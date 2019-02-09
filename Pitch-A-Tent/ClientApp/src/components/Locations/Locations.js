
import React from 'react';
import campgroundRequest from '../Home/Request/Request';

class Locations extends React.Component {
    state = {
        campgrounds: [],
        wishItems:[],
    }

    componentDidMount() {
        campgroundRequest
            .getCampgrounds()
            .then((results) => {
                this.setState({ campgrounds: results.data });
            })
            .catch((err) => {
                console.error('error getting campgrounds', err);
            })

       

        //campgroundRequest
        //    .getLocations()
        //    .then((locations) => {
        //        this.setState({ locations });
        //    })
        //    .catch((err) => {
        //        console.error('error getting campgrounds', err);
        //    })
    }


    render() {
        if (this.state.campgrounds) {
            this.locationComponents = this.state.campgrounds.map(campground => {
                return (
                    <div>
                        <h2>{campground.name}</h2>
                        <h4>{campground.description}</h4>
                    </div>
            );
            })
        }
    
        return (
            <div className="Locations">
                <h2> All Locations</h2>
                <ul className="campgrounds">
                    {this.locationComponents}
                </ul>
            </div>
        );
    }
}

export default Locations;