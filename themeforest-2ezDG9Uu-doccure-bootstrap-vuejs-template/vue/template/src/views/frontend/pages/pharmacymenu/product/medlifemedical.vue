<template>
  <div class="col-md-7 col-lg-9 col-xl-9">
    <div class="row align-items-center pb-3">
      <div class="col-md-4 col-12 d-md-block d-none custom-short-by">
        <h3 class="title pharmacy-title">Medlife Medical</h3>
        <p class="doc-location mb-2 text-ellipse pharmacy-location">
          <i class="fas fa-map-marker-alt me-1"></i> 96 Red Hawk Road Cyrus, MN 56323
        </p>
        <span class="sort-title">Showing 6 of 98 products</span>
      </div>
      <div class="col-md-8 col-12 d-md-block d-none custom-short-by">
        <div class="sort-by pb-3">
          <span class="sort-title">Sort by</span>
          <span class="sortby-fliter">
            <vue-select :options="Select" placeholder="Select" />
          </span>
        </div>
      </div>
    </div>

    <div class="row">
      <div
        class="col-md-12 col-lg-4 col-xl-4 product-custom"
        v-for="item in productall"
        :key="item.id"
      >
        <div class="profile-widget">
          <div class="doc-img">
            <router-link to="product-description" tabindex="-1">
              <img
                class="img-fluid"
                alt="Product image"
                :src="require(`@/assets/img/products/${item.image}`)"
              />
            </router-link>
            <a href="javascript:void(0)" class="fav-btn" tabindex="-1">
              <i class="far fa-bookmark"></i>
            </a>
          </div>
          <div class="pro-content">
            <h3 class="title pb-4">
              <router-link to="product-description" tabindex="-1">{{
                item.name
              }}</router-link>
            </h3>
            <div class="row align-items-center">
              <div class="col-lg-6">
                <span class="price">{{ item.price }}</span>
                <span class="price-strike">{{ item.strike_price }}</span>
              </div>
              <div class="col-lg-6 text-end">
                <router-link to="cart" class="cart-icon"
                  ><i class="fas fa-shopping-cart"></i
                ></router-link>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="col-md-12 text-center">
      <a href="javascript:;" class="btn book-btn1 mb-4">Load More</a>
    </div>
  </div>
</template>
<script>
import productall from "@/assets/json/pharmacy/productall.json";
export default {
  data() {
    return {
      productall: productall,
      Select: ["Rating", "Popular", "Latest", "Free"],
    };
  },
};
</script>
