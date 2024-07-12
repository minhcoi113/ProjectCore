<template>
  <div class="stickysidebar">
    <div class="filter-contents">
      <div class="filter-header">
        <h4 class="filter-title">Filter</h4>
      </div>
      <div class="filter-details">
        <!-- Filter Grid -->
        <div class="filter-grid">
          <h4>
            <router-link to="#collapseone" data-bs-toggle="collapse">Gender</router-link>
          </h4>
          <div id="collapseone" class="collapse show">
            <div class="filter-collapse">
              <ul>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="gender" />
                    <span class="checkmark"></span>
                    Male Gender
                  </label>
                </li>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="gender" />
                    <span class="checkmark"></span>
                    Female Gender
                  </label>
                </li>
              </ul>
            </div>
          </div>
        </div>
        <!-- /Filter Grid -->

        <!-- Filter Grid -->
        <div class="filter-grid">
          <h4>
            <router-link to="#collapsetwo" data-bs-toggle="collapse"
              >Availability</router-link
            >
          </h4>
          <div id="collapsetwo" class="collapse show">
            <div class="filter-collapse">
              <ul>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="availability" />
                    <span class="checkmark"></span>
                    Available Today
                  </label>
                </li>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="availability" />
                    <span class="checkmark"></span>
                    Available Tomorrow
                  </label>
                </li>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="availability" />
                    <span class="checkmark"></span>
                    Available in Next 7 Days
                  </label>
                </li>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="availability" />
                    <span class="checkmark"></span>
                    Available in Next 30 Days
                  </label>
                </li>
              </ul>
            </div>
          </div>
        </div>
        <!-- /Filter Grid -->

        <!-- Filter Grid -->
        <div class="filter-grid">
          <h4>
            <router-link to="#collapsethree" data-bs-toggle="collapse"
              >Consultation Fee</router-link
            >
          </h4>
          <div id="collapsethree" class="collapse show">
            <div class="filter-collapse">
              <div class="filter-content filter-content-slider">
                <p>$10 <span>$10000</span></p>
                <div class="slider-wrapper">
                  <div id="price-range">
                    <Slider v-model="value3" :merge="merge" :format="format" />
                  </div>
                </div>
                <div class="price-wrapper">
                  <h6>
                    Price:
                    <span>
                      $<span id="pricerangemin">10</span> - $<span id="pricerangemax"
                        >10000</span
                      >
                    </span>
                  </h6>
                </div>
              </div>
            </div>
          </div>
        </div>
        <!-- /Filter Grid -->

        <!-- Filter Grid -->
        <div class="filter-grid">
          <h4>
            <router-link to="#collapsefour" data-bs-toggle="collapse"
              >Speciality</router-link
            >
          </h4>
          <div id="collapsefour" class="collapse show">
            <div class="filter-collapse">
              <ul>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="speciality" />
                    <span class="checkmark"></span>
                    Urology
                  </label>
                </li>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="speciality" />
                    <span class="checkmark"></span>
                    Ophthalmology
                  </label>
                </li>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="speciality" />
                    <span class="checkmark"></span>
                    Cardiology
                  </label>
                </li>
              </ul>
            </div>
          </div>
        </div>
        <!-- /Filter Grid -->

        <!-- Filter Grid -->
        <div class="filter-grid">
          <h4>
            <router-link to="#collapsefive" data-bs-toggle="collapse"
              >Experience</router-link
            >
          </h4>
          <div id="collapsefive" class="collapse show">
            <div class="filter-collapse">
              <ul>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="experience" />
                    <span class="checkmark"></span>
                    1-5 Years
                  </label>
                </li>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="experience" />
                    <span class="checkmark"></span>
                    5+ Years
                  </label>
                </li>
              </ul>
            </div>
          </div>
        </div>
        <!-- /Filter Grid -->

        <!-- Filter Grid -->
        <div class="filter-grid">
          <h4>
            <router-link to="#collapsesix" data-bs-toggle="collapse"
              >Online Consultation</router-link
            >
          </h4>
          <div id="collapsesix" class="collapse show">
            <div class="filter-collapse">
              <ul>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="online" />
                    <span class="checkmark"></span>
                    <i class="feather-video online-icon"></i> Video Call
                  </label>
                </li>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="online" />
                    <span class="checkmark"></span>
                    <i class="feather-mic online-icon"></i> Audio Call
                  </label>
                </li>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="online" />
                    <span class="checkmark"></span>
                    <i class="feather-message-square online-icon"></i> Chat
                  </label>
                </li>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="online" />
                    <span class="checkmark"></span>
                    <i class="feather-users online-icon"></i> Instant Consulting
                  </label>
                </li>
              </ul>
            </div>
          </div>
        </div>
        <!-- /Filter Grid -->

        <!-- Filter Grid -->
        <div class="filter-grid">
          <h4>
            <router-link to="#collapseseven" data-bs-toggle="collapse"
              >By Rating</router-link
            >
          </h4>
          <div id="collapseseven" class="collapse show">
            <div class="filter-collapse">
              <ul>
                <li>
                  <div class="custom_check rating_custom_check d-inline-flex">
                    <input type="checkbox" name="online" />
                    <span class="checkmark"></span>
                    <div class="rating">
                      <i class="fas fa-star filled"></i>
                      <i class="fas fa-star filled ms-1"></i>
                      <i class="fas fa-star filled ms-1"></i>
                      <i class="fas fa-star filled ms-1"></i>
                      <i class="fas fa-star filled ms-1"></i>
                      <span class="rating-count">(40)</span>
                    </div>
                  </div>
                </li>
                <li>
                  <div class="custom_check rating_custom_check d-inline-flex">
                    <input type="checkbox" name="online" />
                    <span class="checkmark"></span>
                    <div class="rating">
                      <i class="fas fa-star filled"></i>
                      <i class="fas fa-star filled ms-1"></i>
                      <i class="fas fa-star filled ms-1"></i>
                      <i class="fas fa-star filled ms-1"></i>
                      <i class="fas fa-star ms-1"></i>
                      <span class="rating-count">(35)</span>
                    </div>
                  </div>
                </li>
                <li>
                  <div class="custom_check rating_custom_check d-inline-flex">
                    <input type="checkbox" name="online" />
                    <span class="checkmark"></span>
                    <div class="rating">
                      <i class="fas fa-star filled"></i>
                      <i class="fas fa-star filled ms-1"></i>
                      <i class="fas fa-star filled ms-1"></i>
                      <i class="fas fa-star ms-1"></i>
                      <i class="fas fa-star ms-1"></i>
                      <span class="rating-count">(20)</span>
                    </div>
                  </div>
                </li>
                <li>
                  <div class="custom_check rating_custom_check d-inline-flex">
                    <input type="checkbox" name="online" />
                    <span class="checkmark"></span>
                    <div class="rating">
                      <i class="fas fa-star filled"></i>
                      <i class="fas fa-star filled ms-1"></i>
                      <i class="fas fa-star ms-1"></i>
                      <i class="fas fa-star ms-1"></i>
                      <i class="fas fa-star ms-1"></i>
                      <span class="rating-count">(10)</span>
                    </div>
                  </div>
                </li>
                <li>
                  <div class="custom_check rating_custom_check d-inline-flex">
                    <input type="checkbox" name="online" />
                    <span class="checkmark"></span>
                    <div class="rating">
                      <i class="fas fa-star filled"></i>
                      <i class="fas fa-star ms-1"></i>
                      <i class="fas fa-star ms-1"></i>
                      <i class="fas fa-star ms-1"></i>
                      <i class="fas fa-star ms-1"></i>
                      <span class="rating-count">(05)</span>
                    </div>
                  </div>
                </li>
              </ul>
            </div>
          </div>
        </div>
        <!-- /Filter Grid -->

        <!-- Filter Grid -->
        <div class="filter-grid">
          <h4>
            <router-link to="#collapseeight" data-bs-toggle="collapse"
              >Languages</router-link
            >
          </h4>
          <div id="collapseeight" class="collapse show">
            <div class="filter-collapse">
              <ul>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="language" />
                    <span class="checkmark"></span>
                    English
                  </label>
                </li>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="language" />
                    <span class="checkmark"></span>
                    French
                  </label>
                </li>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="language" />
                    <span class="checkmark"></span>
                    Spanish
                  </label>
                </li>
                <li>
                  <label class="custom_check d-inline-flex">
                    <input type="checkbox" name="language" />
                    <span class="checkmark"></span>
                    German
                  </label>
                </li>
              </ul>
            </div>
          </div>
        </div>
        <!-- /Filter Grid -->

        <!-- Filter Btn -->
        <div class="filter-btn apply-btn">
          <div class="row">
            <div class="col-6">
              <a href="javascript:void(0);" class="btn btn-primary">Apply</a>
            </div>
            <div class="col-6">
              <a href="javascript:void(0);" class="btn btn-outline-primary">Reset</a>
            </div>
          </div>
        </div>
        <!-- /Filter Btn -->
      </div>
    </div>
  </div>
</template>

<script>
import Slider from "@vueform/slider";
export default {
  data() {
    return {
      value3: [0, 50],
      merge: 10,
      format: {
        prefix: "$",
        suffix: "0",
      },
    };
  },
  mounted() {
    document.querySelectorAll(".fav-icon").forEach(function (element) {
      element.addEventListener("click", function () {
        element.classList.toggle("selected");
      });
    });

    if (document.getElementById("more") != null) {
      const button = document.getElementById("more");
      const container = document.getElementById("fill-more");

      let isLess = true;

      function showMoreLess() {
        if (isLess) {
          isLess = false;
          container.style.height = "auto";
          button.innerHTML = "Show less <i class='feather-arrow-up-circle ms-1'>";
        } else {
          isLess = true;
          container.style.height = "180px";
          button.innerHTML = "Show more <i class='feather-arrow-down-circle ms-1'></i>";
        }
      }

      button.addEventListener("click", showMoreLess);
    }
  },
  components: {
    Slider,
  },
};
</script>
<style>
.stickysidebar {
  position: sticky;
  top: 0;
}
.slider-connect {
  background: var(--slider-connect-bg, #0e82fd) !important;
  cursor: pointer;
}
.slider-tooltip {
  background: var(--slider-tooltip-bg, #0b2540) !important;
  border: 1px solid var(--slider-tooltip-bg, #0b2540) !important;
  border-radius: var(--slider-tooltip-radius, 5px);
  color: var(--slider-tooltip-color, #fff);
  display: block;
  font-size: var(--slider-tooltip-font-size, 0.875rem);
  font-weight: var(--slider-tooltip-font-weight, 600);
  line-height: var(--slider-tooltip-line-height, 1.25rem);
  min-width: var(--slider-tooltip-min-width, 20px);
  padding: var(--slider-tooltip-py, 2px) var(--slider-tooltip-px, 6px);
  position: absolute;
  text-align: center;
  white-space: nowrap;
}
.roundskin .slider-tooltip {
  background: var(--slider-tooltip-bg, #0e82fd) !important;
  border: 1px solid var(--slider-tooltip-bg, #0e82fd) !important;
  border-radius: var(--slider-tooltip-radius, 5px);
  color: var(--slider-tooltip-color, #fff);
  display: block;
  font-size: var(--slider-tooltip-font-size, 0.875rem);
  font-weight: var(--slider-tooltip-font-weight, 600);
  line-height: var(--slider-tooltip-line-height, 1.25rem);
  min-width: var(--slider-tooltip-min-width, 20px);
  padding: var(--slider-tooltip-py, 2px) var(--slider-tooltip-px, 6px);
  position: absolute;
  text-align: center;
  white-space: nowrap;
}
.slider-handle {
  background-color: #fff !important;
  border: 2px solid #0e82fd !important;
}
.slider-tooltip.slider-tooltip-top {
  display: none !important;
}
</style>
<style src="@vueform/slider/themes/default.css"></style>
