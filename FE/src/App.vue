<script>
import appConfig from "@/app.config";
import {notificationMethods} from "@/state/helpers";
import {apiClient} from "@/state/modules/apiClient";
import Vue from "vue";
import moment from "moment";
import axios from "axios";

export default {
  name: "app",
  page: {
    // All subcomponent titles will be injected into this template.
    titleTemplate(title) {
      title = typeof title === "function" ? title(this.$store) : title;
      return title ? `${title} | ${appConfig.title}` : appConfig.title;
    },
  },
  mounted() {
    // document.querySelector("html").setAttribute('dir', 'rtl')
  },
  async created() {
    //  Check Auth when run app
    const token = localStorage.getItem('user-token')
    const auth = localStorage.getItem('auth-user')
    let authParse = JSON.parse(auth)
    if (authParse) {
      // const d = moment(authParse.expiryDate, "DD/MM/YYYY");
      // let dn = moment();
      // if (authParse.token && d > dn) {
      //   Vue.prototype.$auth_token = authParse.token;
      // } else {
      //   localStorage.removeItem("user-token");
      //   localStorage.removeItem("auth-user");
      //   localStorage.removeItem("TabData");
      //   localStorage.removeItem("menuItems");
      //   // this.$router.push("/dang-nhap");
      //   window.location.href = "/dang-nhap"
      // }
    }
    const options = {
      method: 'POST',
      headers: { 'content-type': 'application/x-www-form-urlencoded', 'Authorization': 'Basic YTJKNWRGOWtiMjVuZEdoaGNGOXdjbTlrOiBRQ05zYjI1bmMyaGxiaUVoTVRJelFBPT0=' },
      data:new URLSearchParams({
        grant_type: 'client_credentials', //gave the values directly for testing
      }),
      url: 'https://api.dongthap.gov.vn/token',
    };

    const response = await axios(options);
    localStorage.setItem("token-dt", response.data?.access_token);
  },
  watch: {
    /**
     * Clear the alert message on route change
     */
    // eslint-disable-next-line no-unused-vars
    $route(to, from) {
      // clear alert on location change
      this.clearNotification();
      this.setMenuId()
    },
  },
  methods: {
    clearNotification: notificationMethods.clear,
    setMenuId() {
      const menuItems = localStorage.getItem('menuItems')
      let currentMenu = localStorage.getItem('currentMenuId')
      if (menuItems) {
        let menus = JSON.parse(menuItems);
        let path = this.$route.path;
        if (path == "/") {
          let active = menus.find(x => x.active == true);
          if (active)
            localStorage.setItem("currentMenuId", active.id)
        } else {
          let active = menus.find(x => x.path == path && x.id == currentMenu);
          if (active)
            localStorage.setItem("currentMenuId", active.id)
          else {
            let active = menus.find(x => x.path == path);
            if (active)
              localStorage.setItem("currentMenuId", active.id)
          }
        }
      }
      currentMenu = localStorage.getItem('currentMenuId')
      if (currentMenu) {
        Vue.prototype.menuId = currentMenu;
      }
    }
  },
};
</script>

<template>
  <div id="app">
    <!--    <notifications group="foo" />-->

    <!-- Custom template example -->
    <notifications group="custom-template"
                   :duration="5000"
                   :width="500"
                   animation-name="v-fade-left"
                   position="top right">

      <template slot="body" slot-scope="props">
        <div class="custom-template">
          <div class="custom-template-icon">
            <i class="bx bx-error-circle"></i>
          </div>
          <div class="custom-template-content">
            <div class="custom-template-title">
              {{ props.item.title }}
            </div>
            <div class="custom-template-text"
                 v-html="props.item.text"></div>
          </div>
        </div>
      </template>
    </notifications>

    <RouterView/>
  </div>
</template>

<style>
.custom-template {
  display: flex;
  flex-direction: row;
  flex-wrap: nowrap;
  text-align: left;
  font-size: 13px;
  margin: 5px;
  margin-bottom: 0;
  margin-left: 10px;
  align-items: center;
  justify-content: center;
  background: #fdedef;
  box-shadow: rgba(50, 50, 93, 0.25) 0px 6px 12px -2px, rgba(0, 0, 0, 0.3) 0px 3px 7px -3px;
  border-radius: 3px;
}

.custom-template, .custom-template > div {
  box-sizing: border-box;
}

.custom-template .custom-template-icon {
  flex: 0 1 auto;
  color: #ef4d61;
  font-size: 32px;
  padding: 0 10px;
}

.custom-template .custom-template-close {
  flex: 0 1 auto;
  padding: 0 20px;
  font-size: 16px;
  opacity: 0.2;
  cursor: pointer;
}

.custom-template .custom-template-close :hover {
  opacity: 0.8;
}

.custom-template .custom-template-content {
  padding: 10px;
  flex: 1 0 auto;
}

.custom-template .custom-template-content .custom-template-title {
  letter-spacing: 1px;
  text-transform: uppercase;
  font-size: 10px;
  font-weight: 600;
}
.pac-container {
  z-index: 99999999;
}
</style>
