<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="doctor-content content">
      <div class="container">
        <!-- Doctor Search List -->
        <div class="row">
          <div class="col-xl-12 col-lg-12 map-view">
            <div class="row">
              <div class="col-lg-3 theiaStickySidebar">
                <search2filter></search2filter>
              </div>
              <div class="col-lg-9">
                <div class="doctor-filter-info">
                  <div class="doctor-filter-inner">
                    <div>
                      <div class="doctors-found">
                        <p>
                          <span>100 Doctors found for:</span> Dentist in San francisco,
                          California
                        </p>
                      </div>
                      <div class="doctor-filter-availability">
                        <p>Availability</p>
                        <div class="status-toggle status-tog">
                          <input type="checkbox" id="status_6" class="check" />
                          <label for="status_6" class="checktoggle">checkbox</label>
                        </div>
                      </div>
                    </div>
                    <div class="doctor-filter-option">
                      <div class="doctor-filter-sort">
                        <p>Sort</p>
                        <div class="doctor-filter-select">
                          <vue-select :options="Sort" placeholder="A to Z" />
                        </div>
                      </div>
                      <div class="doctor-filter-sort">
                        <p class="filter-today d-flex align-items-center">
                          <i class="feather-calendar"></i> Today 10 Aug to 20 Aug
                        </p>
                      </div>
                      <div class="doctor-filter-sort">
                        <ul class="nav">
                          <li>
                            <a href="javascript:void(0);" id="map-list">
                              <i class="feather-map-pin"></i>
                            </a>
                          </li>
                          <li>
                            <router-link to="doctor-search-grid" class="active">
                              <i class="feather-grid"></i>
                            </router-link>
                          </li>
                          <li>
                            <router-link to="search-2">
                              <i class="feather-list"></i>
                            </router-link>
                          </li>
                        </ul>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="row">
                  <div
                    class="col-xl-4 col-lg-6 col-md-6"
                    v-for="item in doctorsearchgrid"
                    :key="item.id"
                  >
                    <div class="doctor-profile-widget doc-grid">
                      <div class="doc-pro-img">
                        <router-link to="doctor-profile">
                          <div class="doctor-profile-img">
                            <img
                              :src="require(`@/assets/img/doctors/${item.image}`)"
                              class="img-fluid"
                              alt="John Doe"
                            />
                          </div>
                        </router-link>
                        <div class="reviews-ratings">
                          <p>
                            <span><i class="fas fa-star"></i>{{ item.rating }}</span>
                          </p>
                        </div>
                        <div class="favourite-btn">
                          <a
                            href="javascript:void(0)"
                            class="favourite-icon"
                            @click="toggleFavorite(item)"
                          >
                            <i
                              :class="['fas', 'fa-heart', { favorite: item.isFavorite }]"
                            ></i>
                          </a>
                        </div>
                      </div>
                      <div class="doc-content">
                        <div class="doc-pro-info">
                          <div class="doc-pro-name">
                            <h4>
                              <router-link to="doctor-profile">{{
                                item.doctor
                              }}</router-link
                              ><i class="fas fa-circle-check"></i>
                            </h4>
                            <p>{{ item.specialty }}</p>
                          </div>
                          <div class="review-price">
                            <p>
                              {{ item.price }}<span>{{ item.hours }}</span>
                            </p>
                          </div>
                        </div>
                        <div class="doc-pro-location">
                          <p>
                            <i class="feather-map-pin"></i> <span>{{ item.km }}</span
                            >{{ item.location }}
                          </p>
                          <p>
                            <i class="feather-award"></i> <span>{{ item.year }}</span>
                            {{ item.experience }}
                          </p>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="row">
                  <div class="col-sm-12">
                    <div class="blog-pagination rev-page">
                      <nav>
                        <ul class="pagination justify-content-center">
                          <li class="page-item disabled">
                            <a
                              class="page-link page-prev"
                              href="javascript:;"
                              tabindex="-1"
                              ><i class="feather-chevrons-left me-1"></i> PREV</a
                            >
                          </li>
                          <li class="page-item active">
                            <a class="page-link" href="javascript:;">1</a>
                          </li>
                          <li class="page-item">
                            <a class="page-link" href="javascript:;">2</a>
                          </li>
                          <li class="page-item">
                            <a class="page-link" href="javascript:;">...</a>
                          </li>
                          <li class="page-item">
                            <a class="page-link" href="javascript:;">10</a>
                          </li>
                          <li class="page-item">
                            <a class="page-link page-next" href="javascript:;"
                              >NEXT <i class="feather-chevrons-right ms-1"></i
                            ></a>
                          </li>
                        </ul>
                      </nav>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="col-xl-3 col-lg-12 theiaStickySidebar map-right">
            <search2map></search2map>
          </div>
        </div>
        <!-- /Doctor Search List -->
      </div>
    </div>
    <indexfooter></indexfooter>
    <div class="mouse-cursor cursor-outer"></div>
    <div class="mouse-cursor cursor-inner"></div>
  </div>
</template>
<script>
import doctorsearchgrid from "@/assets/json/searchdoctor/doctor-search-grid.json";
export default {
  data() {
    return {
      title: "Search Doctors",
      text: "Home",
      text1: "Search Doctors",
      doctorsearchgrid: doctorsearchgrid,
      Sort: ["A to Z", "B to Z", "C to Z", "D to Z", "E to Z"],
      isFavorite: false,
    };
  },
  methods: {
    toggleFavorite(item) {
      item.isFavorite = !item.isFavorite;
    },
  },
  mounted() {
    const mapListButton = document.getElementById("map-list");
    if (mapListButton) {
      mapListButton.addEventListener("click", function () {
        var container = this.closest(".container");
        if (container) {
          container.classList.add("container-fluid");
          container.classList.remove("container");
        }

        var mapView = document.querySelector(".map-view");
        if (mapView) {
          mapView.classList.remove("col-xl-12");
          mapView.classList.add("col-xl-9");
        }

        var mapRight = document.querySelector(".map-right");
        if (mapRight) {
          mapRight.style.display = "block";
        }

        var timeSlotSlider = document.getElementsByClassName("time-slot-slider")[0];
        if (timeSlotSlider && timeSlotSlider.slick && timeSlotSlider.slick.refresh) {
          timeSlotSlider.slick.refresh();
        }
      });
    }
  },
};
</script>
<style scoped>
.favorite {
  color: red;
}
</style>
