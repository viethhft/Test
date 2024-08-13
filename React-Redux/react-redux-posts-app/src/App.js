import React from 'react';
import { BrowserRouter as Router, Route, Routes, Link, Navigate } from 'react-router-dom';
import PostForm from './features/posts/PostForm';
import PostList from './features/posts/PostList';

function App() {
  return (
    <Router>
      <div className="App">
        <ul className="nav-menu">
          <li><Link to="/post-form">Post Form</Link></li>
          <li><Link to="/post-list">Post List</Link></li>
        </ul>

        <Routes>
          <Route path="/" element={<Navigate to="/post-form" />} /> 
          <Route path="/post-form" element={<PostForm />} />
          <Route path="/post-list" element={<PostList />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
