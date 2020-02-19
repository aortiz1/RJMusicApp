import React from 'react';

const AlbumRow = (props) => {
    //console.log("cols", props);
    let cols = props.cols.length > 0 ? props.cols : [];
    //return (<div>ooo</div>);
    if (cols.length === 0) {
        return (<div>000</div>);
    }
    return (
        <div className="row" key={props.rowNumber}>
            {cols.map(col =>
                <div className="col-sm">{col.name}</div>
            )}
        </div>
    );
}

export default AlbumRow;