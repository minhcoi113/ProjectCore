<template>
  <section class="section products-sec recent-product-sec">
    <div class="container">
      <div class="pharmacy-section-header">
        <div class="row align-items-center">
          <div class="col-md-6">
            <div class="pharmacy-title">
              <h4>Recent Products</h4>
            </div>
          </div>
          <div class="col-md-6">
            <div class="pharmacy-title-link">
              <router-link to="product-all"
                >See All <i class="fa-solid fa-arrow-right"></i
              ></router-link>
            </div>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-lg-3 col-md-4 col-sm-6">
          <div class="products-card">
            <div class="product-card-img">
              <router-link to="product-all"
                ><img src="@/assets/img/products/product-27.png" alt=""
              /></router-link>
            </div>
            <div class="product-content">
              <h6>Home & Health</h6>
              <h4><router-link to="product-all">Cold Relief Tablet</router-link></h4>
              <span class="badge">60 pills</span>
              <div class="product-cart">
                <div class="cart-price">
                  <h5>$150<span>$199</span></h5>
                </div>
                <router-link to="product-all" class="cart-icon">
                  <i class="feather-shopping-bag"></i>
                </router-link>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-3 col-md-4 col-sm-6">
          <div class="products-card">
            <div class="product-card-img">
              <router-link to="product-all"
                ><img src="@/assets/img/products/product-28.png" alt=""
              /></router-link>
            </div>
            <div class="product-content">
              <h6>Weight</h6>
              <h4><router-link to="product-all">Protein Bars</router-link></h4>
              <span class="badge">65 g</span>
              <div class="product-cart">
                <div class="cart-price">
                  <h5>$120<span>$150</span></h5>
                </div>
                <div class="cart-count">
                  <div class="custom-increment cart">
                    <div class="input-group1">
                      <span class="input-group-btn">
                        <button
                          type="button"
                          class="quantity-left-minus3 btn btn-danger btn-number"
                          data-type="minus"
                          data-field=""
                        >
                          <span><i class="fas fa-minus"></i></span>
                        </button>
                      </span>
                      <input
                        type="text"
                        id="quantity3"
                        name="quantity3"
                        class="input-number"
                        value="10"
                      />
                      <span class="input-group-btn">
                        <button
                          type="button"
                          class="quantity-right-plus3 btn btn-success btn-number"
                          data-type="plus"
                          data-field=""
                        >
                          <span><i class="fas fa-plus"></i></span>
                        </button>
                      </span>
                    </div>
                  </div>
                  <router-link to="product-all" class="cart-icon check-icon">
                    <i class="feather-check"></i>
                  </router-link>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-3 col-md-4 col-sm-6">
          <div class="products-card">
            <div class="product-card-img">
              <router-link to="product-all"
                ><img src="@/assets/img/products/product-29.png" alt=""
              /></router-link>
            </div>
            <div class="product-content">
              <h6>Home & Health</h6>
              <h4><router-link to="product-all">Acetoheal</router-link></h4>
              <span class="badge">40 pills</span>
              <span class="sticker">5% OFF</span>
              <div class="product-cart">
                <div class="cart-price">
                  <h5>$250<span>$350</span></h5>
                </div>
                <router-link to="product-all" class="cart-icon">
                  <i class="feather-shopping-bag"></i>
                </router-link>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-3 col-md-4 col-sm-6">
          <div class="products-card">
            <div class="product-card-img">
              <router-link to="product-all"
                ><img src="@/assets/img/products/product-30.png" alt=""
              /></router-link>
            </div>
            <div class="product-content">
              <h6>Weight</h6>
              <h4><router-link to="product-all">Apexitecan</router-link></h4>
              <span class="badge">20 pills</span>
              <div class="product-cart">
                <div class="cart-price">
                  <h5>$279<span>$300</span></h5>
                </div>
                <router-link to="product-all" class="cart-icon">
                  <i class="feather-shopping-bag"></i>
                </router-link>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-3 col-md-4 col-sm-6 d-flex">
          <div class="products-card w-100">
            <div class="product-icon">
              <span><img src="@/assets/img/icons/product-icon-01.svg" alt="" /></span>
            </div>
            <div class="product-content">
              <h4>Free Shipping</h4>
              <p>Free shipping with discount</p>
            </div>
          </div>
        </div>
        <div class="col-lg-3 col-md-4 col-sm-6 d-flex">
          <div class="products-card w-100">
            <div class="product-icon">
              <span><img src="@/assets/img/icons/product-icon-02.svg" alt="" /></span>
            </div>
            <div class="product-content">
              <h4>Great Support 24/7</h4>
              <p>Instant access to Contact</p>
            </div>
          </div>
        </div>
        <div class="col-lg-3 col-md-4 col-sm-6 d-flex">
          <div class="products-card w-100">
            <div class="product-icon">
              <span><img src="@/assets/img/icons/product-icon-03.svg" alt="" /></span>
            </div>
            <div class="product-content">
              <h4>100% Sucure Payment</h4>
              <p>We ensure your money is save</p>
            </div>
          </div>
        </div>
        <div class="col-lg-3 col-md-4 col-sm-6 d-flex">
          <div class="products-card w-100">
            <div class="product-icon">
              <span><img src="@/assets/img/icons/product-icon-04.svg" alt="" /></span>
            </div>
            <div class="product-content">
              <h4>Money-Back Guarantee</h4>
              <p>30 days money-back guarantee</p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>
