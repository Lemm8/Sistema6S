
<template>
  <v-container>
      <v-row>
        <v-col class="titulo">Operaciones</v-col>
        <v-col class="subtitulo">Oficinas</v-col>
      </v-row>
      <v-row></v-row>
      <v-col>
        <v-row>
          <v-col>
            <Auditor v-bind:auditores="info"></Auditor>
          </v-col>
          <v-col style="width:1rem;">
          </v-col>
          <v-col>
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
.subtitulo {
  text-align: center;
  font-size: 1.6rem;
}
.auditores {
  margin: 0 auto;
}
.titulo {
  text-align: center;
  font-size: 1.6rem;
  
}
.button {
 padding: 1rem;
}
.text-center {
  padding-top: 4rem;
}
</style>
