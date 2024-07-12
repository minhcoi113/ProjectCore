<template>
  <div class="account-page">
    <div class="main-wrapper">
      <layoutheader></layoutheader>

      <!-- Page Content -->
      <div class="content top-space">
        <div class="container-fluid">
          <div class="row">
            <div class="col-md-8 offset-md-2">
              <!-- Account Content -->
              <div class="account-content">
                <div class="row align-items-center justify-content-center">
                  <div class="col-md-7 col-lg-6 login-left">
                    <img
                      src="@/assets/img/login-banner.png"
                      class="img-fluid"
                      alt="Login Banner"
                    />
                  </div>
                  <div class="col-md-12 col-lg-6 login-right">
                    <div class="login-header">
                      <h3>Forgot Password?</h3>
                      <p class="small text-muted">
                        Enter your email to get a password reset link
                      </p>
                    </div>

                    <!-- Forgot Password Form -->
                    <form @submit.prevent="submitForm">
                      <div class="mb-3 form-focus">
                        <input type="email" class="form-control floating" />
                        <label class="focus-label">Email</label>
                      </div>
                      <div class="text-end">
                        <router-link class="forgot-link" to="/login"
                          >Remember your password?</router-link
                        >
                      </div>
                      <b-button
                        class="btn btn-primary w-100 btn-lg login-btn"
                        type="submit"
                        >Reset Password</b-button
                      >
                    </form>
                    <!-- /Forgot Password Form -->
                  </div>
                </div>
              </div>
              <!-- /Account Content -->
            </div>
          </div>
        </div>
      </div>
      <!-- /Page Content -->
    </div>
  </div>
  <indexfooter></indexfooter>
</template>
<script>
export default {
  methods: {
    submitForm() {
      this.$router.push("/login");
    },
  },
};
</script>
