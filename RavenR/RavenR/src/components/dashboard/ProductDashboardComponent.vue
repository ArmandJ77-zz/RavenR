<template>
  <div>
    <v-container fluid fill-height>
      <v-layout row>
        <v-flex xs8 offset-lg3 offset-sm4>
          <h3>{{Name}}</h3>
          <product-Component></product-Component>
        </v-flex>
      </v-layout>
    </v-container>
  </div>
</template>

<script>
  import ProductComponent from '../product/ProductComponent';
  export default {
    components: {
      'product-Component': ProductComponent
    },
    data: () => ({
      Name: "Products Managment",
      origionalProductsList: [],
      products: [],
      filterName: ''
    })

  }
</script>

<style>
</style>
