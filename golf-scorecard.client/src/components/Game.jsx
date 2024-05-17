import React, { useState, useEffect } from 'react';
import ScoreCard from './ScoreCard';
import ScoreScreen from './ScoreScreen';

const apiHost = "https://localhost:7287/api/Game";

const Game = ({ course, extraStrokes }) => {

    // Define state variables to store the data
    const [holes, setHoles] = useState([]);
    const [gameFinished, setGameFinished] = useState(false);
    const [score, setScore] = useState(0);
    
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
    );
};

export default Game;
