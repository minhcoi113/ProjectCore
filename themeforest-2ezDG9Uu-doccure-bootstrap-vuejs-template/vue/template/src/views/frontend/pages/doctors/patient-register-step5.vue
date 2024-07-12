<template>
  <!-- Main Wrapper -->
  <div class="main-wrapper">
    <!-- Page Content -->
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
                      <li><a href="javascript:void(0)" class="active-done">1</a></li>
                      <li><a href="javascript:void(0)" class="active-done">2</a></li>
                      <li><a href="javascript:void(0)" class="active-done">3</a></li>
                      <li><a href="javascript:void(0)" class="active-done">4</a></li>
                      <li><a href="javascript:void(0)" class="active">5</a></li>
                    </ul>
                  </div>
                  <form method="post">
                    <h3 class="my-4">Your Location</h3>
                    <div class="mb-3">
                      <label class="mb-2">Select City</label>

                      <vue-select :options="sorting2" placeholder="Select Your State" />
                    </div>
                    <div class="mb-3">
                      <label class="mb-2">Select State</label>

                      <vue-select :options="sorting2" placeholder="Select Your City" />
                    </div>

                    <div class="mt-5">
                      <router-link
                        to="patient-dashboard"
                        class="btn btn-primary w-100 btn-lg login-btn step5_submit"
                        >continue
                      </router-link>
                    </div>
                  </form>
                </div>
              </div>
              <div class="login-bottom-copyright">
                <span>© {{ new Date().getFullYear() }} Doccure. All rights reserved.</span>
              </div>
            </div>
          </div>
        </div>
        <!-- /Register Content -->
      </div>
    </div>
    <!-- /Page Content -->
  </div>
  <!-- /Main Wrapper -->
</template>
<script>
export default {
  data() {
    return {
      sorting1: ["Select Your State", "State 1", "State 2"],
      sorting2: ["Select Your City", "City 1", "City 2"],
    };
  },
};
</script>
