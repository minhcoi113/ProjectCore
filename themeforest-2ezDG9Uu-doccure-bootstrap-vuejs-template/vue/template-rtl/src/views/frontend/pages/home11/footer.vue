<template>
  <!-- Footer -->
  <footer class="footer footer-one footer-sixteen">
    <div class="footer-top aos" data-aos="fade-up">
      <div class="container">
        <div class="row">
          <div class="col-lg-4 col-md-4">
            <div class="footer-widget footer-about">
              <div class="footer-logo">
                <img src="@/assets/img/logo.png" alt="logo" />
              </div>
              <div class="footer-about-content">
                <p>
                  Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod
                  tempor incididunt ut labore.
                </p>
              </div>
              <div class="subscribe-form">
                <input
                  type="email"
                  class="form-control"
                  placeholder="Enter Email Address"
                />
                <b-button type="submit" class="btn footer-btn">Subscribe</b-button>
              </div>
            </div>
          </div>
          <div class="col-lg-2 col-md-4">
            <div class="footer-widget footer-menu">
              <h2 class="footer-title">Company</h2>
              <ul>
                <li><router-link to="/about-us">About us</router-link></li>
                <li><router-link to="/cart">Careers</router-link></li>
                <li><a href="javascript:void(0);">News</a></li>
                <li><router-link to="/contact-us">Contact</router-link></li>
              </ul>
            </div>
          </div>
          <div class="col-lg-2 col-md-4">
            <div class="footer-widget footer-menu">
              <h2 class="footer-title">Resources</h2>
              <ul>
                <li><a href="javascript:void(0);">Events</a></li>
                <li><a href="javascript:void(0);">Help Centre</a></li>
                <li><a href="javascript:void(0);">Tutorials</a></li>
                <li><a href="javascript:void(0);">Support</a></li>
              </ul>
            </div>
          </div>
          <div class="col-lg-2 col-md-5">
            <div class="footer-widget footer-menu">
              <h2 class="footer-title">Social</h2>
              <ul>
                <li><a href="javascript:void(0);">Twitter</a></li>
                <li><a href="javascript:void(0);">LinkedIn</a></li>
                <li><a href="javascript:void(0);">Facebook</a></li>
                <li><a href="javascript:void(0);">Dribble</a></li>
              </ul>
            </div>
          </div>
          <div class="col-lg-2 col-md-7">
            <div class="footer-widget footer-menu">
              <h2 class="footer-title">Legal</h2>
              <ul>
                <li>
                  <router-link to="/terms-condition">Terms & Condition</router-link>
                </li>
                <li><router-link to="/privacy-policy">Privacy Policy</router-link></li>
                <li><router-link to="/coming-soon">Cookies</router-link></li>
                <li><a href="javascript:void(0);">Licenses</a></li>
              </ul>
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
                <p>© {{ new Date().getFullYear() }} Doccure. All rights reserve.</p>
              </div>
            </div>
            <div class="col-md-6 col-lg-6">
              <!-- Copyright Menu -->
              <div class="copyright-menu">
                <ul>
                  <li>
                    <a href="javascript:;" target="_blank"
                      ><i class="fa-brands fa-facebook-f"></i
                    ></a>
                  </li>
                  <li>
                    <a href="javascript:;" target="_blank"
                      ><i class="fab fa-twitter"></i>
                    </a>
                  </li>
                  <li>
                    <a href="javascript:;" target="_blank"
                      ><i class="fa-brands fa-whatsapp"></i
                    ></a>
                  </li>
                  <li>
                    <a href="javascript:;" target="_blank"
                      ><i class="fa-brands fa-youtube"></i
                    ></a>
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
