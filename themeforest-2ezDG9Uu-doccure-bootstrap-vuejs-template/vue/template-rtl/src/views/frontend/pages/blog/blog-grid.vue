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
              <div class="row blog-grid-row">
                <div class="col-md-6 col-sm-12" v-for="item in BlogGrid" :key="item.id">
                  <!-- Blog Post -->
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
                                :src="require(`@/assets/img/doctors/${item.Doctor}`)"
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
                      <p class="mb-0">{{ item.Content }}</p>
                    </div>
                  </div>
                  <!-- /Blog Post -->
                </div>
              </div>

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
    <indexfooter></indexfooter>
  </div>
</template>

<script>
import BlogGrid from "@/assets/json/blog-grid.json";
export default {
  data() {
    return {
      title: "Blog Grid",
      text: "Home",
      text1: "Blog Grid",
      BlogGrid: BlogGrid,
    };
  },
};
</script>
