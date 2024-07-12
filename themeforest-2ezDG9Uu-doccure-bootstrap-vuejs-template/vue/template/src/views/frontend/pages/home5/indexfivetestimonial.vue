<template>
  <!-- Testimonials -->
  <div class="testimonial-section-ten need-to-know-section">
    <div class="floating-bg">
      <img src="@/assets/img/bg/health-care.png" alt="Image" />
    </div>
    <div class="container">
      <div class="row align-items-center">
        <div class="col-md-12 col-lg-5 aos" data-aos="fade-up">
          <div class="section-header-one section-header-slider">
            <h2 class="section-title">What Our <span>Patients Say</span></h2>
            <div class="need-to-know-content">
              <p>
                If one of the valves in your heart becomes diseased it can affect the flow
                of blood. This can happen in one of two ways: valve stenosis (where the
                valve does not fully open and obstructs or restricts flow) or valve
                incompetence (where the valve does not close properly and blood is allowed
                to leak backwards)....
              </p>
              <div class="patient-rating-block">
                <div class="patient-rating">
                  <div class="circle-rating">
                    <i class="fa-solid fa-circle"></i>
                    <i class="fa-solid fa-circle"></i>
                    <i class="fa-solid fa-circle"></i>
                    <i class="fa-solid fa-circle"></i>
                    <i class="fa-solid fa-circle-half-stroke"></i>
                    <span>(4.8/5)</span>
                  </div>
                  <h5>Overall Customer Ratings</h5>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="col-md-12 col-lg-7 aos" data-aos="fade-up">
          <div class="row align-items-center">
            <div class="col-lg-6">
              <div class="testimonial-card">
                <div class="testimonial-user-details">
                  <div class="testimonial-user-img">
                    <img
                      src="@/assets/img/clients/client-07.jpg"
                      class="img-fluid"
                      alt="Image"
                    />
                  </div>
                  <div class="testimonial-user-name">
                    <h5>Martin Philips</h5>
                    <div class="circle-rating">
                      <i class="fa-solid fa-circle me-1"></i>
                      <i class="fa-solid fa-circle me-1"></i>
                      <i class="fa-solid fa-circle me-1"></i>
                      <i class="fa-solid fa-circle me-1"></i>
                      <i class="fa-solid fa-circle-half-stroke"></i>
                    </div>
                  </div>
                </div>
                <div class="testmonial-user-coments">
                  <h6>“ Awesome Impact ”</h6>
                  <p>
                    After suffering from a heart condition for a number of years I was
                    very happy to meet Doccure, from the first consultation where he
                    believed there was a solution...
                  </p>
                </div>
              </div>
              <div class="testimonial-card">
                <div class="testimonial-user-details">
                  <div class="testimonial-user-img">
                    <img
                      src="@/assets/img/clients/client-08.jpg"
                      class="img-fluid"
                      alt="Image"
                    />
                  </div>
                  <div class="testimonial-user-name">
                    <h5>James Anderson</h5>
                    <div class="circle-rating">
                      <i class="fa-solid fa-circle me-1"></i>
                      <i class="fa-solid fa-circle me-1"></i>
                      <i class="fa-solid fa-circle me-1"></i>
                      <i class="fa-solid fa-circle me-1"></i>
                      <i class="fa-solid fa-circle-half-stroke"></i>
                    </div>
                  </div>
                </div>
                <div class="testmonial-user-coments">
                  <h6>“ I am very grateful ”</h6>
                  <p>
                    Doctors explains everything clearly and helps you to understand even
                    the most complex medical terms
                  </p>
                </div>
              </div>
            </div>
            <div class="col-lg-6">
              <div class="testimonial-card">
                <div class="testimonial-user-details">
                  <div class="testimonial-user-img">
                    <img
                      src="@/assets/img/clients/client-09.jpg"
                      class="img-fluid"
                      alt="Image"
                    />
                  </div>
                  <div class="testimonial-user-name">
                    <h5>Christina Louis</h5>
                    <div class="circle-rating">
                      <i class="fa-solid fa-circle me-1"></i>
                      <i class="fa-solid fa-circle me-1"></i>
                      <i class="fa-solid fa-circle me-1"></i>
                      <i class="fa-solid fa-circle me-1"></i>
                      <i class="fa-solid fa-circle-half-stroke"></i>
                    </div>
                  </div>
                </div>
                <div class="testmonial-user-coments">
                  <h6>“ Excellent Clinician ”</h6>
                  <p>
                    Excellent clinician. Endlessly patient and reassuring.Also a very
                    efficient back up team. He was prepared to spend as long as I needed
                    to understand what he was saying.
                  </p>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
  <!-- /Testimonials -->

  <!-- Book Appointment -->
  <section class="book-appointment-section aos" data-aos="fade-up">
    <div class="container">
      <div class="book-appointment-ten text-center">
        <div class="book-section-bg">
          <img src="@/assets/img/bg/hexagen-group-3.png" alt="Image" />
          <img src="@/assets/img/bg/hand.png" alt="Image" />
          <img src="@/assets/img/bg/heart-plus.png" alt="Image" />
        </div>
        <h2>Book An Appointment Today</h2>
        <p>
          Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
          Ipsum has been the industry's standard dummy text ever since the 1500s, when an
          unknown printer took a galley of type and scrambled it to make a type specimen
          book.
        </p>
        <div class="appointment-btn-group">
          <router-link to="/booking" class="appointment-blue-btn"
            >Start a Consult</router-link
          >
          <router-link to="/pricing">Click Our Plan</router-link>
        </div>
      </div>
    </div>
  </section>
  <!-- /Book Appointment -->
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
