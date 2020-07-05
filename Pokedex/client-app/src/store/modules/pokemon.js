import { RepositoryFactory } from '@/repositorys/RepositoryFactory'
import pokemonRepository from '../../repositorys/pokemonRepository';
const PokemonRepository = RepositoryFactory.get('pokemon')
const PokedexRepository = RepositoryFactory.get('pokedex')

const state = {
    pokemon: '',
    pokedex: [],
    species: '',
}

const getters = {
    pokemon: (state) => state.pokemon,
    pokedex: (state) => state.pokedex,
    species: (state) => state.species
};

const actions = {
    async fetchPokemonByName({commit}, name){
        console.log(name);
        const response = await PokemonRepository.get_pokemon_by_name(name)

        commit('setPokemon', response.data);
    },
    async fetchPokemon({ commit }) {
        const response = await PokedexRepository.get_pokedex();
        commit('setPokedex', response.data.pokemon_entries)
    },
    async fetchSpecies({ commit }, id) {
        const response = await pokemonRepository.get_species(id);

        commit('setSpecies', response.data)
    }
};

const mutations = {
    setPokemon: (state, new_pokemon) => (state.pokemon = new_pokemon),
    setPokedex: (state, pokedex_results) => (state.pokedex = pokedex_results),
    setSpecies: (state, specie) => (state.species = specie)
};

export default {
    state,
    getters,
    actions,
    mutations
};