<script>
export default {
  props: {
    maxVisibleButtons: {
      type: Number,
      required: false,
      default: 3
    },
    totalPages: {
      type: Number,
      required: true
    },
    total: {
      type: Number,
      required: true
    },
    currentPage: {
      type: Number,
      required: true
    }
  },
  computed: {
    isInFirstPage() {
      return this.currentPage === 1;
    },
    isInLastPage() {
      return this.currentPage === this.totalPages;
    },
    startPage() {
      // When on the first page
      if (this.currentPage === 1) {
        return 1;
      }
      // When on the last page
      if (this.currentPage === this.totalPages) {
        return this.totalPages - this.maxVisibleButtons + 1;
      }
      // When in between
      return this.currentPage - 1;
    },
    pages() {
      const range = [];

      for (let i = this.startPage;
           i <= Math.min(this.startPage + this.maxVisibleButtons - 1, this.totalPages);
           i += 1) {
        range.push({
          name: i,
          isDisabled: i === this.currentPage
        });
      }

      return range;
    },
  },
  methods: {
    onClickFirstPage() {
      this.$emit('pagechanged', 1);
    },
    onClickPreviousPage() {
      this.$emit('pagechanged', this.currentPage - 1);
    },
    onClickPage(page) {
      this.$emit('pagechanged', page);
    },
    onClickNextPage() {
      this.$emit('pagechanged', this.currentPage + 1);
    },
    onClickLastPage() {
      this.$emit('pagechanged', this.totalPages);
    },
    isPageActive(page) {
      return this.currentPage === page;
    }
  }
}
</script>
<template>
  <ul class="pagination pagination-rounded justify-content-center mt-4">
    <li class="page-item">
      <button class="btn btn-primary btn-sm" type="button" @click="onClickFirstPage" :disabled="isInFirstPage">
        Trước
      </button>
    </li>
    <li class="page-item">
      <button type="button" class="page-link" @click="onClickPreviousPage" :disabled="isInFirstPage">
        <i class="mdi mdi-chevron-left"></i>
      </button>
    </li>
    <li v-for="(page, index) in pages" class="page-item" :key="index" :class="{ active: isPageActive(page.name) }">
      <button class="page-link" type="button" @click="onClickPage(page.name)" :disabled="page.isDisabled">
        {{ page.name }}
      </button>
    </li>
    <li class="page-item">
      <button type="button" class="page-link" @click="onClickNextPage" :disabled="isInLastPage">
        <i class="mdi mdi-chevron-right"></i>
      </button>
    </li>
    <li class="page-ite">
      <button class="btn btn-primary btn-sm" type="button" @click="onClickLastPage" :disabled="isInLastPage">
        Sau
      </button>
    </li>
  </ul>
</template>

