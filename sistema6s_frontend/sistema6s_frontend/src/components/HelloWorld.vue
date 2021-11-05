<template>
  <v-container>
    <v-row class="text-center">
      <v-col>
        6S
      </v-col>
      <v-col>
        <v-row class="padding-for-button">
          <v-btn
            depressed
            color="primary"
            outlined
            block
            x-large
          >
            <v-row>
              <v-icon
                large
                color="green darken-2"
              >
                mdi-home
              </v-icon>
            </v-row>
          INICIO</v-btn>
        </v-row>
        <v-row class="padding-for-button">
          <v-btn
            depressed
            color="primary"
            outlined
            block
            x-large
          >
            <v-row>
              <v-icon
                large
                color="green darken-2"
              >
                mdi-domain
              </v-icon>
            </v-row>
          INSTRUCCION</v-btn>
        </v-row>
          
        <v-row class="padding-for-button" >
          <v-btn
            depressed
            color="primary"
            outlined
            block
            x-large
          >
            <v-row>
              <v-icon
                large
                color="green darken-2"
              >
                mdi-domain
              </v-icon>
            </v-row>
        INDICADORES</v-btn>
        </v-row>
      </v-col>
      <v-col>
        <v-row class="padding-for-button">
          <v-btn
            depressed
            color="primary"
            outlined
            block
            x-large
          >
            <v-row>
              <v-icon
                large
                color="green darken-2"
              >
                mdi-domain
              </v-icon>
            </v-row>
            HACER AUDITORIA OPERACIONES
          </v-btn>
        </v-row>
        <v-row class="padding-for-button">
          <v-btn
            depressed
            color="primary"
            outlined
            block
            x-large
          >
            <v-row>
              <v-icon
                large
                color="green darken-2"
              >
                mdi-domain
              </v-icon>
            </v-row>
        CALIFICACIONES 6S OPERACIONES</v-btn>
        </v-row>

        <v-row class="padding-for-button">
          <v-btn
            depressed
            color="primary"
            outlined
            block
            x-large
            @click="goToAuditores"
          >
            <v-row>
              <v-icon
                large
                color="green darken-2"
              >
                mdi-domain
              </v-icon>
            </v-row>
        AUDITORES</v-btn>
        </v-row>
      </v-col>
      <v-col>
        <v-row class="padding-for-button">
          <v-btn
            depressed
            color="primary"
            outlined
            block
            x-large
          >
            <v-row>
              <v-icon
                large
                color="green darken-2"
              >
                mdi-domain
              </v-icon>
            </v-row>
          HACER AUDITORIA ADMINISTRATIVA
          </v-btn>
        </v-row>
        <v-row class="padding-for-button">
          <v-btn
            depressed
            color="primary"
            outlined
            block
            x-large
          >
            <v-row>
              <v-icon
                large
                color="green darken-2"
              >
                mdi-domain
              </v-icon>
            </v-row>
              CALIFICACIONES 6S ADMINISTRATIVA
          </v-btn>
        </v-row>

        <v-row class="padding-for-button">
          <v-btn
            depressed
            color="primary"
            outlined
            block
            x-large
            @click="goToAuditores"
          >
            <v-row>
              <v-icon
                large
                color="green darken-2"
              >
                mdi-domain
              </v-icon>
            </v-row>
        KAIZEN 6S
          </v-btn>
        </v-row>
        <v-row class="padding-for-button">
          <v-btn
            depressed
            color="primary"
            outlined
            block
            x-large
            @click="goToAuditores"
          >
            <v-row>
              <v-icon
                large
                color="green darken-2"
              >
                mdi-domain
              </v-icon>
            </v-row>
        RECONOCIMIENTOS</v-btn>
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
.text-center {
  padding-top: 4rem;
}
.padding-for-button {
  height: 4rem;
  padding-top: 3rem;
  padding-right: 3rem;
}
</style>
