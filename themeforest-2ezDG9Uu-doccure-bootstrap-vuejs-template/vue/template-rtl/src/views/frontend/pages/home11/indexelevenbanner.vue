<template>
  <!-- Home Banner -->
  <section class="banner-section-sixteen">
    <div class="container">
      <div class="row">
        <div class="col-lg-6">
          <div class="banner-content banner-content-sixteen aos" data-aos="fade-up">
            <span>Safe and certified treatments</span>
            <h1>Perfect Face Surgery For Everyone</h1>
            <p>
              Lorem Ipsum is simply dummy text of the printing and typesetting industry.
              Lorem Ipsum has been the industry's standard dummy text ever since the
              1500s, when an unknown printer took a galley of type and scrambled it to
              make a type specimen book.
            </p>
            <div class="banner-btns-sixteen">
              <router-link to="/booking-2" class="btn btn-primary me-2"
                >Make an Appointment</router-link
              >
            </div>
          </div>
        </div>
        <div class="col-lg-6">
          <div class="banner-image-sixteen">
            <div class="banner-inner-img-sixteen">
              <img
                src="@/assets/img/ban-right-img1.jpg"
                alt="Home image"
                class="img-fluid"
              />
              <img
                src="@/assets/img/ban-right-img2.jpg"
                alt="Home image"
                class="img-fluid"
              />
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="ban-sixteen-imgone">
      <img src="@/assets/img/ban-sixteen-img1.png" alt="banner bg" />
    </div>
    <div class="ban-sixteen-imgtwo">
      <img src="@/assets/img/ban-sixteen-img2.png" alt="banner bg" />
    </div>
  </section>
  <!-- /Home Banner -->

  <!-- services Section -->
  <section class="services-section-sixteen">
    <div class="container">
      <div class="row">
        <div class="col-md-12">
          <div class="section-header-sixteen text-center">
            <p>Recapture the beauty of self-confidence</p>
            <h2>Discover a New you</h2>
          </div>
        </div>
      </div>
      <div class="owl-carousel discover-slider owl-theme">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in indexelevenservice" :key="item.id">
            <div class="discover-you-main mb-3">
              <div class="discover-you-image">
                <img :src="require(`@/assets/img/icons/${item.Image}`)" alt="Body" />
              </div>
              <a href="javascript:void(0);">{{ item.Title }}</a>
              <p>{{ item.Content }}</p>
              <a href="javascript:void(0);" class="discov-innner"
                >Read More<i class="fa-solid fa-chevron-right ms-2"></i
              ></a>
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
    <div class="service-sixteen-icon">
      <img src="@/assets/img/service-sixteen-icon.png" alt="Section bg" />
    </div>
  </section>
  <!-- /services Section -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import indexelevenservice from "@/assets/json/indexelevenservice.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      indexelevenservice: indexelevenservice,
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
