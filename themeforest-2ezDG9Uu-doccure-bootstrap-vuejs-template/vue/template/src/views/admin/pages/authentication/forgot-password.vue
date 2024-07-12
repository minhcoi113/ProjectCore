<template>
  <!-- Main Wrapper -->
  <div class="main-wrapper login-body">
    <div class="login-wrapper">
      <div class="container">
        <div class="loginbox">
          <div class="login-left">
            <img class="img-fluid" src="@/assets/admin/img/logo-white.png" alt="Logo" />
          </div>
          <div class="login-right">
            <div class="login-right-wrap">
              <h1>Forgot Password?</h1>
              <p class="account-subtitle">
                Enter your email to get a password reset link
              </p>

              <!-- Form -->
              <form @submit.prevent="submitForm">
                <div class="form-group">
                  <input class="form-control" type="text" placeholder="Email" />
                </div>
                <div class="form-group mb-0">
                  <b-button class="btn btn-primary w-100" type="submit">
                    Reset Password
                  </b-button>
                </div>
              </form>
              <!-- /Form -->

              <div class="text-center dont-have">
                Remember your password? <router-link to="/admin/login">Login</router-link>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
  <!-- /Main Wrapper -->
</template>

<script>
export default {
  data() {
    return {};
  },
  methods: {
    submitForm() {
      this.$router.push("/admin/login");
    },
  },
  name: "/admin/forgot-password",
};
</script>
