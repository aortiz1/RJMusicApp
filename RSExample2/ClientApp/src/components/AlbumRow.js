import React from 'react';
import imageCd from '../assets/cd_1.png';
import './web.css';
import imgexample from '../assets/mustard.jpg'

const AlbumRow = (props) => {
    let cols = props.cols.length > 0 ? props.cols : [];
    if (cols.length === 0) {
        return (<div></div>);
    }
    var date = new Date();
    return (
        <div className="row">
            {cols.map(col =>
                <div className="" key={col.id}>
                    <img className="imgSmall" src={imageCd} />
                  <div >{col.name} {col.id}</div>
                </div>
            )}
        </div>
    );
}

export default AlbumRow;