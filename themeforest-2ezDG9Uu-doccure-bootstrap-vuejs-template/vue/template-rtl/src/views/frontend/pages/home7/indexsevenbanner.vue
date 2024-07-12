<template>
  <!-- Home Banner -->
  <section class="banner-section-fourteen banner-section-twelve">
    <div class="banner-section-twelve-bg">
      <img src="@/assets/img/bg/home-12-banner-bg-1.png" alt="design-image" />
      <img src="@/assets/img/bg/home-12-banner-bg-2.png" alt="design-image" />
    </div>
    <div class="container">
      <div class="row">
        <div class="col-lg-6">
          <div class="banner-img banner-img-twelve aos" data-aos="fade-up">
            <img
              src="@/assets/img/bg/home-12-banner-1.png"
              class="img-fluid"
              alt="dog-image"
            />
            <img
              src="@/assets/img/bg/home-12-banner-2.png"
              class="img-fluid"
              alt="cat-image"
            />
            <div class="banner-banner-img-twelve-bg">
              <img src="@/assets/img/bg/dot-1.png" alt="dot-icon" />
              <img src="@/assets/img/bg/dot-2.png" alt="dot-icon" />
              <img src="@/assets/img/bg/ring-1.png" alt="ring-icon" />
              <img src="@/assets/img/bg/ring-2.png" alt="ring-icon" />
            </div>
          </div>
        </div>
        <div class="col-lg-6">
          <div class="banner-content banner-content-fourteen aos" data-aos="fade-up">
            <h1>We take care <span>of Your Pets</span></h1>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit,</p>
            <div class="banner-btns-fourteen">
              <router-link to="booking" class="btn btn-primary me-2"
                >Start a Consult</router-link
              >
              <router-link to="booking" class="btn btn-primary"
                >Schedule a Call</router-link
              >
            </div>
          </div>
          <div class="search-box-fourteen aos" data-aos="fade-up">
            <form @submit.prevent="submitForm" class="form-block d-flex">
              <div class="search-input">
                <div class="forms-block">
                  <label class="mb-2">Date</label>
                  <datepicker
                    v-model="startdate"
                    placeholder="Date"
                    class="form-control datetimepicker"
                    :editable="true"
                    :clearable="false"
                  />
                </div>
              </div>
              <div class="search-input">
                <div class="forms-block mb-0">
                  <label class="location-icon">Location</label>
                  <input
                    type="text"
                    class="form-control"
                    placeholder="San Diego Branch"
                  />
                </div>
              </div>
              <div class="search-btn">
                <b-button class="btn btn-primary" type="submit">Book Now</b-button>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Home Banner -->

  <!-- services Section -->
  <section class="services-section-fourteen">
    <div class="floating-bg">
      <img src="@/assets/img/bg/big-paw.png" alt="paw-image" />
      <img src="@/assets/img/bg/small-paw.png" alt="paw-image" />
    </div>
    <div class="container">
      <div class="row">
        <div class="col-lg-12 aos" data-aos="fade-up">
          <div class="section-header-fourteen service-inner-fourteen">
            <div class="service-inner-fourteen">
              <div class="service-inner-fourteen-two">
                <h3>OUR SERVICES</h3>
              </div>
            </div>
            <h2>What can We do</h2>
            <p>Our Professional Services</p>
          </div>
        </div>
      </div>
      <div class="row row-gap justify-content-center">
        <div
          v-for="service in indexsevenservice"
          :key="service.title"
          class="col-lg-3 col-md-4 col-sm-12"
        >
          <div class="our-services-list">
            <div class="service-icon">
              <img
                :src="require(`@/assets/img/icons/${service.icon}`)"
                :alt="service.alt"
              />
            </div>
            <h4>{{ service.title }}</h4>
            <p>{{ service.description }}</p>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /services Section -->

  <!-- Our Doctors -->
  <div class="blog-section-fourteen our-doctor-twelve">
    <div class="floating-bg">
      <img src="@/assets/img/bg/small-paw.png" alt="paw-image" />
      <img src="@/assets/img/bg/big-paw.png" alt="paw-image" />
    </div>
    <div class="container">
      <div class="row">
        <div class="col-lg-12">
          <div class="section-header-fourteen service-inner-fourteen">
            <div class="service-inner-fourteen">
              <div class="service-inner-fourteen-two">
                <h3>OUR TEAM</h3>
              </div>
            </div>
            <h2>Meet Our Doctors</h2>
            <p>Our Qualified Professionals</p>
          </div>
        </div>
      </div>
      <Carousel
        class="blog-slider-twelve"
        :wrap-around="true"
        :settings="settings"
        :breakpoints="breakpoints"
      >
        <Slide v-for="doctor in indexsevendoctor" :key="doctor.name">
          <div class="card blog-inner-fourt-all">
            <div class="card-body blog-inner-fourt-main">
              <div class="blog-inner-right-fourt">
                <router-link to="doctor-profile">
                  <div class="blog-inner-right-img">
                    <img
                      :src="require(`@/assets/img/doctors/${doctor.imgSrc}`)"
                      :alt="doctor.imgAlt"
                      class="img-fluid"
                    />
                    <div class="blog-inner-top-content content-pricing">
                      <span>{{ doctor.price }}</span>
                    </div>
                    <div class="blog-inner-top-content">
                      <span>{{ doctor.specialization }}</span>
                    </div>
                  </div>
                </router-link>
                <h4 class="blog-inner-right-fourt-care">
                  <router-link to="doctor-profile">{{ doctor.name }}</router-link>
                </h4>
                <ul class="articles-list nav blog-articles-list">
                  <li>
                    <i class="fa fa-location-dot"></i>
                    <strong>{{ doctor.location }}</strong>
                  </li>
                </ul>
                <div class="blog-list-ratings">
                  <i
                    v-for="index in 5"
                    :key="index"
                    class="fa-solid fa-star"
                    :class="{ rated: index <= doctor.ratings }"
                  ></i>
                  <span>({{ doctor.ratings }})</span>
                </div>
                <router-link to="booking" class="btn btn-primary">Consult</router-link>
              </div>
            </div>
          </div>
        </Slide>
        <template #addons>
          <Navigation />
        </template>
      </Carousel>
      <div class="owl-nav slide-nav-16 text-end nav-control"></div>

      <div class="blog-btn-sec text-center aos aos-init aos-animate" data-aos="fade-up">
        <router-link to="search" class="btn btn-primary btn-view"
          >See All Doctors</router-link
        >
      </div>
    </div>
  </div>
  <!-- /Our Doctors -->
</template>
<script>
import { ref } from "vue";
const currentDate = ref(new Date());
import AOS from "aos";
import "aos/dist/aos.css";
import indexsevenservice from "@/assets/json/indexsevenservice.json";
import indexsevendoctor from "@/assets/json/indexsevendoctor.json";
import { Carousel, Navigation, Slide } from "vue3-carousel";
import "vue3-carousel/dist/carousel.css";
export default {
  components: {
    Carousel,
    Slide,
    Navigation,
  },
  data() {
    return {
      indexsevendoctor: indexsevendoctor,
      indexsevenservice: indexsevenservice,
      startdate: currentDate,
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
        // 700px and up
        991: {
          itemsToShow: 3,
          snapAlign: "center",
        },
        // 1024 and up
        1024: {
          itemsToShow: 4,
          snapAlign: "start",
        },
      },
    };
  },
  methods: {
    submitForm() {
      this.$router.push("/search");
    },
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
