<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="content content-space">
      <div class="container">
        <!-- Booking -->
        <div class="row">
          <div class="col-lg-8 col-md-12">
            <div class="booking-header">
              <h4 class="booking-title">Select Available Slots</h4>
            </div>
            <div class="booking-date choose-date-book">
              <p>Choose Date</p>
              <div class="booking-range">
                <div class="bookingrange btn" ref="bookingRange">
                  <img src="@/assets/img/icons/today-icon.svg" alt="calendar-mage" />
                  <span></span>
                  <i class="fas fa-chevron-down"></i>
                </div>
              </div>
            </div>
            <div class="card booking-card">
              <div class="card-body time-slot-card-body">
                <div class="booking-date-slider">
                  <ul class="date-slider slick">
                    <Carousel
                      :wrap-around="true"
                      :settings="settings"
                      :breakpoints="breakpoints"
                    >
                      <Slide v-for="item in Booking" :key="item.id">
                        <div>
                          <h4>{{ item.Day }}</h4>
                          <p>{{ item.Month }}</p>
                        </div>
                      </Slide>
                      <template #addons>
                        <Navigation />
                      </template>
                    </Carousel>
                  </ul>
                </div>
                <div class="row">
                  <div class="col-lg-4 col-md-4">
                    <div class="time-slot time-slot-blk">
                      <h4>Morning</h4>
                      <div class="time-slot-list">
                        <ul>
                          <li>
                            <a class="timing" href="javascript:void(0);">
                              <span><i class="feather-clock"></i> 09:00 - 09:30</span>
                            </a>
                          </li>
                          <li>
                            <a class="timing" href="javascript:void(0);">
                              <span><i class="feather-clock"></i> 10:00 - 10:30</span>
                            </a>
                          </li>
                          <li
                            class="time-slot-open time-slot-morning"
                            :style="{ display: showMorningTimeSlot ? 'block' : 'none' }"
                          >
                            <a class="timing" href="javascript:void(0);">
                              <span><i class="feather-clock"></i> 11:00 - 11:30</span>
                            </a>
                          </li>
                          <li>
                            <div
                              class="load-more-timings load-more-morning"
                              @click="toggleTimeSlot('showMorningTimeSlot')"
                            >
                              <a href="javascript:void(0);">Load More</a>
                            </div>
                          </li>
                        </ul>
                      </div>
                    </div>
                  </div>
                  <div class="col-lg-4 col-md-4">
                    <div class="time-slot time-slot-blk">
                      <h4>Afternoon</h4>
                      <div class="time-slot-list">
                        <ul>
                          <li>
                            <a class="timing" href="javascript:void(0);">
                              <span><i class="feather-clock"></i> 12:00 - 12:30</span>
                            </a>
                          </li>
                          <li>
                            <a class="timing active" href="javascript:void(0);">
                              <span><i class="feather-clock"></i> 01:00 - 01:30</span>
                            </a>
                          </li>
                          <li
                            class="time-slot-open time-slot-afternoon"
                            :style="{ display: showAfternoonTimeSlot ? 'block' : 'none' }"
                          >
                            <a class="timing" href="javascript:void(0);">
                              <span><i class="feather-clock"></i> 02:30 - 03:00</span>
                            </a>
                          </li>
                          <li>
                            <div
                              class="load-more-timings load-more-afternoon"
                              @click="toggleTimeSlot('showAfternoonTimeSlot')"
                            >
                              <a href="javascript:void(0);">Load More</a>
                            </div>
                          </li>
                        </ul>
                      </div>
                    </div>
                  </div>
                  <div class="col-lg-4 col-md-4">
                    <div class="time-slot time-slot-blk">
                      <h4>Evening</h4>
                      <div class="time-slot-list">
                        <ul>
                          <li>
                            <a class="timing" href="javascript:void(0);">
                              <span><i class="feather-clock"></i> 03:00 - 03:30</span>
                            </a>
                          </li>
                          <li>
                            <a class="timing" href="javascript:void(0);">
                              <span><i class="feather-clock"></i> 04:00 - 04:30</span>
                            </a>
                          </li>
                          <li
                            class="time-slot-open time-slot-evening"
                            :style="{ display: showEveningTimeSlot ? 'block' : 'none' }"
                          >
                            <a class="timing" href="javascript:void(0);">
                              <span><i class="feather-clock"></i> 05:00 - 05:30</span>
                            </a>
                          </li>
                          <li>
                            <div
                              class="load-more-timings load-more-evening"
                              @click="toggleTimeSlot('showEveningTimeSlot')"
                            >
                              <a href="javascript:void(0);">Load More</a>
                            </div>
                          </li>
                        </ul>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class="booking-btn">
              <router-link
                to="/patient-details"
                class="btn btn-primary prime-btn justify-content-center align-items-center"
              >
                Next <i class="feather-arrow-right-circle"></i>
              </router-link>
            </div>
          </div>
          <div class="col-lg-4 col-md-12">
            <div class="booking-header">
              <h4 class="booking-title">Booking Summary</h4>
            </div>
            <div class="card booking-card">
              <div class="card-body booking-card-body">
                <div class="booking-doctor-details">
                  <div class="booking-doctor-left">
                    <div class="booking-doctor-img">
                      <router-link to="doctor-profile">
                        <img src="@/assets/img/doctors/doctor-01.jpg" alt="John Doe" />
                      </router-link>
                    </div>
                    <div class="booking-doctor-info">
                      <h4><router-link to="doctor-profile">Dr. John Doe</router-link></h4>
                      <p>MBBS, Dentist</p>
                    </div>
                  </div>
                  <div class="booking-doctor-right">
                    <p>
                      <i class="fas fa-check-circle"></i>
                      <router-link to="doctor-profile-settings">Edit</router-link>
                    </p>
                  </div>
                </div>
              </div>
            </div>
            <div class="card booking-card">
              <div class="card-body booking-card-body">
                <div class="booking-doctor-details">
                  <div class="booking-device">
                    <div class="booking-device-img">
                      <img
                        src="@/assets/img/icons/device-message.svg"
                        alt="device-message"
                      />
                    </div>
                    <div class="booking-doctor-info">
                      <h3>We can help you</h3>
                      <p class="device-text">
                        Call us +1 888-888-8888 (or) chat with our customer support team.
                      </p>
                      <router-link to="chat" class="btn">Chat With Us</router-link>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class="card booking-card mb-0">
              <div class="card-body booking-card-body">
                <div class="booking-doctor-details">
                  <div class="booking-device">
                    <div class="booking-device-img">
                      <img src="@/assets/img/icons/smart-phone.svg" alt="smart-phone" />
                    </div>
                    <div class="booking-doctor-info">
                      <h3>Get the App</h3>
                      <p class="device-text">
                        Download our app for better experience and for more feature
                      </p>
                      <div class="app-images">
                        <a href="javascript:void(0);">
                          <img src="@/assets/img/google-img.svg" alt="google-image" />
                        </a>
                        <a href="javascript:void(0);">
                          <img src="@/assets/img/app-img.svg" alt="app-image" />
                        </a>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        <!-- /Booking -->
      </div>
    </div>
    <indexfooter></indexfooter>
  </div>
</template>
<script>
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import Booking from "@/assets/json/booking/booking-2.json";
import "vue3-carousel/dist/carousel.css";
import { onMounted, defineComponent } from "vue";

import "daterangepicker/daterangepicker.css";
import "daterangepicker/daterangepicker.js";

import moment from "moment";
import DateRangePicker from "daterangepicker";

export default defineComponent({
  data() {
    return {
      title: "Booking",
      text: "Home",
      text1: "Booking",
      showMorningTimeSlot: false,
      showAfternoonTimeSlot: false,
      showEveningTimeSlot: false,
      Booking: Booking,
      settings: {
        itemsToShow: 1,
        snapAlign: "center",
      },
      breakpoints: {
        575: {
          itemsToShow: 3,
          snapAlign: "center",
        },
        767: {
          itemsToShow: 5,
          snapAlign: "center",
        },
        991: {
          itemsToShow: 7,
          snapAlign: "center",
        },
        1024: {
          itemsToShow: 7,
          snapAlign: "start",
        },
      },
    };
  },
  components: {
    Carousel,
    Slide,
    Pagination,
    Navigation,
  },
  methods: {
    toggleTimeSlot(timeSlot) {
      this[timeSlot] = !this[timeSlot];
    },
  },
  setup() {
    onMounted(() => {
      if (document.querySelectorAll(".bookingrange").length > 0) {
        var start = moment().subtract(6, "days");
        var end = moment();

        function booking_range(start, end) {
          document.querySelector(".bookingrange span").innerHTML =
            start.format("MMMM D, YYYY") + " - " + end.format("MMMM D, YYYY");
        }

        document.querySelector(".bookingrange").addEventListener("change", function () {
          booking_range(this.startDate, this.endDate);
        });

        var ranges = {
          Today: [moment(), moment()],
          Yesterday: [moment().subtract(1, "days"), moment().subtract(1, "days")],
          "Last 7 Days": [moment().subtract(6, "days"), moment()],
          "Last 30 Days": [moment().subtract(29, "days"), moment()],
          "This Month": [moment().startOf("month"), moment().endOf("month")],
          "Last Month": [
            moment().subtract(1, "month").startOf("month"),
            moment().subtract(1, "month").endOf("month"),
          ],
        };

        var options = {
          startDate: start,
          endDate: end,
          ranges: ranges,
        };

        new DateRangePicker(document.querySelector(".bookingrange"), options);
        booking_range(start, end);
      }
    });
  },
});
</script>
