<template>
  <!-- Add Item -->
  <div class="add-more-item text-end">
    <a href="javascript:void(0)" @click="addItem"
      ><i class="fa fa-plus-circle"></i> Add More</a
    >
  </div>
  <!-- /Add Item -->
  <!-- Prescription Item -->
  <div class="card card-table">
    <div class="card-body">
      <div class="table-responsive">
        <table class="table table-hover table-center">
          <thead>
            <tr>
              <th class="table-head-name">Name</th>
              <th>Quantity</th>
              <th class="table-head-days">Days</th>
              <th>Time</th>
              <th class="custom-class"></th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="(item, index) in medicines" :key="index">
              <td>
                <input class="form-control" v-model="item.medicine" type="text" />
              </td>
              <td>
                <input class="form-control" v-model="item.quantity" type="text" />
              </td>
              <td>
                <input class="form-control" v-model="item.duration" type="text" />
              </td>
              <td>
                <div
                  class="form-check form-check-inline"
                  v-for="dosage in item.dosages"
                  :key="dosage"
                >
                  <label class="form-check-label">
                    <input
                      class="form-check-input"
                      type="checkbox"
                      :checked="item.checked"
                    />
                    {{ dosage }}
                  </label>
                </div>
              </td>

              <td>
                <a
                  href="javascript:void(0)"
                  class="btn bg-danger-light trash"
                  @click="removeItem(index)"
                  ><i class="far fa-trash-alt"></i
                ></a>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  </div>
  <!-- /Prescription Item -->

  <!-- Signature -->
  <div class="row">
    <div class="col-md-12 text-end">
      <div class="signature-wrap">
        <div class="signature">Click here to sign</div>
        <div class="sign-name">
          <p class="mb-0">( Dr. Darren Elder )</p>
          <span class="text-muted">Signature</span>
        </div>
      </div>
    </div>
  </div>
  <!-- /Signature -->
</template>
<script>
export default {
  data() {
    return {
      medicines: [
        {
          medicine: "Amoxapine",
          quantity: "2",
          duration: "2 Days",
          dosages: ["Morning", "Afternoon", "Evening", "Night"],
          checked: true,
        },
        {
          medicine: "Benazepril",
          quantity: "2",
          duration: "1 Days",
          dosages: ["Morning", "Afternoon", "Evening", "Night"],
          checked: true,
        },
      ],
    };
  },
  methods: {
    addItem() {
      this.medicines.push({
        medicine: "",
        quantity: "",
        duration: "",
        dosages: ["Morning", "Afternoon", "Evening", "Night"],
        checked: false,
      });
    },
    removeItem(index) {
      this.medicines.splice(index, 1);
    },
  },
};
</script>
