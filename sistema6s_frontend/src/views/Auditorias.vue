<template>
    <div class="container">
        <h2 id="title">Plataforma 6S</h2>
        <div v-for="auditoria in auditorias" :key="auditoria.id">
            <AuditoriaComponente 
                v-bind:auditoriaId = "auditoria.auditoriaId"
                v-bind:auditoriaNombre = "auditoria.auditoriaNombre"
                v-bind:auditoriaEstado = "auditoria.auditoriaEstado"
                v-bind:auditoriaFechaInicio = "auditoria.auditoriaFechaInicio"
                v-bind:auditoriaFechaTarget = "auditoria.auditoriaFechaTarget"
                v-bind:auditoriaFechaComplete = "auditoria.auditoriaFechaCompleto"
                v-bind:auditorNombre = "auditoria.auditorNombre"
                v-bind:area = "auditoria.area"
            />
        </div>                        

    </div>
</template>



<script>

import axios from 'axios'
import AuditoriaComponente from '../components/AuditoriaComponent.vue'

export default {
    name: 'Auditorias',
    components: {
        AuditoriaComponente
    },    
    data() {
        return {
            auditorias: []
        }
    },
    // YA CARGADO, LLAMAMOS A LA API
    mounted() {
        let vue = this
        axios.get('https://localhost:44390/api/auditorias')
        .then( function( response ) {
            vue.auditorias = response.data
            //console.log(vue.auditorias)
        })
    }
}

</script>


<style>
#title {
    text-align: center;
    margin-top: 30px;
    font-weight: bold;
}

thead {
    background-color: #00008B;
    color: #ffffff;
}
</style>