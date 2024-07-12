<template>
  <div class="owl-carousel eye-blogslider owl-them aos" data-aos="fade-up">
    <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
      <Slide v-for="item in EyeGlass" :key="item.id">
        <div class="item slide-content-containers">
          <div class="store-item">
            <div class="store-img">
              <router-link to="/product-description">
                <img
                  :src="require(`@/assets/img/stores/${item.Image}`)"
                  alt="eye-glass"
                  class="img-fluid"
                />
              </router-link>
              <span class="glass-cat">{{ item.Badge }}</span>
            </div>
            <div class="store-content">
              <span class="store-cat">New</span>
              <h4>
                <router-link to="/product-description">{{ item.Title }}</router-link>
              </h4>
              <p>{{ item.Content }}</p>
              <div class="price-tag">
                <h5>{{ item.Price }}</h5>
                <ul class="color-selection">
                  <li>
                    <span :class="item.Class">
                      <i class="fa-solid fa-circle me-1"></i>
                    </span>
                  </li>
                  <li>
                    <span :class="item.Class1">
                      <i class="fa-solid fa-circle"></i>
                    </span>
                  </li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </Slide>
      <template #addons>
        <Navigation />
      </template>
    </Carousel>
  </div>
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import EyeGlass from "@/assets/json/eyeglass.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      EyeGlass: EyeGlass,
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
