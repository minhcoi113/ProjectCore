<template>
  <section class="section welcome-section">
    <div class="container">
      <div class="welcome-grid">
        <div class="row align-items-center">
          <div class="col-md-8">
            <div class="welcome-info">
              <div class="welcome-icon">
                <img src="@/assets/img/welcome-icon.png" alt="Welcome Icon" />
              </div>
              <div class="welcome-content">
                <h5>Welcome to Doccure</h5>
                <p>Download the app get free medicine & 50% off on your first order</p>
              </div>
            </div>
          </div>
          <div class="col-md-4">
            <div class="welcome-btn">
              <a href="javascript:void(0);" class="btn">Download App</a>
            </div>
            <div class="welcome-shapes">
              <div class="welcome-shape-top">
                <img src="@/assets/img/shapes/shape-9.png" alt="Shape Img" />
              </div>
              <div class="welcome-shape-bottom">
                <img src="@/assets/img/shapes/shape-10.png" alt="Shape Img" />
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="row justify-content-center">
        <div class="col-lg-4 col-md-6 d-flex">
          <div class="shop-card suppliment-card">
            <div class="row align-items-center">
              <div class="col-md-7">
                <div class="shop-content">
                  <h5>10% Cashback on Dietary <span>Suppliments</span></h5>
                  <p>Code: CARE12</p>
                  <router-link to="product-all" class="btn">Shop Now</router-link>
                </div>
              </div>
              <div class="col-md-5">
                <div class="shop-img">
                  <img src="@/assets/img/products/product-16.png" alt="Product Img" />
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-4 col-md-6 d-flex">
          <div class="shop-card freshner-card">
            <div class="row align-items-center">
              <div class="col-md-6">
                <div class="shop-content">
                  <h5><span>Say yes</span> to New Throat Freshner</h5>
                  <h6>Refresh your day the fruity way</h6>
                  <router-link to="product-all" class="btn">Shop Now</router-link>
                </div>
              </div>
              <div class="col-md-6">
                <div class="shop-img">
                  <img src="@/assets/img/products/product-17.png" alt="Product Img" />
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-4 col-md-6 d-flex">
          <div class="shop-card product-worth-card">
            <div class="row align-items-center">
              <div class="col-md-7">
                <div class="shop-content">
                  <h5>Get a Product Worth <span>1000</span> in a Pack</h5>
                  <p>Code: CARE12</p>
                  <router-link to="product-all" class="btn">Shop Now</router-link>
                </div>
              </div>
              <div class="col-md-5">
                <div class="shop-img">
                  <img src="@/assets/img/products/product-18.png" alt="Product Img" />
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>
