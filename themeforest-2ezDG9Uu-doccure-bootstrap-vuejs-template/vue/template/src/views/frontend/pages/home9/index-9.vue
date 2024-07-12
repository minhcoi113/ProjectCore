<template>
  <div class="main-wrapper home-fourteen">
    <layoutheader
      :class="['header-fourteen']"
      :style="{ background: headerBackground }"
    />
    <indexninebanner></indexninebanner>

    <indexnineteam></indexnineteam>

    <indexnineblog></indexnineblog>

    <indexninechoose></indexninechoose>

    <indexninecontent></indexninecontent>

    <indexninefooter></indexninefooter>
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
      this.headerBackground = scroll > 95 ? "#2b6ccb" : "transparent";
    },
  },
};
</script>
