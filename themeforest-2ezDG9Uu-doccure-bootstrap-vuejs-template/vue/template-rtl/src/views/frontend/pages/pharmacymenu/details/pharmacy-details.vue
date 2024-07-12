<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <!-- Page Content -->
    <div class="content">
      <div class="container">
        <!-- Doctor Widget -->
        <div class="card">
          <div class="card-body">
            <div class="doctor-widget">
              <div class="doc-info-left">
                <div class="doctor-img1">
                  <router-link to="/pharmacy-details">
                    <img
                      src="@/assets/img/medical-img1.jpg"
                      class="img-fluid"
                      alt="User Image"
                    />
                  </router-link>
                </div>
                <div class="doc-info-cont">
                  <h4 class="doc-name mb-2">
                    <router-link to="/pharmacy-details">Medlife Medical</router-link>
                  </h4>
                  <div class="rating mb-2">
                    <span class="badge badge-primary me-1">4.0</span>
                    <i class="fas fa-star filled me-1"></i>
                    <i class="fas fa-star filled me-1"></i>
                    <i class="fas fa-star filled me-1"></i>
                    <i class="fas fa-star filled me-1"></i>
                    <i class="fas fa-star me-1"></i>
                    <span class="d-inline-block average-rating">(17)</span>
                  </div>
                  <div class="clinic-details">
                    <div class="clini-infos pt-3">
                      <p class="doc-location mb-2">
                        <i class="fas fa-phone-volume me-1"></i>
                        320-795-8815
                      </p>
                      <p class="doc-location mb-2 text-ellipse">
                        <i class="fas fa-map-marker-alt me-1"></i> 96 Red Hawk Road Cyrus,
                        MN 56323
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
              <div
                class="doc-info-right d-flex align-items-center justify-content-center"
              >
                <div class="clinic-booking">
                  <router-link class="view-pro-btn" to="/chat">Send Message</router-link>
                  <a
                    class="apt-btn"
                    href="javascript:;"
                    data-bs-toggle="modal"
                    data-bs-target="#voice_call"
                    >Call Now</a
                  >
                  <router-link to="product-all" class="view-pro-btn"
                    >Browse Products</router-link
                  >
                </div>
              </div>
            </div>
          </div>
        </div>
        <!-- /Doctor Widget -->

        <!-- Doctor Details Tab -->
        <div class="card">
          <div class="card-body pt-0">
            <!-- Tab Menu -->
            <nav class="user-tabs mb-4">
              <ul class="nav nav-tabs nav-tabs-bottom nav-justified">
                <li class="nav-item">
                  <a class="nav-link active" href="#doc_overview" data-bs-toggle="tab"
                    >Overview</a
                  >
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="#doc_locations" data-bs-toggle="tab"
                    >Locations</a
                  >
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="#doc_reviews" data-bs-toggle="tab">Reviews</a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="#doc_business_hours" data-bs-toggle="tab"
                    >Business Hours</a
                  >
                </li>
              </ul>
            </nav>
            <!-- /Tab Menu -->

            <!-- Tab Content -->
            <div class="tab-content pt-0">
              <!-- Overview Content -->
              <overview-content></overview-content>
              <!-- /Overview Content -->

              <!-- Locations Content -->
              <location-content></location-content>
              <!-- /Locations Content -->

              <!-- Reviews Content -->
              <review-content></review-content>
              <!-- /Reviews Content -->

              <!-- Business Hours Content -->
              <business-content></business-content>
              <!-- /Business Hours Content -->
            </div>
          </div>
        </div>
        <!-- /Doctor Details Tab -->
      </div>
    </div>
    <!-- /Page Content -->

    <indexfooter></indexfooter>
  </div>
  <!-- Voice Call Modal -->
  <div class="modal fade call-modal" id="voice_call">
    <div class="modal-dialog modal-dialog-centered" role="document">
      <div class="modal-content">
        <div class="modal-body">
          <!-- Outgoing Call -->
          <div class="call-box incoming-box">
            <div class="call-wrapper">
              <div class="call-inner">
                <div class="call-user">
                  <img
                    alt="User Image"
                    src="@/assets/img/doctors/doctor-thumb-02.jpg"
                    class="call-avatar"
                  />
                  <h4>Dr. Darren Elder</h4>
                  <span>Connecting...</span>
                </div>
                <div class="call-items">
                  <a
                    href="javascript:void(0);"
                    class="btn call-item call-end"
                    data-bs-dismiss="modal"
                    aria-label="Close"
                    ><i class="material-icons">call_end</i></a
                  >
                  <a
                    href="javascript:;"
                    class="btn call-item call-start"
                    data-bs-dismiss="modal"
                    aria-label="Close"
                    ><i class="material-icons">call</i></a
                  >
                </div>
              </div>
            </div>
          </div>
          <!-- Outgoing Call -->
        </div>
      </div>
    </div>
  </div>
  <!-- /Voice Call Modal -->
</template>

<script>
export default {
  data() {
    return {
      title: "Pharmacy Details",
      text: "Home",
      text1: "Pharmacy Details",
    };
  },
  name: "pharmacy-details",
};
</script>
