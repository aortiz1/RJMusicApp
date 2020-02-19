import React from 'react';

const AlbumRow = (props) => {
    let cols = props.cols.length > 0 ? props.cols : [];
    if (cols.length === 0) {
        return (<div></div>);
    }
    var date = new Date();
    return (
        <div className="row">
            {cols.map(col =>
                <div className="col-sm" key={col.id}>
                    <i src='assets/cd_1.png' />
                    <div >{col.name} {col.id}</div>
                </div>
            )}
        </div>
    );
}

export default AlbumRow;