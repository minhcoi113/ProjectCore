<template>
  <!-- Header -->
  <div class="header">
    <!-- Logo -->
    <div class="header-left">
      <router-link to="/pharmacy/index" class="logo">
        <img src="@/assets/pharmacy/img/logo.png" alt="Logo" />
      </router-link>

      <router-link to="/pharmacy/index" class="logo logo-small">
        <img
          src="@/assets/pharmacy/img/logo-small.png"
          alt="Logo"
          width="30"
          height="30"
        />
      </router-link>
    </div>
    <!-- /Logo -->

    <a href="javascript:void(0);" id="toggle_btn" @click="toggleSidebar">
      <i class="fe fe-text-align-left"></i>
    </a>

    <div class="top-nav-search">
      <form>
        <input type="text" class="form-control" placeholder="Search here" />
        <b-button class="btn" type="submit"><i class="fa fa-search"></i></b-button>
      </form>
    </div>

    <!-- Mobile Menu Toggle -->
    <a class="mobile_btn" id="mobile_btn" @click="toggleSidebar1">
      <i class="fa fa-bars"></i>
    </a>
    <!-- /Mobile Menu Toggle -->

    <!-- Header Right Menu -->
    <ul class="nav user-menu">
      <!-- Notifications -->
      <li class="nav-item dropdown noti-dropdown">
        <a href="javascript:;" class="dropdown-toggle nav-link" data-bs-toggle="dropdown">
          <i class="fe fe-bell"></i> <span class="badge rounded-pill">3</span>
        </a>
        <div class="dropdown-menu notifications">
          <div class="topnav-dropdown-header">
            <span class="notification-title">Notifications</span>
            <a href="javascript:void(0)" class="clear-noti"> Clear All </a>
          </div>
          <div class="noti-content">
            <ul class="notification-list">
              <li class="notification-message">
                <a href="javascript:void(0)">
                  <div class="media d-flex">
                    <span class="avatar avatar-sm flex-shrink-0">
                      <img
                        class="avatar-img rounded-circle"
                        alt="User Image"
                        src="@/assets/pharmacy/img/doctors/doctor-thumb-01.jpg"
                      />
                    </span>
                    <div class="media-body flex-grow-1">
                      <p class="noti-details">
                        <span class="noti-title">Dr. Ruby Perrin</span> Schedule
                        <span class="noti-title">her appointment</span>
                      </p>
                      <p class="noti-time">
                        <span class="notification-time">4 mins ago</span>
                      </p>
                    </div>
                  </div>
                </a>
              </li>
              <li class="notification-message">
                <a href="javascript:void(0)">
                  <div class="media d-flex">
                    <span class="avatar avatar-sm flex-shrink-0">
                      <img
                        class="avatar-img rounded-circle"
                        alt="User Image"
                        src="@/assets/pharmacy/img/profiles/avatar-01.jpg"
                      />
                    </span>
                    <div class="media-body flex-grow-1">
                      <p class="noti-details">
                        <span class="noti-title">Charlene Reed</span> has booked her
                        appointment to <span class="noti-title">Dr. Ruby Perrin</span>
                      </p>
                      <p class="noti-time">
                        <span class="notification-time">6 mins ago</span>
                      </p>
                    </div>
                  </div>
                </a>
              </li>
              <li class="notification-message">
                <a href="javascript:void(0)">
                  <div class="media d-flex">
                    <span class="avatar avatar-sm flex-shrink-0">
                      <img
                        class="avatar-img rounded-circle"
                        alt="User Image"
                        src="@/assets/pharmacy/img/profiles/avatar-02.jpg"
                      />
                    </span>
                    <div class="media-body flex-grow-1">
                      <p class="noti-details">
                        <span class="noti-title">Travis Trimble</span> sent a amount of
                        $210 for his <span class="noti-title">appointment</span>
                      </p>
                      <p class="noti-time">
                        <span class="notification-time">8 mins ago</span>
                      </p>
                    </div>
                  </div>
                </a>
              </li>
              <li class="notification-message">
                <a href="javascript:void(0)">
                  <div class="media d-flex">
                    <span class="avatar avatar-sm flex-shrink-0">
                      <img
                        class="avatar-img rounded-circle"
                        alt="User Image"
                        src="@/assets/pharmacy/img/profiles/avatar-03.jpg"
                      />
                    </span>
                    <div class="media-body flex-grow-1">
                      <p class="noti-details">
                        <span class="noti-title">Carl Kelly</span> send a message
                        <span class="noti-title"> to his doctor</span>
                      </p>
                      <p class="noti-time">
                        <span class="notification-time">12 mins ago</span>
                      </p>
                    </div>
                  </div>
                </a>
              </li>
            </ul>
          </div>
          <div class="topnav-dropdown-footer">
            <a href="javascript:void(0)">View all Notifications</a>
          </div>
        </div>
      </li>
      <!-- /Notifications -->

      <!-- User Menu -->
      <li class="nav-item dropdown has-arrow">
        <a
          href="javascript:void(0)"
          class="dropdown-toggle nav-link"
          data-bs-toggle="dropdown"
        >
          <span class="user-img"
            ><img
              class="rounded-circle"
              src="@/assets/pharmacy/img/profiles/avatar-01.jpg"
              width="31"
              alt="Ryan Taylor"
          /></span>
        </a>
        <div class="dropdown-menu">
          <div class="user-header">
            <div class="avatar avatar-sm">
              <img
                src="@/assets/pharmacy/img/profiles/avatar-01.jpg"
                alt="User Image"
                class="avatar-img rounded-circle"
              />
            </div>
            <div class="user-text">
              <h6>Ryan Taylor</h6>
              <p class="text-muted mb-0">Administrator</p>
            </div>
          </div>
          <router-link class="dropdown-item" to="/pharmacy/profile"
            >My Profile</router-link
          >
          <router-link class="dropdown-item" to="/pharmacy/settings"
            >Settings</router-link
          >
          <router-link class="dropdown-item" to="/pharmacy/login">Logout</router-link>
        </div>
      </li>
      <!-- /User Menu -->
    </ul>
    <!-- /Header Right Menu -->
  </div>
  <!-- /Header -->
</template>

<script>
export default {
  data() {
    return {};
  },
  mounted() {
    // Add scroll event listener
    // window.addEventListener("scroll", () => {
    //   var scroll = window.pageYOffset || document.documentElement.scrollTop;
    //   var header = document.getElementsByClassName("header")[0];

    //   if (scroll < 100) {
    //     header.classList.remove("sticky");
    //   } else {
    //     header.classList.add("sticky");
    //   }
    // });

    // Add click event listener
    this.$nextTick(() => {
      document.addEventListener("click", this.handleToggleClick);
    });

    // Add mouseover event listener
    document.addEventListener("mouseover", (event) => {
      event.stopPropagation();

      var body = document.body;
      var toggleBtn = document.getElementById("toggle_btn");
      var sidebar = document.getElementsByClassName("sidebar")[0];
      var subdropUL = document.getElementsByClassName("subdrop");

      if (body.classList.contains("mini-sidebar") && toggleBtn.style.display !== "none") {
        var target = event.target.closest(".sidebar");

        if (target) {
          body.classList.add("expand-menu");
          for (var i = 0; i < subdropUL.length; i++) {
            var ul = subdropUL[i].nextElementSibling;
            if (ul) {
              ul.style.display = "block";
            }
          }
        } else {
          body.classList.remove("expand-menu");
          for (var i = 0; i < subdropUL.length; i++) {
            var ul = subdropUL[i].nextElementSibling;
            if (ul) {
              ul.style.display = "none";
            }
          }
        }

        event.preventDefault();
      }
    });
  },
  beforeUnmount() {
    document.removeEventListener("click", this.handleToggleClick);
  },

  methods: {
    toggleSidebar1() {
      const body = document.body;
      body.classList.toggle("slide-nav");
    },
    toggleSidebar() {
      const body = document.body;
      body.classList.toggle("mini-sidebar");
    },
  },
};
</script>
