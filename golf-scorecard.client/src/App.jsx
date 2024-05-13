import React from 'react';
import Container from 'react-bootstrap/Container';
//import './custom.css';
import { BrowserRouter as Router } from 'react-router-dom';
import AppRoutes from './AppRoutes';
//import { Container } from 'reactstrap';

function App() {
    return (
            <Container>
                <Router>
                    <AppRoutes />
                </Router>
            </Container>
    );
}

export default App;
