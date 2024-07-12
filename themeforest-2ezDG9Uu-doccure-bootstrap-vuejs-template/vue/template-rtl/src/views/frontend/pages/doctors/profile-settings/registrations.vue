<template>
  <!-- Registrations -->
  <div class="card">
    <div class="card-body">
      <h4 class="card-title">Registrations</h4>
      <div class="registrations-info">
        <div class="row reg-cont">
          <div class="col-12 col-md-5">
            <div class="mb-3">
              <label class="mb-2">Registrations</label>
              <input type="text" class="form-control" />
            </div>
          </div>
          <div class="col-12 col-md-5">
            <div class="mb-3">
              <label class="mb-2">Year</label>
              <input type="text" class="form-control" />
            </div>
          </div>
        </div>
      </div>

      <!-- Add Registrations -->
      <div
        class="row reg-cont"
        v-for="(registrations, index) in registrations"
        :key="index"
      >
        <div class="col-12 col-md-5">
          <div class="mb-3">
            <label class="mb-2">Registrations</label>
            <input type="text" class="form-control" />
          </div>
        </div>
        <div class="col-12 col-md-5">
          <div class="mb-3">
            <label class="mb-2">Year</label>
            <input type="text" class="form-control" />
          </div>
        </div>
        <div class="col-12 col-md-2 col-lg-1">
          <a
            href="javascript:void(0);"
            class="btn btn-danger trash"
            @click="deleteregistrations(index)"
            ><i class="far fa-trash-alt"></i
          ></a>
        </div>
      </div>
      <!-- /Add Registrations -->

      <div class="add-more">
        <a href="javascript:void(0);" class="add-reg" @click="addmeregistrations"
          ><i class="fa fa-plus-circle"></i> Add More</a
        >
      </div>
    </div>
  </div>
  <!-- /Registrations -->
</template>

<script>
export default {
  data() {
    return {
      registrations: [],
    };
  },
  methods: {
    addmeregistrations() {
      this.registrations.push({});
    },
    deleteregistrations(index) {
      this.registrations.splice(index, 1);
    },
  },
};
</script>
<style scoped>
.reg-cont {
  align-items: center;
}
</style>
