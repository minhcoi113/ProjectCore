<template>
  <div class="col-md-5 col-lg-4 col-xl-3 theiaStickySidebar">
    <div class="stickysidebar">
      <!-- Profile Sidebar -->
      <div class="profile-sidebar">
        <div class="widget-profile pro-widget-content">
          <div class="profile-info-widget">
            <a href="#" class="booking-doc-img">
              <img src="@/assets/img/doctors/doctor-thumb-02.jpg" alt="User Image" />
            </a>
            <div class="profile-det-info">
              <h3>Dr. Darren Elder</h3>

              <div class="patient-details">
                <h5 class="mb-0">BDS, MDS - Oral & Maxillofacial Surgery</h5>
              </div>
            </div>
          </div>
        </div>
        <div class="dashboard-widget">
          <nav class="dashboard-menu">
            <ul>
              <li :class="{ active: isActive('/doctor-dashboard') }">
                <router-link to="/doctor-dashboard">
                  <i class="fas fa-columns"></i>
                  <span class="ms-1">Dashboard</span>
                </router-link>
              </li>
              <li :class="{ active: isActive('/appointments') }">
                <router-link to="/appointments">
                  <i class="fas fa-calendar-check"></i>
                  <span class="ms-1">Appointments</span>
                </router-link>
              </li>
              <li :class="{ active: isActive('/my-patients') }">
                <router-link to="/my-patients">
                  <i class="fas fa-user-injured"></i>
                  <span class="ms-1">My Patients</span>
                </router-link>
              </li>
              <li :class="{ active: isActive('/schedule-timings') }">
                <router-link to="/schedule-timings">
                  <i class="fas fa-hourglass-start"></i>
                  <span class="ms-1">Schedule Timings</span>
                </router-link>
              </li>
              <li :class="{ active: isActive('/available-timings') }">
                <router-link to="/available-timings">
                  <i class="fas fa-clock"></i>
                  <span class="ms-1">Available Timings</span>
                </router-link>
              </li>
              <li :class="{ active: isActive('/invoices') }">
                <router-link to="/invoices">
                  <i class="fas fa-file-invoice"></i>
                  <span class="ms-1">Invoices</span>
                </router-link>
              </li>
              <li :class="{ active: isActive('/accounts') }">
                <router-link to="/accounts">
                  <i class="fas fa-file-invoice-dollar"></i>
                  <span class="ms-1">Accounts</span>
                </router-link>
              </li>
              <li :class="{ active: isActive('/reviews') }">
                <router-link to="/reviews">
                  <i class="fas fa-star"></i>
                  <span class="ms-1">Reviews</span>
                </router-link>
              </li>
              <li :class="{ active: isActive('/chat-doctor') }">
                <router-link to="/chat-doctor">
                  <i class="fas fa-comments"></i>
                  <span class="ms-1">Message</span>
                  <small class="unread-msg">23</small>
                </router-link>
              </li>
              <li :class="{ active: isActive('/doctor-profile-settings') }">
                <router-link to="/doctor-profile-settings">
                  <i class="fas fa-user-cog"></i>
                  <span class="ms-1">Profile Settings</span>
                </router-link>
              </li>
              <li :class="{ active: isActive('/social-media') }">
                <router-link to="/social-media">
                  <i class="fas fa-share-alt"></i>
                  <span class="ms-1">Social Media</span>
                </router-link>
              </li>
              <li :class="{ active: isActive('/doctor-change-password') }">
                <router-link to="/doctor-change-password">
                  <i class="fas fa-lock"></i>
                  <span class="ms-1">Change Password</span>
                </router-link>
              </li>
              <li :class="{ active: isActive('/') }">
                <router-link to="/">
                  <i class="fas fa-sign-out-alt"></i>
                  <span class="ms-1">Logout</span>
                </router-link>
              </li>
            </ul>
          </nav>
        </div>
      </div>
      <!-- /Profile Sidebar -->
    </div>
  </div>
</template>
<script>
export default {
  data() {
    return {
      activeClass: "active",
    };
  },
  methods: {
    isActive(paths) {
      return paths.includes(this.$route.path);
    },
  },
};
</script>
