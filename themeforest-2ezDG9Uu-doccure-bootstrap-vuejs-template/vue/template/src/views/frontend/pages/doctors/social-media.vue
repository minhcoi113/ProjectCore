<template>
  <!-- Main Wrapper -->
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb1 :title="title" :text="text" :text1="text1" />

    <!-- Page Content -->
    <div class="content">
      <div class="container">
        <div class="row">
          <doctorsidebar></doctorsidebar>

          <div class="col-md-7 col-lg-8 col-xl-9">
            <div class="card">
              <div class="card-body">
                <!-- Social Form -->
                <form>
                  <div class="row">
                    <div class="col-md-12 col-lg-8">
                      <div class="mb-3">
                        <label class="mb-2">Facebook URL</label>
                        <input type="text" class="form-control" />
                      </div>
                    </div>
                  </div>
                  <div class="row">
                    <div class="col-md-12 col-lg-8">
                      <div class="mb-3">
                        <label class="mb-2">Twitter URL</label>
                        <input type="text" class="form-control" />
                      </div>
                    </div>
                  </div>
                  <div class="row">
                    <div class="col-md-12 col-lg-8">
                      <div class="mb-3">
                        <label class="mb-2">Instagram URL</label>
                        <input type="text" class="form-control" />
                      </div>
                    </div>
                  </div>
                  <div class="row">
                    <div class="col-md-12 col-lg-8">
                      <div class="mb-3">
                        <label class="mb-2">Pinterest URL</label>
                        <input type="text" class="form-control" />
                      </div>
                    </div>
                  </div>
                  <div class="row">
                    <div class="col-md-12 col-lg-8">
                      <div class="mb-3">
                        <label class="mb-2">Linkedin URL</label>
                        <input type="text" class="form-control" />
                      </div>
                    </div>
                  </div>
                  <div class="row">
                    <div class="col-md-12 col-lg-8">
                      <div class="mb-3">
                        <label class="mb-2">Youtube URL</label>
                        <input type="text" class="form-control" />
                      </div>
                    </div>
                  </div>
                  <div class="submit-section">
                    <b-button type="submit" class="btn btn-primary submit-btn">
                      Save Changes
                    </b-button>
                  </div>
                </form>
                <!-- /Social Form -->
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
      title: "Social Media",
      text: "Home",
      text1: "Social Media",
    };
  },
};
</script>
