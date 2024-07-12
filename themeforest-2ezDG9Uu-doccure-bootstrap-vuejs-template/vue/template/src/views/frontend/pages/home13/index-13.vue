<template>
  <div class="main-wrapper home-pg-fourteen">
    <layoutheader :class="['header-fifteen']" />

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
      headerBackground: "transparent",
    };
  },
  mounted() {
    window.addEventListener("scroll", this.handleScroll);
  },
  beforeUnmount() {
    window.removeEventListener("scroll", this.handleScroll);
  },
  methods: {
    handleScroll() {
      const scroll =
        window.pageYOffset ||
        document.documentElement.scrollTop ||
        document.body.scrollTop;
      // Update the background color based on the scroll position
      this.headerBackground = scroll > 95 ? "#ffffff" : "transparent";
    },
  },
};
</script>
