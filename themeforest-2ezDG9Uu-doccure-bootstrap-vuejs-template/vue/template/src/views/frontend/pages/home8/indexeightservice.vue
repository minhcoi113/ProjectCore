<template>
  <!-- services Section -->
  <section class="services-section-thirteen common-padding">
    <div class="container">
      <div class="row">
        <div class="col-lg-12 aos" data-aos="fade-up">
          <div class="section-header-thirteen">
            <div class="section-inner-thirteen">
              <img src="@/assets/img/icons/atom-bond2.svg" alt="Service" />
            </div>
            <h2>Our Services</h2>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-lg-4 col-md-6" v-for="item in IndexEightService" :key="item.id">
          <div class="service-thirteen-main">
            <div class="service-thirteen-all">
              <div class="service-img-thirteen">
                <img :src="require(`@/assets/img/${item.Image}`)" alt="Service" />
              </div>
              <div class="service-inner-contents">
                <h5>{{ item.Title }}</h5>
                <p>{{ item.Content }}</p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /services Section -->

  <!-- Our Doctors -->
  <div class="our-doctor-thirteen common-padding">
    <div class="container">
      <div class="row">
        <div class="col-lg-12 aos" data-aos="fade-up">
          <div class="section-header-thirteen">
            <div class="section-inner-thirteen">
              <img src="@/assets/img/icons/atom-bond2.svg" alt="Bond" />
            </div>
            <h2>Our Doctors</h2>
          </div>
        </div>
      </div>
      <div class="owl-carousel our-slider-thirteen owl-theme aos" data-aos="fade-up">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in IndexEightDoctor" :key="item.id">
            <div class="our-doctor-thirteen-all mb-5">
              <div class="our-doctor-thirteen-img">
                <img
                  :src="require(`@/assets/img/doctors/${item.Image}`)"
                  alt="Doctor"
                  class="img-fluid"
                />
              </div>
              <div class="our-doctor-content text-start">
                <router-link to="/doctor-profile">{{ item.Name }}</router-link>
                <div class="our-doctor-content-inner">
                  <span>Paediatrician</span>
                  <div class="reviews-ratings">
                    <p>
                      <span><i class="fas fa-star"></i> {{ item.Star }}</span>
                      {{ item.Count }}
                    </p>
                  </div>
                </div>
                <h6>{{ item.Patients }}</h6>
                <p><i class="fa-solid fa-location-dot"></i>{{ item.Location }}A</p>
                <div class="our-doctor-thirteen-imgone">
                  <img
                    src="@/assets/img/icons/add-circle.png"
                    alt="Circle"
                    class="img-fluid"
                  />
                </div>
              </div>
            </div>
          </Slide>
          <template #addons>
            <div class="owl-dots">
              <Pagination />
            </div>
          </template>
        </Carousel>
      </div>
    </div>
    <div class="our-doctor-thirteen-one">
      <img src="@/assets/img/bg/pluse-1.png" alt="pluse" />
      <img src="@/assets/img/bg/pluse-3.png" alt="pluse" />
      <img src="@/assets/img/bg/pluse-2.png" alt="pluse" />
      <img src="@/assets/img/bg/pluse-3.png" alt="pluse" />
    </div>
  </div>
  <!-- /Our Doctors -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import IndexEightService from "@/assets/json/indexeightservice.json";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import IndexEightDoctor from "@/assets/json/indexeightdoctor.json";
import "vue3-carousel/dist/carousel.css";
export default {
  components: {
    Carousel,
    Slide,
    Pagination,
    Navigation,
  },
  data() {
    return {
      IndexEightService: IndexEightService,
      IndexEightDoctor: IndexEightDoctor,
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

  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
