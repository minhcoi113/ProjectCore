<template>
    <!-- Onboarding Payments -->

    <div class="onboard-wrapper">
        <onboarding-slider></onboarding-slider>
        <div class="right-panel">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 p-0">
                        <div class="right-panel-title text-center">
                            <router-link to="/"> <img src="@/assets/img/onboard-img/onb-logo.png" alt="Image"></router-link>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-12">
                        <onboarding-sidebar></onboarding-sidebar>
                    </div>
                    <div class="col-lg-8 col-md-12">
                        <div class="onboarding-content-box">
                            <div class="row">
                                <div class="col-lg-10">
                                    <div class="onboarding-title">
                                        <h2>Payment Details <span>*</span></h2>
                                        <h6>Set Your Payment Methods</h6>
                                    </div>
                                    <div class="onboarding-content passcode-wrap mail-box">
                                        <div class="row">
                                            <div class="col-lg-12">
                                                <div class="form-group">
                                                    <label class="onboarding-lable">Name On Card <span>*</span></label>
                                                    <input type="text" placeholder="Max Doe"
                                                        class="form-control placeholder-style" required="">
                                                </div>
                                            </div>
                                            <div class="col-lg-4">
                                                <div class="form-group">
                                                    <label class="onboarding-lable">Expiration
                                                        Date<span>*</span></label>
                                                    <vue-select :options="Month" placeholder="Select Month" />
                                                </div>
                                            </div>
                                            <div class="col-lg-4">
                                                <div class="form-group">
                                                    <label class="onboarding-lable">&nbsp;</label>
                                                    <datepicker v-model="startdate" class="picker" :editable="true"
                                                        :clearable="false" />
                                                </div>
                                            </div>
                                            <div class="col-lg-4">
                                                <div class="form-group">
                                                    <label class="onboarding-lable">CVV<span>*</span></label>
                                                    <input type="text" placeholder="Enter CVV"
                                                        class="form-control placeholder-style" maxlength="3" required="">
                                                </div>
                                            </div>
                                            <div class="col-lg-12">
                                                <div class="form-group">
                                                    <label class="onboarding-lable">Card Number<span>*</span></label>
                                                    <input type="text" placeholder="4111 1111 1111 1111"
                                                        class="form-control placeholder-style" required="">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-1g-12">
                                            <div class="save-detail">
                                                <div class="tog-button">
                                                    <label class="switch">
                                                        <input type="checkbox">
                                                        <span class="tog-slider round"></span>
                                                    </label>
                                                </div>
                                                <div class="save-card">
                                                    <h5>Save Card for further billing?</h5>
                                                    <h6> If you need more info, please check budget planning</h6>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="onboarding-btn Personalize-btn">
                                            <router-link to="/onboarding-preferences">Continue</router-link>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-2">
                                    <div class="payment-icon">
                                        <img src="@/assets/img/icons/payment-card.png" alt="Image" class="img-fluid">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- /Onboarding Payments -->
</template>
<script>

import { ref } from 'vue'
const currentDate = ref(new Date())
export default {
    data() {
        return {
            startdate: currentDate,
            Month: ["Select Month", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
        }
    },
    components: {
    },
    mounted() {

    },
}
</script>
