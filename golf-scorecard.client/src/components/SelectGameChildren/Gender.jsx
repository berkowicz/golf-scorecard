import React from 'react';
import Form from 'react-bootstrap/Form';

const Gender = ({ gender, genders, setGenderChild }) => {

    const handleGenderChange = (event) => {
        setGenderChild(event.target.value);
    };

    return (
            <Form.Select size="lg" value={gender} onChange={handleGenderChange}>
                <option value="">Select Gender</option>
                {genders.map(gender => (
                    <option key={gender.id} value={gender.id}>{gender.type}</option>
                ))}
            </Form.Select>
    );
};

export default Gender;