<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="content">
      <div class="container-fluid">
        <div class="row">
          <!-- Profile Sidebar -->
          <div class="col-md-5 col-lg-4 col-xl-3 theiaStickySidebar">
            <div class="stickysidebar">
              <profilesidebar></profilesidebar>
            </div>
          </div>
          <!-- / Profile Sidebar -->

          <div class="col-md-7 col-lg-8 col-xl-9">
            <div class="card">
              <div class="card-header">
                <div class="row">
                  <div class="col-sm-6">
                    <h3 class="card-title">Dependent</h3>
                  </div>
                  <div class="col-sm-6">
                    <div class="text-end">
                      <a
                        href="#modal_form"
                        data-bs-toggle="modal"
                        class="btn btn-primary btn-sm"
                        tabindex="0"
                        >Add Dependent</a
                      >
                    </div>
                  </div>
                </div>
              </div>
              <div class="card-body">
                <!-- Dependent Tab -->
                <div class="card card-table mb-0">
                  <div class="card-body">
                    <div class="table-responsive">
                      <table class="table table-hover table-center mb-0">
                        <thead>
                          <tr>
                            <th>Dependent</th>
                            <th>Relationship</th>
                            <th>gender</th>
                            <th>Number</th>
                            <th>Blood Group</th>
                            <th>Action</th>
                          </tr>
                        </thead>
                        <tbody>
                          <tr
                            class="col-md-6 col-lg-4 col-xl-3"
                            v-for="item in dependent"
                            :key="item.id"
                          >
                            <td>
                              <h2 class="table-avatar">
                                <span class="avatar avatar-sm me-2">
                                  <img
                                    class="avatar-img rounded-circle"
                                    :src="require(`@/assets/img/patients/${item.Image}`)"
                                    alt="User Image"
                                  />
                                </span>
                                {{ item.Dependent }}
                              </h2>
                            </td>
                            <td>{{ item.Relationship }}</td>
                            <td>{{ item.gender }}</td>
                            <td>{{ item.Number }}</td>
                            <td>{{ item.BloodGroup }}</td>
                            <td>
                              <div class="table-action">
                                <a
                                  href="#edit_form"
                                  class="btn btn-sm bg-info-light me-1"
                                  data-bs-toggle="modal"
                                >
                                  <i class="fas fa-edit"></i> Edit</a
                                >
                                <a
                                  href="javascript:void(0);"
                                  class="btn btn-sm bg-danger-light"
                                  ><i class="fas fa-times"></i> Deactive</a
                                >
                              </div>
                            </td>
                          </tr>
                        </tbody>
                      </table>
                    </div>
                  </div>
                </div>
                <!-- /Dependent Tab -->
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <indexfooter></indexfooter>
  </div>
  <actions></actions>
</template>
<script>
import dependent from "@/assets/json/patients/dependent.json";
export default {
  data() {
    return {
      title: "Dashboard",
      text: "Home",
      text1: "Dashboard",
      dependent: dependent,
    };
  },
};
</script>
<style scoped>
.form-control[type="file"]:not(:disabled):not([readonly]) {
  padding: 10px;
}
</style>
