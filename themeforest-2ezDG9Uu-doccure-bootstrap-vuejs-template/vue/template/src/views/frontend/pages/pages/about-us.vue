<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="page-wrapper">
      <!-- About Us -->
      <section class="about-section">
        <div class="container">
          <div class="row align-items-center">
            <div class="col-lg-6 col-md-12">
              <div class="about-img-info">
                <div class="row">
                  <div class="col-md-6">
                    <div class="about-inner-img">
                      <div class="about-img">
                        <img src="@/assets/img/about-img1.jpg" class="img-fluid" alt="Image" />
                      </div>
                      <div class="about-img">
                        <img src="@/assets/img/about-img2.jpg" class="img-fluid" alt="Image" />
                      </div>
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="about-inner-img">
                      <div class="about-box">
                        <h4>Over 25+ Years Experience</h4>
                      </div>
                      <div class="about-img">
                        <img src="@/assets/img/about-img3.jpg" class="img-fluid" alt="Image" />
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class="col-lg-6 col-md-12">
              <div class="section-inner-header about-inner-header">
                <h6>About Our Company</h6>
                <h2>We Are Always Ensure Best Medical Treatment For Your Health</h2>
              </div>
              <div class="about-content">
                <div class="about-content-details">
                  <p>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do
                    eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad
                    minim veniam, quis nostrud exercitation ullamco laboris nisi ut
                    aliquip ex ea commodo consequat. Duis aute irure dolor in
                    reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla
                    pariatur.
                  </p>
                  <p>
                    Sed ut perspiciatis unde omnis iste natus sit voluptatem accusantium
                    doloremque eaque ipsa quae architecto beatae vitae dicta sunt
                    explicabo.
                  </p>
                </div>
                <div class="about-contact">
                  <div class="about-contact-icon">
                    <span><img src="@/assets/img/icons/phone-icon.svg" alt="Image" /></span>
                  </div>
                  <div class="about-contact-text">
                    <p>Need Emergency?</p>
                    <h4>+1 315 369 5943</h4>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
      <!-- /About Us -->

      <!-- Why Choose Us -->
      <section class="why-choose-section">
        <div class="container">
          <div class="row">
            <div class="col-md-12">
              <div class="section-inner-header text-center">
                <h2>Why Choose Us</h2>
              </div>
            </div>
          </div>
          <div class="row">
            <div
              class="col-lg-3 col-md-6 d-flex"
              v-for="item in AboutusChoose"
              :key="item.id"
            >
              <div class="card why-choose-card w-100">
                <div class="card-body">
                  <div class="why-choose-icon">
                    <span
                      ><img :src="require(`@/assets/img/icons/${item.Image}`)" alt="Image"
                    /></span>
                  </div>
                  <div class="why-choose-content">
                    <h4>Qualified Staff of Doctors</h4>
                    <p>
                      Lorem ipsum sit amet consectetur incididunt ut labore et
                      exercitation ullamco laboris nisi dolore magna enim veniam aliqua.
                    </p>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
      <!-- /Why Choose Us -->

      <!-- Way Section -->
      <section class="way-section">
        <div class="container">
          <div class="way-bg">
            <div class="way-shapes-img">
              <div class="way-shapes-left">
                <img src="@/assets/img/shape-06.png" alt="Image" />
              </div>
              <div class="way-shapes-right">
                <img src="@/assets/img/shape-07.png" alt="Image" />
              </div>
            </div>
            <div class="row align-items-end">
              <div class="col-lg-7 col-md-12">
                <div class="section-inner-header way-inner-header mb-0">
                  <h2>Be on Your Way to Feeling Better with the Doccure</h2>
                  <p>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do
                    eiusmod tempor incididunt ut labore et dolore magna aliqua.
                  </p>
                  <router-link to="/contact-us" class="btn btn-primary"
                    >Contact With Us</router-link
                  >
                </div>
              </div>
              <div class="col-lg-5 col-md-12">
                <div class="way-img">
                  <img src="@/assets/img/way-img.png" class="img-fluid" alt="Image" />
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
      <!-- /Way Choose Us -->

      <!-- Doctors Section -->
      <section class="doctors-section professional-section">
        <div class="container">
          <div class="row">
            <div class="col-md-12">
              <div class="section-inner-header text-center">
                <h2>Best Doctors</h2>
              </div>
            </div>
          </div>
          <div class="row">
            <!-- Doctor Item -->
            <div
              class="col-lg-3 col-md-6 d-flex"
              v-for="item in AboutusDoctors"
              :key="item.id"
            >
              <div class="doctor-profile-widget w-100">
                <div class="doc-pro-img">
                  <router-link to="/doctor-profile">
                    <div class="doctor-profile-img">
                      <img
                        :src="require(`@/assets/img/doctors/${item.Image}`)"
                        class="img-fluid"
                        alt="Image"
                      />
                    </div>
                  </router-link>
                  <div class="doctor-amount">
                    <span>{{ item.Price }}</span>
                  </div>
                </div>
                <div class="doc-content">
                  <div class="doc-pro-info">
                    <div class="doc-pro-name">
                      <router-link to="/doctor-profile">{{ item.Name }}</router-link>
                      <p>{{ item.Role }}</p>
                    </div>
                    <div class="reviews-ratings">
                      <p>
                        <span><i class="fas fa-star"></i> {{ item.Rateing }}</span>
                        {{ item.Views }}
                      </p>
                    </div>
                  </div>
                  <div class="doc-pro-location">
                    <p><i class="feather-map-pin"></i> {{ item.Location }}</p>
                  </div>
                </div>
              </div>
            </div>
            <!-- /Doctor Item -->
          </div>
        </div>
      </section>
      <!-- /Doctors Section -->

      <!-- Testimonial Section -->
      <section class="testimonial-section">
        <div class="testimonial-shape-img">
          <div class="testimonial-shape-left">
            <img src="@/assets/img/shape-04.png" alt="Image" />
          </div>
          <div class="testimonial-shape-right">
            <img src="@/assets/img/shape-05.png" alt="Image" />
          </div>
        </div>
        <div class="container">
          <div class="row">
            <div class="col-md-12">
              <div class="testimonial-slider slick">
                <Carousel
                  :wrap-around="true"
                  :settings="settings"
                  :breakpoints="breakpoints"
                >
                  <Slide v-for="item in IndexTestimonial" :key="item.id">
                    <div class="testimonial-grid">
                      <div class="testimonial-info">
                        <div class="testimonial-img">
                          <img
                            :src="require(`@/assets/img/clients/${item.Image}`)"
                            class="img-fluid"
                            alt="client-image"
                          />
                        </div>
                        <div class="testimonial-content">
                          <div class="section-inner-header testimonial-header">
                            <h6>Testimonials</h6>
                            <h2>What Our Client Says</h2>
                          </div>
                          <div class="testimonial-details">
                            <p>
                              Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed
                              do eiusmod tempor incididunt ut labore et dolore magna
                              aliqua. Ut enim ad minim veniam, quis nostrud exercitation
                              ullamco laboris nisi ut aliquip ex ea commodo consequat.
                              Duis aute irure dolor in reprehenderit in voluptate velit
                              esse cillum dolore eu fugiat nulla pariatur.
                            </p>
                            <h6>
                              <span>{{ item.Name }}</span> {{ item.Location }}
                            </h6>
                          </div>
                        </div>
                      </div>
                    </div>
                  </Slide>
                  <template #addons>
                    <Navigation />
                  </template>
                </Carousel>
              </div>
            </div>
          </div>
        </div>
      </section>
      <!-- /Testimonial Section -->

      <!-- FAQ Section -->
      <section class="faq-section faq-section-inner">
        <div class="container">
          <div class="row">
            <div class="col-md-12">
              <div class="section-inner-header text-center">
                <h6>Get Your Answer</h6>
                <h2>Frequently Asked Questions</h2>
              </div>
            </div>
          </div>
          <div class="row align-items-center">
            <div class="col-lg-6 col-md-12">
              <div class="faq-img">
                <img src="@/assets/img/faq-img.png" class="img-fluid" alt="img" />
                <div class="faq-patients-count">
                  <div class="faq-smile-img">
                    <img src="@/assets/img/icons/smiling-icon.svg" alt="icon" />
                  </div>
                  <div class="faq-patients-content">
                    <h4>
                      <span class="count-digit"
                        ><vue3-autocounter
                          class="count-digit"
                          ref="counter"
                          :startAmount="0"
                          :delay="5"
                          :endAmount="95"
                          :duration="5"
                          separator=","
                          :autoinit="true" /></span
                      >k+
                    </h4>
                    <p>Happy Patients</p>
                  </div>
                </div>
              </div>
            </div>
            <div class="col-lg-6 col-md-12">
              <div class="faq-info">
                <div class="accordion" id="accordionExample">
                  <!-- FAQ Item -->
                  <div class="accordion-item">
                    <h2 class="accordion-header" id="headingOne">
                      <a
                        class="accordion-button"
                        data-bs-toggle="collapse"
                        data-bs-target="#collapseOne"
                        aria-expanded="true"
                        aria-controls="collapseOne"
                      >
                        Can i make an Appointment Online with White Plains Hospital Kendi?
                      </a>
                    </h2>
                    <div
                      id="collapseOne"
                      class="accordion-collapse collapse show"
                      aria-labelledby="headingOne"
                      data-bs-parent="#accordionExample"
                    >
                      <div class="accordion-body">
                        <div class="accordion-content">
                          <p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed
                            do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                            Ut enim ad minim veniam,
                          </p>
                        </div>
                      </div>
                    </div>
                  </div>
                  <!-- /FAQ Item -->

                  <!-- FAQ Item -->
                  <div class="accordion-item">
                    <h2 class="accordion-header" id="headingTwo">
                      <a
                        class="accordion-button collapsed"
                        type="button"
                        data-bs-toggle="collapse"
                        data-bs-target="#collapseTwo"
                        aria-expanded="false"
                        aria-controls="collapseTwo"
                      >
                        Can i make an Appointment Online with White Plains Hospital Kendi?
                      </a>
                    </h2>
                    <div
                      id="collapseTwo"
                      class="accordion-collapse collapse"
                      aria-labelledby="headingTwo"
                      data-bs-parent="#accordionExample"
                    >
                      <div class="accordion-body">
                        <div class="accordion-content">
                          <p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed
                            do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                            Ut enim ad minim veniam,
                          </p>
                        </div>
                      </div>
                    </div>
                  </div>
                  <!-- /FAQ Item -->

                  <!-- FAQ Item -->
                  <div class="accordion-item">
                    <h2 class="accordion-header" id="headingThree">
                      <a
                        class="accordion-button collapsed"
                        type="button"
                        data-bs-toggle="collapse"
                        data-bs-target="#collapseThree"
                        aria-expanded="false"
                        aria-controls="collapseThree"
                      >
                        Can i make an Appointment Online with White Plains Hospital Kendi?
                      </a>
                    </h2>
                    <div
                      id="collapseThree"
                      class="accordion-collapse collapse"
                      aria-labelledby="headingThree"
                      data-bs-parent="#accordionExample"
                    >
                      <div class="accordion-body">
                        <div class="accordion-content">
                          <p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed
                            do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                            Ut enim ad minim veniam,
                          </p>
                        </div>
                      </div>
                    </div>
                  </div>
                  <!-- /FAQ Item -->

                  <!-- FAQ Item -->
                  <div class="accordion-item">
                    <h2 class="accordion-header" id="headingFour">
                      <a
                        class="accordion-button collapsed"
                        type="button"
                        data-bs-toggle="collapse"
                        data-bs-target="#collapseFour"
                        aria-expanded="false"
                        aria-controls="collapseFour"
                      >
                        Can i make an Appointment Online with White Plains Hospital Kendi?
                      </a>
                    </h2>
                    <div
                      id="collapseFour"
                      class="accordion-collapse collapse"
                      aria-labelledby="headingFour"
                      data-bs-parent="#accordionExample"
                    >
                      <div class="accordion-body">
                        <div class="accordion-content">
                          <p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed
                            do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                            Ut enim ad minim veniam,
                          </p>
                        </div>
                      </div>
                    </div>
                  </div>
                  <!-- /FAQ Item -->

                  <!-- FAQ Item -->
                  <div class="accordion-item">
                    <h2 class="accordion-header" id="headingFive">
                      <a
                        class="accordion-button collapsed"
                        type="button"
                        data-bs-toggle="collapse"
                        data-bs-target="#collapseFive"
                        aria-expanded="false"
                        aria-controls="collapseFive"
                      >
                        Can i make an Appointment Online with White Plains Hospital Kendi?
                      </a>
                    </h2>
                    <div
                      id="collapseFive"
                      class="accordion-collapse collapse"
                      aria-labelledby="headingFive"
                      data-bs-parent="#accordionExample"
                    >
                      <div class="accordion-body">
                        <div class="accordion-content">
                          <p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed
                            do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                            Ut enim ad minim veniam,
                          </p>
                        </div>
                      </div>
                    </div>
                  </div>
                  <!-- /FAQ Item -->
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
      <!-- /FAQ Section -->
    </div>
    <indexfooter></indexfooter>
    <cursor></cursor>
  </div>
</template>

<script>
import AboutusChoose from "@/assets/json/aboutuschoose.json";
import AboutusDoctors from "@/assets/json/aboutusdoctors";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import IndexTestimonial from "@/assets/json/indextestimonial.json";
import "vue3-carousel/dist/carousel.css";

export default {
  data() {
    return {
      AboutusChoose: AboutusChoose,
      AboutusDoctors: AboutusDoctors,
      title: "About Us",
      text: "Home",
      text1: "About Us",
      IndexTestimonial: IndexTestimonial,
      settings: {
        itemsToShow: 1,
        snapAlign: "center",
      },
      breakpoints: {
        575: {
          itemsToShow: 1,
          snapAlign: "center",
        },
        767: {
          itemsToShow: 1,
          snapAlign: "center",
        },
        991: {
          itemsToShow: 1,
          snapAlign: "center",
        },
        1024: {
          itemsToShow: 1,
          snapAlign: "start",
        },
      },
    };
  },
  components: {
    Carousel,
    Slide,
    Pagination,
    Navigation,
  },
};
</script>
