<template>
  <!-- Footer -->
  <footer class="footer footer-fifteen">
    <div class="footer-top footer-top-fifteen aos" data-aos="fade-up">
      <div class="container">
        <div class="row">
          <div class="col-lg-6">
            <div class="footer-left-fifteen">
              <div class="footer-fifteen-image">
                <img src="@/assets/img/logo-03.png" alt="Logo" />
              </div>
              <p>
                Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                Lorem Ipsum has been the industry's standard dummy text ever since the
                1500s, when an unknown printer took a galley of type and scrambled it to
                make a type specimen book. It has survived not only five centuries, but
                also the leap into electronic typesetting, remaining essentially
                unchanged.
              </p>
              <h6 class="subscribe-fifteen">Subscribe Newsletter</h6>
              <div class="subscribe-form subscribe-form-fifteen">
                <input
                  type="email"
                  class="form-control"
                  placeholder="Enter Email Address"
                />
                <b-button type="submit" class="btn footer-btn">Subscribe</b-button>
              </div>
              <h6 class="subscribe-fifteentwo">Acceptable Payments</h6>
              <div class="footer-fifteen-image-2">
                <img src="@/assets/img/footer-fift-payment.png" alt="Payment" />
              </div>
            </div>
          </div>
          <div class="col-lg-6">
            <div class="footer-right-fifteen">
              <h6 class="subscribe-fifteenthree">Quick Links</h6>
              <ul>
                <li>
                  <router-link to="about-us">About</router-link>
                </li>
                <li>
                  <router-link to="search-2">services</router-link>
                </li>
                <li>
                  <router-link to="/patient-details">Patients</router-link>
                </li>
                <li>
                  <a href="javascript:void(0);">Camp</a>
                </li>
                <li>
                  <router-link to="doctor-blog">Doctors</router-link>
                </li>
                <li>
                  <a href="javascript:void(0);">Treatments</a>
                </li>
                <li>
                  <a href="javascript:void(0);">Facilities</a>
                </li>
              </ul>
              <h6 class="subscribe-fifteenthree">Contact</h6>
              <p>38 Simpson Street, Rock Island, Illinois - 61201</p>
              <div class="user-details-fift">
                <ul>
                  <li>
                    <div class="contact-fifteen">
                      <div class="contact-form-fift">
                        <i class="feather-phone"></i>
                      </div>
                      <div class="contact-content-fift">
                        <h6>Phone Number</h6>
                        <span>1800 - 42657678</span>
                      </div>
                    </div>
                  </li>
                  <li>
                    <div class="contact-fifteen">
                      <div class="contact-form-fift">
                        <i class="feather-mail"></i>
                      </div>
                      <div class="contact-content-fift">
                        <h6>Email</h6>
                        <span>Doccure@example.com</span>
                      </div>
                    </div>
                  </li>
                  <li>
                    <div class="contact-fifteen">
                      <div class="contact-form-fift">
                        <i class="feather-clock"></i>
                      </div>
                      <div class="contact-content-fift">
                        <h6>Opening</h6>
                        <span>Available 24*7</span>
                      </div>
                    </div>
                  </li>
                </ul>
              </div>

              <h6 class="subscribe-fifteenthree">Language and Social</h6>
              <div class="footer-fift-selects">
                <div class="footer-select">
                  <img src="@/assets/img/icons/globe.svg" alt="img" />
                  <vue-select :options="English" placeholder="English" />
                </div>
                <div class="social-icon">
                  <ul>
                    <li>
                      <a href="javascript:;" target="_blank"
                        ><i class="fa-brands fa-facebook"></i>
                      </a>
                    </li>
                    <li>
                      <a href="javascript:;" target="_blank"
                        ><i class="fab fa-twitter"></i>
                      </a>
                    </li>
                    <li>
                      <a href="javascript:;" target="_blank"
                        ><i class="fa-brands fa-instagram"></i
                      ></a>
                    </li>
                    <li>
                      <a href="javascript:;" target="_blank"
                        ><i class="fa-brands fa-linkedin"></i
                      ></a>
                    </li>
                  </ul>
                </div>
              </div>
              <div class="footer-bottom footer-bottom-fifteen">
                <div class="container">
                  <!-- Copyright -->
                  <div class="copyright">
                    <div class="row">
                      <div class="col-md-6">
                        <div class="copyright-text">
                          <p>
                            © {{ new Date().getFullYear() }} Doccure. All rights reserve.
                          </p>
                        </div>
                      </div>
                      <div class="col-md-6">
                        <!-- Copyright Menu -->
                        <div class="copyright-menu">
                          <ul class="policy-menu">
                            <li>
                              <router-link to="terms-condition">Terms</router-link>
                            </li>
                            <li>
                              <router-link to="privacy-policy"
                                >Privacy Policy</router-link
                              >
                            </li>
                            <li>
                              <a href="javascript:void(0);">Sitemap</a>
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
            </div>
          </div>
        </div>
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
      English: ["English", "Spanish", "Mexico"],
    };
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
