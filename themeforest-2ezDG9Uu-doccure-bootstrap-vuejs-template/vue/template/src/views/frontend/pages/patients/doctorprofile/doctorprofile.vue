<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="content">
      <div class="container">
        <!-- Doctor Widget -->
        <div class="card">
          <div class="card-body">
            <div class="doctor-widget">
              <div class="doc-info-left">
                <div class="doctor-img">
                  <img
                    src="@/assets/img/doctors/doctor-thumb-02.jpg"
                    class="img-fluid"
                    alt="User Image"
                  />
                </div>
                <div class="doc-info-cont">
                  <h4 class="doc-name">Dr. Darren Elder</h4>
                  <p class="doc-speciality">BDS, MDS - Oral & Maxillofacial Surgery</p>
                  <p class="doc-department">
                    <img
                      src="@/assets/img/specialities/specialities-05.png"
                      class="img-fluid"
                      alt="Speciality"
                    />Dentist
                  </p>
                  <div class="rating me-2">
                    <i class="fas fa-star filled"></i>
                    <i class="fas fa-star filled ms-1"></i>
                    <i class="fas fa-star filled ms-1"></i>
                    <i class="fas fa-star filled ms-1"></i>
                    <i class="fas fa-star ms-1"></i>
                    <span class="d-inline-block average-rating ms-1">(35)</span>
                  </div>
                  <div class="clinic-details">
                    <p class="doc-location">
                      <i class="fas fa-map-marker-alt"></i> Newyork, USA -
                      <a href="javascript:void(0);">Get Directions</a>
                    </p>
                    <ul class="clinic-gallery">
                      <li
                        class="ms-1"
                        v-for="(image, index) in galleryImages"
                        :key="index"
                        @click="() => show(index)"
                      >
                        <a data-fancybox="gallery">
                          <img
                            :src="require(`@/assets/img/features/${image.src}`)"
                            alt="Feature"
                          />
                        </a>
                      </li>
                    </ul>
                  </div>
                  <div class="clinic-services">
                    <span>Dental Fillings</span>
                    <span>Teeth Whitneing</span>
                  </div>
                </div>
              </div>
              <div class="doc-info-right">
                <div class="clini-infos">
                  <ul>
                    <li><i class="far fa-thumbs-up"></i> 99%</li>
                    <li><i class="far fa-comment"></i> 35 Feedback</li>
                    <li><i class="fas fa-map-marker-alt"></i> Newyork, USA</li>
                    <li><i class="far fa-money-bill-alt"></i> $100 per hour</li>
                  </ul>
                </div>
                <div class="doctor-action">
                  <a href="javascript:void(0)" class="btn btn-white fav-btn">
                    <i class="far fa-bookmark"></i>
                  </a>
                  <router-link to="chat" class="btn btn-white msg-btn">
                    <i class="far fa-comment-alt"></i>
                  </router-link>
                  <a
                    href="javascript:void(0)"
                    class="btn btn-white call-btn"
                    data-bs-toggle="modal"
                    data-bs-target="#voice_call"
                  >
                    <i class="fas fa-phone"></i>
                  </a>
                  <a
                    href="javascript:void(0)"
                    class="btn btn-white call-btn"
                    data-bs-toggle="modal"
                    data-bs-target="#video_call"
                  >
                    <i class="fas fa-video"></i>
                  </a>
                </div>
                <div class="clinic-booking">
                  <router-link class="apt-btn" to="booking">Book Appointment</router-link>
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
              <overview></overview>
              <!-- /Overview Content -->
              <!-- Locations Content -->
              <locations></locations>
              <!-- /Locations Content -->
              <!-- Reviews Content -->
              <reviews></reviews>
              <!-- /Reviews Content -->
              <!-- Business Hours Content -->
              <businesshours></businesshours>
              <!-- /Business Hours Content -->
            </div>
          </div>
        </div>
        <!-- /Doctor Details Tab -->
      </div>
    </div>
    <indexfooter></indexfooter>

    <vue-easy-lightbox
      :visible="visible"
      :index="index"
      :imgs="
        galleryImages.map((image) => ({
          src: require(`@/assets/img/features/${image.src}`),
        }))
      "
      @hide="visible = false"
      @on-prev="handlePrev"
      @on-next="handleNext"
    >
    </vue-easy-lightbox>
  </div>
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

  <!-- Video Call Modal -->
  <div class="modal fade call-modal" id="video_call">
    <div class="modal-dialog modal-dialog-centered" role="document">
      <div class="modal-content">
        <div class="modal-body">
          <!-- Incoming Call -->
          <div class="call-box incoming-box">
            <div class="call-wrapper">
              <div class="call-inner">
                <div class="call-user">
                  <img
                    class="call-avatar"
                    src="@/assets/img/doctors/doctor-thumb-02.jpg"
                    alt="User Image"
                  />
                  <h4>Dr. Darren Elder</h4>
                  <span>Calling ...</span>
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
                    ><i class="material-icons">videocam</i></a
                  >
                </div>
              </div>
            </div>
          </div>
          <!-- /Incoming Call -->
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import VueEasyLightbox from "vue-easy-lightbox";
export default {
  components: {
    VueEasyLightbox,
  },
  data() {
    return {
      title: "Doctor Profile",
      text: "Home",
      text1: "Doctor Profile",
      visible: false,
      index: 0,
      galleryImages: [
        {
          src: "feature-01.jpg",
        },
        {
          src: "feature-02.jpg",
        },
        {
          src: "feature-03.jpg",
        },
        {
          src: "feature-04.jpg",
        },
      ],
    };
  },
  methods: {
    show(index) {
      this.index = index;
      this.visible = true;
    },
    handlePrev(oldIndex, newIndex) {
      console.log("when prev btn click or user swipe right ----");
      console.log("oldIndex of imgs:", oldIndex);
      console.log("newIndex of imgs:", newIndex);
    },
    handleNext(oldIndex, newIndex) {
      console.log("when next btn click or user swipe left ----");
      console.log("oldIndex of imgs:", oldIndex);
      console.log("newIndex of imgs:", newIndex);
    },
  },
};
</script>
