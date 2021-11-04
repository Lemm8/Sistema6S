<template>
    <div class="container main">
        <h2 id="title">Plataforma 6S</h2>
        <div class="row">
            <div class="col-6">

            </div>
            <div class="col-6">
                <div class="container menu_div">
                    <div class="row">
                        <div class="col-6 button_div">
                            <Button text="Inicio" color="#00008B" width="100%"/>
                        </div>
                        <div class="col-6 button_div">
                            <Button text="Indicadores" color="#00008B" width="100%"/>
                        </div>                
                    </div>

                    <div class="row">
                        <div class="col-6 button_div">
                            <Button text="Auditorías" color="#00008B" width="100%"/>
                        </div>   
                        <div class="col-6 button_div">
                            <Button text="Calificaciones" color="#00008B" width="100%"/>
                        </div>   
                    </div>

                    <div class="row">
                        <div class="col-6 button_div">
                            <Button text="Auditores" color="#00008B" width="100%"/>
                        </div>   
                        <div class="col-6 button_div">
                            <Button text="Kaizen 6S" color="#00008B" width="100%"/>
                        </div>   
                    </div>

                    <div class="row">
                        <div class="col-12 button_div">
                            <Button text="Reconocimientos" color="#00008B" width="50%"/>
                        </div>     
                    </div>
                </div>
            </div>
        </div>            
    </div>    
</template>



<script>

import Button from '../components/Button.vue'
//@btn-click="null"
export default {
    name: 'App',
    components: {
        Button
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
