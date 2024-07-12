<template>
  <!-- Center Section -->
  <section class="center-section">
    <div class="ban-bg">
      <img
        src="@/assets/img/bg/center-bg.png"
        alt="design-image"
        class="img-fluid bg-05"
      />
    </div>
    <div class="container">
      <div class="row">
        <div class="col-lg-5 aos" data-aos="fade-up">
          <div class="center-img">
            <img src="@/assets/img/hospital.png" alt="eye-checkup" class="img-fluid" />
            <div class="center-service">
              <span><i class="fa-solid fa-headphones"></i></span>
              <div>
                <h6>24/7 Service</h6>
                <p>We are available when you want</p>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-7 aos" data-aos="fade-up">
          <div class="center-info">
            <div class="section-heading sec-heading-eye">
              <img
                src="@/assets/img/icons/eye-icon.svg"
                alt="eye-icon"
                class="img-fluid"
              />
              <h2><span>Who</span> We Are</h2>
              <p>The Great Place Of Eyecare Hospital Center</p>
            </div>
            <p>
              Lorem Ipsum is simply dummy text of the printing and typesetting industry.
              Lorem Ipsum has been the industry's standard dummy text ever since the
              1500s, when an unknown printer took a galley of type and scrambled it to
              make a type specimen book. It has survived not only five centuries
            </p>
            <p>
              Lorem Ipsum is simply dummy text of the printing and typesetting industry.
              Lorem Ipsum has been the industry's standard
            </p>
          </div>
          <div class="row">
            <div class="col-md-4">
              <div class="care-box">
                <span>
                  <img
                    src="@/assets/img/icons/doc-01.svg"
                    alt="doctor-image"
                    class="img-fluid"
                  />
                </span>
                <h6>Expert Professionals and World Class Facilities</h6>
                <router-link to="/doctor-search-grid"
                  >Find Doctors<i class="fa-solid fa-chevron-right"></i
                ></router-link>
              </div>
            </div>
            <div class="col-md-4">
              <div class="care-box">
                <span>
                  <img
                    src="@/assets/img/icons/doc-02.svg"
                    alt="stethoscope"
                    class="img-fluid"
                  />
                </span>
                <h6>Specialty Eyecare treatment for all</h6>
                <router-link to="/booking"
                  >Book Now<i class="fa-solid fa-chevron-right"></i
                ></router-link>
              </div>
            </div>
            <div class="col-md-4">
              <div class="care-box">
                <span>
                  <img
                    src="@/assets/img/icons/doc-03.svg"
                    alt="calendar"
                    class="img-fluid"
                  />
                </span>
                <h6>Online Appointment and Excellent Treatment</h6>
                <router-link to="/booking-2"
                  >Make an Appointment<i class="fa-solid fa-chevron-right"></i
                ></router-link>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Center Section -->

  <!-- Counter Section -->
  <section class="counter-section">
    <div class="ban-bg">
      <img
        src="@/assets/img/bg/counter-bg.png"
        alt="design-image"
        class="img-fluid bg-06"
      />
      <img
        src="@/assets/img/bg/counter-bg-01.png"
        alt="eye-image"
        class="img-fluid bg-07"
      />
    </div>
    <div class="container">
      <div class="row">
        <div class="col-lg-3 col-sm-6">
          <div class="count-box">
            <span class="count-icon">
              <img
                src="@/assets/img/icons/count-01.svg"
                alt="doctor-image"
                class="img-fluid"
              />
            </span>
            <div class="count-info">
              <h3>
                <vue3-autocounter
                  class="count-digit"
                  ref="counter"
                  :startAmount="0"
                  :delay="3"
                  :endAmount="180"
                  :duration="5"
                  separator=","
                  :autoinit="true"
                />+
              </h3>
              <p>Expert Doctors</p>
            </div>
          </div>
        </div>
        <div class="col-lg-3 col-sm-6">
          <div class="count-box">
            <span class="count-icon">
              <img
                src="@/assets/img/icons/count-02.svg"
                alt="stethoscope"
                class="img-fluid"
              />
            </span>
            <div class="count-info">
              <h3>
                <vue3-autocounter
                  class="count-digit"
                  ref="counter"
                  :startAmount="0"
                  :delay="3"
                  :endAmount="26"
                  :duration="5"
                  separator=","
                  :autoinit="true"
                />+
              </h3>
              <p>Expert Services</p>
            </div>
          </div>
        </div>
        <div class="col-lg-3 col-sm-6">
          <div class="count-box">
            <span class="count-icon">
              <img
                src="@/assets/img/icons/count-03.svg"
                alt="smiley-icon"
                class="img-fluid"
              />
            </span>
            <div class="count-info">
              <h3>
                <vue3-autocounter
                  class="count-digit"
                  ref="counter"
                  :startAmount="0"
                  :delay="3"
                  :endAmount="10"
                  :duration="5"
                  separator=","
                  :autoinit="true"
                />K+
              </h3>
              <p>Happy Customers</p>
            </div>
          </div>
        </div>
        <div class="col-lg-3 col-sm-6">
          <div class="count-box">
            <span class="count-icon">
              <img
                src="@/assets/img/icons/count-04.svg"
                alt="award-icon"
                class="img-fluid"
              />
            </span>
            <div class="count-info">
              <h3>
                <vue3-autocounter
                  class="count-digit"
                  ref="counter"
                  :startAmount="0"
                  :delay="3"
                  :endAmount="150"
                  :duration="5"
                  separator=","
                  :autoinit="true"
                />+
              </h3>
              <p>Best Awards Winner</p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Counter Section -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
export default {
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
