<template>
    <!-- App Section -->
    <section class="app-section app-sec-twelve">
        <div class="container">
            <div class="app-twelve">
                <div class="app-bg">
                    <div class="row align-items-center">
                        <div class="col-lg-6 col-md-12">
                            <div class="mobile-img">
                                <img src="@/assets/img/mobile-img.png" class="img-fluid" alt="img">
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-12">
                            <div class="app-content">
                                <div class="app-header">
                                    <h5>Working for Your Better Health.</h5>
                                    <h2>Download the Doccure App today!</h2>
                                </div>
                                <div class="app-scan">
                                    <p>Scan the QR code to get the app now</p>
                                    <img src="@/assets/img/scan-img.png" alt="scan-image">
                                </div>
                                <div class="google-imgs aos" data-aos="fade-up">
                                    <a href="javascript:void(0);"><img src="@/assets/img/google-play.png" alt="img"></a>
                                    <a href="javascript:void(0);"><img src="@/assets/img/app-store.png" alt="img"></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </section>
    <!-- /App Section -->

    <!-- Footer -->
    <footer class="footer-twelve">
        <div class="footer-top-sec">
            <div class="container">
                <div class="footer-top">
                    <div class="logo-footer">
                        <img src="@/assets/img/icons/footer-logo-.svg" alt="Img">
                    </div>
                    <div class="footer-buy-btn">
                        <h6>Ready to get started with Doccure?</h6>
                        <router-link to="booking-2" class="btn btn-primary">Book Now</router-link>
                    </div>
                </div>
                <div class="footer-middle">
                    <div class="row">
                        <div class="col-lg-3 col-md-5 col-sm-6">
                            <div class="footer-links-middle">
                                <h4>Contact Us</h4>
                                <ul>
                                    <li><span><i class="feather-map-pin"></i></span>3556 Beech Street, USA</li>
                                    <li><span><i class="feather-phone"></i></span>+1 315 369 5943</li>
                                    <li><span><i class="feather-mail"></i></span>info@example.com</li>
                                </ul>
                            </div>
                        </div>
                        <div class="col-lg-2 col-md-3 col-sm-6">
                            <div class="footer-links-middle">
                                <h4>Company</h4>
                                <ul>
                                    <li><router-link to="about-us">About Us</router-link></li>
                                    <li><router-link to="blog-grid">Blogs</router-link></li>
                                    <li><a href="javascript:void(0);">Careers</a></li>
                                    <li><a href="javascript:void(0);">Success Stories</a></li>
                                </ul>
                            </div>
                        </div>
                        <div class="col-lg-3 col-md-4 col-sm-6">
                            <div class="footer-links-middle">
                                <h4>Specialities</h4>
                                <ul>
                                    <li><a href="javascript:void(0);">Pregnancy Test</a></li>
                                    <li><a href="javascript:void(0);">Vitamin D & B12 Combo</a></li>
                                    <li><a href="javascript:void(0);">Cancer Screening - Male</a></li>
                                    <li><a href="javascript:void(0);">Advanced Renal Package</a></li>
                                </ul>
                            </div>
                        </div>
                        <div class="col-lg-4 col-sm-6">
                            <div class="footer-links-middle">
                                <h4>Join Our Newsletter</h4>
                                <form action="index-12">
                                    <div class="input-block">
                                        <input type="email" class="form-control" placeholder="Enter Email Address">
                                        <button class="submit-btn">Submit</button>
                                    </div>
                                </form>
                                <p>* Will send you weekly updates for your better</p>
                                <ul class="social-icons">
                                    <li><a href="javascript:void(0);" class="fb"><i class="fa-brands fa-facebook-f"></i></a>
                                    </li>
                                    <li><a href="javascript:void(0);" class="insta"><i
                                                class="fa-brands fa-instagram"></i></a></li>
                                    <li><a href="javascript:void(0);" class="linked-in"><i
                                                class="fa-brands fa-linkedin-in"></i></a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="fooeter-bottom">
            <div class="container">
                <div class="copy-right-footer">
                    <h5>Copyright © {{ new Date().getFullYear() }} Doccure. All Rights Reserved</h5>
                    <ul class="privacy-policy">
                        <li><router-link to="privacy-policy">Privacy Policy</router-link></li>
                        <li><router-link to="terms-condition">Terms & Conditions</router-link></li>
                    </ul>
                </div>
            </div>
        </div>
    </footer>
    <!-- /Footer -->
</template>