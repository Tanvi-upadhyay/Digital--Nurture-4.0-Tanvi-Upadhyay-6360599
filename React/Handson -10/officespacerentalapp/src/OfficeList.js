import React from 'react';

const OfficeList = () => {
  const offices = [
    {
      name: 'TechPark',
      rent: 55000,
      address: 'MG Road, Bangalore',
      image: 'https://via.placeholder.com/150'
    },
    {
      name: 'StartupHub',
      rent: 75000,
      address: 'Kharadi, Pune',
      image: 'https://via.placeholder.com/150'
    },
    {
      name: 'BizSpace',
      rent: 60000,
      address: 'Cyber City, Gurgaon',
      image: 'https://via.placeholder.com/150'
    }
  ];

  return (
    <div>
      <h1 style={{ textAlign: 'center' }}>Office Space Rentals</h1>
      {offices.map((office, index) => (
        <div key={index} style={{
          border: '1px solid #ccc',
          margin: '10px',
          padding: '10px',
          borderRadius: '8px'
        }}>
          <img src={office.image} alt={office.name} />
          <h2>{office.name}</h2>
          <p>{office.address}</p>
          <p style={{ color: office.rent < 60000 ? 'red' : 'green' }}>
            Rent: ₹{office.rent}
          </p>
        </div>
      ))}
    </div>
  );
};

export default OfficeList;
