//import React, { Component } from 'react';
//import CampgroundRequest from '../../apiCalls/PitchRequest';
//import LocationsResults from '../Locations/Locations';

////import './Home.css';


//export class Home extends Component {
//    render() {

//    }
//    return()
//    //state = {
//    //    campgrounds: [],
//    //    //myWishList: [],
//    //    searchResult: '',
//    //}

//    //searchCampgrounds = (e) => {
//    //    if (e.key === 'Enter') {
//    //        CampgroundRequest
//    //            .getCampsites(this.state.searchResult)
//    //            .then(results => {
//    //                this.setState({ campgrounds: results.camp })
//    //            })
//    //            .catch(err => {
//    //                console.error('error in searching campgrounds', err)
//    //            })
//    //    }
//    //}

//    //searchInput = (e) => {
//    //    this.setState({ searchResult: e.target.value });
//    //}

//    //render() {
//    //    if (this.state.campgrounds) {
//    //        this.LocationsComponent = this.state.campgrounds.map(campgrounds => {
//    //            return (
//    //                <LocationsResults
//    //                    key={campgrounds.id}
//    //                    booksDetails={campgrounds}
//    //                />
//    //            //   <SearchResults
//    //            //    key = { campground.id }
//    //            //booksDetails = { campsite }
//    //            //saveBook = { this.saveLocation }
//    //            //    />
//    //            )
//    //        })
//    //    }
////        return (
////            <div className="Home">
////                <h2>Pitch A Tent!</h2>
////                <input
////                    type="text"
////                    placeholder="Search for a campground"
////                    onChange={this.searchInput}
////                    onKeyPress={this.searchCampsites}
////                />
////                {this.campgroundComponent}
////            </div>
////        )
////    }
////}

//export default Home;

import React from 'react';
//import campgroundRequest from './Request/Request';
import '../Home/Home.css';

class Home extends React.Component {
    render() {
        return (
            <div className="Home">
                <h2>Home</h2>
            </div>
        );
     }
}

export default Home;