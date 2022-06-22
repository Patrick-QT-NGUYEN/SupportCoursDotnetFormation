import React from 'react';
import './Home.css';

const Home = () => {
    let prenom = "Anthony";
    return (
        <div className='ConteneurHome'>            
            <h1>Welcome to Home component {prenom}...!</h1>
            <img src="./img/logo192.png" alt="Logo React" />
        </div>
    );
};

export default Home;