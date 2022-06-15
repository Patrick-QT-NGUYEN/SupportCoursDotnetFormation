import { React, useState } from 'react';
import Category from '../../components/CategoryComponent/Category';
import { coursList } from '../../datas/CoursList';
import FormationCard from '../../components/FormationCardComponent/FormationCard';
import './FormationList.css';
import Cart from '../../components/CartComponent/Cart';

const FormationList = ({ cart, updateCart }) => {

    const [activeCategory, setActiveCategory] = useState('');

    const categoryList = coursList.reduce(
        (acc, elem) => acc.includes(elem.category) ? acc : acc.concat(elem.category),
        []
    )
    //console.log("CategoryList : "+categoryList);

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

    return (
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
                {coursList.map((cours, index) =>
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
                )}
            </div>
        </div>
    );
};

export default FormationList;