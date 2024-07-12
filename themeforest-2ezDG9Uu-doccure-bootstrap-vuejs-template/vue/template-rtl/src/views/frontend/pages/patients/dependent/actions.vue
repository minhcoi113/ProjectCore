<template>
  <!-- Add Dependent Modal-->
  <div
    id="modal_form"
    class="modal fade custom-modal"
    tabindex="-1"
    role="dialog"
    aria-modal="true"
  >
    <div class="modal-dialog modal-dialog-centered">
      <div class="modal-content">
        <form action="javascript:;" enctype="multipart/form-data" autocomplete="off" method="post">
          <div class="modal-header">
            <h5 class="modal-title">Add new member</h5>
            <b-button
              type="button"
              class="btn-close"
              data-bs-dismiss="modal"
              aria-label="Close"
            ></b-button>
          </div>
          <div class="modal-body">
            <div class="mb-3">
              <label class="control-label mb-10">
                Name <span class="text-danger">*</span></label
              >
              <input type="text" name="name" class="form-control" />
            </div>
            <div class="mb-3">
              <label class="control-label mb-10">Relationship </label>
              <input type="text" name="relationship" class="form-control" />
            </div>
            <div class="mb-3">
              <label class="control-label mb-10">Gender </label>
              <vue-select :options="Gender" placeholder="Select" />
            </div>
            <div class="mb-3">
              <label class="control-label mb-10">DOB </label>
              <datepicker
                v-model="startdate"
                placeholder="Date"
                class="form-control datetimepicker"
                :editable="true"
                :clearable="false"
              />
            </div>
            <div class="mb-3">
              <label class="control-label mb-10">Photo </label>
              <input type="file" name="profile_image" class="form-control" />
            </div>
          </div>
          <div class="modal-footer text-center">
            <b-button type="submit" class="btn btn-primary submit-btn">Save</b-button>
          </div>
        </form>
      </div>
    </div>
  </div>
  <!-- /Add Dependent Modal-->

  <!-- Edit Dependent Modal-->
  <div
    id="edit_form"
    class="modal fade custom-modal"
    tabindex="-1"
    role="dialog"
    aria-modal="true"
  >
    <div class="modal-dialog modal-dialog-centered">
      <div class="modal-content">
        <form action="javascript:;" enctype="multipart/form-data" autocomplete="off" method="post">
          <div class="modal-header">
            <h5 class="modal-title">Edit member</h5>
            <b-button
              type="button"
              class="btn-close"
              data-bs-dismiss="modal"
              aria-label="Close"
            ></b-button>
          </div>
          <div class="modal-body">
            <div class="mb-3">
              <label class="control-label mb-10">
                Name <span class="text-danger">*</span></label
              >
              <input type="text" name="name" class="form-control" value="Christopher" />
            </div>
            <div class="mb-3">
              <label class="control-label mb-10">Relationship </label>
              <input type="text" name="relationship" class="form-control" value="son" />
            </div>
            <div class="mb-3">
              <label class="control-label mb-10">Gender </label>
              <vue-select :options="Gender" placeholder="Select" />
            </div>
            <div class="mb-3">
              <label class="control-label mb-10">DOB </label>
              <datepicker
                v-model="startdate"
                placeholder="Date"
                class="form-control datetimepicker"
                :editable="true"
                :clearable="false"
              />
            </div>
            <div class="mb-3">
              <label class="control-label mb-10">Photo </label>
              <input type="file" name="profile_image" class="form-control" />
            </div>
          </div>
          <div class="modal-footer text-center">
            <b-button type="submit" class="btn btn-primary submit-btn">Save</b-button>
          </div>
        </form>
      </div>
    </div>
  </div>
  <!-- /Edit Dependent Modal-->
</template>

<script>
import { ref } from "vue";
const currentDate = ref(new Date());
export default {
  data() {
    return {
      Gender: ["Select", "Male", "Female"],
      startdate: currentDate,
    };
  },
};
</script>
