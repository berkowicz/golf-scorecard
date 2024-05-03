import React from 'react';

const Gender = ({ value }) => {
    const gender = value; // Genders array

    console.log(value)

    //const handleGenderChange = (event) => {
    //    setGender(event.target.value);
    //};
    //onChange={handleGenderChange}
    return (
        <select value={gender} >
            <option value="">Select Gender</option>
            {gender.map(gender => (
                <option key={gender.id} value={gender.id}>{gender.type}</option>
            ))}
        </select>
    );
};

export default Gender;