<template>
  <!-- Footer -->
  <footer class="footer footer-one footer-fourteen">
    <div class="footer-top aos" data-aos="fade-up">
      <div class="container">
        <div class="row">
          <div class="col-lg-3 col-md-4">
            <div class="footer-widget footer-about">
              <div class="footer-logo">
                <router-link to="/index-10"
                  ><img src="@/assets/img/logo.png" alt="logo"
                /></router-link>
              </div>
              <div class="footer-about-content">
                <p>
                  Lorem ipsum dolor sit amet, consecte adipiscing elit, sed do eiusmod
                  tempor incididunt ut labore et dolore magna ad minim veniam aliqua.
                </p>
              </div>
            </div>
          </div>
          <div class="col-lg-5">
            <div class="row">
              <div class="col-lg-3 col-md-4">
                <div class="footer-widget footer-menu">
                  <h2 class="footer-title">Company</h2>
                  <ul>
                    <li><a href="javascript:void(0);">Home</a></li>
                    <li><a href="javascript:void(0);">Specialities</a></li>
                    <li><a href="javascript:void(0);">Consult</a></li>
                  </ul>
                </div>
              </div>
              <div class="col-lg-3 col-md-4">
                <div class="footer-widget footer-menu">
                  <h2 class="footer-title">Specialities</h2>
                  <ul>
                    <li><a href="javascript:void(0);">Neurology</a></li>
                    <li><a href="javascript:void(0);">Cardiologist</a></li>
                    <li><a href="javascript:void(0);">Dentist</a></li>
                  </ul>
                </div>
              </div>
              <div class="col-lg-6 col-md-4">
                <div class="footer-widget footer-contact">
                  <h2 class="footer-title">Contact Us</h2>
                  <div class="footer-contact-info">
                    <div class="footer-address">
                      <p><i class="feather-map-pin"></i> 3556 Beech Street, USA</p>
                    </div>
                    <div class="footer-address">
                      <p><i class="feather-phone-call"></i> +1 315 369 5943</p>
                    </div>
                    <div class="footer-address mb-0">
                      <p><i class="feather-mail"></i> doccure@example.com</p>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="col-lg-4 col-md-7">
            <div class="footer-widget">
              <h2 class="footer-title">Join Our Newsletter</h2>
              <div class="subscribe-form">
                <form action="javascript:;">
                  <input
                    type="email"
                    class="form-control"
                    placeholder="Enter Email"
                  />
                  <b-button type="submit" class="btn">Submit</b-button>
                </form>
              </div>
              <div class="social-icon">
                <ul>
                  <li>
                    <a href="javascript:;" target="_blank"
                      ><i class="fab fa-facebook"></i>
                    </a>
                  </li>
                  <li>
                    <a href="javascript:;" target="_blank"
                      ><i class="fab fa-instagram"></i
                    ></a>
                  </li>
                  <li>
                    <a href="javascript:;" target="_blank"
                      ><i class="fab fa-twitter"></i>
                    </a>
                  </li>
                  <li>
                    <a href="javascript:;" target="_blank"
                      ><i class="fab fa-linkedin-in"></i
                    ></a>
                  </li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="footer-bottom">
      <div class="container">
        <!-- Copyright -->
        <div class="copyright">
          <div class="row">
            <div class="col-md-6 col-lg-6">
              <div class="copyright-text">
                <p class="mb-0">
                  Copyright © {{ new Date().getFullYear() }} All Rights Reserved
                </p>
              </div>
            </div>
            <div class="col-md-6 col-lg-6">
              <!-- Copyright Menu -->
              <div class="copyright-menu">
                <ul class="policy-menu">
                  <li><router-link to="/privacy-policy">Privacy Policy</router-link></li>
                  <li>
                    <router-link to="/terms-condition">Terms and Conditions</router-link>
                  </li>
                  <li><router-link to="/login">Login & Register</router-link></li>
                </ul>
              </div>
              <!-- /Copyright Menu -->
            </div>
          </div>
        </div>
        <!-- /Copyright -->
      </div>
    </div>
  </footer>
  <!-- /Footer -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
export default {
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
