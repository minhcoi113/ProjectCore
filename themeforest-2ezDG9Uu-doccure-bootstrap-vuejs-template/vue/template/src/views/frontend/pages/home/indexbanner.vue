<template>
  <!-- Home Banner -->
  <section class="banner-section">
    <div class="container">
      <div class="row align-items-center">
        <div class="col-lg-6">
          <div class="banner-content aos" data-aos="fade-up">
            <h1>Consult <span>Best Doctors</span> Your Nearby Location.</h1>
            <img
              src="@/assets/img/icons/header-icon.svg"
              class="header-icon"
              alt="header-icon"
            />
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit,</p>
            <router-link to="/booking" class="btn">Start a Consult</router-link>
            <div class="banner-arrow-img">
              <img src="@/assets/img/down-arrow-img.png" class="img-fluid" alt="Image" />
            </div>
          </div>
          <div class="search-box-one aos" data-aos="fade-up">
            <form @submit.prevent="submitForm">
              <div class="search-input search-line">
                <i class="feather-search bficon"></i>
                <div class="form-group mb-0">
                  <input
                    type="text"
                    class="form-control"
                    placeholder="Search doctors, clinics, hospitals, etc"
                  />
                </div>
              </div>
              <div class="search-input search-map-line">
                <i class="feather-map-pin"></i>
                <div class="form-group mb-0">
                  <input type="text" class="form-control" placeholder="Location" />
                  <a class="current-loc-icon current_location" href="javascript:void(0);">
                    <i class="feather-crosshair"></i>
                  </a>
                </div>
              </div>
              <div class="search-input search-calendar-line">
                <i class="feather-calendar"></i>
                <div class="mb-0">
                  <datepicker
                    v-model="startdate"
                    placeholder="Date"
                    class="form-control datetimepicker"
                    :editable="true"
                    :clearable="false"
                  />
                </div>
              </div>
              <div class="form-search-btn">
                <b-button class="btn" type="submit">Search</b-button>
              </div>
            </form>
          </div>
        </div>
        <div class="col-lg-6">
          <div class="banner-img aos" data-aos="fade-up">
            <img src="@/assets/img/banner-img.png" class="img-fluid" alt="Image" />
            <div class="banner-img1">
              <img src="@/assets/img/banner-img1.png" class="img-fluid" alt="Image" />
            </div>
            <div class="banner-img2">
              <img src="@/assets/img/banner-img2.png" class="img-fluid" alt="Image" />
            </div>
            <div class="banner-img3">
              <img src="@/assets/img/banner-img3.png" class="img-fluid" alt="Image" />
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Home Banner -->

  <!-- Specialities Section -->
  <section class="specialities-section-one">
    <div class="container">
      <div class="row">
        <div class="col-md-6 aos" data-aos="fade-up">
          <div class="section-header-one section-header-slider">
            <h2 class="section-title">Specialities</h2>
          </div>
        </div>
        <div class="col-md-6 aos" data-aos="fade-up">
          <div class="owl-nav slide-nav-1 text-end nav-control"></div>
        </div>
      </div>
      <div class="owl-carousel specialities-slider-one owl-theme aos" data-aos="fade-up">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in IndexBanner" :key="item.id">
            <div class="item slide-content-container">
              <div class="specialities-item">
                <div class="specialities-img">
                  <span
                    ><img
                      :src="require(`@/assets/img/specialities/${item.Image}`)"
                      alt="specialities"
                  /></span>
                </div>
                <p>{{ item.Title }}</p>
              </div>
            </div>
          </Slide>
          <template #addons>
            <Navigation />
          </template>
        </Carousel>
      </div>
      <div class="specialities-btn aos" data-aos="fade-up">
        <router-link to="/search" class="btn"> See All Specialities </router-link>
      </div>
    </div>
  </section>
  <!-- /Specialities Section -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import IndexBanner from "@/assets/json/indexbanner.json";
import "vue3-carousel/dist/carousel.css";

import { ref } from "vue";
const currentDate = ref(new Date());
export default {
  data() {
    return {
      startdate: currentDate,
      IndexBanner: IndexBanner,
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
          itemsToShow: 6,
          snapAlign: "start",
        },
      },
    };
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
  methods: {
    submitForm() {
      this.$router.push("/search-2");
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
