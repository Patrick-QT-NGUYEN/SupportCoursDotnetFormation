import { React, useEffect, useState } from 'react';
import Contact from './models/Contact';
import { ListPersons } from './data/ListPerson';
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import NavBar from './components/NavBarComponent/NavBar';

function App() {
  // Récupération des données stockée dans le local storage
  const savedList = JSON.parse(localStorage.getItem('List'));

  // Création d'une liste de contact dpuis notre ListPersons
  const contactList = savedList ?
    savedList.map((contact) => new Contact(contact.nom, contact.prenom, contact.email
      , contact.telephone))
    :
    null;

  const [ListContact, updateListContact] = useState(contactList ? contactList : []);

  useEffect(()=> {
    localStorage.setItem('List', JSON.stringify(ListContact))
  })

  return (
    <div className="App">
      <NavBar ListContact={ListContact} updateListContact={updateListContact} />
    </div>
  );
}

export default App;
