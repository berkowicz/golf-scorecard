import React from 'react';

const Gender = ({ gender, genders, setGenderChild }) => {

    const handleGenderChange = (event) => {
        setGenderChild(event.target.value);
    };

    return (
        <label>
            <select value={gender} onChange={handleGenderChange}>
                <option value="">Select Gender</option>
                {genders.map(gender => (
                    <option key={gender.id} value={gender.id}>{gender.type}</option>
                ))}
            </select>
        </label>
    );
};

export default Gender;