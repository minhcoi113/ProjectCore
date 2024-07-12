<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="content">
      <div class="container">
        <div class="row">
          <div class="col-12">
            <div class="card">
              <div class="card-body">
                <div class="booking-doc-info">
                  <router-link to="doctor-profile" class="booking-doc-img">
                    <img
                      src="@/assets/img/doctors/doctor-thumb-02.jpg"
                      alt="User Image"
                    />
                  </router-link>
                  <div class="booking-info">
                    <h4>
                      <router-link to="doctor-profile">Dr. Darren Elder</router-link>
                    </h4>
                    <div class="rating">
                      <i class="fas fa-star filled"></i>
                      <i class="fas fa-star filled ms-1"></i>
                      <i class="fas fa-star filled ms-1"></i>
                      <i class="fas fa-star filled ms-1"></i>
                      <i class="fas fa-star ms-1"></i>
                      <span class="d-inline-block average-rating ms-1">35</span>
                    </div>
                    <p class="text-muted mb-0">
                      <i class="fas fa-map-marker-alt"></i> Newyork, USA
                    </p>
                  </div>
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-12 col-sm-4 col-md-6">
                <h4 class="mb-1">11 March 2023</h4>
                <p class="text-muted">Saturday</p>
              </div>
              <div class="col-12 col-sm-8 col-md-6 text-sm-end">
                <div class="bookingrange btn btn-white btn-sm mb-3">
                  <i class="far fa-calendar-alt me-2"></i>
                  <span></span>
                  <i class="fas fa-chevron-down ms-2"></i>
                </div>
              </div>
            </div>
            <!-- Schedule Widget -->
            <div class="card booking-schedule schedule-widget">
              <!-- Schedule Header -->
              <div class="schedule-header">
                <div class="row">
                  <div class="col-md-12">
                    <!-- Day Slot -->
                    <div class="day-slot">
                      <ul>
                        <li class="left-arrow">
                          <a href="javascript:;">
                            <i class="fa fa-chevron-left"></i>
                          </a>
                        </li>
                        <li v-for="item in booking" :key="item.id">
                          <span>{{ item.day }}</span>
                          <span class="slot-date"
                            >{{ item.date }}
                            <small class="slot-year">{{ item.year }}</small></span
                          >
                        </li>
                        <li class="right-arrow">
                          <a href="javascript:;">
                            <i class="fa fa-chevron-right"></i>
                          </a>
                        </li>
                      </ul>
                    </div>
                    <!-- /Day Slot -->
                  </div>
                </div>
              </div>
              <!-- /Schedule Header -->

              <!-- Schedule Content -->
              <div class="schedule-cont">
                <div class="row">
                  <div class="col-md-12">
                    <!-- Time Slot -->
                    <div class="time-slot">
                      <ul class="clearfix">
                        <li>
                          <a class="timing" href="javascript:;">
                            <span>9:00</span> <span>AM</span>
                          </a>
                          <a class="timing" href="javascript:;">
                            <span>10:00</span> <span>AM</span>
                          </a>
                          <a class="timing" href="javascript:;">
                            <span>11:00</span> <span>AM</span>
                          </a>
                        </li>
                        <li>
                          <a class="timing" href="javascript:;">
                            <span>9:00</span> <span>AM</span>
                          </a>
                          <a class="timing" href="javascript:;">
                            <span>10:00</span> <span>AM</span>
                          </a>
                          <a class="timing" href="javascript:;">
                            <span>11:00</span> <span>AM</span>
                          </a>
                        </li>
                        <li>
                          <a class="timing" href="javascript:;">
                            <span>9:00</span> <span>AM</span>
                          </a>
                          <a class="timing" href="javascript:;">
                            <span>10:00</span> <span>AM</span>
                          </a>
                          <a class="timing" href="javascript:;">
                            <span>11:00</span> <span>AM</span>
                          </a>
                        </li>
                        <li>
                          <a class="timing" href="javascript:;">
                            <span>9:00</span> <span>AM</span>
                          </a>
                          <a class="timing" href="javascript:;">
                            <span>10:00</span> <span>AM</span>
                          </a>
                          <a class="timing" href="javascript:;">
                            <span>11:00</span> <span>AM</span>
                          </a>
                        </li>
                        <li>
                          <a class="timing" href="javascript:;">
                            <span>9:00</span> <span>AM</span>
                          </a>
                          <a class="timing selected" href="javascript:;">
                            <span>10:00</span> <span>AM</span>
                          </a>
                          <a class="timing" href="javascript:;">
                            <span>11:00</span> <span>AM</span>
                          </a>
                        </li>
                        <li>
                          <a class="timing" href="javascript:;">
                            <span>9:00</span> <span>AM</span>
                          </a>
                          <a class="timing" href="javascript:;">
                            <span>10:00</span> <span>AM</span>
                          </a>
                          <a class="timing" href="javascript:;">
                            <span>11:00</span> <span>AM</span>
                          </a>
                        </li>
                        <li>
                          <a class="timing" href="javascript:;">
                            <span>9:00</span> <span>AM</span>
                          </a>
                          <a class="timing" href="javascript:;">
                            <span>10:00</span> <span>AM</span>
                          </a>
                          <a class="timing" href="javascript:;">
                            <span>11:00</span> <span>AM</span>
                          </a>
                        </li>
                      </ul>
                    </div>
                    <!-- /Time Slot -->
                  </div>
                </div>
              </div>
              <!-- /Schedule Content -->
            </div>
            <!-- /Schedule Widget -->

            <!-- Submit Section -->
            <div class="submit-section proceed-btn text-end">
              <router-link to="checkout" class="btn btn-primary submit-btn"
                >Proceed to Pay</router-link
              >
            </div>
            <!-- /Submit Section -->
          </div>
        </div>
      </div>
    </div>
    <indexfooter></indexfooter>
  </div>
</template>
<script>
import Booking from "@/assets/json/booking/booking.json";
import "daterangepicker/daterangepicker.css";
import "daterangepicker/daterangepicker.js";
import "moment/min/moment.min.js";

import { onMounted } from "vue";
import moment from "moment";
import DateRangePicker from "daterangepicker";
export default {
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

    return {
      title: "Booking",
      text: "Home",
      text1: "Booking",
      booking: Booking,
    };
  },
};
</script>
