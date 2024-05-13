import React, { useState, useEffect } from 'react';
import axios from 'axios'; // Import Axios
import Tee from "./Tee";
import Course from "./Course";
import Gender from './Gender';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import InputGroup from 'react-bootstrap/InputGroup';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import Container from 'react-bootstrap/Container'

const apiHost = "https://localhost:7287/api/Test";

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



    const handleClick = () => {
        //const data2 = [tee, course, gender, handicap]
        const dataArray = [[tee], [course], [gender], [handicap.toString()]]
        console.log(dataArray);
            /*setSubmited(true);*/
            /*setSubmitData(data);*/

        const data = {
            value1: true,
            value2: dataArray
        };
        onChildEvent(data);

            /*onChildEvent(true, data);*/
        // Trigger callback function passed from parent
    };

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

    const handleHandicapChange = (event) => {
        setHandicap(event.target.value);
        console.log("handicap: ", event.target.value);
    };

    const handleCourseChange = (event) => {
        setCourse(event.target.value);
        console.log("course-id: ", event.target.value);
    };

    const handleTeeChange = (event) => {
        setTee(event.target.value);
        if (tee != '') {
            console.log("tee-id: ", event.target.value);
        }
    };

    const handleGenderChange = (event) => {
        setGender(event.target.value);
        console.log("gender-id: ", event.target.value);
    };

    //const handleSubmit = async (event) => {
    //    event.preventdefault();
    //    if (tee != '' || course != '' || gender != '' || handicap != '') {
    //        setSubmited(true);
    //        const data2 = [tee, course, gender, handicap]
    //        const data = [[tee], [course], [gender], [handicap]]
    //        console.log(data2, data)
    //        setSubmitData(data)
    //    }
    //    else {
    //        console.error('Select all fields:', error);
    //        return;
    //    }
    //    event.PreventDefault();
    //    // handle form submission
    //};


    return (
        <div>
            {/*<Course value={data.courses} />*/}
            {/*<Gender value={genders} />*/}
            {/*<Tee value={tees} />*/}
            <h1>Golf Start Screen</h1>
            <Form onSubmit={handleClick}>
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
                    <label>
                        Course:
                        {/*onChange={e => setCourse(e.target.value)}*/}
                        {/*<Course value={course, courses} />*/}
                        <select value={course} onChange={handleCourseChange}>
                            <option value="">Select Course</option>
                            {courses.map(course => (
                                <option key={course.id} value={course.id}>{course.name}</option>
                            ))}
                        </select>
                    </label>
                </InputGroup>

                <label>
                    Tee:
                    {/*<Tee value={tees} />*/}
                    <select value={tee} onChange={handleTeeChange}>
                        <option value="">Select Tee</option>
                        {tees.map(tee => (
                            <option key={tee.id} value={tee.id}>{tee.type}</option>
                        ))}
                    </select>
                </label>
                <br />
                <label>
                    Gender:
                    {/*<Gender value={genders} />*/}
                    <select value={gender} onChange={handleGenderChange}>
                        <option value="">Select Gender</option>
                        {genders.map(gender => (
                            <option key={gender.id} value={gender.id}>{gender.type}</option>
                        ))}
                    </select>
                </label>
                <br />
                <Button  type="submit" value="Submit">Start Game</Button>
                {/*<Button onClick={handleClick} type="click">Start Game</Button>*/}
                {/*<button type="submit">Start Game</button>*/}
            </Form>






                {/*<Form onSubmit={handleSubmit, handleClick}>*/}
                {/*<Form.Group className="mb-3">*/}
                {/*<Form.Label column="lg" lg={2}>*/}
                {/*    Handicap:*/}
                {/*</Form.Label>*/}
                {/*<Form.Range*/}
                {/*    type="range"*/}
                {/*    step={1}*/}
                {/*    min={0}*/}
                {/*    max={36}*/}
                {/*    value={handicap}*/}
                {/*    onChange={handleHandicapChange} />*/}
                {/*    {handicap}*/}
                {/*</Form.Group>*/}

                {/*<InputGroup className="mb-3">*/}
                {/*<label>*/}
                {/*    Course:*/}
                {/*    */}{/*onChange={e => setCourse(e.target.value)}*/}
                {/*    */}{/*<Course value={course, courses} />*/}
                {/*    <select value={course} onChange={handleCourseChange}>*/}
                {/*        <option value="">Select Course</option>*/}
                {/*        {courses.map(course => (*/}
                {/*            <option key={course.id} value={course.id}>{course.name}</option>*/}
                {/*        ))}*/}
                {/*    </select>*/}
                {/*    </label>*/}
                {/*    </InputGroup>*/}

                {/*<label>*/}
                {/*    Tee:*/}
                {/*    */}{/*<Tee value={tees} />*/}
                {/*    <select value={tee} onChange={handleTeeChange}>*/}
                {/*        <option value="">Select Tee</option>*/}
                {/*        {tees.map(tee => (*/}
                {/*            <option key={tee.id} value={tee.id}>{tee.type}</option>*/}
                {/*        ))}*/}
                {/*    </select>*/}
                {/*</label>*/}
                {/*<br />*/}
                {/*<label>*/}
                {/*    Gender:*/}
                {/*    */}{/*<Gender value={genders} />*/}
                {/*    <select value={gender} onChange={handleGenderChange}>*/}
                {/*        <option value="">Select Gender</option>*/}
                {/*        {genders.map(gender => (*/}
                {/*            <option key={gender.id} value={gender.id}>{gender.type}</option>*/}
                {/*        ))}*/}
                {/*    </select>*/}
                {/*</label>*/}
                {/*<br />*/}
                {/*<Button type="submit">Start Game</Button>*/}
                {/*<button type="submit">Start Game</button>*/}
                {/*</Form>*/}
        </div>
    );
};

export default SelectGame;
