import React, { useState, useEffect } from 'react';
import axios from 'axios'; // Import Axios
import Tee from "./SelectGameChildren/Tee";
import Course from "./SelectGameChildren/Course";
import Gender from './SelectGameChildren/Gender';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import InputGroup from 'react-bootstrap/InputGroup';

const apiHost = "https://localhost:7287/api/Select";

const SelectGame = ({ onChildEvent }) => {

    // Define state variables to store the data
    const [courses, setCourses] = useState([]);
    const [genders, setGenders] = useState([]);
    const [tees, setTees] = useState([]);
    const [course, setCourse] = useState('');
    const [gender, setGender] = useState('');
    const [tee, setTee] = useState('');
    const [handicap, setHandicap] = useState(18);
    const [submited, setSubmited] = useState(false);
/*    const [submitData, setSubmitData] = useState([[]]);*/


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
            console.log(data);

            // Extract and set the data in state variables
            setCourses(data.courses);
            setGenders(data.genders);
            setTees(data.tees);
        } catch (error) {
            console.error('Error fetching data:', error);
        }
    };


    const handleClick = () => {

        if (tee != '' && course != '' && gender != '') {
            const dataArray = [[tee], [course], [gender], [handicap.toString()]]
            console.log(dataArray);
            /*setSubmited(true);*/
            /*setSubmitData(data);*/

            const data = {
                value1: true,
                value2: dataArray
            };
            onChildEvent(data);
        }
        else {
            console.error('Select all fields');
            return;
        }
    };


    const handleHandicapChange = (event) => {
        setHandicap(event.target.value);
        console.log("handicap: ", event.target.value);
    };

    const handleCourseChange = (course) => {
        setCourse(course);
        console.log("course-id: ", course);
    };

    const handleTeeChange = (tee) => {
        setTee(tee);
        console.log("tee-id: ", tee);
    };

    const handleGenderChange = (gender) => {
        setGender(gender);
        console.log("gender-id: ", gender);
    };



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
