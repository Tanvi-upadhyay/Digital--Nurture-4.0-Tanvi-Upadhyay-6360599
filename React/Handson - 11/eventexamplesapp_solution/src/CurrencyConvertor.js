import React, { useState } from 'react';

const CurrencyConvertor = () => {
  const [rupees, setRupees] = useState('');
  const [euro, setEuro] = useState('');

  const handleSubmit = () => {
    const value = parseFloat(rupees);
    if (!isNaN(value)) {
      setEuro((value * 0.011).toFixed(2));
    }
  };

  return (
    <div>
      <h3>Currency Convertor</h3>
      <input type="number" value={rupees} onChange={(e) => setRupees(e.target.value)} placeholder="Enter amount in ₹" />
      <button onClick={handleSubmit}>Convert</button>
      <p>Amount in Euro: €{euro}</p>
    </div>
  );
};

export default CurrencyConvertor;
