<template>
  <v-container>
    <v-row class="text-center">
      <v-col>
        6S
      </v-col>
      <v-col>
        <v-row>
          <v-btn
            depressed
            class="button"
            color="primary"
            block
          >
          INICIO</v-btn>
        </v-row>
        <v-row>
          <v-btn
            depressed
            class="button"
            color="primary"
            block
          >
          INSTRUCCION</v-btn>
        </v-row>
          
        <v-row>
          <v-btn
            depressed
            class="button"
            color="primary"
            block
          >
        INDICADORES</v-btn>
        </v-row>
      </v-col>
      <v-col>
        <v-row>
          <v-btn
            depressed
            class="button"
            color="primary"
            block
          >
            HACER AUDITORIA OPERACIONES
          </v-btn>
        </v-row>
        <v-row>
          <v-btn
            depressed
            class="button"
            color="primary"
            block
          >
        CALIFICACIONES 6S OPERACIONES</v-btn>
        </v-row>

        <v-row>
          <v-btn
            depressed
            class="button"
            color="primary"
            block
            @click="goToAuditores"
          >
        AUDITORES</v-btn>
        </v-row>
      </v-col>

    </v-row>
  </v-container>
</template>

<script>
  export default {
    name: 'HelloWorld',

    methods: {
      goToAuditores(){
        this.$router.push({name: "Auditores"})
      }
    },
    data: () => ({
      ecosystem: [
        {
          text: 'vuetify-loader',
          href: 'https://github.com/vuetifyjs/vuetify-loader',
        },
        {
          text: 'github',
          href: 'https://github.com/vuetifyjs/vuetify',
        },
        {
          text: 'awesome-vuetify',
          href: 'https://github.com/vuetifyjs/awesome-vuetify',
        },
      ],
      importantLinks: [
        {
          text: 'Documentation',
          href: 'https://vuetifyjs.com',
        },
        {
          text: 'Chat',
          href: 'https://community.vuetifyjs.com',
        },
        {
          text: 'Made with Vuetify',
          href: 'https://madewithvuejs.com/vuetify',
        },
        {
          text: 'Twitter',
          href: 'https://twitter.com/vuetifyjs',
        },
        {
          text: 'Articles',
          href: 'https://medium.com/vuetify',
        },
      ],
      whatsNext: [
        {
          text: 'Explore components',
          href: 'https://vuetifyjs.com/components/api-explorer',
        },
        {
          text: 'Select a layout',
          href: 'https://vuetifyjs.com/getting-started/pre-made-layouts',
        },
        {
          text: 'Frequently Asked Questions',
          href: 'https://vuetifyjs.com/getting-started/frequently-asked-questions',
        },
      ],
    }),
  }
</script>
<style>
.button {
 padding: 1rem;
}
.text-center {
  padding-top: 4rem;
}
</style>
