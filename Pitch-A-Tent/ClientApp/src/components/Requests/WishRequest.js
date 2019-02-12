import axios from 'axios';
import constants from '../../Constants';

const getWishItem = () => {
    return new Promise((resolve, reject) => {
        axios
            .get(`/api/wishItem`)
            .then(res => {
                resolve(res.data);
            })
            .catch(error => {
                reject(error);
            });
    });
};


const postWish = (wish) => {
    return new Promise((resolve, reject) => {
        console.log(wish);
        axios
            .post(`/api/wishItem`, wish)
            .then((res) => {
                resolve(res.data);
            })
            .catch((error) => {
                reject(error);
            })
    })
};

const deleteWish = (id) => {
    return new Promise((resolve, reject) => {
        axios
            .delete(`/api/wishItem/${id}`)
            .then((res) => {
                resolve(res);
            })
            .catch((err) => {
                reject(err);
            })
    })
}


export default { getWishItem, postWish, deleteWish }