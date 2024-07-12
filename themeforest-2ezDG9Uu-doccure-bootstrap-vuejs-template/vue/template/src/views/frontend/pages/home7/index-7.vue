<template>
  <div class="main-wrapper home-twelve">
    <layoutheader :style="{ background: headerBackground }" />
    <indexsevenbanner></indexsevenbanner>
    <indexsevenfeedback></indexsevenfeedback>
    <indexsevenfooter></indexsevenfooter>
    <cursor />
  </div>
  <scrolltotop />
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
      if (scroll > 95) {
        this.headerBackground = "#fff";
      } else {
        this.headerBackground = "transparent";
      }
    },
  },
};
</script>
