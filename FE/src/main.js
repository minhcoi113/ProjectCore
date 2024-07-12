import Vue from 'vue'
import BootstrapVue from 'bootstrap-vue'
import VueApexCharts from 'vue-apexcharts'
import Vuelidate from 'vuelidate'
import * as VueGoogleMaps from 'vue2-google-maps'
import VueMask from 'v-mask'
import VueRouter from 'vue-router'
import vco from "v-click-outside"
import router from './router/index'
import Scrollspy from 'vue2-scrollspy';
import VueSweetalert2 from 'vue-sweetalert2';
import VueLoading from 'vue-loading-overlay';
import 'vue-loading-overlay/dist/vue-loading.css';
import '@riophae/vue-treeselect/dist/vue-treeselect.css'
import LiquorTree from 'liquor-tree'
import TreeView from '@ll931217/vue-treeview'
import 'vue-tree-halower/dist/halower-tree.min.css'
import { VTree, VSelectTree } from 'vue-tree-halower'
import acl from './plugins/acl';
Vue.use (VTree)
Vue.use (VSelectTree)
import VJstree from 'vue-jstree'
// Toast
import Toast from "vue-toastification";
import "vue-toastification/dist/index.css";

import Notifications from 'vue-notification'

import "../src/design/app.scss";
import "@/assets/css/src/style.css";

import store from '@/state/store'

import App from './App.vue'

import {initFirebaseBackend} from './authUtils'
import i18n from './i18n'

import {configureFakeBackend} from './helpers/fake-backend';

import tinymce from 'vue-tinymce-editor'


const firebaseConfig = {
    apiKey: process.env.VUE_APP_APIKEY,
    authDomain: process.env.VUE_APP_AUTHDOMAIN,
    databaseURL: process.env.VUE_APP_VUE_APP_DATABASEURL,
    projectId: process.env.VUE_APP_PROJECTId,
    storageBucket: process.env.VUE_APP_STORAGEBUCKET,
    messagingSenderId: process.env.VUE_APP_MESSAGINGSENDERID,
    appId: process.env.VUE_APP_APPId,
    measurementId: process.env.VUE_APP_MEASUREMENTID
};

if (process.env.VUE_APP_DEFAULT_AUTH === "firebase") {
    initFirebaseBackend(firebaseConfig);
} else {
    configureFakeBackend();
}


Vue.component('tinymce', tinymce)
Vue.use(VueRouter)
Vue.use(Notifications)
Vue.use(vco)
Vue.use(Scrollspy);
const VueScrollTo = require('vue-scrollto')
Vue.use(VueScrollTo)
Vue.config.productionTip = false
const options = {
    // You can set your default options here
};

Vue.use(TreeView)
Vue.use(Toast, options);
Vue.use(VueLoading, {
    canCancel: false,
    color: '#000000',
    loader: 'spinner',
    width: 30,
    height: 30,
    backgroundColor: '#ffffff',
    opacity: 0.7,
    zIndex: 999,
}, {});
Vue.component(LiquorTree.name, LiquorTree)
Vue.use(VTree)
Vue.use(VSelectTree)
Vue.use(VJstree)
Vue.use(BootstrapVue)
Vue.use(Vuelidate)
Vue.use(VueMask)
Vue.use(require('vue-chartist'))
Vue.use(VueSweetalert2);
Vue.use(acl);
// Vue.use(VueMindmap)
Vue.use(VueGoogleMaps, {
    load: {
        key: 'AIzaSyCiwEL7SVslx6lJGL4I0fpD5OWhGAsshAs',
        libraries: 'places',
        region: 'VI',
        language: 'vi',
    },
    installComponents: true
});
Vue.component('apexchart', VueApexCharts)

new Vue({
    router,
    store,
    i18n,
    render: h => h(App)
}).$mount('#app')

Vue.filter('truncate', function (value, len = 50) {
    if (value) {
        if (value.length > len) {
            value = value.substring(0, len) + '...'
        }
        return value
    }
})