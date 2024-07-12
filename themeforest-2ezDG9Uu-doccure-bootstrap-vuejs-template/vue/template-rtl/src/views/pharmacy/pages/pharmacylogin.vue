<template>
  <!-- Main Wrapper -->
  <div class="main-wrapper login-body">
    <div class="login-wrapper">
      <div class="container">
        <div class="loginbox">
          <div class="login-left">
            <img
              class="img-fluid"
              src="@/assets/pharmacy/img/logo-white.png"
              alt="Logo"
            />
          </div>
          <div class="login-right">
            <div class="login-right-wrap">
              <h1>Login</h1>
              <p class="account-subtitle">Access to our dashboard</p>

              <!-- Form -->
              <Form
                class="login"
                @submit="onSubmit"
                :validation-schema="schema"
                v-slot="{ errors }"
              >
                <div class="mb-3">
                  <Field
                    name="email"
                    type="text"
                    value="example@dreamstechnologies.com"
                    class="form-control"
                    :class="{ 'is-invalid': errors.email }"
                  />
                  <div class="invalid-feedback">{{ errors.email }}</div>
                  <div class="emailshow text-danger" id="email"></div>
                </div>
                <div class="mb-3 pass-group">
                  <Field
                    name="password"
                    :type="showPassword ? 'text' : 'password'"
                    value="123456"
                    class="form-control pass-input mt-2"
                    :class="{ 'is-invalid': errors.password }"
                  />
                  <span @click="toggleShow" class="toggle-password">
                    <i
                      :class="{
                        'fas fa-eye': showPassword,
                        'fas fa-eye-slash': !showPassword,
                      }"
                    ></i>
                  </span>
                  <div class="invalid-feedback">{{ errors.password }}</div>
                  <div class="emailshow text-danger" id="password"></div>
                </div>

                <div class="mb-3">
                  <b-button class="btn btn-primary w-100" type="submit">Login</b-button>
                </div>
              </Form>
              <!-- /Form -->

              <div class="text-center forgotpass">
                <router-link to="forgot-password">Forgot Password?</router-link>
              </div>
              <div class="login-or">
                <span class="or-line"></span>
                <span class="span-or">or</span>
              </div>

              <!-- Social Login -->
              <div class="social-login">
                <span>Login with</span>
                <a href="javascript:;" class="facebook"
                  ><i class="fa-brands fa-facebook-f"></i></a
                ><a href="javascript:;" class="google"
                  ><i class="fa-brands fa-google"></i
                ></a>
              </div>
              <!-- /Social Login -->

              <div class="text-center dont-have">
                Don’t have an account? <router-link to="register">Register</router-link>
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
import { Form, Field } from "vee-validate";
import * as Yup from "yup";
import { router } from "@/router";
export default {
  components: {
    Form,
    Field,
  },
  data() {
    return {
      showPassword: false,
      password: null,
      emailError: "",
      passwordError: "",
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
    onSubmit(values) {
      this.emailError = "";
      this.passwordError = "";

      let data = localStorage.getItem("storedData");
      var Pdata = JSON.parse(data);
      const Eresult = Pdata.find(({ email }) => email === values.email);
      if (Eresult) {
        if (Eresult.password === values.password) {
          this.$router.push("index"); // Use this.$router instead of router
        } else {
          this.passwordError = "Incorrect password";
        }
      } else {
        this.emailError = "Email is not valid";
      }
    },
  },
  setup() {
    let users = localStorage.getItem("storedData");
    if (users === null) {
      let password = [
        {
          email: "example@dreamstechnologies.com",
          password: "123456",
        },
      ];
      const jsonData = JSON.stringify(password);
      localStorage.setItem("storedData", jsonData);
    }
    const schema = Yup.object().shape({
      email: Yup.string().required("Email is required").email("Email is invalid"),
      password: Yup.string()
        .min(6, "Password must be at least 6 characters")
        .required("Password is required"),
    });
    return {
      schema,
    };
  },
};
</script>
