<template>
  <div class="profile-sidebar">
    <div class="widget-profile pro-widget-content">
      <div class="profile-info-widget">
        <a href="javascript:;" class="booking-doc-img">
          <img src="@/assets/img/patients/patient.jpg" alt="User Image" />
        </a>
        <div class="profile-det-info">
          <h3>Richard Wilson</h3>
          <div class="patient-details">
            <h5><i class="fas fa-birthday-cake"></i> 24 Jul 1983, 38 years</h5>
            <h5 class="mb-0"><i class="fas fa-map-marker-alt"></i> Newyork, USA</h5>
          </div>
        </div>
      </div>
    </div>
    <div class="dashboard-widget">
      <nav class="dashboard-menu">
        <ul>
          <li :class="currentPath == 'patient-dashboard' ? 'active' : 'notactive'">
            <router-link to="/patient-dashboard">
              <i class="fas fa-columns"></i>
              <span class="ms-1">Dashboard</span>
            </router-link>
          </li>
          <li :class="currentPath == 'favourites' ? 'active' : 'notactive'">
            <router-link to="/favourites">
              <i class="fas fa-bookmark"></i>
              <span class="ms-1">Favourites</span>
            </router-link>
          </li>
          <li :class="currentPath == 'dependent' ? 'active' : 'notactive'">
            <router-link to="/dependent">
              <i class="fas fa-users"></i>
              <span class="ms-1">Dependent</span>
            </router-link>
          </li>
          <li :class="currentPath == 'chat' ? 'active' : 'notactive'">
            <router-link to="/chat">
              <i class="fas fa-comments"></i>
              <span class="ms-1">Message</span>
              <small class="unread-msg">23</small>
            </router-link>
          </li>
          <li :class="currentPath == 'patient-accounts' ? 'active' : 'notactive'">
            <router-link to="/patient-accounts">
              <i class="fas fa-file-invoice-dollar"></i>
              <span class="ms-1"> Accounts</span>
            </router-link>
          </li>
          <li :class="currentPath == 'orders-list' ? 'active' : 'notactive'">
            <router-link to="/orders-list">
              <i class="fas fa-list-alt"></i>
              <span class="ms-1">Orders</span>
              <small class="unread-msg">7</small>
            </router-link>
          </li>
          <li :class="currentPath == 'medical-records' ? 'active' : 'notactive'">
            <router-link to="/medical-records">
              <i class="fas fa-clipboard"></i>
              <span class="ms-1">Add Medical Records</span>
            </router-link>
          </li>
          <li :class="currentPath == 'medical-details' ? 'active' : 'notactive'">
            <router-link to="/medical-details">
              <i class="fas fa-file-medical-alt"></i>
              <span class="ms-1">Medical Details</span>
            </router-link>
          </li>
          <li :class="currentPath == 'profile-settings' ? 'active' : 'notactive'">
            <router-link to="/profile-settings">
              <i class="fas fa-user-cog"></i>
              <span class="ms-1">Profile Settings</span>
            </router-link>
          </li>
          <li :class="currentPath == 'change-password' ? 'active' : 'notactive'">
            <router-link to="/change-password">
              <i class="fas fa-lock"></i>
              <span class="ms-1">Change Password</span>
            </router-link>
          </li>
          <li :class="currentPath == 'index' ? 'active' : 'notactive'">
            <router-link to="/">
              <i class="fas fa-sign-out-alt"></i>
              <span class="ms-1">Logout</span>
            </router-link>
          </li>
        </ul>
      </nav>
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
  computed: {
    currentPath() {
      return this.$route.name;
    },
  },
};
</script>
