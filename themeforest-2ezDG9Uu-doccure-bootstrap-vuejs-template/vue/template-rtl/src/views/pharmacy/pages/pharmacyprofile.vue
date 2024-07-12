<template>
  <div class="main-wrapper">
    <pharmacyheader></pharmacyheader>
    <pharmacysidebar></pharmacysidebar>
    <!-- Page Wrapper -->
    <div class="page-wrapper">
      <div class="content container-fluid">
        <pharmacybreadcrumb1 :title="title" :text="text" :text1="text1" />
        <div class="row">
          <div class="col-md-12">
            <div class="profile-header">
              <div class="row align-items-center">
                <div class="col-auto profile-image">
                  <a href="javascript:;">
                    <img
                      class="rounded-circle"
                      alt="User Image"
                      src="@/assets/pharmacy/img/profiles/avatar-01.jpg"
                    />
                  </a>
                </div>
                <div class="col ml-md-n2 profile-user-info">
                  <h4 class="user-name mb-0">Ryan Taylor</h4>
                  <h6 class="text-muted">ryantaylor@admin.com</h6>
                  <div class="user-Location">
                    <i class="fa fa-map-marker"></i> Florida, United States
                  </div>
                  <div class="about-text">
                    Lorem ipnpm isum dolor sit amet, consectetur adipiscing elit, sed do
                    eiusmod tempor incididunt ut labore et dolore magna aliqua.
                  </div>
                </div>
                <div class="col-auto profile-btn">
                  <a href="javascript:;" class="btn btn-primary"> Edit </a>
                </div>
              </div>
            </div>
            <div class="profile-menu">
              <ul class="nav nav-tabs nav-tabs-solid">
                <li class="nav-item">
                  <a class="nav-link active" data-bs-toggle="tab" href="#per_details_tab"
                    >About</a
                  >
                </li>
                <li class="nav-item">
                  <a class="nav-link" data-bs-toggle="tab" href="#password_tab"
                    >Password</a
                  >
                </li>
              </ul>
            </div>
            <div class="tab-content profile-tab-cont">
              <!-- Personal Details Tab -->
              <div class="tab-pane fade show active" id="per_details_tab">
                <!-- Personal Details -->
                <div class="row">
                  <div class="col-lg-12">
                    <div class="card">
                      <div class="card-body">
                        <h5 class="card-title d-flex justify-content-between">
                          <span>Personal Details</span>
                          <router-link
                            class="edit-link"
                            data-bs-toggle="modal"
                            to="#edit_personal_details"
                            ><i class="fa fa-edit me-1"></i>Edit</router-link
                          >
                        </h5>
                        <div class="row">
                          <p class="col-sm-2 text-muted text-sm-end mb-0 mb-sm-3">Name</p>
                          <p class="col-sm-10">John Doe</p>
                        </div>
                        <div class="row">
                          <p class="col-sm-2 text-muted text-sm-end mb-0 mb-sm-3">
                            Date of Birth
                          </p>
                          <p class="col-sm-10">24 Jul 1983</p>
                        </div>
                        <div class="row">
                          <p class="col-sm-2 text-muted text-sm-end mb-0 mb-sm-3">
                            Email ID
                          </p>
                          <p class="col-sm-10">johndoe@example.com</p>
                        </div>
                        <div class="row">
                          <p class="col-sm-2 text-muted text-sm-end mb-0 mb-sm-3">
                            Mobile
                          </p>
                          <p class="col-sm-10">305-310-5857</p>
                        </div>
                        <div class="row">
                          <p class="col-sm-2 text-muted text-sm-end mb-0">Address</p>
                          <p class="col-sm-10 mb-0">
                            4663 Agriculture Lane,<br />
                            Miami,<br />
                            Florida - 33165,<br />
                            United States.
                          </p>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
                <!-- /Personal Details -->
              </div>
              <!-- /Personal Details Tab -->

              <!-- Change Password Tab -->
              <div id="password_tab" class="tab-pane fade">
                <div class="card">
                  <div class="card-body">
                    <h5 class="card-title">Change Password</h5>
                    <div class="row">
                      <div class="col-md-10 col-lg-6">
                        <form>
                          <div class="form-group">
                            <label class="mb-2">Old Password</label>
                            <input type="password" class="form-control" />
                          </div>
                          <div class="form-group">
                            <label class="mb-2">New Password</label>
                            <input type="password" class="form-control" />
                          </div>
                          <div class="form-group">
                            <label class="mb-2">Confirm Password</label>
                            <input type="password" class="form-control" />
                          </div>
                          <b-button class="btn btn-primary" type="submit">
                            Save Changes
                          </b-button>
                        </form>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
              <!-- /Change Password Tab -->
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- /Page Wrapper -->
  </div>
  <pharmacymodel />
</template>
<script>
export default {
  data() {
    return {
      title: "Profile",
      text: "Dashboard",
      text1: "Profile",
    };
  },
  name: "pharmacy/profile",
};
</script>
