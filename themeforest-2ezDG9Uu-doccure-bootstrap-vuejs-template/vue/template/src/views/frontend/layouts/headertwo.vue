<template>
  <header class="header header-trans" v-bind:class="$route.meta.headerClass">
    <div class="container">
      <nav
        class="navbar navbar-expand-lg header-nav"
        v-bind:class="$route.meta.headerNavClass"
      >
        <div class="navbar-header">
          <a id="mobile_btn" href="javascript:void(0);" @click="toggleSidebar">
            <span class="bar-icon">
              <span></span>
              <span></span>
              <span></span>
            </span>
          </a>
          <router-link to="/" class="navbar-brand logo" v-if="isHomeFourRoute">
            <img src="@/assets/img/footer-logo.png" class="img-fluid" alt="Logo" />
          </router-link>

          <router-link to="/" class="navbar-brand logo" v-else>
            <img src="@/assets/img/logo.png" class="img-fluid" alt="Logo" />
          </router-link>
        </div>
        <div class="main-menu-wrapper">
          <div class="menu-header">
            <router-link to="/" class="menu-logo">
              <img src="@/assets/img/logo.png" class="img-fluid" alt="Logo" />
            </router-link>
            <a
              id="menu_close"
              class="menu-close"
              href="javascript:void(0);"
              @click="closeSidebar"
            >
              <i class="fas fa-times"></i>
            </a>
          </div>
          <mainmenu></mainmenu>
        </div>

        <ul class="nav header-navbar-rht" v-if="isHomeTwoRoute">
          <li class="nav-item">
            <router-link class="nav-link header-login" to="/login"
              >login / Signup
            </router-link>
          </li>
        </ul>
        <ul class="nav header-navbar-rht right-menu" v-else-if="isHomeFour1Route">
          <li class="nav-item">
            <router-link class="nav-link header-login white-bg" to="login"
              >login / Signup</router-link
            >
          </li>
        </ul>
        <ul class="nav header-navbar-rht" v-else-if="isHomeSixRoute">
          <li class="nav-item">
            <router-link class="nav-link header-login white-bg me-2" to="register"
              ><i class="feather-lock me-2"></i>Register</router-link
            >
          </li>
          <li class="nav-item">
            <router-link class="nav-link header-login btn-light-blue" to="login"
              ><i class="feather-user me-2"></i>Login</router-link
            >
          </li>
        </ul>
      </nav>
      <div
        class="sidebar-overlay"
        :class="{ opened: isSidebarOpen }"
        @click="closeSidebar"
      ></div>
    </div>
  </header>
</template>
<script>
export default {
  data() {
    return {
      isSidebarOpen: false,
    };
  },
  methods: {
    toggleSidebar() {
      this.isSidebarOpen = !this.isSidebarOpen;
      document.documentElement.classList.toggle("menu-opened");
    },
    closeSidebar() {
      this.isSidebarOpen = false;
      document.documentElement.classList.remove("menu-opened");
    },
  },
  computed: {
    isHomeTwoRoute() {
      return this.$route.path === "/index-2" || this.$route.path === "/index-3";
    },
    isHomeFourRoute() {
      return this.$route.path === "/index-4" || this.$route.path === "/index-6";
    },
    isHomeFour1Route() {
      return this.$route.path === "/index-4";
    },
    isHomeSixRoute() {
      return this.$route.path === "/index-6";
    },
  },
};
</script>
