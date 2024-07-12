<template>
  <div class="map-page">
    <div class="main-wrapper">
      <layoutheader></layoutheader>

      <div class="content top-space">
        <div class="container">
          <div class="row">
            <div
              class="col-xl-6 col-lg-12 order-md-last order-sm-last order-last map-left"
            >
              <div class="row align-items-center mb-4">
                <div class="col-md-6 col">
                  <h4>2245 Doctors found</h4>
                </div>

                <div class="col-md-6 col-auto">
                  <div class="view-icons">
                    <router-link
                      to="map-grid"
                      class="grid-view active"
                      @click="redirectReloadmapgrid"
                      ><i class="fas fa-th-large"></i
                    ></router-link>
                    <router-link
                      to="map-list"
                      class="list-view"
                      @click="redirectReloadmaplist"
                      ><i class="fas fa-bars"></i
                    ></router-link>
                  </div>
                  <div class="sort-by d-sm-block d-none">
                    <span class="sortby-fliter">
                      <vue-select :options="Sort" placeholder="Sort by" />
                    </span>
                  </div>
                </div>
              </div>

              <div class="row">
                <div
                  class="col-sm-6 col-md-4 col-xl-6"
                  v-for="item in map_gird"
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
                        <router-link to="doctor-profile">{{
                          item.DoctorName
                        }}</router-link>
                        <i class="fas fa-check-circle verified"></i>
                      </h3>
                      <p class="speciality">{{ item.speciality }}</p>
                      <div class="rating">
                        <i class="fas fa-star filled"></i>
                        <i class="fas fa-star filled ms-1"></i>
                        <i class="fas fa-star filled ms-1"></i>
                        <i class="fas fa-star filled ms-1"></i>
                        <i class="fas fa-star filled ms-1"></i>
                        <span class="d-inline-block average-rating">{{
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
              <div class="load-more text-center">
                <a class="btn btn-primary btn-sm" href="javascript:void(0);">Load More</a>
              </div>
            </div>
            <!-- /content-left-->
            <div class="col-xl-6 col-lg-12 map-right grid-list-map">
              <div id="map" class="map-listing"></div>
              <!-- map-->
            </div>
            <!-- /map-right-->
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import map_gird from "@/assets/json/patient-doctors/map-gird.json";

const icons = {
  default: require("@/assets/img/marker.png"),
};

const locations = [
  {
    id: 1,
    doc_name: "Dr. Ruby Perrin",
    speciality: "MDS - Periodontology and Oral Implantology, BDS",
    address: "Florida, USA",
    next_available: "Available on Fri, 22 Mar",
    amount: "$300 - $1000",
    lat: 53.470692,
    lng: -2.220328,
    icons: "default",
    profile_link: "profile",
    total_review: "17",
    image: "doctor-01.jpg",
  },
  {
    id: 2,
    doc_name: "Dr. Darren Elder",
    speciality: "BDS, MDS - Oral & Maxillofacial Surgery",
    address: "Newyork, USA",
    next_available: "Available on Fri, 23 Mar",
    amount: "$50 - $300",
    lat: 53.469189,
    lng: -2.199262,
    icons: "default",
    profile_link: "profile",
    total_review: "35",
    image: "doctor-02.jpg",
  },
  {
    id: 3,
    doc_name: "Dr. Deborah Angel",
    speciality: "MBBS, MD - General Medicine, DNB - Cardiology",
    address: "Georgia, USA",
    next_available: "Available on Fri, 24 Mar",
    amount: "$100 - $400",
    lat: 53.468665,
    lng: -2.189269,
    icons: "default",
    profile_link: "profile",
    total_review: "27",
    image: "doctor-03.jpg",
  },
  {
    id: 4,
    doc_name: "Dr. Sofia Brient",
    speciality: "MBBS, MS - General Surgery, MCh - Urology",
    address: "Louisiana, USA",
    next_available: "Available on Fri, 25 Mar",
    amount: "$150 - $250",
    lat: 53.463894,
    lng: -2.17788,
    icons: "default",
    profile_link: "profile",
    total_review: "4",
    image: "doctor-04.jpg",
  },
  {
    id: 5,
    doc_name: "Dr. Marvin Campbell",
    speciality: "MBBS, MD - Ophthalmology, DNB - Ophthalmology",
    address: "Michigan, USA",
    next_available: "Available on Fri, 25 Mar",
    amount: "$50 - $700",
    lat: 53.466359,
    lng: -2.213314,
    icons: "default",
    profile_link: "profile",
    total_review: "66",
    image: "doctor-05.jpg",
  },
  {
    id: 6,
    doc_name: "Dr. Katharine Berthold",
    speciality: "MS - Orthopaedics, MBBS, M.Ch - Orthopaedics",
    address: "Texas, USA",
    next_available: "Available on Fri, 25 Mar",
    amount: "$100 - $500",
    lat: 53.463906,
    lng: -2.213271,
    icons: "default",
    profile_link: "profile",
    total_review: "52",
    image: "doctor-06.jpg",
  },
  {
    id: 7,
    doc_name: "Dr. Linda Tobin",
    speciality: "MBBS, MD - General Medicine, DM - Neurology",
    address: "Kansas, USA",
    next_available: "Available on Fri, 25 Mar",
    amount: "$100 - $1000",
    lat: 53.461974,
    lng: -2.210661,
    icons: "default",
    profile_link: "profile",
    total_review: "43",
    image: "doctor-07.jpg",
  },
  {
    id: 8,
    doc_name: "Dr. Paul Richard",
    speciality: "MDS - Periodontology and Oral Implantology, BDS",
    address: "California, USA",
    next_available: "Available on Fri, 25 Mar",
    amount: "$100 - $400",
    lat: 53.458785,
    lng: -2.188532,
    icons: "default",
    profile_link: "profile",
    total_review: "49",
    image: "doctor-08.jpg",
  },
  {
    id: 9,
    doc_name: "Dr. John Gibbs",
    speciality: "MBBS, MD - Dermatology , Venereology & Lepros",
    address: "Oklahoma, USA",
    next_available: "Available on Fri, 25 Mar",
    amount: "$500 - $2500",
    lat: 53.4558571,
    lng: -2.1950372,
    icons: "default",
    profile_link: "profile",
    total_review: "112",
    image: "doctor-09.jpg",
  },
  {
    id: 10,
    doc_name: "Dr. Olga Barlow",
    speciality: "MDS - Periodontology and Oral Implantology, BDS",
    address: "Montana, USA",
    next_available: "Available on Fri, 25 Mar",
    amount: "$75 - $250",
    lat: 53.45885,
    lng: -2.194549,
    icons: "default",
    profile_link: "profile",
    total_review: "65",
    image: "doctor-10.jpg",
  },
  {
    id: 11,
    doc_name: "Dr. Julia Washington",
    speciality: "MBBS, MD - General Medicine, DM - Endocrinology",
    address: "Oklahoma, USA",
    next_available: "Available on Fri, 25 Mar",
    amount: "$275 - $450",
    lat: 53.461733,
    lng: -2.194502,
    icons: "default",
    profile_link: "profile",
    total_review: "5",
    image: "doctor-11.jpg",
  },
  {
    id: 12,
    doc_name: "Dr. Shaun Aponte",
    speciality: "MBBS, MS - ENT, Diploma in Otorhinolaryngology (DLO)",
    address: "Indiana, USA",
    next_available: "Available on Fri, 25 Mar",
    amount: "$150 - $350",
    lat: 53.460548,
    lng: -2.190956,
    icons: "default",
    profile_link: "profile",
    total_review: "5",
    image: "doctor-12.jpg",
  },
];
export default {
  data() {
    return {
      map_gird: map_gird,
      Sort: ["Rating", "Popular", "Latest", "Free"],
      icons: icons,
      locations: locations,
    };
  },
  methods: {
    redirectReloadmapgrid() {
      this.$router.push({ path: "/map-grid" }).then(() => {
        this.$router.go();
      });
    },
    redirectReloadmaplist() {
      this.$router.push({ path: "/map-list" }).then(() => {
        this.$router.go();
      });
    },
  },
  mounted() {
    google.maps.visualRefresh = true;
    var slider,
      infowindow = null;
    var bounds = new google.maps.LatLngBounds();
    var map,
      current = 0;

    function show() {
      infowindow.close();
      if (!map.slide) {
        return;
      }
      var next, marker;
      if (locations.length == 0) {
        return;
      } else if (locations.length == 1) {
        next = 0;
      }
      if (locations.length > 1) {
        do {
          next = Math.floor(Math.random() * locations.length);
        } while (next == current);
      }
      current = next;
      marker = locations[next];
      setInfo(marker);
      infowindow.open(map, marker);
    }

    function initialize() {
      var bounds = new google.maps.LatLngBounds();
      var mapOptions = {
        zoom: 14,
        center: new google.maps.LatLng(53.470692, -2.220328),
        scrollwheel: false,
        mapTypeId: google.maps.MapTypeId.ROADMAP,
      };

      map = new google.maps.Map(document.getElementById("map"), mapOptions);
      map.slide = true;

      setMarkers(map, locations);
      infowindow = new google.maps.InfoWindow({
        content: "loading...",
      });
      google.maps.event.addListener(infowindow, "closeclick", function () {
        infowindow.close();
      });
      slider = window.setTimeout(show, 3000);
    }

    function setInfo(marker) {
      var content =
        '<div class="profile-widget" style="width: 100%; display: inline-block;">' +
        '<div class="doc-img">' +
        '<a href="' +
        marker.profile_link +
        '" tabindex="0" target="_blank">' +
        '<img class="img-fluid" alt="' +
        marker.doc_name +
        '" src="' +
        require(`@/assets/img/doctors/${marker.image}`) +
        '">' +
        "</a>" +
        "</div>" +
        '<div class="pro-content">' +
        '<h3 class="title">' +
        '<a href="' +
        marker.profile_link +
        '" tabindex="0">' +
        marker.doc_name +
        "</a>" +
        '<i class="fas fa-check-circle verified"></i>' +
        "</h3>" +
        '<p class="speciality">' +
        marker.speciality +
        "</p>" +
        '<div class="rating">' +
        '<i class="fas fa-star filled"></i>' +
        '<i class="fas fa-star filled ms-1"></i>' +
        '<i class="fas fa-star filled ms-1"></i>' +
        '<i class="fas fa-star filled ms-1"></i>' +
        '<i class="fas fa-star ms-1"></i>' +
        '<span class="d-inline-block average-rating"> (' +
        marker.total_review +
        ")</span>" +
        "</div>" +
        '<ul class="available-info">' +
        '<li><i class="fas fa-map-marker-alt"></i> ' +
        marker.address +
        " </li>" +
        '<li><i class="far fa-clock"></i> ' +
        marker.next_available +
        "</li>" +
        '<li><i class="far fa-money-bill-alt"></i> ' +
        marker.amount +
        "</li>" +
        "</ul>" +
        "</div>" +
        "</div>";
      infowindow.setContent(content);
    }

    function setMarkers(map, markers) {
      for (var i = 0; i < markers.length; i++) {
        var item = markers[i];
        var latlng = new google.maps.LatLng(item.lat, item.lng);
        var marker = new google.maps.Marker({
          position: latlng,
          map: map,
          doc_name: item.doc_name,
          address: item.address,
          speciality: item.speciality,
          next_available: item.next_available,
          amount: item.amount,
          profile_link: item.profile_link,
          total_review: item.total_review,
          animation: google.maps.Animation.DROP,
          icon: icons[item.icons],
          image: item.image,
        });
        bounds.extend(marker.position);
        markers[i] = marker;
        google.maps.event.addListener(marker, "click", function () {
          setInfo(this);
          infowindow.open(map, this);
          window.clearTimeout(slider);
        });
      }
      map.fitBounds(bounds);
      google.maps.event.addListener(map, "zoom_changed", function () {
        if (map.zoom > 16) map.slide = false;
      });
    }

    google.maps.event.addDomListener(window, "load", initialize);
  },
};
</script>
