<template>
  <div class="main-wrapper">
    <adminheader></adminheader>
    <adminsidebar></adminsidebar>

    <!-- Page Wrapper -->
    <div class="page-wrapper">
      <div class="content container-fluid">
        <adminbreadcrumb2 :title="title" :text="text" />

        <div class="row">
          <div class="col-xl-3 col-sm-6 col-12">
            <div class="card">
              <div class="card-body">
                <div class="dash-widget-header">
                  <span class="dash-widget-icon text-primary border-primary">
                    <i class="fe fe-users"></i>
                  </span>
                  <div class="dash-count">
                    <h3>168</h3>
                  </div>
                </div>
                <div class="dash-widget-info">
                  <h6 class="text-muted">Doctors</h6>
                  <div class="progress progress-sm">
                    <div class="progress-bar bg-primary w-50"></div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="col-xl-3 col-sm-6 col-12">
            <div class="card">
              <div class="card-body">
                <div class="dash-widget-header">
                  <span class="dash-widget-icon text-success">
                    <i class="fe fe-credit-card"></i>
                  </span>
                  <div class="dash-count">
                    <h3>487</h3>
                  </div>
                </div>
                <div class="dash-widget-info">
                  <h6 class="text-muted">Patients</h6>
                  <div class="progress progress-sm">
                    <div class="progress-bar bg-success w-50"></div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="col-xl-3 col-sm-6 col-12">
            <div class="card">
              <div class="card-body">
                <div class="dash-widget-header">
                  <span class="dash-widget-icon text-danger border-danger">
                    <i class="fe fe-money"></i>
                  </span>
                  <div class="dash-count">
                    <h3>485</h3>
                  </div>
                </div>
                <div class="dash-widget-info">
                  <h6 class="text-muted">Appointment</h6>
                  <div class="progress progress-sm">
                    <div class="progress-bar bg-danger w-50"></div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="col-xl-3 col-sm-6 col-12">
            <div class="card">
              <div class="card-body">
                <div class="dash-widget-header">
                  <span class="dash-widget-icon text-warning border-warning">
                    <i class="fe fe-folder"></i>
                  </span>
                  <div class="dash-count">
                    <h3>$62523</h3>
                  </div>
                </div>
                <div class="dash-widget-info">
                  <h6 class="text-muted">Revenue</h6>
                  <div class="progress progress-sm">
                    <div class="progress-bar bg-warning w-50"></div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-md-12 col-lg-6">
            <!-- Sales Chart -->
            <div class="card card-chart">
              <div class="card-header">
                <h4 class="card-title">Revenue</h4>
              </div>
              <div class="card-body">
                <apexchart
                  type="area"
                  height="350"
                  :options="splineAreaChart.slinearea"
                  :series="splineAreaChart.series"
                ></apexchart>
              </div>
            </div>
            <!-- /Sales Chart -->
          </div>
          <div class="col-md-12 col-lg-6">
            <!-- Invoice Chart -->
            <div class="card card-chart">
              <div class="card-header">
                <h4 class="card-title">Status</h4>
              </div>
              <div class="card-body">
                <apexchart
                  type="line"
                  height="350"
                  :options="splineChart.slineline"
                  :series="splineChart.series"
                ></apexchart>
              </div>
            </div>
            <!-- /Invoice Chart -->
          </div>
        </div>
        <div class="row">
          <div class="col-md-6 d-flex">
            <!-- Recent Orders -->
            <div class="card card-table flex-fill">
              <div class="card-header">
                <h4 class="card-title">Doctors List</h4>
              </div>
              <div class="card-body">
                <div class="table-responsive">
                  <table class="table table-hover table-center mb-0">
                    <thead>
                      <tr>
                        <th>Doctor Name</th>
                        <th>Speciality</th>
                        <th>Earned</th>
                        <th>Reviews</th>
                      </tr>
                    </thead>
                    <tbody>
                      <tr v-for="item in doctorlist" :key="item.id">
                        <td>
                          <h2 class="table-avatar">
                            <router-link to="/admin/profile" class="avatar avatar-sm me-2"
                              ><img
                                class="avatar-img rounded-circle"
                                :src="
                                  require(`@/assets/admin/img/doctors/${item.Image}`)
                                "
                            /></router-link>
                            <router-link to="/admin/profile">{{
                              item.DoctorName
                            }}</router-link>
                          </h2>
                        </td>
                        <td>{{ item.Speciality }}</td>
                        <td>{{ item.Earned }}</td>
                        <td>
                          <i class="fe fe-star text-warning me-1"></i>
                          <i class="fe fe-star text-warning me-1"></i>
                          <i class="fe fe-star text-warning me-1"></i>
                          <i class="fe fe-star text-warning me-1"></i>
                          <i class="fe fe-star-o text-secondary"></i>
                        </td>
                      </tr>
                    </tbody>
                  </table>
                </div>
              </div>
            </div>
            <!-- /Recent Orders -->
          </div>
          <div class="col-md-6 d-flex">
            <!-- Feed Activity -->
            <div class="card card-table flex-fill">
              <div class="card-header">
                <h4 class="card-title">Patients List</h4>
              </div>
              <div class="card-body">
                <div class="table-responsive">
                  <table class="table table-hover table-center mb-0">
                    <thead>
                      <tr>
                        <th>Patient Name</th>
                        <th>Phone</th>
                        <th>Last Visit</th>
                        <th>Paid</th>
                      </tr>
                    </thead>
                    <tbody>
                      <tr v-for="item in patientlist" :key="item.id">
                        <td>
                          <h2 class="table-avatar">
                            <router-link to="/admin/profile" class="avatar avatar-sm me-2"
                              ><img
                                class="avatar-img rounded-circle"
                                :src="
                                  require(`@/assets/admin/img/patients/${item.PatientImg}`)
                                "
                                alt="User Image"
                            /></router-link>
                            <router-link to="/admin/profile"
                              >{{ item.PatientName }}
                            </router-link>
                          </h2>
                        </td>
                        <td>{{ item.Phone }}</td>
                        <td>{{ item.LastVisit }}</td>
                        <td class="text-end">{{ item.Paid }}</td>
                      </tr>
                    </tbody>
                  </table>
                </div>
              </div>
            </div>
            <!-- /Feed Activity -->
          </div>
        </div>
        <div class="row">
          <div class="col-md-12">
            <!-- Recent Orders -->
            <div class="card card-table">
              <div class="card-header">
                <h4 class="card-title">Appointment List</h4>
              </div>
              <div class="card-body">
                <div class="table-responsive">
                  <table class="table table-hover table-center mb-0">
                    <thead>
                      <tr>
                        <th>Doctor Name</th>
                        <th>Speciality</th>
                        <th>Patient Name</th>
                        <th>Apointment Time</th>
                        <th>Status</th>
                        <th class="text-end">Amount</th>
                      </tr>
                    </thead>
                    <tbody>
                      <tr v-for="item in appointmentlist" :key="item.id">
                        <td>
                          <h2 class="table-avatar">
                            <router-link to="/admin/profile" class="avatar avatar-sm me-2"
                              ><img
                                class="avatar-img rounded-circle"
                                :src="
                                  require(`@/assets/admin/img/doctors/${item.DoctorImg}`)
                                "
                                alt="User Image"
                            /></router-link>
                            <router-link to="/admin/profile">{{
                              item.DoctorName
                            }}</router-link>
                          </h2>
                        </td>
                        <td>{{ item.Speciality }}</td>
                        <td>
                          <h2 class="table-avatar">
                            <router-link to="/admin/profile" class="avatar avatar-sm me-2"
                              ><img
                                class="avatar-img rounded-circle"
                                :src="
                                  require(`@/assets/admin/img/patients/${item.PatientImg}`)
                                "
                                alt="User Image"
                            /></router-link>
                            <router-link to="/admin/profile"
                              >{{ item.PatientName }}
                            </router-link>
                          </h2>
                        </td>
                        <td>
                          {{ item.Appointment }}
                          <span class="text-primary d-block">{{ item.Time }}</span>
                        </td>
                        <td>
                          <div class="status-toggle">
                            <input
                              type="checkbox"
                              :id="item.IdName"
                              class="check"
                              checked
                            />
                            <label :for="item.IdName" class="checktoggle">checkbox</label>
                          </div>
                        </td>
                        <td class="text-end">{{ item.Amount }}</td>
                      </tr>
                    </tbody>
                  </table>
                </div>
              </div>
            </div>
            <!-- /Recent Orders -->
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { splineAreaChart, splineChart } from "./data";
import appointmentlist from "@/assets/admin/json/dashboard/appointmentlist.json";
import patientlist from "@/assets/admin/json/dashboard/patientlist.json";
import doctorlist from "@/assets/admin/json/dashboard/doctorlist.json";

export default {
  data() {
    return {
      title: "Welcome Admin!",
      text: "Dashboard",
      splineChart: splineChart,
      splineAreaChart: splineAreaChart,
      appointmentlist: appointmentlist,
      patientlist: patientlist,
      doctorlist: doctorlist,
    };
  },
};
</script>
