<template>
  <!-- Experience -->
  <div class="card">
    <div class="card-body">
      <h4 class="card-title">Experience</h4>
      <div class="experience-info">
        <div class="row experience-cont">
          <div class="col-12 col-md-10 col-lg-11">
            <div class="row">
              <div class="col-12 col-md-6 col-lg-4">
                <div class="mb-3">
                  <label class="mb-2">Hospital Name</label>
                  <input type="text" class="form-control" />
                </div>
              </div>
              <div class="col-12 col-md-6 col-lg-4">
                <div class="mb-3">
                  <label class="mb-2">From</label>
                  <input type="text" class="form-control" />
                </div>
              </div>
              <div class="col-12 col-md-6 col-lg-4">
                <div class="mb-3">
                  <label class="mb-2">To</label>
                  <input type="text" class="form-control" />
                </div>
              </div>
              <div class="col-12 col-md-6 col-lg-4">
                <div class="mb-3">
                  <label class="mb-2">Designation</label>
                  <input type="text" class="form-control" />
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>

      <!-- Add Experience -->
      <div
        class="row experience-cont"
        v-for="(experience, index) in experience"
        :key="index"
      >
        <div class="col-12 col-md-10 col-lg-11">
          <div class="row">
            <div class="col-12 col-md-6 col-lg-4">
              <div class="mb-3">
                <label class="mb-2">Hospital Name</label>
                <input type="text" class="form-control" />
              </div>
            </div>
            <div class="col-12 col-md-6 col-lg-4">
              <div class="mb-3">
                <label class="mb-2">From</label>
                <input type="text" class="form-control" />
              </div>
            </div>
            <div class="col-12 col-md-6 col-lg-4">
              <div class="mb-3">
                <label class="mb-2">To</label>
                <input type="text" class="form-control" />
              </div>
            </div>
            <div class="col-12 col-md-6 col-lg-4">
              <div class="mb-3">
                <label class="mb-2">Designation</label>
                <input type="text" class="form-control" />
              </div>
            </div>
          </div>
        </div>
        <div class="col-12 col-md-2 col-lg-1">
          <a
            href="javascript:void(0);"
            class="btn btn-danger trash"
            @click="deleteexperience(index)"
            ><i class="far fa-trash-alt"></i
          ></a>
        </div>
      </div>
      <!-- /Add Experience -->

      <div class="add-more">
        <a href="javascript:void(0);" class="add-experience" @click="addexperience"
          ><i class="fa fa-plus-circle"></i> Add More</a
        >
      </div>
    </div>
  </div>
  <!-- /Experience -->
</template>

<script>
export default {
  data() {
    return {
      experience: [],
    };
  },
  methods: {
    addexperience() {
      this.experience.push({});
    },
    deleteexperience(index) {
      this.experience.splice(index, 1);
    },
  },
};
</script>

<style scoped>
.experience-cont {
  align-items: flex-end;
}
</style>
