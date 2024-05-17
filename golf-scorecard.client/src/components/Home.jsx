import React, { useState, useEffect } from 'react';
import SelectGame from './SelectGame';
import ScoreScreen from './ScoreScreen';
import Game from './Game';

const Home = () => {

    //SelectGame
    //const [submitData, setSubmitData] = useState([]);
    const [course, setCourse] = useState(0);
    //const [gender, setGender] = useState(0);
    //const [tee, setTee] = useState(0);
    //const [handicap, setHandicap] = useState(0);
    const [extraStrokes, setExtraStrokes] = useState(0);

    //Game constants
    const [gameSelected, setGameSelected] = useState(false);

    // Callback function to handle event in SelectGame component
    const selectedGameChildEvent = (data) => {
        setCourse(data.course);
        //setTee(data.tee);
        //setGender(data.gender);
        //setHandicap(data.handicap);
        setExtraStrokes(data.strokes);
        setGameSelected(data.bool); //true
    };

    return (
        <div>
          {!gameSelected ? (
                <SelectGame gameSettingsToHome={selectedGameChildEvent} />
            ) : (
            <>
                {(gameSelected) ? <Game course={course} extraStrokes={extraStrokes} /> : null}
                
            </>
          )}
        </div>
    )
};

export default Home;
