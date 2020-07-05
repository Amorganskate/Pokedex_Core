import Repository from "./Repository";

const resource = "/pokemon";
export default {
    get_pokemon(id) {
        return Repository.get(`${resource}/GetPokemonByID?id=${id}`);
    },
    get_species(id){
        return Repository.get(`${resource}/species?id=${id}`);
    },
    get_pokemon_by_name(name){
        return Repository.get(`${resource}/GetPokemonByName?name=${name}`)
    }
}