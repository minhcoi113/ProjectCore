<template>
  <!-- Feedback -->
  <section class="clients-section-fourteen">
    <div class="floating-bg">
      <img src="@/assets/img/bg/two-paw.png" alt="paw-image" />
    </div>
    <div class="container">
      <div class="row">
        <div class="col-lg-5">
          <div class="client-inner-main">
            <img
              src="@/assets/img/bg/home-12-testimonial.png"
              alt="image"
              class="img-fluid"
            />
          </div>
        </div>
        <div class="col-lg-7 col-md-12">
          <div class="section-header-fourteen service-inner-fourteen">
            <div class="service-inner-fourteen">
              <div class="service-inner-fourteen-two">
                <h3>CLIENT REVIEWS</h3>
              </div>
            </div>
            <h2>Testimonials</h2>
            <p>What our customers says about us</p>
          </div>
          <div
            class="owl-carousel feedback-slider-fourteen owl-theme aos"
            data-aos="fade-up"
          >
            <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
              <Slide v-for="feedback in indesevenfeedbacklist" :key="feedback.id">
                <div class="card feedback-card">
                  <div class="card-body feedback-card-body">
                    <div class="feedback-inner-main text-end">
                      <div class="feedback-inner-img">
                        <img
                          :src="require(`@/assets/img/clients/${feedback.image}`)"
                          alt="image"
                          class="img-fluid"
                        />
                        <div class="feedback-user-details">
                          <h4>{{ feedback.name }}</h4>
                          <h6>{{ feedback.location }}</h6>
                          <div class="rating rating-fourteen">
                            <i
                              v-for="star in feedback.rating"
                              :key="star"
                              class="fas fa-star filled me-1"
                            ></i>
                            <i
                              v-for="star in 5 - feedback.rating"
                              :key="star"
                              class="fas fa-star"
                            ></i>
                          </div>
                        </div>
                      </div>
                      <p>“{{ feedback.comment }}”</p>
                    </div>
                  </div>
                </div>
              </Slide>
              <template #addons>
                <div class="owl-nav">
                  <Navigation />
                </div>
              </template>
            </Carousel>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Feedback -->

  <!-- Pricing -->
  <section class="home-twelve-pricing">
    <div class="container">
      <div class="row">
        <div class="col-lg-12 aos" data-aos="fade-up">
          <div class="section-header-fourteen service-inner-fourteen">
            <div class="service-inner-fourteen">
              <div class="service-inner-fourteen-two">
                <h3>OUR PACKAGES</h3>
              </div>
            </div>
            <h2>Our Pricing Plan</h2>
            <p>Our Special Package</p>
          </div>
        </div>
      </div>
      <div class="row row-gap justify-content-center">
        <div
          v-for="card in indexsevenpricecard"
          :key="card.id"
          :class="{ active: card.isActive }"
          class="col-lg-4 col-md-6 col-sm-12"
        >
          <div class="price-card-twelve" :class="card.classcard">
            <div class="price-bg">
              <img src="@/assets/img/bg/home-12-pricing-bg-4.png" alt="design-image" />
              <img src="@/assets/img/bg/home-12-pricing-bg-5.png" alt="design-image" />
              <img src="@/assets/img/bg/home-12-pricing-bg-3.png" alt="design-image" />
            </div>
            <div class="price-content">
              <div class="card-title">
                <h3>{{ card.title }}</h3>
                <span v-if="card.bestOffer">Best Offer</span>
              </div>
              <div class="price">
                <h2><sup>$</sup> {{ card.price }} / <span>Visit</span></h2>
              </div>
              <div class="pack-details">
                <ul>
                  <li v-for="detail in card.details" :key="detail">
                    <i class="feather-check-circle"></i>{{ detail }}
                  </li>
                </ul>
              </div>
              <div class="price-btn">
                <router-link to="pricing" class="btn">Buy Now</router-link>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Pricing -->

  <!-- blog section -->
  <div class="blog-section-fourteen">
    <div class="container">
      <div class="row">
        <div class="col-lg-12">
          <div class="section-header-fourteen service-inner-fourteen">
            <div class="service-inner-fourteen">
              <div class="service-inner-fourteen-two">
                <h3>BLOG</h3>
              </div>
            </div>
            <h2>Our Blogs</h2>
            <p>Our Recent Articles</p>
          </div>
        </div>
      </div>
      <div class="owl-carousel blog-slider-fourteen owl-theme aos" data-aos="fade-up">
        <Carousel
          :wrap-around="true"
          :settings="settingsblog"
          :breakpoints="breakpointsblog"
        >
          <Slide v-for="blog in indexsevenblogs" :key="blog.id">
            <div class="card blog-inner-fourt-all slide-content-container">
              <div class="card-body blog-inner-fourt-main">
                <div class="blog-inner-right-fourt">
                  <router-link to="blog-details">
                    <div class="blog-inner-right-img">
                      <img
                        :src="require(`@/assets/img/blog/${blog.imageSrc}`)"
                        :alt="blog.imageAlt"
                        class="img-fluid"
                      />
                      <div class="blog-inner-top-content">
                        <img
                          :src="require(`@/assets/img/doctors/${blog.authorImageSrc}`)"
                          :alt="blog.authorAlt"
                          class="me-2"
                        />
                        <span>{{ blog.authorName }}</span>
                      </div>
                    </div>
                  </router-link>
                  <router-link to="blog-details" class="blog-inner-right-fourt-care">{{
                    blog.title
                  }}</router-link>
                  <ul class="articles-list nav blog-articles-list">
                    <li><i class="feather-calendar"></i> {{ blog.date }}</li>
                    <li><i class="feather-message-square"></i> {{ blog.comments }}</li>
                    <li><i class="feather-eye"></i> {{ blog.views }}</li>
                  </ul>
                  <ul class="articles-list nav blog-articles-list-two">
                    <li v-for="tag in blog.tags" :key="tag">{{ tag }}</li>
                  </ul>
                  <p>{{ blog.content }}</p>
                </div>
              </div>
            </div>
          </Slide>
          <template #addons>
            <div class="owl-nav">
              <Navigation />
            </div>
          </template>
        </Carousel>
      </div>
      <div class="owl-nav slide-nav-15 text-end nav-control"></div>
      <div class="blog-btn-sec text-center aos aos-init aos-animate" data-aos="fade-up">
        <router-link to="search" class="btn btn-primary btn-view"
          >Read More Articles</router-link
        >
      </div>
    </div>
  </div>
  <!-- /blog section -->

  <!-- Choose us -->
  <section class="choose-us-fourteen">
    <div class="container">
      <div class="row">
        <div class="col-md-12">
          <div class="section-header-fourteen text-center">
            <div class="service-inner-fourteen justify-content-center">
              <div class="service-inner-fourteen-two">
                <h3>Why Us</h3>
              </div>
            </div>
            <h2>Why Choose Us</h2>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing.</p>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-lg-6">
          <div class="choose-us-right-main">
            <img src="@/assets/img/bg/home-12-why-us.png" alt="image" class="img-fluid" />
          </div>
        </div>
        <div class="col-lg-6 col-md-12 col-sm-12 col-xs-12">
          <div class="why-us-content">
            <div class="us-faq aos" data-aos="fade-up" data-aos-delay="200">
              <div class="accordion" id="accordionExample">
                <div
                  class="accordion-item"
                  v-for="(item, index) in indexsevenaccordion"
                  :key="index"
                >
                  <h2 class="accordion-header" :id="item.heading">
                    <b-button
                      class="accordion-button"
                      :class="item.collapsed"
                      type="button"
                      data-bs-toggle="collapse"
                      :data-bs-target="item.target"
                      :aria-expanded="item.expanded"
                      :aria-controls="item.collapse"
                    >
                      {{ item.title }}
                    </b-button>
                  </h2>
                  <div
                    :id="item.collapse"
                    class="accordion-collapse collapse shade"
                    :class="item.show"
                    :aria-labelledby="item.heading"
                    data-bs-parent="#accordionExample"
                  >
                    <div class="accordion-body">
                      <h6>
                        {{ item.content }}
                      </h6>
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
  <!-- /Choose us -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import indesevenfeedbacklist from "@/assets/json/indesevenfeedbacklist.json";
import indexsevenpricecard from "@/assets/json/indexsevenpricecard.json";
import indexsevenblogs from "@/assets/json/indexsevenblogs.json";
import indexsevenaccordion from "@/assets/json/indexsevenaccordion.json";
import { Carousel, Navigation, Slide } from "vue3-carousel";
import "vue3-carousel/dist/carousel.css";
export default {
  components: {
    Carousel,
    Slide,
    Navigation,
  },
  data() {
    return {
      indesevenfeedbacklist: indesevenfeedbacklist,
      indexsevenpricecard: indexsevenpricecard,
      indexsevenblogs: indexsevenblogs,
      indexsevenaccordion: indexsevenaccordion,
      settings: {
        itemsToShow: 1,
        snapAlign: "center",
      },
      settingsblog: {
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
        // 700px and up
        991: {
          itemsToShow: 1,
          snapAlign: "center",
        },
        // 1024 and up
        1024: {
          itemsToShow: 1,
          snapAlign: "start",
        },
      },
      breakpointsblog: {
        575: {
          itemsToShow: 1,
          snapAlign: "center",
        },
        767: {
          itemsToShow: 1,
          snapAlign: "center",
        },
        // 700px and up
        991: {
          itemsToShow: 3,
          snapAlign: "center",
        },
        // 1024 and up
        1024: {
          itemsToShow: 2.95,
          snapAlign: "start",
        },
      },
    };
  },

  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
