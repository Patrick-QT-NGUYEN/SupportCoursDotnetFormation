import './App.css';
import {BrowserRouter, Routes, Route} from 'react-router-dom'
import Home from './views/HomeView/Home';
import About from './views/AboutView/About';


function App() {
  return (
    <div className="App">
      <BrowserRouter>
          <Routes>
            <Route path="/" element={<Home/>}/>
            <Route path="/about" element={<About/>}/>
            <Route path="/*" element={<Home/>}/>
          </Routes>
      </BrowserRouter>
    </div>
  );
}


export default App;
