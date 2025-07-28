import React from 'react';
import CohortDetails from './CohortDetails';

function App() {
  const cohorts = [
    { id: 1, name: 'React May 2025', status: 'ongoing', startDate: '2025-05-10', endDate: '2025-08-10' },
    { id: 2, name: 'Node March 2025', status: 'completed', startDate: '2025-03-01', endDate: '2025-06-01' },
  ];

  return (
    <div>
      <h1>Cognizant Academy Cohorts</h1>
      {cohorts.map(c => (
        <CohortDetails key={c.id} {...c} />
      ))}
    </div>
  );
}

export default App;
