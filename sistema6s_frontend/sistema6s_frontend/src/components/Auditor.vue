<template>
  <v-layout row wrap>
    <v-flex xs10 sm8 md3 lg4 v-for="item in this.auditores " v-bind:key="item.userId" class="container">
      <v-card
        class="card"
        style="border: 1px solid black;"
        flat>
        <div 
          class="justify-center card-title"
          >
          {{item.auditorNombre}}
        </div>
        <v-responsive class="avatar">
          <v-avatar size="80" color="indigo">
            <v-icon dark size="80">
              mdi-account-circle
            </v-icon>
          </v-avatar>
        </v-responsive>
          <div>{{item.auditoriaFechaCompleto}}</div>
          <div 
            class="en-progreso" 
            v-if="item.auditoriaFechaCompleto == null"
            >En progreso</div>
          <div 
            class="validado" 
            v-else
            >Validado: {{item.auditoriaFechaCompleto}}</div>
      </v-card>
    </v-flex>
  </v-layout>
</template>
  
<script>

export default{
  props: {
    auditores: {
      type:Array,
      required: true
    }
  },

}
</script>

<style>
.avatar{
  padding-top: 0.5rem;
}
.container{
  display: flexbox;
}
.en-progreso{
  margin-top: 1rem;
  border: 1px solid black;
  background-color: yellow;
  width: 100%;
}
.card{
  height: 9.8rem;
  width: 15rem;
  text-align: center;
  border: 1px solid black;
}
.card-title{
  font-size: 1rem;
  border: 1px solid black;
  width: 100%;
}
.validado{
  border: 1px solid black;
  background-color: green;
  width: 100%;
}
</style>

