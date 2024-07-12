<template>
  <section class="section pharmacy-banner">
    <div class="pharmacy-shapes">
      <div class="pharmacy-shape-left">
        <img src="@/assets/img/shapes/shape-5.png" alt="" />
        <img src="@/assets/img/shapes/shape-6.png" class="shape-six" alt="" />
      </div>
      <div class="pharmacy-shape-right">
        <img src="@/assets/img/shapes/shape-8.png" class="shape-eight" alt="" />
        <img src="@/assets/img/shapes/shape-7.png" class="shape-seven" alt="" />
      </div>
    </div>
    <div class="container">
      <div class="row align-items-center">
        <div class="col-lg-6 col-md-12">
          <div class="pharmacy-content">
            <h1>From the Leading Online Pharmacy</h1>
            <h4>& Healthcare Platform Company</h4>
            <p>
              Essentials Nutrition & Supplements from all over the suppliers around the
              World
            </p>
          </div>
          <div class="pharmacy-btn">
            <router-link to="pharmacy-search" class="btn">Shop Now</router-link>
          </div>
        </div>
        <div class="col-lg-6 col-md-12">
          <div class="pharmacy-banner-img">
            <img
              src="@/assets/img/pharmacy-img.png"
              class="img-fluid"
              alt="Pharmacy Img"
            />
          </div>
        </div>
      </div>
    </div>
  </section>
</template>
