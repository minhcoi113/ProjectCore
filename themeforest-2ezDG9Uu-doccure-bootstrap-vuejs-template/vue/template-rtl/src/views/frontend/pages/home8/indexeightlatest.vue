<template>
  <!-- Latest Articles -->
  <section class="latest-articles-thirteen common-padding">
    <div class="container">
      <div class="row">
        <div class="col-lg-12 aos" data-aos="fade-up">
          <div class="section-header-thirteen">
            <div class="section-inner-thirteen">
              <img src="@/assets/img/icons/atom-bond2.svg" alt="Bond" />
            </div>
            <h2>Our Latest Articles</h2>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-lg-3 col-sm-6" v-for="item in IndexEightLatest" :key="item.id">
          <div class="articles-thirteen">
            <div class="articles-thirteen-img">
              <router-link to="/blog-details"
                ><img
                  :src="require(`@/assets/img/patients/${item.Image}`)"
                  alt="Articles"
                  class="img-fluid"
              /></router-link>
            </div>
            <div class="articles-thirteen-content">
              <h6>{{ item.Badge }}</h6>
              <router-link to="/blog-details">{{ item.Title }}</router-link>
              <p>{{ item.Content }}</p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- Latest Articles -->

  <!-- Feedback -->
  <section class="feedback-section-thirteen common-padding">
    <div class="container">
      <div class="row align-items-center">
        <div class="col-lg-6">
          <div class="feedback-main-thirteen">
            <div class="feedback-all-img">
              <img src="@/assets/img/feedback-inner.png" alt="image" class="img-fluid" />
            </div>
          </div>
        </div>
        <div class="col-lg-6">
          <div class="feedback-main-content">
            <h2>Download <br />The Doccure App Today!</h2>
            <p>
              Rasakan kemudahan pembayaran melalui aplikasi SmartInPays. Jalan-jalan,
              membayar tagihan, donasi di ujung jari Anda.
            </p>
            <div class="feedback-inner-img">
              <div class="feedback-inner-imgone">
                <a href="javascript:"
                  ><img src="@/assets/img/app-store-1.png" alt="Store"
                /></a>
              </div>
              <div class="feedback-inner-imgtwo">
                <a href="javascript:"
                  ><img src="@/assets/img/google-store-1.png" alt="Store"
                /></a>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="feedback-bg-icons">
      <img src="@/assets/img/bg/pluse-1.png" alt="Pluse" />
      <img src="@/assets/img/bg/pluse-2.png" alt="Pluse" />
      <img src="@/assets/img/bg/pluse-3.png" alt="Pluse" />
      <img src="@/assets/img/bg/pluse-3.png" alt="Pluse" />
      <img src="@/assets/img/bg/pluse-1.png" alt="Pluse" />
    </div>
  </section>
  <!-- Feedback -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
import IndexEightLatest from "@/assets/json/indexeightlatest.json";
export default {
  data() {
    return {
      IndexEightLatest: IndexEightLatest,
    };
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
