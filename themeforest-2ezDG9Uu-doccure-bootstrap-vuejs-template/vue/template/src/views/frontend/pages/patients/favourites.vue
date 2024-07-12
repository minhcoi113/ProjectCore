<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="content">
      <div class="container">
        <div class="row">
          <div class="col-md-5 col-lg-4 col-xl-3 theiaStickySidebar">
            <div class="stickysidebar">
              <profilesidebar></profilesidebar>
            </div>
          </div>
          <div class="col-md-7 col-lg-8 col-xl-9">
            <div class="row row-grid">
              <div
                class="col-md-6 col-lg-4 col-xl-3"
                v-for="item in patientfavourite"
                :key="item.id"
              >
                <div class="profile-widget">
                  <div class="doc-img">
                    <router-link to="doctor-profile">
                      <img
                        class="img-fluid"
                        alt="User Image"
                        :src="require(`@/assets/img/doctors/${item.DoctorImg}`)"
                      />
                    </router-link>
                    <a href="javascript:void(0)" class="fav-btn">
                      <i class="far fa-bookmark"></i>
                    </a>
                  </div>
                  <div class="pro-content">
                    <h3 class="title">
                      <router-link to="doctor-profile">{{ item.DoctorName }}</router-link>
                      <i class="fas fa-check-circle verified ms-2"></i>
                    </h3>
                    <p class="speciality">{{ item.speciality }}</p>
                    <div class="rating">
                      <i class="fas fa-star filled me-1"></i>
                      <i class="fas fa-star filled me-1"></i>
                      <i class="fas fa-star filled me-1"></i>
                      <i class="fas fa-star filled me-0"></i>
                      <i :class="item.class"></i>
                      <span class="d-inline-block average-rating ms-1">{{
                        item.Views
                      }}</span>
                    </div>
                    <ul class="available-info">
                      <li><i class="fas fa-map-marker-alt"></i> {{ item.Location }}</li>
                      <li><i class="far fa-clock"></i> {{ item.Available }}</li>
                      <li>
                        <i class="far fa-money-bill-alt"></i> {{ item.Price }}
                        <i
                          class="fas fa-info-circle"
                          data-bs-toggle="tooltip"
                          title="Lorem Ipsum"
                        ></i>
                      </li>
                    </ul>
                    <div class="row row-sm">
                      <div class="col-6">
                        <router-link to="doctor-profile" class="btn view-btn"
                          >View Profile</router-link
                        >
                      </div>
                      <div class="col-6">
                        <router-link to="booking" class="btn book-btn"
                          >Book Now</router-link
                        >
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
  <indexfooter></indexfooter>
</template>

<script>
import patientfavourite from "@/assets/json/patientfavourites.json";

export default {
  data() {
    return {
      title: "Favourites",
      text: "Home",
      text1: "Favourites",
      patientfavourite: patientfavourite,
    };
  },
};
</script>
