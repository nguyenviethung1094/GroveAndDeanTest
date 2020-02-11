import React, { Component } from 'react';
import Contacts from './components/contact';
import { getAllUser } from './api';


class App extends Component {
  state = {
    contacts: []
  }

  componentDidMount() {
    getAllUser().then(users => {
      this.setState({ contacts: users })
    })
  }


  render() {
    return (
      <Contacts contacts={this.state.contacts} />
    )
  }
}

export default App;
