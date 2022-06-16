import React from 'react';
import {
    BrowserRouter,
    Routes,
    Route,
    Outlet,
    Link
} from 'react-router-dom';
import AddContact from '../../views/AddContactView/AddContact';
import ContactListView from '../../views/ContactListView/ContactListView';
import Home from '../../views/HomeView/Home';
import ErrorComponent from '../ErrorComponent/ErrorComponent';

import './NavBar.css';

const NavBar = ({ListContact, updateListContact}) => {
    return (
        <div>
            <BrowserRouter>
                <div className='navBar'>
                    <Link to='/' className='btn btn-secondary navBarBtn'>Home</Link>
                    <Link to='/list' className='btn btn-secondary navBarBtn'>List</Link>
                    <Link to='/add' className='btn btn-secondary navBarBtn'>Add</Link>
                    <hr/>
                </div>
                <Routes>
                    <Route path='/' element = {<Home/>}/>
                    <Route path='/list' element = 
                    {
                        <ContactListView 
                            ListContact={ListContact} 
                            updateListContact={updateListContact}
                        />
                    }/>
                    <Route path='/add' element = 
                    {
                        <AddContact 
                            ListContact={ListContact} 
                            updateListContact={updateListContact} 
                        />
                    }/>
                    <Route path='/*' element = {<ErrorComponent/>}/>
                </Routes>
            </BrowserRouter>

            <div className="container">
                <Outlet/>
            </div>
        </div>
    );
};

export default NavBar;