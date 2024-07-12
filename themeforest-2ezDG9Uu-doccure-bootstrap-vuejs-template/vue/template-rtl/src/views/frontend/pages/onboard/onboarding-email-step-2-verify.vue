<template>
    <!-- Onboarding Step-2 -->
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
                                    <h2>2-step verification</h2>
                                    <h6>We sent you a notification to <span> doccure@example.com</span> to <br>
                                        authenticate your log in.</h6>
                                </div>
                                <div class="onboarding-content passcode-wrap">
                                    <div class="method-btn">
                                        <a href="#">Change Method</a>
                                    </div>
                                    <div class="code-title">
                                        <h6>Security code sent via Email</h6>
                                    </div>
                                    <div class="d-flex digit-group">
                                        <input type="text" id="digit-1" name="digit-1" data-next="digit-2">
                                        <input type="text" id="digit-2" name="digit-2" data-next="digit-3"
                                            data-previous="digit-1">
                                        <input type="text" id="digit-3" name="digit-3" data-next="digit-4"
                                            data-previous="digit-2">
                                        <input type="text" id="digit-4" name="digit-4" data-next="digit-5"
                                            data-previous="digit-3">
                                    </div>
                                </div>
                            </div>
                            <div class="onboarding-btn step-2-btn">
                                <router-link to="/onboarding-identity">Continue</router-link>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- /Onboarding Step-2 -->
</template>