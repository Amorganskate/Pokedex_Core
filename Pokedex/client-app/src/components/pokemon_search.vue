<template>
    <v-autocomplete v-on:keyup.enter="search_pokemon()" :items="pokedex" item-text="pokemon_species.name" :loading="is_loading" label="Search..." item-value="entry_number" hide-no-data hide-details :search-input.sync="search" cache-items solo clearable></v-autocomplete>
</template>
<script>
import { RepositoryFactory } from '@/repositorys/RepositoryFactory'
const PokedexRepository = RepositoryFactory.get('pokedex')
import {  mapActions, mapGetters} from 'vuex'
export default {
    props:["change_pokedex_pokemon"],
    data: () => ({
        search: '',
        is_loading: false,
        }),
    computed: mapGetters(['pokedex', 'pokemon']),
    methods:{
        ...mapActions(['fetchPokemon', 'fetchPokemonByName']),
        async search_pokemon(){
            console.log(this.fetchPokemonByName)
            this.pokemon = this.fetchPokemonByName(this.search.toLowerCase());
            
            this.change_pokedex_pokemon(this.pokemon);
      },
        async get_pokedex() {
            this.is_loading = true;
            this.pokedex = await PokedexRepository.get_pokedex().pokemon_entries;

            this.is_loading = false;

        },

    },
    mounted(){
        this.fetchPokemon();
    }
};
</script>