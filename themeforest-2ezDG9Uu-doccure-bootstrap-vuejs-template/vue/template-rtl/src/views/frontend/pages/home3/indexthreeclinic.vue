<template>
  <section class="clinic-features-section">
    <div class="container">
      <div class="row">
        <div class="col-md-6 aos" data-aos="fade-up">
          <div class="section-heading">
            <h2>Availabe Features in Our Clinic</h2>
            <p>Meet our Experts & Book Online</p>
          </div>
        </div>
        <div class="col-md-6 text-end aos" data-aos="fade-up">
          <div class="owl-nav slide-nav-3 text-end nav-control"></div>
        </div>
      </div>
      <div class="owl-carousel clinic-feature owl-theme">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in indexThreeClinic" :key="item.id">
            <div class="item">
              <div class="clinic-features">
                <img
                  :src="require(`@/assets/img/clinic/${item.Image}`)"
                  alt="Image"
                  class="img-fluid"
                />
              </div>
              <div class="clinic-feature-overlay">
                <a href="javascript:;" class="img-overlay">{{ item.Title }}</a>
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
</template>

<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import indexThreeClinic from "@/assets/json/indexthreeclinic.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      indexThreeClinic: indexThreeClinic,
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
          itemsToShow: 5,
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
