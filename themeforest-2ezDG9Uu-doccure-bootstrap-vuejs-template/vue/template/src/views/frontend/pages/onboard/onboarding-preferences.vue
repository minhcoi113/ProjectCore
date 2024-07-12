<template>
    <!-- Onboarding Preferences -->

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
                            <div class="onboarding-title">
                                <h2>Preferences <span>*</span></h2>
                                <h6>This can be edited later on from the account settings.</h6>
                            </div>
                            <div class="onboarding-content">
                                <div class="row">
                                    <div class="col-lg-12">
                                        <div class="accordion" id="accordionExample">
                                            <div class="accordion-item">
                                                <h2 class="accordion-header" id="headingOne">
                                                    <b-button class="accordion-button" type="button" data-bs-toggle="collapse"
                                                        data-bs-target="#collapseOne" aria-expanded="true"
                                                        aria-controls="collapseOne">
                                                        Cost of an Consultation
                                                    </b-button>
                                                </h2>
                                                <div id="collapseOne" class="accordion-collapse collapse show"
                                                    aria-labelledby="headingOne" data-bs-parent="#accordionExample">
                                                    <div class="accordion-body">
                                                        <div class="onboard-set">
                                                            <div class="onboarding-title">
                                                                <h2>What is the maximum cost per <br>
                                                                    consultation?<span>*</span></h2>
                                                                <h6>This can be edited later on from the preferences
                                                                    section.</h6>
                                                            </div>
                                                            <div class="onboarding-content passcode-wrap mail-box">
                                                                <div class="row">
                                                                    <div class="col-lg-2">
                                                                        <div class="form-group">
                                                                            <vue-select :options="Euro"
                                                                                placeholder="Euro" />
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-lg-10">
                                                                        <div class="form-group">
                                                                            <input type="text" placeholder="Enter Amount"
                                                                                class=" placeholder-style form-control"
                                                                                required="">
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="onboarding-btn Consultation-btn cost-btns">
                                                            <a data-bs-toggle="collapse" data-bs-target="#collapseOne"
                                                                aria-expanded="true" aria-controls="collapseOne"
                                                                href="javascript:void(0);">Save</a>
                                                            <a data-bs-toggle="collapse" data-bs-target="#collapseOne"
                                                                aria-expanded="true" aria-controls="collapseOne"
                                                                href="javascript:void(0);">Not Now</a>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="accordion-item">
                                                <h2 class="accordion-header" id="headingTwo">
                                                    <b-button class="accordion-button collapsed" type="button"
                                                        data-bs-toggle="collapse" data-bs-target="#collapseTwo"
                                                        aria-expanded="false" aria-controls="collapseTwo">
                                                        Preferred means for online consultations
                                                    </b-button>
                                                </h2>
                                                <div id="collapseTwo" class="accordion-collapse collapse"
                                                    aria-labelledby="headingTwo" data-bs-parent="#accordionExample">
                                                    <div class="accordion-body">
                                                        <div class="onboarding-title">
                                                            <h2>
                                                                Which are your preferred means <br> of online
                                                                consultation?<span>*</span>
                                                            </h2>
                                                            <h6>You can select more than one from the below. These will
                                                                show up as options for the patient when booking an
                                                                appointment.</h6>
                                                        </div>
                                                        <div class="onboarding-content">
                                                            <div class="consult-option mb-lg-4 mb-sm-1">
                                                                <div class="call-option">
                                                                    <input type="checkbox" id="radio1" name="selector"
                                                                        class="option-radio" checked>
                                                                    <label for="radio1" class="call-lable"> <img
                                                                            src="@/assets/img/icons/mic-black.svg"
                                                                            alt="Image">Audio Call</label>
                                                                </div>
                                                                <div class="call-option">
                                                                    <input type="checkbox" id="radio2" name="selector"
                                                                        class="option-radio">
                                                                    <label for="radio2" class="call-lable"><img
                                                                            src="@/assets/img/icons/video-icon.svg"
                                                                            alt="Image">Video Call</label>
                                                                </div>
                                                                <div class="call-option">
                                                                    <input type="checkbox" id="radio3" name="selector"
                                                                        class="option-radio">
                                                                    <label for="radio3" class="call-lable"> <img
                                                                            src="@/assets/img/icons/ch.svg"
                                                                            alt="Image">Chat</label>
                                                                </div>
                                                            </div>
                                                            <div class="onboarding-title">
                                                                <h6>Choose your preferred language for Audio, Video
                                                                    calls and chat. You can select more than one option.
                                                                </h6>
                                                            </div>
                                                            <div class="form-group">
                                                                <label class="onboarding-lable">Language</label>
                                                                <vue-select :options="Language"
                                                                    placeholder="Choose Your Language" />
                                                            </div>
                                                            <div class="onboarding-btn Consultation-btn">
                                                                <a data-bs-toggle="collapse" data-bs-target="#collapseTwo"
                                                                    aria-expanded="true" aria-controls="collapseTwo"
                                                                    href="javascript:void(0);">Save</a>
                                                                <a data-bs-toggle="collapse" data-bs-target="#collapseTwo"
                                                                    aria-expanded="true" aria-controls="collapseTwo"
                                                                    href="javascript:void(0);">Not Now</a>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="accordion-item">
                                                <h2 class="accordion-header" id="headingThree">
                                                    <b-button class="accordion-button collapsed" type="button"
                                                        data-bs-toggle="collapse" data-bs-target="#collapseThree"
                                                        aria-expanded="false" aria-controls="collapseThree">
                                                        Availabilities
                                                    </b-button>
                                                </h2>
                                                <div id="collapseThree" class="accordion-collapse collapse"
                                                    aria-labelledby="headingThree" data-bs-parent="#accordionExample">
                                                    <div class="accordion-body">
                                                        <div class="onboarding-title">
                                                            <h2>Add availability<span>*</span></h2>
                                                            <h6>Visitors will only be able to schedule appointments
                                                                during available hours.</h6>
                                                        </div>
                                                        <div class="onboarding-content passcode-wrap mail-box">
                                                            <div class="row">
                                                                <div class="col-lg-12">
                                                                    <div class="form-group">
                                                                        <label class="onboarding-lable">Date</label>
                                                                        <datepicker v-model="startdate" class="picker"
                                                                            :editable="true" :clearable="false" />
                                                                    </div>
                                                                </div>
                                                                <div class="col-lg-6">
                                                                    <div class="form-group">
                                                                        <label class="onboarding-lable">Time will you be
                                                                            available?</label>
                                                                        <vue-select :options="Time"
                                                                            placeholder="Start Time" />
                                                                    </div>
                                                                </div>
                                                                <div class="col-lg-6">
                                                                    <div class="form-group">
                                                                        <label class="onboarding-lable">&nbsp;</label>
                                                                        <vue-select :options="Times"
                                                                            placeholder="End Time" />
                                                                    </div>
                                                                </div>
                                                                <div class="col-lg-12">
                                                                    <div class="form-group">
                                                                        <div class="repeat-avail d-flex ">
                                                                            <div class="tog-button">
                                                                                <label class="switch">
                                                                                    <input type="checkbox">
                                                                                    <span class="tog-slider round"></span>
                                                                                </label>
                                                                            </div>
                                                                            <div class="avail-content d-flex ">
                                                                                <a href="javascript:void(0);">
                                                                                    <h6> Repeat Availability
                                                                                    </h6>
                                                                                </a>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <div class="col-lg-12">
                                                                    <div class="form-group">
                                                                        <label class="onboarding-lable">Choose any day
                                                                            of the week to repeat this
                                                                            availability.</label>
                                                                        <div class="weekDays-selector">
                                                                            <input type="checkbox" id="weekday-mon"
                                                                                class="weekday" />
                                                                            <label for="weekday-mon">M</label>
                                                                            <input type="checkbox" id="weekday-tue"
                                                                                class="weekday" />
                                                                            <label for="weekday-tue">T</label>
                                                                            <input type="checkbox" id="weekday-wed"
                                                                                class="weekday" />
                                                                            <label for="weekday-wed">W</label>
                                                                            <input type="checkbox" id="weekday-thu"
                                                                                class="weekday" />
                                                                            <label for="weekday-thu">T</label>
                                                                            <input type="checkbox" id="weekday-fri"
                                                                                class="weekday" />
                                                                            <label for="weekday-fri">F</label>
                                                                            <input type="checkbox" id="weekday-sat"
                                                                                class="weekday" />
                                                                            <label for="weekday-sat">S</label>
                                                                            <input type="checkbox" id="weekday-sun"
                                                                                class="weekday" />
                                                                            <label for="weekday-sun">S</label>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <div class="col-lg-12">
                                                                    <div class="form-group">
                                                                        <label class="onboarding-lable">Repeat this
                                                                            schedule until</label>
                                                                        <datepicker v-model="startdate" class="picker"
                                                                            :editable="true" :clearable="false" />
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="onboarding-btn Personalize-btn">
                                                                <a href="javascript:void(0);" data-bs-toggle="modal"
                                                                    data-bs-target="#id-verified">Save & Next</a>
                                                            </div>
                                                            <!-- Modal -->
                                                            <div class="modal fade fade-custom" id="id-verified"
                                                                tabindex="-1" aria-hidden="true">
                                                                <div class="modal-dialog id-upload modal-dialog-centered">
                                                                    <div class="modal-content id-pop-content">
                                                                        <div
                                                                            class="modal-header id-pop-header justify-content-center">
                                                                            <img src="@/assets/img/icons/success-tick.svg"
                                                                                alt="Image">
                                                                        </div>
                                                                        <div class="modal-body id-pop-body text-center">
                                                                            <h2>Doctor’s profile has been verified</h2>
                                                                            <p>Lorem ipsum dolor sit amet, consectetur
                                                                                adipiscing elit, sed do eiusmod tempor
                                                                                incididunt ut labore et dolore magna
                                                                                aliqua.</p>
                                                                        </div>
                                                                        <div class="modal-footer id-pop-footer text-center">
                                                                            <div class="onboarding-btn pop-btn ">
                                                                                <router-link
                                                                                    to="doctor-dashboard">Continue</router-link>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- /Onboarding Preferences -->
</template>
<script>
import { ref } from 'vue'
const currentDate = ref(new Date())
export default {
    data() {
        return {
            startdate: currentDate,
            Euro: ["Euro", "INR", "Dinar", "ring"],
            Language: ["Choose Your Language", "French", "English", "Spanish"],
            Time: ["Start Time", "12:00 a.m", "1:00 a.m", "2:00 a.m", "3:00 a.m", "4:00 a.m", "5:00 a.m", "6:00 a.m", "7:00 a.m", "8:00 a.m", "9:00 a.m"],
            Times: ["End Time", "12:00 a.m", "1:00 a.m", "2:00 a.m", "3:00 a.m", "4:00 a.m", "5:00 a.m", "6:00 a.m", "7:00 a.m", "8:00 a.m", "9:00 a.m"],
        }
    }
}
</Script>