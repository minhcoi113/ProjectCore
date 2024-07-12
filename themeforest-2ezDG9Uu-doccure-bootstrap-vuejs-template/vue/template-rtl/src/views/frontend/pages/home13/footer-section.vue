<template>
  <footer class="footer footer-sec-fourteen">
    <div class="footer-top">
      <div class="row">
        <div class="col-sm-3 col-6 p-0">
          <div class="footer-img">
            <img
              src="@/assets/img/service/footer-img-01.jpg"
              class="img-fluid w-100"
              alt="Img"
            />
          </div>
        </div>
        <div class="col-sm-3 col-6 p-0">
          <div class="footer-img">
            <img
              src="@/assets/img/service/footer-img-02.jpg"
              class="img-fluid w-100"
              alt="Img"
            />
          </div>
        </div>
        <div class="col-sm-3 col-6 p-0">
          <div class="footer-img">
            <img
              src="@/assets/img/service/footer-img-03.jpg"
              class="img-fluid w-100"
              alt="Img"
            />
          </div>
        </div>
        <div class="col-sm-3 col-6 p-0">
          <div class="footer-img">
            <img
              src="@/assets/img/service/footer-img-04.jpg"
              class="img-fluid w-100"
              alt="Img"
            />
          </div>
        </div>
      </div>
    </div>
    <div class="footer-middle">
      <div class="container">
        <div class="footer-mid-content">
          <p>Would you like to connect with us</p>
          <ul class="social-icons">
            <li>
              <a href="javascript:void(0);"><i class="fa-brands fa-facebook-f"></i></a>
            </li>
            <li>
              <a href="javascript:void(0);"><i class="fa-brands fa-twitter"></i></a>
            </li>
            <li>
              <a href="javascript:void(0);"><i class="fa-brands fa-linkedin-in"></i></a>
            </li>
            <li>
              <a href="javascript:void(0);"><i class="fa-brands fa-youtube"></i></a>
            </li>
          </ul>
        </div>
      </div>
    </div>
    <div class="footer-mid-two">
      <div class="container">
        <div class="row">
          <div class="col-xl-4 col-md-6 col-sm-12">
            <div class="footer-logo-col">
              <div class="footer-logo">
                <img src="@/assets/img/icons/footer-logo-.svg" alt="Img" />
              </div>
              <p>
                Connect with healthcare professionals, manage appointments & prioritize
                your well being
              </p>
              <form action="index-13">
                <div class="input-block">
                  <span class="mail-icons"><i class="feather-mail"></i></span>
                  <input
                    type="text"
                    class="form-control"
                    placeholder="Enter You Email Here"
                  />
                  <button class="btn" type="submit">Subscribe</button>
                </div>
              </form>
            </div>
          </div>
          <div class="col-xl-2 col-md-3 col-sm-6">
            <div class="footer-links-middle">
              <h4>QUICK LINKS</h4>
              <ul>
                <li><router-link to="/">Home</router-link></li>
                <li><router-link to="about-us">About us</router-link></li>
                <li><router-link to="payment">Payments</router-link></li>
                <li><router-link to="booking">Lab Test</router-link></li>
              </ul>
            </div>
          </div>
          <div class="col-xl-2 col-md-3 col-sm-6">
            <div class="footer-links-middle">
              <h4>SERVICES</h4>
              <ul>
                <li><router-link to="search-2">Nurse at Home</router-link></li>
                <li><router-link to="search-2">Physiotherapy</router-link></li>
                <li><router-link to="search-2">Medical Equipment</router-link></li>
                <li>
                  <router-link to="booking-2">Doctor Consultation</router-link>
                </li>
              </ul>
            </div>
          </div>
          <div class="col-xl-2 col-md-4 col-sm-6">
            <div class="footer-links-middle">
              <h4>CONSUMER POLICY</h4>
              <ul>
                <li><router-link to="privacy-policy">Privacy</router-link></li>
                <li>
                  <router-link to="terms-condition">Terms and Condition</router-link>
                </li>
                <li><router-link to="booking">Aggrements</router-link></li>
                <li><router-link to="map-grid">Sitemap</router-link></li>
              </ul>
            </div>
          </div>
          <div class="col-xl-2 col-md-4 col-sm-6">
            <div class="footer-links-middle">
              <h4>QUICK CONTACT</h4>
              <ul>
                <li>
                  <span><i class="feather-mail"></i></span>max@example.com
                </li>
                <li>
                  <span><i class="feather-phone"></i></span>+91 XXXXX YYYY65
                </li>
                <li>
                  <span><i class="feather-clock"></i></span>We are available 24*7
                </li>
              </ul>
            </div>
          </div>
        </div>
        <div class="footer-bottom">
          <ul class="payment-method">
            <li>
              <a href="#"
                ><img src="@/assets/img/icons/footer-card-icon-01.svg" alt="Img"
              /></a>
            </li>
            <li>
              <a href="#"
                ><img src="@/assets/img/icons/footer-card-icon-02.svg" alt="Img"
              /></a>
            </li>
            <li>
              <a href="#"
                ><img src="@/assets/img/icons/footer-card-icon-03.svg" alt="Img"
              /></a>
            </li>
            <li>
              <a href="#"
                ><img src="@/assets/img/icons/footer-card-icon-04.svg" alt="Img"
              /></a>
            </li>
          </ul>
          <div class="footer-select-drops">
            <div class="input-select">
              <span class="select-icon"><i class="feather-globe"></i></span>
              <vue-select
                :options="LocationSection"
                id="locationsection"
                placeholder="India"
              />
            </div>
            <div class="input-select">
              <vue-select :options="USD" id="usd" placeholder="USD" />
            </div>
          </div>
        </div>
        <div class="copy-right text-center">
          <p>Copyright © 2024 Doccure Homecare. All rights are reserved.</p>
        </div>
      </div>
    </div>
  </footer>
</template>
<script>
export default {
  data() {
    return {
      USD: ["USD", "INR"],
      LocationSection: ["India", "USA"],
    };
  },
};
</script>
