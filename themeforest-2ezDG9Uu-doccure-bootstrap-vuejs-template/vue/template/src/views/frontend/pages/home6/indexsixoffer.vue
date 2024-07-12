<template>
  <!-- Offer Section -->
  <section class="offer-section">
    <div class="container">
      <div class="row">
        <div class="col-lg-6 d-flex">
          <div class="offer-wrap flex-fill">
            <div class="row align-items-center">
              <div class="col-md-6">
                <div class="off-img">
                  <img
                    src="@/assets/img/offer-01.png"
                    alt="eye-test image"
                    class="img-fluid"
                  />
                </div>
              </div>
              <div class="col-md-6">
                <div class="off-info">
                  <h6>NEW USER OFFER</h6>
                  <p>21 - 25 April {{ new Date().getFullYear() }}</p>
                  <h5>Free Eye Camp</h5>
                  <a href="javascript:;" class="btn btn-light-blue">Book Now</a>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-6 d-flex">
          <div class="offer-wrap flat-offer flex-fill">
            <div class="row align-items-center">
              <div class="col-md-6">
                <div class="off-img">
                  <img
                    src="@/assets/img/offer-02.png"
                    alt="eye-glass"
                    class="img-fluid"
                  />
                </div>
              </div>
              <div class="col-md-6">
                <div class="off-info">
                  <h6>Flat 30% OffER</h6>
                  <p>21 April {{ new Date().getFullYear() }}</p>
                  <h5>Crystal Clear</h5>
                  <a href="javascript:;" class="btn btn-light-blue">Buy Now</a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Offer Section -->

  <!-- Facility Section -->
  <section class="facilities-section">
    <div class="container">
      <div class="row">
        <div class="col-md-12 aos" data-aos="fade-up">
          <div class="section-heading text-center sec-heading-eye">
            <img src="@/assets/img/icons/eye-icon.svg" alt="eye-icon" class="img-fluid" />
            <h2><span>Top</span> Facilities</h2>
            <p>The Great Place Of Eyecare Hospital Center</p>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-md-4">
          <div class="facility-box">
            <div class="facility-img">
              <img
                src="@/assets/img/features/facility-01.jpg"
                alt="eye-test image"
                class="img-fluid"
              />
            </div>
            <h6>Consultation rooms</h6>
          </div>
        </div>
        <div class="col-md-4">
          <div class="row">
            <div class="col-md-12">
              <div class="facility-box">
                <div class="facility-img">
                  <img
                    src="@/assets/img/features/facility-02.jpg"
                    alt="eye-test image"
                    class="img-fluid"
                  />
                </div>
                <h6>Audio and Video Call Consultation</h6>
              </div>
            </div>
            <div class="col-md-6 col-sm-6">
              <div class="facility-box">
                <div class="facility-img">
                  <img
                    src="@/assets/img/features/facility-03.jpg"
                    alt="eye-test image"
                    class="img-fluid"
                  />
                </div>
                <h6>Modern Equipments</h6>
              </div>
            </div>
            <div class="col-md-6 col-sm-6">
              <div class="facility-box">
                <div class="facility-img">
                  <img
                    src="@/assets/img/features/facility-04.jpg"
                    alt="laboratory"
                    class="img-fluid"
                  />
                </div>
                <h6>Laboratory</h6>
              </div>
            </div>
          </div>
        </div>
        <div class="col-md-4">
          <div class="row">
            <div class="col-md-6 col-sm-6">
              <div class="facility-box">
                <div class="facility-img">
                  <img
                    src="@/assets/img/features/facility-05.jpg"
                    alt="laboratory"
                    class="img-fluid"
                  />
                </div>
                <h6>Optical Store</h6>
              </div>
            </div>
            <div class="col-md-6 col-sm-6">
              <div class="facility-box">
                <div class="facility-img">
                  <img
                    src="@/assets/img/features/facility-06.jpg"
                    alt="eye-test image"
                    class="img-fluid"
                  />
                </div>
                <h6>Operation Theaters</h6>
              </div>
            </div>
            <div class="col-md-12">
              <div class="facility-box">
                <div class="facility-img">
                  <img
                    src="@/assets/img/features/facility-07.jpg"
                    alt="pharmacy-shop"
                    class="img-fluid"
                  />
                </div>
                <h6>Pharmacy Shop</h6>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Facility Section -->
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
