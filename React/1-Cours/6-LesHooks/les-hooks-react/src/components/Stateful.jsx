import React, { PureComponent } from 'react';

class Stateful extends PureComponent {

    constructor(props) {
        super(props)
        this.state = {
            count: 0
        }
    }

    componentDidMount() {
       // Mettre à jour le titre du document en utilisant l'API du navigateur
        document.title = `Vous avez cliqué ${this.state.count} fois`;
    }

    componentDidUpdate() {
       // Mettre à jour le titre du document en utilisant l'API du navigateur
        document.title = `Vous avez cliqué ${this.state.count} fois`;
    }

    componentWillUnmount() {

    }

    render() {
        return (
            <div>
                <p>Stateful =&gt; Vous avez cliqué {this.state.count} fois</p>
                <button onClick={() => this.setState({ count: this.state.count + 1 })}>
                    Incrémenter
                </button>
                <button onClick={() => this.setState({ count: 0 })}>
                    Reset
                </button>
            </div>
        );
    }
}

export default Stateful;