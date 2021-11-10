
<template>
  <v-container>
      <v-row>
        <v-col class="titulo">Operaciones</v-col>
        <v-col class="subtitulo">Oficinas</v-col>
      </v-row>
      <v-row></v-row>
      <v-col>
        <v-row no-gutters>
          <v-col>
            <template v-for="auditor in info">
              <v-col
                :key="auditor.userId">
                  <v-card
                    class="card"
                    elevation="2">
                    <v-avatar size="70" color="indigo">
                      <v-icon dark size="70">
                        mdi-account-circle
                      </v-icon>
                    </v-avatar>
                    <v-card-subtitle>
                      {{auditor.nombre}}
                    </v-card-subtitle>
                  </v-card>
              </v-col>
             <v-responsive
               v-if="auditor.userId === 3"
                :key="`width-${auditor.userId}`"
                width="20%"
             ></v-responsive>
              </template>
          </v-col>
          <v-col>
            <template v-for="auditor in info">
              <v-col
                :key="auditor.userId">
                  <v-card
                    class="card"
                    elevation="2">
                    <v-avatar size="70" color="indigo">
                      <v-icon dark size="70">
                        mdi-account-circle
                      </v-icon>
                    </v-avatar>
                    <v-card-subtitle>
                      {{auditor.nombre}}
                    </v-card-subtitle>
                  </v-card>
              </v-col>
             <v-responsive
               v-if="auditor.userId === 3"
                :key="`width-${auditor.userId}`"
                width="20%"
             ></v-responsive>
              </template>
          </v-col>
        </v-row>
    </v-col>
  </v-container>
</template>

<script>
import axios from 'axios';
  export default {
    name: 'Auditores',

    data: () => {
      return {
        info : null
      }
    },
      mounted () {
        axios
          .get('https://localhost:5001/api/auditores')
          .then(response => {
            this.info = response.data
            console.log(this.info.data)
          })
      }
    }
</script>
<style>
.subtitulo {
  text-align: center;
  
}
.titulo {
  text-align: center;
  
}
.button {
 padding: 1rem;
}
.text-center {
  padding-top: 4rem;
}
.card {
  text-align: center;
  height: 10rem;
}
</style>
