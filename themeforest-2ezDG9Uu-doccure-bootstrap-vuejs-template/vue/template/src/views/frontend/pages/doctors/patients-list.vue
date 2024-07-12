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
            <div class="row row-grid">
              <div
                class="col-md-6 col-lg-4 col-xl-3"
                v-for="item in patientlist"
                :key="item.id"
              >
                <div class="card widget-profile pat-widget-profile">
                  <div class="card-body">
                    <div class="pro-widget-content">
                      <div class="profile-info-widget">
                        <router-link to="patient-profile" class="booking-doc-img">
                          <img
                            :src="require(`@/assets/img/patients/${item.Image}`)"
                            alt="User Image"
                          />
                        </router-link>

                        <div class="profile-det-info">
                          <h3>
                            <router-link to="patient-profile">{{
                              item.name
                            }}</router-link>
                          </h3>

                          <div class="patient-details">
                            <h5><b>Patient ID : </b>{{ item.patientId }}</h5>
                            <h5 class="mb-0">
                              <i class="fas fa-map-marker-alt me-1"></i
                              >{{ item.location }}
                            </h5>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="patient-info">
                      <ul>
                        <li>
                          Phone<span>{{ item.phone }}</span>
                        </li>
                        <li>
                          Age<span>{{ item.age }}</span>
                        </li>
                        <li>
                          Blood Group<span>{{ item.bloodGroup }}</span>
                        </li>
                      </ul>
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
import patientlist from "@/assets/json/doctor/patientlist.json";

export default {
  data() {
    return {
      title: "My Patients",
      text: "Home",
      text1: "My Patients",
      patientlist: patientlist,
    };
  },
};
</script>
