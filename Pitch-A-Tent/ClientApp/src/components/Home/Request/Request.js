import axios from 'axios';
import constants from '../../../Constants';


const getCampgrounds = () => {
    return new Promise((resolve, reject) => {
        axios
            .get(`https://developer.nps.gov/api/v1/campgrounds?stateCode=TN&api_key=${constants.myApiKey}`)
            .then(campgrounds => resolve(campgrounds.data))
            .catch(error => reject(error));
    });
}

//q = ${ txt }

//const getWishItem = () => {
//    return new Promise((resolve, reject) => {
//        axios
//            .get(`/api/wishItem`)
//            .then(res => resolve(res.data))
//            .catch(error => reject(error));
//    });
//}


const addToWishList = (wishList) => {
    return new Promise((resolve, reject) => {
        axios
            .post(`api/wishitem/additem`, wishList)
            .then((res) => {
                resolve(res.data);
            })
            .catch((err) => {
                reject(console.error('Can NOT add books', err))
            })
    });
};

export default { getCampgrounds, addToWishList};