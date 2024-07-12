<template>
  <!-- Blog Section -->
  <section class="our-blog-section eye-blog">
    <div class="container">
      <div class="row">
        <div class="col-md-12 aos" data-aos="fade-up">
          <div class="section-heading text-center sec-heading-eye">
            <img src="@/assets/img/icons/eye-icon.svg" alt="eye-icon" class="img-fluid" />
            <h2><span>Blog</span> Post</h2>
            <p>The Great Place Of Eyecare Hospital Center</p>
          </div>
        </div>
      </div>
      <div class="owl-carousel eye-blogslider owl-them aos" data-aos="fade-up">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in IndexSixBlog" :key="item.id">
            <div class="item">
              <div class="our-blogs">
                <div class="blogs-img">
                  <router-link to="/blog-details"
                    ><img
                      :src="require(`@/assets/img/blog/${item.Image}`)"
                      alt="blog-image"
                      class="img-fluid blog-inner-img"
                  /></router-link>
                  <div class="blogs-overlay">
                    <div class="blog-name">
                      <img
                        :src="require(`@/assets/img/doctors/${item.Doctor}`)"
                        alt="Deirdre Carolyn"
                        class="img-fluid"
                      />
                      <div>
                        <a href="javascript:;">{{ item.Name }}</a>
                        <p>{{ item.Day }}</p>
                      </div>
                    </div>
                    <span class="blog-cat">{{ item.Badge }}</span>
                  </div>
                </div>
                <div class="blogs-info">
                  <h4>
                    <router-link to="/blog-details">{{ item.Title }}</router-link>
                  </h4>
                  <p>{{ item.Content }}</p>
                  <router-link to="/blog-details" class="blogs-btn"
                    >Read More<i class="fa-solid fa-chevron-right"></i
                  ></router-link>
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
  <!-- /Blog Section -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import IndexSixBlog from "@/assets/json/indexsixblog.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      IndexSixBlog: IndexSixBlog,
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
