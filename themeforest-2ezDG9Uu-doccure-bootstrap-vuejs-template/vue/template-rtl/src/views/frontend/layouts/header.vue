<template>
  <!-- Header -->
  <header class="header header-fixed" v-if="isHomeOneRoute" :class="{ 'header-one': true, 'header-space': isScrolled }">
    <div class="container">
      <nav class="navbar navbar-expand-lg header-nav">
        <div class="navbar-header">
          <a id="mobile_btn" href="javascript:void(0);" @click="toggleSidebar">
            <span class="bar-icon">
              <span></span>
              <span></span>
              <span></span>
            </span>
          </a>
          <router-link to="/" class="navbar-brand logo">
            <img src="@/assets/img/logo.png" class="img-fluid" alt="Logo" />
          </router-link>
        </div>
        <div class="main-menu-wrapper">
          <div class="menu-header">
            <router-link to="/" class="menu-logo">
              <img src="@/assets/img/logo.png" class="img-fluid" alt="Logo" />
            </router-link>
            <a id="menu_close" class="menu-close" href="javascript:void(0);" @click="closeSidebar">
              <i class="fas fa-times"></i>
            </a>
          </div>
          <mainnav></mainnav>
        </div>
        <ul class="nav header-navbar-rht" v-if="isHomeAccRoute">
          <!-- Cart -->
          <li class="nav-item dropdown noti-nav view-cart-header me-3">
            <a href="javascript:;" class="dropdown-toggle nav-link p-0 position-relative" data-bs-toggle="dropdown">
              <i class="fa-solid fa-cart-shopping"></i>
              <small class="unread-msg1">7</small>
            </a>
            <div class="dropdown-menu notifications dropdown-menu-end">
              <div class="shopping-cart">
                <ul class="shopping-cart-items list-unstyled">
                  <li class="clearfix">
                    <div class="close-icon"><i class="fa-solid fa-circle-xmark"></i></div>
                    <router-link to="product-description"><img class="avatar-img rounded"
                        src="@/assets/img/products/product.jpg" alt="User Image" /></router-link>
                    <router-link to="product-description" class="item-name">Benzaxapine Croplex</router-link>
                    <span class="item-price">$849.99</span>
                    <span class="item-quantity">Quantity: 01</span>
                  </li>

                  <li class="clearfix">
                    <div class="close-icon"><i class="fa-solid fa-circle-xmark"></i></div>
                    <router-link to="product-description"><img class="avatar-img rounded"
                        src="@/assets/img/products/product1.jpg" alt="User Image" /></router-link>
                    <router-link to="product-description" class="item-name">Ombinazol Bonibamol</router-link>
                    <span class="item-price">$1,249.99</span>
                    <span class="item-quantity">Quantity: 01</span>
                  </li>

                  <li class="clearfix">
                    <div class="close-icon"><i class="fa-solid fa-circle-xmark"></i></div>
                    <router-link to="product-description"><img class="avatar-img rounded"
                        src="@/assets/img/products/product2.jpg" alt="User Image" /></router-link>
                    <router-link to="product-description" class="item-name">Dantotate Dantodazole</router-link>
                    <span class="item-price">$129.99</span>
                    <span class="item-quantity">Quantity: 01</span>
                  </li>
                </ul>
                <div class="booking-summary pt-3">
                  <div class="booking-item-wrap">
                    <ul class="booking-date">
                      <li>Subtotal <span>$5,877.00</span></li>
                      <li>Shipping <span>$25.00</span></li>
                      <li>Tax <span>$0.00</span></li>
                      <li>Total <span>$5.2555</span></li>
                    </ul>
                    <div class="booking-total">
                      <ul class="booking-total-list text-align">
                        <li>
                          <div class="clinic-booking pt-3">
                            <router-link class="apt-btn" to="cart">View Cart</router-link>
                          </div>
                        </li>
                        <li>
                          <div class="clinic-booking pt-3">
                            <router-link class="apt-btn" to="product-checkout">Checkout</router-link>
                          </div>
                        </li>
                      </ul>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </li>
          <!-- /Cart -->

          <!-- Notifications -->
          <li class="nav-item dropdown noti-nav me-3 pe-0">
            <a href="javascript:;" class="dropdown-toggle nav-link p-0" data-bs-toggle="dropdown">
              <i class="fa-solid fa-bell"></i> <span class="badge">5</span>
            </a>
            <div class="dropdown-menu notifications dropdown-menu-end">
              <div class="topnav-dropdown-header">
                <span class="notification-title">Notifications</span>
              </div>
              <div class="noti-content">
                <ul class="notification-list">
                  <li class="notification-message">
                    <a href="javascript:;">
                      <div class="notify-block d-flex">
                        <span class="avatar">
                          <img class="avatar-img" alt="Ruby perin" src="@/assets/img/clients/client-01.jpg" />
                        </span>
                        <div class="media-body">
                          <h6>
                            Travis Tremble <span class="notification-time">18.30 PM</span>
                          </h6>
                          <p class="noti-details">
                            Sent a amount of $210 for his Appointment
                            <span class="noti-title">Dr.Ruby perin </span>
                          </p>
                        </div>
                      </div>
                    </a>
                  </li>
                  <li class="notification-message">
                    <a href="javascript:;">
                      <div class="notify-block d-flex">
                        <span class="avatar">
                          <img class="avatar-img" alt="Hendry Watt" src="@/assets/img/clients/client-02.jpg" />
                        </span>
                        <div class="media-body">
                          <h6>
                            Travis Tremble
                            <span class="notification-time">12 Min Ago</span>
                          </h6>
                          <p class="noti-details">
                            has booked her appointment to
                            <span class="noti-title">Dr. Hendry Watt</span>
                          </p>
                        </div>
                      </div>
                    </a>
                  </li>
                  <li class="notification-message">
                    <a href="javascript:;">
                      <div class="notify-block d-flex">
                        <div class="avatar">
                          <img class="avatar-img" alt="Maria Dyen" src="@/assets/img/clients/client-03.jpg" />
                        </div>
                        <div class="media-body">
                          <h6>
                            Travis Tremble
                            <span class="notification-time">6 Min Ago</span>
                          </h6>
                          <p class="noti-details">
                            Sent a amount $210 for his Appointment
                            <span class="noti-title">Dr.Maria Dyen</span>
                          </p>
                        </div>
                      </div>
                    </a>
                  </li>
                  <li class="notification-message">
                    <a href="javascript:;">
                      <div class="notify-block d-flex">
                        <div class="avatar avatar-sm">
                          <img class="avatar-img" alt="client-image" src="@/assets/img/clients/client-04.jpg" />
                        </div>
                        <div class="media-body">
                          <h6>
                            Travis Tremble <span class="notification-time">8.30 AM</span>
                          </h6>
                          <p class="noti-details">Send a message to his doctor</p>
                        </div>
                      </div>
                    </a>
                  </li>
                </ul>
              </div>
            </div>
          </li>
          <!-- /Notifications -->

          <!-- User Menu -->
          <li class="nav-item dropdown has-arrow logged-item">
            <a href="javascript:;" class="dropdown-toggle nav-link" data-bs-toggle="dropdown">
              <span class="user-img">
                <img class="rounded-circle" src="@/assets/img/doctors/doctor-thumb-02.jpg" width="31"
                  alt="Darren Elder" />
              </span>
            </a>
            <div class="dropdown-menu dropdown-menu-end">
              <div class="user-header">
                <div class="avatar avatar-sm">
                  <img src="@/assets/img/doctors/doctor-thumb-02.jpg" alt="User Image"
                    class="avatar-img rounded-circle" />
                </div>
                <div class="user-text">
                  <h6>Darren Elder</h6>
                  <p class="text-muted mb-0">Doctor</p>
                </div>
              </div>
              <router-link class="dropdown-item" to="doctor-dashboard">Dashboard</router-link>
              <router-link class="dropdown-item" to="doctor-profile-settings">Profile Settings</router-link>
              <router-link class="dropdown-item" to="login">Logout</router-link>
            </div>
          </li>
          <!-- /User Menu -->
        </ul>
        <ul class="nav header-navbar-rht" v-if="isHomeBillRoute">
          <!-- User Menu -->
          <li class="nav-item dropdown has-arrow logged-item">
            <a href="javascript:;" class="dropdown-toggle nav-link" data-bs-toggle="dropdown">
              <span class="user-img">
                <img class="rounded-circle" src="@/assets/img/patients/patient.jpg" width="31" alt="Darren Elder" />
              </span>
            </a>
            <div class="dropdown-menu dropdown-menu-end">
              <div class="user-header">
                <div class="avatar avatar-sm">
                  <img src="@/assets/img/patients/patient.jpg" alt="User Image" class="avatar-img rounded-circle" />
                </div>
                <div class="user-text">
                  <h6>Darren Elder</h6>
                  <p class="text-muted mb-0">Doctor</p>
                </div>
              </div>
              <router-link class="dropdown-item" to="doctor-dashboard">Dashboard</router-link>
              <router-link class="dropdown-item" to="doctor-profile-settings">Profile Settings</router-link>
              <router-link class="dropdown-item" to="login">Logout</router-link>
            </div>
          </li>
          <!-- /User Menu -->
        </ul>
        <ul class="nav header-navbar-rht" v-if="isHomeprescriptionRoute">
          <!-- User Menu -->
          <li class="nav-item dropdown has-arrow logged-item">
            <a href="javascript:;" class="dropdown-toggle nav-link" data-bs-toggle="dropdown">
              <span class="user-img">
                <img class="rounded-circle" src="@/assets/img/doctors/doctor-thumb-02.jpg" width="31"
                  alt="Darren Elder" />
              </span>
            </a>
            <div class="dropdown-menu dropdown-menu-end">
              <div class="user-header">
                <div class="avatar avatar-sm">
                  <img src="@/assets/img/doctors/doctor-thumb-02.jpg" alt="User Image"
                    class="avatar-img rounded-circle" />
                </div>
                <div class="user-text">
                  <h6>Darren Elder</h6>
                  <p class="text-muted mb-0">Doctor</p>
                </div>
              </div>
              <router-link class="dropdown-item" to="doctor-dashboard">Dashboard</router-link>
              <router-link class="dropdown-item" to="doctor-profile-settings">Profile Settings</router-link>
              <router-link class="dropdown-item" to="login">Logout</router-link>
            </div>
          </li>
          <!-- /User Menu -->
        </ul>
        <ul class="nav header-navbar-rht" v-if="isHomepatientRoute">
          <!-- Cart -->
          <li class="nav-item dropdown noti-nav view-cart-header me-3">
            <a href="javascript:;" class="dropdown-toggle nav-link p-0 position-relative" data-bs-toggle="dropdown">
              <i class="fa-solid fa-cart-shopping"></i>
              <small class="unread-msg1">7</small>
            </a>
            <div class="dropdown-menu notifications dropdown-menu-end">
              <div class="shopping-cart">
                <ul class="shopping-cart-items list-unstyled">
                  <li class="clearfix">
                    <div class="close-icon"><i class="fa-solid fa-circle-xmark"></i></div>
                    <router-link to="product-description"><img class="avatar-img rounded"
                        src="@/assets/img/products/product.jpg" alt="User Image" /></router-link>
                    <router-link to="product-description" class="item-name">Benzaxapine Croplex</router-link>
                    <span class="item-price">$849.99</span>
                    <span class="item-quantity">Quantity: 01</span>
                  </li>

                  <li class="clearfix">
                    <div class="close-icon"><i class="fa-solid fa-circle-xmark"></i></div>
                    <router-link to="product-description"><img class="avatar-img rounded"
                        src="@/assets/img/products/product1.jpg" alt="User Image" /></router-link>
                    <router-link to="product-description" class="item-name">Ombinazol Bonibamol</router-link>
                    <span class="item-price">$1,249.99</span>
                    <span class="item-quantity">Quantity: 01</span>
                  </li>

                  <li class="clearfix">
                    <div class="close-icon"><i class="fa-solid fa-circle-xmark"></i></div>
                    <router-link to="product-description"><img class="avatar-img rounded"
                        src="@/assets/img/products/product2.jpg" alt="User Image" /></router-link>
                    <router-link to="product-description" class="item-name">Dantotate Dantodazole</router-link>
                    <span class="item-price">$129.99</span>
                    <span class="item-quantity">Quantity: 01</span>
                  </li>
                </ul>
                <div class="booking-summary pt-3">
                  <div class="booking-item-wrap">
                    <ul class="booking-date">
                      <li>Subtotal <span>$5,877.00</span></li>
                      <li>Shipping <span>$25.00</span></li>
                      <li>Tax <span>$0.00</span></li>
                      <li>Total <span>$5.2555</span></li>
                    </ul>
                    <div class="booking-total">
                      <ul class="booking-total-list text-align">
                        <li>
                          <div class="clinic-booking pt-3">
                            <router-link class="apt-btn" to="cart">View Cart</router-link>
                          </div>
                        </li>
                        <li>
                          <div class="clinic-booking pt-3">
                            <router-link class="apt-btn" to="product-checkout">Checkout</router-link>
                          </div>
                        </li>
                      </ul>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </li>
          <!-- /Cart -->

          <!-- Notifications -->
          <li class="nav-item dropdown noti-nav me-3 pe-0">
            <a href="javascript:;" class="dropdown-toggle nav-link p-0" data-bs-toggle="dropdown">
              <i class="fa-solid fa-bell"></i> <span class="badge">5</span>
            </a>
            <div class="dropdown-menu notifications dropdown-menu-end">
              <div class="topnav-dropdown-header">
                <span class="notification-title">Notifications</span>
              </div>
              <div class="noti-content">
                <ul class="notification-list">
                  <li class="notification-message">
                    <a href="javascript:;">
                      <div class="notify-block d-flex">
                        <span class="avatar">
                          <img class="avatar-img" alt="Ruby perin" src="@/assets/img/clients/client-01.jpg" />
                        </span>
                        <div class="media-body">
                          <h6>
                            Travis Tremble <span class="notification-time">18.30 PM</span>
                          </h6>
                          <p class="noti-details">
                            Sent a amount of $210 for his Appointment
                            <span class="noti-title">Dr.Ruby perin </span>
                          </p>
                        </div>
                      </div>
                    </a>
                  </li>
                  <li class="notification-message">
                    <a href="javascript:;">
                      <div class="notify-block d-flex">
                        <span class="avatar">
                          <img class="avatar-img" alt="Hendry Watt" src="@/assets/img/clients/client-02.jpg" />
                        </span>
                        <div class="media-body">
                          <h6>
                            Travis Tremble
                            <span class="notification-time">12 Min Ago</span>
                          </h6>
                          <p class="noti-details">
                            has booked her appointment to
                            <span class="noti-title">Dr. Hendry Watt</span>
                          </p>
                        </div>
                      </div>
                    </a>
                  </li>
                  <li class="notification-message">
                    <a href="javascript:;">
                      <div class="notify-block d-flex">
                        <div class="avatar">
                          <img class="avatar-img" alt="Maria Dyen" src="@/assets/img/clients/client-03.jpg" />
                        </div>
                        <div class="media-body">
                          <h6>
                            Travis Tremble
                            <span class="notification-time">6 Min Ago</span>
                          </h6>
                          <p class="noti-details">
                            Sent a amount $210 for his Appointment
                            <span class="noti-title">Dr.Maria Dyen</span>
                          </p>
                        </div>
                      </div>
                    </a>
                  </li>
                  <li class="notification-message">
                    <a href="javascript:;">
                      <div class="notify-block d-flex">
                        <div class="avatar avatar-sm">
                          <img class="avatar-img" alt="client-image" src="@/assets/img/clients/client-04.jpg" />
                        </div>
                        <div class="media-body">
                          <h6>
                            Travis Tremble <span class="notification-time">8.30 AM</span>
                          </h6>
                          <p class="noti-details">Send a message to his doctor</p>
                        </div>
                      </div>
                    </a>
                  </li>
                </ul>
              </div>
            </div>
          </li>
          <!-- /Notifications -->

          <!-- User Menu -->
          <li class="nav-item dropdown has-arrow logged-item">
            <a href="javacript:;" class="dropdown-toggle nav-link" data-bs-toggle="dropdown">
              <span class="user-img">
                <img class="rounded-circle" src="@/assets/img/patients/patient.jpg" width="31" alt="Darren Elder" />
              </span>
            </a>
            <div class="dropdown-menu dropdown-menu-end">
              <div class="user-header">
                <div class="avatar avatar-sm">
                  <img src="@/assets/img/patients/patient.jpg" alt="User Image" class="avatar-img rounded-circle" />
                </div>
                <div class="user-text">
                  <h6>Richard Wilson</h6>
                  <p class="text-muted mb-0">Patient</p>
                </div>
              </div>
              <router-link class="dropdown-item" to="doctor-dashboard">Dashboard</router-link>
              <router-link class="dropdown-item" to="profile-settings">Profile Settings</router-link>
              <router-link class="dropdown-item" to="login">Logout</router-link>
            </div>
          </li>
          <!-- /User Menu -->
        </ul>
      </nav>
      <div class="sidebar-overlay" :class="{ opened: isSidebarOpen }" @click="closeSidebar"></div>
    </div>
  </header>
  <header class="header" v-else-if="isHomePharmacyRoute">
    <div class="container">
      <nav class="navbar navbar-expand-lg header-nav">
        <div class="navbar-header">
          <a id="mobile_btn" href="javascript:void(0);" @click="toggleSidebar">
            <span class="bar-icon">
              <span></span>
              <span></span>
              <span></span>
            </span>
          </a>
          <router-link to="/" class="navbar-brand logo">
            <img src="@/assets/img/logo.png" class="img-fluid" alt="Logo" />
          </router-link>
        </div>
        <div class="main-menu-wrapper">
          <div class="menu-header">
            <router-link to="/" class="menu-logo">
              <img src="@/assets/img/logo.png" class="img-fluid" alt="Logo" />
            </router-link>
            <a id="menu_close" class="menu-close" href="javascript:void(0);" @click="closeSidebar">
              <i class="fas fa-times"></i>
            </a>
          </div>
          <mainnav></mainnav>
        </div>
        <ul class="nav header-navbar-rht">
          <li class="nav-item contact-item">
            <div class="header-contact-img">
              <i class="far fa-hospital"></i>
            </div>
            <div class="header-contact-detail">
              <p class="contact-header">Contact</p>
              <p class="contact-info-header">+1 315 369 5943</p>
            </div>
          </li>
          <li class="nav-item">
            <router-link class="nav-link header-login" to="login">login / Signup
            </router-link>
          </li>
        </ul>
      </nav>
      <div class="sidebar-overlay" :class="{ opened: isSidebarOpen }" @click="closeSidebar"></div>
    </div>
  </header>
  <header class="header header-fixed" v-else v-bind:class="$route.meta.headerClass">
    <div class="container">
      <nav class="navbar navbar-expand-lg header-nav">
        <div class="navbar-header">
          <a id="mobile_btn" href="javascript:void(0);" @click="toggleSidebar">
            <span class="bar-icon">
              <span></span>
              <span></span>
              <span></span>
            </span>
          </a>
          <router-link to="/" class="navbar-brand logo" v-if="isHomeFive1Route">
            <img src="@/assets/img/logo-white.svg" class="img-fluid" alt="Logo" />
          </router-link>
          <router-link to="/" class="navbar-brand logo" v-else-if="isHomeSevenRoute">
            <img src="@/assets/img/logo.svg" class="img-fluid" alt="Logo" />
          </router-link>
          <router-link to="/" class="navbar-brand logo" v-else-if="isHomeNineRoute">
            <img src="@/assets/img/logo-03.png" class="img-fluid" alt="Logo" />
          </router-link>
          <router-link to="/" class="navbar-brand logo" v-else-if="isHomeTenRoute">
            <img src="@/assets/img/logo-15.png" class="img-fluid" alt="Logo" />
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
            <a id="menu_close" class="menu-close" href="javascript:void(0);" @click="closeSidebar">
              <i class="fas fa-times"></i>
            </a>
          </div>
          <mainnav></mainnav>
        </div>
        <ul class="nav header-navbar-rht" v-if="isHomeFiveRoute">
          <li class="register-btn">
            <router-link to="login-email" class="btn log-btn"><i class="feather-lock"></i>Login</router-link>
          </li>
          <li class="register-btn">
            <router-link to="signup" class="btn reg-btn"><i class="feather-user"></i>Sign Up</router-link>
          </li>
        </ul>
        <ul class="nav header-navbar-rht" v-else-if="isHomeSeven1RouteComputed">
          <li class="searchbar searchbar-fourteen me-2">
            <a href="javascript:void(0);" @click="toggleElement"><i class="feather-search"></i></a>
            <div class="togglesearch" v-if="isVisible" @click="handleClick">
              <form @submit.prevent="submitForm">
                <div class="input-group">
                  <input type="text" class="form-control" />
                  <b-button type="submit" class="btn btn-primary">Search</b-button>
                </div>
              </form>
            </div>
          </li>
          <li class="login-link">
            <router-link to="login-email">Login / Signup</router-link>
          </li>
          <li class="login-in-fourteen">
            <router-link to="signup" class="btn reg-btn"><i class="feather-user me-2"></i>Log In</router-link>
          </li>
          <li class="login-in-fourteen">
            <router-link to="login-email" class="btn btn-primary reg-btn reg-btn-fourteen"><i
                class="feather-user me-2"></i>Sign Up</router-link>
          </li>
        </ul>
        <ul class="nav header-navbar-rht" v-else-if="isHomeEightRoute">
          <li class="login-link">
            <router-link to="login-email">Login / Signup</router-link>
          </li>
          <li class="login-in-fourteen">
            <router-link to="signup" class="btn reg-btn">Log In</router-link>
          </li>
          <li class="login-in-fourteen">
            <router-link to="login-email" class="reg-btn-thirteen"><span>Sign Up</span>
              <div class="user-icon-header"><i class="feather-user"></i></div>
            </router-link>
          </li>
        </ul>
        <ul class="nav header-navbar-rht" v-else-if="isHomeNine1Route">
          <li class="searchbar searchbar-fourteen me-2">
            <a href="javascript:void(0);" @click="toggleElement"><i class="feather-search"></i></a>
            <div class="togglesearch" v-if="isVisible" @click="handleClick">
              <form @submit.prevent="submitForm">
                <div class="input-group">
                  <input type="text" class="form-control" />
                  <b-button type="submit" class="btn btn-primary">Search</b-button>
                </div>
              </form>
            </div>
          </li>
          <li class="login-link">
            <router-link to="login-email">Login / Signup</router-link>
          </li>
          <li class="login-in-fourteen">
            <router-link to="signup" class="btn reg-btn"><i class="feather-user me-2"></i>Log In</router-link>
          </li>
          <li class="login-in-fourteen">
            <router-link to="login-email" class="btn btn-primary reg-btn reg-btn-fourteen"><i
                class="feather-user me-2"></i>Sign Up</router-link>
          </li>
        </ul>
        <ul class="nav header-navbar-rht" v-else-if="isHomeTen1Route">
          <li class="login-link">
            <router-link to="login-email">Login / Signup</router-link>
          </li>
          <li class="login-in-fourteen">
            <router-link to="signup" class="btn reg-btn"><i class="feather-video me-2"></i>Live Demo</router-link>
          </li>
          <li class="login-in-fourteen">
            <router-link to="login-email" class="btn btn-primary reg-btn reg-btn-fourteen"><i
                class="feather-shopping-cart me-2"></i>Buy Template</router-link>
          </li>
        </ul>
        <ul class="nav header-navbar-rht" v-else-if="isHomeElevenRoute">
          <li class="login-link">
            <router-link to="login-email">Login / Signup</router-link>
          </li>
          <li class="login-in-sixteen">
            <router-link to="signup" class="btn reg-btn"><i class="feather-lock me-2"></i>Login
            </router-link>
          </li>
          <li class="login-in-sixteen">
            <router-link to="login-email" class="btn btn-primary reg-btn reg-btn-sixteen"><i
                class="feather-user me-2"></i>Sign Up</router-link>
          </li>
        </ul>
        <ul class="nav header-navbar-rht" v-else-if="isHomeTwelveRoute">
          <li class="login-in-fourteen">
            <router-link to="login-email" class="btn reg-btn log-btn-twelve">Log In</router-link>
          </li>
          <li class="login-in-fourteen">
            <router-link to="signup" class="reg-btn-thirteen regist-btn"><span>Register</span>
            </router-link>
          </li>
        </ul>
      </nav>
      <div class="sidebar-overlay" :class="{ opened: isSidebarOpen }" @click="closeSidebar"></div>
    </div>
  </header>
  <!-- /Header -->
</template>
<script>
export default {
  data() {
    return {
      isScrolled: false,
      isSidebarOpen: false,
      isVisible: false,
    };
  },
  mounted() {
    // Add a scroll event listener when the component is mounted
    window.addEventListener("scroll", this.handleScroll);
  },
  beforeUnmount() {
    // Remove the scroll event listener when the component is about to be unmounted
    window.removeEventListener("scroll", this.handleScroll);
  },
  methods: {
    submitForm() {
      this.$router.push("/doctor-search-list");
    },
    handleScroll() {
      // Get the scroll position
      const scroll = window.scrollY;

      // Update the isScrolled data property based on the scroll position
      this.isScrolled = scroll > 35;
    },
    toggleSidebar() {
      this.isSidebarOpen = !this.isSidebarOpen;
      document.documentElement.classList.toggle("menu-opened");
    },
    closeSidebar() {
      this.isSidebarOpen = false;
      document.documentElement.classList.remove("menu-opened");
    },
    toggleElement() {
      this.isVisible = !this.isVisible;
    },
  },
  computed: {
    isHomePharmacyRoute() {
      return this.$route.path === "/pharmacy-index";
    },
    isHomeOneRoute() {
      return (
        this.$route.path === "/" ||
        this.$route.path === "/about-us" ||
        this.$route.path === "/accounts" ||
        this.$route.path === "/add-billing" ||
        this.$route.path === "/add-prescription" ||
        this.$route.path === "/appointments" ||
        this.$route.path === "/available-timings" ||
        this.$route.path === "/blank-page" ||
        this.$route.path === "/blog-details" ||
        this.$route.path === "/blog-grid" ||
        this.$route.path === "/blog-list" ||
        this.$route.path === "/booking-2" ||
        this.$route.path === "/booking-success" ||
        this.$route.path === "/booking" ||
        this.$route.path === "/cart" ||
        this.$route.path === "/change-password" ||
        this.$route.path === "/chat-doctor" ||
        this.$route.path === "/chat" ||
        this.$route.path === "/checkout" ||
        this.$route.path === "/coming-soon" ||
        this.$route.path === "/components" ||
        this.$route.path === "/contact-us" ||
        this.$route.path === "/dependent" ||
        this.$route.path === "/doctor-add-blog" ||
        this.$route.path === "/doctor-blog" ||
        this.$route.path === "/doctor-change-password" ||
        this.$route.path === "/doctor-dashboard" ||
        this.$route.path === "/doctor-pending-blog" ||
        this.$route.path === "/doctor-profile-settings" ||
        this.$route.path === "/doctor-profile" ||
        this.$route.path === "/doctor-register" ||
        this.$route.path === "/doctor-search-grid" ||
        this.$route.path === "/doctor-signup" ||
        this.$route.path === "/edit-billing" ||
        this.$route.path === "/edit-blog" ||
        this.$route.path === "/edit-prescription" ||
        this.$route.path === "/error-404" ||
        this.$route.path === "/error-500" ||
        this.$route.path === "/faq" ||
        this.$route.path === "/favourites" ||
        this.$route.path === "/forgot-password" ||
        this.$route.path === "/forgot-password2" ||
        this.$route.path === "/invoice-view" ||
        this.$route.path === "/invoices" ||
        this.$route.path === "/login-email-otp" ||
        this.$route.path === "/login-email" ||
        this.$route.path === "/login-phone-otp" ||
        this.$route.path === "/login" ||
        this.$route.path === "/maintenance" ||
        this.$route.path === "/map-grid" ||
        this.$route.path === "/map-list" ||
        this.$route.path === "/medical-details" ||
        this.$route.path === "/medical-records" ||
        this.$route.path === "/mobile-otp" ||
        this.$route.path === "/my-patients" ||
        this.$route.path === "/orders-list" ||
        this.$route.path === "/patient-accounts" ||
        this.$route.path === "/patient-dashboard" ||
        this.$route.path === "/patient-profile" ||
        this.$route.path === "/patient-signup" ||
        this.$route.path === "/payment-success" ||
        this.$route.path === "/pharmacy-details" ||
        this.$route.path === "/pharmacy-register" ||
        this.$route.path === "/pricing" ||
        this.$route.path === "/privacy-policy" ||
        this.$route.path === "/product-all" ||
        this.$route.path === "/product-checkout" ||
        this.$route.path === "/product-description" ||
        this.$route.path === "/profile-settings" ||
        this.$route.path === "/register" ||
        this.$route.path === "/reviews" ||
        this.$route.path === "/schedule-timings" ||
        this.$route.path === "/search-2" ||
        this.$route.path === "/search" ||
        this.$route.path === "/signup-success" ||
        this.$route.path === "/social-media" ||
        this.$route.path === "/terms-condition" ||
        this.$route.path === "/video-call" ||
        this.$route.path === "/voice-call" ||
        this.$route.path === "/pharmacy-search" ||
        this.$route.path === "/email-otp" ||
        this.$route.path === "/login-phone"
      );
    },
    isHomeprescriptionRoute() {
      return (
        this.$route.path === "/add-prescription" ||
        this.$route.path === "/edit-blog" ||
        this.$route.path === "/edit-prescription"
      );
    },
    isHomeBillRoute() {
      return this.$route.path === "/add-billing" || this.$route.path === "/edit-billing";
    },
    isHomeAccRoute() {
      return (
        this.$route.path === "/accounts" ||
        this.$route.path === "/appointments" ||
        this.$route.path === "/available-timings" ||
        this.$route.path === "/chat-doctor" ||
        this.$route.path === "/doctor-add-blog" ||
        this.$route.path === "/doctor-blog" ||
        this.$route.path === "/doctor-change-password" ||
        this.$route.path === "/doctor-dashboard" ||
        this.$route.path === "/doctor-pending-blog" ||
        this.$route.path === "/doctor-profile-settings" ||
        this.$route.path === "/invoice-view" ||
        this.$route.path === "/invoices" ||
        this.$route.path === "/my-patients" ||
        this.$route.path === "/patient-profile" ||
        this.$route.path === "/reviews" ||
        this.$route.path === "/schedule-timings" ||
        this.$route.path === "/social-media" ||
        this.$route.path === "/video-call"
      );
    },
    isHomepatientRoute() {
      return (
        this.$route.path === "/booking-2" ||
        this.$route.path === "/booking-success" ||
        this.$route.path === "/booking" ||
        this.$route.path === "/cart" ||
        this.$route.path === "/change-password" ||
        this.$route.path === "/chat" ||
        this.$route.path === "/checkout" ||
        this.$route.path === "/dependent" ||
        this.$route.path === "/doctor-profile" ||
        this.$route.path === "/favourites" ||
        this.$route.path === "/medical-details" ||
        this.$route.path === "/medical-records" ||
        this.$route.path === "/orders-list" ||
        this.$route.path === "/patient-accounts" ||
        this.$route.path === "/patient-dashboard" ||
        this.$route.path === "/payment-success" ||
        this.$route.path === "/pharmacy-details" ||
        this.$route.path === "/product-all" ||
        this.$route.path === "/product-checkout" ||
        this.$route.path === "/product-description" ||
        this.$route.path === "/profile-settings" ||
        this.$route.path === "/voice-call" ||
        this.$route.path === "/pharmacy-search"
      );
    },
    isHomeFiveRoute() {
      return this.$route.path === "/index-5" || this.$route.path === "/index-13";
    },
    isHomeTwelveRoute() {
      return this.$route.path === "/index-12";
    },
    isHomeFive1Route() {
      return this.$route.path === "/index-5" || this.$route.path === "/index-13";
    },
    isHomeSevenRoute() {
      return this.$route.path === "/index-7" || this.$route.path === "/index-8";
    },
    isHomeSeven1RouteComputed() {
      return this.$route.path === "/index-7";
    },
    isHomeSeven2Route() {
      return (
        this.$route.path === "/index-7" ||
        this.$route.path === "/index-8" ||
        this.$route.path === "/index-9" ||
        this.$route.path === "/index-10"
      );
    },
    isHomeEightRoute() {
      return this.$route.path === "/index-8";
    },
    isHomeNineRoute() {
      return this.$route.path === "/index-9";
    },
    isHomeNine1Route() {
      return this.$route.path === "/index-9";
    },
    isHomeTenRoute() {
      return this.$route.path === "/index-10" || this.$route.path === "/index-11";
    },
    isHomeTen1Route() {
      return this.$route.path === "/index-10";
    },
    isHomeElevenRoute() {
      return this.$route.path === "/index-11";
    },
  },
};
</script>
