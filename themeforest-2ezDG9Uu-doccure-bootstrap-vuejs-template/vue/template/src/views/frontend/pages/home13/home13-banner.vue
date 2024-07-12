<template>
  <section class="banner-section banner-sec-fourteen">
    <div class="container">
      <div class="row align-items-center">
        <div class="col-lg-6">
          <div class="banner-content">
            <div class="banner-head">
              <h6>LET’s Take CARE</h6>
              <h1>Home Care Services in Your Area</h1>
              <p>Book an expert caregiver that you can trust. To get started</p>
            </div>
            <div class="banner-form-field">
              <span>Home Visit</span>
              <form action="">
                <div class="row">
                  <div class="col-xl-6 col-lg-12 col-md-6">
                    <div class="input-block">
                      <div class="icon-badge">
                        <span><i class="feather-user"></i></span>
                      </div>
                      <div class="banner-input-box">
                        <label class="form-label">Name</label>
                        <input
                          type="text"
                          class="form-control"
                          placeholder="Dorothy Joanne"
                        />
                      </div>
                    </div>
                  </div>
                  <div class="col-xl-6 col-lg-12 col-md-6">
                    <div class="input-block">
                      <div class="icon-badge">
                        <span><i class="feather-smartphone"></i></span>
                      </div>
                      <div class="banner-input-box">
                        <label class="form-label">Phone Number</label>
                        <input
                          type="text"
                          class="form-control"
                          placeholder="1 XXXXX YYY95"
                        />
                      </div>
                    </div>
                  </div>
                  <div class="col-xl-6 col-lg-12 col-md-6">
                    <div class="input-block">
                      <div class="icon-badge">
                        <span><i class="feather-mail"></i></span>
                      </div>
                      <div class="banner-input-box">
                        <label class="form-label">Email</label>
                        <input
                          type="email"
                          class="form-control"
                          placeholder="Sample@example.com"
                        />
                      </div>
                    </div>
                  </div>
                  <div class="col-xl-6 col-lg-12 col-md-6">
                    <div class="input-block">
                      <div class="icon-badge">
                        <span><i class="feather-map-pin"></i></span>
                      </div>
                      <div class="banner-input-box">
                        <label class="form-label">Location</label>
                        <input
                          type="text"
                          class="form-control"
                          placeholder="Newyork, United States"
                        />
                      </div>
                    </div>
                  </div>
                </div>
              </form>
            </div>
            <div class="banner-btns">
              <router-link to="booking-2" class="btn appoint-btn"
                ><i class="feather-file me-2"></i>Book an Appointment</router-link
              >
              <router-link to="index-13" class="btn demo-btn"
                ><i class="feather-video me-2"></i>Live Demo</router-link
              >
            </div>
            <div class="watch-video">
              <a href="#">
                <span><i class="fa-solid fa-circle-play"></i></span>
                Watch Video About Us
              </a>
            </div>
          </div>
        </div>
        <div class="col-lg-6">
          <div class="banner-sec-img">
            <span
              ><img src="@/assets/img/banner-img-13.png" class="img-fluid" alt="Img"
            /></span>
            <span class="banner-curve" data-aos-delay="500"
              ><img
                src="@/assets/img/banner-img-curve-13.png"
                class="img-fluid"
                alt="Img"
            /></span>
            <span class="banner-round-bg"
              ><img src="@/assets/img/banner-round-vector-13.png" alt="Img"
            /></span>
            <span class="cloud-bg-one" data-aos="fade-right" data-aos-delay="500"
              ><img src="@/assets/img/banner-cluoud-01.png" alt="Img"
            /></span>
            <span class="cloud-bg-two" data-aos="fade-left" data-aos-delay="500"
              ><img src="@/assets/img/banner-cluoud-02.png" alt="Img"
            /></span>
            <span class="lief-img"
              ><img src="@/assets/img/banner-lief-img.png" alt="Img"
            /></span>
            <span class="banner-curve-two"
              ><img src="@/assets/img/banner-curve-bg.png" alt="Img"
            /></span>
            <span class="chat-call-btn"
              ><router-link to="chat-doctor">Chat and Call Now</router-link></span
            >
            <div class="banner-cal-icon">
              <span class="calender-border"
                ><img src="@/assets/img/icons/banner-cal-icon.svg" alt="Img"
              /></span>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>
