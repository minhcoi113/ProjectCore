<template>
  <!-- Clinic and Specialities -->
  <section class="section section-specialities">
    <div class="container-fluid">
      <div class="section-header text-center aos" data-aos="fade-up">
        <h2>Clinic and Specialities</h2>
        <p class="sub-title">
          Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
          incididunt ut labore et dolore magna aliqua.
        </p>
      </div>
      <div class="row justify-content-center">
        <div class="col-md-9 aos" data-aos="fade-up">
          <div class="specialities-slider slider">
            <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
              <Slide v-for="item in indexTwoClinic" :key="item.id">
                <div class="speicality-item text-center mb-3">
                  <div class="speicality-img">
                    <img
                      :src="require(`@/assets/img/specialities/${item.Image}`)"
                      class="img-fluid"
                      alt="Speciality"
                    />
                    <span><i class="fa fa-circle" aria-hidden="true"></i></span>
                  </div>
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
  <!-- Clinic and Specialities -->
</template>

<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import indexTwoClinic from "@/assets/json/indextwoclinic.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      indexTwoClinic: indexTwoClinic,
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
