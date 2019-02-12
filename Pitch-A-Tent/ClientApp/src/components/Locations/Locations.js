
import React from 'react';
import campgroundRequest from '../Requests/LocationRequest';
import SearchResults from '../SearchResults/SearchResults';
import wishResults from '../Requests/WishRequest';
import './Locations.css';


class Locations extends React.Component {
    state = {
        campgrounds: [], 
        allWishItems: [],
        searchResults:'',
    }     

    //componentWillMount() {
    //    this.searchCampgrounds()
    //}
        searchCampgrounds = (e) => {
            if (e.key === 'Enter') {
                campgroundRequest
                    .getCampgrounds(this.state.searchResult)
                    .then(results => {
                        this.setState({ campgrounds: results.data })
                        console.log(this.state.campgrounds);
                    })
                    .catch(err => {
                        console.error('Not getting campgrounds', err)
                    })
            }
    }

    //"location_id": 3,
    //"campingTypeId": 6,
    //"name": "oooo",
    //"description":

    addNewWishClick = campgrounds => {
        const wish = { ...this.state.allWishItems }
        wish.location_id = campgrounds.location_id;
        wish.campingTypeId = campgrounds.campingTypeId;
        wish.name = campgrounds.name;
        wish.description = campgrounds.description;
        wishResults
            .postWish(wish)
            .then(() => {
                this.props.history.push('/wishItems')
            })
            .catch(err => {
                console.error('Not adding', err)
    });
    }


    searchInput = (e) => {
        this.setState({ searchResult: e.target.value });
        console.log(this.state.searchResults);
    }


    render() {
        if (this.state.campgrounds) {
            this.campsiteComponent = this.state.campgrounds.map(campground => {
                return (
                    <SearchResults
                        key={campground.id}
                        campgroundDetails={campground}
                        addNewWishClick={this.addNewWishClick}
                    />
                )
            })
        }

        return (
            <div className="Location">
                <h2>Search Campgrounds</h2>
                <input
                    type="text"
                    placeholder="Search Campgrounds"
                    onChange={this.searchInput}
                    onKeyPress={this.searchCampgrounds}
                />
                {this.campsiteComponent}
            </div>

    
        );
    }
}          

export default Locations;