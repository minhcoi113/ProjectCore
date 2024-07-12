<template>
  <section class="section products-sec recent-product-sec">
    <div class="container">
      <div class="pharmacy-section-header">
        <div class="row align-items-center">
          <div class="col-md-6">
            <div class="pharmacy-title">
              <h4>Best Weekly Selling Products</h4>
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
        <div class="col-lg-3 col-md-6 col-sm-6">
          <div class="products-card">
            <div class="product-card-img">
              <router-link to="product-all"
                ><img src="@/assets/img/products/product-31.png" alt=""
              /></router-link>
            </div>
            <div class="product-content">
              <h6>Women’s Care</h6>
              <h4><router-link to="product-all">Hemoglobin Tablets</router-link></h4>
              <h5 class="delivery">Delivery : <span>Tomorrow</span></h5>
              <div class="product-cart">
                <div class="cart-price">
                  <h5>$200<span>$300</span></h5>
                </div>
                <div class="cart-count">
                  <div class="custom-increment cart">
                    <div class="input-group1">
                      <span class="input-group-btn">
                        <button
                          type="button"
                          class="quantity-left-minus4 btn btn-danger btn-number"
                          data-type="minus"
                          data-field=""
                        >
                          <span><i class="fas fa-minus"></i></span>
                        </button>
                      </span>
                      <input
                        type="text"
                        id="quantity4"
                        name="quantity4"
                        class="input-number"
                        value="10"
                      />
                      <span class="input-group-btn">
                        <button
                          type="button"
                          class="quantity-right-plus4 btn btn-success btn-number"
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
        <div class="col-lg-3 col-md-6 col-sm-6">
          <div class="products-card">
            <div class="product-card-img">
              <router-link to="product-all"
                ><img src="@/assets/img/products/product-32.png" alt=""
              /></router-link>
            </div>
            <div class="product-content">
              <h6>Oral Care</h6>
              <h4><router-link to="product-all">Croformin</router-link></h4>
              <h5 class="delivery">Delivery : <span>2 day</span></h5>
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
        <div class="col-lg-3 col-md-6 col-sm-6">
          <div class="products-card">
            <div class="product-card-img">
              <router-link to="product-all"
                ><img src="@/assets/img/products/product-33.png" alt=""
              /></router-link>
            </div>
            <div class="product-content">
              <h6>Home & Health</h6>
              <h4><router-link to="product-all">Fish Oil Capsules</router-link></h4>
              <h5 class="delivery">Delivery : <span>1 day</span></h5>
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
        <div class="col-lg-3 col-md-6 col-sm-6">
          <div class="products-card">
            <div class="product-card-img">
              <router-link to="product-all"
                ><img src="@/assets/img/products/product-34.png" alt=""
              /></router-link>
            </div>
            <div class="product-content">
              <h6>Home & Health</h6>
              <h4><router-link to="product-all">Multivitamin Tablets</router-link></h4>
              <h5 class="delivery">Delivery : <span>1 day</span></h5>
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
      </div>
      <div class="row">
        <div class="col-md-6 d-flex">
          <div class="best-sell-box w-100">
            <h5>Get Flat 5% Simpl Cashback of up to Rs. 500*!..</h5>
            <p>
              Get Flat 5% Simpl Cashback of up to Rs. 500 on your FIRST-EVER payment via
              Simpl for ANY purchases* ..
            </p>
          </div>
        </div>
        <div class="col-md-6 d-flex">
          <div class="best-sell-box box-two w-100">
            <h5>Get assured Cashback of up to Rs. 500* + Earn up to 8X rewards*..</h5>
            <p>
              ALL users get assured Cashback of max. Rs. 500 on ONLY one transaction of
              min. Rs 999 Up to 8X Rewar..
            </p>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>
