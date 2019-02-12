import axios from 'axios';
import constants from '../../Constants';


const getCampgrounds = (txt) => {
    return new Promise((resolve, reject) => {
        axios
            .get(`https://developer.nps.gov/api/v1/campgrounds?name=${txt}&api_key=${constants.myApiKey}`)
            .then(res => {
                resolve(res.data);
                console.log(res.data);
            })
            .catch(err => {
                reject(err)
            })
    })
}




export default { getCampgrounds};