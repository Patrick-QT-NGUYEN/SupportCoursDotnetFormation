import { ADD_TODO_ACTION, DELETE_TODO_ACTION, UPDATE_TODO_ACTION } from "./todosReducer";
let id = 6;

export const AddTodoAction = (todo) => ({
    type: ADD_TODO_ACTION,
    payload: [...todo, { id: ++id, title:{todo}, completed: false }]
})

export const ToggleTodoAction = (todo) => ({
    type: UPDATE_TODO_ACTION,
    payload: { ...todo, completed: !todo.completed }
})

export const DeleteTodoAction = (todo) => ({
    type: DELETE_TODO_ACTION,
    payload: todo.id
})