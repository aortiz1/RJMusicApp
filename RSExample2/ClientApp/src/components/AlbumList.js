import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';
import { actionCreators } from '../store/Album';

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
                {renderAlbums(this.props)}
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

export default connect(
    state => state.albums,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(AlbumList);
