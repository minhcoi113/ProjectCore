<template>
  <!-- Services Section -->
  <div class="features-section-sixteen">
    <div class="container">
      <div class="row">
        <div class="col-md-12">
          <div class="section-header-sixteen text-center">
            <p>OUr services</p>
            <h2>Featured Services</h2>
          </div>
        </div>
      </div>
      <div class="owl-carousel features-slider-sixteen owl-theme">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in IndexElevenServices" :key="item.id">
            <div class="feature-sixteen-main">
              <div class="feature-six-img">
                <img
                  :src="require(`@/assets/img/${item.Image}`)"
                  alt="Feature"
                  class="img-fluid"
                />
                <div class="feature-content-six">
                  <div class="feature-content-one">
                    <h5>{{ item.Title }}</h5>
                    <span><i class="fa-solid fa-angle-up"></i></span>
                  </div>
                  <div class="feature-content-two">
                    <p>
                      Facial procedures are popular because of their ability to give
                      patients a youthful appearance, reduce the signs of aging and by
                      improving existing features for more aesthetically pleasing results.
                      These methods are in two separate categories and are commonly known
                      as facial rejuvenation and facial contouring. Facial rejuvenation
                      consists of facelift, eyelid lift, neck lift and brow lift.
                    </p>
                    <span><i class="fa-solid fa-angle-down"></i></span>
                  </div>
                </div>
              </div>
            </div>
          </Slide>
          <template #addons>
            <Pagination />
          </template>
        </Carousel>
      </div>
    </div>
  </div>
  <!-- /Services Section -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import IndexElevenServices from "@/assets/json/indexelevenservices.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      IndexElevenServices: IndexElevenServices,
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
          itemsToShow: 3,
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
