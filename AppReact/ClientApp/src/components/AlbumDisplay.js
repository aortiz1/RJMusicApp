
import React, { Component } from 'react';

export class AlbumDisplay extends Component {
    displayName = Counter.name

    constructor(props) {
        super(props);
        this.state = { currentCount: 0 };

    }

  

    render() {
        return (
            <div>
                <span>
                    <i src={this.props.cover}></i>
                    <label>{this.props.name}</label>
                    <label>{this.props.artists}</label>
                </span>
            </div>
        );
    }
}
