import PropTypes from 'prop-types';

const AlbumCover = () => {
    <div>
        <span>
            <i src={this.props.cover}></i>
            <label>{this.props.name}</label>
            <label>{this.props.artists}</label>
        </span>
    </div>
}

AlbumCover.propTypes = {
    cover: PropTypes.string.isRequired,
    name: PropTypes.string.isRequired,
    artists: PropTypes.string.isRequired
}

export default AlbumCover;