<template>
  <!-- Blog Section -->
  <section class="section section-blogs">
    <div class="container-fluid">
      <!-- Section Header -->
      <div class="section-header text-center aos" data-aos="fade-up">
        <h2>Blogs and News</h2>
        <p class="sub-title">
          Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
          incididunt ut labore et dolore magna aliqua.
        </p>
      </div>
      <!-- /Section Header -->

      <div class="row blog-grid-row">
        <div
          class="col-md-6 col-lg-3 col-sm-12 aos"
          v-for="item in indexTwoBlog"
          :key="item.id"
          data-aos="fade-up"
        >
          <div class="blog grid-blog">
            <div class="blog-image">
              <router-link to="/blog-details"
                ><img
                  class="img-fluid"
                  :src="require(`@/assets/img/blog/${item.Image}`)"
                  alt="Post Image"
              /></router-link>
            </div>
            <div class="blog-content">
              <ul class="entry-meta meta-item">
                <li>
                  <div class="post-author">
                    <router-link to="/doctor-profile"
                      ><img
                        :src="require(`@/assets/img/doctors/${item.Img}`)"
                        alt="Post Author"
                      />
                      <span>{{ item.Name }}</span></router-link
                    >
                  </div>
                </li>
                <li><i class="far fa-clock me-1"></i>{{ item.Day }}</li>
              </ul>
              <h3 class="blog-title">
                <router-link to="/blog-details">{{ item.Title }}</router-link>
              </h3>
              <p class="mb-0">
                Lorem ipsum dolor sit amet, consectetur em adipiscing elit, sed do eiusmod
                tempor.
              </p>
            </div>
          </div>
        </div>
      </div>
      <div class="view-all text-center aos" data-aos="fade-up">
        <router-link to="/blog-list" class="btn btn-primary">View All</router-link>
      </div>
    </div>
  </section>
  <!-- /Blog Section -->
</template>

<script>
import AOS from "aos";
import "aos/dist/aos.css";
import indexTwoBlog from "@/assets/json/indextwoblog.json";
export default {
  data() {
    return {
      indexTwoBlog: indexTwoBlog,
    };
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
