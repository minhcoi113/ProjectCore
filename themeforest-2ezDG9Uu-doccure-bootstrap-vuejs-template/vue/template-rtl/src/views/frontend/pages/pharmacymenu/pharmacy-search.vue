<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <!-- Page Content -->
    <div class="content">
      <div class="container">
        <div class="row">
          <div class="col-md-12 col-lg-4 col-xl-3 theiaStickySidebar">
            <div class="stickysidebar">
              <pharmacy-filter></pharmacy-filter>
            </div>
          </div>

          <div class="col-md-12 col-lg-8 col-xl-9">
            <!-- Doctor Widget -->
            <div class="card" v-for="item in PharmacySearch" :key="item.id">
              <div class="card-body">
                <div class="doctor-widget">
                  <div class="doc-info-left">
                    <div class="doctor-img1">
                      <router-link to="/pharmacy-details">
                        <img
                          :src="require(`@/assets/img/${item.Image}`)"
                          class="img-fluid"
                          alt="User Image"
                        />
                      </router-link>
                    </div>
                    <div class="doc-info-cont">
                      <h4 class="doc-name mb-2">
                        <router-link to="/pharmacy-details">{{ item.Title }}</router-link>
                      </h4>
                      <div class="rating mb-2">
                        <span class="badge badge-primary me-1">{{ item.Rateing }}</span>
                        <i class="fas fa-star filled me-1"></i>
                        <i class="fas fa-star filled me-1"></i>
                        <i class="fas fa-star filled me-1"></i>
                        <i class="fas fa-star filled me-1"></i>
                        <i class="fas fa-star me-1"></i>
                        <span class="d-inline-block average-rating">{{
                          item.Views
                        }}</span>
                      </div>
                      <div class="clinic-details">
                        <div class="clini-infos pt-3">
                          <p class="doc-location mb-2">
                            <i class="fas fa-phone-volume me-1"></i> {{ item.Phone }}
                          </p>
                          <p class="doc-location mb-2 text-ellipse">
                            <i class="fas fa-map-marker-alt me-1"></i> {{ item.Address }}
                          </p>
                          <p class="doc-location mb-2">
                            <i class="fas fa-chevron-right me-1"></i> Chemists, Surgical
                            Equipment Dealer
                          </p>

                          <p class="doc-location mb-2">
                            <i class="fas fa-chevron-right me-1"></i> Opens at 08.00 AM
                          </p>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="doc-info-right">
                    <div class="clinic-booking">
                      <router-link class="view-pro-btn" to="/pharmacy-details"
                        >View Details</router-link
                      >
                      <router-link class="apt-btn" to="/product-all"
                        >Browse Products</router-link
                      >
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <!-- /Doctor Widget -->

            <div class="load-more text-center">
              <a class="btn btn-primary btn-md" href="javascript:void(0);">Load More</a>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- /Page Content -->
  </div>
</template>

<script>
import PharmacySearch from "@/assets/json/pharmacy-search.json";
export default {
  data() {
    return {
      title: "Search",
      text: "Home",
      text1: "Search",
      PharmacySearch: PharmacySearch,
    };
  },
};
</script>
