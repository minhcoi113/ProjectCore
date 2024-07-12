<template>
  <div
    class="modal fade"
    id="deleteConfirmModal"
    tabindex="-1"
    role="dialog"
    aria-hidden="true"
    v-if="isHomeRoute"
  >
    <div class="modal-dialog modal-dialog-centered">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title" id="acc_title">Delete</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <p id="acc_msg">are you sure you want to delete?</p>
        </div>
        <div class="modal-footer">
          <a href="javascript:;" class="btn btn-success si_accept_confirm">Yes</a>
          <b-button
            type="button"
            class="btn btn-danger si_accept_cancel"
            data-bs-dismiss="modal"
          >
            Cancel
          </b-button>
        </div>
      </div>
    </div>
  </div>
  <div
    class="modal fade"
    id="delete_modal"
    aria-hidden="true"
    role="dialog"
    v-else-if="isHometwoRoute"
  >
    <div class="modal-dialog modal-dialog-centered" role="document">
      <div class="modal-content">
        <div class="modal-body">
          <div class="form-content p-2">
            <h4 class="modal-title">Delete</h4>
            <p class="mb-4">Are you sure want to delete?</p>
            <b-button type="button" class="btn btn-primary me-2">Save</b-button>
            <b-button type="button" class="btn btn-danger" data-bs-dismiss="modal">
              Close
            </b-button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  computed: {
    isHomeRoute() {
      return (
        this.$route.path === "/pharmacy/products" ||
        this.$route.path === "/pharmacy/outstock" ||
        this.$route.path === "/pharmacy/expired" ||
        this.$route.path === "/pharmacy/purchase" ||
        this.$route.path === "/pharmacy/order" ||
        this.$route.path === "/pharmacy/sales" ||
        this.$route.path === "/pharmacy/supplier"
      );
    },
    isHometwoRoute() {
      return (
        this.$route.path === "/pharmacy/categories" ||
        this.$route.path === "/pharmacy/transactions-list" ||
        this.$route.path === "/pharmacy/invoice-report"
      );
    },
  },
};
</script>
