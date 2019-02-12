import React from 'react';
import wishRequest from '../Requests/WishRequest';

class WishList extends React.Component {

    state = {
        wishLists: [],
    }

    componentDidMount() {
        this.myWishRequest()
    }
    myWishRequest = () => {
        wishRequest
            .getWishItem()
            .then((wishLists) => {
                this.setState({ wishLists })
            })
            .catch((error) => {
                console.error('Not getting WishItems', error);
            });
    };

    deleteWishClick = (id) => {
        wishRequest
            .deleteWish(id)
            .then(() => {
                this.myWishRequest()
            })
            .catch(((err) => {
                console.error('error deleting wish', err);
            }));
    }

    render() {
        const wishLists = this.state.wishLists.map((myItem) => {
            return (
                <div key={myItem.id}>
                    <h2>{myItem.name}</h2>
                    <h4>{myItem.description}</h4>
                    <button type="button" className="btn btn-danger" onClick={()=>this.deleteWishClick(myItem.id)}>Delete</button>
                </div>
            );
        })
        return (
            <div>
                <h1>My Wish Items</h1>
                {wishLists}
            </div>
        );
    }

}

export default WishList;