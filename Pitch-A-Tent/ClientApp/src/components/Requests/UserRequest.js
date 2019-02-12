import axios from 'axios';
import constants from '../../Constants';

const getUsers = () => {
    return new Promise((resolve, reject) => {
        axios
            .get(`/api/users`)
            .then(res => {
                resolve(res.data);
            })
            .catch(error => {
                reject(error);
            });
    });
};

export default {getUsers}