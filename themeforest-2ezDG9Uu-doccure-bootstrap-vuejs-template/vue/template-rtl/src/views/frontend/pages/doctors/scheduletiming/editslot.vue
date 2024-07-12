<template>
  <!-- Edit Time Slot Modal -->
  <div class="modal fade custom-modal" id="edit_time_slot">
    <div class="modal-dialog modal-dialog-centered">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Edit Time Slots</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <form>
            <div class="hours-info">
              <div class="row hours-cont">
                <div class="col-12 col-md-10">
                  <div class="row">
                    <div class="col-12 col-md-6">
                      <div class="mb-3">
                        <label class="mb-2">Start Time</label>
                        <select class="form-select form-control">
                          <option>-</option>
                          <option selected>12.00 am</option>
                          <option>12.30 am</option>
                          <option>1.00 am</option>
                          <option>1.30 am</option>
                        </select>
                      </div>
                    </div>
                    <div class="col-12 col-md-6">
                      <div class="mb-3">
                        <label class="mb-2">End Time</label>
                        <select class="form-select form-control">
                          <option>-</option>
                          <option>12.00 am</option>
                          <option selected>12.30 am</option>
                          <option>1.00 am</option>
                          <option>1.30 am</option>
                        </select>
                      </div>
                    </div>
                  </div>
                </div>
              </div>

              <div class="row hours-cont" v-for="(slot, index) in slot" :key="index">
                <div class="col-12 col-md-10">
                  <div class="row">
                    <div class="col-12 col-md-6">
                      <div class="mb-3">
                        <label class="mb-2">Start Time</label>
                        <select class="form-select form-control">
                          <option>-</option>
                          <option>12.00 am</option>
                          <option>12.30 am</option>
                          <option selected>1.00 am</option>
                          <option>1.30 am</option>
                        </select>
                      </div>
                    </div>
                    <div class="col-12 col-md-6">
                      <div class="mb-3">
                        <label class="mb-2">End Time</label>
                        <select class="form-select form-control">
                          <option>-</option>
                          <option>12.00 am</option>
                          <option>12.30 am</option>
                          <option>1.00 am</option>
                          <option selected>1.30 am</option>
                        </select>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="col-12 col-md-2">
                  <label class="d-md-block d-sm-none d-none">&nbsp;</label
                  ><a
                    href="javascript:void(0);"
                    class="btn btn-danger trash"
                    @click="deleteslot(index)"
                    ><i class="far fa-trash-alt"></i
                  ></a>
                </div>
              </div>
            </div>

            <div class="add-more mb-3">
              <a href="javascript:void(0);" class="add-hours" @click="editslot"
                ><i class="fa fa-plus-circle"></i> Add More</a
              >
            </div>
            <div class="submit-section text-center">
              <b-button type="submit" class="btn btn-primary submit-btn">Save</b-button>
            </div>
          </form>
        </div>
      </div>
    </div>
  </div>
  <!-- /Edit Time Slot Modal -->
</template>

<script>
export default {
  data() {
    return {
      Time: ["-", "12.00 am", "12.30 am", "1.00 am", "1.30 am"],
      slot: [""],
    };
  },
  methods: {
    editslot() {
      this.slot.push({});
    },
    deleteslot(index) {
      this.slot.splice(index, 1);
    },
    deleteeditslot() {
      this.slot.splice(1);
    },
  },
};
</script>
