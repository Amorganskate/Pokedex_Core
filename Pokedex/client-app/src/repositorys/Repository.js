import axios from 'axios'

//const baseDomain = "https://pokeapi.co";
const baseURL = `/api/`

export default axios.create({
    baseURL,
    // In Case we every need heads 
    // headers: ["": "Bearer "]
})