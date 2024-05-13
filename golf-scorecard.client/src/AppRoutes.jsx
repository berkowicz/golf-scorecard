import React from 'react';
import Home from './components/Home';
import Home2 from './components/Home2';
import Course from './components/Course';
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
            <Route path="*" element={<Home2 />} />
            {/*<Route path="/selectgame" element={<SelectGame />} />*/}
            {/*<Route path="/course" element={<Course />} />*/}
        </Routes>
    );
};

export default AppRoutes;
