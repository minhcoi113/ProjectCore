<template>
  <div class="main-wrapper home-sixteen">
    <layoutheader />
    <indexelevenbanner></indexelevenbanner>

    <indexeleventreatment></indexeleventreatment>

    <indexelevenservices></indexelevenservices>

    <indexelevenfacts></indexelevenfacts>

    <indexelevenpricing></indexelevenpricing>

    <indexeleventestimonial></indexeleventestimonial>

    <indexelevenfooter></indexelevenfooter>
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
