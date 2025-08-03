// IndianPlayers.js
import React from 'react';

const IndianPlayers = () => {
  const team = ['Virat', 'Rohit', 'Dhoni', 'Hardik', 'Bumrah', 'Kohli'];
  const oddTeam = team.filter((_, index) => index % 2 === 0);
  const evenTeam = team.filter((_, index) => index % 2 !== 0);

  const T20players = ['Rishabh', 'Iyer', 'Pandya'];
  const RanjiTrophyPlayers = ['Pujara', 'Saha'];

  // Merge using ES6 spread
  const mergedPlayers = [...T20players, ...RanjiTrophyPlayers];

  return (
    <div>
      <h2>Odd Team Players</h2>
      <ul>
        {oddTeam.map((player, idx) => <li key={idx}>{player}</li>)}
      </ul>

      <h2>Even Team Players</h2>
      <ul>
        {evenTeam.map((player, idx) => <li key={idx}>{player}</li>)}
      </ul>

      <h2>Merged Players</h2>
      <ul>
        {mergedPlayers.map((player, idx) => <li key={idx}>{player}</li>)}
      </ul>
    </div>
  );
};

export default IndianPlayers;
