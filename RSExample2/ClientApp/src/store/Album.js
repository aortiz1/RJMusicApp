import axios from 'axios';

const REQUEST_ALBUMS = 'REQUEST_ALBUMS';

const initialState = { albums: [], isloading: false }

export const actionCreators = {
    requestAlbums:() => async (dispatch, getState) => {
        const url = `api/MusicStore/getAlbums`;
        axios.get(url).then(res => {
            const albums = res.data;
            dispatch({ type: REQUEST_ALBUMS, albums });
        });
    }
};

export const reducer = (state, action) => {
    state = state || initialState;

    switch (action.type) {
        case REQUEST_ALBUMS:
            return {
                ...state,
                albums: action.albums,
                isLoading: false
            };
        default:
            return state;
    }
};