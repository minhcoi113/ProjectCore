<template>
  <section class="section trusted-section">
    <div class="container">
      <div class="trusted-info">
        <div class="row align-items-center">
          <div class="col-lg-7 col-md-12 trusted-img">
            <img src="@/assets/img/trusted-img.jpg" class="img-fluid" alt="Trusted Img" />
          </div>
          <div class="col-lg-5 col-md-12">
            <div class="trusted-content">
              <h4>100% Trusted Medical Store</h4>
              <div class="trusted-text">
                <h6><i class="fa-solid fa-circle-check"></i> Healthy life.</h6>
                <p>
                  At Doccure, we believe that true well-being extends beyond the
                  prescription counter. Our commitment to your health goes beyond
                  medications, a dedicated space designed to empower you on your journey
                  to a healthier and happier life.
                </p>
              </div>
              <div class="trusted-text">
                <h6>
                  <i class="fa-solid fa-circle-check"></i> Every day quality products for
                  you.
                </h6>
                <p>
                  At Doccure, we believe that true well-being extends beyond the
                  prescription counter. Our commitment to your health goes beyond
                  medications, a dedicated space designed to empower you on your journey
                  to a healthier and happier life.
                </p>
              </div>
              <div class="trusted-btn">
                <router-link to="product-all" class="btn">
                  Shop Now <i class="feather-chevron-right"></i>
                </router-link>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="partners-info">
        <ul class="owl-carousel partners-slider d-flex">
          <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
            <Slide v-for="item in Trusted_Section" :key="item.id">
              <a href="javascript:void(0);">
                <img
                  class="img-fluid"
                  :src="require(`@/assets/img/partners/${item.Image}`)"
                  alt="Partners"
                />
              </a>
            </Slide>
          </Carousel>
        </ul>
      </div>
    </div>
  </section>
</template>
<script>
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import Trusted_Section from "@/assets/json/trusted-section.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      Trusted_Section: Trusted_Section,
      settings: {
        itemsToShow: 1,
        snapAlign: "center",
        loop: true,
        margin: 24,
      },

      breakpoints: {
        575: {
          itemsToShow: 1,
          snapAlign: "center",
        },
        // 700px and up
        767: {
          itemsToShow: 2,
          snapAlign: "center",
        },
        // 991px and up
        991: {
          itemsToShow: 4,
          snapAlign: "center",
        },
        // 1024 and up
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
};
</script>
