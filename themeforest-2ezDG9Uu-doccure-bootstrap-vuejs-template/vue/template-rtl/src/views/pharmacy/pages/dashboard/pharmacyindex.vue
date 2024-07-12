<template>
  <div class="main-wrapper">
    <pharmacyheader></pharmacyheader>
    <pharmacysidebar></pharmacysidebar>

    <div class="page-wrapper">
      <div class="content container-fluid">
        <!-- Page Header -->
        <pharmacybreadcrumb1 :title="title" :text="text" />
        <!-- /Page Header -->

        <div class="row">
          <div class="col-xl-3 col-sm-6 col-12">
            <div class="card">
              <div class="card-body">
                <div class="dash-widget-header">
                  <span class="dash-widget-icon text-primary border-primary">
                    <i class="fe fe-money"></i>
                  </span>
                  <div class="dash-count">
                    <h3>$50.00</h3>
                  </div>
                </div>
                <div class="dash-widget-info">
                  <h6 class="text-muted">Sales Today</h6>
                  <div class="progress progress-sm">
                    <div class="progress-bar bg-primary w-50"></div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="col-xl-3 col-sm-6 col-12">
            <div class="card">
              <div class="card-body">
                <div class="dash-widget-header">
                  <span class="dash-widget-icon text-success">
                    <i class="fe fe-credit-card"></i>
                  </span>
                  <div class="dash-count">
                    <h3>$5.22</h3>
                  </div>
                </div>
                <div class="dash-widget-info">
                  <h6 class="text-muted">Expense Today</h6>
                  <div class="progress progress-sm">
                    <div class="progress-bar bg-success w-50"></div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="col-xl-3 col-sm-6 col-12">
            <div class="card">
              <div class="card-body">
                <div class="dash-widget-header">
                  <span class="dash-widget-icon text-danger border-danger">
                    <i class="fe fe-folder"></i>
                  </span>
                  <div class="dash-count">
                    <h3>485</h3>
                  </div>
                </div>
                <div class="dash-widget-info">
                  <h6 class="text-muted">Medicine</h6>
                  <div class="progress progress-sm">
                    <div class="progress-bar bg-danger w-50"></div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="col-xl-3 col-sm-6 col-12">
            <div class="card">
              <div class="card-body">
                <div class="dash-widget-header">
                  <span class="dash-widget-icon text-warning border-warning">
                    <i class="fe fe-users"></i>
                  </span>
                  <div class="dash-count">
                    <h3>50</h3>
                  </div>
                </div>
                <div class="dash-widget-info">
                  <h6 class="text-muted">Staff</h6>
                  <div class="progress progress-sm">
                    <div class="progress-bar bg-warning w-50"></div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-md-12 col-lg-6">
            <!-- Sales Chart -->
            <div class="card card-chart">
              <div class="card-header">
                <h4 class="card-title">Revenue</h4>
              </div>
              <div class="card-body">
                <apexchart
                  type="area"
                  height="350"
                  :options="splineAreaChart.slinearea"
                  :series="splineAreaChart.series"
                ></apexchart>
              </div>
            </div>
            <!-- /Sales Chart -->
          </div>
          <div class="col-md-12 col-lg-6">
            <!-- Invoice Chart -->
            <div class="card card-chart">
              <div class="card-header">
                <h4 class="card-title">Status</h4>
              </div>
              <div class="card-body">
                <apexchart
                  type="line"
                  height="350"
                  :options="splineChart.slineline"
                  :series="splineChart.series"
                ></apexchart>
              </div>
            </div>
            <!-- /Invoice Chart -->
          </div>
        </div>
        <div class="row">
          <div class="col-md-12">
            <!-- Latest Customers -->
            <div class="card card-table">
              <div class="card-header">
                <h4 class="card-title">Latest Customers</h4>
              </div>
              <div class="card-body">
                <div class="table-responsive">
                  <table class="table table-hover table-center mb-0">
                    <thead>
                      <tr>
                        <th>#</th>
                        <th>Name</th>
                        <th>Address</th>
                        <th>Telephone</th>
                        <th>Email</th>
                        <th class="text-end">Date added</th>
                      </tr>
                    </thead>
                    <tbody>
                      <tr v-for="item in PharmacyIndex" :key="item.id">
                        <td>{{ item.num }}</td>
                        <td>
                          <h2 class="table-avatar">{{ item.Name }}</h2>
                        </td>
                        <td>{{ item.Address }}</td>
                        <td>
                          <h2 class="table-avatar">{{ item.Telephone }}</h2>
                        </td>
                        <td>{{ item.Email }}</td>
                        <td class="text-end">{{ item.Dateadded }}</td>
                      </tr>
                    </tbody>
                  </table>
                </div>
              </div>
            </div>
            <!-- /Latest Customers -->
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import { splineAreaChart, splineChart } from "./data";
import PharmacyIndex from "@/assets/pharmacy/json/pharmacyindex.json";
export default {
  data() {
    return {
      title: "Welcome Admin!",
      text: "Dashboard",
      splineChart: splineChart,
      splineAreaChart: splineAreaChart,
      PharmacyIndex: PharmacyIndex,
    };
  },
  name: "pharmacy/index",
};
</script>
