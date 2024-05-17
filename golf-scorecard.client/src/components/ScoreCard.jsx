import React, { useState} from 'react';
import Button from 'react-bootstrap/Button';
import Container from 'react-bootstrap/Container';
import Table from 'react-bootstrap/Table';
import '../App.css';

const apiHost = "https://localhost:7287/api/Game";

const ScoreCard = ({ holes, submitScoreToGame }) => {

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
        <Container>
            <Table responsive striped bordered hover >
                <thead>
                    <tr>
                        <th colSpan={19}>In</th>
                    </tr>
                    <tr>
                        <td>Hole</td>
                        {holes.map((hole) => (
                            hole.id < 10 && <td key={hole.id}>{hole.number}</td>
                        ))}
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Index</td>
                        {holes.map((hole) => (
                            hole.id < 10 && <td key={hole.id}>{hole.holeIndex}</td>
                        ))}
                    </tr>
                    <tr>
                        <td>Par</td>
                        {holes.map((hole) => (
                            hole.id < 10 && <td key={hole.id}>{hole.par}</td>
                        ))}
                    </tr>
                    <tr>
                        <td>Score</td>
                        {holes.map((hole, index) => (
                            hole.id < 10 && <td key={hole.id}>
                                <input class="center"
                                    type="number"
                                    value={scores[index]}
                                    onChange={(event) => handleScoreChange(index, event)}
                                    min="0"
                                    data-bs-theme="light"
                                />
                            </td>
                        ))}
                    </tr>
                    <tr>
                        <td>Result</td>
                        {holes.map((hole) => (
                            hole.id < 10 && <td key={hole.id}>{result[hole.par - scores[hole.id-1] + 4]}</td>
                        ))}
                    </tr>
                </tbody>
            </Table>


            <Table responsive striped bordered hover >
                <thead>
                    <tr>
                        <th colSpan={19}>Out</th>
                    </tr>
                    <tr>
                        <td>Hole</td>
                        {holes.map((hole) => (
                            hole.id > 9 && <td key={hole.id}>{hole.number}</td>
                        ))}
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Index</td>
                        {holes.map((hole) => (
                            hole.id > 9 && <td key={hole.id}>{hole.holeIndex}</td>
                        ))}
                    </tr>
                    <tr>
                        <td>Par</td>
                        {holes.map((hole) => (
                            hole.id > 9 && <td key={hole.id}>{hole.par}</td>
                        ))}
                    </tr>
                    <tr>
                        <td>Score</td>
                        {holes.map((hole, index) => (
                            hole.id > 9 && <td key={hole.id}>
                                <input
                                    type="number"
                                    value={scores[index]}
                                    onChange={(event) => handleScoreChange(index, event)}
                                    min="0"
                                    class="center"
                                />
                            </td>
                        ))}
                    </tr>
                    <tr>
                        <td>Result</td>
                        {holes.map((hole) => (
                            hole.id > 9 && <td key={hole.id}>{result[hole.par - scores[hole.id - 1] + 4]}</td>
                        ))}
                    </tr>
                </tbody>
            </Table>
            <Button variant="primary" size="lg" onClick={handleClick} type="button" value="input">Finish Game</Button>
        </Container>
    );
};

export default ScoreCard;
