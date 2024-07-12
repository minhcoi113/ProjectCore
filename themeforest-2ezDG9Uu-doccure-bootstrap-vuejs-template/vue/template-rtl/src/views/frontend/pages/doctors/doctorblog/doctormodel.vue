<template>
  <div
    class="modal fade"
    id="deleteConfirmModal"
    tabindex="-1"
    role="dialog"
    aria-labelledby="deleteConfirmModal"
    aria-hidden="true"
  >
    <div class="modal-dialog modal-dialog-centered">
      <div class="modal-content">
        <div class="modal-header">
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <p id="acc_msg"></p>
        </div>
        <div class="modal-footer">
          <a href="javascript:void(0)" class="btn btn-success si_accept_confirm">Yes</a>
          <b-button
            type="button"
            class="btn btn-danger si_accept_cancel"
            data-bs-dismiss="modal"
            >Cancel</b-button
          >
        </div>
      </div>
    </div>
  </div>
  <div
    class="modal fade"
    id="deleteNotConfirmModal"
    tabindex="-1"
    role="dialog"
    aria-labelledby="deleteNotConfirmModal"
    style="display: none"
    aria-hidden="true"
  >
    <div class="modal-dialog modal-dialog-centered">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title" id="acc_title">Active Service?</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <p id="acc_msg1">Service is Booked and Inprogress..</p>
        </div>
        <div class="modal-footer">
          <b-button
            type="button"
            class="btn btn-danger si_accept_cancel"
            data-bs-dismiss="modal"
            >OK</b-button
          >
        </div>
      </div>
    </div>
  </div>
  <!-- /Model -->
</template>
