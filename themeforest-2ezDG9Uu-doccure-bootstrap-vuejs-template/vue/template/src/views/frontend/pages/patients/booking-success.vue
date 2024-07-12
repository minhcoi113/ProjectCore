<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="content success-page-cont">
      <div class="container">
        <div class="row justify-content-center">
          <div class="col-lg-6">
            <!-- Success Card -->
            <div class="card success-card">
              <div class="card-body">
                <div class="success-cont">
                  <i class="fas fa-check"></i>
                  <h3>Appointment booked Successfully!</h3>
                  <p>
                    Appointment booked with <strong>Dr. Darren Elder</strong><br />
                    on <strong>12 Jun 2023 5:00PM to 6:00PM</strong>
                  </p>
                  <router-link to="invoice-view" class="btn btn-primary view-inv-btn"
                    >View Invoice</router-link
                  >
                </div>
              </div>
            </div>
            <!-- /Success Card -->
          </div>
        </div>
      </div>
    </div>
    <indexfooter />
  </div>
</template>

<script>
export default {
  data() {
    return {
      title: "Booking",
      text: "Home",
      text1: "Booking",
    };
  },
};
</script>
