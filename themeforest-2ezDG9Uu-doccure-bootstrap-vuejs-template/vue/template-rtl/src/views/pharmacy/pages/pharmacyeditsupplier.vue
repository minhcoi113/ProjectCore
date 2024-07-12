<template>
  <!-- Main Wrapper -->
  <div class="main-wrapper">
    <pharmacyheader></pharmacyheader>
    <pharmacysidebar></pharmacysidebar>
    <!-- Page Wrapper -->
    <div class="page-wrapper">
      <div class="content container-fluid">
        <pharmacybreadcrumb1 :title="title" :text="text" :text1="text1" />
        <div class="row">
          <div class="col-sm-12">
            <div class="card">
              <div class="card-body custom-edit-service">
                <!-- Add Medicine -->
                <form
                  method="post"
                  enctype="multipart/form-data"
                  autocomplete="off"
                  id="update_service"
                  action="purchase"
                >
                  <input
                    type="hidden"
                    name="csrf_token_name"
                    value="0146f123a4c7ae94253b39bca6bd5a5e"
                  />

                  <div class="service-fields mb-3">
                    <div class="row">
                      <div class="col-lg-6">
                        <div class="form-group">
                          <label class="mb-2"
                            >Name<span class="text-danger">*</span></label
                          >
                          <input type="hidden" name="name" id="name" value="18" />
                          <form
                            input
                            class="form-control"
                            type="text"
                            name="name"
                            id="name"
                            value=""
                            required=""
                          />
                        </div>
                      </div>
                      <div class="col-lg-6">
                        <label class="mb-2"
                          >Email<span class="text-danger">*</span></label
                        >
                        <input type="hidden" name="email" id="email" value="18" />
                        <form
                          input
                          class="form-control"
                          type="text"
                          name="email"
                          id="email"
                          value=""
                          required=""
                        />
                      </div>
                    </div>
                  </div>

                  <div class="service-fields mb-3">
                    <div class="row">
                      <div class="col-lg-6">
                        <div class="form-group">
                          <label class="mb-2"
                            >Phone<span class="text-danger">*</span></label
                          >
                          <input type="hidden" name="phone" id="phone" value="18" />
                          <form
                            input
                            class="form-control"
                            type="text"
                            name="phone"
                            id="phone"
                            value=""
                            required=""
                          />
                        </div>
                      </div>
                      <div class="col-lg-6">
                        <label class="mb-2"
                          >Company<span class="text-danger">*</span></label
                        >
                        <input type="hidden" name="company" id="company" value="18" />
                        <form
                          input
                          class="form-control"
                          type="text"
                          name="company"
                          id="company"
                          value=""
                          required=""
                        />
                      </div>
                    </div>
                  </div>

                  <div class="service-fields mb-3">
                    <div class="row">
                      <div class="col-lg-12">
                        <div class="form-group">
                          <label class="mb-2"
                            >Address <span class="text-danger">*</span></label
                          >
                          <textarea
                            id="address"
                            class="form-control service-desc"
                            name="address"
                          ></textarea>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="service-fields mb-3">
                    <div class="row">
                      <div class="col-lg-12">
                        <div class="service-upload">
                          <i class="fas fa-cloud-upload-alt"></i>
                          <span>Upload Supplier Image *</span>
                          <input
                            type="file"
                            name="images[]"
                            id="images"
                            multiple=""
                            accept="image/jpeg, image/png, image/gif,"
                          />
                        </div>
                        <div id="uploadPreview">
                          <ul class="upload-wrap">
                            <li>
                              <div class="upload-images">
                                <img
                                  alt="Blog Image"
                                  src="@/assets/pharmacy/img/product/product1.jpg"
                                />
                              </div>
                            </li>
                          </ul>
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
                      >Submit</b-button
                    >
                  </div>
                </form>
                <!-- /Add Medicine -->
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- /Page Wrapper -->
  </div>
  <!-- /Main Wrapper -->
</template>
<script>
export default {
  data() {
    return {
      title: "Edit Supplier",
      text: "Dashboard",
      text1: "Edit Supplier",
    };
  },
  name: "pharmacy/edit-supplier",
};
</script>
