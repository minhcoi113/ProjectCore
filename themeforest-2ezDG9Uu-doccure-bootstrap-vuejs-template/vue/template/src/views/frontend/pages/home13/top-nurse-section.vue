<template>
  <section class="neraby-nurses-sec top-nurse-sec">
    <div class="container">
      <div class="section-head-fourteen">
        <h2>Top <span> Nurses </span></h2>
        <p>Our Qualified Nurses</p>
      </div>
      <div class="row">
        <div class="col-md-12">
          <div class="top-nurse-profile-slider owl-carousel">
            <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
              <Slide v-for="record in TopNurseSection" :key="record.id">
                <div class="nurse-profile">
                  <div class="nurse-img">
                    <router-link to="doctor-profile"
                      ><img
                        :src="require(`@/assets/img/nurses/${record.Nurse_Image}`)"
                        alt="Img"
                    /></router-link>
                    <span class="badge">{{ record.Experience }}</span>
                    <span class="fav-item img-top-item">
                      <a href="javascript:void(0)" class="fav-icon">
                        <i class="feather-heart"></i>
                      </a>
                    </span>
                    <span class="calender-icon img-top-item">
                      <a href="javascript:void(0)">
                        <i class="feather-calendar"></i>
                      </a>
                    </span>
                  </div>
                  <div class="nurse-pofile-info">
                    <div class="d-flex justify-content-between">
                      <div class="nurse-name">
                        <h5>
                          <router-link to="doctor-profile">{{ record.Name }}</router-link>
                        </h5>
                        <span>{{ record.Location }}</span>
                      </div>
                      <span
                        ><img
                          :src="require(`@/assets/img/icons/${record.Image}`)"
                          alt="Img"
                      /></span>
                    </div>
                    <div class="nurse-details">
                      <h6>
                        <span
                          ><i class="feather-thumbs-up"></i>{{ record.Percentage }}</span
                        >{{ record.Patients }}
                      </h6>
                      <span class="distance"
                        ><i class="feather-map-pin"></i>{{ record.Meter }}</span
                      >
                    </div>
                    <div class="nurse-book">
                      <div class="nurse-fees">
                        <h5>{{ record.Amount }} <span>Per day</span></h5>
                      </div>
                      <div class="book-btns">
                        <router-link to="booking-2">Book Now</router-link>
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
          <div class="owl-nav-button">
            <div class="owl-nav top-nurse-slide-nav nav-control"></div>
            <router-link to="doctor-profile" class="view-all"
              >View All Top Nurses</router-link
            >
          </div>
        </div>
      </div>
    </div>
  </section>
</template>
<script>
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import TopNurseSection from "@/assets/json/top-nurse-section.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      TopNurseSection: TopNurseSection,
      settings: {
        itemsToShow: 1,
        snapAlign: "center",
        loop: true,
      },

      breakpoints: {
        575: {
          itemsToShow: 1,
          snapAlign: "center",
        },
        // 700px and up
        767: {
          itemsToShow: 1,
          snapAlign: "center",
        },
        // 991px and up
        991: {
          itemsToShow: 3,
          snapAlign: "start",
        },
        // 1024 and up
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
};
</script>
