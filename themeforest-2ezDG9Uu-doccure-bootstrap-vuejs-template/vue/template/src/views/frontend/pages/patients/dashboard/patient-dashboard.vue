<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />
    <div class="page-wrapper">
      <div class="content">
        <div class="container">
          <div class="row">
            <!-- Profile Sidebar -->
            <div class="col-md-5 col-lg-4 col-xl-3 theiaStickySidebar">
              <div class="stickysidebar">
                <profilesidebar></profilesidebar>
              </div>
            </div>
            <!-- / Profile Sidebar -->
            <div class="col-md-7 col-lg-8 col-xl-9">
              <div class="row">
                <div
                  class="col-12 col-md-6 col-lg-4 col-xl-3 patient-dashboard-top"
                  v-for="item in patient"
                  :key="item.id"
                >
                  <div class="card">
                    <div class="card-body text-center">
                      <div class="mb-3">
                        <img
                          :src="require(`@/assets/img/specialities/${item.Image}`)"
                          alt="heart-image"
                          width="55"
                        />
                      </div>
                      <h5>{{ item.Title }}</h5>
                      <h6>
                        {{ item.Number }} <sub>{{ item.text }}</sub>
                      </h6>
                    </div>
                  </div>
                </div>
              </div>
              <div class="row patient-graph-col">
                <div class="col-12">
                  <div class="card">
                    <div class="card-header">
                      <h4 class="card-title">Graph Status</h4>
                    </div>
                    <div class="card-body pt-2 pb-2 mt-1 mb-1">
                      <div class="row">
                        <div
                          class="col-12 col-md-6 col-lg-4 col-xl-3 patient-graph-box"
                          v-for="item in graphstatus"
                          :key="item.id"
                        >
                          <a
                            href="javascript:;"
                            :class="item.color"
                            data-bs-toggle="modal"
                            :data-bs-target="item.target"
                          >
                            <div>
                              <h4>{{ item.status }}</h4>
                            </div>
                            <div class="graph-img">
                              <img
                                :src="require(`@/assets/img/shapes/${item.Image}`)"
                                alt="shapes-icon"
                              />
                            </div>
                            <div class="graph-status-result mt-3">
                              <span class="graph-update-date">{{ item.text }}</span>
                            </div>
                          </a>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>

              <div class="card">
                <div class="card-body pt-0">
                  <!-- Tab Menu -->
                  <nav class="user-tabs mb-4">
                    <ul class="nav nav-tabs nav-tabs-bottom nav-justified">
                      <li class="nav-item">
                        <a
                          class="nav-link active"
                          href="#pat_appointments"
                          data-bs-toggle="tab"
                          >Appointments</a
                        >
                      </li>
                      <li class="nav-item">
                        <a class="nav-link" href="#pat_prescriptions" data-bs-toggle="tab"
                          >Prescriptions</a
                        >
                      </li>
                      <li class="nav-item">
                        <a
                          class="nav-link"
                          href="#pat_medical_records"
                          data-bs-toggle="tab"
                          ><span class="med-records">Medical Records</span></a
                        >
                      </li>
                      <li class="nav-item">
                        <a class="nav-link" href="#pat_billing" data-bs-toggle="tab"
                          >Billing</a
                        >
                      </li>
                    </ul>
                  </nav>
                  <!-- /Tab Menu -->

                  <!-- Tab Content -->
                  <div class="tab-content pt-0">
                    <!-- Appointment Tab -->
                    <patientappointment></patientappointment>
                    <!-- /Appointment Tab -->

                    <!-- Prescription Tab -->
                    <prescription></prescription>
                    <!-- /Prescription Tab -->

                    <!-- Medical Records Tab -->
                    <medicalrecords></medicalrecords>
                    <!-- /Medical Records Tab -->

                    <!-- Billing Tab -->
                    <billing></billing>
                    <!-- /Billing Tab -->
                  </div>
                  <!-- Tab Content -->
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <indexfooter></indexfooter>
    </div>
  </div>
  <graphone></graphone>
  <graphtwo></graphtwo>
  <graphthree></graphthree>
  <graphfour></graphfour>
</template>

<script>
import graphstatus from "@/assets/json/patientdashboard/graphstatus.json";
import patient from "@/assets/json/patientdashboard/patient.json";
export default {
  data() {
    return {
      title: "Dashboard",
      text: "Home",
      text1: "Dashboard",
      graphstatus: graphstatus,
      patient: patient,
    };
  },
};
</script>
