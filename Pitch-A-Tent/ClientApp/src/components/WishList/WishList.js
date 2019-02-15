import React from 'react';
import wishRequest from '../Requests/WishRequest';

import './WishList.css';

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
                
                <div className="card border-primary mb-3" key={myItem.id}>
                    <div className="card-header">{myItem.name}</div>
                    <div className="card-body">
                        <h4 className="card-title">Description</h4>
                        <p>{myItem.description}</p>
                        </div>
                    <button type="button" className="btn btn-danger" onClick={()=>this.deleteWishClick(myItem.id)}>Delete</button>
                    </div>
               
            );
        })
        return (
            <div className="myWish">
                <h1 className="wishes">My Wish Items</h1>
                {wishLists}
            </div>
           
        );
    }

}

export default WishList;