//import React from 'react';
//import { Form, Label, Button } from 'react-bootstrap';
//import addWish from '../Requests/LocationRequest';

//class AddWishListItem extends Component {
//    state = {
//        user_id: 0,
//        location_id: 0,
//        campingTypeId: 0,
//        description: '',
//        id: 0
//    }



//    handleChange = e => {
//        const { name, value } = e.target;
//        const newWishItem = { ...this.state };
//        newPayment[name] = value
//        this.setState(newWishItem)
//        console.error('new', newWishItem);
//    };


//    addNewWishClick = () => {
//        return new Promise((resolve, reject) => {
//            addWish
//                .postWish(this.state)
//                .then(response => {

//                    resolve(response);
//                })
//                .catch(err => reject(err));
//        });
//    };

//    render() {
//        //const { user_id } = this.state;


//        return (
//            <div>
//                <h2>Add New Wish Item</h2>
//                <Form>
//                    <Label>Location ID</Label>
//                    <input
//                        type="number"
//                        name="location_id"
//                        value={this.state.location_id}
//                        onChange={this.handleChange}
//                    /><br />
//                    <Label>Description: </Label>
//                    <br />
//                    <input
//                        type="name"
//                        name="description"
//                        value={this.state.description}
//                        onChange={this.handleChange}
//                    /><br />
//                </Form>
//                <Button
//                    onClick={this.addNewWishClick}
//                >Save Changes</Button>
//            </div>

//        );
//    }
//}

//export default AddPaymentType;