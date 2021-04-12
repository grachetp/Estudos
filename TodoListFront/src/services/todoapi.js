import axios from 'axios';

const urlBaseMarvel = 'https://localhost:5001/api/todoitems';
const apiKey = 'CHAVE-PUBLICA-MARVEL-API';

export default {
    getAllComics: (limit, callback) => {
        const urlComics = urlBaseMarvel + 'comics?apikey=' + apiKey + '&limit=' + limit;
        axios.get(urlComics).then((comics) => {
            if (callback) {
                callback(comics);
            }
        })
    }
}