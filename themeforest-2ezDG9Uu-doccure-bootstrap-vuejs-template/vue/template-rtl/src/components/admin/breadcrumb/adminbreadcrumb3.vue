<template>
  <div class="page-header">
    <div class="row">
      <div class="col-sm-7 col-auto">
        <h3 class="page-title">{{ title }}</h3>
        <ul class="breadcrumb">
          <li class="breadcrumb-item">
            <router-link to="/admin/index">{{ text }}</router-link>
          </li>
          <li class="breadcrumb-item active">{{ text1 }}</li>
        </ul>
      </div>
      <div class="col-sm-5 col">
        <router-link
          to="#Add_Specialities_details"
          data-bs-toggle="modal"
          class="btn btn-primary float-end mt-2"
          >{{ Add }}</router-link
        >
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props: {
    title: {
      type: String,
      default: "",
    },
    text: {
      type: String,
      default: "",
    },
    text1: {
      type: String,
      default: "",
    },
    Add: {
      type: String,
      default: "",
    },
  },
};
</script>
