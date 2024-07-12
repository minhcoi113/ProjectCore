<template>
  <!-- /Page Header -->
  <div class="page-header">
    <div class="row">
      <div class="col-sm-12">
        <h3 class="page-title">{{ title }}</h3>
        <ul class="breadcrumb">
          <li class="breadcrumb-item">
            <router-link to="/pharmacy/index">{{ text }}</router-link>
          </li>
          <li class="breadcrumb-item">
            <a href="javascript:(0)">{{ text1 }}</a>
          </li>
          <li class="breadcrumb-item active">{{ text2 }}</li>
        </ul>
      </div>
    </div>
  </div>
  <!-- /Page Header -->
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
    text2: {
      type: String,
      default: "",
    },
  },
};
</script>
