<template>
  <!-- Specialities Section -->
  <section class="specialities-section">
    <div class="shapes">
      <img src="@/assets/img/shapes/shape-3.png" alt="Image" class="img-fluid shape-3" />
      <img src="@/assets/img/shapes/shape-4.png" alt="Image" class="img-fluid shape-4" />
    </div>
    <div class="container">
      <div class="row">
        <div class="col-md-6 aos" data-aos="fade-up">
          <div class="section-heading bg-area">
            <h2>Browse by Specialities</h2>
            <p>Find experienced doctors across all specialties</p>
          </div>
        </div>
      </div>
      <div class="row">
        <div
          class="col-lg-3 col-md-6 aos"
          v-for="item in indexThreeSpecialities"
          :key="item.id"
          data-aos="fade-up"
        >
          <div class="specialist-card d-flex">
            <div class="specialist-img">
              <img
                :src="require(`@/assets/img/category/${item.Image}`)"
                alt="Image"
                class="img-fluid"
              />
            </div>
            <div class="specialist-info">
              <a href="javascript:;">
                <h4>{{ item.Title }}</h4>
              </a>
              <p>{{ item.Doctors }}</p>
            </div>
            <div class="specialist-nav ms-auto">
              <a href="javascript:;"><i class="fas fa-long-arrow-alt-right"></i></a>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Specialities Section -->

  <!-- Best Doctor Section -->
  <section class="our-doctors-section">
    <div class="container">
      <div class="row">
        <div class="col-md-6 aos" data-aos="fade-up">
          <div class="section-heading">
            <h2>Clinic & Specialities</h2>
            <p>
              Access to expert physicians and surgeons, advanced technologies and
              top-quality surgery facilities right here.
            </p>
          </div>
        </div>
        <div class="col-md-6 text-end aos" data-aos="fade-up">
          <div class="owl-nav slide-nav-2 text-end nav-control"></div>
        </div>
      </div>
      <div class="owl-carousel our-doctors owl-theme">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in indexThreeDoctors" :key="item.id">
            <div class="item">
              <div class="our-doctors-card">
                <div class="doctors-header">
                  <a href="javascript:;"
                    ><img
                      :src="require(`@/assets/img/doctors/${item.Image}`)"
                      alt="Image"
                      class="img-fluid"
                  /></a>
                  <div class="img-overlay">
                    <span>{{ item.Price }}</span>
                  </div>
                </div>
                <div class="doctors-body">
                  <div class="rating">
                    <i class="fas fa-star filled me-1"></i>
                    <i class="fas fa-star filled me-1"></i>
                    <i class="fas fa-star filled me-1"></i>
                    <i class="fas fa-star filled me-1"></i>
                    <i class="fas fa-star filled"></i>
                    <span class="d-inline-block average-ratings">{{ item.Rateing }}</span>
                  </div>
                  <router-link to="/doctor-profile">
                    <h4>{{ item.Name }}</h4>
                  </router-link>
                  <p>{{ item.Title }}</p>
                  <div class="location d-flex">
                    <p><i class="fas fa-map-marker-alt me-2"></i> {{ item.Location }}</p>
                    <p class="ms-auto">
                      <i class="fas fa-user-md"></i> {{ item.Consult }}
                    </p>
                  </div>
                  <div class="row row-sm">
                    <div class="col-6">
                      <router-link to="/doctor-profile" class="btn view-btn" tabindex="0"
                        >View Profile</router-link
                      >
                    </div>
                    <div class="col-6">
                      <router-link to="/booking" class="btn book-btn" tabindex="0"
                        >Book Now</router-link
                      >
                    </div>
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
  </section>
  <!-- /Best Doctor Section -->
</template>

<script>
import AOS from "aos";
import "aos/dist/aos.css";
import indexThreeSpecialities from "@/assets/json/indexthreespecialities.json";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import indexThreeDoctors from "@/assets/json/indexthreedoctors.json";
import "vue3-carousel/dist/carousel.css";

export default {
  data() {
    return {
      indexThreeSpecialities: indexThreeSpecialities,
      indexThreeDoctors: indexThreeDoctors,
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
