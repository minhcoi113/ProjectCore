<template>
  <!-- Payment Request Moodal -->

  <div
    class="modal fade custom-modal"
    id="payment_request_modal"
    role="dialog"
    style="display: none"
    aria-hidden="true"
  >
    <div class="modal-dialog modal-dialog-centered" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h3 class="modal-title">Payment Request</h3>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <form id="payment_request_form" method="post">
            <input type="hidden" name="payment_type" id="payment_type" value="1" />
            <div class="mb-3">
              <label class="mb-2">Request Amount</label>
              <input
                type="text"
                name="request_amount"
                id="request_amount"
                class="form-control"
                maxlength="6"
                oninput="this.value = this.value.replace(/[^0-9.]/g, '').replace(/(\..*)\./g, '$1');"
              />
              <span class="help-block"></span>
            </div>
            <div class="mb-3">
              <label class="mb-2">Description (Optional)</label>
              <textarea
                class="form-control"
                name="description"
                id="description"
              ></textarea>
              <span class="help-block"></span>
            </div>
          </form>
        </div>
        <div class="modal-footer text-center">
          <b-button type="submit" id="request_btn" class="btn btn-primary">Request</b-button>
        </div>
      </div>
    </div>
  </div>

  <!-- /Payment Request Moodal -->

  <!-- Account Details Modal-->
  <div
    class="modal fade custom-modal"
    id="account_modal"
    role="dialog"
    aria-hidden="true"
  >
    <div class="modal-dialog modal-dialog-centered" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h3 class="modal-title">Account Details</h3>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <form id="accounts_form" method="post">
            <div class="row">
              <div class="col-md-12">
                <div class="mb-3">
                  <label class="control-label">Bank Name</label>
                  <input
                    type="text"
                    name="bank_name"
                    class="form-control bank_name"
                    value="Wells Fargo & Co"
                  />
                  <span class="help-block"></span>
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-md-12">
                <div class="mb-3">
                  <label class="control-label">Branch Name</label>
                  <input
                    type="text"
                    name="branch_name"
                    class="form-control branch_name"
                    value="Lenexa"
                  />
                  <span class="help-block"></span>
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-md-12">
                <div class="mb-3">
                  <label class="control-label">Account Number</label>
                  <input
                    type="text"
                    name="account_no"
                    class="form-control account_no"
                    value="5396 5250 1908 3838"
                  />
                  <span class="help-block"></span>
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-md-12">
                <div class="mb-3">
                  <label class="control-label">Account Name</label>
                  <input
                    type="text"
                    name="account_name"
                    class="form-control acc_name"
                    value="Dr. Darren Elder"
                  />
                  <span class="help-block"></span>
                </div>
              </div>
            </div>
          </form>
        </div>
        <div class="modal-footer text-center">
          <b-button type="submit" id="acc_btn" class="btn btn-primary">Save</b-button>
        </div>
      </div>
    </div>
  </div>
  <!-- /Account Details Modal-->
</template>
