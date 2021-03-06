import React, { Component } from 'react';
import axios from 'axios';

export class FetchData extends Component {
  displayName = FetchData.name

  constructor(props) {
    super(props);
    this.state = { forecasts: [], albums:[], loading: true, loadingAlbum:true };

      //  fetch('api/SampleData/WeatherForecasts')
      axios.get('api/SampleData/WeatherForecasts')
     // .then(response => response.json())
          .then(data => {
             
              this.setState({ forecasts: data.data, loading: false });
          });
      axios.get('api/Album/getAlbums')
          .then(data => {
              console.log("got data", data);
              this.setState({ albums: data.data, loadingAlbum: false });
          });
  }

  static renderForecastsTable(forecasts) {
    return (
      <table className='table'>
        <thead>
          <tr>
            <th>Date</th>
            <th>Temp. (C)</th>
            <th>Temp. (F)</th>
            <th>Summary</th>
          </tr>
        </thead>
        <tbody>
          {forecasts.map(forecast =>
            <tr key={forecast.dateFormatted}>
              <td>{forecast.dateFormatted}</td>
              <td>{forecast.temperatureC}</td>
              <td>{forecast.temperatureF}</td>
              <td>{forecast.summary}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
    }

    static renderAlbums(albums) {
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>Name of the album</th>
                        <th>Release year</th>
                    </tr>
                </thead>
                <tbody> {albums.map(album =>
                    <tr key={album.id}>
                        <td>{album.name}</td>
                        <td>{album.year}</td>
                    </tr>)}
                </tbody>

            </table>
        );
    }


  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
          : FetchData.renderForecastsTable(this.state.forecasts);
      let albumData = this.state.loadingAlbum ? <p><em>Loading...</em></p>
          : FetchData.renderAlbums(this.state.albums);
    return (
      <div>
        <h1>Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
            {contents}
            {albumData}
      </div>
    );
  }
}
