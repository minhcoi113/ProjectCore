<template>
    <!-- Onboarding Cost -->
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
                                    <h2>What is the maximum cost per <br> consultation?<span>*</span></h2>
                                    <h6>This can be edited later on from the preferences section.</h6>
                                </div>
                                <div class="onboarding-content passcode-wrap mail-box">
                                    <div class="row">
                                        <div class="col-lg-2">
                                            <div class="mb-3">
                                                <vue-select 
                                                    :options="Amount"
                                                    placeholder="Euro"
                                                />
                                            </div>
                                        </div>
                                        <div class="col-lg-10">
                                            <div class="mb-3">
                                                <input type="text" placeholder="Enter Amount"
                                                    class=" placeholder-style form-control">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="onboarding-btn Consultation-btn cost-btn">
                                <router-link to="/onboarding-preferences">Save</router-link>
                                <router-link to="/onboarding-preferences">Not Now</router-link>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- /Onboarding Cost -->
</template>

<script>
export default {
    data() {
        return {
            Amount: ["Euro", "INR", "Dinar", "ring"]
        }
    },
}
</script>