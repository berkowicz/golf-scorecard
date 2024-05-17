import React from 'react';
import Form from 'react-bootstrap/Form';

const Tee = ({ tee, tees, setTeeChild }) => {

    const handleTeeChange = (event) => {
        setTeeChild(event.target.value);
    };
     
    return (
            <Form.Select size="lg" value={tee} onChange={handleTeeChange}>
                <option value="">Select Tee</option>
                {tees.map(tee => (
                    <option key={tee.id} value={tee.id}>{tee.type}</option>
                ))}
            </Form.Select>
    );
};

export default Tee;