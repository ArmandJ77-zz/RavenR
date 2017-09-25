import Vue from 'vue'
import Router from 'vue-router'
import Dashboard from "../components/dashboard/DashboardComponent"
import SalesDashboardComponent from '../components/dashboard/SalesDashboardComponent'
import ClientDashboard from '../components/dashboard/ClientDashboardComponent'
import ProductDashboardComponent from '../components/dashboard/ProductDashboardComponent'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      component: Dashboard
    },
    {
      path: '/sales',
      component: SalesDashboardComponent
    },
    {
      path: '/client',
      component: ClientDashboard
    },
    {
      path: '/product',
      component: ProductDashboardComponent
    }
  ]
})
