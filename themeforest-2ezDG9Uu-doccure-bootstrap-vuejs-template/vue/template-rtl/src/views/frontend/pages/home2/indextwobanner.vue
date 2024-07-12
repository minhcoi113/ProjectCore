<template>
  <!-- Home Banner -->
  <section class="section section-search">
    <div class="container-fluid">
      <div class="banner-wrapper">
        <div class="banner-header text-center aos" data-aos="fade-up">
          <h1>Search Doctor, Make an Appointment</h1>
          <p>Discover the best doctors, clinic & hospital the city nearest to you.</p>
        </div>

        <!-- Search -->
        <div class="search-box">
          <form @submit.prevent="submitForm">
            <div class="form-group search-location aos" data-aos="fade-up">
              <input type="text" class="form-control" placeholder="Search Location" />
              <span class="form-text">Based on your Location</span>
            </div>
            <div class="form-group search-info aos" data-aos="fade-up">
              <input
                type="text"
                class="form-control"
                placeholder="Search Doctors, Clinics, Hospitals, Diseases Etc"
              />
              <span class="form-text">Ex : Dental or Sugar Check up etc</span>
            </div>
            <b-button
              type="submit"
              class="btn btn-primary search-btn mt-0 aos"
              data-aos="fade-up"
            >
              <i class="fas fa-search"></i> <span>Search</span>
            </b-button>
          </form>
        </div>
        <!-- /Search -->
      </div>
    </div>
  </section>
  <!-- /Home Banner -->

  <section class="section home-tile-section">
    <div class="container-fluid">
      <div class="row">
        <div class="col-md-9 m-auto">
          <div class="section-header text-center aos" data-aos="fade-up">
            <h2>What are you looking for?</h2>
          </div>
          <div class="row">
            <div class="col-lg-4 mb-3 aos" data-aos="fade-up">
              <div class="card text-center doctor-book-card">
                <img
                  src="@/assets/img/doctors/doctor-07.jpg"
                  alt="Image"
                  class="img-fluid"
                />
                <div class="doctor-book-card-content tile-card-content-1">
                  <div>
                    <h3 class="card-title mb-0">Visit a Doctor</h3>
                    <router-link
                      to="/search"
                      class="btn book-btn1 px-3 py-2 mt-3"
                      tabindex="0"
                      >Book Now</router-link
                    >
                  </div>
                </div>
              </div>
            </div>
            <div class="col-lg-4 mb-3 aos" data-aos="fade-up">
              <div class="card text-center doctor-book-card">
                <img src="@/assets/img/img-pharmacy1.jpg" alt="Image" class="img-fluid" />
                <div class="doctor-book-card-content tile-card-content-1">
                  <div>
                    <h3 class="card-title mb-0">Find a Pharmacy</h3>
                    <router-link
                      to="/pharmacy-search"
                      class="btn book-btn1 px-3 py-2 mt-3"
                      tabindex="0"
                      >Find Now</router-link
                    >
                  </div>
                </div>
              </div>
            </div>
            <div class="col-lg-4 mb-3 aos" data-aos="fade-up">
              <div class="card text-center doctor-book-card">
                <img src="@/assets/img/lab-image.jpg" alt="Image" class="img-fluid" />
                <div class="doctor-book-card-content tile-card-content-1">
                  <div>
                    <h3 class="card-title mb-0">Find a Lab</h3>
                    <a
                      href="javascript:void(0);"
                      class="btn book-btn1 px-3 py-2 mt-3"
                      tabindex="0"
                      >Coming Soon</a
                    >
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
export default {
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
  submitForm() {
    this.$router.push("/search");
  },
};
</script>
