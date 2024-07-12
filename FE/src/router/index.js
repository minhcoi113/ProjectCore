import Vue from 'vue'
import VueRouter from 'vue-router'
import VueMeta from 'vue-meta'
import routes from './routes'

Vue.use(VueRouter)
Vue.use(VueMeta, {
  keyName: 'page',
})

const router = new VueRouter({
  routes,
  mode: 'history',
  scrollBehavior(to, from, savedPosition) {
    if (savedPosition) {
      return savedPosition
    } else {
      return { x: 0, y: 0 }
    }
  },
})
router.beforeEach((routeTo, routeFrom, next) => {
  const publicPages = ['/dang-nhap'];
  const authpage = !publicPages.includes(routeTo.path);

  const loggeduser = localStorage.getItem('user-token');

  if (authpage && !loggeduser) {
    return next('/dang-nhap');
  }
  next();
})

router.beforeResolve(async (routeTo, routeFrom, next) => {
  try {
    for (const route of routeTo.matched) {
      await new Promise((resolve, reject) => {
        if (route.meta && route.meta.beforeResolve) {
          route.meta.beforeResolve(routeTo, routeFrom, (...args) => {
            if (args.length) {
              next(...args)
              reject(new Error('Redirected'))
            } else {
              resolve()
            }
          })
        } else {
          resolve()
        }
      })
    }
  } catch (error) {
    return
  }
  next()
})

export default router
