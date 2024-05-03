import React from 'react';

const Course = ({ value }) => {
    const course = value; // Courses array

    console.log(course);

    //const handleCourseChange = (event) => {
    //    setCourse(event.target.value);
    //};
    //onChange={handleCourseChange}
    return (
        <select value={course} >
            <option value="">Select Course</option>
            {course.map(course => (
                <option key={course.id} value={course.id}>{course.name}</option>
            ))}
        </select>
    );
};

export default Course;