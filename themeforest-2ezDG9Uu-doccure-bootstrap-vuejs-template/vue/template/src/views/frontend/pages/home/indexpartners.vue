<template>
  <!-- Partners Section -->
  <section class="partners-section">
    <div class="container">
      <div class="row">
        <div class="col-md-12">
          <div class="section-header-one text-center aos" data-aos="fade-up">
            <h2 class="section-title">Our Partners</h2>
          </div>
        </div>
      </div>
      <div class="partners-info">
        <ul class="owl-carousel partners-slider d-flex">
          <Carousel
            :autoplay="1000"
            :wrap-around="true"
            :settings="settings"
            :breakpoints="breakpoints"
          >
            <Slide v-for="item in IndexPartners" :key="item.id">
              <div class="partners-carousel">
                <a href="javascript:void(0);">
                  <img
                    class="img-fluid"
                    :src="require(`@/assets/img/partners/${item.Image}`)"
                    alt="partners"
                  />
                </a>
              </div>
            </Slide>
            <template #addons>
              <Navigation />
            </template>
          </Carousel>
        </ul>
      </div>
    </div>
  </section>
  <!-- /Partners Section -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import IndexPartners from "@/assets/json/indexpartners.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      IndexPartners: IndexPartners,
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
          itemsToShow: 4,
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
  components: {
    Carousel,
    Slide,
    Pagination,
    Navigation,
  },
};
</script>
