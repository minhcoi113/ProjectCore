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
                      <li><a href="javascript:void(0)">4</a></li>
                      <li><a href="javascript:void(0)">5</a></li>
                    </ul>
                  </div>
                  <form id="personal_details" enctype="multipart/form-data">
                    <div class="text-start mt-2">
                      <h4 class="mt-3">Select Your Gender</h4>
                    </div>
                    <div class="select-gender-col">
                      <div class="row">
                        <div class="col-6 pe-2">
                          <input type="radio" id="test1" name="gender" value="Male" />
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
                          <span class="mt-1">Are you Pregnant</span>
                          <label class="custom_check">
                            <input
                              type="checkbox"
                              class=""
                              id="is_registered"
                              name="pregnant"
                              value="1"
                            />
                            <span class="checkmark"></span>
                          </label>
                        </div>
                      </div>
                    </div>
                    <div class="step-process-col mt-4">
                      <div class="mb-3" id="preg_div" style="display: none">
                        <label class="mb-2">Pregnancy Term</label>

                        <vue-select
                          :options="sorting1"
                          placeholder="Select Your Pregnancy Month"
                        >
                        </vue-select>
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">Your Weight</label>
                        <div class="row">
                          <div class="col-7 pe-2">
                            <input
                              type="text"
                              class="form-control"
                              name="weight"
                              value=""
                              id="weight"
                            />
                          </div>
                          <div class="col-5 ps-2">
                            <vue-select :options="sorting6" placeholder="Kg">
                            </vue-select>
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
                            <vue-select :options="sorting7" placeholder="Cm">
                            </vue-select>
                          </div>
                        </div>
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">Your Age</label>
                        <input
                          type="text"
                          name="age"
                          value=""
                          class="form-control"
                          id="age"
                        />
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">Blood Type</label>
                        <vue-select
                          :options="sorting2"
                          placeholder="Select your blood group"
                        >
                        </vue-select>
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">Heart Rate</label>

                        <vue-select
                          :options="sorting3"
                          placeholder="Select Your Heart Rate"
                        >
                        </vue-select>
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">Blood Pressure</label>

                        <vue-select
                          :options="sorting4"
                          placeholder="Select Your Blood Pressure"
                        >
                        </vue-select>
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">Glucose Level</label>

                        <vue-select
                          :options="sorting5"
                          placeholder="Select Your Glucose Level"
                        >
                        </vue-select>
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">Allergies</label>
                        <input
                          type="text"
                          class="form-control"
                          value=""
                          id="allergies"
                          name="allergies"
                        />
                      </div>
                      <div class="checklist-col pregnant-col">
                        <div class="remember-me-col d-flex justify-content-between">
                          <span class="mt-1"
                            >Do you have any pre-exisiting conditions?</span
                          >
                          <label class="custom_check">
                            <input
                              type="checkbox"
                              class=""
                              name="cancer"
                              id="cancer"
                              value="1"
                            />
                            <span class="checkmark"></span>
                          </label>
                        </div>
                        <div
                          class="remember-me-col"
                          id="cancer_div"
                          style="display: none"
                        >
                          <div class="condition_input">
                            <input
                              type="text"
                              id="conditions"
                              name="conditions[]"
                              class="form-control"
                              placeholder=""
                            />
                          </div>
                          <a href="javascript:void(0);" class="add_condition"
                            ><i class="fa fa-plus"></i
                          ></a>
                        </div>
                        <div class="remember-me-col d-flex justify-content-between">
                          <span class="mt-1"
                            >Are you currently taking any medication</span
                          >
                          <label class="custom_check">
                            <input
                              type="checkbox"
                              class=""
                              name="medicine"
                              id="medicine"
                              value="1"
                            />
                            <span class="checkmark"></span>
                          </label>
                        </div>
                        <div
                          class="remember-me-col"
                          id="medicine_div"
                          style="display: none"
                        >
                          <div class="medicine_input">
                            <input
                              type="text"
                              id="medicine_name"
                              name="medicine_name[]"
                              value=""
                              class="form-control"
                              placeholder="Enter medicine_name"
                            />
                            <input
                              type="text"
                              value=""
                              id="dosage"
                              name="dosage[]"
                              class="form-control"
                              placeholder="Enter dosage"
                            />
                          </div>
                          <a href="javascript:void(0);" class="add_medicine"
                            ><i class="fa fa-plus"></i
                          ></a>
                        </div>
                      </div>
                    </div>
                    <div class="mt-5">
                      <router-link
                        to="patient-register-step3"
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
  <!-- /Main Wrapper -->
</template>
<script>
export default {
  data() {
    return {
      sorting1: ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10"],
      sorting2: ["A-", "A+", "B-", "B+", "AB-", "AB+", "O-", "O+"],
      sorting3: ["1", "2"],
      sorting4: ["1", "2"],
      sorting5: ["Select Your Glucose Level", "1", "2"],
      sorting6: ["Kg"],
      sorting7: ["cm", "ft"],
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
