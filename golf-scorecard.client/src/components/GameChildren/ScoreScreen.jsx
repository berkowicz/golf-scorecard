import React, { useState, useEffect } from 'react';
import Container from 'react-bootstrap/Container'
import Table from 'react-bootstrap/Table';

const apiHost = "https://localhost:7287/api/Game";

const ScoreScreen = ({ score, holes, strokes }) => {

    const [totalPar, setTotalPar] = useState(0);

    const netto = score - strokes;
    const comparedToHandicap = netto - totalPar;
    console.log(comparedToHandicap)

    const formattedComparedToHandicap = comparedToHandicap > 0 ? `+${comparedToHandicap}` : comparedToHandicap.toString();

    console.log(formattedComparedToHandicap);

    useEffect(() => {
        // Calculate totalPar when the component mounts
        const calculateTotalPar = () => {
            let total = 0;
            holes.forEach(hole => {
                total += hole.par;
            });
            setTotalPar(total);
            console.log(total); // Log totalPar
        };

        calculateTotalPar();
    }, [holes]);


    return (
        <Container>
        <Table striped bordered hover>
            <thead>
                <tr>
                    <th colSpan={2}>Results</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Brutto: </td>
                    <td>{score}</td>
                </tr>
                <tr>
                    <td>Netto: </td>
                    <td>{netto}</td>
                </tr>
                <tr>
                    <td>Hcp +/-: </td>
                    <td>{formattedComparedToHandicap}</td>
                </tr>
            </tbody>
            </Table>
        </Container>
    );
};

export default ScoreScreen;
