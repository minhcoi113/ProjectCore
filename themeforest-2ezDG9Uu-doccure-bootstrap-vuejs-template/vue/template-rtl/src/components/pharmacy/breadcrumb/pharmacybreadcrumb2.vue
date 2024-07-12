<template>
  <div class="page-header">
    <div class="row">
      <div class="col-sm-7 col-auto">
        <h3 class="page-title">{{ title }}</h3>
        <ul class="breadcrumb">
          <li class="breadcrumb-item">
            <router-link to="/pharmacy/index">{{ text }}</router-link>
          </li>
          <li class="breadcrumb-item active">{{ text1 }}</li>
        </ul>
      </div>
      <div class="col-sm-5 col" v-if="isHomeRoute">
        <a
          href="#Add_Specialities_details"
          data-bs-toggle="modal"
          class="btn btn-primary float-end mt-2"
          >Add</a
        >
      </div>
      <div class="col-sm-5 col" v-else-if="isPharmacyRoute">
        <router-link to="/pharmacy/add-purchase" class="btn btn-primary float-end mt-2">{{
          Add
        }}</router-link>
      </div>
      <div class="col-sm-5 col" v-else-if="isPharmacy1Route">
        <router-link to="/pharmacy/add-supplier" class="btn btn-primary float-end mt-2">{{
          Add
        }}</router-link>
      </div>
      <div class="col-sm-5 col" v-else>
        <router-link to="/pharmacy/add-product" class="btn btn-primary float-end mt-2">{{
          Add
        }}</router-link>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  computed: {
    isHomeRoute() {
      return this.$route.path === "/pharmacy/categories";
    },
    isPharmacyRoute() {
      return this.$route.path == "/pharmacy/purchase";
    },
    isPharmacy1Route() {
      return this.$route.path == "/pharmacy/supplier";
    },
  },
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
