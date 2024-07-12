<template>
  <!-- Onboarding Verification -->

  <div class="onboard-wrapper">
    <onboarding-slider></onboarding-slider>
    <div class="right-panel">
      <div class="container">
        <div class="row">
          <div class="col-lg-12 p-0">
            <div class="right-panel-title text-center">
              <router-link to="/">
                <img src="@/assets/img/onboard-img/onb-logo.png" alt="Image"
              /></router-link>
            </div>
          </div>
          <div class="col-lg-4 col-md-12">
            <onboarding-sidebar></onboarding-sidebar>
          </div>
          <div class="col-lg-8 col-md-12">
            <div class="onboarding-content-box">
              <div class="onboarding-title">
                <h2>Doctor Verification<span>*</span></h2>
                <h6>Please provide the details below and attach copies for your:</h6>
              </div>
              <div class="onboarding-content passcode-wrap mail-box">
                <div class="row">
                  <div class="col-lg-12">
                    <div class="verify-box">
                      <ul class="verify-list">
                        <li class="verify-item">
                          Certificate of Registration with the Maltese Medical Council OR
                          Registration from the appropriate Professional Council
                        </li>
                        <li class="verify-item">
                          Certificate of Good Standing (from the Maltese Medical Council -
                          valid for 3 months from the date of issue). Doctors applying
                          from overseas are to provide a Certificate of Good Standing
                          issued from the most recent country of residence / practise
                          (valid for 3 months from the date of issue) (only applicable for
                          Medical Doctors)
                        </li>
                        <li class="verify-item">Curriculum Vitae</li>
                        <li class="verify-item">Specialist Registration Certificate</li>
                        <li class="verify-item">
                          Digital signature: copy of the signature and registration number
                        </li>
                      </ul>
                    </div>
                  </div>
                  <div class="col-lg-12">
                    <div class="form-group mt-4">
                      <label class="onboarding-lable"
                        >Medical council registration number <span>*</span></label
                      >
                      <input
                        type="text"
                        placeholder="Medical council registration number"
                        class="form-control placeholder-style"
                        required=""
                      />
                    </div>
                  </div>
                  <div class="col-lg-12">
                    <div class="form-group">
                      <div class="call-option file-option">
                        <input
                          type="file"
                          id="radio1"
                          name="selector"
                          class="option-radio"
                        />
                        <label for="radio1" class="call-lable verify-lable verify-file">
                          <img src="@/assets/img/icons/file.png" alt="Image" />Upload
                          Document</label
                        >
                      </div>
                    </div>
                  </div>
                  <div class="col-lg-12">
                    <div class="form-group mt-4">
                      <label class="onboarding-lable"
                        >Area of Specialisation<span>*</span></label
                      >
                      <vue-select
                        :options="Area"
                        placeholder="Select Area of Specialisatio"
                      />
                    </div>
                  </div>
                </div>
              </div>
              <div class="onboarding-btn Personalize-btn">
                <router-link to="/onboarding-payments">Continue</router-link>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
  <!-- /Onboarding Verification -->
</template>
<script>
export default {
  data() {
    return {
      Area: ["Select Area of Specialisation", "Surgery", "Heart", "Ortho"],
    };
  },
};
</script>
