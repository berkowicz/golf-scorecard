import React, { useState, useEffect } from 'react';
import axios from 'axios'; // Import Axios
import Tee from "./SelectGameChildren/Tee";
import Course from "./SelectGameChildren/Course";
import Gender from './SelectGameChildren/Gender';
import Button from 'react-bootstrap/Button';

const apiHost = "https://localhost:7287/api/Game";

const Game = ({ course, gender, tee, handicap, strokes }) => {

    // Define state variables to store the data
    console.log(`From Game course:${course}, gender:${gender}, tee:${tee}, hcp:${handicap}, strokes:${strokes}`);

    //useEffect(() => {
    //    // Fetch the data when the component mounts
    //    fetchData();
    //}, []);

    //const fetchData = async () => {
    //    try {
    //        // Fetch data from the API endpoint
    //        const response = await fetch(apiHost); // Replace '/api/data' with your actual API endpoint
    //        //console.log(response.text);
    //        const data = await response.json();
    //        console.log(data);

    //        // Extract and set the data in state variables
    //        setCourses(data.courses);
    //        setGenders(data.genders);
    //        setTees(data.tees);
    //    } catch (error) {
    //        console.error('Error fetching data:', error);
    //    }
    //};



    return (
        <div>
        <p>Hej</p>
        </div>
    );
};

export default Game;
