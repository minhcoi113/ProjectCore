<template>
  <!-- blog section -->
  <div class="blog-section-fourteen">
    <div class="container">
      <div class="row">
        <div class="col-lg-6">
          <div class="section-header-fourteen">
            <div class="service-inner-fourteen">
              <div class="service-inner-fourteen-one"></div>
              <div class="service-inner-fourteen-two">
                <h3>Blog</h3>
              </div>
              <div class="service-inner-fourteen-three"></div>
            </div>
            <h2>Our Recent Articles</h2>
          </div>
        </div>
        <div class="col-lg-6 aos" data-aos="fade-up">
          <div class="owl-nav slide-nav-15 text-end nav-control"></div>
        </div>
      </div>
      <div class="owl-carousel blog-slider-fourteen owl-theme aos" data-aos="fade-up">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in IndexNineBlog" :key="item.id">
            <div class="card blog-inner-fourt-all slide-content-container">
              <div class="card-body blog-inner-fourt-main">
                <div class="blog-inner-right-fourt text-end">
                  <router-link to="/blog-details">
                    <div class="blog-inner-right-img">
                      <img
                        :src="require(`@/assets/img/blog/${item.Image}`)"
                        alt="image"
                        class="img-fluid blog-inner-right-inner"
                      />
                      <div class="blog-inner-top-content">
                        <img
                          :src="require(`@/assets/img/doctors/${item.DoctorImg}`)"
                          alt="Doctor"
                          class="me-2"
                        />
                        <span>{{ item.Name }}</span>
                      </div>
                    </div>
                  </router-link>
                  <router-link to="/blog-details" class="blog-inner-right-fourt-care">{{
                    item.Title
                  }}</router-link>
                  <ul class="articles-list nav blog-articles-list">
                    <li><i class="feather-calendar"></i> {{ item.Day }}</li>
                    <li><i class="feather-message-square"></i> {{ item.Chat }}</li>
                    <li><i class="feather-eye"></i> {{ item.Views }}</li>
                  </ul>
                  <ul class="articles-list nav blog-articles-list-two">
                    <li>{{ item.Badge }}</li>
                    <li>{{ item.Badge1 }}</li>
                  </ul>
                  <p>{{ item.Content }}</p>
                </div>
              </div>
            </div>
          </Slide>
          <template #addons>
            <Navigation />
          </template>
        </Carousel>
      </div>
      <div class="blog-btn-sec text-center aos aos-init aos-animate" data-aos="fade-up">
        <router-link to="/search" class="btn btn-primary btn-view"
          >Read More Articles</router-link
        >
      </div>
    </div>
  </div>
  <!-- /blog section -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import IndexNineBlog from "@/assets/json/indexnineblog.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      IndexNineBlog: IndexNineBlog,
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
