<template>
    <!-- Onboarding Email -->
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
                            <div class="onborad-set">
                                <div class="onboarding-title">
                                    <h2>Whats your Primary email?<span>*</span></h2>
                                    <h6>We will only use it to advise you for any important changes.</h6>
                                </div>
                                <div class="onboarding-content">
                                    <div class="row">
                                        <div class="col-lg-12">
                                            <div class="mb-3">
                                                <div class="input-placeholder form-focus passcode-wrap mail-box">
                                                    <label class="focus-label">Email Address<span>*</span></label>
                                                    <input type="text" class="form-control floating mail-icon" required="">
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="onboarding-btn">
                                <router-link to="/onboarding-email-otp">Continue</router-link>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <!-- /Onboarding Email -->
</template>
<script>
import Vue from 'vue'
export default {
    data() {
        return {
            Euro: ["Euro", "INR", "Dinar", "ring"],
        }
    },
}
</Script>