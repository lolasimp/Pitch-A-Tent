import React from 'react';
import { Col } from 'react-bootstrap';

import './SearchResults.css'

class SearchResults extends React.Component {
    state = {
        Name: 'name',
        Description: 'description',
        LatLong: 'latLong',
        DirectionsUrl: 'directionsUrl',
        DirectionsOverview: 'directionsOverview',
    }

    render() {
        const { campgroundDetails } = this.props
        const { name, Description, LatLong, DirectionsUrl, DirectionsOverview } = this.state;

        const saveToWishItems = e => {
            this.props.addNewWishClick(this.props.campgroundDetails)
        }
    
        return (
            <div className="card border-primary mb-3" key={campgroundDetails.id}>
                <div className="card-header">{campgroundDetails.name}</div>
                <div className="card-body">
                    <h4 className="card-title">Description</h4>
                    <p>{campgroundDetails.description}</p>
                    <h4 className="card-title">Coordinates</h4>
                    <p>{campgroundDetails.latLong}</p>
                    <h4 className="card-title">Drection Overview</h4>
                    <p>{campgroundDetails.directionsOverview}</p>
                    <p>{campgroundDetails.directionsUrl}</p>

                </div>
                <button type="button" className="btn btn-primary" onClick={saveToWishItems}>Add To Wish Items</button>
            </div>
        )
    }
}

export default SearchResults;


