<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="content">
      <div class="container">
        <div class="row">
          <!-- Profile Sidebar -->
          <div class="col-md-5 col-lg-4 col-xl-3 theiaStickySidebar">
            <div class="stickysidebar">
              <profilesidebar></profilesidebar>
            </div>
          </div>
          <!-- / Profile Sidebar -->

          <div class="col-md-7 col-lg-8 col-xl-9">
            <div class="row">
              <div class="col-sm-12">
                <div class="card">
                  <div class="card-body">
                    <div class="card card-table mb-0">
                      <div class="card-body">
                        <div class="table-responsive">
                          <table class="table table-hover table-center mb-0">
                            <thead>
                              <tr>
                                <th>#</th>
                                <th>Order Id</th>
                                <th>Pharmacy Name</th>
                                <th class="text-center">Quantity</th>
                                <th class="text-center">Amount</th>
                                <th>Payment Gateway</th>
                                <th>Status</th>
                                <th>Order date</th>
                              </tr>
                            </thead>
                            <tbody>
                              <tr
                                class="col-md-6 col-lg-4 col-xl-3"
                                v-for="item in order"
                                :key="item.id"
                              >
                                <td>{{ item.Id }}</td>
                                <td>
                                  <router-link to="invoice-view">{{
                                    item.OrderId
                                  }}</router-link>
                                </td>
                                <td>{{ item.PharmacyName }}</td>
                                <td class="text-center">{{ item.Quantity }}</td>
                                <td class="text-center">{{ item.Amount }}</td>
                                <td>Stripe</td>
                                <td>
                                  <span :class="item.class">{{ item.Status }}</span>
                                </td>
                                <td>
                                  {{ item.Orderdate }}
                                  <span class="d-block text-info">{{ item.Time }}</span>
                                </td>
                              </tr>
                            </tbody>
                          </table>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <indexfooter></indexfooter>
  </div>
</template>
<script>
import order from "@/assets/json/patients/order.json";
export default {
  data() {
    return {
      title: "Orders",
      text: "Home",
      text1: "Orders",
      order: order,
    };
  },
  name: "orders-list",
};
</script>
