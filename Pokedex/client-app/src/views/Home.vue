<template>
    <div class="home">
        <Pokedex />
        <v-tabs>
            <v-tab centered grow>Moves</v-tab>
            <v-tabs-items>
                <v-tab-item>
                    <Moves></Moves>
                </v-tab-item>
            </v-tabs-items>
        </v-tabs>
    </div>
    
</template>

<script>
    import Pokedex from '@/components/pokedex.vue'
    import Moves from '@/components/moves_tab.vue'

    export default {
        name: 'Home',
        components: {
            Pokedex,
            Moves
        }
    }
</script>
