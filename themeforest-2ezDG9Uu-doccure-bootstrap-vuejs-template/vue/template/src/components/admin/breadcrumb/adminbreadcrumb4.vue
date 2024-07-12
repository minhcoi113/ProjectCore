<template>
  <div class="page-header">
    <div class="row align-items-center">
      <div class="col">
        <h3 class="page-title">{{ title }}</h3>
        <ul class="breadcrumb">
          <li class="breadcrumb-item">
            <a href="/admin/index">{{ text }}</a>
          </li>
          <li class="breadcrumb-item active">{{ text1 }}</li>
        </ul>
      </div>
      <div class="col-auto text-end float-end ms-auto">
        <a href="javascript:;" class="add-btn" data-bs-toggle="modal" data-bs-target="#add_event"
          ><span><i class="fe fe-plus"></i></span> {{ create }}</a
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
    create: {
      type: String,
      default: "",
    },
  },
};
</script>
