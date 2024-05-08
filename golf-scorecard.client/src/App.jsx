import React from 'react';
//import React, { Component } from 'react';
//import './custom.css';
//import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import { BrowserRouter as Router } from 'react-router-dom';
import AppRoutes from './AppRoutes';
//import { Layout } from './components/Layout';
//import Home from './components/Home';

function App() {
    return (
        <Router>
            <AppRoutes />
        </Router>
    );
}

export default App;
