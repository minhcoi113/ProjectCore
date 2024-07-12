<template>
  <div id="pat_medical_records" class="tab-pane fade">
    <div class="card card-table mb-0">
      <div class="card-body">
        <div class="table-responsive">
          <table class="table table-hover table-center mb-0">
            <thead>
              <tr>
                <th>ID</th>
                <th>Date</th>
                <th>Description</th>
                <th>Attachment</th>
                <th>Created</th>
                <th>Action</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="item in medicalrecords" :key="item.id">
                <td>
                  <a href="javascript:void(0);">{{ item.ID }}</a>
                </td>
                <td>{{ item.Date }}</td>
                <td>{{ item.Description }}</td>
                <td>
                  <a href="javascript:;">{{ item.Attachment }}</a>
                </td>
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
                      >{{ item.Created }} <span>{{ item.specialist }}</span></router-link
                    >
                  </h2>
                </td>
                <td class="text-end">
                  <div class="table-action">
                    <a href="javascript:void(0);" class="btn btn-sm bg-info-light ms-">
                      <i class="far fa-eye"></i> View
                    </a>
                    <a
                      href="javascript:void(0);"
                      class="btn btn-sm bg-primary-light ms-1"
                    >
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
import medicalrecords from "@/assets/json/patientdashboard/medicalrecords.json";
export default {
  data() {
    return {
      medicalrecords: medicalrecords,
    };
  },
};
</script>
