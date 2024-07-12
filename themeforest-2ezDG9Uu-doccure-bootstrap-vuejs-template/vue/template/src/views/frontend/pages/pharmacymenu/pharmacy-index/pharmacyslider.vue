<template>
  <!-- Slider -->
  <section class="section full-slide-home">
    <div>
      <div class="slick-wrapper">
        <div class="slider-1">
          <!--slide-->
          <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
            <Slide v-for="item in PharmacySlider" :key="item.id">
              <div class="col-12 d-flex section full-slide-home-demo">
                <div class="col-12 col-lg-6">
                  <div class="slide-image">
                    <span class="text-secondary text-uppercase d-block mb-3"
                      >Introducing Prime Doctors</span
                    >
                    <h2 class="mb-3">
                      Hassle-free appoinments <br />
                      with Prime Doctors
                    </h2>
                    <ul class="list-inline slide-ul mb-3">
                      <li class="list-inline-item">Reasonable wait time</li>
                      <li class="list-inline-item">Fixed Consultation Fee</li>
                      <li class="list-inline-item">
                        Consulation with the preferred doctor
                      </li>
                    </ul>
                    <div class="d-inline-block">
                      <router-link to="/booking" class="btn book-btn1" tabindex="0"
                        >Book Now</router-link
                      >
                    </div>
                  </div>
                </div>
                <div class="col-6 col-12 col-lg-6 d-flex justify-content-center">
                  <img :src="require(`@/assets/img/${item.Image}`)" alt="doctors-image" />
                </div>
              </div>
            </Slide>
            <template #addons>
              <Navigation />
            </template>
          </Carousel>
          <!--/slide-->
        </div>
      </div>
    </div>
  </section>
  <!-- Slider -->

  <!-- Home Banner -->
  <div class="section-search-pharmacy">
    <div class="container-fluid">
      <div class="row justify-content-center">
        <div class="col-md-10">
          <div class="banner-wrapper2">
            <div class="search-box1">
              <form @submit.prevent="submitForm">
                <p class="mb-0 me-3">Find a Pharmacy</p>
                <div class="search-location1 postion-relative">
                  <input
                    type="text"
                    class="form-control"
                    placeholder="Enter your location / Pincode"
                    style="padding-left: 15px"
                  />
                  <span class="search-detect">Detect</span>
                </div>

                <b-button type="submit" class="btn btn-primary search-btn"
                  ><i class="fas fa-search"></i> <span>Search</span></b-button
                >
              </form>
            </div>
            <!-- /Search -->
          </div>
        </div>
      </div>
    </div>
  </div>
  <!-- /Home Banner -->

  <section class="section home-tile-section">
    <div class="container-fluid">
      <div class="row">
        <div class="col-md-9 m-auto">
          <div class="section-header text-center">
            <h2>What are you looking for?</h2>
            <p class="sub-title">
              Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod
              tempor incididunt ut labore et dolore magna aliqua.
            </p>
          </div>
          <div class="row">
            <div class="col-lg-4 mb-3">
              <div class="card text-center doctor-book-card">
                <img
                  src="@/assets/img/doctors/doctor-07.jpg"
                  alt="doctor-image"
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
            <div class="col-lg-4 mb-3">
              <div class="card text-center doctor-book-card">
                <img
                  src="@/assets/img/img-pharmacy1.jpg"
                  alt="pharmacy image"
                  class="img-fluid"
                />
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
            <div class="col-lg-4 mb-3">
              <div class="card text-center doctor-book-card">
                <img src="@/assets/img/lab-image.jpg" alt="lab-image" class="img-fluid" />
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
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import PharmacySlider from "@/assets/json/pharmacyslider.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      PharmacySlider: PharmacySlider,
      settings: {
        itemsToShow: 1,
        snapAlign: "center",
      },
      breakpoints: {
        575: {
          itemsToShow: 1,
          snapAlign: "center",
        },
        767: {
          itemsToShow: 1,
          snapAlign: "center",
        },
        991: {
          itemsToShow: 1,
          snapAlign: "center",
        },
        1024: {
          itemsToShow: 1,
          snapAlign: "start",
        },
      },
    };
  },
  methods: {
    submitForm() {
      this.$router.push("/pharmacy-search");
    },
  },
  components: {
    Carousel,
    Slide,
    Pagination,
    Navigation,
  },
};
</script>
