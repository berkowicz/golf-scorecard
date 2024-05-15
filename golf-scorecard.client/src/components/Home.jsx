import React, { useState, useEffect } from 'react';
import axios from 'axios'; // Import Axios
import Tee from "./SelectGameChildren/Tee";
import Course from "./SelectGameChildren/Course";
import Gender from './SelectGameChildren/Gender';
import SelectGame from './SelectGame';
import ScoreScreen from './ScoreScreen';
import Game from './Game';

import Button from 'react-bootstrap/Button';

const apiHostSelect = "https://localhost:7287/api/Select";
const apiHostGame = "https://localhost:7287/api/Game";

const Home = () => {

    //SelectGame
    //const [submitData, setSubmitData] = useState([]);
    const [course, setCourse] = useState(0);
    const [gender, setGender] = useState(0);
    const [tee, setTee] = useState(0);
    const [handicap, setHandicap] = useState(0);
    const [strokes, setStrokes] = useState(0);

    //Create game
    const [gameGUID, setGameGUID] = useState(null)

    //Game constants
    const [gameSelected, setGameSelected] = useState(false);
    const [gameFinished, setGameFinished] = useState(false);

    // Callback function to handle event in SelectGame component
    const selectedGameChildEvent = (data) => {
        // Update parent state based on child event
        setCourse(data.course);
        setTee(data.tee);
        setGender(data.gender);
        setHandicap(data.handicap);
        setStrokes(data.strokes);
        setGameSelected(data.bool); //true
        console.log('course from home: ',data.course)
        console.log('tee from home: ', data.tee)
        console.log('gender from home: ', data.gender)
        console.log('handicap from home: ', data.handicap)
        console.log('strokes from home: ', data.strokes)
    };

    return (
        <div>
          {!gameSelected ? (
                <SelectGame gameSettingsToHome={selectedGameChildEvent} />
            ) : (
                    <>
                        {(gameSelected && !gameFinished) ? <Game course={course} gender={gender} tee={tee} handicap={handicap} strokes={strokes} /> : null}
                {gameFinished ? <ScoreScreen /> : null}
            </>
          )}
        </div>
    )
};

export default Home;
