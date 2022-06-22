

import React, { useState, useEffect } from 'react';

import './App.css';
import ChartCard from './Components/ChartCard';

function App() {
  const [loading, setLoading] = useState(true);
  const [priceData, setPriceData] = useState(null);
  const [currency, setCurrency] = useState(null);
  const [chartData, setChartData] = useState(null);
  const [series, setSeries] = useState(null);

  useEffect(() => {
    async function fetchPrices() {
      const res = await fetch('https://api.coindesk.com/v1/bpi/currentprice.json')
      const data = await res.json();
      if (data !== null) {
        setCurrency(data.bpi.EUR.code);
        setPriceData(data.bpi);
        getChartData();
      }
    }
    fetchPrices();
  }, []);

  const getChartData = async () => {
    //const res = await fetch(`https://api.coindesk.com/v1/bpi/historical/close.json?`)
    const res = await fetch(`https://api.coindesk.com/v1/bpi/historical/close.json?start=2021-01-01&end=2021-12-31 `)
    const data = await res.json();
    const categories = Object.keys(data.bpi);
    const series = Object.values(data.bpi);
    console.log(categories);
    setChartData({
      xaxis: {
        categories: categories
      }
    })
    setSeries([
      {
        name: "Bitcoin Price",
        data: series
      }
    ])
    setLoading(false);
  }

  return (
    <div className='container'>
      <div className="nav" >
        <span className="titre">Coindesk API Data</span>
      </div>
      {loading ? (
        <div>
          Loading...
        </div>
      ) : (
        <>
          <div className="price-container">
            <div >
              <select onChange={(e) => setCurrency(e.target.value)} className='form-control'>
                <option value="EUR" selected>Eur (€)</option>
                <option value="USD">USD ($)</option>
                <option value="GBP">GBP (£)</option>
              </select>
            </div>

            <div className='price'>
              <span>{currency} Price : <b>{Math.round(priceData[currency].rate_float * 100) / 100} {currency === "EUR" ? "€" : currency === "USD" ? "$" : "£"}</b></span>
            </div>
          </div>
          <div className="chart">
            <ChartCard
              options={chartData}
              series={series}
              type="line"
              width="1200"
              height="300"
            />
          </div>
          <div className="chart">
            <ChartCard
              options={chartData}
              series={series}
              type="area"
              width="1200"
              height="300"
            />
          </div>
          <div className="chart">
            <ChartCard
              options={chartData}
              series={series}
              type="bar"
              width="1200"
              height="300"
            />
          </div>
        </>
      )}
    </div>
  );
}

export default App;