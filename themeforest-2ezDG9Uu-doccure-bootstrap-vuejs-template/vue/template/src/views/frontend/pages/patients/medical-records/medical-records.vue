<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

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
              <div class="col-sm-12">
                <div class="card">
                  <div class="card-body pt-0">
                    <!-- Tab Menu -->
                    <nav class="user-tabs mb-4">
                      <ul class="nav nav-tabs nav-tabs-bottom nav-justified">
                        <li class="nav-item">
                          <a
                            class="nav-link active"
                            href="#pat_medicalrecords"
                            data-bs-toggle="tab"
                            >Medical Records</a
                          >
                        </li>
                        <li class="nav-item">
                          <a
                            class="nav-link"
                            href="#pat_prescription"
                            data-bs-toggle="tab"
                            >Prescription</a
                          >
                        </li>
                      </ul>
                    </nav>
                    <!-- /Tab Menu -->
                    <!-- Tab Content -->
                    <div class="tab-content pt-0">
                      <!-- Medical Records Tab -->
                      <medical-records-table></medical-records-table>
                      <!-- /Medical Records Tab -->
                      <!-- Prescription Tab -->
                      <medicalprescription></medicalprescription>
                      <!-- /Prescription Tab -->
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
    <indexfooter></indexfooter>
  </div>
  <medical-records-model></medical-records-model>
</template>
<script>
export default {
  data() {
    return {
      title: "Medical Records",
      text: "Home",
      text1: "Medical Records",
    };
  },
  name: "medical-details",
};
</script>
