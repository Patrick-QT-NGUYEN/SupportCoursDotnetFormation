import React from 'react';
import './ContactToArray.css';

const ContactToArray = ({ListContact}) => {
    return (
        <table className='table table-striped'>
            <thead>
                <tr>
                    <th scope='col'>#</th>
                    <th scope='col'>Nom</th>
                    <th scope='col'>Prénom</th>
                    <th scope='col'>Email</th>
                    <th scope='col'>Téléphone</th>
                </tr>
            </thead>
            <tbody>
                {ListContact.map( (Contact,index)=>(
                    <tr key={index}>
                        <th scope='row'>{index + 1}</th>
                        <td>{Contact.nom}</td>
                        <td>{Contact.prenom}</td>
                        <td>{Contact.email}</td>
                        <td>{Contact.telephone}</td>
                    </tr>
                ))}
            </tbody>
        </table>
    );
};

export default ContactToArray;