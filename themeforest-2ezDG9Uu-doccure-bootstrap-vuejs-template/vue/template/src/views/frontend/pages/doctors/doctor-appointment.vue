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
            <div class="appointments">
              <!-- Appointment List -->
              <div class="appointment-list" v-for="item in appointment" :key="item.id">
                <div class="profile-info-widget">
                  <router-link to="patient-profile" class="booking-doc-img">
                    <img
                      :src="require(`@/assets/img/patients/${item.Image}`)"
                      alt="User Image"
                    />
                  </router-link>
                  <div class="profile-det-info">
                    <h3>
                      <router-link to="patient-profile">{{ item.name }}</router-link>
                    </h3>
                    <div class="patient-details">
                      <h5><i class="far fa-clock me-1"></i>{{ item.dateTime }}</h5>
                      <h5><i class="fas fa-map-marker-alt"></i> {{ item.location }}</h5>
                      <h5><i class="fas fa-envelope me-1"></i>{{ item.email }}</h5>
                      <h5 class="mb-0">
                        <i class="fas fa-phone me-1"></i>{{ item.phone }}
                      </h5>
                    </div>
                  </div>
                </div>
                <div class="appointment-action">
                  <a
                    href="javascript:void(0)"
                    class="btn btn-sm bg-info-light"
                    data-bs-toggle="modal"
                    data-bs-target="#appt_details"
                  >
                    <i class="far fa-eye"></i> View
                  </a>
                  <a href="javascript:void(0);" class="btn btn-sm bg-success-light">
                    <i class="fas fa-check"></i> Accept
                  </a>
                  <a href="javascript:void(0);" class="btn btn-sm bg-danger-light">
                    <i class="fas fa-times"></i> Cancel
                  </a>
                </div>
              </div>
              <!-- /Appointment List -->
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- /Page Content -->
  </div>
  <!-- /Main Wrapper -->
  <!-- Appointment Details Modal -->
  <div class="modal fade custom-modal" id="appt_details">
    <div class="modal-dialog modal-dialog-centered">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Appointment Details</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <ul class="info-details">
            <li>
              <div class="details-header">
                <div class="row">
                  <div class="col-md-6">
                    <span class="title">#APT0001</span>
                    <span class="text">21 Oct 2023 10:00 AM</span>
                  </div>
                  <div class="col-md-6">
                    <div class="text-end">
                      <b-button
                        type="button"
                        class="btn bg-success-light btn-sm"
                        id="topup_status"
                      >
                        Completed
                      </b-button>
                    </div>
                  </div>
                </div>
              </div>
            </li>
            <li>
              <span class="title">Status:</span>
              <span class="text">Completed</span>
            </li>
            <li>
              <span class="title">Confirm Date:</span>
              <span class="text">29 Jun 2023</span>
            </li>
            <li>
              <span class="title">Paid Amount</span>
              <span class="text">$450</span>
            </li>
          </ul>
        </div>
      </div>
    </div>
  </div>
  <!-- /Appointment Details Modal -->
  <indexfooter />
</template>

<script>
import appointment from "@/assets/json/doctor/appointment.json";

export default {
  data() {
    return {
      title: "Appointments",
      text: "Home",
      text1: "Appointments",
      appointment: appointment,
    };
  },
  name: "appointments",
};
</script>
