import axios from 'axios';

const getCampsites = () => {
    return new Promise((resolve, reject) => {
        axios.get(`https://developer.nps.gov/api/v1/campgrounds?stateCode=TN&api_key=RXWv0vH3UESCkWTlVBHsfliqAAVGVm5V3FVbBoF2`)
            .then(res => {
                resolve(res.data)
            })
            .catch(err => {
                reject(err)
            })
    })
}
export default getCampsites;