<template>
    <!-- Onboarding Password -->
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
                    <div class="col-lg-4">
                        <onboarding-sidebar></onboarding-sidebar>
                    </div>
                    <div class="col-lg-8">
                        <div class="onboarding-content-box content-wrap">
                            <div class="onboard-set">
                                <div class="onboarding-title pass-title">
                                    <h2>Create a passcode on your Doccure account</h2>
                                </div>
                                <div class="onboarding-content">
                                    <div class="row">
                                        <div class="col-lg-12">
                                            <div class="mb-3 forms-block pass-group">
                                                <div class="input-placeholder form-focus passcode-wrap mail-box">
                                                    <label class="focus-label">Enter New Password<span>*</span></label>
                                                    <input type="password" class="form-control floating pass-icon">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-12">
                                            <div class="mb-3">
                                                <div class="input-placeholder form-focus passcode-wrap mail-box">
                                                    <label class="focus-label">Enter Confirm
                                                        Password<span>*</span></label>
                                                    <input type="password" class="form-control floating pass-icon-1">
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="onboarding-btn">
                                <router-link to="/onboarding-identity">Continue</router-link>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- /Onboarding Password -->
</template>