<template>
  <div class="pharmacy-body">
    <div class="main-wrapper">
      <!-- Top Header -->
      <top-header></top-header>
      <!-- /Top Header -->

      <!-- Cart Section -->
      <cart-section></cart-section>
      <!-- /Cart Section -->

      <header class="header" :class="{  'header-space': isScrolled }">
        <div class="container">
          <nav class="navbar navbar-expand-lg header-nav">
            <div class="navbar-header">
              <a id="mobile_btn" href="javascript:void(0);">
                <span class="bar-icon">
                  <span></span>
                  <span></span>
                  <span></span>
                </span>
              </a>
              <router-link to="/" class="navbar-brand logo">
                <img src="@/assets/img/logo.png" class="img-fluid" alt="Logo" />
              </router-link>
            </div>
            <div class="browse-categorie">
              <div class="dropdown categorie-dropdown">
                <a
                  href="javascript:void(0);"
                  class="dropdown-toggle"
                  data-bs-toggle="dropdown"
                >
                  <img src="@/assets/img/icons/browse-categorie.svg" alt="" /> Browse
                  Categories
                </a>
                <div class="dropdown-menu">
                  <a class="dropdown-item" href="javascript:void(0);">Ayush</a>
                  <a class="dropdown-item" href="javascript:void(0);">Covid Essentials</a>
                  <a class="dropdown-item" href="javascript:void(0);">Devices</a>
                  <a class="dropdown-item" href="javascript:void(0);">Glucometers</a>
                </div>
              </div>
            </div>
            <mainmenu></mainmenu>
          </nav>
        </div>
      </header>

      <!-- Pharmacy Banner -->
      <pharmacy-banner></pharmacy-banner>
      <!-- /Pharmacy Banner -->

      <!-- Welcome Section -->
      <welcome-section></welcome-section>
      <!-- /Welcome Section -->

      <!-- Deals Section -->
      <deals-section></deals-section>
      <!-- /Deals Section -->

      <!-- Categories Section -->
      <categories-section></categories-section>
      <!-- /Categories Section -->

      <!-- Seller Section -->
      <seller-section></seller-section>
      <!-- /Seller Section -->

      <!-- Feature Products Section -->
      <feature-section></feature-section>
      <!-- /Feature Products Section -->

      <!-- Recent Products Section -->
      <product-section></product-section>
      <!-- /Recent Products Section -->

      <!-- Coupon Section -->
      <coupon-section></coupon-section>
      <!-- /Coupon Section -->

      <!-- Best Selling Products Section -->
      <best-section></best-section>
      <!-- /Best Selling Products Section -->

      <!-- Trusted Section -->
      <trusted-section></trusted-section>
      <!-- /Trusted Section -->

      <!-- Review Section -->
      <review-section></review-section>
      <!-- /Review Section -->

      <!-- News Section -->
      <news-section></news-section>
      <!-- News Section -->

      <!-- App Section -->
      <app-section></app-section>
      <!-- /App Section -->

      <!-- Footer Section -->
      <footer-section></footer-section>
      <!-- /Footer Section -->
    </div>
  </div>
</template>
<script>
export default {
  data() {
    return {
      isScrolled: false,
    }
  },
  mounted() {
    // Add a scroll event listener when the component is mounted
    window.addEventListener("scroll", this.handleScroll);
  },
  beforeUnmount() {
    // Remove the scroll event listener when the component is about to be unmounted
    window.removeEventListener("scroll", this.handleScroll);
  },
  methods: {
    handleScroll() {
      // Get the scroll position
      const scroll = window.scrollY;

      // Update the isScrolled data property based on the scroll position
      this.isScrolled = scroll > 35;
    },
  },
}
</script>