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
                <div class="row">
                  <div class="col-md-12 col-lg-6">
                    <!-- Change Password Form -->
                    <form>
                      <div class="mb-3">
                        <label class="mb-2">Old Password</label>
                        <input type="password" class="form-control" />
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">New Password</label>
                        <input type="password" class="form-control" />
                      </div>
                      <div class="mb-3">
                        <label class="mb-2">Confirm Password</label>
                        <input type="password" class="form-control" />
                      </div>
                      <div class="submit-section">
                        <b-button type="submit" class="btn btn-primary submit-btn">
                          Save Changes
                        </b-button>
                      </div>
                    </form>
                    <!-- /Change Password Form -->
                  </div>
                </div>
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
      title: "Change Password",
      text: "Home",
      text1: "Change Password",
    };
  },
};
</script>
