<template>
  <div id="pat_appointments" class="tab-pane fade show active">
    <div class="card card-table mb-0">
      <div class="card-body">
        <div class="table-responsive">
          <table class="table table-hover table-center mb-0">
            <thead>
              <tr>
                <th>Doctor</th>
                <th>Appt Date</th>
                <th>Booking Date</th>
                <th>Amount</th>
                <th>Follow Up</th>
                <th>Status</th>
                <th>Action</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="item in patientappointment" :key="item.id">
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
                      >{{ item.Doctor }}<span>{{ item.specialist }}</span></router-link
                    >
                  </h2>
                </td>
                <td>
                  {{ item.ApptDate }}
                  <span class="d-block text-info">{{ item.Time }}</span>
                </td>
                <td>{{ item.BookingDate }}</td>
                <td>{{ item.Amount }}</td>
                <td>{{ item.FollowUp }}</td>
                <td>
                  <span :class="item.class">{{ item.Status }}</span>
                </td>
                <td class="text-end">
                  <div class="table-action">
                    <a
                      href="javascript:void(0);"
                      class="btn btn-sm bg-primary-light ms-3"
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
import patientappointment from "@/assets/json/patientdashboard/patientappointment.json";
export default {
  data() {
    return {
      patientappointment: patientappointment,
    };
  },
};
</script>
