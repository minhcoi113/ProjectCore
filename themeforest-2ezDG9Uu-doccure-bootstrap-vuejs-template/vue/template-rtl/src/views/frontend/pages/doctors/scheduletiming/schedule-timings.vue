<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb1 :title="title" :text="text" :text1="text1" />
    <!-- Page Content -->

    <div class="content">
      <div class="container">
        <div class="row">
          <doctorsidebar></doctorsidebar>

          <div class="col-md-7 col-lg-8 col-xl-9">
            <div class="row">
              <div class="col-sm-12">
                <div class="card">
                  <div class="card-body">
                    <h4 class="card-title">Schedule Timings</h4>
                    <div class="profile-box">
                      <div class="row">
                        <div class="col-lg-4">
                          <div class="mb-3">
                            <label class="durations">Timing Slot Duration</label>

                            <vue-select :options="Sorting" placeholder="30 mins">
                            </vue-select>
                          </div>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col-md-12">
                          <div class="card schedule-widget mb-0">
                            <!-- Schedule Header -->
                            <div class="schedule-header">
                              <!-- Schedule Nav -->
                              <div class="schedule-nav">
                                <ul class="nav nav-tabs nav-justified">
                                  <li class="nav-item">
                                    <a
                                      class="nav-link"
                                      data-bs-toggle="tab"
                                      href="#slot_sunday"
                                      >Sunday</a
                                    >
                                  </li>
                                  <li class="nav-item">
                                    <a
                                      class="nav-link active"
                                      data-bs-toggle="tab"
                                      href="#slot_monday"
                                      >Monday</a
                                    >
                                  </li>
                                  <li class="nav-item">
                                    <a
                                      class="nav-link"
                                      data-bs-toggle="tab"
                                      href="#slot_tuesday"
                                      >Tuesday</a
                                    >
                                  </li>
                                  <li class="nav-item">
                                    <a
                                      class="nav-link"
                                      data-bs-toggle="tab"
                                      href="#slot_wednesday"
                                      >Wednesday</a
                                    >
                                  </li>
                                  <li class="nav-item">
                                    <a
                                      class="nav-link"
                                      data-bs-toggle="tab"
                                      href="#slot_thursday"
                                      >Thursday</a
                                    >
                                  </li>
                                  <li class="nav-item">
                                    <a
                                      class="nav-link"
                                      data-bs-toggle="tab"
                                      href="#slot_friday"
                                      >Friday</a
                                    >
                                  </li>
                                  <li class="nav-item">
                                    <a
                                      class="nav-link"
                                      data-bs-toggle="tab"
                                      href="#slot_saturday"
                                      >Saturday</a
                                    >
                                  </li>
                                </ul>
                              </div>
                              <!-- /Schedule Nav -->
                            </div>
                            <!-- /Schedule Header -->

                            <!-- Schedule Content -->
                            <div class="tab-content schedule-cont">
                              <schedule-sunday></schedule-sunday>
                              <schedule-monday></schedule-monday>
                              <schedule-tuesday></schedule-tuesday>
                              <schedule-wednesday></schedule-wednesday>
                              <schedule-thursday></schedule-thursday>
                              <schedule-friday></schedule-friday>
                              <schedule-saturday></schedule-saturday>
                            </div>
                            <!-- /Schedule Content -->
                          </div>
                        </div>
                      </div>
                    </div>
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
  <addslot></addslot>
  <editslot></editslot>
</template>
<script>
export default {
  data() {
    return {
      title: "Schedule Timings",
      text: "Home",
      text1: "Schedule Timings",
      Sorting: ["-", "15 mins", "30 mins", "45 mins", "1 Hour"],
    };
  },
};
</script>
