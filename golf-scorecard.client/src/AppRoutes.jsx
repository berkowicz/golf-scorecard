import React from 'react';
import Home from './components/Home';
import Course from './components/Course';
import { Route, Routes } from 'react-router-dom';

//const AppRoutes = [
//  {
//    index: true,
//    element: <Home />
//  },
//  {
//    path: "/Home",
//    element: <Home />
//  },
//  {
//    path: "/course",
//    element: <Course />
//  },
//];

const AppRoutes = () => {
    return (
        <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/home" element={<Home />} />
            <Route path="/course" element={<Course />} />
        </Routes>
    );
};

export default AppRoutes;
