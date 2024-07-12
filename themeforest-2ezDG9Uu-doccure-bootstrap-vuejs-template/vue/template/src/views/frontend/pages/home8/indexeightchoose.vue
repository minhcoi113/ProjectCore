<template>
  <!-- Why Choose Us -->
  <section class="choose-us-section-thirteen common-padding">
    <div class="container">
      <div class="row">
        <div class="col-lg-12 aos" data-aos="fade-up">
          <div class="section-header-thirteen">
            <div class="section-inner-thirteen">
              <img src="@/assets/img/icons/atom-bond2.svg" alt="Bond" />
            </div>
            <h2>Why Choose Us?</h2>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-lg-6">
          <div class="choose-us-inner-all">
            <div class="choose-us-thirteen-img">
              <img src="@/assets/img/bg/doctor-bg.jpg" alt="Doctor" class="img-fluid" />
              <div class="choose-us-thirteen-imgone">
                <img src="@/assets/img/bg/atom-bond.png" alt="Doctor" />
                <img src="@/assets/img/bg/rainbow-2.png" alt="Doctor" />
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-6">
          <ul>
            <li v-for="item in IndexEightChoose" :key="item.id">
              <div class="choose-us-content-thirteen">
                <div class="chooseus-contents">
                  <i :class="item.Class"></i>
                </div>
                <div class="chooseus-content-ryt">
                  <h5>{{ item.Title }}</h5>
                  <p>{{ item.Content }}</p>
                </div>
              </div>
            </li>
          </ul>
        </div>
      </div>
    </div>
  </section>
  <!-- /Why Choose Us -->

  <section class="client-us-section-thirteen common-padding">
    <div class="client-us-section-thirteenone aos" data-aos="fade-right">
      <img src="@/assets/img/bg/cloud-2.png" alt="Cloud" />
      <img src="@/assets/img/bg/rainbow-2.png" alt="Rainbow" />
    </div>
    <div class="container">
      <div class="row">
        <div class="col-lg-12 aos" data-aos="fade-up">
          <div class="section-header-thirteen">
            <div class="section-inner-thirteen">
              <img src="@/assets/img/icons/atom-bond2.svg" alt="Bond" />
            </div>
            <h2>What Our Client Says?</h2>
          </div>
        </div>
      </div>
      <div class="owl-carousel client-says-thirteen owl-theme">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in IndexEightClient" :key="item.id">
            <div class="client-says-all mb-5">
              <div class="clients-says-content text-start">
                <p>"{{ item.Content }}"</p>
                <h4>
                  {{ item.Name }}
                </h4>
                <p class="location-thirteen">
                  <i class="fa-solid fa-location-dot"></i> {{ item.Location }}
                </p>
                <div class="client-says-imagesone">
                  <img src="@/assets/img/icons/rainbow-3.svg" alt="Rainbow" />
                  <img src="@/assets/img/icons/rainbow-4.svg" alt="Rainbow" />
                </div>
              </div>
              <div class="client-says-images">
                <img :src="require(`@/assets/img/${item.Image}`)" alt="img-fluid" />
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
  </section>
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import IndexEightChoose from "@/assets/json/indexeightchoose.json";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import IndexEightClient from "@/assets/json/indexeightclient.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      IndexEightChoose: IndexEightChoose,
      IndexEightClient: IndexEightClient,
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
