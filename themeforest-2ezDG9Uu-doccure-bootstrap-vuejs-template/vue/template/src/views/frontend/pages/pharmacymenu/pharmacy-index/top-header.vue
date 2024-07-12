<template>
  <div class="top-header">
    <div class="container">
      <div class="row align-items-center">
        <div class="col-md-6">
          <div class="special-offer-content">
            <p>
              Special offer! Get -20% off for first order with minimum
              <span>$200.00</span> in cart.
            </p>
          </div>
        </div>
        <div class="col-md-6">
          <div class="top-header-right">
            <ul class="nav">
              <li>
                <div class="dropdown lang-dropdown">
                  <a
                    href="javascript:void(0);"
                    class="dropdown-toggle nav-link"
                    data-bs-toggle="dropdown"
                  >
                    English
                  </a>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="javascript:void(0);">French</a>
                    <a class="dropdown-item" href="javascript:void(0);">Spanish</a>
                    <a class="dropdown-item" href="javascript:void(0);">German</a>
                  </div>
                </div>
                <div class="dropdown lang-dropdown">
                  <a
                    href="javascript:void(0);"
                    class="dropdown-toggle nav-link"
                    data-bs-toggle="dropdown"
                  >
                    USD
                  </a>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="javascript:void(0);">Euro</a>
                    <a class="dropdown-item" href="javascript:void(0);">INR</a>
                    <a class="dropdown-item" href="javascript:void(0);">Dinar</a>
                  </div>
                </div>
              </li>
              <li>
                <div class="btn log-register">
                  <router-link to="/login" class="me-1">
                    <span><i class="feather-user"></i></span> Sign In
                  </router-link>
                  /
                  <router-link to="/register" class="ms-1">Sign Up</router-link>
                </div>
              </li>
            </ul>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
