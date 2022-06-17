import React from 'react';
import {
    BrowserRouter,
    Routes,
    Route,
    Link,
    Outlet
} from 'react-router-dom';
import About from '../../views/AboutView/About';
import FormationList from '../../views/FormationlistView/FormationList';
import Form from '../../views/FormView/Form';
import Home from '../../views/HomeView/Home';
import './NavBar.css';

const NavBar = ({cart, updateCart}) => {
    return (
        <div>
            <BrowserRouter>
                <div id="navbar">
                    <button className='bouton'>
                        <Link to="/">Home</Link>
                    </button>
                    <button className='bouton'>
                        <Link to="/list">List</Link>
                    </button>
                    <button className='bouton'>
                        <Link to="/form">Form</Link>
                    </button>
                    <button className='bouton'>
                        <Link to="/about">About</Link>
                    </button>
                </div>
                <Routes>
                    <Route path="/" element={<Home cart={cart} updateCart={updateCart}/>} />
                    <Route path="/about" element={<About />} />
                    <Route path="/list" element={<FormationList cart={cart} updateCart={updateCart}/>} />
                    <Route path="/form" element={<Form />} />
                    <Route path="/*" element={<Home />} />
                </Routes>
            </BrowserRouter>

            <div className="container">
                <Outlet/>
            </div>
        </div>
    );
};

export default NavBar;