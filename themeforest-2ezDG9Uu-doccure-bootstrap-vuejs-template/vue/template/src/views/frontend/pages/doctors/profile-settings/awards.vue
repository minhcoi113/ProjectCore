<template>
  <!-- Awards -->
  <div class="card">
    <div class="card-body">
      <h4 class="card-title">Awards</h4>
      <div class="awards-info">
        <div class="row awards-cont">
          <div class="col-12 col-md-5">
            <div class="mb-3">
              <label class="mb-2">Awards</label>
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

      <!-- Add Awards -->
      <div class="row awards-cont" v-for="(awards, index) in awards" :key="index">
        <div class="col-12 col-md-5">
          <div class="mb-3">
            <label class="mb-2">Awards</label>
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
            @click="deleteawards(index)"
            ><i class="far fa-trash-alt"></i
          ></a>
        </div>
      </div>
      <!-- /Add Awards -->

      <div class="add-more">
        <a href="javascript:void(0);" class="add-award" @click="addawards"
          ><i class="fa fa-plus-circle"></i> Add More</a
        >
      </div>
    </div>
  </div>
  <!-- /Awards -->
</template>

<script>
export default {
  data() {
    return {
      awards: [],
    };
  },
  methods: {
    addawards() {
      this.awards.push({});
    },
    deleteawards(index) {
      this.awards.splice(index, 1);
    },
  },
};
</script>

<style scoped>
.awards-cont {
  align-items: center;
}
</style>
