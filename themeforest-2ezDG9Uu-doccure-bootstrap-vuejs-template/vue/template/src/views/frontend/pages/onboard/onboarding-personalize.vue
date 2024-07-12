<template>
    <!-- Onboarding Personalize -->

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
                            <div class="onboarding-title profile-title">
                                <h2>Personalize Your Profile <span>*</span></h2>
                            </div>
                            <div class="onboarding-content passcode-wrap mail-box">
                                <div class="row">
                                    <div class="col-lg-12">
                                        <div class="form-group">
                                            <div class="upload-pic">
                                                <img src="@/assets/img/icons/up-img-1.svg" alt="img" id="blah">
                                                <h6>Upload Photo</h6>
                                                <div class="upload-pics">
                                                    <a class="btn-profile"><img src="@/assets/img/icons/edit.svg"
                                                            alt="Image"></a>
                                                    <input type="file" id="imgInp">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="photo-norms">
                                                <h5>Logo Should be minimum 152 * 152 Supported File format JPG,PNG,SVG
                                                </h5>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-12">
                                        <div class="form-group">
                                            <label class="onboarding-lable">Legal Name <span>*</span></label>
                                            <input type="text" placeholder="Enter Name"
                                                class="form-control placeholder-style" required="">
                                        </div>
                                    </div>
                                    <div class="col-lg-6">
                                        <div class="form-group">
                                            <label class="onboarding-lable">Gender <span>*</span></label>
                                            <vue-select :options="Gender" placeholder="Select Gender" />
                                        </div>
                                    </div>
                                    <div class="col-lg-6">
                                        <div class="form-group">
                                            <label class="onboarding-lable">Date of Birth <span>*</span></label>
                                            <datepicker v-model="startdate" class="picker" :editable="true"
                                                :clearable="false" />
                                        </div>
                                    </div>
                                    <div class="col-lg-12">
                                        <div class="form-group">
                                            <label class="onboarding-lable">Address<span>*</span></label>
                                            <input type="text" placeholder="Enter Address"
                                                class="form-control placeholder-style" required="">
                                        </div>
                                    </div>
                                    <div class="col-lg-6">
                                        <div class="form-group">
                                            <label class="onboarding-lable">City <span>*</span></label>
                                            <input type="text" placeholder="Enter City"
                                                class="placeholder-style form-control" required="">
                                        </div>
                                    </div>
                                    <div class="col-lg-6">
                                        <div class="form-group">
                                            <label class="onboarding-lable">State<span>*</span></label>
                                            <vue-select :options="State" placeholder="Select State" />
                                        </div>
                                    </div>
                                    <div class="col-lg-12">
                                        <div class="form-group">
                                            <label class="onboarding-lable">About you <span>*</span></label>
                                            <textarea></textarea>
                                        </div>
                                    </div>
                                </div>
                                <div class="onboarding-btn Personalize-btn">
                                    <router-link to="/onboarding-verification">Continue</router-link>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- /Onboarding Personalize -->
</template>
<script>
import { ref } from 'vue'
const currentDate = ref(new Date())
export default {
    data() {
        return {
            startdate: currentDate,
            Gender: ["Select Gender", "male", "female"],
            State: ["Select State", "Washington", "Florida", "Alaska"],
        }
    },
    components: {
    },

}
</script>
