<template>
  <!-- Choose us -->
  <section class="choose-us-fourteen">
    <div class="container">
      <div class="row">
        <div class="col-md-12">
          <div class="section-header-fourteen text-center">
            <div class="service-inner-fourteen justify-content-center">
              <div class="service-inner-fourteen-one"></div>
              <div class="service-inner-fourteen-two">
                <h3>Why Us</h3>
              </div>
              <div class="service-inner-fourteen-three"></div>
            </div>
            <h2>Why Choose Us</h2>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-lg-6">
          <div class="you-get-list">
            <ul>
              <li v-for="item in IndexNineChoose" :key="item.id">
                <div :class="item.class">
                  <div class="get-icon">
                    <img
                      :src="require(`@/assets/img/icons/${item.Image}`)"
                      alt="Icon"
                      class="img-fluid"
                    />
                  </div>
                  <div class="get-icon-right">
                    <h3>{{ item.Title }}</h3>
                    <p>{{ item.Content }}</p>
                  </div>
                </div>
              </li>
            </ul>
          </div>
        </div>
        <div class="col-lg-6">
          <div class="choose-us-right-main">
            <img src="@/assets/img/choose-us-six.png" alt="image" class="img-fluid" />
            <div class="banner-imgfourteenten">
              <img
                src="@/assets/img/icons/serv-img-icon-1.svg"
                class="img-fluid"
                alt="Icon"
              />
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Choose us -->

  <!-- Feedback -->
  <section class="clients-section-fourteen">
    <div class="container">
      <div class="row">
        <div class="col-lg-6">
          <div class="client-inner-main">
            <img src="@/assets/img/feedback-six.png" alt="image" class="img-fluid" />
          </div>
        </div>
        <div class="col-lg-6">
          <div class="section-header-fourteen text-end">
            <div class="service-inner-fourteen justify-content-end">
              <div class="service-inner-fourteen-one"></div>
              <div class="service-inner-fourteen-two">
                <h3>Happy Clients</h3>
              </div>
              <div class="service-inner-fourteen-three"></div>
            </div>
            <h2>Our Clients Feedback About Us</h2>
          </div>
          <div
            class="owl-carousel feedback-slider-fourteen owl-theme aos"
            data-aos="fade-up"
          >
            <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
              <Slide v-for="item in IndexNineFeedback" :key="item.id">
                <div class="card feedback-card">
                  <div class="card-body feedback-card-body">
                    <div class="feedback-inner-main text-end">
                      <div class="feedback-inner-img">
                        <h6>{{ item.Day }}</h6>
                        <img
                          :src="require(`@/assets/img/clients/${item.Image}`)"
                          alt="image"
                          class="img-fluid"
                        />
                      </div>
                      <div class="rating rating-fourteen">
                        <i class="fas fa-star filled me-1"></i>
                        <i class="fas fa-star filled me-1"></i>
                        <i class="fas fa-star filled me-1"></i>
                        <i class="fas fa-star filled me-1"></i>
                        <i class="fas fa-star"></i>
                      </div>
                      <p>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do
                        eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut
                        enim ad minim veniam, quis nostrud exercitation ullamco laboris
                        nisi ut aliquip ex ea commodo consequat.
                      </p>
                      <h4>{{ item.Name }}</h4>
                      <h6>{{ item.Location }}</h6>
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
      </div>
    </div>
  </section>
  <!-- /Feedback -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import IndexNineChoose from "@/assets/json/indexninechoose.json";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import IndexNineFeedback from "@/assets/json/indexninefeedback.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      IndexNineChoose: IndexNineChoose,
      IndexNineFeedback: IndexNineFeedback,
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
