<template>
  <div>
    <v-container fluid fill-height>
      <v-layout row>
        <v-flex xs8 offset-lg3 offset-sm4>
          <h3>Home</h3>
        </v-flex>
      </v-layout>
    </v-container>
  </div>
</template>

<script>
  export default {
    components: {
  
    },
    data() {
      return {
        header: 'Home'
      }
    }
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  h1,
  h2 {
    font-weight: normal;
  }

  ul {
    list-style-type: none;
    padding: 0;
  }

  li {
    display: inline-block;
    margin: 0 10px;
  }

  a {
    color: #42b983;
  }
</style>
