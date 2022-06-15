import NavBar from './components/NavBarComponent/NavBar';
import Header from './components/HeaderComponent/Header';
import {React, useState} from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import Footer from './components/FooterComponent/Footer';
import { useEffect } from 'react';

function App() {

  const savedCart = localStorage.getItem('cart');
  //const [cart,updateCart] = useState([]);
  const [cart,updateCart] = useState(savedCart? JSON.parse(savedCart):[]);

  useEffect(()=>{
    localStorage.setItem('cart', JSON.stringify(cart))
  },[cart])
  
  return (
    <div className="App">
      <Header />
      <NavBar cart={cart} updateCart= {updateCart}/>
      <Footer />
    </div>
  );
}

export default App;
