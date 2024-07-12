<template>
  <div class="call-page">
    <div class="main-wrapper">
      <layoutheader></layoutheader>
      <!-- Page Content -->
      <div class="content top-space">
        <div class="container">
          <!-- Call Wrapper -->
          <div class="call-wrapper">
            <div class="call-main-row">
              <div class="call-main-wrapper">
                <div class="call-view">
                  <div class="call-window">
                    <!-- Call Header -->
                    <div class="fixed-header">
                      <div class="navbar">
                        <div class="user-details me-auto">
                          <div class="float-start user-img">
                            <router-link
                              class="avatar avatar-sm me-2"
                              to="/patient-profile"
                              title="Charlene Reed"
                            >
                              <img
                                src="@/assets/img/patients/patient1.jpg"
                                alt="User Image"
                                class="rounded-circle"
                              />
                              <span class="status online"></span>
                            </router-link>
                          </div>
                          <div class="user-info float-start">
                            <router-link to="/patient-profile"
                              ><span>Charlene Reed</span></router-link
                            >
                            <span class="last-seen">Online</span>
                          </div>
                        </div>
                        <ul class="nav float-end custom-menu">
                          <li class="nav-item dropdown dropdown-action">
                            <a
                              href="javascript:;"
                              class="nav-link dropdown-toggle"
                              data-bs-toggle="dropdown"
                              aria-expanded="false"
                              ><i class="fa fa-cog"></i
                            ></a>
                            <div class="dropdown-menu dropdown-menu-end">
                              <a href="javascript:void(0)" class="dropdown-item"
                                >Settings</a
                              >
                            </div>
                          </li>
                        </ul>
                      </div>
                    </div>
                    <!-- /Call Header -->

                    <!-- Call Contents -->
                    <div class="call-contents">
                      <div class="call-content-wrap">
                        <div class="voice-call-avatar">
                          <img
                            src="@/assets/img/doctors/doctor-thumb-02.jpg"
                            alt="User Image"
                            class="call-avatar"
                          />
                          <span class="username">Dr. Darren Elder</span>
                          <span class="call-timing-count">00:59</span>
                        </div>
                        <div class="call-users">
                          <ul>
                            <li>
                              <a href="javascript:;">
                                <img
                                  src="@/assets/img/patients/patient1.jpg"
                                  class="img-fluid"
                                  alt="User Image"
                                />
                                <span class="call-mute"
                                  ><i class="fa fa-microphone-slash"></i
                                ></span>
                              </a>
                            </li>
                          </ul>
                        </div>
                      </div>
                    </div>
                    <!-- /Call Contents -->

                    <!-- Call Footer -->
                    <div class="call-footer">
                      <div class="call-icons">
                        <ul class="call-items">
                          <li class="call-item me-2">
                            <a
                              href="javascript:void(0)"
                              class="mute-video"
                              :class="isVideoMuted ? 'stop' : ''"
                              title="Enable Video"
                              data-placement="top"
                              data-bs-toggle="tooltip"
                              @click="toggleVideoMute"
                            >
                              <i
                                :class="
                                  isVideoMuted ? 'feather-video-off' : 'feather-video'
                                "
                              ></i>
                            </a>
                          </li>
                          <li class="call-item me-2">
                            <a
                              href="javascript:void(0)"
                              class="mute-bt"
                              :class="isAudioMuted ? 'stop' : ''"
                              title="Mute"
                              data-placement="top"
                              data-bs-toggle="tooltip"
                              @click="toggleAudioMute"
                            >
                              <i
                                :class="isAudioMuted ? 'feather-mic-off' : 'feather-mic'"
                              ></i>
                            </a>
                          </li>
                          <li class="call-item">
                            <a
                              href="javascript:void(0)"
                              title="Add User"
                              data-placement="top"
                              data-bs-toggle="tooltip"
                            >
                              <i class="feather-user-plus"></i>
                            </a>
                          </li>
                        </ul>
                        <div class="end-call">
                          <a href="javascript:void(0);">
                            <i class="material-icons">call_end</i>
                          </a>
                        </div>
                      </div>
                    </div>
                    <!-- /Call Footer -->
                  </div>
                </div>
              </div>
            </div>
          </div>
          <!-- /Call Wrapper -->
        </div>
      </div>
      <!-- /Page Content -->
    </div>
  </div>
</template>
<script>
export default {
  data() {
    return {
      isVideoMuted: false,
      isAudioMuted: false,
    };
  },
  methods: {
    toggleVideoMute() {
      this.isVideoMuted = !this.isVideoMuted;
    },
    toggleAudioMute() {
      this.isAudioMuted = !this.isAudioMuted;
    },
  },
};
</script>
