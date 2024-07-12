<template>
  <!-- Patient About us -->
  <section class="about-us-section-fifteen">
    <div class="container">
      <div class="row">
        <div class="col-md-12">
          <div class="section-header-fifteen text-center">
            <h2>Our <span>Patients Says</span></h2>
            <p>What our Patients say about us</p>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-lg-6">
          <div class="aboutus-img-main">
            <img src="@/assets/img/aboutus-fift-1.jpg" alt="image" class="img-fluid" />
            <div class="aboutus-img-one">
              <img src="@/assets/img/icons/aboutus-icon1.svg" alt="Icon" />
            </div>
          </div>
        </div>
        <div class="col-lg-6 position-relative">
          <div class="swiper-container vertical-slider">
            <div class="swiper-wrapper" style="height: 406.8px">
              <div class="swiper-slide" v-for="item in indextenpatient" :key="item.id">
                <div class="aboutus-fifteen-main">
                  <div class="aboutus-profile-left">
                    <div class="aboutus-image">
                      <img
                        :src="require(`@/assets/img/clients/${item.imageSrc}`)"
                        alt="Client"
                        class="img-fluid"
                      />
                    </div>
                    <div class="aboutus-contents">
                      <h6>{{ item.name }}</h6>
                      <span>{{ item.location }}</span>
                    </div>
                  </div>
                  <p>{{ item.description }}</p>
                </div>
              </div>
            </div>
            <div class="swiper-pagination"></div>
            <div class="swiper-button-next"></div>
            <div class="swiper-button-prev"></div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Patient About us -->
  <!-- Frequent section -->
  <section class="frequently-section-fifteen">
    <div class="container">
      <div class="row">
        <div class="col-md-12">
          <div class="section-header-fifteen text-center">
            <h2>Frequently <span>Asked Questions</span></h2>
            <p>What our clients say about us</p>
          </div>
        </div>
      </div>
      <div class="owl-carousel frequent-slider-fifteen owl-theme">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in indextenfrequently" :key="item.id">
            <div class="items-fift slide-content-container text-start">
              <a href="javascript:">{{ item.title }}</a>
              <p>{{ item.description }}</p>
              <router-link to="faq" class="line-arrow"
                >Read More<i class="feather-arrow-right-circle ms-2"></i
              ></router-link>
            </div>
          </Slide>
          <template #addons>
            <div class="owl-nav">
              <Navigation />
            </div>
            <div class="owl-dots">
              <Pagination />
            </div>
          </template>
        </Carousel>
      </div>
    </div>
  </section>
  <!-- /Frequent section -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import Swiper from "swiper";
import "swiper/css/swiper.css";
import indextenpatient from "@/assets/json/indextenpatient.json";
import indextenfrequently from "@/assets/json/indextenfrequently.json";
import { Carousel, Navigation, Slide, Pagination } from "vue3-carousel";
import "vue3-carousel/dist/carousel.css";
export default {
  components: {
    Carousel,
    Slide,
    Navigation,
    Pagination,
  },
  data() {
    return {
      indextenpatient: indextenpatient,
      indextenfrequently: indextenfrequently,
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
        // 700px and up
        991: {
          itemsToShow: 1,
          snapAlign: "center",
        },
        // 1024 and up
        1024: {
          itemsToShow: 2.99,
          snapAlign: "start",
        },
      },
    };
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
    const swiper = new Swiper(".vertical-slider", {
      loop: true,
      direction: "vertical",
      slidesPerView: 3,
      pagination: {
        el: ".swiper-pagination",
        clickable: true,
      },
      navigation: {
        nextEl: ".swiper-button-next",
        prevEl: ".swiper-button-prev",
      },
    });
  },
};
</script>
