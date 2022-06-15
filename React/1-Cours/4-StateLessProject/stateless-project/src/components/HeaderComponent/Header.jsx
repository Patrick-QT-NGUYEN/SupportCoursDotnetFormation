import React from 'react';
import './Header.css';

const Header = () => {
    return (
        <div className='banner'>
            <img src="./img/M2ILOGO2.png" alt="Logo-M2I" />
            <h2>M2iFormation</h2>
            <span className='description'>Votre formation sur mesure...</span>
        </div>
    );
};

export default Header;