import React from 'react';
import Home from './components/Home';
import Home2 from './components/Home';
import Course from './components/SelectGameChildren/Course';
import SelectGame from './components/SelectGame';
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
            <Route path="*" element={<Home />} />
            {/*<Route path="/selectgame" element={<SelectGame />} />*/}
            {/*<Route path="/course" element={<Course />} />*/}
        </Routes>
    );
};

export default AppRoutes;
