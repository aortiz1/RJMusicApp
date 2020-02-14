import axios from 'axios';

export const getAlbumRequest = () => {
    return axios.get('api/Album/getAlbums')
        .then((data) => {
            data.data;
        });
}