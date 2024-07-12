<template>
  <!-- Doctor Section-->
  <section class="doctor-divison">
    <div class="d-flex">
      <div class="doc-background aos" data-aos="fade-up">
        <h3>ARE YOU A DOCTOR?</h3>
        <p>
          The service allows you to get maximum visibility online and to manage
          appointments and contacts coming from the site, in a simple and fast way.
        </p>
        <router-link to="/booking" class="doc-bok-btn">Book Now</router-link>
      </div>
      <div class="pat-background aos" data-aos="fade-up">
        <h3>ARE YOU A PATIENT?</h3>
        <p>
          The service allows you to get maximum visibility online and to manage
          appointments and contacts coming from the site, in a simple and fast way.
        </p>
        <router-link to="/booking" class="doc-bok-btn">Book Now</router-link>
      </div>
    </div>
  </section>
  <!-- /Doctor Section-->

  <!-- Book Doctors-->
  <section class="book-section">
    <div class="container">
      <div class="section-header-three text-center aos" data-aos="fade-up">
        <h2>Book Our Best Doctor</h2>
        <p class="sub-title">
          Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
          incididunt ut labore et dolore magna aliqua.
        </p>
      </div>
      <div class="row">
        <div
          class="col-lg-3 col-md-6 aos"
          data-aos="fade-up"
          v-for="doctor in indexfourdoctors"
          :key="doctor.id"
        >
          <div class="book-best-doctors">
            <div class="book-header">
              <router-link to="/doctor-profile"
                ><img
                  :src="require(`@/assets/img/doctors/${doctor.imageSrc}`)"
                  :alt="doctor.name"
                  class="img-fluid"
              /></router-link>
              <div class="img-overlay">
                <i class="fas fa-heart"></i>
              </div>
            </div>
            <div class="doctors-body">
              <div class="inner-section">
                <span class="float-start">PSICOLOGIST</span>
                <div class="rating text-end">
                  <i class="fas fa-star filled me-1"></i>
                  <i class="fas fa-star filled me-1"></i>
                  <i class="fas fa-star filled me-1"></i>
                  <i class="fas fa-star filled me-1"></i>
                  <i class="fas fa-star"></i>
                  <span class="d-inline-block average-ratings">3.5</span>
                </div>
                <router-link to="/doctor-profile">
                  <h4>{{ doctor.name }}</h4>
                </router-link>
                <p>MBBS, MD - General Medicine, DNB - Cardiology</p>
              </div>
              <div class="row row-sm loc-details">
                <div class="col-6">
                  <div class="d-flex align-items-center">
                    <a href="javascript:void(0);">
                      <img src="@/assets/img/shapes/map-plus.png" alt="Image" />
                    </a>
                    <a href="javascript:void(0);">
                      <span class="available-info">Location</span>
                      <span class="data-info">Newyork, USA</span>
                    </a>
                  </div>
                </div>
                <div class="col-6">
                  <div class="d-flex align-items-center">
                    <a href="javascript:void(0);">
                      <img src="@/assets/img/shapes/alarm.png" alt="Image" />
                    </a>
                    <a href="javascript:void(0);">
                      <span class="available-info">Available on</span>
                      <span class="data-info">Fri, 22 March</span>
                    </a>
                  </div>
                </div>
                <div class="col-6">
                  <div class="d-flex align-items-center">
                    <a href="javascript:void(0);">
                      <img src="@/assets/img/shapes/consult.png" alt="Image" />
                    </a>
                    <a href="javascript:void(0);">
                      <span class="available-info">Consulting</span>
                      <span class="data-info">500+ Patients</span>
                    </a>
                  </div>
                </div>
                <div class="col-6">
                  <div class="d-flex align-items-center">
                    <a href="javascript:void(0);">
                      <img src="@/assets/img/shapes/exper.png" alt="Image" />
                    </a>
                    <a href="javascript:void(0);">
                      <span class="available-info">EXPERIENCE</span>
                      <span class="data-info">25+ Years</span>
                    </a>
                  </div>
                </div>
              </div>
              <div class="row row-sm align-items-center p-3">
                <div class="col-6">
                  <router-link to="/doctor-profile" class="amt-txt" tabindex="0"
                    >$50 - $100</router-link
                  >
                </div>
                <div class="col-6">
                  <router-link to="/booking" class="btn book-btn" tabindex="0"
                    >Book Now</router-link
                  >
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="view-all-more text-center aos" data-aos="fade-up">
        <router-link to="/doctor-profile" class="btn btn-primary">View More</router-link>
      </div>
    </div>
  </section>
  <!-- /Book Doctors-->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import indexfourdoctors from "@/assets/json/indexfourdoctors.json";
export default {
  data() {
    return {
      indexfourdoctors: indexfourdoctors,
    };
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
