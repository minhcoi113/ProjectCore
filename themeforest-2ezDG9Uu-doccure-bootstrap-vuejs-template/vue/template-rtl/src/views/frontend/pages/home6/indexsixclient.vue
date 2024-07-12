<template>
  <!-- Clinic Section -->
  <section class="eyeclinics-section">
    <div class="container">
      <div class="row">
        <div class="col-md-12 aos" data-aos="fade-up">
          <div class="section-heading text-center sec-heading-eye">
            <img src="@/assets/img/icons/eye-icon.svg" alt="eye-icon" class="img-fluid" />
            <h2><span>Our</span> Specialties</h2>
            <p>The Great Place Of Eyecare Hospital Center</p>
          </div>
        </div>
      </div>
      <div class="owl-carousel eye-clinic owl-them aos" data-aos="fade-up">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in indexSixClient" :key="item.id">
            <div class="item">
              <div class="card our-doctors-card eye-doc">
                <div class="doctors-header">
                  <router-link to="/doctor-profile"
                    ><img
                      :src="require(`@/assets/img/doctors/${item.Image}`)"
                      alt="Andrea"
                      class="img-fluid"
                  /></router-link>
                </div>
                <div class="doctors-body text-end">
                  <h4>
                    <router-link to="/doctor-profile">{{ item.Name }}</router-link>
                  </h4>
                  <p>{{ item.Department }}</p>
                  <h6>{{ item.Experience }}</h6>
                  <div class="rating">
                    <i class="fas fa-star filled me-1"></i>
                    <i class="fas fa-star filled me-1"></i>
                    <i class="fas fa-star filled me-1"></i>
                    <i class="fas fa-star filled me-1"></i>
                    <i class="fas fa-star me-1"></i>
                    <span>{{ item.Rateing }}</span>
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
    </div>
    <div class="ban-bg">
      <img
        src="@/assets/img/bg/clinic-bg-01.png"
        alt="design-image"
        class="img-fluid bg-08"
      />
    </div>
  </section>
  <!-- /Clinic Section -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import indexSixClient from "@/assets/json/indexsixclient.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      indexSixClient: indexSixClient,
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
