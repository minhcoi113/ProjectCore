<template>
  <!-- Home Banner -->
  <section class="banner-section-fifteen">
    <div class="container">
      <div class="row">
        <div class="col-lg-7">
          <div class="banner-content banner-content-fifteen aos" data-aos="fade-up">
            <h2>Painless, Safe Service</h2>
            <h1>Hear what you have been Missing</h1>
            <div class="banner-btns-fifteen">
              <router-link to="appointments" class="btn btn-primary me-2"
                >Make an Appointment</router-link
              >
              <router-link to="booking" class="btn btn-primary btns-primarytwo"
                >Quick Consultation</router-link
              >
            </div>
            <div class="aboutus-companyimg">
              <a href="javascript:;">
                <img
                  src="@/assets/img/banner-fifteen-vd.jpg"
                  alt="image"
                  class="img-fluid"
                />
              </a>
              <a
                href="javascript:void(0);"
                data-bs-toggle="modal"
                data-bs-target="#video"
              >
                <div class="playicon">
                  <span>
                    <i class="fa-solid fa-play"></i>
                  </span>
                </div>
              </a>
            </div>
            <div class="watch-video-fifteen">
              <img src="@/assets/img/icons/fifteen-play.svg" alt="Play" />
              <h6>Watch Video About Us</h6>
            </div>
            <div class="support-consult-main">
              <div class="support-consult">
                <div class="support-consult-img">
                  <img src="@/assets/img/icons/customer-service-2.svg" alt="Service" />
                </div>
                <div class="support-consult-right">
                  <h6>24/7 Support</h6>
                  <div class="rating rating-fifteen">
                    <i class="fas fa-star filled me-1"></i>
                    <i class="fas fa-star filled me-1"></i>
                    <i class="fas fa-star filled me-1"></i>
                    <i class="fas fa-star filled me-1"></i>
                    <i class="fas fa-star"></i>
                  </div>
                </div>
              </div>
              <div class="support-consult">
                <div class="support-consult-img">
                  <img src="@/assets/img/icons/customer-service-1.svg" alt="Service" />
                </div>
                <div class="support-consult-right">
                  <h6>Online Consultation</h6>
                  <span>Just 60 Secs</span>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-5">
          <div class="banner-right-fifteen">
            <img
              src="@/assets/img/banner-fifteen-ryt.png"
              alt="image"
              class="img-fluid"
            />
            <div v-for="icon in indextenbanner" :key="icon.id" :class="icon.class">
              <img :src="require(`@/assets/img/${icon.src}`)" :alt="icon.alt" />
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Home Banner -->

  <!-- services Section -->
  <section class="services-section-fifteen">
    <div class="service-bg-icon">
      <img src="@/assets/img/serive-bg-icon.png" alt="Icon" />
    </div>
    <div class="container">
      <div class="row">
        <div class="col-md-12">
          <div class="section-header-fifteen text-center">
            <h2>Our <span>Services</span></h2>
            <p>
              Our goal is to give the patient maximum relief within minimal pain inflicted
            </p>
          </div>
        </div>
      </div>
      <div class="row justify-content-center">
        <div
          class="col-lg-4 col-md-6"
          v-for="service in indextenservice"
          :key="service.id"
        >
          <div class="item">
            <div class="doctor-profile-widget-fifteen">
              <div class="doc-pro-img">
                <router-link to="doctor-profile">
                  <div class="doctor-profile-img">
                    <img
                      :src="require(`@/assets/img/service/${service.imageSrc}`)"
                      class="img-fluid"
                      alt="Service"
                    />
                  </div>
                </router-link>
              </div>
              <div class="doc-content-bottom">
                <div class="doc-content-split">
                  <router-link to="doctor-profile">{{ service.name }}</router-link>
                  <span>{{ service.numServices }}+ Services</span>
                </div>
                <p>{{ service.description }}</p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /services Section -->

  <!-- Patients Section -->
  <div class="Patients-section-fifteen">
    <div class="patient-fifteen-icon">
      <img src="@/assets/img/fifteen-bg-icon-3.png" alt="Icon" />
    </div>
    <div class="container">
      <div class="row">
        <div class="col-lg-6">
          <div class="patients-left-front patients-left-img">
            <img
              src="@/assets/img/patients-img-fifteen.png"
              alt="Patients"
              class="img-fluid"
            />
          </div>
        </div>
        <div class="col-lg-6">
          <div class="section-header-fifteen section-header-fifteenpatient">
            <h2>Who <span>We Are</span></h2>
            <p>
              Our goal is to give the patient maximum relief within minimal pain inflicted
            </p>
          </div>
          <p>
            Lorem Ipsum is simply dummy text of the printing and typesetting industry.
            Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
            when an unknown printer took a galley of type and scrambled it to make a type
            specimen book. It has survived not only five centuries
          </p>
          <p>
            It is a long established fact that a reader will be distracted by the readable
            content of a page when looking at its layout. The point of using Lorem Ipsum
            is that it has a more-or-less normal distribution of letters
          </p>
          <div class="row">
            <div class="col-md-4">
              <div class="service-patient-inflict">
                <div class="service-patient-inflictimg">
                  <span>
                    <img src="@/assets/img/icons/we-are-icon1.svg" alt="Icon" />
                  </span>
                </div>
                <div class="clients-fifteen-span">
                  <h3 class="counter">
                    <vue3-autocounter
                      ref="counter"
                      :startAmount="500"
                      :delay="3"
                      :endAmount="14500"
                      :duration="5"
                      separator=","
                      :autoinit="true"
                    />
                  </h3>
                </div>
                <h6>ENT Surgery</h6>
              </div>
            </div>
            <div class="col-md-4">
              <div class="service-patient-inflict">
                <div class="service-patient-inflictimg">
                  <span>
                    <img src="@/assets/img/icons/we-are-icon2.svg" alt="Icon" />
                  </span>
                </div>
                <div class="clients-fifteen-span">
                  <h3 class="counter">
                    <vue3-autocounter
                      ref="counter"
                      :startAmount="500"
                      :delay="3"
                      :endAmount="50000"
                      :duration="5"
                      separator=","
                      :autoinit="true"
                    />
                  </h3>
                  <span>+</span>
                </div>
                <h6>Happy Patients</h6>
              </div>
            </div>
            <div class="col-md-4">
              <div class="service-patient-inflict">
                <div class="service-patient-inflictimg">
                  <span>
                    <img src="@/assets/img/icons/we-are-icon3.svg" alt="Icon" />
                  </span>
                </div>
                <div class="clients-fifteen-span">
                  <h3 class="counter">
                    <vue3-autocounter
                      ref="counter"
                      :startAmount="1"
                      :delay="3"
                      :endAmount="30"
                      :duration="5"
                      separator=","
                      :autoinit="true"
                    />
                  </h3>
                  <span>+</span>
                </div>
                <h6>Years of Service</h6>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
  <!-- /Patients Section -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import indextenbanner from "@/assets/json/indextenbanner.json";
import indextenservice from "@/assets/json/indextenservice.json";

export default {
  data() {
    return {
      indextenbanner: indextenbanner,
      indextenservice: indextenservice,
    };
  },

  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
