import './App.css';
import store from './store';
import { Provider } from 'react-redux'// npm install react-redux
import { TodoListStore } from './components/TodoList';
import { TodoFilterStore } from './components/TodoFilter';


function App() {
  return (
    <Provider store={store}>
      <TodoFilterStore/>
      <TodoListStore/>      
    </Provider>
  );
}

export default App;
