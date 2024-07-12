<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="content">
      <div class="container">
        <div class="row">
          <!-- Profile Sidebar -->
          <div class="col-md-5 col-lg-4 col-xl-3 theiaStickySidebar">
            <div class="stickysidebar">
              <profilesidebar></profilesidebar>
            </div>
          </div>
          <!-- / Profile Sidebar -->
          <div class="col-md-7 col-lg-8 col-xl-9">
            <div class="row">
              <div class="col-sm-12">
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title float-start">Medical details</h4>
                    <router-link
                      to="#modal_medical_form"
                      class="btn btn-primary float-end"
                      data-bs-toggle="modal"
                      >Add Details</router-link
                    >
                  </div>
                  <div class="card-body">
                    <div class="card card-table mb-0">
                      <div class="card-body">
                        <div class="table-responsive">
                          <table class="table table-hover table-center mb-0">
                            <thead>
                              <tr>
                                <th>#</th>
                                <th>Name</th>
                                <th>BMI</th>
                                <th class="text-center">Heart Rate</th>
                                <th class="text-center">FBC Status</th>
                                <th>Weight</th>
                                <th>Order date</th>
                                <th>Action</th>
                              </tr>
                            </thead>
                            <tbody>
                              <tr v-for="item in medical_details" :key="item.id">
                                <td>{{ item.Id }}</td>
                                <td>{{ item.Name }}</td>
                                <td>{{ item.BMI }}</td>
                                <td class="text-center">{{ item.HeartRate }}</td>
                                <td class="text-center">{{ item.FBCStatus }}</td>
                                <td>{{ item.Weight }}</td>
                                <td>
                                  {{ item.Orderdate }}
                                  <span class="d-block text-info">{{ item.Time }}</span>
                                </td>
                                <td>
                                  <div class="table-action">
                                    <router-link
                                      to="#edit_medical_form"
                                      class="btn btn-sm bg-info-light me-1"
                                      data-bs-toggle="modal"
                                    >
                                      <i class="fas fa-edit"></i> Edit
                                    </router-link>
                                    <a
                                      href="javascript:void(0);"
                                      class="btn btn-sm bg-danger-light"
                                    >
                                      <i class="fas fa-trash-alt"></i> Delete
                                    </a>
                                  </div>
                                </td>
                              </tr>
                            </tbody>
                          </table>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <indexfooter></indexfooter>
  </div>
  <div
    id="modal_medical_form"
    class="modal fade custom-modal"
    tabindex="-1"
    role="dialog"
    style="display: none"
    aria-hidden="true"
  >
    <div class="modal-dialog modal-dialog-centered">
      <div class="modal-content">
        <form
          action="javascript:;"
          enctype="multipart/form-data"
          autocomplete="off"
          method="post"
        >
          <div class="modal-header">
            <h5 class="modal-title">Add new data</h5>
            <b-button
              type="button"
              class="btn-close"
              data-bs-dismiss="modal"
              aria-label="Close"
            >
            </b-button>
          </div>
          <div class="modal-body">
            <input type="hidden" value="" name="id" />
            <input type="hidden" value="insert" name="method" />
            <div class="mb-3">
              <label class="control-label mb-10">
                BMI <span class="text-danger">*</span></label
              >
              <input type="text" name="bmi" class="form-control" />
            </div>
            <div class="mb-3">
              <label class="control-label mb-10">Heart rate </label>
              <input type="text" name="hr" class="form-control" />
            </div>
            <div class="mb-3">
              <label class="control-label mb-10">Weight</label>
              <input type="text" name="Weight" class="form-control" />
            </div>
            <div class="mb-3">
              <label class="control-label mb-10">Fbc</label>
              <input type="text" id="Fbc" name="Fbc" class="form-control" />
            </div>
            <div class="mb-3">
              <label class="control-label mb-10">Created Date </label>
              <input
                type="text"
                name="dob"
                id="dob"
                value=""
                readonly=""
                class="form-control"
              />
            </div>
          </div>
          <div class="modal-footer text-center">
            <b-button type="submit" variant="btn btn-outline btn-success "
              >Submit</b-button
            >
          </div>
        </form>
      </div>
    </div>
  </div>
  <div
    id="edit_medical_form"
    class="modal fade custom-modal"
    tabindex="-1"
    role="dialog"
    style="display: none"
    aria-hidden="true"
  >
    <div class="modal-dialog modal-dialog-centered">
      <div class="modal-content">
        <form
          action="javascript:;"
          enctype="multipart/form-data"
          autocomplete="off"
          method="post"
        >
          <div class="modal-header">
            <h5 class="modal-title">Add new data</h5>
            <b-button
              type="button"
              class="btn-close"
              data-bs-dismiss="modal"
              aria-label="Close"
            >
            </b-button>
          </div>
          <div class="modal-body">
            <input type="hidden" value="" name="id" />
            <input type="hidden" value="insert" name="method" />
            <div class="mb-3">
              <label class="control-label mb-10">
                BMI <span class="text-danger">*</span></label
              >
              <input type="text" name="bmi" class="form-control" value="23.7" />
            </div>
            <div class="mb-3">
              <label class="control-label mb-10">Heart rate </label>
              <input type="text" name="hr" class="form-control" value="89" />
            </div>
            <div class="mb-3">
              <label class="control-label mb-10">Weight</label>
              <input type="text" name="Weight" class="form-control" value="74" />
            </div>
            <div class="mb-3">
              <label class="control-label mb-10">Fbc</label>
              <input type="text" name="Fbc" class="form-control" value="140" />
            </div>
            <div class="mb-3">
              <label class="control-label mb-10">Created Date </label>
              <input
                type="text"
                name="dob"
                id="editdob"
                value="11/11/2023"
                readonly=""
                class="form-control"
              />
            </div>
          </div>
          <div class="modal-footer text-center">
            <b-button type="submit" variant="btn btn-outline btn-success "
              >Submit</b-button
            >
          </div>
        </form>
      </div>
    </div>
  </div>
</template>
<script>
import medical_details from "@/assets/json/patients/medical-details.json";
export default {
  data() {
    return {
      title: "Medical Details",
      text: "Home",
      text1: "Medical Details",
      medical_details: medical_details,
    };
  },
  name: "Medical Details",
};
</script>
