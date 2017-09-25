<template>
  <div>
    <h5>{{subHeading}}</h5>
    <v-form v-model="valid" ref="form">
      <v-text-field label="Name" v-model="Name" required></v-text-field>
      <v-text-field label="Last Name" v-model="LastName" required></v-text-field>
      <v-text-field label="E-mail" v-model="Email" required></v-text-field>

      <v-btn @click="submit" :class="{ blue: valid, red: !valid }">Add</v-btn>
      <v-btn @click="clear">clear</v-btn>
    </v-form>
  </div>
</template>

<script>
  import axios from 'axios';
  export default {
    data: () => ({
      subHeading: 'Add New Client',
      Name: "",
      LastName: "",
      Email: "",
      valid: false
    }),
    methods: {
      submit() {
        console.log(this.Name);
        console.log(this.LastName);
        console.log(this.Email);
        if (this.$refs.form.validate()) {
          axios.post("/api/client/", {
            Name: this.Name,
            LastName: this.LastName,
            Email: this.Email
          })
            .then(() => {
              this.$refs.form.reset();
            })
            .catch(e => {
              console.log(e);
            })
        }
      },
      clear() {
        this.$refs.form.reset();
      }
    }
  }
</script>

<style scoped>
</style>
