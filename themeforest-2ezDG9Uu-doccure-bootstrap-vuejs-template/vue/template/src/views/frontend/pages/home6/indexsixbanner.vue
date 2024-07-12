<template>
  <!-- Home Banner -->
  <section class="doctor-search-section doctor-search-eleven">
    <div class="container">
      <div class="row align-items-center">
        <div class="col-lg-6 aos" data-aos="fade-up">
          <div class="banner-header">
            <p>Take Eye Care Solution from Experts</p>
            <h1>Eye Care & Holistics The experts</h1>
            <router-link to="/booking" class="btn btn-light-blue"
              >Make an Appointment</router-link
            >
          </div>
          <div class="banner-users">
            <h6>
              <img src="@/assets/img/icons/star.svg" alt="img" />4.8 Well Experienced
            </h6>
            <ul>
              <li>
                <img src="@/assets/img/doctors/doctor-13.jpg" alt="img" class="me-1" />
              </li>
              <li>
                <img src="@/assets/img/doctors/doctor-14.jpg" alt="img" class="me-1" />
              </li>
              <li>
                <img src="@/assets/img/doctors/doctor-15.jpg" alt="img" class="me-1" />
              </li>
              <li>
                <img src="@/assets/img/doctors/doctor-16.jpg" alt="img" class="me-1" />
              </li>
              <li>
                <img src="@/assets/img/doctors/doctor-17.jpg" alt="img" class="me-1" />
              </li>
              <li>
                <img src="@/assets/img/doctors/doctor-18.jpg" alt="img" class="me-1" />
              </li>
            </ul>
          </div>
        </div>
        <div class="col-lg-6 aos" data-aos="fade-up">
          <img
            src="@/assets/img/banner-11.png"
            class="img-fluid dr-img"
            alt="eye-doctor"
          />
        </div>
      </div>
    </div>
    <div class="ban-bg">
      <img
        src="@/assets/img/bg/ban-bg-01.png"
        class="img-fluid bg-01"
        alt="design-image"
      />
      <img
        src="@/assets/img/bg/ban-bg-02.png"
        class="img-fluid bg-02"
        alt="design-image"
      />
      <img src="@/assets/img/eye.png" class="img-fluid bg-03" alt="eye-image" />
    </div>
  </section>
  <!-- /Home Banner -->

  <!-- Specialties Section -->
  <section class="special-section">
    <div class="ban-bg">
      <img
        src="@/assets/img/icons/eye-icon-01.svg"
        alt="eye-icon"
        class="img-fluid bg-04"
      />
    </div>
    <div class="container">
      <div class="row">
        <div class="col-md-12 aos" data-aos="fade-up">
          <div class="section-heading sec-heading-eye text-center">
            <img src="@/assets/img/icons/eye-icon.svg" alt="eye-icon" class="img-fluid" />
            <h2><span>Our</span> Specialties</h2>
            <p>The Great Place Of Eyecare Hospital Center</p>
          </div>
        </div>
      </div>
      <div class="owl-carousel special owl-them aos" data-aos="fade-up">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in indexSixBanner" :key="item.id">
            <div class="item">
              <div class="special-item">
                <div class="special-img">
                  <router-link to="/consultation"
                    ><img
                      :src="require(`@/assets/img/clinic/${item.Image}`)"
                      alt="eye-clinic"
                      class="img-fluid"
                  /></router-link>
                </div>
                <div class="special-icon">
                  <router-link to="/consultation"
                    ><i class="fa-solid fa-circle-chevron-right"></i
                  ></router-link>
                </div>
                <h6>
                  <router-link to="/consultation">{{ item.Title }}</router-link>
                </h6>
              </div>
            </div>
          </Slide>
          <template #addons>
            <Navigation />
          </template>
        </Carousel>
      </div>
    </div>
  </section>
  <!-- /Specialties Section -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import indexSixBanner from "@/assets/json/indexsixbanner.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      indexSixBanner: indexSixBanner,
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
          itemsToShow: 3,
          snapAlign: "center",
        },
        991: {
          itemsToShow: 3,
          snapAlign: "center",
        },
        1024: {
          itemsToShow: 4,
          snapAlign: "start",
        },
      },
    };
  },
  components: {
    Carousel,
    Slide,
    Pagination,
    Navigation,
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
