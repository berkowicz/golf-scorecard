import React, { useState, useEffect } from 'react';
import axios from 'axios'; // Import Axios
import Tee from "./SelectGameChildren/Tee";
import Course from "./SelectGameChildren/Course";
import Gender from './SelectGameChildren/Gender';
import ScoreCard from './ScoreCard';
import ScoreScreen from './ScoreScreen';
import Button from 'react-bootstrap/Button';


const apiHost = "https://localhost:7287/api/Game";

const Game = ({ course, gender, tee, handicap, extraStrokes }) => {

    // Define state variables to store the data
    const [holes, setHoles] = useState([]);
    const [strokes, setStrokes] = useState([])
    const [gameFinished, setGameFinished] = useState(false);
    const [score, setScore] = useState(0);
    //const result = ["Hole In One", "Albatros", "Eagle", "Birdie", "Par", "Boggey"]

    //const [scores, setScores] = useState(new Array(holes.length).fill(''));

    // Function to handle input change for a specific hole
    //const handleScoreChange = (index, event) => {
    //    const newScores = [...scores];
    //    newScores[index] = event.target.value; // Update the score for the corresponding hole
    //    setScores(newScores);
    //}; 

    
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

    const setFinishedGame = (data) => {
        // Update parent state based on child event
        setScore(data.score);
        setGameFinished(data.bool); //true
        console.log('course from home: ', data.score)
    };



    return (
        <div>
            {!gameFinished ? (
                <ScoreCard holes={holes} submitScoreToGame={setFinishedGame} />
            ) : (
                <>
                        {gameFinished ? <ScoreScreen score={score} holes={holes} strokes={extraStrokes} /> : null}
                </>
            )}

        </div>
        //<div>
        //    <h1>Golf Scorecard</h1>
        //    <table>
        //        <thead>
        //            <tr>
        //                <th>Hole</th>
        //                <th>Index</th>
        //                <th>Par</th>
        //                <th>Score</th>
        //            </tr>
        //        </thead>
        //        <tbody>
        //            {holes.map((hole, index) => (
        //                <tr key={hole.id}>
        //                    <td>{hole.number}</td>
        //                    <td>{hole.holeIndex}</td>
        //                    <td>{hole.par}</td>
        //                    <td>
        //                        <input
        //                            type="number"
        //                            value={scores[index]}
        //                            onChange={(event) => handleScoreChange(index, event)}
        //                            min="0"
        //                        />
        //                    </td>
        //                </tr>
        //            ))}
        //        </tbody>
        //    </table>
        //</div>
    );
};

export default Game;
