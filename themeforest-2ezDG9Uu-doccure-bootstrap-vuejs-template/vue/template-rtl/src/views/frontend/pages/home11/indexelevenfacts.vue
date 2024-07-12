<template>
  <!-- Facts Services -->
  <div class="facts-section-sixteen">
    <div class="container">
      <div class="facts-section-all">
        <div class="facts-main-sixteen">
          <span>OUr services</span>
          <h2>Facts you need to know ahead</h2>
          <p>
            Lorem Ipsum is simply dummy text of the printing and typesetting industry.
            Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
            when an unknown printer took a galley of type and scrambled it to make a type
            specimen book.
          </p>
          <router-link to="/booking"
            >Read More<i class="fa-solid fa-chevron-right ms-2"></i
          ></router-link>
        </div>
        <div class="facts-content-all">
          <ul>
            <li v-for="item in IndexElevenFacts" :key="item.id">
              <div class="facts-sixteen-img">
                <img :src="require(`@/assets/img/icons/${item.Image}`)" alt="Facts" />
                <div class="facts-content-sixteen">
                  <div class="facts-content-one">
                    <h5>{{ item.Title }}<i class="fa-solid fa-angle-right ms-2"></i></h5>
                  </div>
                </div>
              </div>
              <div class="facts-content-two facts-content-two-solid">
                <p>{{ item.Content }}</p>
              </div>
            </li>
          </ul>
        </div>
      </div>
    </div>
  </div>
  <!-- /Facts Services -->

  <!-- Experts Team -->
  <section class="experts-section-sixteen">
    <div class="container">
      <div class="row">
        <div class="col-md-12">
          <div class="section-header-sixteen section-header-sixteentwo text-center">
            <p>Our Team</p>
            <h2>Our experts team</h2>
          </div>
        </div>
      </div>
      <div class="slider slider-sixteen aos" data-aos="zoom-in-up">
        <div class="owl-carousel custome_slides" id="slide-experts">
          <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
            <Slide v-for="item in IndexElevenExperts" :key="item.id">
              <div class="test_imgs">
                <div class="main-reviewimages">
                  <img
                    :src="require(`@/assets/img/${item.Image}`)"
                    alt="Leslie Alexander"
                    class="img-fluid"
                  />
                </div>
                <div class="testimonal-contents">
                  <h5>{{ item.Name }}</h5>
                  <span>{{ item.Role }}</span>
                </div>
              </div>
            </Slide>
            <template #addons> </template>
          </Carousel>
        </div>
      </div>
    </div>
  </section>
  <!-- /Experts Team -->
</template>

<script>
import AOS from "aos";
import "aos/dist/aos.css";
import IndexElevenFacts from "@/assets/json/indexelevenfacts.json";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import IndexElevenExperts from "@/assets/json/indexelevenexperts.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      IndexElevenFacts: IndexElevenFacts,
      IndexElevenExperts: IndexElevenExperts,
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
          itemsToShow: 2.99,
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
