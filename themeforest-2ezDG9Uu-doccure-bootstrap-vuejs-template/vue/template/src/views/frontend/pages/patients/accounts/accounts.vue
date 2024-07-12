<template>
  <!-- Main Wrapper -->
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />
    <!-- Page Content -->

    <div class="content">
      <div class="container">
        <div class="row">
          <div class="col-md-5 col-lg-4 col-xl-3 theiaStickySidebar">
            <div class="stickysidebar">
              <profilesidebar></profilesidebar>
            </div>
          </div>

          <div class="col-md-7 col-lg-8 col-xl-9">
            <div class="row">
              <div class="col-lg-5 d-flex">
                <div class="card flex-fill">
                  <div class="card-header">
                    <div class="row">
                      <div class="col-sm-6">
                        <h3 class="card-title">Account</h3>
                      </div>
                      <div class="col-sm-6">
                        <div class="text-end">
                          <a
                            title="Edit Profile"
                            class="btn btn-primary btn-sm"
                            href="#account_modal"
                            data-bs-toggle="modal"
                            ><i class="fas fa-pencil"></i> Edit Details</a
                          >
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="card-body">
                    <div class="profile-view-bottom">
                      <div class="row">
                        <div class="col-lg-6">
                          <div class="info-list">
                            <div class="title">Bank Name</div>
                            <div class="text" id="bank_name">Goldman Sachs</div>
                          </div>
                        </div>
                        <div class="col-lg-6">
                          <div class="info-list">
                            <div class="title">Branch Name</div>
                            <div class="text" id="branch_name">Alpharetta</div>
                          </div>
                        </div>
                        <div class="col-lg-6">
                          <div class="info-list">
                            <div class="title">Account Number</div>
                            <div class="text" id="account_no">4916 0606 4635 5064</div>
                          </div>
                        </div>
                        <div class="col-lg-6">
                          <div class="info-list">
                            <div class="title">Account Name</div>
                            <div class="text" id="account_name">Richard Wilson</div>
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
              <div class="col-lg-7 d-flex">
                <div class="card flex-fill">
                  <div class="card-body">
                    <div class="row">
                      <div class="col-lg-6" v-for="item in paymentrequest" :key="item.id">
                        <div :class="item.class">
                          <span>{{ item.amount }}</span> {{ item.type }}
                        </div>
                      </div>

                      <div class="col-md-12 text-center">
                        <a
                          href="#payment_request_modal"
                          class="btn btn-primary request_btn"
                          data-bs-toggle="modal"
                          >Refund Request</a
                        >
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>

            <div class="row">
              <div class="col-sm-12">
                <div class="card">
                  <div class="card-body pt-0">
                    <!-- Tab Menu -->
                    <nav class="user-tabs mb-4">
                      <ul class="nav nav-tabs nav-tabs-bottom nav-justified">
                        <li class="nav-item">
                          <a
                            class="nav-link active"
                            href="#pat_accounts"
                            data-bs-toggle="tab"
                            >Accounts</a
                          >
                        </li>
                        <li class="nav-item">
                          <a
                            class="nav-link"
                            href="#pat_refundrequest"
                            data-bs-toggle="tab"
                            >Doctor Request</a
                          >
                        </li>
                      </ul>
                    </nav>
                    <!-- /Tab Menu -->

                    <!-- Tab Content -->
                    <div class="tab-content pt-0">
                      <!-- Accounts Tab -->
                      <patientsaccounts1></patientsaccounts1>
                      <!-- /Accounts Tab -->
                      <patientsaccounts2></patientsaccounts2>
                    </div>
                    <!-- Tab Content -->
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <!-- /Page Content -->
    <indexfooter></indexfooter>
  </div>
  <!-- /Main Wrapper -->
  <patientsaccounts3></patientsaccounts3>
</template>
<script>
import paymentrequest from "@/assets/json/patient-account/paymentrequest.json";
export default {
  data() {
    return {
      title: "Accounts",
      text: "Home",
      text1: "Accounts",
      paymentrequest: paymentrequest,
    };
  },
};
</script>
