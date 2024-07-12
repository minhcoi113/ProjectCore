<template>
  <div class="cart-section">
    <div class="container">
      <div class="row align-items-center">
        <div class="col-md-3">
          <div class="cart-logo">
            <router-link to="/">
              <img src="@/assets/img/logo.png" class="img-fluid" alt="Logo" />
            </router-link>
          </div>
        </div>
        <div class="col-md-6">
          <div class="cart-search">
            <form action="pharmacy-search">
              <div class="enter-pincode">
                <i class="feather-map-pin"></i>
                <div class="enter-pincode-input">
                  <input type="text" class="form-control" placeholder="Enter Pincode" />
                </div>
              </div>
              <div class="cart-search-input">
                <input
                  type="text"
                  class="form-control"
                  placeholder="Search for medicines, health products and more"
                />
              </div>
              <div class="cart-search-btn">
                <button type="submit" class="btn">
                  <i class="feather-search"></i>
                </button>
              </div>
            </form>
          </div>
        </div>
        <div class="col-md-3">
          <div class="shopping-cart-list">
            <ul class="nav">
              <li>
                <a href="javascript:void(0);">
                  <img src="@/assets/img/icons/cart-favourite.svg" alt="" />
                </a>
              </li>
              <li>
                <div class="shopping-cart-amount">
                  <div class="shopping-cart-icon">
                    <img src="@/assets/img/icons/shopping-bag.svg" alt="" />
                    <span>2</span>
                  </div>
                  <div class="shopping-cart-content">
                    <p>Shopping cart</p>
                    <h6>$57.00</h6>
                  </div>
                </div>
              </li>
            </ul>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
