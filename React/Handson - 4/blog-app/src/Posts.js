// src/Posts.js
import React, { Component } from 'react';
import Post from './Post';

class Posts extends Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: []
    };
  }

  // Step 6
  loadPosts() {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then(response => response.json())
      .then(data => {
        const postList = data.map(
          p => new Post(p.userId, p.id, p.title, p.body)
        );
        this.setState({ posts: postList });
      })
      .catch(error => {
        throw new Error('Error fetching posts: ' + error);
      });
  }

  // Step 7
  componentDidMount() {
    this.loadPosts();
  }

  // Step 9
  componentDidCatch(error, info) {
    alert('An error occurred: ' + error.message);
  }

  // Step 8
  render() {
    return (
      <div>
        <h2>Blog Posts</h2>
        {this.state.posts.map(post => (
          <div key={post.id} style={{ marginBottom: '20px' }}>
            <h3>{post.title}</h3>
            <p>{post.body}</p>
          </div>
        ))}
      </div>
    );
  }
}

export default Posts;
