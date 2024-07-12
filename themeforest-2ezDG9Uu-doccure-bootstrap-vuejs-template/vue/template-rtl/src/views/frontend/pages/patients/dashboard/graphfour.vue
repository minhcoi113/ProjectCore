<template>
  <div class="modal fade custom-modal" id="graph4">
    <div class="modal-dialog modal-dialog-centered modal-lg">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Weight Status</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <div id="weight-status">
            <apexchart
              type="line"
              height="350"
              :options="weightStatus.sline"
              :series="weightStatus.series"
            >
            </apexchart>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import { weightStatus } from "./data";

export default {
  data() {
    return {
      weightStatus: weightStatus,
    };
  },
};
</script>
