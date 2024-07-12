<template>
    <!-- Onboarding Identity -->

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
                    <div class="col-lg-4">
                        <onboarding-sidebar></onboarding-sidebar>
                    </div>
                    <div class="col-lg-8 col-md-12">
                        <div class="onboarding-content-box">
                            <div class="onboarding-title">
                                <h2>Upload identification<span>*</span></h2>
                                <h6>We need to determine if an identity document is authentic and belongs to you. You
                                    just need to go through some steps which will help us to build a secure system
                                    together</h6>
                            </div>
                            <div class="onboarding-content passcode-wrap mail-box">
                                <div class="row">
                                    <div class="col-lg-12">
                                        <div class="form-group">
                                            <vue-select :options="Type" placeholder="Select Document Type" />
                                        </div>
                                    </div>
                                    <div class="col-lg-12">
                                        <div class="form-group">
                                            <input type="text" placeholder="Enter Document Number"
                                                class="form-control placeholder-style" required="">
                                        </div>
                                    </div>
                                    <div class="col-lg-12">
                                        <div class="form-group">
                                            <div class="call-option file-option ">
                                                <input type="file" id="radio1" name="selector" class="option-radio">
                                                <label for="radio1" class="call-lable verify-lable verify-file"> <img
                                                        src="@/assets/img/icons/file.png" alt="Image">Upload Document</label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="onboarding-btn Personalize-btn">
                                <a href="javascript:void(0);" data-bs-toggle="modal"
                                    data-bs-target="#id-verified">Continue</a>
                            </div>
                            <!-- Modal -->

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- /Onboarding Identity -->
    <div class="modal fade" id="id-verified" tabindex="-1" aria-hidden="true">
        <div class="modal-dialog id-upload modal-dialog-centered">
            <div class="modal-content id-pop-content">
                <div class="modal-header id-pop-header justify-content-center">
                    <img src="@/assets/img/icons/success-tick.svg" alt="Image">
                </div>
                <div class="modal-body id-pop-body text-center">
                    <h2>Your ID uploaded Successfully</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod
                        tempor incididunt ut labore et dolore magna aliqua.</p>
                </div>
                <div class="modal-footer id-pop-footer text-center">
                    <div class="onboarding-btn pop-btn ">
                        <router-link to="/onboarding-personalize">Continue</router-link>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>
<script>
export default {
    data() {
        return {
            Type: ["Select Document Type", "PDF", "TXT", "JPEC"],
        }
    },
}
</Script>
