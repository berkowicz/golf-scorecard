import React, { useState, useEffect } from 'react';
import axios from 'axios'; // Import Axios
import Tee from "./Tee";
import Course from "./Course";
import Gender from './Gender';

const apiHost = "/api/Test";

const GolfStartScreen = () => {

    // Define state variables to store the data
    const [courses, setCourses] = useState([]);
    const [genders, setGenders] = useState([]);
    const [tees, setTees] = useState([]);
    const [course, setCourse] = useState([]);
    const [gender, setGender] = useState('');
    const [tee, setTee] = useState('');
    const [handicap, setHandicap] = useState('');

    useEffect(() => {
        // Fetch the data when the component mounts
        fetchData();
    }, []);

    const fetchData = async () => {
        try {
            // Fetch data from the API endpoint
            const response = await fetch('https://localhost:7287/api/Test'); // Replace '/api/data' with your actual API endpoint
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
    };

    //const handleCourseChange = (event) => {
    //    setCourse(event.target.value);
    //  console.log(event.target.value);
    //};

    const handleTeeChange = (event) => {
        setTee(event.target.value);
        console.log(event.target.value);
    };

    const handleGenderChange = (event) => {
        setGender(event.target.value);
        console.log(event.target.value);
    };

    const handleSubmit = (event) => {
        event.preventDefault();
        // Handle form submission
    };

    return (
        <div>
            {/*<Course value={data.courses} />*/}
            {/*<Gender value={genders} />*/}
            {/*<Tee value={tees} />*/}
            <h1>Golf Start Screen</h1>
            <form onSubmit={handleSubmit}>
                <label>
                    Handicap:
                    <input type="text" value={handicap} onChange={handleHandicapChange} />
                </label>
                <br />
                <label>
                    Course:                    
                    {/*<Course value={courses} />*/}
                    <select value={courses} onChange={e => setCourse(e.target.value)}>
                        <option value="">Select Course</option>
                        {courses.map(course => (
                            <option key={course.id} value={course.id}>{course.name}</option>
                        ))}
                    </select>
                </label>
                <br />
                <label>
                    Tee:
                    {/*<Tee value={tees} />*/}
                    <select value={tees} onChange={handleTeeChange}>
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
                    <select value={genders} onChange={handleGenderChange}>
                        <option value="">Select Gender</option>
                        {genders.map(gender => (
                            <option key={gender.id} value={gender.id}>{gender.type}</option>
                        ))}
                    </select>
                </label>
                <br />
                <button type="submit">Start Game</button>
            </form>
        </div>
    );
};

export default GolfStartScreen;
