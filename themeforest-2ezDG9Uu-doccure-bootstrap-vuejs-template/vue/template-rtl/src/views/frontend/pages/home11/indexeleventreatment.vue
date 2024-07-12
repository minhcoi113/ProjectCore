<template>
  <!-- Treatment Section -->
  <div class="treatment-section-sixteen">
    <div class="container">
      <div class="row">
        <div class="col-md-12">
          <div class="section-header-sixteen text-center">
            <p>OUr services</p>
            <h2>Choose a treatment</h2>
          </div>
        </div>
      </div>
      <div class="owl-carousel treatment-sixteen-slider owl-theme">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in IndexElevenTreatment" :key="item.id">
            <div class="item item-sixteen">
              <div class="doctor-profile-widget">
                <div class="doc-pro-img">
                  <router-link to="/doctor-profile">
                    <div class="doctor-profile-img">
                      <img
                        :src="require(`@/assets/img/${item.Image}`)"
                        class="img-fluid"
                        alt="Treatment"
                      />
                    </div>
                  </router-link>
                  <div class="doctor-amount">
                    <span>{{ item.Badge }}</span>
                  </div>
                </div>
                <div class="doc-content text-end">
                  <div class="doc-pro-info">
                    <div class="doc-pro-name">
                      <router-link to="/doctor-profile">{{ item.Name }}</router-link>
                      <p>{{ item.Role }}</p>
                    </div>
                    <div class="reviews-ratings">
                      <p>
                        <span><i class="fas fa-star"></i> {{ item.Rating }}</span>
                        {{ item.View }}
                      </p>
                    </div>
                  </div>
                  <div class="doc-pro-location">
                    <p><i class="feather-map-pin"></i> {{ item.Location }}</p>
                  </div>
                </div>
                <router-link to="/booking" class="btn btn-primary">Book</router-link>
              </div>
            </div>
          </Slide>
          <template #addons>
            <Navigation />
          </template>
        </Carousel>
      </div>
    </div>
    <div class="service-sixteen-icontwo">
      <img src="@/assets/img/service-sixteen-icon.png" alt="Section bg" />
    </div>
  </div>
  <!-- /Treatment Section -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import IndexElevenTreatment from "@/assets/json/indexeleventreatment.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      IndexElevenTreatment: IndexElevenTreatment,
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
          itemsToShow: 2,
          snapAlign: "start",
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
