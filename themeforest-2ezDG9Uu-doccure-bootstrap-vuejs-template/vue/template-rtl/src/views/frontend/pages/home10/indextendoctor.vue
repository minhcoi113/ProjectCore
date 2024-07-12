<template>
  <!-- Doctors section -->
  <div class="doctors-section-fifteen">
    <div class="doctor-fifteen-icon">
      <img src="@/assets/img/fifteen-bg-icon-2.png" alt="Icon" />
    </div>
    <div class="doctors-fifteen-icon">
      <img
        src="@/assets/img/fifteen-bg-icon-1.png"
        alt="Icon"
        class="aos"
        data-aos="fade-down"
      />
    </div>
    <div class="container">
      <div class="row">
        <div class="col-md-12">
          <div class="section-header-fifteen text-center">
            <h2>Our <span>Expert Doctors</span></h2>
            <p>The Great Place Of ENT Hospital Center</p>
          </div>
        </div>
      </div>
      <div class="owl-carousel doctor-slider-fifteen owl-theme aos" data-aos="fade-up">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in indextendoctor" :key="item.id">
            <div class="item item-fifteen slide-content-container">
              <div class="doctor-profile-widget">
                <div class="doc-pro-img">
                  <router-link to="doctor-profile">
                    <div class="doctor-profile-img">
                      <img
                        :src="require(`@/assets/img/doctors/${item.imageSrc}`)"
                        class="img-fluid"
                        alt="Icon"
                      />
                    </div>
                  </router-link>
                  <div class="doctor-amount">
                    <a
                      href="javascript:void(0)"
                      class="fav-icon"
                      :class="{ selected: item.isFavourite }"
                      @click="toggleFavourite(item)"
                    >
                      <i class="feather-heart"></i>
                    </a>
                  </div>
                  <div class="item-info">
                    <h6>{{ item.yearsExperience }}+ Years Experience</h6>
                  </div>
                </div>
                <div class="doc-content-fift text-end">
                  <router-link to="doctor-profile">{{ item.doctorName }}</router-link>
                  <p>{{ item.specialization }}</p>
                  <div class="rate-fifteen">
                    <div class="rate-four">
                      <i class="fas fa-star filled me-2"></i
                      ><span>{{ item.rating }}</span>
                    </div>
                    <ul>
                      <li>Mo</li>
                      <li>Tu</li>
                      <li>We</li>
                      <li>Th</li>
                      <li>Fr</li>
                    </ul>
                  </div>
                </div>
              </div>
            </div>
          </Slide>
          <template #addons>
            <div class="owl-nav">
              <Navigation />
            </div>
          </template>
        </Carousel>
      </div>
    </div>
  </div>
  <!-- /blog section -->

  <!-- Pharmacy Section -->
  <section class="pharmacy-section-fifteen">
    <div class="container">
      <div class="row">
        <div class="col-md-12">
          <div class="section-header-fifteen text-center">
            <h2>Online <span>Pharmacy Store</span></h2>
            <p>More the quantity, higher the discount. Hurry, Buy Now!</p>
          </div>
        </div>
      </div>
      <div class="owl-carousel pharmacy-slider-fifteen owl-theme aos" data-aos="fade-up">
        <Carousel
          :wrap-around="true"
          :settings="settingspharmacy"
          :breakpoints="breakpointspharmacy"
        >
          <Slide v-for="item in indextenpharmacy" :key="item.id">
            <div class="item item-fifteen slide-content-container w-100">
              <div class="doctor-profile-widget doctor-profile-widget-fift">
                <div class="doc-pro-img doc-pro-img-fifteen">
                  <router-link to="doctor-profile">
                    <div class="doctor-profile-img doctor-profile-img-fifteen">
                      <img
                        :src="require(`@/assets/img/${item.imageSrc}`)"
                        class="img-fluid"
                        alt="Doctor"
                      />
                    </div>
                  </router-link>
                  <div class="doctor-amount">
                    <a
                      href="javascript:void(0)"
                      class="fav-icon fav-icon-fifteen"
                      :class="{ selected: item.isFavourite }"
                      @click="toggleFavourite1(item)"
                    >
                      <i class="feather-heart"></i>
                    </a>
                  </div>
                  <div class="item-info">
                    <h6>{{ item.discount }}</h6>
                  </div>
                </div>
                <div class="doc-content-fift text-end">
                  <a href="javacript:;">{{ item.productName }}</a>
                  <p><span>Sold by:</span> {{ item.soldBy }}</p>
                  <div class="rate-fifteen">
                    <div class="rate-four">
                      <span>In Stock</span>
                    </div>
                    <ul class="fift-rate">
                      <li>5ml</li>
                      <li>10ml</li>
                    </ul>
                  </div>
                  <div class="fift-bottom-content">
                    <h3>
                      ${{ item.price }}<span class="ms-2">${{ item.originalPrice }}</span>
                    </h3>
                    <router-link to="add-prescription">Add to Cart</router-link>
                  </div>
                </div>
              </div>
            </div>
          </Slide>
          <template #addons>
            <div class="owl-nav">
              <Navigation />
            </div>
          </template>
        </Carousel>
      </div>
    </div>
  </section>
  <!-- /Pharmacy section -->

  <!-- Feedback -->
  <section class="feedback-section-fifteen">
    <div class="container">
      <div class="feedback-schedule-all">
        <div class="row">
          <div class="col-lg-5">
            <div class="feedback-inner-main">
              <img
                src="@/assets/img/feedback-fifteen.png"
                alt="image"
                class="img-fluid"
              />
            </div>
          </div>
          <div class="col-lg-7">
            <div class="feedback-fifteen-content">
              <div class="feedback-fift-img">
                <img src="@/assets/img/logo-03.png" alt="Logo" />
              </div>
              <h3>Consult top doctors online for any health concern</h3>
              <p>Connect within 60secs</p>
              <a href="javascript:;">Signup Now</a>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Feedback -->

  <!-- contact -->
  <section class="appointment-section-fifteen">
    <div class="container">
      <div class="row">
        <div class="col-lg-7">
          <div class="appointment-schedule-main">
            <h2>Book Appointment</h2>
            <h6>More the quantity, higher the discount. Hurry, Buy Now!</h6>
            <p>
              Lorem Ipsum is simply dummy text of the printing and typesetting industry.
              Lorem Ipsum has been the industry's standard dummy text ever since the
              1500s, when an unknown printer took a galley of type and scrambled it to
              make a type specimen book.
            </p>
            <ul>
              <li v-for="item in indextenbook" :key="item.id">
                <div class="appointment-schedule-img">
                  <img
                    :src="require(`@/assets/img/icons/${item.outerImgSrc}`)"
                    alt="Experience"
                  />
                  <div class="appoint-inner-img">
                    <img
                      :src="require(`@/assets/img/icons/${item.innerImgSrc}`)"
                      alt="Experience"
                    />
                  </div>
                </div>
                <span>{{ item.text }}</span>
              </li>
            </ul>
            <router-link to="booking-2">Book an Appointment</router-link>
          </div>
        </div>
        <div class="col-lg-5">
          <div class="appointment-right-image appoint-fift-img">
            <img
              src="@/assets/img/appointment-ryt-1.png"
              alt="Experience"
              class="img-fluid"
            />
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /contact -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import indextendoctor from "@/assets/json/indextendoctor.json";
import indextenpharmacy from "@/assets/json/indextenpharmacy.json";
import indextenbook from "@/assets/json/indextenbook.json";
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
      indextendoctor: indextendoctor,
      indextenpharmacy: indextenpharmacy,
      indextenbook: indextenbook,
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
          itemsToShow: 2.99,
          snapAlign: "start",
        },
      },
      settingspharmacy: {
        itemsToShow: 1,
        snapAlign: "center",
      },

      breakpointspharmacy: {
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
          itemsToShow: 1,
          snapAlign: "center",
        },
        // 1024 and up
        1024: {
          itemsToShow: 3,
          snapAlign: "start",
        },
      },
    };
  },
  methods: {
    toggleFavourite(item) {
      item.isFavourite = !item.isFavourite;
    },
    toggleFavourite1(item) {
      item.isFavourite = !item.isFavourite;
    },
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
