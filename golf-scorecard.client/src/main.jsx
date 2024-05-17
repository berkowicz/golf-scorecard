import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App.jsx'
import './index.css'
import 'bootstrap/dist/css/bootstrap.min.css';
import Container from 'react-bootstrap/Container';
import './App.css';


ReactDOM.createRoot(document.getElementById('root')).render(
    <React.StrictMode>
        <Container>
            <App />
        </Container>
  </React.StrictMode>,
)
