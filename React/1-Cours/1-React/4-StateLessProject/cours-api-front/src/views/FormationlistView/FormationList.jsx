import { React, useState } from 'react';
import Category from '../../components/CategoryComponent/Category';
//import { coursList } from '../../datas/CoursList';
import FormationCard from '../../components/FormationCardComponent/FormationCard';
import './FormationList.css';
import Cart from '../../components/CartComponent/Cart';
import { getCoursApi , searchCoursApi } from '../../ApiService';

const FormationList = ({ cart, updateCart }) => {
    // Création d'un state pour la coursList
    const [coursList, setCoursList] = useState();
    const [activeCategory, setActiveCategory] = useState('');

    const categoryList = coursList ? coursList.reduce(
        (acc, elem) => acc.includes(elem.category) ? acc : acc.concat(elem.category),
        []
    ) : [];

    function FetchData() {
        getCoursApi().then((data) => setCoursList(data))
    }
    function SearchData(id) {
        let response = [];
        searchCoursApi(id).then((data) =>{
            response.push(data)
        })
        setCoursList(response)
    }


    function AddToCart(name, price) {
        // Rechercher si la formation est déja présente dans note panier
        const formationAdded = cart.find((cours) => cours.name === name);
        // Vérifier si la formation est déja présente
        if (formationAdded) {
            const filtreredCart = cart.filter(
                (cours) => cours.name !== name
            )
            updateCart([
                ...filtreredCart,
                { name, price, amount: formationAdded.amount + 1 }  // Update de la quantité
            ])
        }
        else {
            updateCart([
                ...cart,
                { name, price, amount: 1 }
            ])
        }
        alert(`La formation ${name} a été ajoutée`);
    }

    return coursList ? (
        <div className="formation-list">

            <h2>Nos Formations</h2>
            <div>
                <div className="row">
                    <div className="col-8">
                        <Category
                            categoryList={categoryList}
                            activeCategory={activeCategory}
                            setActiveCategory={setActiveCategory}
                        />
                    </div>
                    <div className="col-2 paddingTop">
                        <Cart cart={cart} updateCart={updateCart} />
                    </div>
                </div>
            </div>
            <div className="card-container">
                {coursList? coursList.map((cours, index) =>
                    !activeCategory || activeCategory === cours.category ?
                        <div key={index} onClick={() => AddToCart(cours.name, cours.price)}>
                            <FormationCard
                                name={cours.name}
                                logo={cours.logo}
                                category={cours.category}
                                difficulte={cours.difficulte}
                                price={cours.price}
                                index={index}
                            />
                        </div>
                        :
                        null
                ) : []}
            </div>
        </div>
    ) :
        (
            <div>
                <button onClick={() => FetchData()}>Charger Les données depuis l'Api</button>
                <button onClick={() => SearchData(1)}>Chercher la formation id 1</button>
            </div>
        );
};

export default FormationList;