<template>
  <section class="section products-sec">
    <div class="container">
      <div class="pharmacy-section-header">
        <div class="row align-items-center">
          <div class="col-md-6">
            <div class="pharmacy-title">
              <h4>Featured Products</h4>
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
      <div class="row justify-content-center">
        <div class="col-lg-3 col-md-4">
          <div class="products-card">
            <div class="product-card-img">
              <router-link to="product-all"
                ><img src="@/assets/img/products/product-19.png" alt=""
              /></router-link>
            </div>
            <div class="product-content">
              <h6>Home & Health</h6>
              <h4><router-link to="product-all">Vitamin Tablets</router-link></h4>
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
        <div class="col-lg-3 col-md-4">
          <div class="products-card">
            <div class="product-card-img">
              <router-link to="product-all"
                ><img src="@/assets/img/products/product-20.png" alt=""
              /></router-link>
            </div>
            <div class="product-content">
              <h6>Women’s Care</h6>
              <h4><router-link to="product-all">Amber Tonic</router-link></h4>
              <span class="badge">250 ml</span>
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
                          class="quantity-left-minus btn btn-danger btn-number"
                          data-type="minus"
                          data-field=""
                        >
                          <span><i class="fas fa-minus"></i></span>
                        </button>
                      </span>
                      <input
                        type="text"
                        id="quantity"
                        name="quantity"
                        class="input-number"
                        value="10"
                      />
                      <span class="input-group-btn">
                        <button
                          type="button"
                          class="quantity-right-plus btn btn-success btn-number"
                          data-type="plus"
                          data-field=""
                        >
                          <span><i class="fas fa-plus"></i></span>
                        </button>
                      </span>
                    </div>
                  </div>
                  <a href="" class="cart-icon check-icon">
                    <i class="feather-check"></i>
                  </a>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-3 col-md-4">
          <div class="products-card">
            <div class="product-card-img">
              <router-link to="product-all"
                ><img src="@/assets/img/products/product-21.png" alt=""
              /></router-link>
            </div>
            <div class="product-content">
              <h6>Weight</h6>
              <h4><router-link to="product-all">Prexolol</router-link></h4>
              <span class="badge">50 pills</span>
              <div class="product-cart">
                <div class="cart-price">
                  <h5>$370<span>$450</span></h5>
                </div>
                <router-link to="product-all" class="cart-icon">
                  <i class="feather-shopping-bag"></i>
                </router-link>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-3 col-md-4">
          <div class="products-card">
            <div class="product-card-img">
              <router-link to="product-all"
                ><img src="@/assets/img/products/product-22.png" alt=""
              /></router-link>
            </div>
            <div class="product-content">
              <h6>Oral Care</h6>
              <h4><router-link to="product-all">Pain Killer</router-link></h4>
              <span class="badge">30 pills</span>
              <span class="sticker">5% OFF</span>
              <div class="product-cart">
                <div class="cart-price">
                  <h5>$430<span>$690</span></h5>
                </div>
                <router-link to="product-all" class="cart-icon">
                  <i class="feather-shopping-bag"></i>
                </router-link>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-3 col-md-4">
          <div class="products-card">
            <div class="product-card-img">
              <router-link to="product-all"
                ><img src="@/assets/img/products/product-23.png" alt=""
              /></router-link>
            </div>
            <div class="product-content">
              <h6>Women’s Care</h6>
              <h4><router-link to="product-all">Healizone</router-link></h4>
              <span class="badge">20 pills</span>
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
                          class="quantity-left-minus2 btn btn-danger btn-number"
                          data-type="minus"
                          data-field=""
                        >
                          <span><i class="fas fa-minus"></i></span>
                        </button>
                      </span>
                      <input
                        type="text"
                        id="quantity2"
                        name="quantity2"
                        class="input-number"
                        value="10"
                      />
                      <span class="input-group-btn">
                        <button
                          type="button"
                          class="quantity-right-plus2 btn btn-success btn-number"
                          data-type="plus"
                          data-field=""
                        >
                          <span><i class="fas fa-plus"></i></span>
                        </button>
                      </span>
                    </div>
                  </div>
                  <a href="" class="cart-icon check-icon">
                    <i class="feather-check"></i>
                  </a>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-3 col-md-4">
          <div class="products-card">
            <div class="product-card-img">
              <router-link to="product-all"
                ><img src="@/assets/img/products/product-24.png" alt=""
              /></router-link>
            </div>
            <div class="product-content">
              <h6>Home & Health</h6>
              <h4><router-link to="product-all">Calcium Tablets</router-link></h4>
              <span class="badge">30 pills</span>
              <div class="product-cart">
                <div class="cart-price">
                  <h5>$130<span>$150</span></h5>
                </div>
                <router-link to="product-all" class="cart-icon">
                  <i class="feather-shopping-bag"></i>
                </router-link>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-3 col-md-4">
          <div class="products-card">
            <div class="product-card-img">
              <router-link to="product-all"
                ><img src="@/assets/img/products/product-25.png" alt=""
              /></router-link>
            </div>
            <div class="product-content">
              <h6>Home & Health</h6>
              <h4><router-link to="product-all">Iron Tablets</router-link></h4>
              <span class="badge">60 pills</span>
              <span class="sticker">5% OFF</span>
              <div class="product-cart">
                <div class="cart-price">
                  <h5>$230<span>$250</span></h5>
                </div>
                <router-link to="product-all" class="cart-icon">
                  <i class="feather-shopping-bag"></i>
                </router-link>
              </div>
            </div>
          </div>
        </div>
        <div class="col-lg-3 col-md-4">
          <div class="products-card">
            <div class="product-card-img">
              <router-link to="product-all"
                ><img src="@/assets/img/products/product-26.png" alt=""
              /></router-link>
            </div>
            <div class="product-content">
              <h6>Baby Care</h6>
              <h4><router-link to="product-all">Cough Syrup</router-link></h4>
              <span class="badge">250 ml</span>
              <div class="product-cart">
                <div class="cart-price">
                  <h5>$320<span>$400</span></h5>
                </div>
                <router-link to="product-all" class="cart-icon">
                  <i class="feather-shopping-bag"></i>
                </router-link>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>
