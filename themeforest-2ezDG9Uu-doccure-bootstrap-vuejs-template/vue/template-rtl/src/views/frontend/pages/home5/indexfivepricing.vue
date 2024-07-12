<template>
  <!-- Pricing -->
  <section class="pricing-section pricing-section-ten">
    <div class="container">
      <div class="row">
        <div class="col-md-12 text-center aos" data-aos="fade-up">
          <div class="section-header-one section-header-slider">
            <h2 class="section-title">Our <span>Pricing</span></h2>
            <div class="pricing-options">
              <p>Choose the package that best suit you</p>
              <div class="options-group">
                <span>Monthly</span>
                <div class="form-check form-switch">
                  <input
                    class="form-check-input"
                    type="checkbox"
                    role="switch"
                    id="flexSwitchCheckDefault"
                  />
                </div>
                <span>Yearly <span class="discount-plan">30% discount</span></span>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="row justify-content-center align-items-center">
        <div class="col-lg-3 col-md-6 col-sm-12 aos" data-aos="fade-up">
          <div class="card pricing-card pricing-card-active">
            <div class="card-body">
              <div class="pricing-header">
                <div class="pricing-header-info">
                  <div class="pricing-title">
                    <h4>Free</h4>
                  </div>
                  <div class="pricing-tag">
                    <div><img src="@/assets/img/bg/heart-plus.png" alt="icon" /></div>
                  </div>
                </div>
              </div>
              <div class="pricing-info">
                <div class="pricing-amount">
                  <h2>$0</h2>
                  <span>per month</span>
                </div>
                <div class="pricing-btn">
                  <router-link to="/pricing" class="btn">Choose Plan</router-link>
                </div>
                <div class="pricing-list">
                  <ul>
                    <li>100 conversations p/m</li>
                    <li>10 websites</li>
                    <li>2 GB data storage</li>
                  </ul>
                </div>
                <div class="pricing-list pricing-list-two">
                  <ul>
                    <li>Chat widget</li>
                    <li>Real time support</li>
                  </ul>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div
          class="col-lg-3 col-md-6 col-sm-12 aos"
          v-for="item in IndexFivePricing"
          :key="item.id"
          data-aos="fade-up"
        >
          <div class="card pricing-card">
            <div class="card-body">
              <div class="pricing-header">
                <div class="pricing-header-info">
                  <div class="pricing-title">
                    <h4>{{ item.title }}</h4>
                  </div>
                </div>
              </div>
              <div class="pricing-info">
                <div class="pricing-amount">
                  <h2>{{ item.amount }}</h2>
                  <span>{{ item.per_month }}</span>
                </div>
                <div class="pricing-btn">
                  <router-link to="pricing" class="btn">{{
                    item.button_text
                  }}</router-link>
                </div>
                <div class="pricing-list">
                  <ul>
                    <li>{{ item.features }}</li>
                    <li>{{ item.websites }}</li>
                    <li>{{ item.data }}</li>
                  </ul>
                </div>
                <div class="pricing-list pricing-list-two">
                  <ul>
                    <li>{{ item.widget }}</li>
                    <li>{{ item.Real }}</li>
                  </ul>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- /Pricing -->

  <!-- FAQ Section -->
  <section class="faq-section faq-section-ten">
    <div class="floating-bg">
      <img src="@/assets/img/bg/health-care.png" alt="Image" />
    </div>
    <div class="container">
      <div class="row align-items-center">
        <div class="col-lg-6 col-md-12 aos" data-aos="fade-up">
          <div class="faq-img">
            <img src="@/assets/img/faq-img-2.jpg" class="img-fluid" alt="img" />
          </div>
        </div>
        <div class="col-lg-6 col-md-12">
          <div class="section-header-one aos" data-aos="fade-up">
            <h2 class="section-title">Frequently Asked <span>Questions?</span></h2>
          </div>
          <div class="faq-info aos" data-aos="fade-up">
            <div class="accordion" id="faq-details">
              <!-- FAQ Item -->
              <div class="accordion-item" v-for="item in IndexfiveFaq" :key="item.id">
                <h2 class="accordion-header" :id="item.faqid">
                  <a
                    href="javascript:void(0);"
                    :class="item.accordion"
                    data-bs-toggle="collapse"
                    :data-bs-target="item.target"
                    :aria-expanded="item.expanded"
                    :aria-controls="item.targetid"
                  >
                    {{ item.question }}
                  </a>
                </h2>
                <div
                  :id="item.targetid"
                  :class="item.class"
                  :aria-labelledby="item.faqid"
                  data-bs-parent="#faq-details"
                >
                  <div class="accordion-body">
                    <div class="accordion-content">
                      <p>{{ item.answer }}</p>
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
import IndexfiveFaq from "@/assets/json/indexfivefaq.json";
import IndexFivePricing from "@/assets/json/indexfivepricing.json";
export default {
  data() {
    return {
      IndexfiveFaq: IndexfiveFaq,
      IndexFivePricing: IndexFivePricing,
    };
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
