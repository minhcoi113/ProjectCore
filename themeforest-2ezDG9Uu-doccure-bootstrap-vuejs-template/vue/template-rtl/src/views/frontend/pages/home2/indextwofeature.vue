<template>
  <!-- Availabe Features -->
  <section class="section section-features">
    <div class="container-fluid">
      <div class="row">
        <div class="col-md-5 features-img aos" data-aos="fade-up">
          <img src="@/assets/img/features/feature.png" class="img-fluid" alt="Feature" />
        </div>
        <div class="col-md-7 aos" data-aos="fade-up">
          <div class="section-header">
            <h2 class="mt-2">Availabe Features in Our Clinic</h2>
            <p>
              It is a long established fact that a reader will be distracted by the
              readable content of a page when looking at its layout.
            </p>
          </div>
          <div class="features-slider slider">
            <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
              <Slide v-for="item in indexTwoFeature" :key="item.id">
                <div class="feature-item text-center mb-3">
                  <img
                    :src="require(`@/assets/img/features/${item.Image}`)"
                    class="img-fluid"
                    alt="Feature"
                  />
                  <p>{{ item.Title }}</p>
                </div>
              </Slide>
              <template #addons>
                <Pagination />
              </template>
            </Carousel>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Availabe Features -->
</template>

<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import indexTwoFeature from "@/assets/json/indextwofeature.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      indexTwoFeature: indexTwoFeature,
      settings: {
        itemsToShow: 1,
        snapAlign: "center",
      },
      breakpoints: {
        575: {
          itemsToShow: 3,
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
