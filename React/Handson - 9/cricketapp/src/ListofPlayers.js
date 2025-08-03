// ListofPlayers.js
import React from 'react';

const ListofPlayers = () => {
  const players = [
    { name: 'Virat', score: 85 },
    { name: 'Rohit', score: 90 },
    { name: 'Dhoni', score: 75 },
    { name: 'Hardik', score: 65 },
    { name: 'Bumrah', score: 55 },
    { name: 'Kohli', score: 88 },
    { name: 'Jadeja', score: 62 },
    { name: 'Shami', score: 50 },
    { name: 'Gill', score: 73 },
    { name: 'Surya', score: 95 },
    { name: 'Rahul', score: 60 }
  ];

  const lowScorers = players.filter(player => player.score < 70);

  return (
    <div>
      <h2>All Players</h2>
      <ul>
        {players.map((player, index) => (
          <li key={index}>{player.name} - {player.score}</li>
        ))}
      </ul>
      <h3>Players with score below 70</h3>
      <ul>
        {lowScorers.map((player, index) => (
          <li key={index}>{player.name} - {player.score}</li>
        ))}
      </ul>
    </div>
  );
};

export default ListofPlayers;
