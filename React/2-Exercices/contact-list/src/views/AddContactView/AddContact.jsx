import {React,useState} from 'react';
import Contact from '../../models/Contact';

import './AddContact.css';

const AddContact = ({ListContact, updateListContact}) => {

    /**
     * States
     */
    const [nom, setNom] = useState('');
    const [prenom, setPrenom] = useState('');
    const [email, setEmail] = useState('');
    const [telephone, setTelephone] = useState('');


    /**
     * Function
     */
    // function addToList(nom, prenom, email,telephone){
    //     updateListContact([...ListContact, new Contact(nom, prenom,email,telephone)]);
    //     alert(`${nom} ${prenom} a bien été ajouté!`);        
    // }
    function resetAllStates(){
        setNom("");
        setPrenom("");
        setEmail("");
        setTelephone("");        
    }

    function handleSubmit(e) {
        e.preventDefault();
        updateListContact([...ListContact, new Contact(nom, prenom,email,telephone)]);
        resetAllStates();   
        alert(`${nom} ${prenom} a bien été ajouté!`);  
    }

    /**
     * JSX
     */
    return (
        <div className='container'>
            <h1>Ajouter un contact</h1>
            <div className="card">
                <form onSubmit={handleSubmit}>
                {/* <form > */}
                    <div className="form-control formulaire">
                        <div className="mb-3">
                            <label htmlFor="nom">Nom : </label>
                            <input className='form-control' type="text" name='nom' value={nom} onChange={(e)=>setNom(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="prenom">Prénom : </label>
                            <input className='form-control' type="text" name='prenom'  value={prenom} onChange={(e)=>setPrenom(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="email">Email : </label>
                            <input className='form-control' type="email" name='email'  value={email} onChange={(e)=>setEmail(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="telephone">Téléphone : </label>
                            <input className='form-control' type="text" name='telephone'  value={telephone} onChange={(e)=>setTelephone(e.target.value)} />
                        </div>
                        <button className='btn btn-secondary form-control' type='submit'>Ajouter</button>
                        {/* <button className='btn btn-secondary form-control' onClick={()=>addToList(nom,prenom,email,telephone)}>Ajouter</button> */}
                    </div>
                </form>
            </div>
        </div>
    );
};

export default AddContact;