<template>
  <!-- Main Wrapper -->
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb1 :title="title" :text="text" :text1="text1" />
    <!-- Page Content -->
    <div class="content">
      <div class="container">
        <div class="row">
          <doctorsidebar></doctorsidebar>

          <div class="col-md-7 col-lg-8 col-xl-9">
            <div class="row">
              <div class="col-sm-12">
                <div class="card">
                  <div class="card-body">
                    <h4 class="card-title">Schedule Timings</h4>
                    <div class="profile-box">
                      <div class="row">
                        <div class="col-sm-6 col-12 avail-time">
                          <div class="mb-3">
                            <div class="schedule-calendar-col justify-content-start">
                              <form class="d-flex flex-wrap">
                                <span class="input-group-text">Date:</span>
                                <div class="me-3">
                                  <datepicker
                                    v-model="startdate"
                                    type="date"
                                    class="form-control"
                                    :editable="true"
                                    :clearable="false"
                                  />
                                </div>
                                <div class="search-time-mobile">
                                  <input
                                    type="submit"
                                    name="submit"
                                    value="Search"
                                    class="btn btn-primary h-100"
                                  />
                                </div>
                              </form>
                            </div>
                          </div>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col-lg-12">
                          <h3
                            class="h3 text-center book-btn2 mt-3 px-5 py-1 mx-3 rounded"
                          >
                            1<sup>st</sup> Session
                          </h3>
                          <div class="text-center mt-3">
                            <h4 class="h4 mb-2">Start Time</h4>
                            <span class="h4 btn btn-outline-primary"
                              ><b> 09:00 AM</b></span
                            >
                          </div>
                          <div class="token-slot mt-2">
                            <div
                              class="form-check-inline visits me-1"
                              v-for="item in availabletiming"
                              :key="item.id"
                            >
                              <label class="visit-btns">
                                <input
                                  type="checkbox"
                                  class="form-check-input"
                                  data-date="2023-05-21"
                                  data-timezone="Asia/Calcutta"
                                  data-end-time="15:40:00"
                                  name="token[]"
                                  data-session="1"
                                  :value="item.value"
                                />

                                <span
                                  class="visit-rsn"
                                  data-bs-toggle="tooltip"
                                  :title="item.time"
                                  >{{ item.time }}</span
                                >
                              </label>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="text-center">
                      <b-button class="btn btn-primary">Save</b-button>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- /Page Content -->
    <indexfooter></indexfooter>
  </div>
  <!-- /Main Wrapper -->
</template>
<script>
import availabletiming from "@/assets/json/doctor/availabletiming.json";
import { ref } from "vue";
const currentDate = ref(new Date());
export default {
  data() {
    return {
      title: "Available Timings",
      text: "Home",
      text1: "Available Timings",
      availabletiming: availabletiming,
      startdate: currentDate,
    };
  },
};
</script>
