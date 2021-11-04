import { createApp } from 'vue'
import {createVuetify} from 'vuetify/lib/framework.mjs'
import App from './App.vue'
import 'vuetify/dist/vuetify.min.css'


const app = createApp(App)
const vuetify = createVuetify({})
app.use(vuetify)
app.mount('#app')
