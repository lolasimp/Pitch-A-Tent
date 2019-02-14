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
            <div className=" allCamps card text-center">
                <Col sm={6} md={4}>
                    <div className="card-header">
                        <h4>{campgroundDetails.name}</h4>
                    </div>

                    <h5><strong>Description:</strong> {campgroundDetails.description}</h5>
                    <h5><strong>Coordinates:</strong> {campgroundDetails.latLong}</h5>
                    <h5><strong>Directions:</strong> {campgroundDetails.directionsUrl}</h5>
                    <h5><strong>Directions Overview:</strong> {campgroundDetails.directionsOverview}</h5>
                    <button type="button" className="btn btn-primary" onClick={saveToWishItems}>Add To Wish Items</button>
                </Col>
            </div>
        )
    }
}

export default SearchResults;


