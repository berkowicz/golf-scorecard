import React, { useState, useEffect } from 'react';
import axios from 'axios'; // Import Axios
import Tee from "./SelectGameChildren/Tee";
import Course from "./SelectGameChildren/Course";
import Gender from './SelectGameChildren/Gender';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import InputGroup from 'react-bootstrap/InputGroup';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import Container from 'react-bootstrap/Container'
import Table from 'react-bootstrap/Table';
/*import '../App.css';*/

const apiHost = "https://localhost:7287/api/Game";

const ScoreScreen = ({ score, holes, strokes }) => {

    const [comparedToHandicap2, setComparedToHandicap2] = useState(0)
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
        //<div>
        //    <h1>Result</h1>
        //    <table>
        //        <thead>
        //            <tr>
        //                <th>Brutto</th>
        //                <th>Netto</th>
        //                <th>Compared to handicap</th>
        //            </tr>
        //        </thead>
        //        <tbody>
        //            <tr>
        //                <td>{score}</td>
        //                <td>{score - strokes}</td>
        //                <td>{formattedComparedToHandicap}</td>
        //            </tr>
        //        </tbody>
        //    </table>
        //</div>
    );
};

export default ScoreScreen;
