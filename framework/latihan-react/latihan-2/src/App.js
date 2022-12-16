import React, {Component} from 'react';
import { BrowserRouter as Router, Route, Link, Routes } from 'react-router-dom';
import logo from './logo_unri.png';
import './App.css';
import User from './User';
import Blog from './Blog';
import Account from './Account';

class App extends Component{
  render() {
    return (
      <Router>
      <div>
        <Link to="/">|Home|</Link>
        <Link to="/account">|Account|</Link>
        <Link to="/blog">|Blog|</Link>
        <hr/>
        <img src={logo} className="App-logo" alt="logo" />
        <Routes>
          <Route exact path="/" element={<User/>}/>
        <Route path="/blog" element={<Blog/>}/>
        <Route path="/account" element={<Account/>}/>
        </Routes>
        </div>
        </Router>
      );
    }
  }
export default App;
