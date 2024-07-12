<template>
  <div class="tab-pane fade" id="pat_prescriptions">
    <div class="card card-table mb-0">
      <div class="card-body">
        <div class="table-responsive">
          <table class="table table-hover table-center mb-0">
            <thead>
              <tr>
                <th>Date</th>
                <th>Name</th>
                <th>Created by</th>
                <th>Action</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="item in prescription" :key="item.id">
                <td>{{ item.Date }}</td>
                <td>{{ item.Name }}</td>
                <td>
                  <h2 class="table-avatar">
                    <router-link to="doctor-profile" class="avatar avatar-sm me-2">
                      <img
                        class="avatar-img rounded-circle"
                        :src="require(`@/assets/img/doctors/${item.Image}`)"
                        alt="User Image"
                      />
                    </router-link>
                    <router-link to="doctor-profile"
                      >{{ item.Createdby }}<span>{{ item.specialist }}</span></router-link
                    >
                  </h2>
                </td>
                <td class="text-end">
                  <div class="table-action">
                    <a
                      href="javascript:void(0);"
                      class="btn btn-sm bg-primary-light ms-1"
                    >
                      <i class="fas fa-print"></i> Print
                    </a>
                    <a href="javascript:void(0);" class="btn btn-sm bg-info-light ms-1">
                      <i class="far fa-eye"></i> View
                    </a>
                  </div>
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
import prescription from "@/assets/json/patientdashboard/prescription.json";
export default {
  data() {
    return {
      prescription: prescription,
    };
  },
};
</script>
