<template>
  <section class="our-best-work-sec">
    <div class="container">
      <div class="section-head-fourteen">
        <h2>See Our Best Work</h2>
        <p>More the quantity, higher the discount. Hurry, Buy Now!</p>
      </div>
      <div class="treatment-video-main">
        <div class="row">
          <div class="col-lg-12">
            <div class="best-work-video">
              <div class="slider work-video-img">
                <Carousel
                  :wrap-around="true"
                  :settings="settings"
                  :breakpoints="breakpoints"
                >
                  <Slide v-for="record in WorkSection" :key="record.id">
                    <div class="treatment-video">
                      <div class="video-img">
                        <img
                          :src="require(`@/assets/img/slider/${record.Image}`)"
                          alt="Slider"
                        />
                        <div class="video-player">
                          <a @click="toggleVideo" :class="{ active: isActive }"
                            >Toggle Video</a
                          >
                          <video
                            ref="currentVideo"
                            class="doctor-treatment-video"
                            @click="toggleVideo"
                            :class="{ active: isActive }"
                          >
                            <source :src="record.VideoSource" type="video/mp4" />
                          </video>
                        </div>
                      </div>
                      <div class="treatment-video"></div>
                      <a href="javascript:void(0);">
                        <span class="play-btn-video"><i class="feather-play"></i></span>
                        <span class="pause-btn-video"><i class="feather-pause"></i></span>
                      </a>
                    </div>
                  </Slide>
                  <template #addons>
                    <Navigation />
                  </template>
                </Carousel>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>
<script>
import { Carousel, Pagination, Navigation, Slide } from "vue3-carousel";
import WorkSection from "@/assets/json/work-section.json";
import "vue3-carousel/dist/carousel.css";
export default {
  data() {
    return {
      WorkSection: WorkSection,
      isActive: true,
      settings: {
        itemsToShow: 1,
        snapAlign: "center",
        loop: true,
      },

      breakpoints: {
        575: {
          itemsToShow: 1,
          snapAlign: "center",
        },
        // 700px and up
        767: {
          itemsToShow: 1,
          snapAlign: "start",
        },
        // 991px and up
        991: {
          itemsToShow: 1,
          snapAlign: "start",
        },
        // 1024 and up
        1024: {
          itemsToShow: 1,
          snapAlign: "start",
        },
      },
    };
  },
  components: {
    Carousel,
    Slide,
    Pagination,
    Navigation,
  },

  methods: {
    toggleVideo() {
      const currentVideo = this.$refs.currentVideo;

      if (currentVideo) {
        const allVideos = document.querySelectorAll(".doctor-treatment-video");

        allVideos.forEach((video) => {
          if (currentVideo !== video) {
            video.pause();
          }
        });

        currentVideo.classList.toggle("active");
        this.isActive = !this.isActive;

        if (currentVideo.paused) {
          currentVideo.play();
        } else {
          currentVideo.pause();
        }
      } else {
        console.error("Could not find the video element.");
      }
    },
  },
};
</script>
