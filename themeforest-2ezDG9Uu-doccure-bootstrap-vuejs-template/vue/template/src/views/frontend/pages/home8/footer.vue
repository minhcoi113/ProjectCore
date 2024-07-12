<template>
  <!-- Footer -->
  <footer class="footer footer-thirteen">
    <div class="footer-bg-icon">
      <img
        src="@/assets/img/bg/cloud-2.png"
        alt="Cloud"
        class="aos"
        data-aos="fade-right"
      />
      <img
        src="@/assets/img/bg/rainbow-2.png"
        alt="Rainbow"
        class="aos"
        data-aos="fade-left"
      />
    </div>
    <div class="footer-top aos" data-aos="fade-up">
      <div class="container">
        <div class="row">
          <div class="col-lg-6">
            <div class="row">
              <div class="col-md-6">
                <div class="footer-widget footer-menu">
                  <h2 class="footer-title">About us</h2>
                  <ul>
                    <li>
                      <a href="javascript:void(0);">Our Doctors</a>
                    </li>
                    <li>
                      <a href="javascript:void(0);">Why us</a>
                    </li>
                    <li>
                      <a href="javascript:void(0);">How it works</a>
                    </li>
                    <li>
                      <a href="javascript:void(0);">Our News & Events</a>
                    </li>
                    <li>
                      <a href="javascript:void(0);">FAQ</a>
                    </li>
                  </ul>
                </div>
              </div>
              <div class="col-md-6">
                <div class="footer-widget footer-menu">
                  <h2 class="footer-title">Our cabins</h2>
                  <ul>
                    <li>
                      <a href="javascript:void(0);">North of London</a>
                    </li>
                    <li>
                      <a href="javascript:void(0);">Golden Hideaway</a>
                    </li>
                    <li>
                      <a href="javascript:void(0);">Oak Treehouse</a>
                    </li>
                    <li>
                      <a href="javascript:void(0);">Acacia Retreat</a>
                    </li>
                    <li>
                      <a href="javascript:void(0);">Blue Lagoon</a>
                    </li>
                  </ul>
                </div>
              </div>
            </div>
          </div>

          <div class="col-lg-6">
            <div class="row">
              <div class="col-md-4">
                <div class="footer-widget footer-menu">
                  <h2 class="footer-title">Services</h2>
                  <ul>
                    <li>
                      <a href="javascript:void(0);">Prenatal/New-born</a>
                    </li>
                    <li>
                      <a href="javascript:void(0);">Vaccinations</a>
                    </li>
                    <li>
                      <a href="javascript:void(0);">Blood tests</a>
                    </li>
                    <li>
                      <a href="javascript:void(0);">Diagnostic tests</a>
                    </li>
                    <li>
                      <a href="javascript:void(0);">Parents training classes</a>
                    </li>
                  </ul>
                </div>
              </div>
              <div class="col-md-4">
                <div class="footer-widget footer-menu footer-menu-thirteen">
                  <h2 class="footer-title">Services</h2>
                  <ul>
                    <li>
                      <a href="javascript:void(0);">Our Doctors</a>
                    </li>
                    <li>
                      <a href="javascript:void(0);">Why us</a>
                    </li>
                    <li>
                      <a href="javascript:void(0);">How it works</a>
                    </li>
                    <li>
                      <a href="javascript:void(0);">Our News & Events</a>
                    </li>
                    <li>
                      <router-link to="/faq">FAQ</router-link>
                    </li>
                  </ul>
                </div>
              </div>
              <div class="col-md-4">
                <div class="footer-widget footer-menu">
                  <h2 class="footer-title">Support</h2>
                  <ul>
                    <li>
                      <a href="javascript:void(0);">Help Us</a>
                    </li>
                    <li>
                      <router-link to="/privacy-policy">Privacy Policy</router-link>
                    </li>
                    <li>
                      <router-link to="/contact-us">Contact Us</router-link>
                    </li>
                    <li>
                      <router-link to="/terms-condition">Terms of Service</router-link>
                    </li>
                    <li>
                      <a href="javascript:void(0);">Complaints Policy</a>
                    </li>
                  </ul>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="footer-contents-thirteen-main">
          <div class="row">
            <div class="col-lg-6">
              <div class="footer-thirt-inner">
                <h4>Sign up to our Newsletter</h4>
                <p>
                  For a weekly curated collection of 3 things you can watch, read or
                  listen to switch off from the busy everyday.
                </p>
              </div>
            </div>
            <div class="col-lg-6">
              <div class="subscribe-form">
                <form action="javascript:;">
                  <input
                    type="email"
                    class="form-control"
                    placeholder="Doccure@example.com"
                  />
                  <b-button type="submit" class="btn"
                    >Subscribe <i class="feather-arrow-right ms-2"></i
                  ></b-button>
                </form>
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
          <div class="row align-items-center">
            <div class="col-md-4 col-lg-4">
              <div class="copyright-img">
                <router-link to="/index-10"
                  ><img src="@/assets/img/logo.png" alt="doccure-logo"
                /></router-link>
              </div>
            </div>
            <div class="col-md-4 col-lg-4">
              <div class="copyright-text">
                <p class="mb-0">
                  Copyright © {{ new Date().getFullYear() }} All Rights Reserved
                </p>
              </div>
            </div>
            <div class="col-md-4 col-lg-4">
              <!-- Copyright Menu -->
              <div class="copyright-menu">
                <ul class="policy-menu">
                  <li>
                    <a href="javascript:void(0);"><i class="feather-linkedin"></i></a>
                  </li>
                  <li>
                    <a href="javascript:void(0);"><i class="feather-twitter"></i></a>
                  </li>
                  <li>
                    <a href="javascript:void(0);"><i class="feather-facebook"></i></a>
                  </li>
                  <li>
                    <a href="javascript:void(0);"><i class="feather-instagram"></i></a>
                  </li>
                  <li>
                    <a href="javascript:void(0);"><i class="feather-youtube"></i></a>
                  </li>
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
