<template>
  <div>
    <v-container fluid fill-height>
      <v-layout row>
        <v-flex xs8 offset-lg3 offset-sm4>
          <h3>{{Name}}</h3>
          <salesProcess-Component></salesProcess-Component>
        </v-flex>
      </v-layout>
    </v-container>
  </div>
</template>

<script>
  import SalesProcessComponent from '../sale/SalesProcessComponent'

  export default {
    components: {
      'salesProcess-Component': SalesProcessComponent
    },
    data: () => ({
      Name: "Sales",
      origionalProductsList: [],
      products: [],
      filterName: ''
    })

  }
</script>

<style>
</style>
