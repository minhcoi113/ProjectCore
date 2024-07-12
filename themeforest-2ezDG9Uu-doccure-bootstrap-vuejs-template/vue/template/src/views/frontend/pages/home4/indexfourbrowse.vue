<template>
  <!-- browse speciality-->
  <section class="browse-section">
    <div class="container">
      <div class="section-header-three text-center aos" data-aos="fade-up">
        <h2>Browse by Specialities</h2>
        <p class="sub-title">
          Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
          incididunt ut labore et dolore magna aliqua.
        </p>
      </div>
      <div class="row">
        <div
          class="col-lg-2 col-md-3 aos"
          v-for="item in IndexFourBrowse"
          :key="item.id"
          data-aos="fade-up"
        >
          <div class="brower-box">
            <div>
              <div class="brower-img">
                <img :src="require(`@/assets/img/shapes/${item.Image}`)" alt="Image" />
              </div>
              <h4>{{ item.Title }}</h4>
              <p>124 <span>Doctors</span></p>
            </div>
          </div>
        </div>
      </div>
      <div class="view-all-more text-center aos" data-aos="fade-up">
        <router-link to="/doctor-profile" class="btn btn-primary">View More</router-link>
      </div>
    </div>
  </section>
  <!-- /browse speciality-->
</template>

<script>
import AOS from "aos";
import "aos/dist/aos.css";
import IndexFourBrowse from "@/assets/json/indexfourbrowse.json";
export default {
  data() {
    return {
      IndexFourBrowse: IndexFourBrowse,
    };
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
