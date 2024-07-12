<template>
  <div class="login-body">
    <!-- Main Wrapper -->
    <div class="main-wrapper">
      <layoutheader></layoutheader>
      <!-- Page Content -->
      <div class="login-content-info">
        <div class="container">
          <!-- Signup Success -->
          <div class="row justify-content-center">
            <div class="col-lg-4 col-md-6">
              <div class="account-content">
                <div class="login-shapes">
                  <div class="shape-img-left">
                    <img src="@/assets/img/shape-01.png" alt="shape-image" />
                  </div>
                  <div class="shape-img-right">
                    <img src="@/assets/img/shape-02.png" alt="shape-image" />
                  </div>
                </div>
                <div class="account-info">
                  <div class="login-back">
                    <router-link to="login-email"
                      ><i class="fa-solid fa-arrow-left-long"></i> Back</router-link
                    >
                  </div>
                  <div class="login-success-icon">
                    <i class="fas fa-circle-check"></i>
                  </div>
                  <div class="login-title">
                    <h3>Success</h3>
                    <p class="mb-0">Your new password has been Successfully saved</p>
                  </div>
                  <form @submit.prevent="submitForm">
                    <div class="mb-0">
                      <b-button class="btn w-100" type="submit">Sign in</b-button>
                    </div>
                  </form>
                </div>
              </div>
            </div>
          </div>
          <!-- /Signup Success -->
        </div>
      </div>
      <!-- /Page Content -->
      <cursor></cursor>
    </div>
    <!-- /Main Wrapper -->
  </div>
</template>
<script>
export default {
  methods: {
    submitForm() {
      this.$router.push("/login-email");
    },
  },
};
</script>
