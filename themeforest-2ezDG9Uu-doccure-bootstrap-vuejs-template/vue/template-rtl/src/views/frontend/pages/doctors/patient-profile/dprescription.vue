<template>
  <div class="tab-pane fade" id="pres">
    <div class="text-end">
      <router-link to="add-prescription" class="add-new-btn"
        >Add Prescription</router-link
      >
    </div>
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
              <tr v-for="item in dprescription" :key="item.id">
                <td>{{ item.date }}</td>
                <td>{{ item.name }}</td>
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
                      >{{ item.created_by }} <span>{{ item.name1 }}</span></router-link
                    >
                  </h2>
                </td>
                <td class="text-end">
                  <div class="table-action">
                    <a
                      href="javascript:void(0);"
                      class="btn btn-sm bg-primary-light me-2"
                    >
                      <i class="fas fa-print"></i> Print
                    </a>
                    <a href="javascript:void(0);" class="btn btn-sm bg-info-light">
                      <i class="far fa-eye"></i> View
                    </a>
                    <router-link to="edit-prescription" :class="item.class3">
                      <i :class="item.class"></i> {{ item.Edit }}
                    </router-link>
                    <a href="javascript:void(0);" :class="item.class4">
                      <i :class="item.class1"></i> {{ item.Delete }}
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
import dprescription from "@/assets/json/doctor/dprescription.json";

export default {
  data() {
    return {
      dprescription: dprescription,
    };
  },
};
</script>
