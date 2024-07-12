<template>
  <!-- Main Wrapper -->
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb1 :title="title" :text="text" :text1="text1" />
    <!-- Page Content -->
    <div class="content">
      <div class="container">
        <div class="row">
          <doctorsidebar></doctorsidebar>
          <div class="col-md-7 col-lg-8 col-xl-9">
            <div class="doc-review review-listing">
              <div class="row mb-5">
                <div class="col">
                  <ul class="nav nav-tabs nav-tabs-solid">
                    <li class="nav-item">
                      <router-link class="nav-link active" to="doctor-blog"
                        >Acitive Blog</router-link
                      >
                    </li>
                    <li class="nav-item">
                      <router-link class="nav-link" to="doctor-pending-blog"
                        >Pending Blog</router-link
                      >
                    </li>
                  </ul>
                </div>
                <div class="col-auto">
                  <router-link class="btn btn-primary btn-sm" to="doctor-add-blog"
                    ><i class="fas fa-plus me-1"></i> Add Blog</router-link
                  >
                </div>
              </div>

              <!-- Blog -->
              <div class="row blog-grid-row">
                <div
                  class="col-md-6 col-xl-4 col-sm-12"
                  v-for="item in doctorblog"
                  :key="item.id"
                >
                  <!-- Blog Post -->
                  <div class="blog grid-blog">
                    <div class="blog-image">
                      <router-link to="blog-details"
                        ><img
                          class="img-fluid"
                          :src="require(`@/assets/img/blog/${item.imageUrl}`)"
                          alt="Post Image"
                      /></router-link>
                    </div>
                    <div class="blog-content">
                      <ul class="entry-meta meta-item">
                        <li>
                          <div class="post-author">
                            <router-link to="doctor-profile"
                              ><img
                                :src="require(`@/assets/img/doctors/${item.authorImage}`)"
                                alt="Post Author"
                              />
                              <span>{{ item.authorName }}</span></router-link
                            >
                          </div>
                        </li>
                        <li><i class="far fa-clock"></i> {{ item.postDate }}</li>
                      </ul>
                      <h3 class="blog-title">
                        <router-link to="blog-details"> {{ item.title }}</router-link>
                      </h3>
                      <p class="mb-0">{{ item.content }}</p>
                    </div>
                    <div class="row pt-3">
                      <div class="col">
                        <router-link to="edit-blog" class="text-success"
                          ><i class="far fa-edit"></i> Edit</router-link
                        >
                      </div>

                      <div class="col text-end">
                        <a
                          href="javascript:void(0);"
                          class="text-danger"
                          data-bs-toggle="modal"
                          data-bs-target="#deleteNotConfirmModal"
                          ><i class="far fa-trash-alt"></i> Inactive</a
                        >
                      </div>
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
                          <a class="page-link" href="javascript:void(0)" tabindex="-1"
                            ><i class="fas fa-angle-double-left"></i
                          ></a>
                        </li>
                        <li class="page-item">
                          <a class="page-link" href="javascript:void(0)">1</a>
                        </li>
                        <li class="page-item active">
                          <a class="page-link" href="javascript:void(0)"
                            >2 <span class="visually-hidden">(current)</span></a
                          >
                        </li>
                        <li class="page-item">
                          <a class="page-link" href="javascript:void(0)">3</a>
                        </li>
                        <li class="page-item">
                          <a class="page-link" href="javascript:void(0)"
                            ><i class="fas fa-angle-double-right"></i
                          ></a>
                        </li>
                      </ul>
                    </nav>
                  </div>
                </div>
              </div>
              <!-- /Blog Pagination -->
              <!-- /Blog -->
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- /Page Content -->
    <indexfooter></indexfooter>
  </div>
  <!-- /Main Wrapper -->
  <doctormodel></doctormodel>
</template>

<script>
import doctorblog from "@/assets/json/doctor/doctorblog.json";

export default {
  data() {
    return {
      title: "Doctor Blog",
      text: "Home",
      text1: "Doctor Blog",
      doctorblog: doctorblog,
    };
  },
};
</script>
