<template>
  <div class="vld-parent">
    <loading :active="isLoading"
             :can-cancel="true"
             :on-cancel="onCancel"
             :is-full-page="fullPage"
             :width="100"
             :height="100"
             :z-index="9999"
             />
  </div>
</template>

<script>
import Loading from 'vue-loading-overlay';
import 'vue-loading-overlay/dist/vue-loading.css';

export default {
  data() {
    return {
      isLoading: true,
      fullPage: false
    }
  },
  components: {
    Loading
  },
  methods: {
    doAjax() {
      this.isLoading = true;
      // simulate AJAX
      setTimeout(() => {
        this.isLoading = false
      }, 5000)
    },
    onCancel() {
    }
  }
}
</script>