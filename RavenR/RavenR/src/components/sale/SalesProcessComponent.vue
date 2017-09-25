<template>
  <div>
    <v-stepper v-model="e1">
      <v-stepper-header>
        <v-stepper-step step="1" :complete="e1 > 1">Name of step 1</v-stepper-step>
        <v-divider></v-divider>
        <v-stepper-step step="2" :complete="e1 > 2">Name of step 2</v-stepper-step>
        <v-divider></v-divider>
        <v-stepper-step step="3">Name of step 3</v-stepper-step>
      </v-stepper-header>
      <v-stepper-content step="1">
        <h3>Step 1</h3>
        <v-card class="grey lighten-1 mb-5" height="200px"></v-card>
        <v-btn primary @click.native="e1 = 2">Continue</v-btn>
        <v-btn flat>Cancel</v-btn>
      </v-stepper-content>
      <v-stepper-content step="2">
        <h3>Step 2</h3>
        <v-card class="grey lighten-1 mb-5" height="200px"></v-card>
        <v-btn primary @click.native="e1 = 3">Continue</v-btn>
        <v-btn flat>Cancel</v-btn>
      </v-stepper-content>
      <v-stepper-content step="3">
        <h3>Step 3</h3>
        <v-card class="grey lighten-1 mb-5" height="200px"></v-card>
        <v-btn primary @click.native="e1 = 1">Continue</v-btn>
        <v-btn flat>Cancel</v-btn>
      </v-stepper-content>
    </v-stepper>    
  </div>
</template>
<script>
  import axios from 'axios';
  export default {
    data: () => ({
      e1: 0,
      subHeading: "Sales",
    })
    , created() {
      //axios.get("/api/products/")
      //  .then(response => {
      //    this.products = response.data;
      //    this.origionalProductsList = response.data;
      //  })
      //  .catch(e => {
      //    console.log(e);
      //  })
    },
    methods: {
      
    }
  }
</script>

<style>
</style>
