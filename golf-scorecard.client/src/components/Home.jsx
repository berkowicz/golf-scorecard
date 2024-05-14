import React, { useState, useEffect } from 'react';
import axios from 'axios'; // Import Axios
import Tee from "./SelectGameChildren/Tee";
import Course from "./SelectGameChildren/Course";
import Gender from './SelectGameChildren/Gender';
import SelectGame from './SelectGame';
import ScoreScreen from './ScoreScreen';
import Game from './Game';

import Button from 'react-bootstrap/Button';

const apiHost = "https://localhost:7287/api/Select";

const Home = () => {

    //SelectGame
    const [submitData, setSubmitData] = useState([[]]);

    //Game constants
    const [gameSelected, setGameSelected] = useState(false);
    const [gameFinished, setGameFinished] = useState(false);

    // Callback function to handle event in SelectGame component
    const selectedGameChildEvent = (data) => {
        // Update parent state based on child event
        setGameSelected(data.value1); //true
        setSubmitData(data.value2)
        console.log(data.value1)
        console.log(data.value2)
    };


    return (
        <div>
          {!gameSelected ? (
                <SelectGame onChildEvent={selectedGameChildEvent} />
            ) : (
            <>
                {(gameSelected && !gameFinished) ? <Game /> : null}
                {gameFinished ? <ScoreScreen /> : null}
            </>
          )}
        </div>
    )
};

export default Home;
