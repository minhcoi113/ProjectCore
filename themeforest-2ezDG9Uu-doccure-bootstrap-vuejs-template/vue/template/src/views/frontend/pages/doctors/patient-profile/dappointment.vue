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
              <tr v-for="item in dappointment" :key="item.id">
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
                      >{{ item.doctor }} <span>{{ item.doctor1 }}</span></router-link
                    >
                  </h2>
                </td>
                <td>
                  {{ item.appt_date }}
                  <span class="d-block text-info">{{ item.time }}</span>
                </td>
                <td>{{ item.booking_date }}</td>
                <td>{{ item.amount }}</td>
                <td>{{ item.follow_up }}</td>
                <td>
                  <span :class="item.class">{{ item.status }}</span>
                </td>
                <td>
                  <div class="table-action">
                    <router-link to="edit-prescription" :class="item.class2">
                      <i :class="item.class1"></i> {{ item.edit }}
                    </router-link>
                    <a href="javascript:void(0);" :class="item.class3">
                      <i :class="item.class4"></i> {{ item.reschedule }}
                    </a>
                    <a href="javascript:void(0);" :class="item.class5">
                      <i :class="item.class6" class="me-1"></i>{{ item.Cancel }}
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
import dappointment from "@/assets/json/doctor/dappointment.json";

export default {
  data() {
    return {
      dappointment: dappointment,
    };
  },
};
</script>
