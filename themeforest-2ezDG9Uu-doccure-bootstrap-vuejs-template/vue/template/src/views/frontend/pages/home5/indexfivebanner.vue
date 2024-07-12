<template>
  <!-- Home Banner -->
  <section class="banner-section">
    <div class="container">
      <div class="row align-items-center">
        <div class="col-lg-7">
          <div class="banner-content aos" data-aos="fade-up">
            <h6>
              <img src="@/assets/img/icons/heart-2.svg" class="me-2" alt="Image" />Every
              Beat, Every Moment
            </h6>
            <h1>Preventive Care Is Essential For <br /><span>Healthy Heart</span></h1>
            <p>
              We can guide you through issues like Cardiac arrest, Heart Failure,
              Peripheral Artery Disease, Arrhythmia, Atrial Fibrillation, Cholesterol and
              High BP.
            </p>
            <router-link to="/booking" class="btn plan-btn">Start a Consult</router-link>
            <router-link to="/booking" class="btn">Click Our Plan</router-link>
          </div>
        </div>
        <div class="col-lg-5">
          <div class="banner-img aos" data-aos="fade-up">
            <img
              src="@/assets/img/bg/home-10-banner-img.png"
              class="img-fluid"
              alt="Image"
            />
            <img src="@/assets/img/bg/heart-bg.png" class="img-fluid" alt="Image" />
          </div>
        </div>
        <div class="col-md-12">
          <div class="search-box-one search-ten aos" data-aos="fade-up">
            <div class="search-title">
              <h5>Book An Apppointment</h5>
              <img src="@/assets/img/icons/health-care-1.svg" alt="Image" />
            </div>
            <form @submit.prevent="submitForm">
              <div class="row row-gap">
                <div class="col-lg-3 col-md-12">
                  <div class="search-input-ten">
                    <span><i class="fa-solid fa-location-dot"></i></span>
                    <div class="forms-block mb-0">
                      <input type="text" class="form-control" placeholder="Location" />
                    </div>
                  </div>
                </div>
                <div class="col-lg-3 col-md-12">
                  <div class="search-input-ten">
                    <span><i class="fa-solid fa-calendar-minus"></i></span>
                    <div class="forms-block mb-0">
                      <datepicker
                        v-model="startdate"
                        placeholder="Date"
                        class="form-control datetimepicker"
                        :editable="true"
                        :clearable="false"
                      />
                    </div>
                  </div>
                </div>
                <div class="col-lg-4 col-md-12">
                  <div class="search-input-ten">
                    <span><i class="fa-solid fa-magnifying-glass"></i></span>
                    <div class="forms-block mb-0">
                      <input
                        type="text"
                        class="form-control"
                        placeholder="Search Doctor"
                      />
                    </div>
                  </div>
                </div>
                <div class="col-lg-2 col-md-12">
                  <div class="form-search-btn search-btn-ten w-100">
                    <b-button class="btn" type="submit">Search</b-button>
                  </div>
                </div>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Home Banner -->

  <!-- Specialities Section -->
  <section class="specialities-section-one">
    <div class="floating-bg">
      <img src="@/assets/img/bg/health-care.png" alt="Image" />
    </div>
    <div class="container">
      <div class="row">
        <div class="col-md-12 aos" data-aos="fade-up">
          <div class="section-header-one section-header-slider">
            <h2 class="section-title">Why <span>Doccure?</span></h2>
          </div>
        </div>
      </div>
      <div class="specialities-block aos" data-aos="fade-up">
        <ul>
          <li v-for="(speciality, index) in indexfivespecialities" :key="index">
            <div class="specialities-item">
              <div class="specialities-img">
                <div class="hexogen">
                  <img
                    :src="require(`@/assets/img/icons/${speciality.imageSrc}`)"
                    :alt="speciality.altText"
                  />
                </div>
              </div>
              <p>{{ speciality.title }}</p>
            </div>
          </li>
        </ul>
      </div>
    </div>
  </section>
  <!-- /Specialities Section -->
</template>

<script>
import { ref } from "vue";
const currentDate = ref(new Date());
import AOS from "aos";
import "aos/dist/aos.css";
import indexfivespecialities from "@/assets/json/indexfivespecialities.json";
export default {
  data() {
    return {
      startdate: currentDate,
      indexfivespecialities: indexfivespecialities,
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
