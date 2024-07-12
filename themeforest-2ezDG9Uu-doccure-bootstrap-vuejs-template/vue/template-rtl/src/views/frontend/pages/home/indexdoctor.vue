<template>
  <!-- Doctors Section -->
  <section class="doctors-section">
    <div class="container">
      <div class="row">
        <div class="col-md-6 aos" data-aos="fade-up">
          <div class="section-header-one section-header-slider">
            <h2 class="section-title">Best Doctors</h2>
          </div>
        </div>
        <div class="col-md-6 aos" data-aos="fade-up">
          <div class="owl-nav slide-nav-2 text-end nav-control"></div>
        </div>
      </div>
      <div class="owl-carousel doctor-slider-one owl-theme aos" data-aos="fade-up">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in IndexDoctor" :key="item.id">
            <div class="item slide-content-container">
              <div class="doctor-profile-widget">
                <div class="doc-pro-img">
                  <router-link to="/doctor-profile">
                    <div class="doctor-profile-img">
                      <img
                        :src="require(`@/assets/img/doctors/${item.Image}`)"
                        class="img-fluid"
                        alt="Image"
                      />
                    </div>
                  </router-link>
                  <div class="doctor-amount">
                    <span>{{ item.Badge }}</span>
                  </div>
                </div>
                <div class="doc-content">
                  <div class="doc-pro-info">
                    <div class="doc-pro-name">
                      <router-link to="/doctor-profile">{{ item.Name }}</router-link>
                      <p>{{ item.Text }}</p>
                    </div>
                    <div class="reviews-ratings">
                      <p>
                        <span><i class="fas fa-star"></i> {{ item.Star }}</span>
                        {{ item.Rateing }}
                      </p>
                    </div>
                  </div>
                  <div class="doc-pro-location">
                    <p><i class="feather-map-pin"></i> {{ item.Location }}</p>
                  </div>
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
  <!-- /Doctors Section -->

  <!-- Pricing -->
  <section class="pricing-section">
    <div class="container">
      <div class="row">
        <div class="col-md-12 text-center aos" data-aos="fade-up">
          <div class="section-header-one">
            <h2 class="section-title">Pricing Plan</h2>
          </div>
        </div>
      </div>
      <div class="row justify-content-center align-items-center">
        <div class="col-lg-4 col-sm-12 aos" data-aos="fade-up">
          <div class="card pricing-card">
            <div class="card-body">
              <div class="pricing-header">
                <div class="pricing-header-info">
                  <div class="pricing-icon">
                    <span>
                      <img src="@/assets/img/icons/price-icon1.svg" alt="icon" />
                    </span>
                  </div>
                  <div class="pricing-title">
                    <p>For individuals</p>
                    <h4>Basic</h4>
                  </div>
                </div>
                <div class="pricing-header-text">
                  <p>
                    Lorem ipsum dolor consectetur adipiscing elit,sed do eiusmod tempor
                  </p>
                </div>
              </div>
              <div class="pricing-info">
                <div class="pricing-amount">
                  <h2>$99 <span>/monthly</span></h2>
                  <h6>What’s included</h6>
                </div>
                <div class="pricing-list">
                  <ul>
                    <li>Lorem ipsum dolor amet, consectetur</li>
                    <li>Lorem ipsum amet, consectetur</li>
                    <li>Lorem ipsum dolor amet, consectetur</li>
                    <li>Lorem ipsum amet, consectetur</li>
                  </ul>
                </div>
                <div class="pricing-btn">
                  <router-link to="/login-email" class="btn">Choose Plan</router-link>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-4 col-sm-12 aos" data-aos="fade-up">
          <div class="card pricing-card pricing-card-active">
            <div class="card-body">
              <div class="pricing-header">
                <div class="pricing-header-info">
                  <div class="pricing-icon">
                    <span>
                      <img src="@/assets/img/icons/price-icon2.svg" alt="icon" />
                    </span>
                  </div>
                  <div class="pricing-title">
                    <p>For startups</p>
                    <h4>Pro</h4>
                  </div>
                  <div class="pricing-tag">
                    <span>Popular</span>
                  </div>
                </div>
                <div class="pricing-header-text">
                  <p>
                    Lorem ipsum dolor consectetur adipiscing elit,sed do eiusmod tempor
                  </p>
                </div>
              </div>
              <div class="pricing-info">
                <div class="pricing-amount">
                  <h2>$199 <span>/monthly</span></h2>
                  <h6>What’s included</h6>
                </div>
                <div class="pricing-list">
                  <ul>
                    <li>Lorem ipsum dolor amet, consectetur</li>
                    <li>Lorem ipsum amet, consectetur</li>
                    <li>Neque porro quisquam est, qui dolorem</li>
                    <li>Lorem ipsum dolor amet, consectetur</li>
                    <li>Lorem ipsum amet, consectetur</li>
                    <li>Sed ut perspiciatis unde</li>
                    <li>Nemo enim ipsam voluptatem</li>
                  </ul>
                </div>
                <div class="pricing-btn">
                  <router-link to="/login-email" class="btn">Choose Plan</router-link>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-4 col-sm-12 aos" data-aos="fade-up">
          <div class="card pricing-card">
            <div class="card-body">
              <div class="pricing-header">
                <div class="pricing-header-info">
                  <div class="pricing-icon">
                    <span>
                      <img src="@/assets/img/icons/price-icon3.svg" alt="icon" />
                    </span>
                  </div>
                  <div class="pricing-title">
                    <p>For big companies</p>
                    <h4>Enterprise</h4>
                  </div>
                </div>
                <div class="pricing-header-text">
                  <p>
                    Lorem ipsum dolor consectetur adipiscing elit,sed do eiusmod tempor
                  </p>
                </div>
              </div>
              <div class="pricing-info">
                <div class="pricing-amount">
                  <h2>$399 <span>/monthly</span></h2>
                  <h6>What’s included</h6>
                </div>
                <div class="pricing-list">
                  <ul>
                    <li>Lorem ipsum dolor amet, consectetur</li>
                    <li>Lorem ipsum amet, consectetur</li>
                    <li>Lorem ipsum dolor amet, consectetur</li>
                    <li>Lorem ipsum amet, consectetur</li>
                  </ul>
                </div>
                <div class="pricing-btn">
                  <router-link to="/login-email" class="btn">Choose Plan</router-link>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Pricing -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import IndexDoctor from "@/assets/json/indexdoctor.json";
import "vue3-carousel/dist/carousel.css";

export default {
  data() {
    return {
      IndexDoctor: IndexDoctor,
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
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
  components: {
    Carousel,
    Slide,
    Pagination,
    Navigation,
  },
};
</script>
