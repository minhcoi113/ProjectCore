<template>
  <!-- Footer -->
  <footer class="footer footer-eleven">
    <div class="footer-top aos aos-init aos-animate" data-aos="fade-up">
      <div class="container">
        <div class="footer-contacts">
          <div class="row">
            <div class="col-md-4">
              <div class="footer-wrap">
                <div class="footer-icon">
                  <i class="feather-mail"></i>
                </div>
                <div class="footer-info">
                  <h6>Email</h6>
                  <p>doccure@example.com</p>
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="footer-wrap">
                <div class="footer-icon">
                  <i class="feather-phone"></i>
                </div>
                <div class="footer-info">
                  <h6>Phone Number</h6>
                  <p>1800 - 672-4399</p>
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="footer-wrap">
                <div class="footer-icon">
                  <i class="feather-clock"></i>
                </div>
                <div class="footer-info">
                  <h6>Open Timing</h6>
                  <p>We are available 24*7</p>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-md-6">
            <div class="footer-content">
              <p>
                Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                Lorem Ipsum has been the industry's standard dummy text ever since the
                1500s, when an unknown printer took a galley of type and scrambled it to
                make a type specimen book. It has survived not only five centuries,
              </p>
            </div>
          </div>
          <div class="col-md-6">
            <div class="footer-widget">
              <h2 class="footer-title">Subscribe Newsletter</h2>
              <div class="subscribe-form">
                <form action="javascript:;">
                  <input type="email" class="form-control" placeholder="Enter Email" />
                  <b-button type="submit" class="btn">Subscribe</b-button>
                </form>
              </div>
            </div>
          </div>
          <div class="col-md-6">
            <div class="footer-payment">
              <h6>Acceptable Payments</h6>
              <img src="@/assets/img/payment.png" alt="payment" class="img-fluid" />
            </div>
          </div>
          <div class="col-md-6">
            <div class="footer-language">
              <vue-select :options="Lang" placeholder="English" />
              <span class="icon-lang">
                <i class="feather-globe"></i>
              </span>
            </div>
          </div>
        </div>
      </div>
    </div>

    <div class="footer-bottom">
      <div class="container">
        <div class="row align-items-center">
          <div class="col-md-6">
            <div class="footer-widget footer-menu">
              <ul>
                <li><a href="javascript:;">About</a></li>
                <li><a href="javascript:;">Our services</a></li>
                <li><a href="javascript:;">Patients</a></li>
                <li><a href="javascript:;">Camp</a></li>
                <li><a href="javascript:;">Doctors</a></li>
              </ul>
            </div>
          </div>

          <div class="col-md-6">
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

        <!-- Copyright -->
        <div class="copyright">
          <div class="row align-items-center">
            <div class="col-md-5">
              <div class="copyright-text">
                <p>© {{ new Date().getFullYear() }} Doccure. All Rights Reserved.</p>
              </div>
            </div>
            <div class="col-md-2">
              <div class="footer-bottom-logo">
                <router-link to="/index-10"
                  ><img src="@/assets/img/logo-03.png" class="img-fluid" alt="Logo"
                /></router-link>
              </div>
            </div>
            <div class="col-md-5">
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
  data() {
    return {
      Lang: ["English", "Japanese"],
    };
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
