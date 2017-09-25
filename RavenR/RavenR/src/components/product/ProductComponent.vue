<template>
  <div>
    <h5>{{subHeading}}</h5>
    <v-text-field label="Filter by Name" v-model="filterName"></v-text-field>
    <v-btn light v-on:click="filterProducts()">Filter</v-btn>
    <br />
    <br />
    <v-card v-for="product in products" :key="product.Id">
      <v-card-title primary-title>
        <div>
          <h4 class="headline mb-0">{{product.Name}}</h4>
          <div>{{product.Price}}</div>
        </div>
      </v-card-title>
    </v-card>
  </div>
</template>
<script>
  import axios from 'axios';
  export default {
    data: () => ({
      subHeading: "Products",
      origionalProductsList: [],
      products: [],
      filterName: ''
    })
    , created() {
      axios.get("/api/products/")
        .then(response => {
          this.products = response.data;
          this.origionalProductsList = response.data;
        })
        .catch(e => {
          console.log(e);
        })
    },
    methods: {
      filterProducts: function () {
        const criteria = this.filterName;
        this.products = (criteria.length === 0) ? this.origionalProductsList
          : this.origionalProductsList.filter((product) => product.Name === criteria);
      }
    }
  }
</script>

<style>
</style>
