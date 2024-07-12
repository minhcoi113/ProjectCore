<template>
  <section class="section categorie-section">
    <div class="container">
      <div class="pharmacy-section-header">
        <div class="row">
          <div class="col-md-12">
            <div class="pharmacy-title mb-0">
              <h4>Shop Popular Categories</h4>
            </div>
          </div>
        </div>
      </div>
      <div class="categorie-info">
        <div class="row">
          <div
            class="col-xl-2 col-lg-3 col-md-4 d-flex"
            v-for="record in Categories_Section"
            :key="record.id"
          >
            <div class="categorie-grid flex-fill">
              <div class="categorie-img">
                <router-link to="product-all">
                  <img
                    :src="require(`@/assets/img/category/${record.Image}`)"
                    alt="Categorie Img"
                  />
                </router-link>
              </div>
              <div class="categorie-content">
                <h5>
                  <router-link to="product-all">{{ record.Name }}</router-link>
                </h5>
                <p>{{ record.Product }}</p>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-md-6 d-flex">
          <div class="categorie-card cash-card">
            <div class="categorie-details">
              <h4>Cash On delivery Available</h4>
              <p>Order Now, Pay Later</p>
            </div>
            <div class="categorie-btn">
              <router-link to="product-all" class="btn">
                <img src="@/assets/img/icons/order-icon.svg" alt="Order Icon" /> Order Now
              </router-link>
            </div>
            <div class="categorie-shapes">
              <div class="categorie-shape-top">
                <img src="@/assets/img/shapes/shape-11.png" alt="Shape Img" />
              </div>
              <div class="categorie-shape-bottom">
                <img src="@/assets/img/shapes/shape-12.png" alt="Shape Img" />
              </div>
            </div>
          </div>
        </div>
        <div class="col-md-6 d-flex">
          <div class="categorie-card sale-card">
            <div class="categorie-details">
              <h4>Sale of the Month</h4>
              <p>Offer Prices in all medecines</p>
            </div>
            <div class="categorie-btn">
              <router-link to="product-all" class="btn"
                >View Medicines
                <img src="@/assets/img/icons/medicine-icon.svg" alt="Medicine Icon" />
              </router-link>
            </div>
            <div class="categorie-shapes">
              <div class="categorie-shape-top">
                <img src="@/assets/img/shapes/shape-11.png" alt="Shape Img" />
              </div>
              <div class="categorie-shape-bottom">
                <img src="@/assets/img/shapes/shape-12.png" alt="Shape Img" />
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>
<script>
import Categories_Section from "@/assets/json/categories-section.json";
export default {
  data() {
    return {
      Categories_Section: Categories_Section,
    };
  },
};
</script>
