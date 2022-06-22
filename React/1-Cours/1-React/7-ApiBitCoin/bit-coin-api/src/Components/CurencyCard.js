import React, { Component } from 'react'
import '../App.css';

class CurrencyCard extends Component {
    constructor(props) {
        super(props)
        this.state = {
            currency: props.currency,
            index: props.index
        }
    }


    render() {
        // console.log(this.currency);
        // console.log(this.index);
        return (
            <div key={this.index}>{this.currency.description}</div>
        )
    }
}

export default CurrencyCard;
