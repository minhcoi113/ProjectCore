<template>
  <div class="login-body">
    <div class="main-wrapper">
      <layoutheader></layoutheader>

      <!-- Page Content -->
      <div class="login-content-info">
        <div class="container">
          <!-- Forgot Password -->
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
                    <router-link to="/login-email"
                      ><i class="fa-solid fa-arrow-left-long"></i> Back</router-link
                    >
                  </div>
                  <div class="login-title">
                    <h3>Password Recovery</h3>
                    <p class="mb-0">
                      Enter your email and we will send you a link to reset your password.
                    </p>
                  </div>
                  <form @submit.prevent="submitForm">
                    <div class="mb-3">
                      <label class="mb-2">E-mail</label>
                      <input
                        type="text"
                        class="form-control"
                        placeholder="example@email.com"
                      />
                    </div>
                    <div class="mb-3">
                      <b-button class="btn w-100" type="submit">Sign in</b-button>
                    </div>
                    <div class="back-btn-light mb-0">
                      <b-button class="btn btn-light w-100" type="submit">
                        <i class="fa-solid fa-arrow-left"></i> Back
                      </b-button>
                    </div>
                  </form>
                </div>
              </div>
            </div>
          </div>
          <!-- /Forgot Password -->
        </div>
      </div>
      <!-- /Page Content -->
    </div>
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
