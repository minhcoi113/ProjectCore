<template>
    <!-- Onboarding Consultation -->
    <div class="onboard-wrapper">
        <onboarding-slider></onboarding-slider>
        <div class="right-panel">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 p-0">
                        <div class="right-panel-title text-center">
                            <img src="@/assets/img/onboard-img/onb-logo.png" alt="doccure-logo">
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-12">
                        <onboarding-sidebar></onboarding-sidebar>
                    </div>
                    <div class="col-lg-8 col-md-12">
                        <div class="onboarding-content-box">
                            <div class="onboarding-title">
                                <h2>
                                    Which are your preferred means <br> of online consultation?<span>*</span>
                                </h2>
                                <h6>You can select more than one from the below. These will show up as options for the
                                    patient when booking an appointment.</h6>
                            </div>
                            <div class="onboarding-content">
                                <div class="consult-option mb-lg-4 mb-sm-1">
                                    <div class="call-option">
                                        <input type="checkbox" id="radio1" name="selector" class="option-radio" checked>
                                        <label for="radio1" class="call-lable"> <img src="@/assets/img/icons/mic-black.svg"
                                                alt="mic-icon">Audio Call</label>
                                    </div>
                                    <div class="call-option">
                                        <input type="checkbox" id="radio2" name="selector" class="option-radio">
                                        <label for="radio2" class="call-lable"><img src="@/assets/img/icons/video-icon.svg"
                                                alt="video-icon">Video Call</label>
                                    </div>
                                    <div class="call-option">
                                        <input type="checkbox" id="radio3" name="selector" class="option-radio">
                                        <label for="radio3" class="call-lable"> <img src="@/assets/img/icons/ch.svg"
                                                alt="chat-icon">Chat</label>
                                    </div>
                                </div>
                                <div class="onboarding-title">
                                    <h6>Choose your preferred language for Audio, Video calls and chat. You can select
                                        more than one option.</h6>
                                </div>
                                <div class="mb-3">
                                    <label class="onboarding-lable">Language</label>
                                    <vue-select 
                                        :options="Language"
                                        placeholder="Choose Your Language"
                                    />
                                </div>
                                <div class="onboarding-btn Consultation-btn">
                                    <router-link to="/onboarding-preferences">Save</router-link>
                                    <router-link to="/onboarding-preferences">Not Now</router-link>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- /Onboarding Consultation -->
</template>

<script>
export default {
    data() {
        return {
            Language: ["French", "English", "Spanish"]
        }
    },
}
</script>