<template>
  <div class="login-body">
    <div class="man-wrapper">
      <layoutheader></layoutheader>

      <!-- Page Content -->
      <div class="login-content-info">
        <div class="container">
          <!-- Doctor Signup -->
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
                <div class="widget-set">
                  <div class="account-info">
                    <div class="widget-content multistep-form">
                      <fieldset id="first" v-if="currentStep === 1">
                        <div class="login-back">
                          <router-link to="/"
                            ><i class="fa-solid fa-arrow-left-long"></i> Back</router-link
                          >
                        </div>
                        <div class="login-title">
                          <h3>Doctor Signup</h3>
                          <p class="mb-0">Welcome back! Please enter your details.</p>
                        </div>
                        <div class="widget-setcount">
                          <ul id="progressbar">
                            <li class="progress-active">
                              <div class="step-box">
                                <div class="step-icon">
                                  <span>
                                    <img
                                      src="@/assets/img/icons/signup-users.svg"
                                      alt="icon"
                                    />
                                  </span>
                                </div>
                                <div class="step-content">
                                  <p>Step 1</p>
                                  <h4>Create Account</h4>
                                </div>
                              </div>
                            </li>
                            <li>
                              <div class="step-box">
                                <div class="step-icon">
                                  <span>
                                    <img
                                      src="@/assets/img/icons/signup-unlock.svg"
                                      alt="icon"
                                    />
                                  </span>
                                </div>
                                <div class="step-content">
                                  <p>Step 2</p>
                                  <h4>Verify Account</h4>
                                </div>
                              </div>
                            </li>
                          </ul>
                        </div>
                        <form action="javascript:;">
                          <div class="mb-3">
                            <label class="mb-2">Name</label>
                            <input
                              type="text"
                              class="form-control"
                              placeholder="Enter Your Name"
                            />
                          </div>
                          <div class="mb-3">
                            <label class="mb-2">Email</label>
                            <input
                              type="text"
                              class="form-control"
                              placeholder="Enter Your Email"
                            />
                          </div>
                          <div class="mb-3">
                            <label class="mb-2">Phone Number</label>
                            <vue-tel-input
                              mode="international"
                              class="form-control form-control-lg group_formcontrol form-control-phone"
                              id="phone"
                              name="phone"
                              value="(256) 789-6253"
                            ></vue-tel-input>
                          </div>
                          <div class="mb-3">
                            <label class="mb-2">Password </label>
                            <div class="pass-group">
                              <input
                                v-if="showPassword"
                                type="text"
                                class="form-control pass-input"
                                v-model="password"
                                placeholder="**********"
                              />

                              <input
                                v-else
                                type="password"
                                class="form-control pass-input"
                                placeholder="**********"
                                v-model="password"
                              />

                              <span
                                class="toggle-password"
                                @click="toggleShow"
                                :class="{
                                  'feather-eye': showPassword,
                                  'feather-eye-off': !showPassword,
                                }"
                              ></span>
                            </div>
                          </div>
                        </form>
                        <div
                          class="widget-btn"
                          @click="nextStep"
                          :disabled="currentStep === totalSteps"
                        >
                          <a class="btn btn-primary w-100 next_btn">Next</a>
                        </div>
                      </fieldset>
                      <fieldset class="field-card" v-if="currentStep === 2">
                        <div class="login-back">
                          <a
                            href="javascript:void(0);"
                            class="prev_btn"
                            @click="previousStep"
                            :disabled="currentStep === 1"
                          >
                            <i class="fa-solid fa-arrow-left-long"></i> Back
                          </a>
                        </div>
                        <div class="login-title">
                          <h3>Security Verification</h3>
                          <p class="mb-0">
                            To Secure your Account create complete the following verify
                            request.
                          </p>
                        </div>
                        <div class="widget-setcount">
                          <ul id="progressbar1">
                            <li class="progress-active">
                              <div class="step-box">
                                <div class="step-icon">
                                  <span>
                                    <img
                                      src="@/assets/img/icons/signup-users.svg"
                                      alt="icon"
                                    />
                                  </span>
                                </div>
                                <div class="step-content">
                                  <p>Step 1</p>
                                  <h4>Create Account</h4>
                                </div>
                              </div>
                            </li>
                            <li class="progress-active">
                              <div class="step-box">
                                <div class="step-icon">
                                  <span>
                                    <img
                                      src="@/assets/img/icons/signup-unlock.svg"
                                      alt="icon"
                                    />
                                  </span>
                                </div>
                                <div class="step-content">
                                  <p>Step 2</p>
                                  <h4>Verify Account</h4>
                                </div>
                              </div>
                            </li>
                          </ul>
                        </div>
                        <form
                          @submit.prevent="submitForm"
                          class="signup-verfication-form"
                        >
                          <div class="mb-3">
                            <div class="form-group-flex">
                              <label class="mb-2">Phone Number Verfication Code</label>
                              <a href="javascript:void(0);" class="forgot-link"
                                >Get Code</a
                              >
                            </div>
                            <div class="pass-group">
                              <vue-tel-input
                                mode="international"
                                class="form-control form-control-lg group_formcontrol form-control-phone"
                                id="phone"
                                name="phone"
                                value="(256) 789-6253"
                              ></vue-tel-input>
                            </div>
                            <p class="signup-code">
                              Enter the 6 digit code sent to 98****4578
                            </p>
                          </div>
                          <div class="mb-3">
                            <div class="form-group-flex">
                              <label class="mb-2">Email Verfication Code</label>
                              <a href="javascript:void(0);" class="forgot-link"
                                >Get Code</a
                              >
                            </div>
                            <div class="pass-group">
                              <input
                                type="text"
                                class="form-control form-control-phone"
                                placeholder="example@gmail.com"
                              />
                            </div>
                            <p class="signup-code">
                              Enter the 6 digit code sent to ex****@gmail.com
                            </p>
                          </div>
                          <div class="mb-0">
                            <b-button class="btn btn-primary w-100" type="submit"
                              >Submit</b-button
                            >
                          </div>
                        </form>
                      </fieldset>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <!-- /Doctor Signup -->
        </div>
      </div>
      <!-- /Page Content -->
    </div>
  </div>
</template>
<script>
export default {
  data() {
    return {
      showPassword: false,
      password: null,
      currentStep: 1,
      totalSteps: 2,
    };
  },
  computed: {
    buttonLabel() {
      return this.showPassword ? "Hide" : "Show";
    },
  },
  methods: {
    toggleShow() {
      this.showPassword = !this.showPassword;
    },
    nextStep() {
      if (this.currentStep < this.totalSteps) {
        this.currentStep++;
      }
    },
    submitForm() {
      this.$router.push("/signup-success");
    },
    previousStep() {
      if (this.currentStep > 1) {
        this.currentStep--;
      }
    },
  },
};
</script>
