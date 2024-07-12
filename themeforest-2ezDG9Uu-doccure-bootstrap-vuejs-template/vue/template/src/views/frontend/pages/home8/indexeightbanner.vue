<template>
  <!-- Home Banner -->
  <section class="banner-section-thirteen common-padding aos" data-aos="fade-down">
    <div class="container">
      <div class="row">
        <div class="col-lg-12">
          <div class="banner-content aos" data-aos="fade-up">
            <h4>We specialize in Paediatric Care</h4>
            <h1>A Safe Care for your children’s health</h1>
            <p>
              Supporting you to keep your child healthy with easy access to high-quality
              paediatric care.
            </p>
            <div class="banner-btns-fourteen">
              <router-link to="/search" class="btn btn-primary">Know More</router-link>
            </div>
          </div>
        </div>
        <div class="col-lg-12">
          <div class="banner-center-img d-flex justify-content-center">
            <img src="@/assets/img/bg/home-13-banner-img.png" alt="Banner Image" />
          </div>
        </div>
        <div class="col-lg-12">
          <div class="search-box-one search-box-thirteen aos" data-aos="fade-up">
            <div class="search-title">
              <h5>Fix Appointment</h5>
            </div>
            <form @submit.prevent="submitForm">
              <div class="search-input search-calendar-line-thirteen">
                <i class="feather-calendar"></i>
                <div class="mb-0">
                  <datepicker
                    v-model="startdate"
                    placeholder="Date"
                    class="form-control datetimepicker"
                    :editable="true"
                    :clearable="false"
                  />
                </div>
              </div>
              <div class="search-input search-line-thirteen">
                <i class="feather-user"></i>
                <vue-select :options="Lang" placeholder="English" />
              </div>
              <div class="search-input search-map-line-thirteen">
                <i class="feather-map-pin"></i>
                <div class="mb-0">
                  <input type="text" class="form-control" placeholder="Location" />
                  <a class="current-loc-icon current_location" href="javascript:void(0);">
                  </a>
                </div>
              </div>
              <div class="search-input search-users-line-thirteen">
                <i class="feather-users"></i>
                <vue-select :options="Lang" placeholder="English" />
              </div>
              <div class="form-search-btn">
                <b-button class="btn" type="submit"
                  >See Availability<i class="feather-arrow-right ms-2"></i
                ></b-button>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
    <div class="banner-section-thirteen-bg">
      <div class="banner-section-thirteen-bg-one">
        <img src="@/assets/img/bg/pluse-1.png" alt="Pluse" />
      </div>
      <div class="banner-section-thirteen-bg-two">
        <img src="@/assets/img/bg/pluse-2.png" alt="Pluse" />
      </div>
      <div class="banner-section-thirteen-bg-three">
        <img src="@/assets/img/bg/pluse-4.png" alt="Pluse" />
      </div>
      <div class="banner-section-thirteen-bg-four">
        <img src="@/assets/img/bg/pluse-3.png" alt="Pluse" />
      </div>
      <div class="banner-section-thirteen-bg-five">
        <img src="@/assets/img/bg/pluse-3.png" alt="Pluse" />
      </div>
      <div class="banner-section-thirteen-bg-six">
        <img src="@/assets/img/bg/pulse-6.png" alt="Pluse" />
      </div>
      <div class="banner-section-thirteen-bg-seven">
        <img src="@/assets/img/bg/gold-star.png" alt="Pluse" />
      </div>
      <div class="banner-section-thirteen-bg-eight">
        <img src="@/assets/img/bg/pink-star.png" alt="Pluse" />
      </div>
      <div class="banner-section-thirteen-bg-nine">
        <img src="@/assets/img/bg/atom-bond.png" alt="Pluse" />
      </div>
      <div class="banner-section-thirteen-bg-ten">
        <img src="@/assets/img/bg/pulse-7.png" alt="Pluse" />
      </div>
      <div class="banner-section-thirteen-bg-eleven">
        <img src="@/assets/img/bg/atom-bond.png" alt="Pluse" />
      </div>
      <div class="banner-section-thirteen-bg-thirteen">
        <img src="@/assets/img/bg/pluse-white.png" alt="Pluse" />
      </div>
      <div class="banner-section-thirteen-bg-fourteen">
        <img src="@/assets/img/bg/star-1.png" alt="Star" class="img-fluid" />
      </div>
      <div class="banner-section-thirteen-bg-fifteen aos" data-aos="fade-left">
        <img src="@/assets/img/bg/cloud-1.png" alt="Cloud" />
      </div>
      <div class="banner-section-thirteen-bg-sixteen aos" data-aos="fade-right">
        <img src="@/assets/img/bg/cloud-2.png" alt="Cloud" />
      </div>
      <div class="banner-section-thirteen-bg-seventeen">
        <a href="javascript:">Trained paediatric doctors</a>
      </div>
      <div class="banner-section-thirteen-bg-eighteen">
        <a href="javascript:">New Born Care</a>
      </div>
      <div class="banner-section-thirteen-bg-ninteen">
        <a href="javascript:">Child care treatments</a>
      </div>
      <div class="banner-section-thirteen-bg-twenty">
        <img src="@/assets/img/bg/baby-star.png" alt="Star" />
      </div>
      <div class="banner-section-thirteen-bgs">
        <img src="@/assets/img/bg/heart-1.png" alt="Star" />
      </div>
    </div>
  </section>
  <!-- /Home Banner -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { ref } from "vue";
const currentDate = ref(new Date());
export default {
  data() {
    return {
      Lang: ["English", "Spanish", "Mexico"],
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
      this.$router.push("/search-2");
    },
  },
};
</script>
