<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="page-wrapper">
      <!-- Page Content -->
      <div class="content">
        <div class="container">
          <div class="row">
            <div class="col-lg-8 col-md-12">
              <!-- Blog Post -->
              <div class="blog" v-for="item in BlogList" :key="item.id">
                <div class="blog-image">
                  <router-link to="/blog-details"
                    ><img
                      class="img-fluid"
                      :src="require(`@/assets/img/blog/${item.Image}`)"
                      alt="Post Image"
                  /></router-link>
                </div>
                <h3 class="blog-title">
                  <router-link to="/blog-details">{{ item.Title }}</router-link>
                </h3>
                <div class="blog-info clearfix">
                  <div class="post-left">
                    <ul>
                      <li>
                        <div class="post-author">
                          <router-link to="/doctor-profile"
                            ><img
                              :src="require(`@/assets/img/doctors/${item.Doctor}`)"
                              alt="Post Author"
                            />
                            <span>{{ item.Name }}</span></router-link
                          >
                        </div>
                      </li>
                      <li><i class="far fa-clock"></i>{{ item.Day }}</li>
                      <li><i class="far fa-comments"></i>{{ item.Comments }}</li>
                      <li><i class="fa fa-tags"></i>{{ item.Tips }}</li>
                    </ul>
                  </div>
                </div>
                <div class="blog-content">
                  <p>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do
                    eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad
                    minim veniam, quis nostrud exercitation ullamco sit laboris ullamco
                    laborisut aliquip ex ea commodo consequat. Ut enim ad minim veniam,
                    quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea
                    commodo consequat.
                  </p>
                  <router-link to="/blog-details" class="read-more"
                    >View Blog</router-link
                  >
                </div>
              </div>
              <!-- /Blog Post -->

              <!-- Blog Post -->
              <div class="blog" v-for="item in BlogListVideo" :key="item.id">
                <div class="blog-image">
                  <div class="video">
                    <iframe :src="item.Link" width="940" allowfullscreen></iframe>
                  </div>
                </div>
                <h3 class="blog-title">
                  <router-link to="/blog-details">{{ item.Title }}</router-link>
                </h3>
                <div class="blog-info clearfix">
                  <div class="post-left">
                    <ul>
                      <li>
                        <div class="post-author">
                          <router-link to="/doctor-profile"
                            ><img
                              :src="require(`@/assets/img/doctors/${item.Doctors}`)"
                              alt="Post Author"
                            />
                            <span>{{ item.Name }}</span></router-link
                          >
                        </div>
                      </li>
                      <li><i class="far fa-clock"></i>{{ item.Day }}</li>
                      <li><i class="far fa-comments"></i>{{ item.Comments }}</li>
                      <li><i class="fa fa-tags"></i>{{ item.Tips }}</li>
                    </ul>
                  </div>
                </div>
                <div class="blog-content">
                  <p>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do
                    eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad
                    minim veniam, quis nostrud exercitation ullamco sit laboris ullamco
                    laborisut aliquip ex ea commodo consequat. Ut enim ad minim veniam,
                    quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea
                    commodo consequat.
                  </p>
                  <router-link to="blog-details" class="read-more">View Blog</router-link>
                </div>
              </div>
              <!-- /Blog Post -->

              <!-- Blog Pagination -->
              <div class="row">
                <div class="col-md-12">
                  <div class="blog-pagination">
                    <nav>
                      <ul class="pagination justify-content-center">
                        <li class="page-item disabled">
                          <a class="page-link" href="javascript:;" tabindex="-1"
                            ><i class="fas fa-angle-double-left"></i
                          ></a>
                        </li>
                        <li class="page-item">
                          <a class="page-link" href="javascript:;">1</a>
                        </li>
                        <li class="page-item active">
                          <a class="page-link" href="javascript:;"
                            >2 <span class="visually-hidden">(current)</span></a
                          >
                        </li>
                        <li class="page-item">
                          <a class="page-link" href="javascript:;">3</a>
                        </li>
                        <li class="page-item">
                          <a class="page-link" href="javascript:;"
                            ><i class="fas fa-angle-double-right"></i
                          ></a>
                        </li>
                      </ul>
                    </nav>
                  </div>
                </div>
              </div>
              <!-- /Blog Pagination -->
            </div>

            <!-- Blog Sidebar -->
            <blogsidebar></blogsidebar>
            <!-- /Blog Sidebar -->
          </div>
        </div>
      </div>
      <!-- /Page Content -->
    </div>
  </div>
  <indexfooter></indexfooter>
</template>

<script>
import BlogList from "@/assets/json/bloglist.json";
import BlogListVideo from "@/assets/json/bloglistvideo.json";
export default {
  data() {
    return {
      BlogList: BlogList,
      BlogListVideo: BlogListVideo,
      title: "Blog List",
      text: "Home",
      text1: "Blog List",
    };
  },
};
</script>
