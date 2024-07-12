<template>
  <div class="account-page">
    <div class="main-wrapper">
      <div class="content login-page pt-0">
        <div class="container-fluid">
          <!-- Register Content -->
          <div class="account-content">
            <div class="row align-items-center">
              <div class="login-right">
                <div class="inner-right-login">
                  <div class="login-header">
                    <div class="logo-icon">
                      <img src="@/assets/img/logo.png" alt="doccure-logo" />
                    </div>
                    <div class="step-list">
                      <ul>
                        <li><a href="javascript:;" class="active-done">1</a></li>
                        <li><a href="javascript:;" class="active">2</a></li>
                        <li><a href="javascript:;">3</a></li>
                      </ul>
                    </div>
                    <form method="post">
                      <h3 class="my-4">Your Location</h3>
                      <div class="mb-3">
                        <label class="mb-2">Select City</label>
                        <vue-select :options="Sort" placeholder="Select" />
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">Select State</label>
                        <vue-select :options="Sort" placeholder="Select" />
                      </div>
                      <div class="mt-5">
                        <router-link
                          to="pharmacy-register-step3"
                          @click="redirectReloadGrid"
                          class="btn btn-primary w-100 btn-lg login-btn step5_submit"
                          >Continue</router-link
                        >
                      </div>
                    </form>
                  </div>
                </div>
                <div class="login-bottom-copyright">
                  <span
                    >© {{ new Date().getFullYear() }} Doccure. All rights reserved.</span
                  >
                </div>
              </div>
            </div>
          </div>
          <!-- /Register Content -->
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import productall from "@/assets/json/pharmacy/productall.json";
export default {
  data() {
    return {
      productall: productall,
      Sort: ["City 1", "City 2"],
      Sort: ["State 1", "State 2"],
    };
  },
  methods: {
    redirectReloadGrid() {
      this.$router.push({ path: "/pharmacy-register-step3" }).then(() => {
        this.$router.go();
      });
    },
  },
};
</script>
