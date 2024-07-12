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
              <div class="col-md-12">
                <div class="card dash-card">
                  <div class="card-body">
                    <div class="row">
                      <div class="col-md-12 col-lg-4">
                        <div class="dash-widget dct-border-rht">
                          <div class="circle-bar circle-bar1">
                            <div class="circle-graph1">
                              <circle-progress :percent="75" />
                              <img
                                src="@/assets/img/icon-01.png"
                                class="img-fluid"
                                alt="patient"
                              />
                            </div>
                          </div>
                          <div class="dash-widget-info">
                            <h6>Total Patient</h6>
                            <h3>1500</h3>
                            <p class="text-muted">Till Today</p>
                          </div>
                        </div>
                      </div>

                      <div class="col-md-12 col-lg-4">
                        <div class="dash-widget dct-border-rht">
                          <div class="circle-bar circle-bar2">
                            <div class="circle-graph2">
                              <circle-progress :percent="65" />
                              <img
                                src="@/assets/img/icon-02.png"
                                class="img-fluid"
                                alt="Patient"
                              />
                            </div>
                          </div>
                          <div class="dash-widget-info">
                            <h6>Today Patient</h6>
                            <h3>160</h3>
                            <p class="text-muted">06, Nov 2023</p>
                          </div>
                        </div>
                      </div>

                      <div class="col-md-12 col-lg-4">
                        <div class="dash-widget">
                          <div class="circle-bar circle-bar3">
                            <div class="circle-graph3">
                              <circle-progress :percent="50" />
                              <img
                                src="@/assets/img/icon-03.png"
                                class="img-fluid"
                                alt="Patient"
                              />
                            </div>
                          </div>
                          <div class="dash-widget-info">
                            <h6>Appoinments</h6>
                            <h3>85</h3>
                            <p class="text-muted">06, Apr 2023</p>
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>

            <div class="row">
              <div class="col-md-12">
                <h4 class="mb-4">Patient Appoinment</h4>
                <div class="appointment-tab">
                  <!-- Appointment Tab -->
                  <ul class="nav nav-tabs nav-tabs-solid nav-tabs-rounded">
                    <li class="nav-item">
                      <a
                        class="nav-link active"
                        href="#upcoming-appointments"
                        data-bs-toggle="tab"
                        >Upcoming</a
                      >
                    </li>
                    <li class="nav-item">
                      <a class="nav-link" href="#today-appointments" data-bs-toggle="tab"
                        >Today</a
                      >
                    </li>
                  </ul>
                  <!-- /Appointment Tab -->

                  <div class="tab-content">
                    <!-- Upcoming Appointment Tab -->
                    <div class="tab-pane show active" id="upcoming-appointments">
                      <div class="card card-table mb-0">
                        <div class="card-body">
                          <div class="table-responsive">
                            <table class="table table-hover table-center mb-0">
                              <thead>
                                <tr></tr>
                                <tr>
                                  <th>Patient Name</th>
                                  <th>Appt Date</th>
                                  <th>Purpose</th>
                                  <th>Type</th>
                                  <th class="text-center">Paid Amount</th>
                                  <th></th>
                                </tr>
                              </thead>
                              <tbody>
                                <tr v-for="item in doctorupcoming" :key="item.id">
                                  <td>
                                    <h2 class="table-avatar">
                                      <router-link
                                        to="patient-profile"
                                        class="avatar avatar-sm me-2"
                                        ><img
                                          class="avatar-img rounded-circle"
                                          :src="
                                            require(`@/assets/img/patients/${item.Image}`)
                                          "
                                          alt="User Image"
                                      /></router-link>
                                      <router-link to="patient-profile"
                                        >{{ item.PatientName }}
                                        <span>{{ item.PatientId }}</span></router-link
                                      >
                                    </h2>
                                  </td>
                                  <td>
                                    {{ item.ApptDate }}
                                    <span class="d-block text-info">{{
                                      item.ApptTime
                                    }}</span>
                                  </td>
                                  <td>{{ item.Purpose }}</td>
                                  <td>{{ item.Type }}</td>
                                  <td class="text-center">{{ item.PaidAmount }}</td>
                                  <td class="text-end">
                                    <div class="table-action">
                                      <a
                                        href="javascript:void(0);"
                                        class="btn btn-sm bg-info-light me-2"
                                      >
                                        <i class="far fa-eye"></i> View
                                      </a>

                                      <a
                                        href="javascript:void(0);"
                                        class="btn btn-sm bg-success-light me-2"
                                      >
                                        <i class="fas fa-check"></i> Accept
                                      </a>
                                      <a
                                        href="javascript:void(0);"
                                        class="btn btn-sm bg-danger-light"
                                      >
                                        <i class="fas fa-times"></i> Cancel
                                      </a>
                                    </div>
                                  </td>
                                </tr>
                              </tbody>
                            </table>
                          </div>
                        </div>
                      </div>
                    </div>
                    <!-- /Upcoming Appointment Tab -->
                    <!-- Today Appointment Tab -->
                    <div class="tab-pane" id="today-appointments">
                      <div class="card card-table mb-0">
                        <div class="card-body">
                          <div class="table-responsive">
                            <table class="table table-hover table-center mb-0">
                              <thead>
                                <tr>
                                  <th>Patient Name</th>
                                  <th>Appt Date</th>
                                  <th>Purpose</th>
                                  <th>Type</th>
                                  <th class="text-center">Paid Amount</th>
                                  <th></th>
                                </tr>
                              </thead>
                              <tbody>
                                <tr v-for="item in doctortoday" :key="item.id">
                                  <td>
                                    <h2 class="table-avatar">
                                      <router-link
                                        to="patient-profile"
                                        class="avatar avatar-sm me-2"
                                        ><img
                                          class="avatar-img rounded-circle"
                                          :src="
                                            require(`@/assets/img/patients/${item.Image}`)
                                          "
                                          alt="User Image"
                                      /></router-link>
                                      <router-link to="patient-profile"
                                        >{{ item.PatientName }}
                                        <span>{{ item.PatientId }}</span></router-link
                                      >
                                    </h2>
                                  </td>
                                  <td>
                                    {{ item.ApptDate
                                    }}<span class="d-block text-info">{{
                                      item.ApptTime
                                    }}</span>
                                  </td>
                                  <td>{{ item.Purpose }}</td>
                                  <td>{{ item.Type }}</td>
                                  <td class="text-center">{{ item.PaidAmount }}</td>
                                  <td class="text-end">
                                    <div class="table-action">
                                      <a
                                        href="javascript:void(0);"
                                        class="btn btn-sm bg-info-light me-2"
                                      >
                                        <i class="far fa-eye"></i> View
                                      </a>

                                      <a
                                        href="javascript:void(0);"
                                        class="btn btn-sm bg-success-light me-2"
                                      >
                                        <i class="fas fa-check"></i> Accept
                                      </a>
                                      <a
                                        href="javascript:void(0);"
                                        class="btn btn-sm bg-danger-light"
                                      >
                                        <i class="fas fa-times"></i> Cancel
                                      </a>
                                    </div>
                                  </td>
                                </tr>
                              </tbody>
                            </table>
                          </div>
                        </div>
                      </div>
                    </div>
                    <!-- /Today Appointment Tab -->
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- /Page Content -->
    <indexfooter />
  </div>
  <!-- /Main Wrapper -->
</template>
<script>
import doctorupcoming from "@/assets/json/doctor/doctorupcoming.json";
import doctortoday from "@/assets/json/doctor/doctortoday.json";

import CircleProgress from "vue3-circle-progress";
import "vue3-circle-progress/dist/circle-progress.css";
import { ref } from "vue";
export default {
  components: {
    CircleProgress,
  },
  data() {
    return {
      title: "Dashboard",
      text: "Home",
      text1: "Dashboard",
      doctorupcoming: doctorupcoming,
      doctortoday: doctortoday,
    };
  },
  mounted() {
    const percent = ref(75);
    setInterval(() => {
      if (percent.value === 25) {
        percent.value = 75;
      } else {
        percent.value = 25;
      }
    }, 1000);
  },
  name: "doctor-dashboard",
};
</script>
