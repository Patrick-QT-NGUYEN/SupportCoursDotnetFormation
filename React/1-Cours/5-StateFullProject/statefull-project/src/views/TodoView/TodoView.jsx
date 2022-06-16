import { React, PureComponent } from 'react';
import FormTodo from '../../components/FormTodoComponent/FormTodo';

class TodoView extends PureComponent {
    /**
     * Constructeur avec déclaration des states locaux
     */
    constructor(props) {
        super(props)
        this.state = {
            todos: []
        }
    }

    /**
     * Function()
     */
    addTodo = (message) => {
        let tmpTodos = [...this.state.todos];
        let newTodo = {
            id: (this.state.todos[this.state.todos.length - 1] !== undefined ? (this.state.todos[this.state.todos.length - 1].id + 1) : 1),
            status: 'undone',
            content: message
        }
        tmpTodos.push(newTodo);
        this.setState({
            todos: tmpTodos
        })
    }

    deleteTodo = (id) => {
        let tmpTodos = [];
        for (let todo of this.state.todos) {
            if (todo.id !== id) {
                tmpTodos.push(todo)
            }
        }
        this.setState({
            todos: tmpTodos
        })
    }

    editTodo = (id, newContent) => {
        let tmpTodos = [];
        for (let todo of this.state.todos) {
            if (todo.id === id) {
                todo.content = newContent
            }
            tmpTodos.push(todo)
        }
        this.setState({
            todos: tmpTodos
        })
    }

    changeStatus = (id, newStatus) => {
        let tmpTodos = [];
        for (let todo of this.state.todos) {
            if (todo.id === id) {
                todo.status = newStatus
            }
            tmpTodos.push(todo)
        }
        this.setState({
            todos: tmpTodos
        })
    }

    render() {
        return (
            <div className='container'>
                <h1>React ToDo List</h1>
                {/* Composant pour ajouter des Todo */}
                <FormTodo addTodo={this.addTodo}/>
                {/* Affichera des notifications sur le nombre de todo*/}

                {/* Composant pour afficher les todos */}
            </div>
        );
    }
}

export default TodoView;