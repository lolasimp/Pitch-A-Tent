//import React from 'react';
//import wishItemRequest from './Request/Request';

//class WishList extends React.Component {

//    state = {
//        wishLists: [],
//    }

//    componentDidMount() {
//        wishItemRequest
//            .getWishitems()
//            .then((wishList) => {
//                this.setState({ wishList });
//            })
//            .catch((err) => {
//                console.error('error getting wishItems', err);
//            })
//    render() {
//        return (
//            <div className="WishList">
//                <h2>WishList</h2>
//            </div>
//        );
//    }
//}

//export default WishList;