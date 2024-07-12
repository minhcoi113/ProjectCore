<template>
  <!-- Clinic Section -->
  <section class="clinic-specialities">
    <div class="container">
      <div class="section-header-three text-center aos" data-aos="fade-up">
        <h2>Clinic & Specialities</h2>
        <p class="sub-title">
          Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
          incididunt ut labore et dolore magna aliqua.
        </p>
      </div>
      <div class="row">
        <div
          class="col-lg-3 col-md-4 aos"
          v-for="item in indexFourClinic"
          :key="item.id"
          data-aos="fade-up"
        >
          <div class="special-box text-center">
            <div class="special-body">
              <img :src="require(`@/assets/img/shapes/${item.Image}`)" alt="Image" />
              <h4>{{ item.Title }}</h4>
              <router-link to="/booking" class="spc-book"
                >Book now <i class="fas fa-caret-right"></i>
              </router-link>
            </div>
            <div class="row row-sm special-footer">
              <div class="col-6 text-start">
                <a href="javascript:;" class="doc-count">124 <span>Doctors</span></a>
              </div>
              <div class="col-6 text-end">
                <a href="javascript:;" class="clin-count">24 <span>Clinics</span></a>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="view-all-more text-center aos" data-aos="fade-up">
        <router-link to="/doctor-profile" class="btn btn-primary">View More</router-link>
      </div>
    </div>
  </section>
  <!-- /Clinic Section -->
</template>

<script>
import AOS from "aos";
import "aos/dist/aos.css";
import indexFourClinic from "@/assets/json/indexfourclinic.json";
export default {
  data() {
    return {
      indexFourClinic: indexFourClinic,
    };
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
