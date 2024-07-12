<template>
  <!-- App Section -->
  <section class="app-section">
    <div class="container">
      <div class="app-bg">
        <div class="row align-items-center">
          <div class="col-lg-6 col-md-12">
            <div class="app-content">
              <div class="app-header aos" data-aos="fade-up">
                <h5>Working for Your Better Health.</h5>
                <h2>Download the Doccure App today!</h2>
              </div>
              <div class="app-scan aos" data-aos="fade-up">
                <p>Scan the QR code to get the app now</p>
                <img src="@/assets/img/scan-img.png" alt="Image" />
              </div>
              <div class="google-imgs aos" data-aos="fade-up">
                <a href="javascript:void(0);"
                  ><img src="@/assets/img/google-play.png" alt="img"
                /></a>
                <a href="javascript:void(0);"
                  ><img src="@/assets/img/app-store.png" alt="img"
                /></a>
              </div>
            </div>
          </div>
          <div class="col-lg-6 col-md-12 aos" data-aos="fade-up">
            <div class="mobile-img">
              <img src="@/assets/img/mobile-img.png" class="img-fluid" alt="img" />
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /App Section -->

  <!-- FAQ Section -->
  <section class="faq-section">
    <div class="container">
      <div class="row">
        <div class="col-md-12">
          <div class="section-header-one text-center aos" data-aos="fade-up">
            <h5>Get Your Answer</h5>
            <h2 class="section-title">Frequently Asked Questions</h2>
          </div>
        </div>
      </div>
      <div class="row align-items-center">
        <div class="col-lg-6 col-md-12 aos" data-aos="fade-up">
          <div class="faq-img">
            <img src="@/assets/img/faq-img.png" class="img-fluid" alt="img" />
            <div class="faq-patients-count">
              <div class="faq-smile-img">
                <img src="@/assets/img/icons/smiling-icon.svg" alt="icon" />
              </div>
              <div class="faq-patients-content">
                <h4>
                  <span class="count-digit">
                    <vue3-autocounter
                      ref="counter"
                      :startAmount="1"
                      :delay="3"
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
          <div class="faq-info aos" data-aos="fade-up">
            <div class="accordion" id="faq-details">
              <!-- FAQ Item -->
              <div class="accordion-item" v-for="item in IndexApp" :key="item.id">
                <h2 class="accordion-header" :id="item.Text">
                  <a
                    href="javascript:void(0);"
                    :class="item.classname"
                    data-bs-toggle="collapse"
                    :data-bs-target="item.Target"
                    :aria-expanded="item.expanded"
                    :aria-controls="item.Aria"
                  >
                    {{ item.Title }}
                  </a>
                </h2>
                <div
                  :id="item.Targetid"
                  :class="item.Class"
                  :aria-labelledby="item.Text"
                  data-bs-parent="#faq-details"
                >
                  <div class="accordion-body">
                    <div class="accordion-content">
                      <p>{{ item.Content }}</p>
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
</template>

<script>
import AOS from "aos";
import "aos/dist/aos.css";
import IndexApp from "@/assets/json/indexapp.json";
export default {
  data() {
    return {
      IndexApp: IndexApp,
    };
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
