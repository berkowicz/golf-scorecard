import React, { useState, useEffect } from 'react';
import axios from 'axios'; // Import Axios
import Tee from "./Tee";
import Course from "./Course";
import Gender from './Gender';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import InputGroup from 'react-bootstrap/InputGroup';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import Container from 'react-bootstrap/Container'

const apiHost = "https://localhost:7287/api/Test";

const ScoreScreen = ({ onChildEvent }) => {



    return (
        <div>
            <p>ScoreScreen</p>
        </div>
    );
};

export default ScoreScreen;
