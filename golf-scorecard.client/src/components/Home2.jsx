import React, { useState, useEffect } from 'react';
import axios from 'axios'; // Import Axios
import Tee from "./Tee";
import Course from "./Course";
import Gender from './Gender';
import SelectGame from './SelectGame';
import ScoreScreen from './ScoreScreen';
import Game from './Game';

import Button from 'react-bootstrap/Button';

const apiHost = "https://localhost:7287/api/Test";

const Home2 = () => {

    //SelectGame
    const [submitData, setSubmitData] = useState([[]]);


    const [gameSelected, setGameSelected] = useState(false);
    const [gameFinished, setGameFinished] = useState(false);

    // Callback function to handle event in child component
    const handleChildEvent = (data) => {
        // Update parent state based on child event
        setGameSelected(data.value1);
        setSubmitData(data.value2)
        console.log(data.value1)
        console.log(data.value2)
    };


    const handlePlayClick = () => {
        setPlayButton(true);
    };

    const handleComponentToggle = () => {
        setGameSelected(!gameSelected);
    };

    return (
        <div>
          {!gameSelected ? (
                <SelectGame onChildEvent={handleChildEvent} />
            ) : (
            <>
                {(gameSelected && !gameFinished) ? <Game /> : null}
                {gameFinished ? <ScoreScreen /> : null}
            </>
          )}
        </div>
    )
};

export default Home2;
