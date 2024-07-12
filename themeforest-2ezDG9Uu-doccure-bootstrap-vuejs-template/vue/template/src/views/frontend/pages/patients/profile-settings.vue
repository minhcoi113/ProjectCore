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
            <div class="card">
              <div class="card-body">
                <!-- Profile Settings Form -->
                <form>
                  <div class="row">
                    <div class="col-12 col-md-12">
                      <div class="mb-3">
                        <div class="change-avatar">
                          <div class="profile-img">
                            <img
                              src="@/assets/img/patients/patient.jpg"
                              alt="User Image"
                            />
                          </div>
                          <div class="upload-img">
                            <div class="change-photo-btn">
                              <span><i class="fa fa-upload"></i> Upload Photo</span>
                              <input type="file" class="upload" />
                            </div>
                            <small class="form-text text-muted"
                              >Allowed JPG, GIF or PNG. Max size of 2MB</small
                            >
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="col-12 col-md-6">
                      <div class="mb-3">
                        <label class="mb-2">First Name</label>
                        <input type="text" class="form-control" value="Richard" />
                      </div>
                    </div>
                    <div class="col-12 col-md-6">
                      <div class="mb-3">
                        <label class="mb-2">Last Name</label>
                        <input type="text" class="form-control" value="Wilson" />
                      </div>
                    </div>
                    <div class="col-12 col-md-6">
                      <div class="mb-3">
                        <label class="mb-2">Date of Birth</label>
                        <div class="cal-icon">
                          <datepicker
                            v-model="startdate"
                            placeholder="Date"
                            class="form-control datetimepicker"
                            :editable="true"
                            :clearable="false"
                          />
                        </div>
                      </div>
                    </div>
                    <div class="col-12 col-md-6">
                      <div class="mb-3">
                        <label class="mb-2">Blood Group</label>
                        <vue-select :options="Sort" placeholder="A -" />
                      </div>
                    </div>
                    <div class="col-12 col-md-6">
                      <div class="mb-3">
                        <label class="mb-2">Email ID</label>
                        <input
                          type="email"
                          class="form-control"
                          value="richard@example.com"
                        />
                      </div>
                    </div>
                    <div class="col-12 col-md-6">
                      <div class="mb-3">
                        <label class="mb-2">Mobile</label>
                        <input type="text" value="+1 202-555-0125" class="form-control" />
                      </div>
                    </div>
                    <div class="col-12">
                      <div class="mb-3">
                        <label class="mb-2">Address</label>
                        <input
                          type="text"
                          class="form-control"
                          value="806 Twin Willow Lane"
                        />
                      </div>
                    </div>
                    <div class="col-12 col-md-6">
                      <div class="mb-3">
                        <label class="mb-2">City</label>
                        <input type="text" class="form-control" value="Old Forge" />
                      </div>
                    </div>
                    <div class="col-12 col-md-6">
                      <div class="mb-3">
                        <label class="mb-2">State</label>
                        <input type="text" class="form-control" value="Newyork" />
                      </div>
                    </div>
                    <div class="col-12 col-md-6">
                      <div class="mb-3">
                        <label class="mb-2">Zip Code</label>
                        <input type="text" class="form-control" value="13420" />
                      </div>
                    </div>
                    <div class="col-12 col-md-6">
                      <div class="mb-3">
                        <label class="mb-2">Country</label>
                        <input type="text" class="form-control" value="United States" />
                      </div>
                    </div>
                  </div>
                  <div class="submit-section">
                    <b-button type="submit" class="btn btn-primary submit-btn"
                      >Save Changes</b-button
                    >
                  </div>
                </form>
                <!-- /Profile Settings Form -->
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
import { ref } from "vue";
const currentDate = ref(new Date());
export default {
  data() {
    return {
      title: "Profile Settings",
      text: "Home",
      text1: "Profile Settings",
      startdate: currentDate,
      Sort: ["A-", "A+", "B-", "B+", "AB-", "AB+", "O-", "O+"],
    };
  },
  name: "profile-settings",
};
</script>

<style scoped>
.v3dp__elements[data-v-65eb861b] button.selected span {
  background-color: #20c0f3 !important;
  color: aliceblue !important;
}
.v3dp__elements[data-v-65eb861b] button:not(:disabled):hover span {
  background-color: #20c0f3 !important;
  color: aliceblue !important;
}
</style>
