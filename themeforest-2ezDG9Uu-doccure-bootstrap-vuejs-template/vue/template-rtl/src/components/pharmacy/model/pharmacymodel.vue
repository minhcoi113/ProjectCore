<template>
  <!-- Add Modal -->
  <div class="modal fade" id="Add_Specialities_details" aria-hidden="true" role="dialog">
    <div class="modal-dialog modal-dialog-centered" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Add Category</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <form>
            <div class="row">
              <div class="col-12">
                <div class="mb-3">
                  <label class="mb-2">Category</label>
                  <input type="text" class="form-control" />
                </div>
              </div>
            </div>
            <b-button type="submit" class="btn btn-primary w-100">Save</b-button>
          </form>
        </div>
      </div>
    </div>
  </div>
  <!-- /ADD Modal -->

  <!-- Edit Details Modal -->
  <div
    class="modal fade"
    id="edit_invoice_report"
    aria-hidden="true"
    role="dialog"
    v-if="isHomeRoute"
  >
    <div class="modal-dialog modal-dialog-centered" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Edit Invoice Report</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <form>
            <div class="row form-row">
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Invoice Number</label>
                  <input type="text" class="form-control" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Medicine Image</label>
                  <input type="file" class="form-control" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Medicine Name</label>
                  <input type="text" class="form-control" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Total Amount</label>
                  <input type="text" class="form-control" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Status <span class="text-danger">*</span></label>
                  <select class="form-select form-control" name="category" required="">
                    <option value="" selected="selected">Paid</option>
                    <option value="2">Unpaid</option>
                    <option value="3">Pending</option>
                  </select>
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Created Date</label>
                  <input type="text" class="form-control" />
                </div>
              </div>
            </div>
            <b-button type="submit" class="btn btn-primary w-100">Save Changes</b-button>
          </form>
        </div>
      </div>
    </div>
  </div>

  <div
    class="modal fade"
    id="edit_personal_details"
    aria-hidden="true"
    role="dialog"
    v-else-if="isHome2Route"
  >
    <div class="modal-dialog modal-dialog-centered" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Personal Details</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <form>
            <div class="row form-row">
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">First Name</label>
                  <input type="text" class="form-control" value="John" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Last Name</label>
                  <input type="text" class="form-control" value="Doe" />
                </div>
              </div>
              <div class="col-12">
                <div class="form-group">
                  <label class="mb-2">Date of Birth</label>
                  <div class="cal-icon">
                    <datepicker
                      v-model="startdate"
                      placeholder="Choose Date"
                      class="form-control datetimepicker"
                      :editable="true"
                      :clearable="false"
                    />
                  </div>
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Email ID</label>
                  <input type="email" class="form-control" value="johndoe@example.com" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Mobile</label>
                  <input type="text" value="+1 202-555-0125" class="form-control" />
                </div>
              </div>
              <div class="col-12">
                <h5 class="form-title"><span>Address</span></h5>
              </div>
              <div class="col-12">
                <div class="form-group">
                  <label class="mb-2">Address</label>
                  <input type="text" class="form-control" value="4663 Agriculture Lane" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">City</label>
                  <input type="text" class="form-control" value="Miami" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">State</label>
                  <input type="text" class="form-control" value="Florida" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Zip Code</label>
                  <input type="text" class="form-control" value="22434" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Country</label>
                  <input type="text" class="form-control" value="United States" />
                </div>
              </div>
            </div>
            <b-button type="submit" class="btn btn-primary w-100">Save Changes</b-button>
          </form>
        </div>
      </div>
    </div>
  </div>
  <!-- Edit Details Modal -->
  <div
    class="modal fade"
    id="edit_invoice_report"
    aria-hidden="true"
    role="dialog"
    v-else-if="isHome3Route"
  >
    <div class="modal-dialog modal-dialog-centered" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Edit Invoice Report</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <form>
            <div class="row form-row">
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Invoice Number</label>
                  <input type="text" class="form-control" value="20169998" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Medicine Name</label>
                  <input type="text" class="form-control" value="Abilify" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Total Amount</label>
                  <input type="text" class="form-control" value="$150.00" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Created Date</label>
                  <input type="text" class="form-control" value="14-5-2023" />
                </div>
              </div>
            </div>
            <b-button type="submit" class="btn btn-primary w-100">Save Changes</b-button>
          </form>
        </div>
      </div>
    </div>
  </div>
  <!-- /Edit Details Modal -->
  <div
    class="modal fade"
    id="edit_specialities_details"
    aria-hidden="true"
    role="dialog"
    v-else
  >
    <div class="modal-dialog modal-dialog-centered" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Edit Category</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <form>
            <div class="row">
              <div class="col-12">
                <div class="mb-3">
                  <label class="mb-2">Category</label>
                  <input type="text" class="form-control" value="Cardiology" />
                </div>
              </div>
            </div>
            <b-button type="submit" class="btn btn-primary w-100">Save</b-button>
          </form>
        </div>
      </div>
    </div>
  </div>
  <!-- /Edit Details Modal -->
</template>
<script>
import { ref } from "vue";
const currentDate = ref(new Date());
export default {
  computed: {
    isHomeRoute() {
      return this.$route.path === "/pharmacy/invoice-report";
    },
    isHome2Route() {
      return this.$route.path === "/pharmacy/profile";
    },
    isHome3Route() {
      return this.$route.path === "/pharmacy/sales";
    },
  },
  data() {
    return {
      startdate: currentDate,
    };
  },
};
</script>
