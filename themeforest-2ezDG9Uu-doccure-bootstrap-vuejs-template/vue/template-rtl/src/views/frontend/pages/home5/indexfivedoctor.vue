<template>
  <!-- Our Doctor -->
  <section class="our-doctor-section">
    <div class="section-floating-bg">
      <img src="@/assets/img/bg/hexagen-group-1.png" alt="Image" />
      <img src="@/assets/img/bg/hexagon-group-2.png" alt="Image" />
    </div>
    <div class="container">
      <div class="row">
        <div class="col-md-12 aos" data-aos="fade-up">
          <div class="section-header-one section-header-slider">
            <h2 class="section-title">Our Specialist <span>Doctors</span></h2>
          </div>
        </div>
      </div>
      <div class="row row-gap justify-content-center aos" data-aos="fade-up">
        <div
          class="col-md-4 col-sm-12 col-lg-3"
          v-for="item in indexFiveDoctor"
          :key="item.id"
        >
          <div class="module-border-wrap">
            <div class="listing-card">
              <div class="listing-img">
                <router-link to="/doctor-profile"
                  ><img
                    :src="require(`@/assets/img/doctors/${item.Image}`)"
                    class="img-fluid"
                    alt="Image"
                /></router-link>
                <div :class="['fav-item', { selected: item.favorite }]">
                  <div class="featured-rating">
                    <i class="fa fa-star"></i> <span>4.5</span>
                  </div>
                  <a
                    href="javascript:void(0)"
                    class="fav-icon"
                    :class="['fav-icon', { selected: item.favorite }]"
                    @click="toggleFavorite(item)"
                  >
                    <i class="fa fa-heart"></i>
                  </a>
                </div>
              </div>
              <div class="listing-content">
                <div class="listing-details">
                  <div class="listing-category">
                    <a
                      class="listing-category-tag tag-green"
                      v-if="item.Badge === 'Cardiology'"
                      >{{ item.Badge }}</a
                    >
                    <a
                      class="listing-category-tag tag-red"
                      v-else-if="item.Badge === 'Hypertension'"
                      >{{ item.Badge }}</a
                    >
                    <a
                      class="listing-category-tag tag-green"
                      v-if="item.Badge1 === 'Cardiology'"
                      >{{ item.Badge1 }}</a
                    >
                    <a
                      class="listing-category-tag tag-purple"
                      v-if="item.Badge1 === 'physiology'"
                      >{{ item.Badge1 }}</a
                    >
                  </div>
                  <div class="listing-profile-details">
                    <div class="listing-floating-img">
                      <img src="@/assets/img/bg/ecg-wave.png" alt="Image" />
                    </div>
                    <div class="listing-user">
                      <div class="listing-user-details">
                        <h6>
                          <router-link to="/doctor-profile">{{ item.Name }}</router-link>
                        </h6>
                        <span>{{ item.Text }}</span>
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
    </div>
  </section>
  <!-- /Our Doctor -->

  <!-- Steps To Follow-->
  <section class="need-to-know-section steps-to-follow">
    <div class="floating-bg">
      <img src="@/assets/img/bg/health-care.png" alt="Image" />
    </div>
    <div class="container">
      <div class="row align-items-center">
        <div class="col-lg-5 col-md-12 aos" data-aos="fade-up">
          <div class="gallery-box-block">
            <div class="gallery-box-right">
              <div class="box-detail" v-for="step in stepsRight" :key="step.id">
                <div class="steps-list-box">
                  <div class="steps-list-img">
                    <span>{{ step.number }}</span>
                    <img
                      :src="require(`@/assets/img/icons/hreat-pulse.svg`)"
                      class="img-fluid"
                      alt="Image"
                    />
                  </div>
                  <h6>{{ step.title }}</h6>
                  <p>{{ step.description }}</p>
                </div>
              </div>
            </div>
            <div class="gallery-box-left">
              <div class="box-detail mb-4" v-for="step in stepsLeft" :key="step.id">
                <div class="steps-list-box">
                  <div class="steps-list-img">
                    <span>{{ step.number }}</span>
                    <img
                      :src="require(`@/assets/img/icons/hreat-pulse.svg`)"
                      class="img-fluid"
                      alt="Image"
                    />
                  </div>
                  <h6>{{ step.title }}</h6>
                  <p>{{ step.description }}</p>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-7 col-md-12 aos" data-aos="fade-up">
          <div class="section-header-one section-header-slider">
            <h2 class="section-title">Easy Steps For <span>New Patients</span></h2>
            <div class="need-to-know-content">
              <p>
                If one of the valves in your heart becomes diseased it can affect the flow
                of blood. This can happen in one of two ways: valve stenosis (where the
                valve does not fully open and obstructs or restricts flow) or valve
                incompetence (where the valve does not close properly and blood is allowed
                to leak backwards)....
              </p>
              <div class="content-btn-block d-flex">
                <router-link to="/booking" class="need-to-know-content-btn book-btn me-2"
                  >Book Appointment</router-link
                >
                <router-link to="/pricing" class="need-to-know-content-btn"
                  >Click Our Plan</router-link
                >
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Steps To Follow -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import indexFiveDoctor from "@/assets/json/indexfivedoctor.json";
export default {
  data() {
    return {
      indexFiveDoctor: indexFiveDoctor,
      stepsRight: [
        {
          id: 1,
          number: 1,
          title: "Choose Your Doctor",
          description: "Lorem Ipsum is simply dummy text of the printing..",
        },
        {
          id: 3,
          number: 3,
          title: "Consult with doctor",
          description: "Lorem Ipsum is simply dummy text of the printing..",
        },
      ],
      stepsLeft: [
        {
          id: 2,
          number: 2,
          title: "Set Appointment",
          description: "Lorem Ipsum is simply dummy text of the printing..",
        },
        {
          id: 4,
          number: 4,
          title: "Get recommendation",
          description: "Lorem Ipsum is simply dummy text of the printing..",
        },
      ],
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
