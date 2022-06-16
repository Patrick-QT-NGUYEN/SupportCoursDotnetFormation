import { React, PureComponent } from 'react';
import './FormTodo.css';

class FormTodo extends PureComponent {
    constructor(props) {
        super(props)
        this.state = {
            contentTask: undefined
        }
    }

    Submit = (e) => {
        e.preventDefault();
        if (this.state.contentTask != undefined) {
            this.props.addTodo(this.state.contentTask);
            this.setState({
                contentTask: undefined
            })
        }
    }

    ChangeTask = (e) => {
        e.preventDefault();
        this.setState({
            contentTask: e.target.value
        })
    }



    render() {
        return (
            <form className='row m-1' onSubmit={this.Submit}>
                <div className="col-9">
                    <input
                        type="text"
                        onChange={this.ChangeTask}
                        className='form-control'
                        placeholder='Contenu de la Todo'
                    />
                </div>
                <div className="col-3">
                    <button
                        type='submit'
                        className='form-control btn btn-secondary'
                    >Ajouter</button>
                </div>
            </form>
        );
    }
}

export default FormTodo;