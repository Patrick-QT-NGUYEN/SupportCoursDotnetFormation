import { combineReducers, createStore } from "redux";
import { filterReducer } from "./filterReducer";
import { TodosReducer } from "./todosReducer";

const incr = function (state = 0, action) {
    if (action.type === 'incr') {
        return state + 1
    }
    return state
}


const store = createStore(
    combineReducers({
        todos: TodosReducer,
        filter: filterReducer,
        incr: incr
    }),
    window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__()
)
window.setInterval(()=>{
    store.dispatch({type:'incr'})
},60000)
export default store