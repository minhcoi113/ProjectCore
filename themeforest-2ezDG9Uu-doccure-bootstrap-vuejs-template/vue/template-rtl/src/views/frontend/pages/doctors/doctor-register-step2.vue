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
                      <li><a href="javascript:void(0)" class="active">2</a></li>
                      <li><a href="javascript:void(0)">3</a></li>
                    </ul>
                  </div>
                  <form id="personal_details" enctype="multipart/form-data">
                    <div class="text-start mt-2">
                      <h4 class="mt-3">Select Your Gender</h4>
                    </div>
                    <div class="select-gender-col">
                      <div class="row">
                        <div class="col-6 pe-2">
                          <input
                            type="radio"
                            id="test1"
                            name="gender"
                            checked=""
                            value="Male"
                          />
                          <label for="test1">
                            <span class="gender-icon"
                              ><img src="@/assets/img/icons/male.png" alt="male-icon"
                            /></span>
                            <span>Male</span>
                          </label>
                        </div>
                        <div class="col-6 ps-2">
                          <input type="radio" id="test2" name="gender" value="Female" />
                          <label for="test2">
                            <span class="gender-icon"
                              ><img src="@/assets/img/icons/female.png" alt="female-icon"
                            /></span>
                            <span>Female</span>
                          </label>
                        </div>
                      </div>
                    </div>
                    <div class="pregnant-col pt-4">
                      <div>
                        <div class="remember-me-col d-flex justify-content-between">
                          <span class="mt-1">Are you Registered?</span>
                          <label class="custom_check">
                            <input
                              type="checkbox"
                              class=""
                              id="is_registered"
                              name="isregistered"
                              value="1"
                            />
                            <span class="checkmark"></span>
                          </label>
                        </div>
                      </div>
                    </div>
                    <div class="step-process-col mt-4">
                      <div class="mb-3" id="preg_div" style="display: none">
                        <label class="mb-2">How many years have you been registered?</label>
                        <vue-select
                          :options="sorting"
                          placeholder="Tell us how long you have been practicing"
                        />
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">Registered Clinic address</label>
                        <input
                          type="text"
                          name="address"
                          class="form-control"
                          id="address"
                        />
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">Address 2</label>
                        <input
                          type="text"
                          name="address2"
                          class="form-control"
                          id="address2"
                        />
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">Pincode / Zipcoode</label>
                        <input
                          type="text"
                          name="zipcode"
                          class="form-control"
                          id="zipcode"
                        />
                      </div>

                      <div class="mb-3">
                        <label class="mb-2">Certification and Employer</label>
                        <div class="row justify-content-center">
                          <div class="col-12 col-md-6 d-flex">
                            <div
                              class="profile-pic-upload d-flex flex-wrap justify-content-center"
                            >
                              <div class="cam-col">
                                <img
                                  src="@/assets/img/icons/camera.svg"
                                  alt="camera-image"
                                />
                              </div>
                              <span class="text-center"
                                >Upload Rigth To sell Certigifcate</span
                              >
                              <input
                                type="file"
                                id="quali_certificate"
                                name="quali_certificate"
                              />
                            </div>
                          </div>
                          <div class="col-12 col-md-6 d-flex">
                            <div
                              class="profile-pic-upload d-flex flex-wrap justify-content-center"
                            >
                              <div class="cam-col">
                                <img
                                  src="@/assets/img/icons/camera.svg"
                                  alt="camera-image"
                                />
                              </div>
                              <span class="text-center">Upload Photo ID</span>
                              <input type="file" id="photo_id" name="photo_id" />
                            </div>
                          </div>
                          <div class="col-12 col-md-6 d-flex">
                            <div
                              class="profile-pic-upload d-flex flex-wrap justify-content-center"
                            >
                              <div class="cam-col">
                                <img
                                  src="@/assets/img/icons/camera.svg"
                                  alt="camera-image"
                                />
                              </div>
                              <span class="text-center">Upload Clinical employment</span>
                              <input
                                type="file"
                                id="clinical_employment"
                                name="clinical_employment"
                              />
                            </div>
                          </div>
                        </div>
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">Your Weight</label>
                        <div class="row">
                          <div class="col-7 pe-2">
                            <input
                              type="text"
                              class="form-control"
                              name="weight"
                              id="weight"
                            />
                          </div>
                          <div class="col-5 ps-2">
                            <vue-select :options="sorting2" placeholder="Kg" />
                          </div>
                        </div>
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">Your Height</label>
                        <div class="row">
                          <div class="col-7 pe-2">
                            <input type="text" class="form-control" id="height" />
                          </div>
                          <div class="col-5 ps-2">
                            <vue-select :options="sorting3" placeholder="cm" />
                          </div>
                        </div>
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">Your Age</label>
                        <input type="text" name="age" class="form-control" id="age" />
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">Blood Type</label>
                        <vue-select
                          :options="sorting1"
                          placeholder="Select your blood group"
                        />
                      </div>
                    </div>
                    <div class="mt-5">
                      <router-link
                        to="doctor-register-step3"
                        class="btn btn-primary w-100 btn-lg login-btn step2_submit"
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
  <doctor-register-step3></doctor-register-step3>
  <!-- /Main Wrapper -->
</template>
<script>
export default {
  data() {
    return {
      sorting: [
        "Tell us how long you have been practicing",
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10+",
      ],
      sorting1: [
        "Select your blood group",
        "A-",
        "A+",
        "B-",
        "B+",
        "AB-",
        "AB+",
        "O-",
        "O-",
      ],
      sorting3: ["cm", "ft"],
      sorting2: ["kg"],
    };
  },
  mounted() {
    document.addEventListener("DOMContentLoaded", function () {
      const isRegisteredCheckbox = document.getElementById("is_registered");
      const pregDiv = document.getElementById("preg_div");

      isRegisteredCheckbox.addEventListener("click", function () {
        if (this.checked) {
          pregDiv.style.display = "block";
        } else {
          pregDiv.style.display = "none";
        }
      });
    });
  },
};
</script>
