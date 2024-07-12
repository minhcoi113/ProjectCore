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
                            >Medicine Name<span class="text-danger">*</span></label
                          >
                          <input
                            type="hidden"
                            name="brand_name"
                            id="brand_name"
                            value="18"
                          />
                          <form
                            input
                            class="form-control"
                            type="text"
                            name="brand_name"
                            id="brand_name"
                            value=""
                            required=""
                          />
                        </div>
                      </div>
                      <div class="col-lg-6">
                        <div class="form-group">
                          <label class="mb-2"
                            >Category <span class="text-danger">*</span></label
                          >
                          <vue-select :options="sorting" placeholder="Injuries">
                          </vue-select>
                        </div>
                      </div>
                    </div>
                  </div>

                  <div class="service-fields mb-3">
                    <div class="row">
                      <div class="col-lg-6">
                        <div class="form-group">
                          <label class="mb-2"
                            >Price<span class="text-danger">*</span></label
                          >
                          <input type="hidden" name="Price" id="Price" value="18" />
                          <form
                            input
                            class="form-control"
                            type="text"
                            name="Price"
                            id="Price"
                            value="$"
                            required=""
                          />
                        </div>
                      </div>
                      <div class="col-lg-6">
                        <div class="form-group">
                          <label class="mb-2"
                            >Quantity<span class="text-danger">*</span></label
                          >
                          <input type="hidden" name="quantity" id="quantity" value="18" />
                          <form
                            input
                            class="form-control"
                            type="text"
                            name="quantity"
                            id="quantity"
                            value=""
                            required=""
                          />
                        </div>
                      </div>
                    </div>
                  </div>

                  <div class="service-fields mb-3">
                    <div class="row">
                      <div class="col-lg-6">
                        <div class="form-group">
                          <label class="mb-2"
                            >Expire Date<span class="text-danger">*</span></label
                          >
                          <datepicker
                            v-model="startdate"
                            class="form-control datetimepicker"
                            :editable="true"
                            :clearable="false"
                          />
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
import { ref } from "vue";
const currentDate = ref(new Date());
export default {
  data() {
    return {
      title: "Edit Purchase",
      text: "Dashboard",
      text1: "Edit Purchase",
      startdate: currentDate,
      sorting: [
        "Injuries",
        "Phytopathology",
        "Cancer",
        "Animal diseases",
        "Growth disorders",
        "Rare diseases",
        "Neoplasms",
        "Inflammations",
        "Sleep disorders",
        "Infectious diseases",
      ],
    };
  },
  name: "pharmacy/edit-purchase",
};
</script>
