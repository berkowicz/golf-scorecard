import React, { useState, useEffect } from 'react';
import axios from 'axios'; // Import Axios
import Tee from "./SelectGameChildren/Tee";
import Course from "./SelectGameChildren/Course";
import Gender from './SelectGameChildren/Gender';
import Button from 'react-bootstrap/Button';

const apiHost = "https://localhost:7287/api/Game";

const Game = ({ course, gender, tee, handicap, extraStrokes }) => {

    // Define state variables to store the data
    const [holes, setHoles] = useState([]);
    const [strokes, setStrokes] = useState([])

    const [scores, setScores] = useState(new Array(holes.length).fill(''));

    // Function to handle input change for a specific hole
    const handleScoreChange = (index, event) => {
        const newScores = [...scores];
        newScores[index] = event.target.value; // Update the score for the corresponding hole
        setScores(newScores);
    }; 

    
    useEffect(() => {
        // Fetch the data when the component mounts
        fetchData();
    }, []);

    const fetchData = async () => {
        try {
            // Fetch data from the API endpoint
            const response = await fetch(`${apiHost}/${course}`);

            const data = await response.json();
            console.log('fetch holes: ', data.holes);

            // Extract and set the data in state variables
            setHoles(data.holes);
            console.log(data.holes[1])

        } catch (error) {
            console.error('Error fetching data:', error);
        }
    };



    return (
        <div>
            <h1>Golf Scorecard</h1>
            <table>
                <thead>
                    <tr>
                        <th>Hole</th>
                        <th>Index</th>
                        <th>Par</th>
                        <th>Score</th>
                    </tr>
                </thead>
                <tbody>
                    {holes.map((hole, index) => (
                        <tr key={hole.id}>
                            <td>{hole.number}</td>
                            <td>{hole.holeIndex}</td>
                            <td>{hole.par}</td>
                            <td>
                                <input
                                    type="number"
                                    value={scores[index]}
                                    onChange={(event) => handleScoreChange(index, event)}
                                    min="0"
                                />
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
};

export default Game;
