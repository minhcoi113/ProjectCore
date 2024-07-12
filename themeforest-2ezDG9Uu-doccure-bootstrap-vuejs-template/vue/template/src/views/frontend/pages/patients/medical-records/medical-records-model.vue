<template>
  <div
    class="modal fade custom-modal custom-medicalrecord-modal"
    id="add_medical_records_modal"
    style="display: none"
    data-select2-id="add_medical_records_modal"
    aria-hidden="true"
  >
    <div class="modal-dialog modal-dialog-centered modal-lg" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Add Medical Records</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          >
          </b-button>
        </div>
        <form id="medical_records_form" enctype="multipart/form-data">
          <div class="modal-body">
            <div class="row">
              <div class="col-12 col-md-6">
                <div class="mb-3">
                  <label class="mb-2">Title Name</label>
                  <input
                    type="text"
                    name="description"
                    class="form-control"
                    placeholder="Enter Title Name"
                  />
                </div>
              </div>
              <div class="col-12 col-md-6">
                <div class="mb-3">
                  <label class="mb-2">Patient</label>
                  <input
                    type="text"
                    name="description"
                    class="form-control"
                    placeholder="Enter Patient Name"
                  />
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-12">
                <div class="mb-3">
                  <label class="mb-2">Hospital Name</label>
                  <input
                    type="text"
                    name="hospital"
                    class="form-control"
                    placeholder="Enter name here.."
                  />
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-12">
                <div class="mb-3">
                  <label class="mb-2">Upload</label>
                  <div class="upload-medical-records">
                    <input
                      class="form-control"
                      type="file"
                      name="user_file"
                      id="user_files_mr"
                    />
                    <div class="upload-content dropzone">
                      <div class="text-center">
                        <div class="upload-icon mb-2">
                          <img src="@/assets/img/upload-icon.png" alt="upload-icon" />
                        </div>
                        <h5>Drag &amp; Drop</h5>
                        <h6>or <span class="text-danger">Browse</span></h6>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-12">
                <div class="mb-3">
                  <label class="mb-2">Symptoms</label>
                  <input
                    type="text"
                    data-role="tagsinput"
                    class="input-tags form-control"
                    value="Fever, Fatigue"
                    name="services"
                    id="services"
                  />
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-12 col-md-6">
                <div class="mb-3">
                  <label class="mb-2">Date</label>
                  <div class="mb-3">
                    <datepicker
                      v-model="startdate"
                      placeholder="Date"
                      class="form-control datetimepicker"
                      :editable="true"
                      :clearable="false"
                    />
                  </div>
                </div>
              </div>
            </div>
            <div class="text-center mt-4">
              <div class="submit-section text-center">
                <b-button
                  type="submit"
                  id="medical_btn"
                  class="btn btn-primary submit-btn"
                  >Submit</b-button
                >
              </div>
            </div>
          </div>
        </form>
      </div>
    </div>
  </div>
</template>
<script>
import { ref } from "vue";
const currentDate = ref(new Date());
export default {
  data() {
    return {
      startdate: currentDate,
    };
  },
};
</script>
