<template>
  <div class="left-panel">
    <div class="onboarding-logo text-center">
      <router-link to="/"
        ><img
          src="@/assets/img/onboard-img/onb-logo.png"
          class="img-fluid"
          alt="doccure-logo"
      /></router-link>
    </div>
    <div class="onboard-img">
      <img
        src="@/assets/img/onboard-img/onb-slide-img.png"
        class="img-fluid"
        alt="onboard-slider"
      />
    </div>
    <div class="onboarding-slider">
      <!-- Slider -->

      <div id="onboard-slider" class="owl-carousel owl-theme onboard-slider slider">
        <!-- Slider Item -->
        <Carousel :autoplay="2000" :wrap-around="true">
          <Slide v-for="slide in 3" :key="slide">
            <div class="onboard-item text-center">
              <div class="onboard-content">
                <h3>Welcome to Doccure</h3>
                <p>
                  Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod
                  tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim
                  veniam.
                </p>
              </div>
            </div>
          </Slide>
          <template #addons>
            <Pagination />
          </template>
        </Carousel>
        <!-- /Slider Item -->
      </div>

      <!-- /Slider -->
    </div>
  </div>
</template>

<script>
import { defineComponent } from "vue";
import { Carousel, Pagination, Slide } from "vue3-carousel";

import "vue3-carousel/dist/carousel.css";

export default defineComponent({
  name: "Autoplay",
  components: {
    Carousel,
    Slide,
    Pagination,
  },
});
</script>
