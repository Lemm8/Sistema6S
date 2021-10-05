<template>
  <NavBar />
  <Home />
</template>

<script>
import Home from './views/Home.vue'
import NavBar from './layouts/NavBar.vue'

export default {
  name: 'App',
  components: {
    Home,
    NavBar
  }
}
</script>

<style>
body {
  font-family: 'Oswald', sans-serif;
}
</style>
