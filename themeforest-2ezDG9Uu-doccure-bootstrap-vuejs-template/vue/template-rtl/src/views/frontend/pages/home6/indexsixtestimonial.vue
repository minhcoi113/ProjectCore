<template>
  <section class="eye-testimonial-section">
    <div class="container">
      <div class="row">
        <div class="col-md-12 aos" data-aos="fade-up">
          <div class="section-heading text-center sec-heading-eye">
            <img src="@/assets/img/icons/eye-icon.svg" alt="eye-icon" class="img-fluid" />
            <h2><span>Client</span> Testimonials</h2>
            <p>What our clients say about us</p>
          </div>
        </div>
      </div>
      <div class="row align-items-center">
        <div class="col-md-5">
          <div class="testi-img">
            <img
              src="@/assets/img/testimonial.jpg"
              alt="client-image"
              class="img-fluid"
            />
            <span class="testi-icon"><i class="fa-solid fa-quote-left"></i></span>
          </div>
          <div class="testi-users">
            <div class="nav nav-container slide-11"></div>
            <ul>
              <li>
                <img
                  src="@/assets/img/clients/client-01.jpg"
                  alt="client-image"
                  class="img-fluid"
                />
              </li>
              <li>
                <img
                  src="@/assets/img/clients/client-02.jpg"
                  alt="client-image"
                  class="img-fluid"
                />
              </li>
              <li>
                <img
                  src="@/assets/img/clients/client-03.jpg"
                  alt="client-image"
                  class="img-fluid"
                />
              </li>
              <li>
                <img
                  src="@/assets/img/clients/client-04.jpg"
                  alt="client-image"
                  class="img-fluid"
                />
              </li>
            </ul>
          </div>
        </div>
        <div class="col-md-7">
          <div class="owl-carousel eye-testislider">
            <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
              <Slide v-for="item in IndexSixTestimonial" :key="item.id">
                <div class="testimonial-wrap text-end">
                  <h4>
                    Contrary to popular belief, Lorem Ipsum is not simply random text. It
                    has roots in a piece of classical
                  </h4>
                  <p>
                    Lorem Ipsum is simply dummy text of the printing and typesetting
                    industry. Lorem Ipsum has been the industry's standard. The point of
                    using Lorem Ipsum is that it has a more-or-less normal distribution of
                    letters, as opposed to using 'Content here, content here', making it
                    look like readable English. Many desktop publishing packages and web
                    page editors now use Lorem Ipsum as their default model text, and a
                    search for 'lorem ipsum' will uncover many web sites still in their
                    infancy
                  </p>
                  <div class="testimonial-user">
                    <h6>{{ item.Name }}</h6>
                    <p>{{ item.Location }}</p>
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
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import IndexSixTestimonial from "@/assets/json/indexsixtestimonial.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      IndexSixTestimonial: IndexSixTestimonial,
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
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
