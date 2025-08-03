import React, { useState } from 'react'
import BookDetails from './components/BookDetails'
import BlogDetails from './components/BlogDetails'
import CourseDetails from './components/CourseDetails'

export default function App() {
  const [view, setView] = useState('book')
  const isCourse = view === 'course'

  let content
  if (view === 'book') {
    content = <BookDetails />
  } else if (view === 'blog') {
    content = <BlogDetails />
  } else {
    content = <CourseDetails />
  }

  const renderSwitch = (param) => {
    switch (param) {
      case 'book': return <BookDetails />
      case 'blog': return <BlogDetails />
      case 'course': return <CourseDetails />
      default: return <h3>Select a view</h3>
    }
  }

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial' }}>
      <h1>Blogger App - Conditional Rendering</h1>
      <div>
        <button onClick={() => setView('book')}>Book</button>
        <button onClick={() => setView('blog')}>Blog</button>
        <button onClick={() => setView('course')}>Course</button>
      </div>

      <h2>1. If / Else</h2>
      {content}

      <h2>2. Ternary Operator</h2>
      {view === 'book' ? <BookDetails /> : <BlogDetails />}

      <h2>3. Logical AND (&&)</h2>
      {isCourse && <CourseDetails />}

      <h2>4. Switch Case</h2>
      {renderSwitch(view)}

      <h2>5. Element Variable</h2>
      {content}
    </div>
  )
}
