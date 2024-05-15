import React, { useState, useEffect } from 'react';
import axios from 'axios'; // Import Axios
import Tee from "./SelectGameChildren/Tee";
import Course from "./SelectGameChildren/Course";
import Gender from './SelectGameChildren/Gender';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import InputGroup from 'react-bootstrap/InputGroup';

let config = { headers: {} };

const apiHost = "https://localhost:7287/api/Select";

const SelectGame = ({ gameSettingsToHome }) => {

    // Define state variables to store the data
    const [courses, setCourses] = useState([]);
    const [genders, setGenders] = useState([]);
    const [tees, setTees] = useState([]);
    const [course, setCourse] = useState(0);
    const [gender, setGender] = useState(0);
    const [tee, setTee] = useState(0);
    const [handicap, setHandicap] = useState(18);
    const [submitData, setSubmitData] = useState([]);
    const [strokes, setStrokes] = useState(0);

    useEffect(() => {
        // Fetch the data when the component mounts
        fetchData();
    }, []);


    const fetchData = async () => {
        try {
            // Fetch data from the API endpoint
            const response = await fetch(apiHost); // Replace '/api/data' with your actual API endpoint
            //console.log(response.text);
            const data = await response.json();

            // Extract and set the data in state variables
            await setCourses(data.courses);
            await setGenders(data.genders);
            await setTees(data.tees);
        } catch (error) {
            console.error('Error fetching data:', error);
        }
    };


    const postData = async () => {
        try {
            const response = await axios.post(`${apiHost}/${tee}/${course}/${gender}/${handicap}`);
            const data = response.data;

            const x = data.strokes;

            await setStrokes(x)

            return x;
        } catch (error) {
            console.error('Error sending data:', error);
        }
    };

    const handleClick = async () => {

        if (tee != 0 && course != 0 && gender != 0) {
            /*const dataarray = [[tee], [course], [gender], [handicap.tostring()]]*/
            const data2 = [tee, course, gender, handicap];
            let strokesLocal;

            await setSubmitData(data2);

            const x = postData();
            await x.then(result => {
                const value = result; // Assign the resolved value to a constant
                strokesLocal = value;
            });

            const data = {
                bool: true,
                course: course,
                tee: tee,
                gender: gender,
                handicap: handicap,
                strokes: strokesLocal
            };
            console.log(x)
            await gameSettingsToHome(data);
        }
        else {
            console.error('select all fields');
            return;
        }
    };


    const handleHandicapChange = (event) => {
        setHandicap(parseInt(event.target.value));
        console.log("handicap: ", event.target.value);
    };

    const handleCourseChange = (course) => {
        setCourse(parseInt(course));
        console.log("course-id: ", course);
    };

    const handleTeeChange = (tee) => {
        setTee(parseInt(tee));
        console.log("tee-id: ", tee);
    };

    const handleGenderChange = (gender) => {
        setGender(parseInt(gender));
        console.log("gender-id: ", gender);
    };


    //const postData = async () => {

    //    //const response = await axios.post(`${apiHost}/${tee}/${course}/${gender}/${handicap}`);
    //    //console.log('Response from backend:', response.data);
    //    const response = await fetch(`${apiHost}/${tee}/${course}/${gender}/${handicap}`, {
    //            method: 'POST'})
    //        .then((response) => response.json())


    //        console.log(response)

    //};


    //const handleClick = () => {
    //    // Example submitData array
    //    //const submitData2 = [parseInt(tee), parseInt(course), parseInt(gender), parseInt(handicap)];
    //    ////const submitData2 = [tee, course, gender, handicap]; // Assuming these values are defined in your component's state
    //    //console.log(submitData2)
    //    postData();
    //};




    //const postData = async () => {
    //    // POST request using fetch with async/await
    //    const requestOptions = {
    //        method: 'POST',
    //        headers: { 'Content-Type': 'application/json' },
    //        body: JSON.stringify({ title: 'React POST Request Example' })
    //    };
    //    const response = await fetch('https://reqres.in/api/posts', requestOptions);
    //    const data = await response.json();
    //    this.setState({ postId: data.id });
    //}


    //const SendGuess = async () => {
    //    //Add put method to header config
    //    let putConfig = {
    //        ...config,
    //        method: "PUT",
    //    };

    //    const response = await fetch(`${apiHost}`, putConfig)
    //        .then((response) => response.json())
    //        .then((result) => {

    //            //Work around to make the json in same PascalCasing
    //            const resultWithUppercaseKeys = Object.keys(result).reduce(
    //                (acc, key) => {
    //                    acc[key.charAt(0).toUpperCase() + key.slice(1)] = result[key];
    //                    return acc;
    //                },
    //                {}
    //            );

    //            if (result.correct) {
    //                setGameFinished(true);
    //            }

    //            setAttempts((prevAttempts) => [
    //                ...prevAttempts,
    //                JSON.stringify(resultWithUppercaseKeys),
    //            ]);
    //            setCorrectWord(result.word);
    //        });

    //    setGuess("");
    //};


    //const postData = async () => {
    //    try {

    //        // Make the POST request to create new data
    //        const requestOptions = {
    //            method: 'POST',
    //            headers: { 'Content-Type': 'application/json' },
    //            body: JSON.stringify({ handicap, gender, course, tee })
    //        };
    //        const response = await fetch(apiHost, requestOptions)
    //        //    {
    //        //    method: 'POST',
    //        //    headers: {
    //        //        'Content-Type': 'application/json', // Assuming JSON data
    //        //    },
    //        //    body: JSON.stringify(submitData), // Convert requestData to JSON string
    //        //});
    //        const createdData = await response.json();
    //        newGameID(createdData)
    //        console.log('Data created:', createdData);
    //    } catch (error) {
    //        console.error('Error creating data:', error);
    //    }
    //}

    return (
        <div>
            <h1>Golf Start Screen</h1>
            <Form>
                <Form.Group className="mb-3">
                    <Form.Label column="lg" lg={2}>
                        Handicap:
                    </Form.Label>
                    <Form.Range
                        type="range"
                        step={1}
                        min={0}
                        max={36}
                        value={handicap}
                        onChange={handleHandicapChange} />
                    {handicap}
                </Form.Group>

                <InputGroup className="mb-3">
                    Course:
                    <Course course={course} courses={courses} setCourseChild={handleCourseChange} />
                </InputGroup>

                <InputGroup className="mb-3">
                    Tee:
                    <Tee tee={tee} tees={tees} setTeeChild={handleTeeChange} />
                </InputGroup>

                <InputGroup className="mb-3">
                    Gender:
                    <Gender gender={gender} genders={genders} setGenderChild={handleGenderChange} />
                </InputGroup>

                <Button onClick={handleClick} type="button" value="input">Start Game</Button>
            </Form>
        </div>
    );
};

export default SelectGame;
