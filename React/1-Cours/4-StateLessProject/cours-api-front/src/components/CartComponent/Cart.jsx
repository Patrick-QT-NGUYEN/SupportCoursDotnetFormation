import React from 'react';
import { useState } from 'react';
import './Cart.css';

const Cart = ({ cart, updateCart }) => {
    // Declaration d'un state isOpen (Booleen) pour savoir si le panier est affiché ou non
    const [isOpen, setIsOpen] = useState(false);

    // Calcul du montant du panier
    const Total = cart.reduce(
        (acc, cours) => acc + cours.amount * cours.price, 0
    );

    // Retourne du JSX conditionné par le state isOpen
    return isOpen ? (
        <div className='relative'>
            <div className="cart-list over">
                {
                    /* Si il y a des formation dans notre panier */
                    cart.length > 0 ?
                        <div>
                            <h2>Panier</h2>
                            <div className="inner-card">
                                {/* Affichage des formations présente dans le panier*/}
                                <div>
                                    {
                                        cart.map(({ name, price, amount }, index) => (
                                            <div key={`${name} - ${index}`}>
                                                {name} : {price}€ x {amount}
                                                <hr />
                                            </div>
                                        ))
                                    }
                                </div>
                                {/* Affichage du montant du panier */}
                                <h3>Total : {Total}€</h3>
                            </div>
                            <button className='btn btn-secondary space-top' onClick={() => updateCart([])}>Vider le Panier</button>
                        </div>

                        :
                        /* Sinon */
                        <div className='vide'>
                            Votre panier est vide
                        </div>
                }
                <button className='btn btn-secondary spaced' onClick={() => setIsOpen(false)} >Fermer le panier</button>
            </div>
        </div>
    )
        :
        (
            <button className='btn btn-secondary' onClick={() => setIsOpen(true)} >Ouvrir le panier</button>           
        );
};

export default Cart;