<template>
  <div class="chat-page">
    <div class="main-wrapper">
      <layoutheader></layoutheader>
      <!-- Page Content -->
      <div class="content-chat top-space-chat">
        <div class="container-fluid">
          <div class="row">
            <div class="col-xl-12">
              <div class="chat-window">
                <!-- Chat Left -->
                <doctor-chat-left></doctor-chat-left>
                <!-- /Chat Left -->

                <!-- Chat Right -->
                <doctor-chat-right></doctor-chat-right>
                <!-- /Chat Right -->
              </div>
            </div>
          </div>
          <!-- /Row -->
        </div>
      </div>
      <!-- /Page Content -->
      <indexfooter />
    </div>

    <doctor-chat-model></doctor-chat-model>
  </div>
</template>
