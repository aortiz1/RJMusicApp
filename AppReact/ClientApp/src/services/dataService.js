import axios from 'axios';

export const getAlbumRequest = () => {
    return axios.get('api/Album/getAlbums');
        //.then((data) => {
        //    data;
        //});
}

export const generateMock = () => {
    return axios.get('api/Mock/generateData');
}

