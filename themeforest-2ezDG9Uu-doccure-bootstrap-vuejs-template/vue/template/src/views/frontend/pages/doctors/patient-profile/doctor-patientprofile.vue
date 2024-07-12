<template>
  <!-- Main Wrapper -->
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb1 :title="title" :text="text" :text1="text1" />

    <!-- Page Content -->
    <div class="content">
      <div class="container">
        <div class="row">
          <div class="col-md-5 col-lg-4 col-xl-3 theiaStickySidebar dct-dashbd-lft">
            <div class="stickysidebar">
              <profilewidget />

              <!-- Last Booking -->
              <div class="card">
                <div class="card-header">
                  <h4 class="card-title">Last Booking</h4>
                </div>
                <ul class="list-group list-group-flush">
                  <li class="list-group-item">
                    <div class="notify-block align-items-center d-flex">
                      <div class="me-3 flex-shrink-0">
                        <img
                          alt="Image placeholder"
                          src="@/assets/img/doctors/doctor-thumb-02.jpg"
                          class="avatar rounded-circle"
                        />
                      </div>
                      <div class="media-body flex-grow-1">
                        <h5 class="d-block mb-0">Dr. Darren Elder</h5>
                        <span class="d-block text-sm text-muted">Dentist</span>
                        <span class="d-block text-sm text-muted"
                          >14 Nov 2023 5.00 PM</span
                        >
                      </div>
                    </div>
                  </li>
                  <li class="list-group-item">
                    <div class="notify-block align-items-center d-flex">
                      <div class="me-3 flex-shrink-0">
                        <img
                          alt="Image placeholder"
                          src="@/assets/img/doctors/doctor-thumb-02.jpg"
                          class="avatar rounded-circle"
                        />
                      </div>
                      <div class="media-body flex-grow-1">
                        <h5 class="d-block mb-0">Dr. Darren Elder</h5>
                        <span class="d-block text-sm text-muted">Dentist</span>
                        <span class="d-block text-sm text-muted"
                          >12 Nov 2023 11.00 AM</span
                        >
                      </div>
                    </div>
                  </li>
                </ul>
              </div>
              <!-- /Last Booking -->
            </div>
          </div>

          <div class="col-md-7 col-lg-8 col-xl-9 dct-appoinment">
            <div class="card">
              <div class="card-body pt-0">
                <div class="user-tabs">
                  <ul class="nav nav-tabs nav-tabs-bottom nav-justified flex-wrap">
                    <li class="nav-item">
                      <a
                        class="nav-link active"
                        href="#pat_appointments"
                        data-bs-toggle="tab"
                        >Appointments</a
                      >
                    </li>
                    <li class="nav-item">
                      <a class="nav-link" href="#pres" data-bs-toggle="tab"
                        ><span>Prescription</span></a
                      >
                    </li>
                    <li class="nav-item">
                      <a class="nav-link" href="#medical" data-bs-toggle="tab"
                        ><span class="med-records">Medical Records</span></a
                      >
                    </li>
                    <li class="nav-item">
                      <a class="nav-link" href="#billing" data-bs-toggle="tab"
                        ><span>Billing</span></a
                      >
                    </li>
                  </ul>
                </div>
                <div class="tab-content">
                  <!-- Appointment Tab -->
                  <dappointment></dappointment>
                  <!-- /Appointment Tab -->

                  <!-- Prescription Tab -->
                  <dprescription></dprescription>
                  <!-- /Prescription Tab -->

                  <!-- Medical Records Tab -->
                  <dmedicalrecords></dmedicalrecords>
                  <!-- /Medical Records Tab -->

                  <!-- Billing Tab -->
                  <dbilling></dbilling>
                  <!-- Billing Tab -->
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
  <div class="modal fade custom-modal" id="add_medical_records">
    <div class="modal-dialog modal-dialog-centered modal-lg" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h3 class="modal-title">Medical Records</h3>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <form>
          <div class="modal-body">
            <div class="mb-3">
              <label class="mb-2">Date</label>
              <datepicker
                v-model="startdate"
                class="form-control datetimepicker"
                placeholder="2023-05-21"
                :editable="true"
                :clearable="false"
              />
            </div>
            <div class="mb-3">
              <label class="mb-2">Description ( Optional )</label>
              <textarea class="form-control"></textarea>
            </div>
            <div class="mb-3">
              <label class="mb-2">Upload File</label>
              <input type="file" class="form-control" />
            </div>
            <div class="submit-section text-center">
              <b-button type="submit" class="btn btn-primary submit-btn">Submit</b-button>
              <b-button
                type="button"
                class="btn btn-secondary submit-btn"
                data-bs-dismiss="modal"
              >
                Cancel
              </b-button>
            </div>
          </div>
        </form>
      </div>
    </div>
  </div>
</template>
<script>
import { ref } from "vue";
const currentDate = ref(new Date());
export default {
  data() {
    return {
      title: "Profile",
      text: "Home",
      text1: "Profile",
      startdate: currentDate,
    };
  },
};
</script>
