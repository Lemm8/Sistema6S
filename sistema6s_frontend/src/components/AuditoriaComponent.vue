<template>
    <div class="container">
        <div class="auditoria-title">
            <div class="auditoria-head">
                <i class="fa fa-calendar"></i>
                Título
            </div>            
        </div>    
        <div class="auditor">            
            {{ auditorNombre }}
            <i class="fa fa-plus" title="Añadir Auditoría"></i>
        </div>    
        <div class="tareas"> 
            <a href="#">Agregar auditoría</a>
        </div>    
        <table class="table table-hover">
            <thead>
                <tr>
                    <th scope="col">Id</th>
                    <th scope="col">Área</th>
                    <th scope="col"></th>                    
                    <th scope="col">Inicial</th>
                    <th scope="col">Target</th>
                    <th scope="col">Complete</th>
                    <th scope="col">Estado</th>
                    <th scope="col"></th>
                    <th scope="col"></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope="row"> {{ auditoriaId }} </th>                    
                    <td> {{area }} </td>                    
                    <td> <a href="#">Iniciar Auditoría</a> </td>
                                                                                
                    <td> {{ auditoriaFechaInicio }} </td>
                                
                    <td v-if="auditoriaFechaTarget"> 
                        {{ auditoriaFechaTarget }}
                    </td>
                    <td v-else> 
                        Sin fecha
                    </td>

                    <td v-if="auditoriaFechaCompleto"> 
                        {{ auditoriaFechaCompleto }}
                    </td>
                    <td v-else> 
                        Sin fecha
                    </td>

                    <td> {{ auditoriaEstado}} </td>

                    <td> <a href="#"> <i class="fa fa-edit" title="Editar"></i> </a> </td>
                    <td> <a href="#"> <i class="fa fa-trash" title="Borrar"></i> </a> </td>
                </tr>                
            </tbody>
        </table>        
    </div>
</template>



<script>

export default {
    name: 'Auditorias',
    props: [
        'auditoriaId', 
        'auditoriaNombre',
        'auditorId',
        'auditorNombre',
        'auditoriaNombre', 
        'auditoriaFechaInicio', 
        'auditoriaFechaTarget', 
        'auditoriaFechaCompleto',
        'auditoriaEstado',
        'area'
    ],
    data() {
        return {
            auditorias: []
        }
    },
    // YA CARGADO, LLAMAMOS A LA API
    /*mounted() {
        let vue = this
        axios.get('https://localhost:44390/api/auditorias')
        .then( function( response ) {
            vue.auditorias = response.data
            console.log(vue.auditorias)
        })
    }*/
}

</script>


<style>
.container {
    margin-bottom: 60px;
}
.auditoria-title {
    text-align: left;    
    margin-top: 30px;
    border-bottom: solid;
    border-bottom-color: #00008B;
    font-size: 20px;    
}
.fa-calendar{
    color: #00008B;
}
thead {
    background-color: #00008B;
    color: #ffffff;
}
.fa-plus {
    margin-left: 40px;
    margin-top: 4px;
    color: #00008B;
}
.fa-plus:hover {
    margin-left: 40px;
    margin-top: 4px;
    color: black;
}
.auditor {    
    display: flex;
    justify-content: center;
    font-size: 18px;
    margin-top: 20px;    
    /*border-bottom-style: groove;
    border-bottom-width: 3px;*/
}
.auditoria-head {
    margin-left: 10px;
}

</style>

