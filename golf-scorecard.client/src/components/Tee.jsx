import React from 'react';

const Tee = ({ value }) => {
    const tee = value; // Tees array

    console.log(tee)

    //const handleTeeChange = (event) => {
    //    setTee(event.target.value);
    //};
     
    return (
        <select value={tee}>
            <option value="">Select Tee</option>
            {tee.map(tee => (
                <option key={tee.id} value={tee.id}>{tee.type}</option>
            ))}
        </select>
    );
};

export default Tee;