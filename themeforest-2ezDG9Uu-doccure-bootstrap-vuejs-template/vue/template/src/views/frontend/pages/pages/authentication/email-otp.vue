<template>
  <div class="login-body">
    <div class="main-wrapper">
      <layoutheader></layoutheader>

      <!-- Page Content -->
      <div class="login-content-info">
        <div class="container">
          <!-- Login Email Otp -->
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
                    <router-link to="login-email-otp"
                      ><i class="fa-solid fa-arrow-left-long"></i> Back</router-link
                    >
                  </div>
                  <div class="login-verify-img">
                    <img src="@/assets/img/icons/email-icon.svg" alt="email-icon" />
                  </div>
                  <div class="login-title">
                    <h3>Email OTP Verification</h3>
                    <p class="mb-0">
                      OTP sent to your Email ending <strong>**********@gmail.com</strong>
                    </p>
                  </div>
                  <form
                    method="get"
                    class="digit-group login-form-control"
                    data-group-name="digits"
                    data-autosubmit="false"
                    autocomplete="off"
                    action="doctor-dashboard"
                  >
                    <div class="otp-box">
                      <div class="mb-3">
                        <input
                          v-for="(digit, index) in digits"
                          :key="index"
                          :id="`digit-${index + 1}`"
                          :name="`digit-${index + 1}`"
                          :maxlength="1"
                          :class="{ active: digit !== '' }"
                          @input="onInput(index, $event.target.value)"
                          @keydown="onKeyDown(index, $event)"
                          @keyup="onKeyUp(index, $event)"
                          :data-next="
                            index < digits.length - 1 ? `digit-${index + 2}` : null
                          "
                          :data-previous="index > 0 ? `digit-${index}` : null"
                          ref="inputRefs"
                        />
                      </div>
                    </div>
                    <div class="mb-3">
                      <div class="otp-info">
                        <div class="otp-code">
                          <p>Didn't receive OTP code?</p>
                          <a href="javascript:void(0);">Resend Code</a>
                        </div>
                        <div class="otp-sec">
                          <p><i class="feather-clock"></i> 00:25 secs</p>
                        </div>
                      </div>
                    </div>
                    <div class="reset-btn">
                      <b-button class="btn w-100" type="submit">Submit</b-button>
                    </div>
                  </form>
                </div>
              </div>
            </div>
          </div>
          <!-- /Login Email Otp -->
        </div>
      </div>
      <!-- /Page Content -->
      <cursor></cursor>
    </div>
  </div>
</template>
<script>
import { ref, onMounted } from "vue";

export default {
  setup() {
    const digits = ref(Array(4).fill(""));
    const inputRefs = ref([]);

    function onInput(index, value) {
      if (value.length > 0) {
        value = value.slice(0, 1);
      }
      digits.value[index] = value;
    }

    function focusInput(index) {
      const input = inputRefs.value[index];
      if (input) {
        input.focus();
        input.select();
      }
    }

    function onKeyDown(index, event) {
      const value = digits.value[index];

      if (event.keyCode === 8 || event.keyCode === 37) {
        if (!value && index > 0) {
          digits.value[index - 1] = "";
          focusInput(index - 1);
        } else if (!value && index === 0) {
          event.preventDefault();
        }
      } else if (
        (event.keyCode >= 48 && event.keyCode <= 57) ||
        (event.keyCode >= 65 && event.keyCode <= 90) ||
        (event.keyCode >= 96 && event.keyCode <= 105) ||
        event.keyCode === 39
      ) {
        const nextInputId = inputRefs.value[index + 1];
        if (nextInputId) {
          const nextInput = nextInputId.$el;
          nextInput && nextInput.focus();
        }
      }
    }

    function onKeyUp(index, event) {
      const value = event.target.value;
      digits.value[index] = value;

      if (index === 0 && !value) {
        focusInput(0);
      }
    }

    onMounted(() => {
      // Focus the first input
      const firstInput = inputRefs.value[0];
      if (firstInput) {
        firstInput.focus();
      }
    });

    return {
      digits,
      onInput,
      onKeyDown,
      onKeyUp,
    };
  },
};
</script>
