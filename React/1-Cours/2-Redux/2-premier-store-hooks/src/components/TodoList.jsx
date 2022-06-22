import { useDispatch, useSelector } from "react-redux"
import { filtreredTodosSelector } from "../store/todosSelectors"
import { DeleteTodoAction, ToggleTodoAction } from "../store/todosActions"
import { useCallback } from "react"

function TodoItem({ todo, onToggle, onDelete }) {
    return <li>
        <label htmlFor="">
            <input className="btn btn-secondary" type="checkbox" checked={todo.completed} onChange={() => onToggle(todo)} />
            {todo.title}
            <button className="btn btn-secondary" onClick={() => onDelete(todo)}>x</button>
        </label>
    </li>
}
// // 1 => Le composant est fortement couplé au store
// export function TodoList() {    
//     const todos= useSelector(todosSelector)
//     const dispatch = useDispatch()
//     const onToggle = useCallback((todo)=>{
//         dispatch(toggleTodoAction(todo))
//     },[])
//     return <ul>
//         {todos.map(todo => <TodoItem todo={todo} onToggle={onToggle} key={todo.id} />)}
//     </ul>
// }

// 2 => Gardons un composant pure découplé du store
export function TodoList({ todos, onToggle, onDelete }) {
    return <ul>
        {todos.map(todo => <TodoItem todo={todo} onToggle={onToggle}
            onDelete={onDelete} key={todo.id} />)}
    </ul>
}

// 2 => Et créons un composant reliant notre composant TodoList au store
export function TodoListStore() {
    const todos = useSelector(filtreredTodosSelector)
    const dispatch = useDispatch()
    const onToggle = useCallback((todo) => {
        dispatch(ToggleTodoAction(todo))
        // eslint-disable-next-line react-hooks/exhaustive-deps
    }, [])
    // Ajout de l'action Delete
    const onDelete = useCallback(todo => {
        dispatch(DeleteTodoAction(todo))
        // eslint-disable-next-line react-hooks/exhaustive-deps
    }, [])

    // Utilisation de notre composant sans logique store
    return <TodoList todos={todos} onToggle={onToggle} onDelete={onDelete} />
}


// export const TodoListStore = connect(
//     (state) => ({
//         todos: todosSelector(state)
//     }),
//     (dispatch) => ({
//         onToggle: todo => dispatch(toggleTodoAction(todo))
//     })
// )(TodoList)
