import React, { Component } from 'react';
import CurrencyConvertor from './CurrencyConvertor';

class App extends Component {
  constructor() {
    super();
    this.state = {
      count: 0
    };
  }

  increment = () => {
    this.setState({ count: this.state.count + 1 });
    this.sayHello();
  };

  decrement = () => {
    this.setState({ count: this.state.count - 1 });
  };

  sayHello = () => {
    console.log('Hello! Static message after increment.');
  };

  sayWelcome = (message) => {
    alert(message);
  };

  handleClick = (e) => {
    alert("I was clicked");
  };

  render() {
    return (
      <div>
        <h1>React Event Handling</h1>
        <p>Count: {this.state.count}</p>
        <button onClick={this.increment}>Increment</button>
        <button onClick={this.decrement}>Decrement</button>

        <br /><br />
        <button onClick={() => this.sayWelcome("Welcome")}>Say Welcome</button>

        <br /><br />
        <button onClick={this.handleClick}>Synthetic Event (OnPress)</button>

        <br /><br />
        <CurrencyConvertor />
      </div>
    );
  }
}

export default App;
