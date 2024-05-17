import React, { useState, useEffect } from 'react';
import axios from 'axios'; // Import Axios
import Tee from "./SelectGameChildren/Tee";
import Course from "./SelectGameChildren/Course";
import Gender from './SelectGameChildren/Gender';
import Button from 'react-bootstrap/Button';

const apiHost = "https://localhost:7287/api/Game";

const Game = ({ holes, submitScoreToGame }) => {

    // Define state variables to store the data
    //const [holesStrokes, setHolesStrokes] = useState([])
    const [sortedIndex, setSortedIndex] = useState([]);
    //const [extraStrokes2, setExtraStrokes2] = useState(new Array(holes.length).fill(0));
    const [scores, setScores] = useState(new Array(holes.length).fill(''));
    const result = ["Quadruple Bogey", "Tripple Bogey", "Double Bogey", "Bogey", "Par", "Birdie", "Eagle", "Albatros", "Hole In One",]

    // Function to handle input change for a specific hole
    const handleScoreChange = (index, event) => {
        const newScores = [...scores];
        newScores[index] = event.target.value; // Update the score for the corresponding hole
        setScores(newScores);
        console.log(scores);
    };

    //Button
    const handleClick = () => {
        //Checks that all 18 scores is input
        if (scores.length == 18) {
            const sum = scores.reduce((accumulator, currentValue) => accumulator + parseInt(currentValue), 0);
            console.log('hej', sum)

            //Sends data to parent(Game)
            const data = {
                bool: true,
                score: sum,
            };
            submitScoreToGame(data);
        }
        else {
            console.log(scores.length)
            console.error('select all fields');
            return;
        }
    }
     


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
                        <th>Result</th>
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
                            <td>{result[hole.par-scores[index]+4]}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
            <Button onClick={handleClick} type="button" value="input">Finish Game</Button>
        </div>
    );
};

export default Game;
