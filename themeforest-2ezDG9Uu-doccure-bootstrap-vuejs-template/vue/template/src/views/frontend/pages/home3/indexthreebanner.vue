<template>
  <!-- Home Banner -->
  <section class="doctor-search-section">
    <div class="container">
      <div class="row align-items-center">
        <div class="col-lg-6 aos" data-aos="fade-up">
          <div class="doctor-search">
            <div class="banner-header">
              <h2>
                Search Doctor, <br />
                Make an Appointment
              </h2>
            </div>
            <div class="doctor-form">
              <form action="javascript:;" class="doctor-search-form">
                <div class="row">
                  <div class="col-md-12">
                    <div class="form-group">
                      <label class="mb-2">Location</label>
                      <div class="form-custom">
                        <input type="text" class="form-control" value="" />
                        <i class="far fa-compass"></i>
                      </div>
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="form-group">
                      <label class="mb-2">Gender</label>
                      <div class="form-custom">
                        <input type="text" class="form-control" value="" />
                        <i class="far fa-smile"></i>
                      </div>
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="form-group">
                      <label class="mb-2">Department</label>
                      <div class="form-custom">
                        <input type="text" class="form-control" value="" />
                        <i class="fas fa-user-check"></i>
                      </div>
                    </div>
                  </div>
                  <div class="col-md-12">
                    <router-link to="/search" class="btn banner-btn mt-3"
                      >MAKE APPOINTMENT</router-link
                    >
                  </div>
                </div>
              </form>
            </div>
          </div>
        </div>
        <div class="col-lg-6 aos" data-aos="fade-up">
          <img
            src="@/assets/img/doctor-banner.png"
            class="img-fluid dr-img"
            alt="Image"
          />
        </div>
      </div>
    </div>
  </section>
  <!-- /Home Banner -->

  <!-- Clinic Section -->
  <section class="clinics-section">
    <div class="shapes">
      <img src="@/assets/img/shapes/shape-1.png" alt="Image" class="img-fluid shape-1" />
      <img src="@/assets/img/shapes/shape-2.png" alt="Image" class="img-fluid shape-2" />
    </div>
    <div class="container">
      <div class="row">
        <div class="col-md-6 aos" data-aos="fade-up">
          <div class="section-heading">
            <h2>Clinic & Specialities</h2>
            <p>
              Access to expert physicians and surgeons, advanced technologies and
              top-quality surgery facilities right here.
            </p>
          </div>
        </div>
        <div class="col-md-6 text-end aos" data-aos="fade-up">
          <div class="owl-nav slide-nav-1 text-end nav-control"></div>
        </div>
      </div>
      <div class="owl-carousel clinics owl-theme">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in indexThreeBanner" :key="item.id">
            <div class="item">
              <div class="clinic-item">
                <div class="clinics-card">
                  <div class="clinics-img">
                    <img
                      :src="require(`@/assets/img/clinic/${item.Image}`)"
                      alt="Image"
                    />
                  </div>
                  <div class="clinics-info">
                    <img
                      :src="require(`@/assets/img/category/${item.Logo}`)"
                      alt="Image"
                    />
                    <a href="javascript:;"
                      ><span>{{ item.Title }}</span></a
                    >
                  </div>
                </div>
                <div class="clinics-icon">
                  <a href="javascript:;"><i class="fas fa-long-arrow-alt-right"></i></a>
                </div>
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
  <!-- /Clinic Section -->
</template>

<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import indexThreeBanner from "@/assets/json/indexthreebanner.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      indexThreeBanner: indexThreeBanner,
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
          itemsToShow: 3,
          snapAlign: "center",
        },
        1024: {
          itemsToShow: 5.99,
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
