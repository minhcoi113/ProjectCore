<template>
  <div id="pat_medicalrecords" class="tab-pane fade show active">
    <div class="text-end">
      <a
        href="javascript:;"
        class="add-new-btn"
        data-bs-toggle="modal"
        data-bs-target="#add_medical_records_modal"
        >Add Medical Records</a
      >
    </div>
    <div class="card card-table mb-0">
      <div class="card-body">
        <div class="table-responsive">
          <table class="table table-hover table-center mb-0">
            <thead>
              <tr>
                <th>#</th>
                <th>Name</th>
                <th>Date</th>
                <th>Description</th>
                <th>Attachment</th>
                <th>Orderd By</th>
                <th>Action</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="item in medical_records" :key="item.id">
                <td>{{ item.Id }}</td>
                <td>{{ item.Name }}</td>
                <td>
                  {{ item.Date }}<span class="d-block text-info">{{ item.Time }}</span>
                </td>
                <td>{{item.Description}}</td>
                <td>
                  <a
                    href="javascript:void(0);"
                    title="Download attachment"
                    class="btn btn-primary btn-sm"
                  >
                    <i class="fa fa-download"></i
                  ></a>
                </td>
                <td>{{ item.OrderdBy }}</td>
                <td>
                  <a href="javascript:void(0);" class="btn btn-sm bg-danger-light">
                    <i class="far fa-trash-alt"></i>
                  </a>
                </td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import medical_records from "@/assets/json/patients/medical-records.json";
export default {
  data() {
    return {
      medical_records: medical_records,
    };
  },
};
</script>
