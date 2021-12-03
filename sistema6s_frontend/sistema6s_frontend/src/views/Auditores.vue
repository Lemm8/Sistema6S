
<template>
  <v-container>
      <v-row>
        <v-col class="titulo-pagina">Plataforma 6S</v-col>
      </v-row>
      <v-row no-gutters>
        <v-col class="titulo">AUDITORES 6S</v-col>
      </v-row>
      <v-row>
        <v-col class="titulo">OPERACIONES</v-col>
        <v-col class="titulo">OFICINAS</v-col>
      </v-row>
      <v-col class="pt-13">
        <v-row>
          <v-col md="20">
            <Auditor v-bind:auditores="info"></Auditor>
          </v-col>
          <v-col md="1">
          </v-col>
          <v-col md="20">
            <Auditor v-bind:auditores="info"></Auditor>
          </v-col>
        </v-row>
    </v-col>
  </v-container>
</template>

<script>
import axios from 'axios';
import Auditor from '../components/Auditor.vue';
  export default {
    name: 'Auditores',
    components: {
      'Auditor': Auditor
    },

    data: () => {
      return {
        info : []
      }
    },
      mounted () {
        axios
          .get('https://localhost:5001/api/auditores')
          .then(response => {
            console.log(response)
            this.info = response.data
            console.log(this.info)
          })
      }
    }
</script>
<style>
.auditores {
  margin: 0 auto;
}
.titulo-pagina {
  text-align: center;
  font-weight: bold;
  font-size: 1.5rem;
  color: darkgray;
  
}
.titulo {
  text-align: center;
  font-size: 1rem;
  
}
.button {
 padding: 1rem;
}
.text-center {
  padding-top: 4rem;
}
</style>
