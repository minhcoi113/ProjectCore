<template>
  <div class="chat-page">
    <div class="main-wrapper">
      <layoutheader></layoutheader>

      <div class="content-chat top-space-chat">
        <div class="container-fluid">
          <div class="row">
            <div class="col-xl-12">
              <div class="chat-window">
                <!-- Chat Left -->
                <chatleft></chatleft>
                <!-- /Chat Left -->

                <!-- Chat Right -->
                <chatright></chatright>
                <!-- /Chat Right -->
              </div>
            </div>
          </div>
          <!-- /Row -->
        </div>
      </div>
    </div>
    <div class="modal fade call-modal" id="voice_call">
      <div class="modal-dialog modal-dialog-centered" role="document">
        <div class="modal-content">
          <div class="modal-body">
            <!-- Outgoing Call -->
            <div class="call-box incoming-box">
              <div class="call-wrapper">
                <div class="call-inner">
                  <div class="call-user">
                    <img
                      alt="User Image"
                      src="@/assets/img/doctors/doctor-thumb-02.jpg"
                      class="call-avatar"
                    />
                    <h4>Darren Elder</h4>
                    <span>Connecting...</span>
                  </div>
                  <div class="call-items">
                    <a
                      href="javascript:void(0);"
                      class="btn call-item call-end"
                      data-bs-dismiss="modal"
                      aria-label="Close"
                      ><i class="material-icons">call_end</i></a
                    >
                    <a
                      href="javascript:;"
                      class="btn call-item call-start"
                      data-bs-dismiss="modal"
                      aria-label="Close"
                      ><i class="material-icons">call</i></a
                    >
                  </div>
                </div>
              </div>
            </div>
            <!-- Outgoing Call -->
          </div>
        </div>
      </div>
    </div>
    <!-- /Voice Call Modal -->

    <!-- Video Call Modal -->
    <div class="modal fade call-modal" id="video_call">
      <div class="modal-dialog modal-dialog-centered" role="document">
        <div class="modal-content">
          <div class="modal-body">
            <!-- Incoming Call -->
            <div class="call-box incoming-box">
              <div class="call-wrapper">
                <div class="call-inner">
                  <div class="call-user">
                    <img
                      class="call-avatar"
                      src="@/assets/img/doctors/doctor-thumb-02.jpg"
                      alt="User Image"
                    />
                    <h4>Darren Elder</h4>
                    <span>Calling ...</span>
                  </div>
                  <div class="call-items">
                    <a
                      href="javascript:void(0);"
                      class="btn call-item call-end"
                      data-bs-dismiss="modal"
                      aria-label="Close"
                      ><i class="material-icons">call_end</i></a
                    >
                    <a
                      href="javascript:;"
                      class="btn call-item call-start"
                      data-bs-dismiss="modal"
                      aria-label="Close"
                      ><i class="material-icons">videocam</i></a
                    >
                  </div>
                </div>
              </div>
            </div>
            <!-- /Incoming Call -->
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
