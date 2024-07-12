<template>
  <!-- Graph Two-->
  <div class="modal fade custom-modal" id="graph2">
    <div class="modal-dialog modal-dialog-centered modal-lg">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Heart Rate Status</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <div id="heartrate-status">
            <apexchart
              type="line"
              height="350"
              :options="heartRate.sline"
              :series="heartRate.series"
            ></apexchart>
          </div>
        </div>
      </div>
    </div>
  </div>
  <!-- /Graph Two-->
</template>

<script>
import { heartRate } from "./data";
export default {
  data() {
    return {
      heartRate: heartRate,
    };
  },
};
</script>
