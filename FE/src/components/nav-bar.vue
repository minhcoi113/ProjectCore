<script>

import i18n from "../i18n";
import { authComputed } from "@/state/helpers";

/**
 * Nav-bar Component
 */
export default {
  data() {
    return {
      url: process.env.VUE_APP_API_URL + 'files/view/',
      lan: i18n.locale,
      text: null,
      flag: null,
      value: null,
      myVar: 1,
      currentUserAuth: null
    };
  },
  components: {},
  mounted() {
    // this.value = this.languages.find((x) => x.language === i18n.locale);
    // this.text = this.value.title;
    // this.flag = this.value.flag;
  },
  created() {
    let authUser = localStorage.getItem("auth-user");
    if (authUser) {
      let jsonUserCurrent = JSON.parse(authUser);
      this.currentUserAuth = jsonUserCurrent;
    }
  },
  methods: {
    toggleMenu() {
      this.$parent.toggleMenu();
    },
    toggleRightSidebar() {
      this.$parent.toggleRightSidebar();
    },
    initFullScreen() {
      document.body.classList.toggle("fullscreen-enable");
      if (
        !document.fullscreenElement &&
        /* alternative standard method */ !document.mozFullScreenElement &&
        !document.webkitFullscreenElement
      ) {
        // current working methods
        if (document.documentElement.requestFullscreen) {
          document.documentElement.requestFullscreen();
        } else if (document.documentElement.mozRequestFullScreen) {
          document.documentElement.mozRequestFullScreen();
        } else if (document.documentElement.webkitRequestFullscreen) {
          document.documentElement.webkitRequestFullscreen(
            Element.ALLOW_KEYBOARD_INPUT
          );
        }
      } else {
        if (document.cancelFullScreen) {
          document.cancelFullScreen();
        } else if (document.mozCancelFullScreen) {
          document.mozCancelFullScreen();
        } else if (document.webkitCancelFullScreen) {
          document.webkitCancelFullScreen();
        }
      }
    },
    logoutUser() {
      // eslint-disable-next-line no-unused-vars
      var userLocalStorage = localStorage.getItem("user-token");
      if (userLocalStorage) {
        localStorage.removeItem("user-token");
        localStorage.removeItem("auth-user");
        localStorage.removeItem("menuItems");
        let checkTabData = localStorage.getItem("TabData");
        if (checkTabData) {
          localStorage.removeItem("TabData");
        }
        window.location.href = "/dang-nhap"
        return;
      }
    },
    handleThongTinCaNhan() {
      this.$router.push("/thong-tin-ca-nhan");
    }
  },
  computed: {
    ...authComputed,
  },
};
</script>
<template>
  <header id="page-topbar">
    <div class="navbar-header" style="background: #082957">
      <div class="d-flex">
        <!-- LOGO -->
        <div class="navbar-brand-box">
          <router-link to="/" class="logo logo-dark">
            <span class="logo-sm">
              <img src="@/assets/images/logo.png" alt height="22" />
            </span>
            <span class="logo-lg">
              <img src="@/assets/images/logo.png" alt height="17" />
            </span>
          </router-link>
          <router-link to="/" class="logo logo-light">
            <span class="logo-sm">
              <img src="@/assets/images/logo.png" alt height="30" />
            </span>
            <span class="logo-lg">
              <img src="@/assets/images/logo.png" alt height="55" />
            </span>
          </router-link>
        </div>
        <button id="vertical-menu-btn" type="button" class="btn btn-sm px-3 font-size-16 header-item"
          @click="toggleMenu">
          <i class="fa fa-fw fa-bars"></i>
        </button>
        <!-- App Search-->
        <form class="app-search" style="display: flex; justify-content: center; align-items: center">
          <div class="text-white" style="font-weight: bold; font-size: 15px">
            QUẢN LÝ CÔNG VIỆC
          </div>
        </form>
      </div>
      <div class="d-flex">

        <div class="dropdown d-none d-lg-inline-block ms-1">
          <button type="button" class="btn header-item noti-icon pt-4" @click="initFullScreen" style="margin-top:5px">
            <i class="bx bx-fullscreen"></i>
          </button>
        </div>
        <b-dropdown right variant="black" toggle-class="header-item" menu-class="dropdown-menu-end">
          <template v-slot:button-content>
            <span>
              <span v-if="currentUserAuth && currentUserAuth.avatar">
                <b-img :src="url + `${currentUserAuth.avatar.fileId}`" alt="Avatar"
                  class="rounded-circle header-profile-user mb-3">
                </b-img>
              </span>
              <span v-else>
                <img class="rounded-circle header-profile-user mb-3" src="@/assets/images/avatar-default.png"
                  alt="Avatar" />
              </span>
            </span>&nbsp;
            <span class="d-none d-xl-inline-block ms-1 mt-3">
              <div v-if="currentUserAuth" style="font-size: 10px;">
                <div style="font-size: 12px">
                  {{ currentUserAuth.name }}
                  <i class="mdi mdi-chevron-down d-none d-xl-inline "></i>
                </div>
                <div class="text-start">
                  @{{ currentUserAuth.userName }}
                </div>
              </div>
              <div v-else>
                User
              </div>
            </span>
          </template>
          <b-dropdown-item>
            <a v-on:click="handleThongTinCaNhan">

              <span>
                <i class="bx bx-user font-size-16 align-middle me-1"></i>
                Thông tin cá nhân
              </span>
            </a>
          </b-dropdown-item>
          <b-dropdown-divider></b-dropdown-divider>
          <a v-on:click="logoutUser" class="dropdown-item text-danger">
            <i class="bx bx-power-off font-size-16 align-middle me-1 text-danger"></i>
            Đăng xuất
          </a>
        </b-dropdown>

      </div>
    </div>
  </header>
</template>
