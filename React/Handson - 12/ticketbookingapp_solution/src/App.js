import React, { Component } from 'react';
import Guest from './Guest';
import User from './User';

class App extends Component {
  constructor() {
    super();
    this.state = {
      isLoggedIn: false
    };
  }

  handleLogin = () => {
    this.setState({ isLoggedIn: true });
  };

  handleLogout = () => {
    this.setState({ isLoggedIn: false });
  };

  render() {
    const { isLoggedIn } = this.state;
    let content;

    if (isLoggedIn) {
      content = <User />;
    } else {
      content = <Guest />;
    }

    return (
      <div>
        <h1>Ticket Booking App</h1>
        {isLoggedIn ? (
          <button onClick={this.handleLogout}>Logout</button>
        ) : (
          <button onClick={this.handleLogin}>Login</button>
        )}
        {content}
      </div>
    );
  }
}

export default App;
