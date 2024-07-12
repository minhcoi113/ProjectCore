<template>
  <!-- Education -->
  <div class="card">
    <div class="card-body">
      <h4 class="card-title">Education</h4>
      <div class="education-info">
        <div class="row education-cont">
          <div class="col-12 col-md-10 col-lg-11">
            <div class="row">
              <div class="col-12 col-md-6 col-lg-4">
                <div class="mb-3">
                  <label class="mb-2">Degree</label>
                  <input type="text" class="form-control" />
                </div>
              </div>
              <div class="col-12 col-md-6 col-lg-4">
                <div class="mb-3">
                  <label class="mb-2">College/Institute</label>
                  <input type="text" class="form-control" />
                </div>
              </div>
              <div class="col-12 col-md-6 col-lg-4">
                <div class="mb-3">
                  <label class="mb-2">Year of Completion</label>
                  <input type="text" class="form-control" />
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>

      <!-- /Add Education -->
      <div class="row btn-delete" v-for="(certify, index) in certify" :key="index">
        <div class="col-12 col-md-10 col-lg-11">
          <div class="row">
            <div class="col-12 col-md-6 col-lg-4">
              <div class="mb-3">
                <label class="mb-2">Degree</label><input type="text" class="form-control" />
              </div>
            </div>
            <div class="col-12 col-md-6 col-lg-4">
              <div class="mb-3">
                <label class="mb-2">College/Institute</label><input type="text" class="form-control" />
              </div>
            </div>
            <div class="col-12 col-md-6 col-lg-4">
              <div class="mb-3">
                <label class="mb-2">Year of Completion</label
                ><input type="text" class="form-control" />
              </div>
            </div>
          </div>
        </div>
        <div class="col-12 col-md-2 col-lg-1">
          <a
            href="javascript:void(0);"
            class="btn btn-danger trash"
            @click="deletecertify(index)"
            ><i class="far fa-trash-alt"></i
          ></a>
        </div>
      </div>
      <!-- /Add Education -->

      <div class="add-more">
        <a href="javascript:void(0);" class="add-education" @click="addcertify"
          ><i class="fa fa-plus-circle"></i> Add More</a
        >
      </div>
    </div>
  </div>
  <!-- /Education -->

  <!-- Experience -->
  <experience></experience>
  <!-- /Experience -->

  <!-- Awards -->
  <awards></awards>
  <!-- /Awards -->

  <!-- Memberships -->
  <memberships></memberships>
  <!-- /Memberships -->

  <!-- Registrations -->
  <registrations></registrations>
  <!-- /Registrations -->
</template>

<script>
export default {
  data() {
    return {
      certify: [],
    };
  },
  methods: {
    addcertify() {
      this.certify.push({});
    },
    deletecertify(index) {
      this.certify.splice(index, 1);
    },
  },
};
</script>

<style scoped>
.btn-delete {
  align-items: center;
}
</style>
