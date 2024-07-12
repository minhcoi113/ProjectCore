<template>
  <!-- Home Banner -->
  <section class="banner-section-fourteen">
    <div class="container">
      <div class="row">
        <div class="col-lg-6">
          <div class="banner-content banner-content-fourteen aos" data-aos="fade-up">
            <h1>The Best Solutions, Experts and Care For Your Pregnancy</h1>
            <div class="banner-btns-fourteen">
              <router-link to="/booking" class="btn btn-primary me-2"
                >Meet Our Specialist</router-link
              >
              <router-link to="/booking-2" class="btn btn-primarytwo"
                >Schedule a Call</router-link
              >
            </div>
          </div>
          <div class="search-box-fourteen aos" data-aos="fade-up">
            <form @submit.prevent="submitForm" class="form-block d-flex">
              <div class="search-input">
                <div class="forms-block">
                  <label class="mb-2">Date</label>
                  <datepicker
                    v-model="startdate"
                    placeholder="Date"
                    class="form-control datetimepicker"
                    :editable="true"
                    :clearable="false"
                  />
                </div>
              </div>
              <div class="search-input">
                <div class="forms-block mb-0">
                  <label class="mb-2">Location</label>
                  <input
                    type="text"
                    class="form-control"
                    placeholder="San Diego Branch"
                  />
                </div>
              </div>
              <div class="search-btn">
                <b-button variant="primary" type="submit">Book Now</b-button>
              </div>
            </form>
          </div>
        </div>
        <div class="col-lg-6">
          <div class="banner-img banner-img-fourteen aos" data-aos="fade-up">
            <img src="@/assets/img/banner-six-2.png" class="img-fluid" alt="Banner" />
            <div class="banner-img1 banner-imgfourteen">
              <img
                src="@/assets/img/icons/ban-six-icon1.svg"
                class="img-fluid"
                alt="Icon"
              />
            </div>
            <div class="banner-img2">
              <img
                src="@/assets/img/icons/ban-six-icon3.svg"
                class="img-fluid"
                alt="Icon"
              />
            </div>
            <div class="banner-img3 banner-imgfourteen3">
              <img
                src="@/assets/img/icons/ban-six-icon2.svg"
                class="img-fluid"
                alt="Icon"
              />
            </div>
            <div class="banner-imgfourteen4">
              <img
                src="@/assets/img/icons/ban-img-icon-4.svg"
                class="img-fluid"
                alt="Icon"
              />
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="banner-imgfourteen5">
      <img src="@/assets/img/icons/ban-img-icon5.svg" class="img-fluid" alt="Icon" />
    </div>
    <div class="banner-imgfourteen6">
      <img src="@/assets/img/icons/ban-img-icon6.svg" class="img-fluid" alt="Icon" />
    </div>
  </section>
  <!-- /Home Banner -->

  <!-- services Section -->
  <section class="services-section-fourteen">
    <div class="container">
      <div class="row">
        <div class="col-lg-6 aos" data-aos="fade-up">
          <div class="section-header-fourteen service-inner-fourteen">
            <div class="service-inner-fourteen">
              <div class="service-inner-fourteen-one"></div>
              <div class="service-inner-fourteen-two">
                <h3>Our Services</h3>
              </div>
              <div class="service-inner-fourteen-three"></div>
            </div>
            <h2>Best Quality Services for you</h2>
          </div>
          <div class="service-inner-img-fourt-all">
            <div class="service-inner-img-fourt">
              <img src="@/assets/img/services-six-1.png" alt="Image" class="img-fluid" />
            </div>
            <div class="service-inner-img-fourtone">
              <img
                src="@/assets/img/icons/serv-img-icon-2.svg"
                class="img-fluid"
                alt="Icon"
              />
            </div>
            <div class="service-inner-img-fourttwo">
              <img
                src="@/assets/img/icons/serv-img-icon-1.svg"
                class="img-fluid"
                alt="Icon"
              />
            </div>
            <div class="service-inner-img-fourtthree">
              <img
                src="@/assets/img/icons/serv-img-icon-3.svg"
                class="img-fluid"
                alt="Icon"
              />
            </div>
          </div>
        </div>
        <div class="col-lg-6 aos" data-aos="fade-up">
          <div class="row justify-content-center">
            <div
              class="col-lg-6 col-md-4 col-sm-6"
              v-for="item in IndexNightServices"
              :key="item.id"
            >
              <div class="card service-inner-fourt-all">
                <div class="card-body service-inner-fourt-main">
                  <div class="service-inner-right-fourt">
                    <router-link to="/patient-details">
                      <div class="service-inner-right-img">
                        <img :src="require(`@/assets/img/${item.Image}`)" alt="image" />
                      </div>
                    </router-link>
                    <router-link
                      to="/patient-details"
                      class="service-inner-right-fourt-care"
                      >{{ item.Title }}</router-link
                    >
                    <p>{{ item.Content }}</p>
                    <router-link
                      to="/patient-details"
                      class="service-inner-right-fourt-caretwo"
                      >Learn More <i class="fa-solid fa-arrow-right ms-2"></i
                    ></router-link>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="btn-sec-fourteen">
            <router-link to="/patient-profile" class="btn btn-primary btns-view"
              >View All Services</router-link
            >
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /services Section -->
</template>
<script>
import { ref } from "vue";
const currentDate = ref(new Date());
import AOS from "aos";
import "aos/dist/aos.css";
import IndexNightServices from "@/assets/json/indexnineservices.json";
export default {
  data() {
    return {
      IndexNightServices: IndexNightServices,
      startdate: currentDate,
    };
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
  methods: {
    submitForm() {
      this.$router.push("/doctor-search-list");
    },
  },
};
</script>
