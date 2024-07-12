<template>
    <!-- Onboarding Verify Account -->
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
                                <div class="onboarding-title pass-title">
                                    <h2>
                                        Verify Your Account
                                    </h2>
                                </div>
                                <div class="onboarding-content">
                                    <div class="row">
                                        <div class="consult-option mb-lg-5 mb-sm-0">
                                            <div class="call-option verify-account">
                                                <input type="radio" id="radio1" name="selector" class="option-radio"
                                                    checked>
                                                <label for="radio1" class="call-lable verify-lable verify-options"> <img
                                                        src="@/assets/img/icons/phone.png" alt="phone">Mobile Number</label>
                                            </div>
                                            <div class="call-option verify-account">
                                                <input type="radio" id="radio2" name="selector" class="option-radio">
                                                <label for="radio2" class="call-lable verify-lable verify-options"><img
                                                        src="@/assets/img/mail-box.png" alt="mail-box">Email Address</label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="onboarding-btn ">
                                <router-link to="/onboarding-email-step-2-verify">Continue</router-link>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- /Onboarding Verify Account -->
</template>