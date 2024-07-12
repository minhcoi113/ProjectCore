<template>
  <!-- Main Wrapper -->
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb1 :title="title" :text="text" :text1="text1" />

    <div class="page-wrapper">
      <!-- Page Content -->
      <div class="content">
        <div class="container">
          <div class="row">
            <doctorsidebar></doctorsidebar>
            <div class="col-md-7 col-lg-8 col-xl-9">
              <div class="doc-review review-listing custom-edit-service">
                <div class="row mb-5">
                  <div class="col">
                    <ul class="nav nav-tabs nav-tabs-solid">
                      <li class="nav-item">
                        <router-link class="nav-link" to="doctor-blog"
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

                <!-- Edit Blog -->

                <!-- Edit Blog -->
                <div class="card">
                  <div class="card-body">
                    <h3 class="pb-3">Edit Blog</h3>

                    <form
                      method="post"
                      enctype="multipart/form-data"
                      autocomplete="off"
                      id="update_service"
                      action="doctor-blog"
                    >
                      <input
                        type="hidden"
                        name="csrf_token_name"
                        value="0146f123a4c7ae94253b39bca6bd5a5e"
                      />

                      <div class="service-fields mb-3">
                        <div class="row">
                          <div class="col-lg-12">
                            <div class="mb-3">
                              <label class="mb-2">Blog Title <span class="text-danger">*</span></label>
                              <input
                                type="hidden"
                                name="service_id"
                                id="service_id"
                                value="18"
                              />
                              <input
                                class="form-control"
                                type="text"
                                name="service_title"
                                id="service_title"
                                value="Doccure - Making your clinic painless visit?"
                                required=""
                              />
                            </div>
                          </div>
                        </div>
                      </div>

                      <div class="service-fields mb-3">
                        <div class="row">
                          <div class="col-lg-6">
                            <div class="mb-3">
                              <label class="mb-2">Category <span class="text-danger">*</span></label>

                              <vue-select :options="sorting" placeholder="Construction">
                              </vue-select>
                            </div>
                          </div>
                          <div class="col-lg-6">
                            <div class="mb-3">
                              <label
                                >Sub Category <span class="text-danger">*</span></label
                              >

                              <vue-select
                                :options="sorting1"
                                placeholder="House cleaning"
                              >
                              </vue-select>
                            </div>
                          </div>
                        </div>
                      </div>

                      <div class="service-fields mb-3">
                        <div class="row">
                          <div class="col-lg-12">
                            <div class="mb-3">
                              <label
                                >Descriptions <span class="text-danger">*</span></label
                              >
                              <textarea
                                id="about"
                                class="form-control service-desc"
                                name="about"
                              >
note.</textarea
                              >
                            </div>
                          </div>
                        </div>
                      </div>

                      <div class="service-fields mb-3">
                        <div class="row">
                          <div class="col-lg-12">
                            <div class="service-upload">
                              <i class="fas fa-cloud-upload-alt"></i>
                              <span>Upload Blog Images *</span>
                              <input
                                type="file"
                                name="images[]"
                                id="images"
                                multipl=""
                                accept="image/jpeg, image/png, image/gif"
                              />
                            </div>
                            <div id="uploadPreview">
                              <ul class="upload-wrap">
                                <li>
                                  <div class="upload-images">
                                    <img alt="Blog Image" src="@/assets/img/img-01.jpg" />
                                  </div>
                                </li>
                                <li>
                                  <div class="upload-images">
                                    <img alt="Blog Image" src="@/assets/img/img-02.jpg" />
                                  </div>
                                </li>
                                <li>
                                  <div class="upload-images">
                                    <img alt="Blog Image" src="@/assets/img/img-03.jpg" />
                                  </div>
                                </li>
                              </ul>
                            </div>
                          </div>
                        </div>
                      </div>
                      <div class="service-fields mb-3">
                        <div class="row">
                          <div class="col-lg-12">
                            <div class="mb-3">
                              <label class="mb-2">Video id <span class="text-danger">*</span></label>
                              <input
                                type="hidden"
                                name="video_id"
                                id="video_id"
                                value="18"
                              />
                              <input
                                class="form-control"
                                type="text"
                                name="video_id1"
                                id="video_id1"
                                value="Rf34rhkWW1"
                              />
                            </div>
                          </div>
                        </div>
                      </div>
                      <div class="submit-section">
                        <b-button
                          class="btn btn-primary submit-btn"
                          type="submit"
                          name="form_submit"
                          value="submit"
                        >
                          Submit
                        </b-button>
                      </div>
                      <doctor-blog></doctor-blog>
                    </form>
                  </div>
                </div>
                <!-- /Edit Blog -->

                <!-- /Edit Blog -->
              </div>
            </div>
          </div>
        </div>
      </div>
      <!-- /Page Content -->
    </div>
    <indexfooter></indexfooter>
  </div>
  <!-- /Main Wrapper -->
</template>
<script>
export default {
  data() {
    return {
      title: "Edit Blog",
      text: "Home",
      text1: "Edit Blog",
      sorting: [
        "Automobile",
        "Construction",
        "Interior",
        "Cleaning",
        "Electrical",
        "Carpentry",
        "Painting",
        "Car Wash",
        "Category",
        "dfdf",
        "Equipment",
        "Test category1",
        "Farming",
        "Test Category02",
        "Laundry",
      ],
      sorting1: [
        "Others",
        "Others",
        "Others",
        "House cleaning",
        "Others",
        "Others",
        "Others",
        "Others",
        "Full Car Wash",
        "Testing category",
        "Test Sub category",
        "Harvesting pine",
        "Test Sub category name",
        "Test Sub category name",
      ],
    };
  },
};
</script>
