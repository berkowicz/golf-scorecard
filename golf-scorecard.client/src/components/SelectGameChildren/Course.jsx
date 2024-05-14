import React from 'react';

const Course = ({ course, courses, setCourseChild }) => {

    const handleCourseChange = (event) => {
        setCourseChild(event.target.value);
    };

    /*onChange = { e => setCourseChild(e.target.value) }*/

    return (
        <label>
            <select value={course} onChange={handleCourseChange}>
                <option value="">Select Course</option>
                {courses.map(course => (
                    <option key={course.id} value={course.id}>{course.name}</option>
                ))}
            </select>
        </label>
    );
};




export default Course;