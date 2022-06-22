import { React, useState } from 'react';
import './Form.css';

const Form = () => {


    const [nom, setNom] = useState("");
    const [prenom, setPrenom] = useState("");
    const [email, setEmail] = useState("");
    const [type, setType] = useState("");
    const [text, setText] = useState("");

    function handleSubmit(e) {
        e.preventDefault();
        alert(e.target['prenom'].value)
        console.log(nom);
    }

    return (
        <div className='container'>
            <h1>Les Formulaires en React</h1>
            <div className="card">
                <form onSubmit={handleSubmit}>
                    <div className="form-control">
                        <div className="mb-3">
                            <label htmlFor="nom">Nom : </label>
                            <input type="text" name='nom' onChange={(e) => setNom(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="prenom">Prénom : </label>
                            <input type="text" name='prenom' onChange={(e) => setPrenom(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="email">Email : </label>
                            <input type="email" name='email' onChange={(e) => setEmail(e.target.value)} />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="type">Choississez votre type de demande : </label>
                            <select className='form-select' name='type' onChange={(e) => setType(e.target.value)}>
                                <option defaultValue disabled>Choississez votre type de demande</option>
                                <option value="1">Renseignement à propos d'une formation</option>
                                <option value="2">Demande de rendez-vous</option>
                                <option value="3">Autres demandes...</option>
                            </select>
                        </div>
                        <div className="mb-3">
                            <label htmlFor="FormTextArea">Rédigez votre demande : </label>
                            <textarea
                                name="FormTextArea"
                                cols="30"
                                rows="10"
                                className='form-control'
                                onChange={(e) => setText(e.target.value)}
                            />
                        </div>
                        <button type='submit' className='btn btn-secondary form-control'>Valider</button>
                    </div>
                </form>
            </div>
            <div className="card">
                <div className="form-control">
                    <div className="mb-3">
                        <label htmlFor="nom">Nom : </label>
                        <input type="text" name='nom' placeholder={nom} />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="prenom">Prénom : </label>
                        <input type="text" name='prenom'  placeholder={prenom} />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="email">Email : </label>
                        <input type="email" name='email'  placeholder={email} />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="type">Choississez votre type de demande : </label>
                        <select className='form-select' name='type'  value={type}>
                            <option defaultValue disabled>Choississez votre type de demande</option>
                            <option value="1">Renseignement à propos d'une formation</option>
                            <option value="2">Demande de rendez-vous</option>
                            <option value="3">Autres demandes...</option>
                        </select>
                    </div>
                    <div className="mb-3">
                        <label htmlFor="FormTextArea">Rédigez votre demande : </label>
                        <textarea
                            name="FormTextArea"
                            cols="30"
                            rows="10"
                            className='form-control'
                            placeholder={text}
                        />
                    </div>
                </div>
            </div>
        </div>
    );
};

export default Form;