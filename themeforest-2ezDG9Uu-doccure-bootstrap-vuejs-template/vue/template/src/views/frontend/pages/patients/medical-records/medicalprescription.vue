<template>
  <div class="tab-pane fade" id="pat_prescription">
    <div class="card card-table mb-0">
      <div class="card-body">
        <div class="table-responsive">
          <table class="table table-hover table-center mb-0">
            <thead>
              <tr>
                <th>#</th>
                <th>Date</th>
                <th>Name</th>
                <th>Doctor</th>
                <th>Action</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="item in prescription" :key="item.id">
                <td>{{ item.Id }}</td>
                <td>
                  {{ item.Date }} <span class="d-block text-info">{{ item.Time }}</span>
                </td>
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
                      >{{ item.Doctor }} <span>{{ item.specialist }}</span></router-link
                    >
                  </h2>
                </td>
                <td>
                  <div class="table-action">
                    <a href="javascript:void(0);" class="btn btn-sm bg-info-light ms-1">
                      <i class="far fa-eye"></i> View
                    </a>

                    <a href="javascript:void(0);" class="btn btn-sm bg-success-light ms-1">
                      <i class="fas fa-print"></i> Print
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
import prescription from "@/assets/json/patients/prescription.json";
export default {
  data() {
    return {
      prescription: prescription,
    };
  },
};
</script>
