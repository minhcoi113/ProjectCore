<template>
  <!-- Main Wrapper -->
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb1 :title="title" :text="text" :text1="text1" />

    <!-- Page Content -->
    <div class="content">
      <div class="container">
        <div class="row">
          <div class="col-md-5 col-lg-4 col-xl-3 theiaStickySidebar">
            <div class="stickysidebar">
              <profilewidget />
            </div>
          </div>
          <div class="col-md-7 col-lg-8 col-xl-9">
            <div class="card">
              <div class="card-header">
                <h4 class="card-title mb-0">Edit Prescription</h4>
              </div>
              <div class="card-body">
                <div class="row">
                  <div class="col-sm-6">
                    <div class="biller-info">
                      <h4 class="d-block">Dr. Darren Elder</h4>
                      <span class="d-block text-sm text-muted">Dentist</span>
                      <span class="d-block text-sm text-muted"
                        >Newyork, United States</span
                      >
                    </div>
                  </div>
                  <div class="col-sm-6 text-sm-end">
                    <div class="billing-info">
                      <h4 class="d-block">1 November 2023</h4>
                      <span class="d-block text-muted">#INV0001</span>
                    </div>
                  </div>
                </div>

                <edit-prescription1></edit-prescription1>
                <!-- Submit Section -->
                <div class="row">
                  <div class="col-md-12">
                    <div class="submit-section">
                      <b-button type="submit" class="btn btn-primary submit-btn">
                        Save
                      </b-button>
                      <b-button type="reset" class="btn btn-secondary submit-btn">
                        Clear
                      </b-button>
                    </div>
                  </div>
                </div>
                <!-- /Submit Section -->
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- /Page Content -->
    <indexfooter />
  </div>
  <!-- /Main Wrapper -->
</template>
<script>
export default {
  data() {
    return {
      title: "Edit Prescription",
      text: "Home",
      text1: "Edit Prescription",
    };
  },
};
</script>
