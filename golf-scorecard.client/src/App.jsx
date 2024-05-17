import React from 'react';
import Container from 'react-bootstrap/Container';
//import './custom.css';
import { BrowserRouter as Router } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import 'bootstrap/dist/css/bootstrap.min.css';
//import { Container } from 'reactstrap';

function App() {
    return (
            <Router>
                <AppRoutes />
            </Router>
    );
}

export default App;
