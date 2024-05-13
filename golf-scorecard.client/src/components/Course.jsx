import React from 'react';

const Course = ({ course, courses }) => {
    //const courses = value; // courses array
    //const course = value2;
    console.log(course);
    console.log(courses);

    const handleCourseChange = (event) => {
        setCourse(event.target.value);
        console.log(event.target.value);
    };

    return (
        <select value={course} onChange={handleCourseChange}>
            <option value="">Select Course</option>
            {courses.map(course => (
                <option key={course.id} value={course.id}>{course.name}</option>
            ))}
        </select>
    );
};

//const Course = () => {
//    const courses = "value"; // Courses array
//    console.log(courses);

//    return (
//        <div>
//            <p>{courses}</p>
//        </div>
//    );
//};

export default Course;