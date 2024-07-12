<template>
  <!-- Memberships -->
  <div class="card">
    <div class="card-body">
      <h4 class="card-title">Memberships</h4>
      <div class="membership-info">
        <div class="row membership-cont">
          <div class="col-12 col-md-10 col-lg-5">
            <div class="mb-3">
              <label class="mb-2">Memberships</label>
              <input type="text" class="form-control" />
            </div>
          </div>
        </div>
      </div>

      <!-- Memberships -->
      <div
        class="row membership-cont"
        v-for="(memberships, index) in memberships"
        :key="index"
      >
        <div class="col-12 col-md-10 col-lg-5">
          <div class="mb-3">
            <label class="mb-2">Memberships</label>
            <input type="text" class="form-control" />
          </div>
        </div>
        <div class="col-12 col-md-2 col-lg-1">
          <a
            href="javascript:void(0);"
            class="btn btn-danger trash"
            @click="deletememberships(index)"
            ><i class="far fa-trash-alt"></i
          ></a>
        </div>
      </div>
      <!-- /Memberships -->
      <div class="add-more">
        <a href="javascript:void(0);" class="add-membership" @click="addmemberships"
          ><i class="fa fa-plus-circle"></i> Add More</a
        >
      </div>
    </div>
  </div>
  <!-- /Memberships -->
</template>

<script>
export default {
  data() {
    return {
      memberships: [],
    };
  },
  methods: {
    addmemberships() {
      this.memberships.push({});
    },
    deletememberships(index) {
      this.memberships.splice(index, 1);
    },
  },
};
</script>

<style scoped>
.membership-cont {
  align-items: center;
}
</style>
