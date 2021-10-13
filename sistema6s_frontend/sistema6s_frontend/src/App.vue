<template>
  <div>
    <NavBar />
    <Home />
  </div>  
</template>

<script>
import Home from './views/Home.vue'
import NavBar from './layouts/NavBar.vue'
import axios from 'axios';
window.axios = require('axios');
export default {
  name: 'App',
  components: {
    Home,
    NavBar
  },
  mounted: function() {
    axios.get("https://localhost:5001/api/auditores")
         .then(response => console.log(response.data))
         .catch(error => console.log(error));
  }
}
</script>

<style>
body {
  font-family: 'Oswald', sans-serif;
}
</style>
