<template>
  <div class="tab-pane fade" id="medical">
    <div class="text-end">
      <a
        href="javascript:void(0)"
        class="add-new-btn"
        data-bs-toggle="modal"
        data-bs-target="#add_medical_records"
        >Add Medical Records</a
      >
    </div>
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
              <tr v-for="item in dmedicalrecords" :key="item.id">
                <td>
                  <a href="javascript:void(0);">{{ item.id }}</a>
                </td>
                <td>{{ item.date }}</td>
                <td>{{ item.description }}</td>
                <td>
                  <a href="javascript:void(0)">{{ item.attachment }}</a>
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
                      >{{ item.created_by }} <span>{{ item.name }}</span></router-link
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
                    <a href="javascript:void(0);" class="btn btn-sm bg-info-light me-2">
                      <i class="far fa-eye"></i> View
                    </a>
                    <router-link
                      to="edit-prescription"
                      :class="item.class"
                      data-bs-toggle="modal"
                      data-bs-target="#add_medical_records"
                    >
                      <i :class="item.class3"></i>{{ item.edit }}
                    </router-link>

                    <a href="javascript:void(0);" :class="item.class1">
                      <i :class="item.class4"></i> {{ item.delete }}
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
import dmedicalrecords from "@/assets/json/doctor/dmedicalrecords.json";

export default {
  data() {
    return {
      dmedicalrecords: dmedicalrecords,
    };
  },
};
</script>
