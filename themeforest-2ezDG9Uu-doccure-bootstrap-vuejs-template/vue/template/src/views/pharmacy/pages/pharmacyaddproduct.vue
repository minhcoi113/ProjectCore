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
                  action="medicine"
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
                          <label class="mb-2">Product Name<span class="text-danger">*</span></label>
                          <input
                            type="hidden"
                            name="brand_name"
                            id="brand_name"
                            value="18"
                          />
                          <input
                            class="form-control"
                            type="text"
                            name="brand_name2"
                            id="brand_name2"
                            value="18"
                            required=""
                          />
                        </div>
                      </div>
                      <div class="col-lg-6">
                        <div class="form-group">
                          <label class="mb-2">Category <span class="text-danger">*</span></label>
                          <vue-select :options="sorting" placeholder="Family Care">
                          </vue-select>
                        </div>
                      </div>
                    </div>
                  </div>

                  <div class="service-fields mb-3">
                    <div class="row">
                      <div class="col-lg-6">
                        <div class="form-group">
                          <label class="mb-2">Price<span class="text-danger">*</span></label>
                          <input type="hidden" name="Price" id="Price" value="18" />
                          <input
                            class="form-control"
                            type="text"
                            name="Price"
                            id="Price"
                            placeholder="$"
                            required=""
                          />
                        </div>
                      </div>
                      <div class="col-lg-6">
                        <div class="form-group">
                          <label class="mb-2">Quantity<span class="text-danger">*</span></label>
                          <input
                            type="hidden"
                            name="quantity"
                            id="quantity"
                            value="18"
                            placeholder="18"
                          />
                          <input
                            class="form-control"
                            type="text"
                            name="quantity"
                            id="quantity"
                            value=""
                            required="required"
                          />
                        </div>
                      </div>
                    </div>
                  </div>

                  <div class="service-fields mb-3">
                    <div class="row">
                      <div class="col-lg-6">
                        <div class="form-group">
                          <label class="mb-2">Discount<span class="text-danger">*</span></label>
                          <input type="hidden" name="discount" id="discount" value="18" />
                          <input
                            class="form-control"
                            type="text"
                            name="discount"
                            id="discount"
                            value=""
                            required="required"
                          />
                        </div>
                      </div>
                    </div>
                  </div>

                  <div class="service-fields mb-3">
                    <div class="row">
                      <div class="col-lg-12">
                        <div class="form-group">
                          <label class="mb-2">Descriptions <span class="text-danger">*</span></label>
                          <textarea
                            id="about"
                            class="form-control service-desc"
                            name="about"
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
                          <span>Upload Product Images *</span>
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
                    >
                      Submit
                    </b-button>
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
  <!-- Main Wrapper -->
</template>
<script>
export default {
  data() {
    return {
      title: "Add Product",
      text: "Dashboard",
      text1: "Add Product",
      sorting: [
        "Family Care",
        "Phytopathology",
        "Cancer",
        "Fitness & Wellness",
        "Hair care",
        "Skin care",
        "Neoplasms",
        "Women's Care",
        "Sleep disorders",
        "Baby care",
      ],
    };
  },
  name: "pharmacy/add-product",
};
</script>
