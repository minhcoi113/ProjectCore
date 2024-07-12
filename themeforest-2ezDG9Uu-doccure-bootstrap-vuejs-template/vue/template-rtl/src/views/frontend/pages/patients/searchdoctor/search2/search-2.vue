<template>
  <div class="main-wrapper search-page">
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
                            <router-link
                              @click="redirectReloadSearch"
                              to="doctor-search-grid"
                            >
                              <i class="feather-grid"></i>
                            </router-link>
                          </li>
                          <li>
                            <router-link to="/search-2" class="active">
                              <i class="feather-list"></i>
                            </router-link>
                          </li>
                        </ul>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="card doctor-card" v-for="item in search2" :key="item.id">
                  <div class="card-body">
                    <div class="doctor-widget-one">
                      <div class="doc-info-left">
                        <div class="doctor-img">
                          <router-link to="doctor-profile">
                            <img
                              :src="require(`@/assets/img/doctors/${item.DoctorImg}`)"
                              class="img-fluid"
                              alt="John Doe"
                            />
                          </router-link>
                          <div class="favourite-btn">
                            <a
                              href="javascript:void(0)"
                              class="favourite-icon"
                              :class="{ favourite: item.isFavourite }"
                              @click="toggleFavourite(item)"
                            >
                              <i class="fas fa-heart"></i>
                            </a>
                          </div>
                        </div>
                        <div class="doc-info-cont">
                          <h4 class="doc-name">
                            <router-link to="doctor-profile">{{
                              item.DoctorName
                            }}</router-link>
                            <i class="fas fa-circle-check"></i>
                          </h4>
                          <p class="doc-speciality">{{ item.Speciality }}</p>
                          <div class="clinic-details">
                            <p class="doc-location">
                              <i class="feather-map-pin"></i>
                              <span>{{ item.Km }}</span
                              >{{ item.Location }}
                              <a href="javascript:void(0);">Get Direction</a>
                            </p>
                            <p class="doc-location">
                              <i class="feather-award"></i>
                              <span>{{ item.Years }}</span>
                              Years of Experience
                            </p>
                          </div>
                          <div class="reviews-ratings">
                            <p>
                              <span><i class="fas fa-star"></i> {{ item.Star }}</span>
                              {{ item.Views }}
                            </p>
                          </div>
                        </div>
                      </div>
                      <div class="doc-info-right">
                        <div class="clini-infos">
                          <ul>
                            <li>
                              <i class="feather-clock available-icon"></i>
                              <span :class="item.class">{{ item.Available }}</span>
                            </li>
                            <li>
                              <i class="feather-thumbs-up available-icon"></i>
                              {{ item.percentage }}
                              <span class="votes">{{ item.Vote }}</span>
                            </li>
                            <li>
                              <i class="feather-dollar-sign available-icon"></i>
                              {{ item.Price }}
                              <i class="feather-info available-info-icon"></i>
                            </li>
                          </ul>
                        </div>
                        <div class="clinic-booking book-appoint">
                          <router-link class="btn btn-primary" to="booking"
                            >Book Appointment</router-link
                          >
                          <router-link class="btn btn-primary-light" to="booking-2"
                            >Book Online Consultation</router-link
                          >
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
          <div class="col-xl-3 col-lg-12 theiaStickySidebar">
            <search2map></search2map>
          </div>
        </div>
      </div>
    </div>

    <indexfooter></indexfooter>
  </div>
</template>
<script>
import search2 from "@/assets/json/searchdoctor/search2.json";
export default {
  data() {
    return {
      title: "Search Doctors",
      text: "Home",
      text1: "Search Doctors",
      search2: search2,
      Sort: ["A to Z", "B to Z", "C to Z", "D to Z", "E to Z"],
      isFavourite: false,
    };
  },
  methods: {
    toggleFavourite(item) {
      item.isFavourite = !item.isFavourite;
    },
    redirectReloadSearch() {
      this.$router.push({ path: "/doctor-search-grid" }).then(() => {
        this.$router.go();
      });
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
