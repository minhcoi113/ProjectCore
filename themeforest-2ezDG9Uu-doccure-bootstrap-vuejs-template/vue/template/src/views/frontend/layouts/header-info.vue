<template>
  <!-- Header -->
  <header class="header login-header-info">
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
      <div class="main-menu-wrapper">
        <div class="menu-header">
          <router-link to="/" class="menu-logo">
            <img src="@/assets/img/logo.png" class="img-fluid" alt="Logo" />
          </router-link>
          <a id="menu_close" class="menu-close" href="javascript:void(0);">
            <i class="fas fa-times"></i>
          </a>
        </div>
        <ul class="main-nav">
          <li>
            <router-link to="faq">FAQ</router-link>
          </li>
          <li>
            <router-link to="login-email">Login</router-link>
          </li>
          <li class="flag-dropdown-hide">
            <div class="flag-dropdown">
              <a
                class="dropdown-toggle"
                data-bs-toggle="dropdown"
                href="javascript:;"
                role="button"
                aria-expanded="false"
              >
                <img
                  src="@/assets/img/flags/flag-01.png"
                  alt="flag-image"
                  height="20"
                  class="flag-img"
                />
                <span>English</span>
              </a>
              <div class="dropdown-menu">
                <a href="javascript:void(0);" class="dropdown-item">
                  <img
                    src="@/assets/img/flags/flag-01.png"
                    alt="flag-image"
                    height="16"
                  />
                  English
                </a>
                <a href="javascript:void(0);" class="dropdown-item">
                  <img
                    src="@/assets/img/flags/flag-02.png"
                    alt="flag-image"
                    height="16"
                  />
                  French
                </a>
                <a href="javascript:void(0);" class="dropdown-item">
                  <img
                    src="@/assets/img/flags/flag-03.png"
                    alt="flag-image"
                    height="16"
                  />
                  Spanish
                </a>
                <a href="javascript:void(0);" class="dropdown-item">
                  <img
                    src="@/assets/img/flags/flag-05.png"
                    alt="flag-image"
                    height="16"
                  />
                  German
                </a>
              </div>
            </div>
          </li>
        </ul>
      </div>
      <ul class="nav header-navbar-rht">
        <li class="nav-item dropdown">
          <div class="flag-dropdown">
            <a
              class="dropdown-toggle nav-link"
              data-bs-toggle="dropdown"
              href="javascript:;"
              role="button"
              aria-expanded="false"
            >
              <img
                src="@/assets/img/flags/flag-01.png"
                alt="flag-image"
                height="20"
                class="flag-img"
              />
              <span>English</span>
            </a>
            <div class="dropdown-menu">
              <a href="javascript:void(0);" class="dropdown-item">
                <img src="@/assets/img/flags/flag-01.png" alt="flag-image" height="16" />
                English
              </a>
              <a href="javascript:void(0);" class="dropdown-item">
                <img src="@/assets/img/flags/flag-02.png" alt="flag-image" height="16" />
                French
              </a>
              <a href="javascript:void(0);" class="dropdown-item">
                <img src="@/assets/img/flags/flag-03.png" alt="flag-image" height="16" />
                Spanish
              </a>
              <a href="javascript:void(0);" class="dropdown-item">
                <img src="@/assets/img/flags/flag-05.png" alt="flag-image" height="16" />
                German
              </a>
            </div>
          </div>
        </li>
      </ul>
    </nav>
  </header>
  <!-- /Header -->
</template>
