<template>
    <div>
        <v-toolbar>
            <search :change_pokedex_pokemon="change_pokedex_pokemon"></search>
        </v-toolbar>
        <v-container class="text-center justify-center">

            <v-card v-if="pokemon != null">

                <v-list-item-content>
                    <v-list-item-title class="title">{{pokemon.name}}</v-list-item-title>
                    <v-list-item-subtitle>Pokedex ID: {{pokemon.id}}</v-list-item-subtitle>
                </v-list-item-content>
                <a class="text_arrows" v-show="pokemon_id != 1" color="white" @click="pokemon_id = pokemon_id - 1; get_pokemon()">&#8592;</a>
                <v-avatar size="400">
                    <img v-bind:src="pokemon.sprites.front_default">
                </v-avatar>
                <a class="text_arrows" color="white" @click="pokemon_id = pokemon_id + 1; get_pokemon()">&rarr;</a>
            </v-card>
        </v-container>
    </div>
</template>

<script>
    import { RepositoryFactory } from '@/repositorys/RepositoryFactory'
    import search from '@/components/pokemon_search'
    import { mapGetters, mapActions } from 'vuex'
    const PokemonRepository = RepositoryFactory.get('pokemon')
    export default {
        props: ["new_pokemon"],
        name: 'pokedex',
        components: {
            search
        },
        computed: mapGetters(['pokemon']),
        data: () => ({
            pokemon_id: 1,
            search: '',

        }),
        watch: {
            new_pokemon: function (value) {
                Object.assign(this.pokemon, value);
            }
        },
        methods: {
            ...mapActions(['fetchPokemonByName', 'fetchSpecies']),
            async get_pokemon() {
                await this.fetchPokemonByName(this.pokemon_id)
            },
            async get_species() {
                await PokemonRepository.get_species(this.pokemon_id)
            },
            change_pokedex_pokemon(pokemon) {
                this.pokemon_id = pokemon.id;
                this.get_species();

            }

        },
        mounted() {
            this.get_pokemon();
            this.get_species();
        }
    }
</script>

<style scoped>
    .text_arrows {
        font-size: 50px;
        color: white;
    }
</style>
