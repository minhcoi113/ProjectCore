<template>
  <!-- Graph One-->
  <div class="modal fade custom-modal" id="graph1">
    <div class="modal-dialog modal-dialog-centered modal-lg">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">BMI Status</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <div id="bmi-status">
            <apexchart
              type="line"
              height="350"
              :options="lineChart.sline"
              :series="lineChart.series"
            >
            </apexchart>
          </div>
        </div>
      </div>
    </div>
  </div>
  <!-- /Graph One-->
</template>

<script>
import { lineChart } from "./data";
export default {
  data() {
    return {
      lineChart: lineChart,
    };
  },
};
</script>
