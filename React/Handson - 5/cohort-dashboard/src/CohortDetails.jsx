import React from 'react';
import styles from './CohortDetails.module.css';

const CohortDetails = ({ name, status, startDate, endDate }) => {
  const h3Color = status.toLowerCase() === 'ongoing' ? 'green' : 'blue';

  return (
    <div className={styles.box}>
      <h3 style={{ color: h3Color }}>{name}</h3>
      <dl>
        <dt>Status</dt>
        <dd>{status}</dd>

        <dt>Start</dt>
        <dd>{startDate}</dd>

        <dt>End</dt>
        <dd>{endDate}</dd>
      </dl>
    </div>
  );
};

export default CohortDetails;
