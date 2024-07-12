<template>
  <!-- Graph Two-->
  <div class="modal fade custom-modal" id="graph3">
    <div class="modal-dialog modal-dialog-centered modal-lg">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">FBC Status</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <div id="fbc-status">
            <apexchart
              type="bar"
              height="350"
              :options="fbcStatus.sline"
              :series="fbcStatus.series"
            >
            </apexchart>
          </div>
        </div>
      </div>
    </div>
  </div>
  <!-- /Graph Two-->
</template>

<script>
import { fbcStatus } from "./data";
export default {
  data() {
    return {
      fbcStatus: fbcStatus,
    };
  },
};
</script>
