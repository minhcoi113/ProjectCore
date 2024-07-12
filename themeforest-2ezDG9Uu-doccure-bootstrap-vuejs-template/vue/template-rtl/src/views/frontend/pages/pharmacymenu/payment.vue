<template>
  <div class="main-wrapper">
    <headerinfo />
    <div class="doctor-content">
      <div class="container">
        <!-- Payment -->
        <div class="row">
          <div class="col-md-12">
            <div class="back-link">
              <router-link to="consultation"
                ><i class="fa-solid fa-arrow-left-long"></i> Back</router-link
              >
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-lg-8 col-md-12">
            <div class="paitent-header">
              <h4 class="paitent-title">Payment</h4>
            </div>
            <div class="booking-header">
              <h4 class="booking-title">Payments Methods</h4>
            </div>
            <div class="payments-form">
              <form @submit.prevent="submitForm">
                <div class="payment-mb-3">
                  <div class="mb-3">
                    <label class="custom_radio">
                      <input type="radio" name="payment" checked="" />
                      <span class="checkmark"></span> Debit or Credit Card
                    </label>
                  </div>
                  <div class="mb-3 card-label">
                    <label class="mb-2">Name on Card</label>
                    <input type="text" class="form-control" placeholder="John Smith" />
                  </div>
                  <div class="mb-3 card-label">
                    <label class="mb-2">Card Number</label>
                    <input
                      type="text"
                      class="form-control"
                      placeholder="xxxx-xxxx-xxxx-xxxx"
                    />
                  </div>
                  <div class="row">
                    <div class="col-md-4">
                      <div class="mb-3 card-label">
                        <label class="mb-2">Expiry Month</label>
                        <input type="text" class="form-control" placeholder="MM" />
                      </div>
                    </div>
                    <div class="col-md-4">
                      <div class="mb-3 card-label">
                        <label class="mb-2">Expiry Year</label>
                        <input type="text" class="form-control" placeholder="YYYY" />
                      </div>
                    </div>
                    <div class="col-md-4">
                      <div class="mb-3 card-label">
                        <label class="mb-2">CVV</label>
                        <input type="text" class="form-control" placeholder="****" />
                      </div>
                    </div>
                  </div>
                </div>
                <div class="payment-mb-3">
                  <div class="mb-3">
                    <label class="custom_radio">
                      <input type="radio" name="payment" />
                      <span class="checkmark"></span> Paypal
                    </label>
                  </div>
                  <div class="mb-3">
                    <label class="custom_radio">
                      <input type="radio" name="payment" />
                      <span class="checkmark"></span> Cash on Visit
                    </label>
                  </div>
                  <div class="mb-3">
                    <label class="custom_radio">
                      <input type="radio" name="payment" />
                      <span class="checkmark"></span> Bank Transfer
                    </label>
                  </div>
                  <div class="mb-3">
                    <label class="custom_radio">
                      <input type="radio" name="payment" />
                      <span class="checkmark"></span> UPI
                    </label>
                  </div>
                </div>
                <div class="mb-3 mb-0">
                  <div class="booking-btn">
                    <b-button
                      type="submit"
                      class="btn btn-primary prime-btn justify-content-center align-items-center"
                    >
                      Next <i class="feather-arrow-right-circle"></i>
                    </b-button>
                  </div>
                </div>
              </form>
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
                        <img src="@/assets/img/doctors/doctor-02.jpg" alt="John Doe" />
                      </router-link>
                    </div>
                    <div class="booking-doctor-info">
                      <h4><router-link to="doctor-profile">Dr. John Doe</router-link></h4>
                      <p>MBBS, Dentist</p>
                    </div>
                  </div>
                  <div class="booking-doctor-right">
                    <p>
                      <i class="fas fa-circle-check"></i>
                      <router-link to="doctor-profile-settings">Edit</router-link>
                    </p>
                  </div>
                </div>
              </div>
            </div>
            <div class="card booking-card">
              <div class="card-body booking-card-body booking-list-body">
                <div class="booking-list">
                  <div class="booking-date-list">
                    <ul>
                      <li>Booking Date: <span>Sun, 30 Aug 2023</span></li>
                      <li>Booking Time: <span>10.00AM to 11:00AM</span></li>
                    </ul>
                  </div>
                  <div class="booking-doctor-right">
                    <p>
                      <router-link to="booking">Edit</router-link>
                    </p>
                  </div>
                </div>
                <div class="booking-list">
                  <div class="booking-date-list">
                    <ul>
                      <li>
                        Consultation Type:
                        <span><i class="feather-video"></i> Video Consulting</span>
                      </li>
                    </ul>
                  </div>
                  <div class="booking-doctor-right">
                    <p>
                      <router-link to="consultation">Edit</router-link>
                    </p>
                  </div>
                </div>
              </div>
            </div>
            <div class="card booking-card">
              <div class="card-body booking-card-body booking-list-body">
                <div class="booking-list">
                  <div class="booking-date-list consultation-date-list">
                    <ul>
                      <li>Consultation Fee: <span>$150.00</span></li>
                      <li>Booking Fee: <span>$8.00</span></li>
                      <li>Tax: <span>$5.00</span></li>
                      <li>
                        <span class="total-amount"></span>Total <span>$163.00</span>
                      </li>
                    </ul>
                  </div>
                </div>
              </div>
            </div>
            <div class="booking-btn proceed-btn">
              <router-link to="booking-success-one" class="btn btn-primary prime-btn">
                Proceed to Pay $163.00
              </router-link>
            </div>
          </div>
        </div>
        <!-- /Payment -->
      </div>
    </div>
  </div>
</template>
<script>
export default {
  methods: {
    submitForm() {
      this.$router.push("/booking-success-one");
    },
  },
};
</script>
