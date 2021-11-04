

<template>
     <v-container class="grey lighten-5">
        <v-row no-gutters>
            <template v-for="auditor in info" :key="auditor.userId">
                <v-col>
                    <v-card
                    class="center-avatar"
                    max-width="344"
                    elevation="2"
                    >
                        <v-avatar
                            class="center"
                            color= "primary"
                            size="60">
                        </v-avatar>
                        <v-card-title>
                            {{auditor.nombre}}
                        </v-card-title>

                        <v-card-subtitle class="center-avatar">
                            {{auditor.userId}}
                        </v-card-subtitle>

                    </v-card>
            </v-col>
                <v-col>
                    <v-card
                    class="center-avatar"
                    max-width="344"
                    elevation="2"
                    >
                        <v-avatar
                            class="center"
                            color= "primary"
                            size="60">
                        </v-avatar>
                        <v-card-title>
                            {{auditor.nombre}}
                        </v-card-title>

                        <v-card-subtitle class="center-avatar">
                            {{auditor.userId}}
                        </v-card-subtitle>

                    </v-card>
            </v-col>
          </template>
        </v-row>
        <v-row no-gutters>
            <template v-for="auditor in info" :key="auditor.userId">
                <v-col>
                    <v-card
                    class="center-avatar"
                    max-width="344"
                    elevation="2"
                    >
                        <v-avatar
                            class="center"
                            color= "primary"
                            size="60">
                        </v-avatar>
                        <v-card-title>
                            {{auditor.nombre}}
                        </v-card-title>

                        <v-card-subtitle class="center-avatar">
                            {{auditor.userId}}
                        </v-card-subtitle>

                    </v-card>
            </v-col>
                <v-col>
                    <v-card
                    class="center-avatar"
                    max-width="344"
                    elevation="2"
                    >
                        <v-avatar
                            class="center"
                            color= "primary"
                            size="60">
                        </v-avatar>
                        <v-card-title>
                            {{auditor.nombre}}
                        </v-card-title>

                        <v-card-subtitle class="center-avatar">
                            {{auditor.userId}}
                        </v-card-subtitle>

                    </v-card>
            </v-col>
          </template>
        </v-row>
  </v-container>
</template>



<script>
import axios from 'axios' 
window.axios = require('axios');
//@btn-click="null"
export default {
    name: 'App',
    data() {
        return {
            info : null
        }
    },
    mounted: function() {
    axios.get("https://localhost:5001/api/auditores")
            .then(response => this.info = response.data)
         .catch(error => console.log(error));

  }
}

</script>



<style>
#title {
    text-align: center;
    margin-top: 30px;
}

.menu_div {
    margin-top: 30px;
}
.row {
    margin-top: 10px;
}
.button_div {
    display: flex;
    justify-content: center;
}
.auditores-nombre {
    align-content: center;
}
.auditores {
    display: flex;
    padding-right: 2rem;
    padding-left: 2rem;
    padding-top: 2rem;
    padding-bottom: 2rem;
}

.center-avatar {
    justify-content: center;
}
.center {
    align-content: center;
}


</style>
