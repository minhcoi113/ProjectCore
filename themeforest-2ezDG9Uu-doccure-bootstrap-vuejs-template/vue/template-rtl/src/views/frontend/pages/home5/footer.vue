<template>
  <!-- Footer -->
  <footer class="footer footer-one footer-ten">
    <div class="footer-ten-bg">
      <img src="@/assets/img/bg/hexagen-group-4.png" alt="Image" />
      <img src="@/assets/img/bg/hexagen-group-5.png" alt="Image" />
      <img src="@/assets/img/bg/ecg.png" alt="Image" />
    </div>
    <div class="footer-top aos" data-aos="fade-up">
      <div class="container">
        <div class="footer-details">
          <div class="row">
            <div class="col-lg-4 col-md-6 col-sm-12">
              <div class="footer-widget footer-about">
                <div class="footer-logo">
                  <img src="@/assets/img/footer-logo.svg" alt="logo" />
                </div>
                <div class="footer-about-content">
                  <p>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do
                    eiusmod tempor
                  </p>
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
            <div class="col-lg-4 col-md-6 col-sm-12">
              <div class="footer-widget footer-contact">
                <h2 class="footer-title">&nbsp;</h2>
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
            <div class="col-lg-4 col-md-6 col-sm-12">
              <div class="footer-map">
                <img src="@/assets/img/bg/footer-map.jpg" class="img-fluid" alt="Image" />
              </div>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-lg-2 col-md-4">
            <div class="footer-widget footer-menu">
              <h2 class="footer-title">Services by city</h2>
              <ul>
                <li><a href="javascript:void(0);">New York</a></li>
                <li><a href="javascript:void(0);">Los Angeles</a></li>
                <li><a href="javascript:void(0);">Chicago</a></li>
                <li><a href="javascript:void(0);">Houston</a></li>
                <li><a href="javascript:void(0);">Phoenix</a></li>
              </ul>
            </div>
          </div>
          <div class="col-lg-2 col-md-4">
            <div class="footer-widget footer-menu">
              <h2 class="footer-title">Services by city</h2>
              <ul>
                <li><a href="javascript:void(0);">New York</a></li>
                <li><a href="javascript:void(0);">Los Angeles</a></li>
                <li><a href="javascript:void(0);">Chicago</a></li>
                <li><a href="javascript:void(0);">Houston</a></li>
                <li><a href="javascript:void(0);">Phoenix</a></li>
              </ul>
            </div>
          </div>
          <div class="col-lg-2 col-md-4">
            <div class="footer-widget footer-menu">
              <h2 class="footer-title">For Patients</h2>
              <ul>
                <li><router-link to="/search">Search for Doctors</router-link></li>
                <li><router-link to="/login">Login</router-link></li>
                <li><router-link to="/register">Register</router-link></li>
              </ul>
            </div>
          </div>
          <div class="col-lg-2 col-md-4">
            <div class="footer-widget footer-menu">
              <h2 class="footer-title">For Doctors</h2>
              <ul>
                <li><router-link to="/appointments">Appointments</router-link></li>
                <li><router-link to="/chat">Chat</router-link></li>
                <li><router-link to="/login">Login</router-link></li>
              </ul>
            </div>
          </div>
          <div class="col-lg-4 col-md-7">
            <div class="footer-widget">
              <h2 class="footer-title">Subscribe to newsletter</h2>
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
              <span class="mail-note"
                >* Will send you weekly updates for your better finance management.</span
              >
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="footer-bottom">
      <div class="container">
        <!-- Copyright -->
        <div class="copyright">
          <div class="copyright-text">
            <p class="mb-0">
              © {{ new Date().getFullYear() }} Doccure. All Rights Reserved.
            </p>
          </div>
          <!-- Copyright Menu -->
          <div class="copyright-menu">
            <ul class="policy-menu">
              <li><router-link to="/privacy-policy">Privacy Policy</router-link></li>
              <li>
                <router-link to="/terms-condition">Terms and Conditions</router-link>
              </li>
            </ul>
          </div>
          <!-- /Copyright Menu -->
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
