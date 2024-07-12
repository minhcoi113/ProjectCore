<template>
  <div class="main-wrapper home-ten">
    <layoutheader :class="{ 'header-space': showHeaderSpace }" ref="header" />

    <indexfivebanner></indexfivebanner>

    <indexfiveservice></indexfiveservice>

    <indexfivedoctor></indexfivedoctor>

    <indexfivetestimonial></indexfivetestimonial>

    <indexfivepricing></indexfivepricing>

    <indexfivefooter></indexfivefooter>
    <cursor />

    <scrolltotop />
  </div>
</template>
<script>
export default {
  data() {
    return {
      showHeaderSpace: false,
    };
  },
  mounted() {
    this.showHeaderSpace = !!this.$refs.header;
    if (this.showHeaderSpace) {
      window.addEventListener("scroll", this.handleScroll);
    }
  },
  beforeUnmount() {
    if (this.showHeaderSpace) {
      window.removeEventListener("scroll", this.handleScroll);
    }
  },
  methods: {
    handleScroll() {
      const scroll =
        window.pageYOffset ||
        document.documentElement.scrollTop ||
        document.body.scrollTop;
      this.showHeaderSpace = scroll > 35;
    },
  },
};
</script>
