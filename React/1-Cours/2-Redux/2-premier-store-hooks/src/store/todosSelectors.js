export const TodosSelector = ({ todos }) => todos

export const filtreredTodosSelector = ({todos,filter})=>{
    if(filter === null){
        return todos
    }
    return todos.filter(todo => todo.completed === filter)
}