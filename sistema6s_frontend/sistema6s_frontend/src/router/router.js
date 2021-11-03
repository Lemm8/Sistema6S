import VueRouter from 'vue-router'
import Auditores from '../views/Auditores.vue'
import App from '../App.vue'

const foo = {template: '<div>hola</div>'}


const routes = [
  {
    path: '/',
    component: App,
    
  },
  {
    path: '/auditores',
    component: Auditores
  },
  {
    path: '/foo',
    component: foo
  }
]

const router = new VueRouter({
  routes,
  mode: 'history',
})

export default router

