<template>
  <div class="main-wrapper">
    <layoutheadertwo v-if="showHeader" ref="header" />

    <indexthreebanner></indexthreebanner>

    <indexthreedoctor></indexthreedoctor>

    <indexthreeclinic></indexthreeclinic>

    <indexthreeblog></indexthreeblog>

    <indextwofooter></indextwofooter>
    <cursor />

    <scrolltotop />
  </div>
</template>
<script>
export default {
  data() {
    return {
      showHeader: true,
      headerElement: null,
    };
  },
  mounted() {
    this.showHeader = !!this.$refs.header;
    if (this.showHeader) {
      this.headerElement = this.$refs.header.$el;
      window.addEventListener("scroll", this.handleScroll);
    }
  },
  beforeUnmount() {
    if (this.showHeader) {
      window.removeEventListener("scroll", this.handleScroll);
    }
  },
  methods: {
    handleScroll() {
      const scroll =
        window.pageYOffset ||
        document.documentElement.scrollTop ||
        document.body.scrollTop;
      if (scroll > 95) {
        this.setTransparentBackground(false);
      } else {
        this.setTransparentBackground(true);
      }
    },
    setTransparentBackground(transparent) {
      if (this.headerElement) {
        this.headerElement.style.background = transparent ? "transparent" : "#ffffff";
      }
    },
  },
};
</script>
