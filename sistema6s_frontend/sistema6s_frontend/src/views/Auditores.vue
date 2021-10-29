

<template>
    <div class="container main">
        <h2 id="title">Auditores</h2>
        <div>
            <ul v-for="auditor in info" :key="auditor.userId">
                <li>
                    {{auditor.nombre}}
                </li>
            </ul>
        </div>
    </div>    
    
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

</style>
