<script>
import appConfig from "@/app.config";
import {required, email} from "vuelidate/lib/validators";
import Vue from "vue";

/**
 * Login component
 */
export default {
  page: {
    title: "Đăng nhập",
    meta: [
      {
        name: "description",
        content: appConfig.description,
      },
    ],
  },
  components: {
  },
  data() {
    return {
      email: "admin@themesbrand.com",
      password: "123456",
      submitted: false,
      authError: null,
      tryingToLogIn: false,
      isAuthError: false,
      capcha: null,
      modelAuth: {
        isAuthError: false,
        message: null
      },
      model: {
        userName: "",
        password: ""
      },
      cssProps: {
        backgroundImage: `url(${require('./bgimg.jpg')})`
      },
      passwordFieldType: "password",
    };
  },
  validations: {
    model: {
      userName: {
        required,
      },
      password: {
        required
      }
    }
  },
  computed: {},
  methods: {
    switchVisibility() {
      this.passwordFieldType = this.passwordFieldType === "password" ? "text" : "password";
    },
    submit(response) {
      this.capcha = response;
    },
    async Login(e) {
      e.preventDefault();
      // if (!this.capcha && process.env.VUE_APP_ENV != 'development') {
      //   this.modelAuth.isAuthError = true;
      //   this.modelAuth.message = "Xác nhận đã nhập mã captcha";
      //   return;
      // }
      this.submitted = true;
      this.$v.$touch();
      if (this.$v.$invalid) {
        return;
      } else {
        let loader = this.$loading.show({
          container: this.$refs.formContainer,
        });
       await this.$store.dispatch("authStore/login", this.model).then(async (res) => {

          if (res.code === 0) {

            await new Promise(resolve => setTimeout(resolve, 1000));
            localStorage.setItem('auth-user', JSON.stringify(res.data));
            localStorage.setItem("user-token", JSON.stringify(res.data.accessToken));
            if (res.data) {
              if (res.data.menu) {
                localStorage.setItem("menuItems", JSON.stringify(res.data.menu));
              }
            }
            Vue.prototype.$auth_token = res.data.token;
            this.showModal = false;
            this.model = {};
            this.modelAuth.isAuthError = false;
            window.location.href = '/cong-viec'
          } else {
            if (res.Code == 24) {
              this.modelAuth.isAuthError = true;
              this.modelAuth.message = "Lỗi! Hãy kiểm tra kết nối mạng!";
            } else {
              this.modelAuth.isAuthError = true;
              this.modelAuth.message = res.message;
            }
            loader.hide();
          }

        })
            .finally(() => {
              loader.hide();
            });
       }
       this.submitted = false;
    },
    togglePasswordVisibility() {
      this.showPassword = !this.showPassword;
    },
  },
  mounted() {
  },
};
</script>

<template>
  <div class="container-fluid p-0 bg-login">
    <div class="row g-0 justify-content-end">
      <div class="col-xl-4 col-md-6 col-12 px-md-2 login-box">
        <div class="auth-full-page-content p-4">
          <div class="w-100">
            <div class="d-flex flex-column h-100">
              <div class="d-flex justify-content-center flex-column align-items-center">
              </div>
              <div class="my-auto">
                <div
                    class="text-center h6
                    text-uppercase fw-bold login-title"
                >
                  ĐĂNG NHẬP
                </div>
                <b-alert
                    v-model="modelAuth.isAuthError"
                    variant="danger"
                    class="mt-4"
                    dismissible
                >{{ modelAuth.message }}
                </b-alert
                >
                <b-form class="" @submit.prevent="Login" ref="formContainer">
                  <b-form-group
                      class="mb-4 title-form"
                      id="input-group-1"
                      label="Tài khoản"
                      label-for="input-1"
                  >
                    <b-form-input
                        id="input-1"
                        v-model="model.userName"
                        type="text"
                        placeholder="Nhập tài khoản"
                        :class="{ 'is-invalid': submitted && $v.model.userName.$error }"
                    ></b-form-input>
                    <div
                        v-if="submitted && $v.model.userName.$error"
                        class="invalid-feedback"
                    >
                      <span v-if="!$v.model.userName.required">Tài khoản không được trống.</span>
                    </div>
                  </b-form-group>
<!--                  <b-form-group-->
<!--                      class="mb-4 title-form"-->
<!--                      id="input-group-2"-->
<!--                      label="Mật khẩu"-->
<!--                      label-for="input-2"-->
<!--                  >-->
<!--                    <b-form-input-->
<!--                        id="input-2"-->
<!--                        v-model="model.password"-->
<!--                        :type="showPassword ? 'text' : 'password'"-->
<!--                        placeholder="Nhập mật khẩu"-->
<!--                        :class="{ 'is-invalid': submitted && $v.model.password.$error }"-->
<!--                    ></b-form-input>-->
<!--                    <div-->
<!--                        v-if="submitted && !$v.model.password.required"-->
<!--                        class="invalid-feedback"-->
<!--                    >-->
<!--                      Mật khẩu không được trống.-->
<!--                    </div>-->
<!--                  </b-form-group>-->

                  <template>
                    <b-form-group
                        id="input-group-2"
                        label="Mật khẩu"
                        label-for="input-2"
                        class="mb-3"
                        label-class="form-label"
                    >
                      <div class="position-relative">
                        <b-form-input
                            id="input-2"
                            v-model="model.password"
                            :type="passwordFieldType"
                            placeholder="Nhập mật khẩu"
                            :class="{ 'is-invalid': submitted && $v.model.password.$error }"
                            class="password"
                        ></b-form-input>
                        <div
                            v-if="submitted && !$v.model.password.required"
                            class="invalid-feedback"
                        >
                          Mật khẩu không được trống.
                        </div>
                        <div class="input-group-prepend">
                          <a @click="switchVisibility">
                            <template v-if="this.passwordFieldType=='password'">
                              <i class="mdi mdi-eye mdi-16px"></i>
                            </template>
                            <template v-else>
                              <i class="mdi mdi-eye-off mdi-16px"></i>
                            </template>
                          </a>
                        </div>
                      </div>

                    </b-form-group>
                  </template>
<!--                  <div class="form-check">-->
<!--                    <input-->
<!--                        class="form-check-input"-->
<!--                        type="checkbox"-->
<!--                        id="remember-check"-->
<!--                    />-->
<!--                    <label class="form-check-label" for="remember-check">-->
<!--                      Ghi nhớ đăng nhập-->
<!--                    </label>-->
<!--                  </div>-->
<!--                  <div class="my-2 d-flex justify-content-center">-->
<!--                    <vue-recaptcha @verify="submit" sitekey="6Lf4VxggAAAAAMKFoeMXT5gYHuZQ-tosJyBBWvvL"></vue-recaptcha>-->
<!--                  </div>-->
                  <div class="mt-3 d-grid">
                    <b-button
                        type="submit"
                        class="text-uppercase fw-bold login-submit"
                    >ĐĂNG NHẬP
                    </b-button
                    >
                  </div>
                </b-form>
              </div>
            </div>
          </div>
        </div>
      </div>
      <!-- end col -->
    </div>
  </div>
</template>

<style>
.bg-login {
  background: url("~@/assets/images/bg-login.jpg");
  background-size: cover;
  background-repeat: no-repeat;
  background-position: center;
  opacity: 1;
}

.login-box {
  background-color: transparent;
}

.login-title {
  font-size: 36px;
  background: -webkit-linear-gradient(0deg, #0e96dc, #103672);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  margin-bottom: 20px;
}

.login-submit {
  color: #fff !important;
  background: linear-gradient(135deg, #103672, #0e96dc) !important;
  border: none;
}

.login-sso {
  color: #061c3d !important;
  background: linear-gradient(135deg, #c4fcb9, #5ab6e5) !important;
  border: none;
}

.title-form,
.form-check-label,
.login-text {
  color: #2a2a2a;
}

@media only screen and (min-width: 1204px) {
  .login-box {
    margin-right: 100px;
  }
}

@media only screen and (max-width: 767px) {
  .login-title {
    font-size: 28px;
    background: -webkit-linear-gradient(0deg, #5ab6e5, #061c3d);
    -webkit-background-clip: text;
    -webkit-text-fill-color: transparent;
    margin-bottom: 5px;
  }

  .title-form,
  .form-check-label,
  .login-text {
    color: #fff !important;
    text-shadow: 0px 2px 5px #2a2a2a;
  }
}
.form-label{
  font-size: 14px;
  font-weight: normal;
}
.input-group-prepend {
  position: absolute;
  top: 17%;
  right: 13px;
  cursor: pointer;
}

</style>

