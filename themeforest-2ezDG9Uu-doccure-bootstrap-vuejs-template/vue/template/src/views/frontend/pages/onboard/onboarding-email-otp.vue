<template>
     <!-- Onboarding Email Otp -->
     <div class="onboard-wrapper">

        <onboarding-slider></onboarding-slider>

        <div class="right-panel">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 p-0">
                        <div class="right-panel-title text-center">
                            <router-link to="/"> <img src="@/assets/img/onboard-img/onb-logo.png" alt="doccure-logo"></router-link>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-12">
                        <onboarding-sidebar></onboarding-sidebar>
                    </div>
                    <div class="col-lg-8 col-md-12">
                        <div class="onboarding-content-box content-wrap">
                            <div class="onboard-set">
                                <div class="onboarding-title">
                                    <h2>Enter 4-digit code sent to your email.</h2>
                                    <h6>We’ve sent it to doccure@example.com</h6>
                                </div>
                                <div class="onboarding-content passcode-wrap">
                                    <div class="d-flex digit-group">
                                        <input type="text" id="digit-1" name="digit-1" data-next="digit-2" >
                                        <input type="text" id="digit-2" name="digit-2" data-next="digit-3"
                                            data-previous="digit-1" >
                                        <input type="text" id="digit-3" name="digit-3" data-next="digit-4"
                                            data-previous="digit-2" >
                                        <input type="text" id="digit-4" name="digit-4" data-next="digit-5"
                                            data-previous="digit-3" >
                                    </div>
                                </div>
                            </div>
                            <div class="onboarding-btn">
                                <router-link to="/onboarding-phone">Continue</router-link>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- /Onboarding Email Otp -->
</template>