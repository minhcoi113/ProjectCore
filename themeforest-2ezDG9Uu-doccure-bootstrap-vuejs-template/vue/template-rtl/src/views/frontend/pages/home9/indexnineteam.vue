<template>
  <!-- Team Section -->
  <div class="team-section-fourteen">
    <div class="container">
      <div class="row">
        <div class="col-lg-6">
          <div class="section-header-fourteen">
            <div class="service-inner-fourteen">
              <div class="service-inner-fourteen-one"></div>
              <div class="service-inner-fourteen-two">
                <h3>Our Team</h3>
              </div>
              <div class="service-inner-fourteen-three"></div>
            </div>
            <h2>Our Qualified Doctors</h2>
          </div>
        </div>
        <div class="col-lg-6 aos" data-aos="fade-up">
          <div class="owl-nav slide-nav-14 text-end nav-control"></div>
        </div>
      </div>
      <div class="owl-carousel owl-theme team-fourteen-slider">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
          <Slide v-for="item in IndexNineTeam" :key="item.id">
            <div
              class="articles-grid articles-grid-fourteen w-100 slide-content-container"
            >
              <div class="articles-info">
                <div class="articles-left">
                  <router-link to="/doctor-profile">
                    <div class="articles-img articles-img-fourteen">
                      <img
                        :src="require(`@/assets/img/doctors/${item.Image}`)"
                        alt="Doctor"
                        class="img-fluid"
                      />
                    </div>
                  </router-link>
                </div>
                <div class="articles-right">
                  <div class="articles-content articles-content-fourteen text-end">
                    <router-link to="/doctor-profile">{{ item.Name }}</router-link>
                    <ul class="articles-list nav">
                      <li class="Qualified-doctors-fourteen">{{ item.Badge }}</li>
                      <li class="Qualified-doctors-fourteentwo">{{ item.Patients }}</li>
                    </ul>
                    <div class="rating rating-fourteen">
                      <i class="fas fa-star filled me-1"></i>
                      <i class="fas fa-star filled me-1"></i>
                      <i class="fas fa-star filled me-1"></i>
                      <i class="fas fa-star filled me-1"></i>
                      <i class="fas fa-star me-1"></i>
                      <span class="d-inline-block average-rating">{{ item.Count }}</span>
                    </div>
                    <p class="text-muted">
                      <i class="feather-map-pin"></i><span>{{ item.Min }}</span>
                      {{ item.Location }}
                    </p>
                    <ul class="articles-list nav mb-0">
                      <li class="Qualified-doctors-fourteenthree">{{ item.Price }}</li>
                      <li class="Qualified-doctors-fourteenfour">
                        <router-link to="/doctor-profile">Consult Now</router-link>
                      </li>
                    </ul>
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
    <div class="banner-imgfourteenseven">
      <img src="@/assets/img/icons/serv-img-icon-1.svg" class="img-fluid" alt="Icon" />
    </div>
    <div class="banner-imgfourteeneight">
      <img src="@/assets/img/icons/serv-img-icon-2.svg" class="img-fluid" alt="Icon" />
    </div>
    <div class="banner-imgfourteennine">
      <img src="@/assets/img/icons/serv-img-icon-2.svg" class="img-fluid" alt="Icon" />
    </div>
  </div>
  <!-- /Team Section -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import IndexNineTeam from "@/assets/json/indexnineteam.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      IndexNineTeam: IndexNineTeam,
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
          itemsToShow: 2,
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
