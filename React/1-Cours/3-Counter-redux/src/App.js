import './App.css';
import { useSelector, useDispatch } from "react-redux"
import { bindActionCreators } from 'redux'
import { actionCreators } from "./state/index"
import { useState } from 'react';


function App() {
  const [userValue, setUserValue] = useState(0)
  const counter = useSelector((state) => state.counter);
  const usrValue = document.getElementById("usrValue");

  const dispatch = useDispatch();

  const { increaseCounter, decreaseCounter } = bindActionCreators(actionCreators, dispatch);

  console.log(counter)

  function IncreaseCounter() {
    if (usrValue.value !== '') {
      increaseCounter(userValue)
      usrValue.value = '';
    } else {
      alert("Veuillez saisir un nombre.")
    }
  }
  function DecreaseCounter() {
    console.log();
    if (usrValue.value !== '') {
      decreaseCounter(userValue)
      usrValue.value = '';
    } else {
      alert("Veuillez saisir un nombre.")
    }
  }

  return (
    <div className="App">
      <input type="number" onChange={(e) => setUserValue(parseFloat(e.target.value))} id="usrValue" />
      <button onClick={IncreaseCounter}>+</button>
      <button onClick={DecreaseCounter}>-</button>
      <h1>Le compteur affiche :</h1>
      <h1> {counter}</h1>
    </div>
  );
}

export default App;
