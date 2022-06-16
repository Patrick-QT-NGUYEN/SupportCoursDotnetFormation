import React from 'react';
import ContactToArray from '../../components/ContactToArrayComponent/ContactToArray';
import './ContactListView.css';

const ContactListView = ({ListContact, updateListContact}) => {
    //console.table(ListContact);
    return (
        <div className='container'>
              <h1 className='title'>Liste des contacts</h1>
              <ContactToArray ListContact={ListContact} />
        </div>
    );
};

export default ContactListView;