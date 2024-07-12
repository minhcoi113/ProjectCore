<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="page-wrapper">
      <!-- Page Content -->
      <div class="content">
        <div class="container">
          <div class="row">
            <doctors-sidebar></doctors-sidebar>

            <div class="col-md-7 col-lg-8 col-xl-9">
              <div class="card card-table">
                <div class="card-body">
                  <!-- Invoice Table -->
                  <div class="table-responsive">
                    <table class="table table-hover table-center mb-0">
                      <thead>
                        <tr>
                          <th>Invoice No</th>
                          <th>Patient</th>
                          <th>Amount</th>
                          <th>Paid On</th>
                          <th>Actions</th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr v-for="item in Invoices" :key="item.id">
                          <td>
                            <router-link to="/invoice-view">{{
                              item.InvoiceNo
                            }}</router-link>
                          </td>
                          <td>
                            <h2 class="table-avatar">
                              <router-link
                                to="/patient-profile"
                                class="avatar avatar-sm me-2"
                              >
                                <img
                                  class="avatar-img rounded-circle"
                                  :src="require(`@/assets/img/patients/${item.Image}`)"
                                  alt="User Image"
                                />
                              </router-link>
                              <router-link to="/patient-profile"
                                >{{ item.Name }}
                                <span>{{ item.Number }}</span></router-link
                              >
                            </h2>
                          </td>
                          <td>{{ item.Price }}</td>
                          <td>{{ item.Day }}</td>
                          <td>
                            <div class="table-action">
                              <router-link
                                to="/invoice-view"
                                class="btn btn-sm bg-info-light me-2"
                              >
                                <i class="far fa-eye"></i> View
                              </router-link>
                              <a
                                href="javascript:void(0);"
                                class="btn btn-sm bg-primary-light"
                              >
                                <i class="fas fa-print"></i> Print
                              </a>
                            </div>
                          </td>
                        </tr>
                      </tbody>
                    </table>
                  </div>
                  <!-- /Invoice Table -->
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <!-- /Page Content -->
    </div>
    <indexfooter></indexfooter>
  </div>
</template>

<script>
import Invoices from "@/assets/json/invoice.json";
export default {
  data() {
    return {
      Invoices: Invoices,
      title: "Invoices",
      text: "Home",
      text1: "Invoices",
    };
  },
};
</script>
