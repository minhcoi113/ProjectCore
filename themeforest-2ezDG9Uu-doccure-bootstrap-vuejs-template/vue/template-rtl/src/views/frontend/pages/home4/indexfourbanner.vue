<template>
  <!-- Home Banner -->
  <section class="section-search-3">
    <div class="container">
      <div class="banner-info">
        <div class="row align-items-center">
          <div class="col-lg-4 aos" data-aos="fade-up">
            <div class="header-banner">
              <h2>
                Search Doctor, <br />
                <span class="header-highlight">Make an Appointment</span>
              </h2>
              <p>Discover the best doctors, clinic & hospital the city nearest to you.</p>
            </div>
          </div>
          <div class="col-lg-8 aos" data-aos="fade-up">
            <div class="doctor-search">
              <div class="doctor-form">
                <form action="javascript:;" class="doctor-search-form trans">
                  <div class="row">
                    <div class="col-md-6">
                      <div class="form-group">
                        <div class="form-custom">
                          <input
                            type="text"
                            class="form-control"
                            value=""
                            placeholder="Search Location"
                          />
                          <i class="far fa-compass"></i>
                        </div>
                      </div>
                    </div>
                    <div class="col-md-6">
                      <div class="form-group">
                        <div class="form-custom">
                          <input
                            type="text"
                            class="form-control"
                            value=""
                            placeholder="Gender"
                          />
                          <i class="far fa-smile"></i>
                        </div>
                      </div>
                    </div>
                    <div class="col-md-7">
                      <div class="form-group">
                        <div class="form-custom">
                          <input
                            type="text"
                            class="form-control"
                            value=""
                            placeholder="Department"
                          />
                          <i class="fas fa-user-check"></i>
                        </div>
                      </div>
                    </div>
                    <div class="col-md-5">
                      <router-link to="/search" class="btn banner-btn"
                        >MAKE APPOINTMENT</router-link
                      >
                    </div>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Home Banner -->

  <!-- category select-->
  <section class="doctor-category">
    <div class="container">
      <div class="row">
        <div
          class="col-md-4 aos"
          data-aos="fade-up"
          v-for="(item, index) in indexfourdoctorcategory"
          :key="index"
        >
          <div class="pop-box">
            <div class="top-section" :class="item.sectionClass">
              <div class="cat-icon">
                <i :class="item.iconClass"></i>
              </div>
            </div>
            <div class="body-section">
              <h3>{{ item.title }}</h3>
              <p>{{ item.description }}</p>
              <router-link to="/booking" class="btn book-btn" tabindex="0"
                >Book Now</router-link
              >
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /category select-->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import indexfourdoctorcategory from "@/assets/json/indexfourdoctorcategory.json";
export default {
  data() {
    return {
      indexfourdoctorcategory: indexfourdoctorcategory,
    };
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
