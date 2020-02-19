import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';
import { actionCreators } from '../store/Album';
import AlbumRow from './AlbumRow';


class AlbumList extends Component {

    componentDidMount() {
        // This method is called when the component is first added to the document
        this.ensureDataFetched();
    }

    componentDidUpdate() {
        this.ensureDataFetched();
    }

    ensureDataFetched() {
        this.props.requestAlbums();
    }

    render() {
        return (
            <div>
                <h1>Albums</h1>
                {renderGrid(this.props)}
              
            </div>
        );
    }
}

function renderAlbums(props) {
    return (
        <table className='table table-stripped'>
            <thead>
                <tr>
                    <th>Name of the album</th>
                    <th>Release year</th>
                    <th>Artist</th>
                    <th>Genre</th>
                </tr>
            </thead>
            <tbody>{props.albums.map(album =>
                <tr key={album.id}><td>{album.name}</td>
                    <td>{album.year}</td>
                    <td>{album.artists}</td>
                    <td>{album.genres}</td>
                </tr>
            )}
            </tbody>
        </table>
    );
    
}

function renderGrid(props) {
    if (props.albums.length === 0) {
        return null;
    }
    let grid = createGrid(props.albums);
    return (
        <div className="container">
            {grid.map((row, index) =>
                <AlbumRow rowNumber={row.rowNumber}
                    cols={row.cols} 
                >
                </AlbumRow>

                )}
        </div>
        );
}

function createGrid(albums) {
    var totalCols = 3;
    var gridList = [];
    for (var i = 0; i < albums.length; i += totalCols) {
        var row = {
            rowNumber: i,
            cols: []
        };
        for (var j = i; j < i + totalCols; j++) {
            if (j < albums.length) {
                row.cols.push(albums[j]);  
            }
        }
        gridList.push(row);
    }
    return gridList;
}
function gridDummy() {
    return (<div className="container">
        <div className="row">
            <div className="col-sm">
                One of three columns
    </div>
            <div className="col-sm">
                One of three columns
    </div>
            <div className="col-sm">
                One of three columns
    </div>
        </div>
    </div>);
}

export default connect(
    state => state.albums,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(AlbumList);
