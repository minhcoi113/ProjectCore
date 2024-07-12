<template>
  <div class="main-wrapper">
    <adminheader></adminheader>
    <adminsidebar></adminsidebar>

    <!-- Page Wrapper -->
    <div class="page-wrapper">
      <div class="content container-fluid">
        <adminbreadcrumb1 :title="title" :text="text" :text1="text1" :text2="text2" />
        <!-- /Page Header -->
        <div class="row">
          <div class="col-12">
            <!-- General -->

            <div class="card">
              <div class="card-header">
                <h4 class="card-title">General</h4>
              </div>
              <div class="card-body">
                <form action="javascript:;">
                  <div class="mb-3">
                    <label class="mb-2">Website Name</label>
                    <input type="text" class="form-control" />
                  </div>
                  <div class="mb-3">
                    <label class="mb-2">Website Logo</label>
                    <input type="file" class="form-control" />
                    <small class="text-secondary"
                      >Recommended image size is <b>150px x 150px</b></small
                    >
                  </div>
                  <div class="mb-0">
                    <label class="mb-2">Favicon</label>
                    <input type="file" class="form-control" />
                    <small class="text-secondary"
                      >Recommended image size is <b>16px x 16px</b> or
                      <b>32px x 32px</b></small
                    ><br />
                    <small class="text-secondary"
                      >Accepted formats : only png and ico</small
                    >
                  </div>
                </form>
              </div>
            </div>

            <!-- /General -->
          </div>
        </div>
      </div>
    </div>
    <!-- /Page Wrapper -->
  </div>
</template>

<script>
export default {
  data() {
    return {
      title: "General Settings",
      text: "Dashboard",
      text1: "Settings",
      text2: "General Settings",
    };
  },
};
</script>
