<template>
  <section class="section deals-section">
    <div class="container">
      <div class="pharmacy-section-header">
        <div class="row align-items-center">
          <div class="col-md-6">
            <div class="pharmacy-title">
              <h4>Great deals on top picks</h4>
            </div>
          </div>
          <div class="col-md-6">
            <div class="pharmacy-title-link">
              <router-link to="product-all"
                >View All <i class="fa-solid fa-arrow-right"></i
              ></router-link>
            </div>
          </div>
        </div>
      </div>
      <div class="deals-list">
        <ul class="nav">
          <li v-for="record in Pharmacy" :key="record.id">
            <div class="deals-grid">
              <div class="deals-box">
                <img
                  :src="require(`@/assets/img/deals/${record.Image}`)"
                  alt="Deals Img"
                />
              </div>
              <div class="deals-content">
                <router-link to="product-all">{{ record.Name }}</router-link>
              </div>
            </div>
          </li>
        </ul>
      </div>
    </div>
  </section>
</template>
<script>
import Pharmacy from "@/assets/json/pharmacy.json";
export default {
  data() {
    return {
      Pharmacy: Pharmacy,
    };
  },
};
</script>
