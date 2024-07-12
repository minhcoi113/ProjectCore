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
            <!-- Basic Information -->
            <div class="card">
              <div class="card-body">
                <h4 class="card-title">Basic Information</h4>
                <div class="row">
                  <div class="col-md-12">
                    <div class="mb-3">
                      <div class="change-avatar">
                        <div class="profile-img">
                          <img
                            src="@/assets/img/doctors/doctor-thumb-02.jpg"
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
                  <div class="col-md-6">
                    <div class="mb-3">
                      <label class="mb-2">Username <span class="text-danger">*</span></label>
                      <input type="text" class="form-control" readonly />
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="mb-3">
                      <label class="mb-2">Email <span class="text-danger">*</span></label>
                      <input type="email" class="form-control" readonly />
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="mb-3">
                      <label class="mb-2">First Name <span class="text-danger">*</span></label>
                      <input type="text" class="form-control" />
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="mb-3">
                      <label class="mb-2">Last Name <span class="text-danger">*</span></label>
                      <input type="text" class="form-control" />
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="mb-3">
                      <label class="mb-2">Phone Number</label>
                      <input type="text" class="form-control" />
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="mb-3">
                      <label class="mb-2">Gender</label>

                      <vue-select :options="sorting"></vue-select>
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="mb-0">
                      <label class="mb-2">Date of Birth</label>
                      <input type="text" class="form-control" />
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <!-- /Basic Information -->

            <!-- About Me -->
            <div class="card">
              <div class="card-body">
                <h4 class="card-title">About Me</h4>
                <div class="mb-0">
                  <label class="mb-2">Biography</label>
                  <textarea class="form-control" rows="5"></textarea>
                </div>
              </div>
            </div>
            <!-- /About Me -->

            <!-- Clinic Info -->
            <div class="card">
              <div class="card-body">
                <h4 class="card-title">Clinic Info</h4>
                <div class="row">
                  <div class="col-md-6">
                    <div class="mb-3">
                      <label class="mb-2">Clinic Name</label>
                      <input type="text" class="form-control" />
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="mb-3">
                      <label class="mb-2">Clinic Address</label>
                      <input type="text" class="form-control" />
                    </div>
                  </div>
                  <div class="col-md-12">
                    <div class="mb-3">
                      <label class="mb-2">Clinic Images</label>
                      <div class="col-lg-12">
                        <div class="form-group">
                          <div
                            class="call-option file-option"
                            @dragover="onDragOver"
                            @dragleave="onDragLeave"
                            @drop="onFileDrop"
                            :class="{ 'file-over': isFileOver }"
                          >
                            <input
                              type="file"
                              id="radio1"
                              name="selector"
                              class="option-radio"
                              style="display: none"
                              ref="fileInput"
                              @change="onFileChange"
                            />
                            <label
                              for="radio1"
                              class="call-lable verify-lable verify-file"
                            >
                              <div v-if="!file">Drop files here to upload</div>
                              <div v-else>
                                <img :src="filePreview" alt="Uploaded Image" />
                                <!-- Add Remove button using Feather Icon -->
                                <a
                                  href="javascript:void(0);"
                                  class="remove-btn"
                                  @click="removeImage"
                                >
                                  <i class="far fa-trash-alt"></i>
                                </a>
                              </div>
                            </label>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="upload-wrap">
                      <div class="upload-images">
                        <img
                          src="@/assets/img/features/feature-01.jpg"
                          alt="Upload Image"
                        />
                        <a
                          href="javascript:void(0);"
                          class="btn btn-icon btn-danger btn-sm"
                          ><i class="far fa-trash-alt"></i
                        ></a>
                      </div>
                      <div class="upload-images">
                        <img
                          src="@/assets/img/features/feature-02.jpg"
                          alt="Upload Image"
                        />
                        <a
                          href="javascript:void(0);"
                          class="btn btn-icon btn-danger btn-sm"
                          ><i class="far fa-trash-alt"></i
                        ></a>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <!-- /Clinic Info -->
            <doctorprofile-settings1></doctorprofile-settings1>
            <doctorprofile-settings2></doctorprofile-settings2>

            <div class="submit-section submit-btn-bottom">
              <b-button type="submit" class="btn btn-primary prime-btn">
                Save Changes
              </b-button>
            </div>
          </div>
        </div>
      </div>
    </div>
    <indexfooter></indexfooter>
  </div>
  <!-- /Main Wrapper -->
</template>
<script>
export default {
  data() {
    return {
      title: "Profile Settings",
      text: "Home",
      text1: "Profile Settings",
      sorting: ["Select", "Male", "Female"],
      file: null,
      filePreview: null,
      isFileOver: false,
    };
  },
  methods: {
    onDragOver(event) {
      event.preventDefault();
      this.isFileOver = true;
    },
    onDragLeave(event) {
      event.preventDefault();
      this.isFileOver = false;
    },
    onFileChange(event) {
      const file = event.target.files[0];
      this.file = file;
      this.filePreview = URL.createObjectURL(file);
    },
    onFileDrop(event) {
      event.preventDefault();
      this.isFileOver = false;
      const file = event.dataTransfer.files[0];
      this.file = file;
      this.filePreview = URL.createObjectURL(file);
    },
    removeImage() {
      // Clear the uploaded image and reset the input field
      this.file = null;
      this.filePreview = null;
      this.$refs.fileInput.value = "";
    },
  },
};
</script>
<style>
.file-over {
  border: 2px dashed #ccc;
}
.file-option img {
  width: 120px;
  height: 120px;
}
.call-lable {
  position: relative;
}
.remove-btn {
  position: absolute;
  top: 23px;
  right: 45%;
}
.remove-btn i {
  color: #e63333;
}
</style>
