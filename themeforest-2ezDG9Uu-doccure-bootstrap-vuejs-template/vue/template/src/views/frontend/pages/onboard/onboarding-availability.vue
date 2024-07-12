<template>
    <!-- Onboarding Availability -->
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
                        <div class="onboarding-content-box position-relative">
                            <div class="onboarding-title">
                                <h2>Add availability<span>*</span></h2>
                                <h6>Visitors will only be able to schedule appointments during available hours.</h6>
                            </div>
                            <div class="onboarding-content passcode-wrap mail-box">
                                <div class="row">
                                    <div class="col-lg-12">
                                        <div class="mb-3">
                                            <label class="onboarding-lable">Date</label>
                                            <datepicker 
                                                v-model="startdate" 
                                                class="form-control placeholder-styledatetimepicker"
                                                :editable="true"
                                                :clearable="false"
                                                placeholder="Select Date"
                                            />
                                        </div>
                                    </div>
                                    <div class="col-lg-6">
                                        <div class="mb-3">
                                            <label class="onboarding-lable">Time will you be available?</label>
                                            <vue-select 
                                                :options="Time"
                                                placeholder="Start Time"
                                            />
                                        </div>
                                    </div>
                                    <div class="col-lg-6">
                                        <div class="mb-3">
                                            <label class="onboarding-lable">&nbsp;</label>
                                            <vue-select 
                                                :options="Time"
                                                placeholder="End Time"
                                            />
                                        </div>
                                    </div>
                                    <div class="col-lg-12">
                                        <div class="mb-3">
                                            <div class="repeat-avail d-flex ">
                                                <div class="tog-button">
                                                    <label class="switch">
                                                        <input type="checkbox">
                                                        <span class="tog-slider round"></span>
                                                    </label>
                                                </div>
                                                <div class="avail-content d-flex ">
                                                    <a href="#">
                                                        <h6> Repeat
                                                            Availability</h6>
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-12">
                                        <div class="mb-3">
                                            <label class="onboarding-lable">Choose any day of the week to repeat this
                                                availability.</label>
                                            <div class="weekDays-selector">
                                                <input type="checkbox" id="weekday-mon" class="weekday">
                                                <label for="weekday-mon">M</label>
                                                <input type="checkbox" id="weekday-tue" class="weekday">
                                                <label for="weekday-tue">T</label>
                                                <input type="checkbox" id="weekday-wed" class="weekday">
                                                <label for="weekday-wed">W</label>
                                                <input type="checkbox" id="weekday-thu" class="weekday">
                                                <label for="weekday-thu">T</label>
                                                <input type="checkbox" id="weekday-fri" class="weekday">
                                                <label for="weekday-fri">F</label>
                                                <input type="checkbox" id="weekday-sat" class="weekday">
                                                <label for="weekday-sat">S</label>
                                                <input type="checkbox" id="weekday-sun" class="weekday">
                                                <label for="weekday-sun">S</label>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-12">
                                        <div class="mb-3">
                                            <label class="onboarding-lable">Repeat this schedule until</label>
                                                <datepicker 
                                                    v-model="startdate" 
                                                    class="form-control placeholder-styledatetimepicker"
                                                    :editable="true"
                                                    :clearable="false"
                                                    placeholder="Select Date"
                                                />
                                        </div>
                                    </div>
                                </div>
                                <div class="onboarding-btn Personalize-btn">
                                    <a href="#" data-bs-toggle="modal" data-bs-target="#id-verified">Save & Next</a>
                                </div>
                                <!-- Modal -->
                                <div class="modal fade fade-custom" id="id-verified" tabindex="-1"
                                    aria-labelledby="id-verified" aria-hidden="true">
                                    <div class="modal-dialog id-upload modal-dialog-centered">
                                        <div class="modal-content id-pop-content">
                                            <div class="modal-header id-pop-header justify-content-center">
                                                <img src="@/assets/img/icons/success-tick.svg" alt="success-tick">
                                            </div>
                                            <div class="modal-body id-pop-body text-center">
                                                <h2>Doctor’s profile has been verified</h2>
                                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do
                                                    eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                                            </div>
                                            <div class="modal-footer id-pop-footer text-center">
                                                <div class="onboarding-btn pop-btn ">
                                                    <a href="#" data-bs-dismiss="modal">Continue</a>
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
    <!-- /Onboarding Availability -->
</template>

<script>
import { ref } from 'vue'
const currentDate = ref(new Date())
export default {
    data() {
        return {
            startdate: currentDate,
            Time: ["12:00 a.m", "1:00 a.m", "2:00 a.m", "3:00 a.m", "4:00 a.m", "5:00 a.m", "6:00 a.m", "7:00 a.m", "8:00 a.m", "9:00 a.m"]
        }
    },
}
</script>