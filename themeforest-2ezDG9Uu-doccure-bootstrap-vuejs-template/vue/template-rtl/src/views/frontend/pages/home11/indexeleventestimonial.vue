<template>
  <!-- Testimonal Section -->
  <div class="testimonal-section-sixteen">
    <div class="container">
      <div class="row">
        <div class="col-md-12">
          <div class="section-header-sixteen text-center">
            <p>OUr services</p>
            <h2>Featured Services</h2>
          </div>
        </div>
      </div>
      <div class="row align-items-center">
        <div class="col-md-5">
          <div class="testi-img">
            <img
              src="@/assets/img/testimonial-2.jpg"
              alt="Testimonial"
              class="img-fluid"
            />
            <span class="testi-icon"><i class="fa-solid fa-quote-left"></i></span>
          </div>
          <div class="testi-users">
            <div class="nav nav-container slide-11"></div>
            <ul>
              <li>
                <img
                  src="@/assets/img/clients/client-04.jpg"
                  alt="Client"
                  class="img-fluid"
                />
              </li>
              <li>
                <img
                  src="@/assets/img/clients/client-03.jpg"
                  alt="Client"
                  class="img-fluid"
                />
              </li>
              <li>
                <img
                  src="@/assets/img/clients/client-06.jpg"
                  alt="Client"
                  class="img-fluid"
                />
              </li>
              <li>
                <img
                  src="@/assets/img/clients/client-07.jpg"
                  alt="Client"
                  class="img-fluid"
                />
              </li>
            </ul>
          </div>
        </div>
        <div class="col-md-7">
          <div class="owl-carousel eye-testislider">
            <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
              <Slide v-for="item in IndexElevenTestimonial" :key="item.id">
                <div class="testimonial-wrap text-end">
                  <h4>{{ item.Title }}</h4>
                  <p>{{ item.Content }}</p>
                  <div class="testimonial-user">
                    <h6>{{ item.Name }}</h6>
                    <p>{{ item.Location }}</p>
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
  </div>
  <!-- Testimonal Section -->

  <!-- Feedback -->
  <section class="feedback-section-sixteen">
    <div class="container">
      <div class="feedback-schedule-all">
        <div class="row align-items-center">
          <div class="col-lg-5">
            <div class="feedback-inner-main">
              <img
                src="@/assets/img/feedback-sixteen.png"
                alt="image"
                class="img-fluid"
              />
            </div>
          </div>
          <div class="col-lg-7">
            <div class="feedback-fifteen-content">
              <h3>Focus On Your Own Body Shape</h3>
              <p>It's easy to list, simple to manage and, best of all, free to list!</p>
              <div class="feedback-btns">
                <router-link to="/appointments" class="btn btn-primary"
                  >Make An Appointment</router-link
                >
                <router-link to="/booking-2" class="btn btn-primarytwo"
                  ><i class="feather-plus me-2"></i>Get Free Check-up</router-link
                >
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Feedback -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import IndexElevenTestimonial from "@/assets/json/indexeleventestimonial.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      IndexElevenTestimonial: IndexElevenTestimonial,
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
          itemsToShow: 1,
          snapAlign: "center",
        },
        1024: {
          itemsToShow: 1,
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
