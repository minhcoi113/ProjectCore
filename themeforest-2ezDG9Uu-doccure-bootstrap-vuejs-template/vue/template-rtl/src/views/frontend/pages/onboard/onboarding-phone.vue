<template>
    <!-- Onboarding Phone -->

    <div class="onboard-wrapper">
        <onboarding-slider></onboarding-slider>
        <div class="right-panel">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 p-0">
                        <div class="right-panel-title text-center">
                            <router-link to="/"> <img src="@/assets/img/onboard-img/onb-logo.png"
                                    alt="Image"></router-link>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-12">
                        <onboarding-sidebar></onboarding-sidebar>
                    </div>
                    <div class="col-lg-8 col-md-12">
                        <div class="onboarding-content-box content-wrap">
                            <div class="onboard-set">
                                <div class="onboarding-title">
                                    <h2>Enter your phone number <span>*</span></h2>
                                    <h6>We’ve sent it to doccure@example.com</h6>
                                </div>
                                <div class="onboarding-content passcode-wrap mail-box">
                                    <div class="row">
                                        <div class="col-lg-12">
                                            <div class="form-group">
                                                <vue-tel-input 
                                                    class="form-control form-control-lg group_formcontrol mail-icon2" 
                                                    id="phone" name="phone"
                                                    mode="international"
                                                />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="onboarding-btn">
                                <router-link to="/onboarding-phone-otp">Continue</router-link>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- /Onboarding Phone -->
</template>
