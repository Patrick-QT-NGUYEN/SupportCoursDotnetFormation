import {React , useState} from 'react';
import Contact from './models/Contact';
import {ListPersons} from './data/ListPerson';
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import NavBar from './components/NavBarComponent/NavBar';

function App() {

  // Création d'une liste de contact dpuis notre ListPersons
  const contactList = ListPersons.map((contact)=> new Contact(contact.nom, contact.prenom, contact.email
    , contact.telephone));

  const [ListContact, updateListContact] = useState(contactList? contactList : []);

  return (
    <div className="App">
      <NavBar ListContact={ListContact} updateListContact={updateListContact}/>
    </div>
  );
}

export default App;
