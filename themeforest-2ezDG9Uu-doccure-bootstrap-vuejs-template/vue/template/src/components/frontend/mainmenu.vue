<template>
  <ul class="main-nav" v-bind:class="$route.meta.headerMainNavClass">
    <li class="has-submenu megamenu" :class="homeMenu ? 'active' : 'notactive'">
      <a @click="toggleVisibilityhome">Home <i class="fas fa-chevron-down"></i></a>
      <ul
        class="submenu mega-submenu"
        :style="{ display: isVisiblehome ? 'block' : 'none' }"
      >
        <li>
          <div class="megamenu-wrapper">
            <div class="row">
              <div class="col-lg-2">
                <div
                  class="single-demo"
                  :class="currentPath == 'index' ? 'active' : 'notactive'"
                >
                  <div class="demo-img">
                    <router-link to="/" class="inner-demo-img"
                      ><img src="@/assets/img/home-11.jpg" class="img-fluid" alt="img"
                    /></router-link>
                  </div>
                  <div class="demo-info">
                    <router-link to="/" class="inner-demo-img">General Home</router-link>
                  </div>
                </div>
              </div>
              <div class="col-lg-2">
                <div
                  class="single-demo"
                  :class="currentPath == 'index-2' ? 'active' : 'notactive'"
                >
                  <div class="demo-img">
                    <router-link to="index-2" class="inner-demo-img"
                      ><img src="@/assets/img/home-10.jpg" class="img-fluid" alt="img"
                    /></router-link>
                  </div>
                  <div class="demo-info">
                    <router-link to="/index-2" class="inner-demo-img"
                      >General Home 2</router-link
                    >
                  </div>
                </div>
              </div>
              <div class="col-lg-2">
                <div
                  class="single-demo"
                  :class="currentPath == 'index-3' ? 'active' : 'notactive'"
                >
                  <div class="demo-img">
                    <router-link to="/index-3" class="inner-demo-img"
                      ><img src="@/assets/img/home-09.jpg" class="img-fluid" alt="img"
                    /></router-link>
                  </div>
                  <div class="demo-info">
                    <router-link to="/index-3" class="inner-demo-img"
                      >General Home 3</router-link
                    >
                  </div>
                </div>
              </div>
              <div class="col-lg-2">
                <div
                  class="single-demo"
                  :class="currentPath == 'index-4' ? 'active' : 'notactive'"
                >
                  <div class="demo-img">
                    <router-link to="/index-4" class="inner-demo-img"
                      ><img src="@/assets/img/home-08.jpg" class="img-fluid" alt="img"
                    /></router-link>
                  </div>
                  <div class="demo-info">
                    <router-link to="/index-4" class="inner-demo-img"
                      >General Home 4</router-link
                    >
                  </div>
                </div>
              </div>
              <div class="col-lg-2">
                <div
                  class="single-demo"
                  :class="currentPath == 'index-5' ? 'active' : 'notactive'"
                >
                  <div class="demo-img">
                    <router-link to="index-5" class="inner-demo-img"
                      ><img src="@/assets/img/home-07.jpg" class="img-fluid" alt="img"
                    /></router-link>
                  </div>
                  <div class="demo-info">
                    <router-link to="/index-5" class="inner-demo-img"
                      >Cardiology Home</router-link
                    >
                  </div>
                </div>
              </div>
              <div class="col-lg-2">
                <div
                  class="single-demo"
                  :class="currentPath == 'index-6' ? 'active' : 'notactive'"
                >
                  <div class="demo-img">
                    <router-link to="/index-6" class="inner-demo-img"
                      ><img src="@/assets/img/home-06.jpg" class="img-fluid" alt="img"
                    /></router-link>
                  </div>
                  <div class="demo-info">
                    <router-link to="/index-6" class="inner-demo-img"
                      >Eye Care Home</router-link
                    >
                  </div>
                </div>
              </div>
              <div class="col-lg-2">
                <div
                  class="single-demo"
                  :class="currentPath == 'index-7' ? 'active' : 'notactive'"
                >
                  <div class="demo-img">
                    <router-link to="/index-7" class="inner-demo-img"
                      ><img src="@/assets/img/home-05.jpg" class="img-fluid" alt="img"
                    /></router-link>
                  </div>
                  <div class="demo-info">
                    <router-link to="/index-7" class="inner-demo-img"
                      >Veterinary Home</router-link
                    >
                  </div>
                </div>
              </div>
              <div class="col-lg-2">
                <div
                  class="single-demo"
                  :class="currentPath == 'index-8' ? 'active' : 'notactive'"
                >
                  <div class="demo-img">
                    <router-link to="index-8" class="inner-demo-img"
                      ><img src="@/assets/img/home-04.jpg" class="img-fluid" alt="img"
                    /></router-link>
                  </div>
                  <div class="demo-info">
                    <router-link to="index-8" class="inner-demo-img"
                      >Paediatric Home</router-link
                    >
                  </div>
                </div>
              </div>
              <div class="col-lg-2">
                <div
                  class="single-demo"
                  :class="currentPath == 'index-9' ? 'active' : 'notactive'"
                >
                  <div class="demo-img">
                    <router-link to="index-9" class="inner-demo-img"
                      ><img src="@/assets/img/home-03.jpg" class="img-fluid" alt="img"
                    /></router-link>
                  </div>
                  <div class="demo-info">
                    <router-link to="/index-9" class="inner-demo-img"
                      >Fertility Home</router-link
                    >
                  </div>
                </div>
              </div>
              <div class="col-lg-2">
                <div
                  class="single-demo"
                  :class="currentPath == 'index-10' ? 'active' : 'notactive'"
                >
                  <div class="demo-img">
                    <router-link to="index-10" class="inner-demo-img"
                      ><img src="@/assets/img/home-02.jpg" class="img-fluid" alt="img"
                    /></router-link>
                  </div>
                  <div class="demo-info">
                    <router-link to="/index-10" class="inner-demo-img"
                      >ENT Hospital Home</router-link
                    >
                  </div>
                </div>
              </div>
              <div class="col-lg-2">
                <div
                  class="single-demo"
                  :class="currentPath == 'index-11' ? 'active' : 'notactive'"
                >
                  <div class="demo-img">
                    <router-link to="/index-11" class="inner-demo-img"
                      ><img src="@/assets/img/home-01.jpg" class="img-fluid" alt="img"
                    /></router-link>
                  </div>
                  <div class="demo-info">
                    <router-link to="/index-11" class="inner-demo-img"
                      >Cosmetics Home</router-link
                    >
                  </div>
                </div>
              </div>
              <div class="col-lg-2">
                <div
                  class="single-demo"
                  :class="currentPath == 'index-12' ? 'active' : 'notactive'"
                >
                  <div class="demo-img">
                    <router-link to="/index-12" class="inner-demo-img"
                      ><img src="@/assets/img/home-12.jpg" class="img-fluid" alt="img"
                    /></router-link>
                  </div>
                  <div class="demo-info">
                    <router-link to="/index-12" class="inner-demo-img"
                      >Lab Test Home</router-link
                    >
                  </div>
                </div>
              </div>
              <div class="col-lg-2">
                <div
                  class="single-demo"
                  :class="currentPath == 'index-13' ? 'active' : 'notactive'"
                >
                  <div class="demo-img">
                    <router-link to="/index-13" class="inner-demo-img"
                      ><img src="@/assets/img/home-13.jpg" class="img-fluid" alt="img"
                    /></router-link>
                  </div>
                  <div class="demo-info">
                    <router-link to="/index-13" class="inner-demo-img"
                      >Homecare Home</router-link
                    >
                  </div>
                </div>
              </div>
            </div>
          </div>
        </li>
      </ul>
    </li>
    <li class="has-submenu" :class="doctorMenu ? 'active' : 'notactive'">
      <a href="javascript:void(0);" @click="toggleVisibilitydoctor"
        >Doctors <i class="fas fa-chevron-down"></i
      ></a>
      <ul class="submenu" :style="{ display: isVisibledoctor ? 'block' : 'none' }">
        <li :class="currentPath == 'doctor-dashboard' ? 'active' : 'notactive'">
          <router-link to="/doctor-dashboard">Doctor Dashboard</router-link>
        </li>
        <li :class="currentPath == 'appointments' ? 'active' : 'notactive'">
          <router-link to="/appointments">Appointments</router-link>
        </li>
        <li :class="currentPath == 'schedule-timings' ? 'active' : 'notactive'">
          <router-link to="/schedule-timings">Schedule Timing</router-link>
        </li>
        <li :class="currentPath == 'my-patients' ? 'active' : 'notactive'">
          <router-link to="/my-patients">Patients List</router-link>
        </li>
        <li
          :class="
            currentPath == 'patient-profile' ||
            currentPath == 'edit-prescription' ||
            currentPath == 'add-billing'
              ? 'active'
              : 'notactive'
          "
        >
          <router-link to="/patient-profile">Patients Profile</router-link>
        </li>
        <li :class="currentPath == 'chat-doctor' ? 'active' : 'notactive'">
          <router-link to="/chat-doctor">Chat</router-link>
        </li>
        <li>
          <router-link to="/invoices">Invoices</router-link>
        </li>
        <li :class="currentPath == 'doctor-profile-settings' ? 'active' : 'notactive'">
          <router-link to="/doctor-profile-settings">Profile Settings</router-link>
        </li>
        <li :class="currentPath == 'reviews' ? 'active' : 'notactive'">
          <router-link to="/reviews">Reviews</router-link>
        </li>
        <li :class="currentPath == 'doctor-register' ? 'active' : 'notactive'">
          <router-link to="/doctor-register">Doctor Register</router-link>
        </li>
        <li
          class="has-submenu"
          :class="
            currentPath == 'doctor-blog' || currentPath == 'doctor-add-blog'
              ? 'active'
              : 'notactive'
          "
        >
          <a href="javascript:void(0);" @click="toggleVisibilitydoctorsblog">Blog</a>
          <ul
            class="submenu"
            :style="{ display: isVisibledoctorsblog ? 'block' : 'none' }"
          >
            <li
              :class="
                currentPath == 'doctor-blog' ||
                currentPath == 'edit-blog' ||
                currentPath == 'doctor-pending-blog'
                  ? 'active'
                  : 'notactive'
              "
            >
              <router-link to="/doctor-blog">Blog</router-link>
            </li>
            <li>
              <router-link to="/blog-details">Blog view</router-link>
            </li>
            <li :class="currentPath == 'doctor-add-blog' ? 'active' : 'notactive'">
              <router-link to="/doctor-add-blog">Add Blog</router-link>
            </li>
          </ul>
        </li>
      </ul>
    </li>
    <li class="has-submenu" :class="patientsMenu ? 'active' : 'notactive'">
      <a href="javascript:void(0);" @click="toggleVisibilitypatients"
        >Patients <i class="fas fa-chevron-down"></i
      ></a>
      <ul class="submenu" :style="{ display: isVisiblepatients ? 'block' : 'none' }">
        <li
          class="has-submenu"
          :class="
            currentPath == 'map-grid' || currentPath == 'map-list'
              ? 'active'
              : 'notactive'
          "
        >
          <a href="javascript:void(0);" @click="toggleVisibilitypatientsdoctors"
            >Doctors</a
          >
          <ul
            class="submenu inner-submenu"
            :style="{ display: isVisiblepatientsdoctor ? 'block' : 'none' }"
          >
            <li :class="currentPath == 'map-grid' ? 'active' : 'notactive'">
              <router-link @click="redirectReloadmapgrid" to="/map-grid"
                >Map Grid</router-link
              >
            </li>
            <li :class="currentPath == 'map-list' ? 'active' : 'notactive'">
              <router-link @click="redirectReloadmaplist" to="/map-list"
                >Map List</router-link
              >
            </li>
          </ul>
        </li>
        <li
          class="has-submenu"
          :class="
            currentPath == 'search' || currentPath == 'search-2' ? 'active' : 'notactive'
          "
        >
          <a href="javascript:void(0);" @click="toggleVisibilitysearch">Search Doctor</a>
          <ul
            class="submenu inner-submenu"
            :style="{ display: isVisiblepatientssearch ? 'block' : 'none' }"
          >
            <li :class="currentPath == 'search' ? 'active' : 'notactive'">
              <router-link to="/search">Search Doctor 1</router-link>
            </li>
            <li :class="currentPath == 'search-2' ? 'active' : 'notactive'">
              <router-link @click="redirectReloadsearch" to="/search-2"
                >Search Doctor 2</router-link
              >
            </li>
          </ul>
        </li>
        <li :class="currentPath == 'doctor-profile' ? 'active' : 'notactive'">
          <router-link to="/doctor-profile">Doctor Profile</router-link>
        </li>
        <li
          class="has-submenu"
          :class="
            currentPath == 'booking' || currentPath == 'booking-2'
              ? 'active'
              : 'notactive'
          "
        >
          <a href="javascript:void(0);" @click="toggleVisibilitybooking">Booking</a>
          <ul
            class="submenu inner-submenu"
            :style="{ display: isVisiblepatientsbooking ? 'block' : 'none' }"
          >
            <li :class="currentPath == 'booking' ? 'active' : 'notactive'">
              <router-link to="/booking">Booking 1</router-link>
            </li>
            <li :class="currentPath == 'booking-2' ? 'active' : 'notactive'">
              <router-link to="/booking-2">Booking 2</router-link>
            </li>
          </ul>
        </li>
        <li :class="currentPath == 'checkout' ? 'active' : 'notactive'">
          <router-link to="/checkout">Checkout</router-link>
        </li>
        <li :class="currentPath == 'booking-success' ? 'active' : 'notactive'">
          <router-link to="/booking-success">Booking Success</router-link>
        </li>
        <li :class="currentPath == 'patient-dashboard' ? 'active' : 'notactive'">
          <router-link to="/patient-dashboard">Patient Dashboard</router-link>
        </li>
        <li :class="currentPath == 'favourites' ? 'active' : 'notactive'">
          <router-link to="/favourites">Favourites</router-link>
        </li>
        <li :class="currentPath == 'chat' ? 'active' : 'notactive'">
          <router-link to="/chat">Chat</router-link>
        </li>
        <li :class="currentPath == 'profile-settings' ? 'active' : 'notactive'">
          <router-link to="/profile-settings">Profile Settings</router-link>
        </li>
        <li :class="currentPath == 'change-password' ? 'active' : 'notactive'">
          <router-link to="/change-password">Change Password</router-link>
        </li>
      </ul>
    </li>
    <li class="has-submenu" :class="pharmacyMenu ? 'active' : 'notactive'">
      <a href="javascript:;" @click="toggleVisibilitypharmacy"
        >Pharmacy <i class="fas fa-chevron-down"></i
      ></a>
      <ul class="submenu" :style="{ display: isVisiblepharmacy ? 'block' : 'none' }">
        <li :class="currentPath == 'pharmacy-index' ? 'active' : 'notactive'">
          <router-link to="/pharmacy-index">Pharmacy</router-link>
        </li>
        <li :class="currentPath == 'pharmacy-details' ? 'active' : 'notactive'">
          <router-link to="/pharmacy-details">Pharmacy Details</router-link>
        </li>
        <li :class="currentPath == 'pharmacy-search' ? 'active' : 'notactive'">
          <router-link to="/pharmacy-search">Pharmacy Search</router-link>
        </li>
        <li :class="currentPath == 'product-all' ? 'active' : 'notactive'">
          <router-link to="/product-all">Product</router-link>
        </li>
        <li :class="currentPath == 'product-description' ? 'active' : 'notactive'">
          <router-link to="/product-description">Product Description</router-link>
        </li>
        <li :class="currentPath == 'cart' ? 'active' : 'notactive'">
          <router-link to="/cart">Cart</router-link>
        </li>
        <li :class="currentPath == 'product-checkout' ? 'active' : 'notactive'">
          <router-link to="/product-checkout">Product Checkout</router-link>
        </li>
        <li :class="currentPath == 'payment-success' ? 'active' : 'notactive'">
          <router-link to="/payment-success">Payment Success</router-link>
        </li>
        <li :class="currentPath == 'pharmacy-register' ? 'active' : 'notactive'">
          <router-link to="/pharmacy-register">Pharmacy Register</router-link>
        </li>
      </ul>
    </li>
    <li class="has-submenu" :class="pagesMenu ? 'active' : 'notactive'">
      <a href="javascript:void(0);" @click="toggleVisibilitypages"
        >Pages <i class="fas fa-chevron-down"></i
      ></a>
      <ul class="submenu" :style="{ display: isVisiblepages ? 'block' : 'none' }">
        <li :class="currentPath == 'about-us' ? 'active' : 'notactive'">
          <router-link to="about-us">About Us</router-link>
        </li>
        <li :class="currentPath == 'contact-us' ? 'active' : 'notactive'">
          <router-link to="contact-us">Contact Us</router-link>
        </li>
        <li class="has-submenu">
          <a href="javascript:void(0);" @click="toggleVisibilitycall">Call</a>
          <ul
            class="submenu inner-submenu"
            :style="{ display: isVisiblecall ? 'block' : 'none' }"
          >
            <li :class="currentPath == 'voice-call' ? 'active' : 'notactive'">
              <router-link to="/voice-call">Voice Call</router-link>
            </li>
            <li :class="currentPath == 'video-call' ? 'active' : 'notactive'">
              <router-link to="/video-call">Video Call</router-link>
            </li>
          </ul>
        </li>
        <li class="has-submenu">
          <a href="javascript:void(0);" @click="toggleVisibilityinvoice">Invoices</a>
          <ul
            class="submenu inner-submenu"
            :style="{ display: isVisibleinvoice ? 'block' : 'none' }"
          >
            <li :class="currentPath == 'invoices' ? 'active' : 'notactive'">
              <router-link to="/invoices">Invoices</router-link>
            </li>
            <li :class="currentPath == 'invoice-view' ? 'active' : 'notactive'">
              <router-link to="/invoice-view">Invoice View</router-link>
            </li>
          </ul>
        </li>
        <li class="has-submenu">
          <a href="javascript:void(0);" @click="toggleVisibilityauthentication"
            >Authentication</a
          >
          <ul
            class="submenu inner-submenu"
            :style="{ display: isVisibleauthentication ? 'block' : 'none' }"
          >
            <li :class="currentPath == 'login-email' ? 'active' : 'notactive'">
              <router-link to="/login-email">Login Email</router-link>
            </li>
            <li :class="currentPath == 'login-phone' ? 'active' : 'notactive'">
              <router-link to="/login-phone">Login Phone</router-link>
            </li>
            <li :class="currentPath == 'doctor-signup' ? 'active' : 'notactive'">
              <router-link to="/doctor-signup">Doctor Signup</router-link>
            </li>
            <li :class="currentPath == 'patient-signup' ? 'active' : 'notactive'">
              <router-link to="/patient-signup">Patient Signup</router-link>
            </li>
            <li :class="currentPath == 'forgot-password' ? 'active' : 'notactive'">
              <router-link to="/forgot-password">Forgot Password 1</router-link>
            </li>
            <li :class="currentPath == 'forgot-password2' ? 'active' : 'notactive'">
              <router-link to="/forgot-password2">Forgot Password 2</router-link>
            </li>
            <li :class="currentPath == 'login-email-otp' ? 'active' : 'notactive'">
              <router-link to="/login-email-otp">Email OTP</router-link>
            </li>
            <li :class="currentPath == 'login-phone-otp' ? 'active' : 'notactive'">
              <router-link to="/login-phone-otp">Phone OTP</router-link>
            </li>
          </ul>
        </li>
        <li class="has-submenu">
          <a href="javascript:void(0);" @click="toggleVisibilityerror">Error Pages</a>
          <ul
            class="submenu inner-submenu"
            :style="{ display: isVisibleerror ? 'block' : 'none' }"
          >
            <li :class="currentPath == 'error-404' ? 'active' : 'notactive'">
              <router-link to="/error-404">404 Error</router-link>
            </li>
            <li :class="currentPath == 'error-500' ? 'active' : 'notactive'">
              <router-link to="/error-500">500 Error</router-link>
            </li>
          </ul>
        </li>
        <li :class="currentPath == 'blank-page' ? 'active' : 'notactive'">
          <router-link to="/blank-page">Starter Page</router-link>
        </li>
        <li :class="currentPath == 'pricing' ? 'active' : 'notactive'">
          <router-link to="/pricing">Pricing Plan</router-link>
        </li>
        <li :class="currentPath == 'faq' ? 'active' : 'notactive'">
          <router-link to="/faq">FAQ</router-link>
        </li>
        <li :class="currentPath == 'maintenance' ? 'active' : 'notactive'">
          <router-link to="/maintenance">Maintenance</router-link>
        </li>
        <li :class="currentPath == 'coming-soon' ? 'active' : 'notactive'">
          <router-link to="/coming-soon">Coming Soon</router-link>
        </li>
        <li :class="currentPath == 'terms-condition' ? 'active' : 'notactive'">
          <router-link to="/terms-condition">Terms & Condition</router-link>
        </li>
        <li :class="currentPath == 'privacy-policy' ? 'active' : 'notactive'">
          <router-link to="/privacy-policy">Privacy Policy</router-link>
        </li>
        <li :class="currentPath == 'components' ? 'active' : 'notactive'">
          <router-link to="/components">Components</router-link>
        </li>
      </ul>
    </li>
    <li class="has-submenu" :class="blogMenu ? 'active' : 'notactive'">
      <a href="javascript:;" @click="toggleVisibilityblog"
        >Blog <i class="fas fa-chevron-down"></i
      ></a>
      <ul class="submenu" :style="{ display: isVisibleblog ? 'block' : 'none' }">
        <li :class="currentPath == 'blog-list' ? 'active' : 'notactive'">
          <router-link to="/blog-list">Blog List</router-link>
        </li>
        <li :class="currentPath == 'blog-grid' ? 'active' : 'notactive'">
          <router-link to="/blog-grid">Blog Grid</router-link>
        </li>
        <li :class="currentPath == 'blog-details' ? 'active' : 'notactive'">
          <router-link to="/blog-details">Blog Details</router-link>
        </li>
      </ul>
    </li>
    <li class="has-submenu" :class="adminMenu ? 'active' : 'notactive'">
      <a href="javascript:;" @click="toggleVisibilityadmin"
        >Admin <i class="fas fa-chevron-down"></i
      ></a>
      <ul class="submenu" :style="{ display: isVisibleadmin ? 'block' : 'none' }">
        <li :class="currentPath == 'admin/index' ? 'active' : 'notactive'">
          <router-link to="/admin/index" target="_blank">Admin</router-link>
        </li>
        <li :class="currentPath == 'pharmacy/index' ? 'active' : 'notactive'">
          <router-link to="/pharmacy/index" target="_blank">Pharmacy Admin</router-link>
        </li>
      </ul>
    </li>
    <li class="login-link">
      <router-link to="/login">Login / Signup</router-link>
    </li>
  </ul>
</template>

<script>
export default {
  data() {
    return {
      isVisiblehome: false,
      isVisibledoctor: false,
      isVisibledoctorsblog: false,
      isVisiblepatients: false,
      isVisiblepatientsdoctor: false,
      isVisiblepatientssearch: false,
      isVisiblepatientsbooking: false,
      isVisiblepharmacy: false,
      isVisiblepages: false,
      isVisiblecall: false,
      isVisibleinvoice: false,
      isVisibleauthentication: false,
      isVisibleerror: false,
      isVisibleblog: false,
      isVisibleadmin: false,
    };
  },
  methods: {
    toggleVisibilityhome() {
      this.isVisiblehome = !this.isVisiblehome;
    },
    toggleVisibilitydoctor() {
      this.isVisibledoctor = !this.isVisibledoctor;
    },
    toggleVisibilitydoctorsblog() {
      this.isVisibledoctorsblog = !this.isVisibledoctorsblog;
    },
    toggleVisibilitypatients() {
      this.isVisiblepatients = !this.isVisiblepatients;
    },
    toggleVisibilitypatientsdoctors() {
      this.isVisiblepatientsdoctor = !this.isVisiblepatientsdoctor;
    },
    toggleVisibilitysearch() {
      this.isVisiblepatientssearch = !this.isVisiblepatientssearch;
    },
    toggleVisibilitybooking() {
      this.isVisiblepatientsbooking = !this.isVisiblepatientsbooking;
    },
    toggleVisibilitypharmacy() {
      this.isVisiblepharmacy = !this.isVisiblepharmacy;
    },
    toggleVisibilitypages() {
      this.isVisiblepages = !this.isVisiblepages;
    },
    toggleVisibilitycall() {
      this.isVisiblecall = !this.isVisiblecall;
    },
    toggleVisibilityinvoice() {
      this.isVisibleinvoice = !this.isVisibleinvoice;
    },
    toggleVisibilityauthentication() {
      this.isVisibleauthentication = !this.isVisibleauthentication;
    },
    toggleVisibilityerror() {
      this.isVisibleerror = !this.isVisibleerror;
    },
    toggleVisibilityblog() {
      this.isVisibleblog = !this.isVisibleblog;
    },
    toggleVisibilityadmin() {
      this.isVisibleadmin = !this.isVisibleadmin;
    },
    redirectReloadmapgrid() {
      this.$router.push({ path: "/map-grid" }).then(() => {
        this.$router.go();
      });
    },
    redirectReloadmaplist() {
      this.$router.push({ path: "/map-list" }).then(() => {
        this.$router.go();
      });
    },
    redirectReloadsearch() {
      this.$router.push({ path: "/search-2" }).then(() => {
        this.$router.go();
      });
    },
  },
  computed: {
    currentPath() {
      return this.$route.name;
    },
    homeMenu() {
      return (
        this.$route.name == "index" ||
        this.$route.name == "index-2" ||
        this.$route.name == "index-3" ||
        this.$route.name == "index-4" ||
        this.$route.name == "index-5" ||
        this.$route.name == "index-6" ||
        this.$route.name == "index-7" ||
        this.$route.name == "index-8" ||
        this.$route.name == "index-9" ||
        this.$route.name == "index-10" ||
        this.$route.name == "index-11"
      );
    },
    doctorMenu() {
      return (
        this.$route.name == "doctor-dashboard" ||
        this.$route.name == "appointments" ||
        this.$route.name == "schedule-timings" ||
        this.$route.name == "my-patients" ||
        this.$route.name == "patient-profile" ||
        this.$route.name == "edit-prescription" ||
        this.$route.name == "add-billing" ||
        this.$route.name == "chat-doctor" ||
        this.$route.name == "doctor-profile-settings" ||
        this.$route.name == "reviews" ||
        this.$route.name == "doctor-register" ||
        this.$route.name == "doctor-blog" ||
        this.$route.name == "edit-blog" ||
        this.$route.name == "blog-details" ||
        this.$route.name == "doctor-add-blog" ||
        this.$route.name == "doctor-pending-blog"
      );
    },
    patientsMenu() {
      return (
        this.$route.name == "map-grid" ||
        this.$route.name == "map-list" ||
        this.$route.name == "search" ||
        this.$route.name == "search-2" ||
        this.$route.name == "doctor-profile" ||
        this.$route.name == "booking" ||
        this.$route.name == "booking-2" ||
        this.$route.name == "checkout" ||
        this.$route.name == "booking-success" ||
        this.$route.name == "patient-dashboard" ||
        this.$route.name == "favourites" ||
        this.$route.name == "chat" ||
        this.$route.name == "profile-settings" ||
        this.$route.name == "change-password"
      );
    },
    pharmacyMenu() {
      return (
        this.$route.name == "pharmacy-index" ||
        this.$route.name == "pharmacy-details" ||
        this.$route.name == "pharmacy-search" ||
        this.$route.name == "product-all" ||
        this.$route.name == "product-description" ||
        this.$route.name == "cart" ||
        this.$route.name == "product-checkout" ||
        this.$route.name == "payment-success" ||
        this.$route.name == "pharmacy-register"
      );
    },
    pagesMenu() {
      return (
        this.$route.name == "about-us" ||
        this.$route.name == "contact-us" ||
        this.$route.name == "blank-page" ||
        this.$route.name == "pricing" ||
        this.$route.name == "faq" ||
        this.$route.name == "maintenance" ||
        this.$route.name == "coming-soon" ||
        this.$route.name == "terms-condition" ||
        this.$route.name == "privacy-policy" ||
        this.$route.name == "components" ||
        this.$route.name == "voice-call" ||
        this.$route.name == "video-call" ||
        this.$route.name == "invoices" ||
        this.$route.name == "invoice-view" ||
        this.$route.name == "login-email" ||
        this.$route.name == "login-phone" ||
        this.$route.name == "doctor-signup" ||
        this.$route.name == "patient-signup" ||
        this.$route.name == "forgot-password" ||
        this.$route.name == "forgot-password2" ||
        this.$route.name == "login-email-otp" ||
        this.$route.name == "login-phone-otp" ||
        this.$route.name == "error-404" ||
        this.$route.name == "error-500"
      );
    },
    blogMenu() {
      return (
        this.$route.name == "blog-list" ||
        this.$route.name == "blog-grid" ||
        this.$route.name == "blog-details"
      );
    },
    adminMenu() {
      return this.$route.name == "admin/index" || this.$route.name == "pharmacy/index";
    },
    redirectReloadIndex11() {
      this.$router.push({ path: "index-11" }).then(() => {
        this.$router.go();
      });
    },
  },
};
</script>
