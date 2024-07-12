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
              <h1>Register</h1>
              <p class="account-subtitle">Access to our dashboard</p>

              <!-- Form -->
              <Form
                class="register"
                @submit="onSubmit"
                :validation-schema="schema"
                v-slot="{ errors }"
              >
                <div class="mb-3 form-focus focused">
                  <Field
                    name="email"
                    type="text"
                    class="form-control"
                    placeholder="Email"
                    :class="{ 'is-invalid': errors.email }"
                  />

                  <div class="invalid-feedback">{{ errors.email }}</div>
                  <div class="emailshow text-danger" id="email"></div>
                </div>
                <div class="mb-3 form-focus focused pass-group">
                  <Field
                    name="password"
                    :type="showPassword ? 'text' : 'password'"
                    class="form-control pass-input mt-2"
                    placeholder="Password"
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
                <div class="mb-3 form-focus focused password-icon">
                  <Field
                    name="confirmpassword"
                    type="password"
                    class="form-control pass-input"
                    placeholder="Confirm Password"
                    :class="{ 'is-invalid': errors.confirmpassword }"
                  />

                  <div class="invalid-feedback">{{ errors.confirmpassword }}</div>
                  <div class="emailshow text-danger" id="confirmpassword"></div>
                </div>
                <div class="mb-0">
                  <b-button class="btn btn-primary w-100" type="submit"
                    >Register</b-button
                  >
                </div>
              </Form>
              <!-- /Form -->

              <div class="login-or">
                <span class="or-line"></span>
                <span class="span-or">or</span>
              </div>

              <!-- Social Login -->
              <div class="social-login">
                <span>Register with</span>
                <a href="javascript:;" class="facebook"
                  ><i class="fa-brands fa-facebook-f"></i></a
                ><a href="javascript:;" class="google"
                  ><i class="fa-brands fa-google"></i
                ></a>
              </div>
              <!-- /Social Login -->

              <div class="text-center dont-have">
                Already have an account? <router-link to="login">Login</router-link>
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
import { ref } from "vue";
import { Form, Field } from "vee-validate";
import * as Yup from "yup";
import { router } from "@/router";

export default {
  components: {
    Form,
    Field,
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
  },
  setup() {
    const showPassword = ref(false);
    const emailError = ref("");
    const passwordError = ref("");

    const schema = Yup.object().shape({
      email: Yup.string().required("Email is required").email("Email is invalid"),
      password: Yup.string()
        .min(6, "Password must be at least 6 characters")
        .required("Password is required"),
      confirmpassword: Yup.string()
        .min(6, "Password must be at least 6 characters")
        .required("Confirm password is required"),
    });

    const onSubmit = (values) => {
      if (values.password === values.confirmpassword) {
        let Rawdata = localStorage.getItem("storedData");
        let Pdata = [];
        Pdata = JSON.parse(Rawdata);
        const Eresult = Pdata.find(({ email }) => email === values.email);
        if (Eresult) {
          emailError.value = "This email is already in use";
        } else {
          Pdata.push(values);
          const jsonData = JSON.stringify(Pdata);
          localStorage.setItem("storedData", jsonData);
          router.push("login");
        }
      } else {
        passwordError.value = "Password does not match";
      }
    };

    return {
      showPassword,
      schema,
      onSubmit,
      emailError,
      passwordError,
    };
  },
  name: "pharmacy/register",
};
</script>
