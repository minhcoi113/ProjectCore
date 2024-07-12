<template>
  <!-- Service Section -->
  <section class="service-section">
    <div class="container">
      <div class="row">
        <div class="col-md-12 aos" data-aos="fade-up">
          <div class="section-header-one section-header-slider">
            <h2 class="section-title">Our <span>Services</span></h2>
          </div>
        </div>
      </div>
      <div class="row row-gap aos" data-aos="fade-up">
        <div
          class="col-md-6 col-sm-12 col-lg-4"
          v-for="item in indexFiveService"
          :key="item.id"
        >
          <div class="listing-card">
            <div class="listing-img">
              <router-link to="/search"
                ><img
                  :src="require(`@/assets/img/features/${item.Image}`)"
                  class="img-fluid"
                  alt="Image"
              /></router-link>
              <div :class="['fav-item', { selected: item.favorite }]">
                <a
                  href="javascript:void(0)"
                  :class="['fav-icon', { selected: item.favorite }]"
                  @click="toggleFavorite(item)"
                >
                  <i class="fa fa-heart"></i>
                </a>
              </div>
            </div>
            <div class="listing-content">
              <div class="listing-details">
                <div class="listing-title">
                  <h3>
                    <router-link to="/search">{{ item.Title }}</router-link>
                  </h3>
                </div>
                <div class="listing-profile-details">
                  <div class="listing-user">
                    <div class="listing-profile-img">
                      <router-link to="/doctor-profile"
                        ><img
                          :src="require(`@/assets/img/doctors/${item.Doctor}`)"
                          class="img-fluid"
                          alt="Image"
                      /></router-link>
                    </div>
                    <div class="listing-user-details">
                      <span>Specialist</span>
                      <h6>
                        <router-link to="/doctor-profile">{{ item.Name }}</router-link>
                      </h6>
                    </div>
                  </div>
                  <div class="listing-btn">
                    <router-link to="/booking-2" class="btn consult-btn"
                      >Consult</router-link
                    >
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Service Section -->

  <!-- Need To Know -->
  <section class="need-to-know-section">
    <div class="floating-bg">
      <img src="@/assets/img/bg/health-care.png" alt="Image" />
    </div>
    <div class="container">
      <div class="row">
        <div class="col-lg-8 col-sm-12 aos" data-aos="fade-up">
          <div class="section-header-one section-header-slider">
            <h2 class="section-title">Need To Know <span>Cardiac Conditions</span></h2>
            <ul class="nav nav-pills" id="pills-tab" role="tablist">
              <li class="nav-item" role="presentation">
                <b-button
                  class="nav-link tag-list active"
                  id="pills-home-tab"
                  data-bs-toggle="pill"
                  data-bs-target="#content_1"
                  type="button"
                  role="tab"
                  aria-controls="content_1"
                  aria-selected="true"
                >
                  Heart valve disease
                </b-button>
              </li>
              <li class="nav-item" role="presentation">
                <b-button
                  class="nav-link tag-list"
                  id="pills-profile-tab"
                  data-bs-toggle="pill"
                  data-bs-target="#content_2"
                  type="button"
                  role="tab"
                  aria-controls="content_2"
                  aria-selected="false"
                >
                  Heart failure
                </b-button>
              </li>
              <li class="nav-item" role="presentation">
                <b-button
                  class="nav-link tag-list"
                  id="pills-contact-tab"
                  data-bs-toggle="pill"
                  data-bs-target="#content_3"
                  type="button"
                  role="tab"
                  aria-controls="content_3"
                  aria-selected="false"
                >
                  Pacemakers and defibrillators
                </b-button>
              </li>
            </ul>
            <div class="tab-content" id="pills-tabContent">
              <div
                class="tab-pane fade show active"
                id="content_1"
                role="tabpanel"
                aria-labelledby="pills-home-tab"
              >
                <div class="need-to-know-content">
                  <h3>Heart valve disease</h3>
                  <p>
                    If one of the valves in your heart becomes diseased it can affect the
                    flow of blood. This can happen in one of two ways: valve stenosis
                    (where the valve does not fully open and obstructs or restricts flow)
                    or valve incompetence (where the valve does not close properly and
                    blood is allowed to leak backwards)....
                  </p>
                  <router-link to="/booking" class="need-to-know-content-btn"
                    >Read More</router-link
                  >
                </div>
              </div>
              <div
                class="tab-pane fade"
                id="content_2"
                role="tabpanel"
                aria-labelledby="pills-profile-tab"
              >
                <div class="need-to-know-content">
                  <h3>Heart failure</h3>
                  <p>
                    If one of the valves in your heart becomes diseased it can affect the
                    flow of blood. This can happen in one of two ways: valve stenosis
                    (where the valve does not fully open and obstructs or restricts flow)
                    or valve incompetence (where the valve does not close properly and
                    blood is allowed to leak backwards)....
                  </p>
                  <router-link to="/booking" class="need-to-know-content-btn"
                    >Read More</router-link
                  >
                </div>
              </div>
              <div
                class="tab-pane fade"
                id="content_3"
                role="tabpanel"
                aria-labelledby="pills-contact-tab"
              >
                <div class="need-to-know-content">
                  <h3>Pacemakers and defibrillators</h3>
                  <p>
                    If one of the valves in your heart becomes diseased it can affect the
                    flow of blood. This can happen in one of two ways: valve stenosis
                    (where the valve does not fully open and obstructs or restricts flow)
                    or valve incompetence (where the valve does not close properly and
                    blood is allowed to leak backwards)....
                  </p>
                  <router-link to="/booking" class="need-to-know-content-btn"
                    >Read More</router-link
                  >
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-4 col-md-12 aos" data-aos="fade-up">
          <div class="gallery-box-block">
            <div class="gallery-box-left">
              <div class="box-detail mb-2">
                <img
                  src="@/assets/img/features/feature-13.jpg"
                  class="img-fluid"
                  alt="Image"
                />
              </div>
              <div class="box-detail">
                <img
                  src="@/assets/img/features/feature-14.jpg"
                  class="img-fluid"
                  alt="Image"
                />
              </div>
            </div>
            <div class="gallery-box-right">
              <div class="box-detail">
                <img
                  src="@/assets/img/features/feature-15.jpg"
                  class="img-fluid"
                  alt="Image"
                />
              </div>
              <div class="box-detail">
                <img
                  src="@/assets/img/features/feature-16.jpg"
                  class="img-fluid"
                  alt="Image"
                />
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Need To Know -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import indexFiveService from "@/assets/json/indexfiveservice.json";
export default {
  data() {
    return {
      indexFiveService: indexFiveService,
    };
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
  methods: {
    toggleFavorite(item) {
      item.favorite = !item.favorite;
    },
  },
};
</script>
