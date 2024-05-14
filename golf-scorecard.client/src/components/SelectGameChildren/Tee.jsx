import React from 'react';

const Tee = ({ tee, tees, setTeeChild }) => {

    const handleTeeChange = (event) => {
        setTeeChild(event.target.value);
    };
     
    return (
        <label>
            <select value={tee} onChange={handleTeeChange}>
                <option value="">Select Tee</option>
                {tees.map(tee => (
                    <option key={tee.id} value={tee.id}>{tee.type}</option>
                ))}
            </select>
        </label>
    );
};

export default Tee;