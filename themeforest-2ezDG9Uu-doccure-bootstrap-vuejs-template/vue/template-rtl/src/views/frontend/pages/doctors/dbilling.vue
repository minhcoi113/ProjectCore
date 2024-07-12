<template>
  <div class="tab-pane" id="billing">
    <div class="text-end">
      <router-link class="add-new-btn" to="add-billing">Add Billing</router-link>
    </div>
    <div class="card card-table mb-0">
      <div class="card-body">
        <div class="table-responsive">
          <table class="table table-hover table-center mb-0">
            <thead>
              <tr>
                <th>Invoice No</th>
                <th>Doctor</th>
                <th>Amount</th>
                <th>Paid On</th>
                <th>Action</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="item in dbilling" :key="item.id">
                <td>
                  <router-link to="invoice-view">{{ item.invoice_no }}</router-link>
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
                      >{{ item.doctor }} <span>{{ item.name }}</span></router-link
                    >
                  </h2>
                </td>
                <td>{{ item.amount }}</td>
                <td>{{ item.paid_on }}</td>
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
import dbilling from "@/assets/json/doctor/dbilling.json";

export default {
  data() {
    return {
      dbilling: dbilling,
    };
  },
};
</script>
