import React, { Component } from 'react'
import '../App.css';
import Chart from 'react-apexcharts'

class ChartCard extends Component {
    constructor(props) {
        super(props)
        this.state = {
            options: props.options,
            series: props.series,
            type: props.type,
            width: props.width,
            height: props.height
        }
        console.log(this.type);
    }


    render() {
        return (
            <Chart
              options={this.state.options}
              series={this.state.series}
              type={this.state.type}
              width={this.state.width}
              height={this.state.height}
            />
        )
    }
}

export default ChartCard;
