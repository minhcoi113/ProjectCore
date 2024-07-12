<template>
  <!-- Appointment Section -->
  <section class="appointment-section">
    <div class="appointment-form">
      <div class="container">
        <div class="row">
          <div class="col-md-12 aos" data-aos="fade-up">
            <div class="section-heading text-center sec-heading-eye">
              <img
                src="@/assets/img/icons/eye-white-icon.svg"
                alt="eye-white-icon"
                class="img-fluid"
              />
              <h2 class="text-white">Book an appointment</h2>
            </div>
          </div>
        </div>
        <form action="javascript:;" class="doctor-search-form">
          <div class="row">
            <div class="col-md-4">
              <div class="forms-block">
                <div class="form-custom">
                  <input type="text" class="form-control" placeholder="Name" />
                  <i class="feather-user"></i>
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="forms-block">
                <div class="form-custom">
                  <input type="email" class="form-control" placeholder="Email" />
                  <i class="feather-mail"></i>
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="forms-block">
                <div class="form-custom">
                  <input type="text" class="form-control" placeholder="Phone Number" />
                  <i class="feather-phone"></i>
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="forms-block">
                <div class="form-custom">
                  <vue-select :options="Hospital" placeholder="Hospital" />
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="forms-block">
                <div class="form-custom">
                  <vue-select :options="Doctor" placeholder="Doctor Name" />
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="forms-block">
                <div class="form-custom">
                  <vue-select :options="Online" placeholder="Online Consultation" />
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="forms-block">
                <div class="form-custom">
                  <datepicker
                    v-model="startdate"
                    placeholder="Date"
                    class="form-control datetimepicker"
                    :editable="true"
                    :clearable="false"
                  />
                  <i class="feather-calendar"></i>
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="forms-block">
                <div class="form-custom">
                  <a-time-picker
                    class="form-control datetimepicker"
                    placeholder="Time"
                    use12-hours
                    format="h:mm a"
                  />
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="forms-block">
                <div class="form-custom">
                  <vue-select :options="Appointment" placeholder="Appointment Type" />
                </div>
              </div>
            </div>
            <div class="col-md-12 text-center">
              <router-link to="/search" class="btn btn-light-blue app-btn"
                >Book an Appointment</router-link
              >
            </div>
          </div>
        </form>
      </div>
      <div class="ban-bg">
        <img
          src="@/assets/img/bg/appoint-bg.png"
          alt="eye-icon"
          class="img-fluid bg-09"
        />
      </div>
    </div>
  </section>
  <!-- /Appointment Section -->

  <!-- Facility Section -->
  <section class="faq-eye-section">
    <div class="container">
      <div class="row">
        <div class="col-md-12 aos" data-aos="fade-up">
          <div class="section-heading text-center sec-heading-eye">
            <img src="@/assets/img/icons/eye-icon.svg" alt="eye-icon" class="img-fluid" />
            <h2><span>Frequently Asked </span> Questions</h2>
            <p>What our clients say about us</p>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-md-6">
          <div class="faq-wrap">
            <ul class="nav">
              <li v-for="item in IndexSixQuestion" :key="item.id">
                <a
                  href="javascript:;"
                  :class="item.class"
                  data-bs-toggle="tab"
                  :data-bs-target="item.id"
                >
                  <span>Q</span>
                  {{ item.question }}
                </a>
              </li>
            </ul>
          </div>
        </div>
        <div class="col-md-6">
          <div class="tab-content pt-0">
            <div
              :class="item.class"
              v-for="item in indexsixappointment"
              :key="item.id"
              :id="item.id"
            >
              <div class="faq-content">
                <img
                  :src="require(`@/assets/img/${item.image}`)"
                  alt="eye-test-icon"
                  class="img-fluid"
                />
                <p>{{ item.content }}</p>
                <p>{{ item.content1 }}</p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="ban-bg">
      <img
        src="@/assets/img/bg/center-bg.png"
        alt="design-image"
        class="img-fluid bg-05"
      />
    </div>
  </section>
  <!-- /Facility Section -->
</template>

<script>
import AOS from "aos";
import "aos/dist/aos.css";
import indexsixappointment from "@/assets/json/indexsixappointment.json";
import IndexSixQuestion from "@/assets/json/indexsixquestion.json";
import { ref } from "vue";
const currentDate = ref(new Date());
export default {
  data() {
    return {
      Hospital: ["Hospital", "Online", "Offline"],
      Doctor: ["Doctor Name", "George", "Matthew"],
      Online: ["Online Consultation", "Online", "Offline"],
      Appointment: ["Appointment Type", "Online", "Offline"],
      indexsixappointment: indexsixappointment,
      IndexSixQuestion: IndexSixQuestion,
      startdate: currentDate,
    };
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
