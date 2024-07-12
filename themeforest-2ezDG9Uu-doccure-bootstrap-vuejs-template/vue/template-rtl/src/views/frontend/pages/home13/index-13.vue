<template>
  <div class="main-wrapper home-pg-fourteen">
    <layoutheader :class="{ 'header-space': showHeaderSpace }"/>

    <home13-banner></home13-banner>

    <how-it-work></how-it-work>

    <service-section></service-section>

    <nurse-section></nurse-section>

    <top-nurse-section></top-nurse-section>

    <work-section></work-section>

    <blog-section></blog-section>

    <pricing-section></pricing-section>

    <faq-section></faq-section>

    <indexfooter-section></indexfooter-section>

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
