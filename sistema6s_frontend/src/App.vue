<template>
  <div>
    <NavBar />    
  </div>
  <router-view/>
</template>

<script>
import NavBar from './layouts/NavBar.vue'

export default {
  name: 'App',
  components: {
    NavBar
  }
}
</script>

<style>
body {
  font-family: 'Oswald', sans-serif;
}

</style>
