<template>
  <div>
    <v-container fluid fill-height>
      <v-layout row>
        <v-flex xs8 offset-lg3 offset-sm4>
          <h3>{{Name}}</h3>
          <clientGrid-component></clientGrid-component>
          <br />
          <br />
          <client-Component></client-Component>
        </v-flex>
      </v-layout>
    </v-container>
  </div>
</template>

<script>
  import ClientAdd from '../client/ClientAddComponent';
  import ClientGrid from '../client/ClientGridComponent';
  export default {
    components: {
      'client-Component': ClientAdd,
      'clientGrid-component': ClientGrid
    },
    data: () => ({
      Name: "Client Management",
      origionalProductsList: [],
      products: [],
      filterName: ''
    })


  }
</script>

<style>
</style>
