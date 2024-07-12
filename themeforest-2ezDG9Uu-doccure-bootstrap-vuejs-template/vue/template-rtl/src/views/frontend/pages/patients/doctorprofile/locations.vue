<template>
  <div role="tabpanel" id="doc_locations" class="tab-pane fade">
    <!-- Location List -->
    <div class="location-list">
      <div class="row">
        <!-- Clinic Content -->
        <div class="col-md-6">
          <div class="clinic-content">
            <h4 class="clinic-name"><a href="javascript:;">Smile Cute Dental Care Center</a></h4>
            <p class="doc-speciality">MDS - Periodontology and Oral Implantology, BDS</p>
            <div class="rating">
              <i class="fas fa-star filled"></i>
              <i class="fas fa-star filled ms-1"></i>
              <i class="fas fa-star filled ms-1"></i>
              <i class="fas fa-star filled ms-1"></i>
              <i class="fas fa-star ms-1"></i>
              <span class="d-inline-block average-rating ms-1">(4)</span>
            </div>
            <div class="clinic-details mb-0">
              <h5 class="clinic-direction">
                <i class="fas fa-map-marker-alt"></i> 2286 Sundown Lane, Austin, Texas
                78749, USA <br /><a href="javascript:void(0);">Get Directions</a>
              </h5>
              <ul>
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
          </div>
        </div>
        <!-- /Clinic Content -->

        <!-- Clinic Timing -->
        <div class="col-md-4">
          <div class="clinic-timing">
            <div>
              <p class="timings-days">
                <span> Mon - Sat </span>
              </p>
              <p class="timings-times">
                <span>10:00 AM - 2:00 PM</span>
                <span>4:00 PM - 9:00 PM</span>
              </p>
            </div>
            <div>
              <p class="timings-days">
                <span>Sun</span>
              </p>
              <p class="timings-times">
                <span>10:00 AM - 2:00 PM</span>
              </p>
            </div>
          </div>
        </div>
        <!-- /Clinic Timing -->

        <div class="col-md-2">
          <div class="consult-price">$250</div>
        </div>
      </div>
    </div>
    <!-- /Location List -->

    <!-- Location List -->
    <div class="location-list">
      <div class="row">
        <!-- Clinic Content -->
        <div class="col-md-6">
          <div class="clinic-content">
            <h4 class="clinic-name"><a href="javascript:;">The Family Dentistry Clinic</a></h4>
            <p class="doc-speciality">MDS - Periodontology and Oral Implantology, BDS</p>
            <div class="rating">
              <i class="fas fa-star filled"></i>
              <i class="fas fa-star filled ms-1"></i>
              <i class="fas fa-star filled ms-1"></i>
              <i class="fas fa-star filled ms-1"></i>
              <i class="fas fa-star me-1"></i>
              <span class="d-inline-block average-rating ms-1">(4)</span>
            </div>
            <div class="clinic-details mb-0">
              <p class="clinic-direction">
                <i class="fas fa-map-marker-alt"></i> 2883 University Street, Seattle,
                Texas Washington, 98155 <br /><a href="javascript:void(0);"
                  >Get Directions</a
                >
              </p>
              <ul>
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
          </div>
        </div>
        <!-- /Clinic Content -->

        <!-- Clinic Timing -->
        <div class="col-md-4">
          <div class="clinic-timing">
            <div>
              <p class="timings-days">
                <span> Tue - Fri </span>
              </p>
              <p class="timings-times">
                <span>11:00 AM - 1:00 PM</span>
                <span>6:00 PM - 11:00 PM</span>
              </p>
            </div>
            <div>
              <p class="timings-days">
                <span>Sat - Sun</span>
              </p>
              <p class="timings-times">
                <span>8:00 AM - 10:00 AM</span>
                <span>3:00 PM - 7:00 PM</span>
              </p>
            </div>
          </div>
        </div>
        <!-- /Clinic Timing -->

        <div class="col-md-2">
          <div class="consult-price">$350</div>
        </div>
      </div>
    </div>
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
</template>
<script>
import VueEasyLightbox from "vue-easy-lightbox";
export default {
  components: {
    VueEasyLightbox,
  },
  data() {
    return {
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
