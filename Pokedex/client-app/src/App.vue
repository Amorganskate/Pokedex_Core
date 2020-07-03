<template>
    <v-app>
        <v-navigation-drawer app>

        </v-navigation-drawer>
        <v-content>
            <v-container class="pa-0" fluid>
                <router-view :new_pokemon="pokemon"></router-view>
            </v-container>
        </v-content>

    </v-app>
</template>

<script>
export default {
  name: 'App',
  components:{
      
  },
  data: () => ({
    pokemon: '',
  }),
  methods:{
  }
};
</script>
