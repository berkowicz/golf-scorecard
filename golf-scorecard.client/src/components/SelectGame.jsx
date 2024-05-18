import React, { useState, useEffect } from 'react';
import axios from 'axios'; // Import Axios
import Tee from "./SelectGameChildren/Tee";
import Course from "./SelectGameChildren/Course";
import Gender from './SelectGameChildren/Gender';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import Container from 'react-bootstrap/Container';
import '../App.css';

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

    useEffect(() => {
        // Fetch the data when the component mounts
        fetchData();
    }, []);


    const fetchData = async () => {
        try {
            // Fetch data from the API endpoint
            const response = await fetch(apiHost);
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

            return x;
        } catch (error) {
            console.error('Error sending data:', error);
        }
    };

    const handleClick = async () => {

        if (tee != 0 && course != 0 && gender != 0) {
            /*const dataarray = [[tee], [course], [gender], [handicap.tostring()]]*/
            //const data2 = [tee, course, gender, handicap];
            let strokesLocal;

            const x = postData();
            await x.then(result => {
                const value = result; // Assign the resolved value to a constant
                strokesLocal = value;
            });

            const data = {
                bool: true,
                course: course,
                //tee: tee,
                //gender: gender,
                //handicap: handicap,
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



    return (
        <Container fluid="md">
            <h1>Daniel's Golf Scorecard</h1>
            <Form className="align-items-center">
                    <Form.Group className="mb-3">
                        Handicap: {handicap}
                        <Form.Range
                            type="range"
                            step={1}
                            min={0}
                            max={36}
                            value={handicap}
                            onChange={handleHandicapChange}></Form.Range>
                    </Form.Group>

                    <Form.Group className="mb-3">
                        <Course course={course} courses={courses} setCourseChild={handleCourseChange} />
                    </Form.Group>

                    <Form.Group className="mb-3">
                        <Tee tee={tee} tees={tees} setTeeChild={handleTeeChange} />
                    </Form.Group>

                    <Form.Group className="mb-3">
                        <Gender gender={gender} genders={genders} setGenderChild={handleGenderChange} />
                    </Form.Group>

                    <div className="d-grid gap-2">
                        <Button variant="primary" size="lg" onClick={handleClick} type="button" value="input">Start Game</Button>
                    </div>                
            </Form>
        </Container>
    );
};

export default SelectGame;
