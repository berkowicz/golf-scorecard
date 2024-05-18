import React from 'react';
import Form from 'react-bootstrap/Form';

const Course = ({ course, courses, setCourseChild }) => {

    const handleCourseChange = (event) => {
        setCourseChild(event.target.value);
    };

    return (
            <Form.Select size="lg" value={course} onChange={handleCourseChange}>
                <option value="">Select Course</option>
                {courses.map(course => (
                    <option key={course.id} value={course.id}>{course.name}</option>
                ))}
            </Form.Select>
    );
};




export default Course;