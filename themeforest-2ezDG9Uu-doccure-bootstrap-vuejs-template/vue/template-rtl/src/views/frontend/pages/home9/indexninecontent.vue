<template>
  <!-- contact -->
  <section class="contact-section-fourteen">
    <div class="container">
      <div class="contact-schedule-main">
        <div class="row">
          <div class="col-lg-7">
            <div class="scheduling-left-main">
              <h2>Are you pregnant?</h2>
              <p>Free talk with us for Schedule a Consultation.</p>
              <ul>
                <li>
                  <router-link to="/appointments">Fix an Appoint</router-link>
                </li>
                <li>
                  <router-link to="/booking">Make a Call</router-link>
                </li>
                <li>
                  <a href="javascript:void(0);">Whatsapp</a>
                </li>
              </ul>
            </div>
          </div>
          <div class="col-lg-5">
            <div class="scheduling-right-main">
              <img
                src="@/assets/img/contact-fourteen.png"
                alt="image"
                class="img-fluid"
              />
              <div class="scheduling-right-img">
                <img src="@/assets/img/contact-icon3.png" alt="Icon" />
              </div>
              <div class="scheduling-right-imgtwo">
                <img src="@/assets/img/contact-icon2.png" alt="Icon" />
              </div>
            </div>
          </div>
        </div>
        <div class="contact-inner-image">
          <img src="@/assets/img/icons/contact-icon1.svg" alt="Icon" />
        </div>
      </div>
    </div>
  </section>
  <!-- /contact -->
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
