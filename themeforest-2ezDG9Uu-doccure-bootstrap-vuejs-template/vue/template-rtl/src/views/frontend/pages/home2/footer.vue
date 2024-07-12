<template>
  <!-- Footer -->
  <footer class="footer">
    <!-- Footer Top -->
    <div class="footer-top aos" data-aos="fade-up">
      <div class="container-fluid">
        <div class="row">
          <div class="col-lg-3 col-md-6">
            <!-- Footer Widget -->
            <div class="footer-widget footer-about">
              <div class="footer-logo">
                <img src="@/assets/img/footer-logo.png" alt="logo" />
              </div>
              <div class="footer-about-content">
                <p>
                  Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod
                  tempor incididunt ut labore et dolore magna aliqua.
                </p>
                <div class="social-icon">
                  <ul>
                    <li>
                      <a href="javascript:;" target="_blank"
                        ><i class="fab fa-facebook-f"></i>
                      </a>
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
                    <li>
                      <a href="javascript:;" target="_blank"
                        ><i class="fab fa-instagram"></i
                      ></a>
                    </li>
                    <li>
                      <a href="javascript:;" target="_blank"
                        ><i class="fab fa-dribbble"></i>
                      </a>
                    </li>
                  </ul>
                </div>
              </div>
            </div>
            <!-- /Footer Widget -->
          </div>

          <div class="col-lg-3 col-md-6">
            <!-- Footer Widget -->
            <div class="footer-widget footer-menu">
              <h2 class="footer-title">For Patients</h2>
              <ul>
                <li><router-link to="/search">Search for Doctors</router-link></li>
                <li><router-link to="/login">Login</router-link></li>
                <li><router-link to="/register">Register</router-link></li>
                <li><router-link to="/booking">Booking</router-link></li>
                <li>
                  <router-link to="/patient-dashboard">Patient Dashboard</router-link>
                </li>
              </ul>
            </div>
            <!-- /Footer Widget -->
          </div>

          <div class="col-lg-3 col-md-6">
            <!-- Footer Widget -->
            <div class="footer-widget footer-menu">
              <h2 class="footer-title">For Doctors</h2>
              <ul>
                <li><router-link to="/appointments">Appointments</router-link></li>
                <li><router-link to="/chat">Chat</router-link></li>
                <li><router-link to="/login">Login</router-link></li>
                <li><router-link to="/doctor-register">Register</router-link></li>
                <li>
                  <router-link to="/doctor-dashboard">Doctor Dashboard</router-link>
                </li>
              </ul>
            </div>
            <!-- /Footer Widget -->
          </div>

          <div class="col-lg-3 col-md-6">
            <!-- Footer Widget -->
            <div class="footer-widget footer-contact">
              <h2 class="footer-title">Contact Us</h2>
              <div class="footer-contact-info">
                <div class="footer-address">
                  <span><i class="fas fa-map-marker-alt"></i></span>
                  <p>
                    3556 Beech Street, San Francisco,<br />
                    California, CA 94108
                  </p>
                </div>
                <p>
                  <i class="fas fa-phone-alt"></i>
                  +1 315 369 5943
                </p>
                <p class="mb-0">
                  <i class="fas fa-envelope"></i>
                  doccure@example.com
                </p>
              </div>
            </div>
            <!-- /Footer Widget -->
          </div>
        </div>
      </div>
    </div>
    <!-- /Footer Top -->

    <!-- Footer Bottom -->
    <div class="footer-bottom">
      <div class="container-fluid">
        <!-- Copyright -->
        <div class="copyright">
          <div class="row">
            <div class="col-md-6 col-lg-6">
              <div class="copyright-text">
                <p class="mb-0">
                  &copy; {{ new Date().getFullYear() }} Doccure. All rights reserved.
                </p>
              </div>
            </div>
            <div class="col-md-6 col-lg-6">
              <!-- Copyright Menu -->
              <div class="copyright-menu">
                <ul class="policy-menu">
                  <li>
                    <router-link to="/terms-condition">Terms and Conditions</router-link>
                  </li>
                  <li><router-link to="/privacy-policy">Policy</router-link></li>
                </ul>
              </div>
              <!-- /Copyright Menu -->
            </div>
          </div>
        </div>
        <!-- /Copyright -->
      </div>
    </div>
    <!-- /Footer Bottom -->
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
