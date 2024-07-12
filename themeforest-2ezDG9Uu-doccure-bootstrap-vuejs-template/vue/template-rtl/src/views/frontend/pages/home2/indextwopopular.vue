<template>
  <section class="section section-doctor">
    <div class="container-fluid">
      <div class="row">
        <div class="col-lg-4 aos" data-aos="fade-up">
          <div class="section-header">
            <h2>Book Our Doctor</h2>
            <p>Lorem Ipsum is simply dummy text</p>
          </div>
          <div class="about-content">
            <p>
              It is a long established fact that a reader will be distracted by the
              readable content of a page when looking at its layout. The point of using
              Lorem Ipsum.
            </p>
            <p>
              web page editors now use Lorem Ipsum as their default model text, and a
              search for 'lorem ipsum' will uncover many web sites still in their infancy.
              Various versions have evolved over the years, sometimes
            </p>
            <a href="javascript:;">Read More..</a>
          </div>
        </div>
        <div class="col-lg-8 aos" data-aos="fade-up">
          <div class="doctor-slider slider">
            <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
              <Slide v-for="item in indexTwoPopular" :key="item.id">
                <div class="profile-widget">
                  <div class="doc-img">
                    <router-link to="/doctor-profile">
                      <img
                        class="img-fluid"
                        alt="User Image"
                        :src="require(`@/assets/img/doctors/${item.Image}`)"
                      />
                    </router-link>
                    <a href="javascript:void(0)" class="fav-btn">
                      <i class="far fa-bookmark"></i>
                    </a>
                  </div>
                  <div class="pro-content">
                    <h3 class="title">
                      <router-link to="/doctor-profile">{{ item.Name }}</router-link>
                      <i class="fas fa-check-circle verified"></i>
                    </h3>
                    <p class="speciality">{{ item.Content }}</p>
                    <div class="rating">
                      <i class="fas fa-star filled me-1"></i>
                      <i class="fas fa-star filled me-1"></i>
                      <i class="fas fa-star filled me-1"></i>
                      <i class="fas fa-star filled me-1"></i>
                      <i class="fas fa-star me-1"></i>
                      <span class="d-inline-block average-rating">{{
                        item.Rateing
                      }}</span>
                    </div>
                    <ul class="available-info">
                      <li><i class="fas fa-map-marker-alt"></i> {{ item.Location }}</li>
                      <li><i class="far fa-clock"></i> {{ item.Available }}</li>
                      <li>
                        <i class="far fa-money-bill-alt"></i>{{ item.Price }}
                        <i
                          class="fas fa-info-circle"
                          data-bs-toggle="tooltip"
                          title="Lorem Ipsum"
                        ></i>
                      </li>
                    </ul>
                    <div class="row row-sm">
                      <div class="col-6">
                        <router-link to="/doctor-profile" class="btn view-btn"
                          >View Profile</router-link
                        >
                      </div>
                      <div class="col-6">
                        <router-link to="/booking" class="btn book-btn"
                          >Book Now</router-link
                        >
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
      </div>
    </div>
  </section>
</template>

<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import indexTwoPopular from "@/assets/json/indextwopopular.json";
import "vue3-carousel/dist/carousel.css";

export default {
  data() {
    return {
      indexTwoPopular: indexTwoPopular,
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
