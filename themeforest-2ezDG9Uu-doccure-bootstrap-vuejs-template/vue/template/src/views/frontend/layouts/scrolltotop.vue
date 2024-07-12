<template>
  <!-- ScrollToTop -->
  <div
    class="progress-wrap"
    :class="{ 'active-progress': isScrolled }"
    @click="scrollToTop"
  >
    <svg
      class="progress-circle svg-content"
      width="100%"
      height="100%"
      viewBox="-1 -1 102 102"
    >
      <path
        ref="progressPath"
        d="M50,1 a49,49 0 0,1 0,98 a49,49 0 0,1 0,-98"
        :style="`stroke-dasharray: ${pathLength}px, ${pathLength}px; stroke-dashoffset: ${pathOffset}px;`"
      ></path>
    </svg>
  </div>
  <!-- /ScrollToTop -->
</template>

<script>
export default {
  data() {
    return {
      pathLength: 0,
      pathOffset: 0,
      isScrolled: false,
    };
  },
  mounted() {
    this.$nextTick(() => {
      const progressPath = this.$refs.progressPath;
      this.pathLength = progressPath.getTotalLength();
      progressPath.style.transition = progressPath.style.WebkitTransition = "none";
      progressPath.style.strokeDasharray = `${this.pathLength}px ${this.pathLength}px`;
      progressPath.style.strokeDashoffset = this.pathLength;
      progressPath.getBoundingClientRect();
      progressPath.style.transition = progressPath.style.WebkitTransition =
        "stroke-dashoffset 10ms linear";
      this.updateProgress();
    });
    window.addEventListener("scroll", this.updateProgress);
  },
  beforeUnmount() {
    window.removeEventListener("scroll", this.updateProgress);
  },
  methods: {
    updateProgress() {
      const scrollTop =
        window.pageYOffset ||
        document.documentElement.scrollTop ||
        document.body.scrollTop;
      const windowHeight =
        window.innerHeight ||
        document.documentElement.clientHeight ||
        document.body.clientHeight;
      const documentHeight = Math.max(
        document.body.scrollHeight,
        document.documentElement.scrollHeight,
        document.body.offsetHeight,
        document.documentElement.offsetHeight,
        document.body.clientHeight,
        document.documentElement.clientHeight
      );
      const scrollPercentage = (scrollTop / (documentHeight - windowHeight)) * 100;
      this.pathOffset = this.pathLength - (scrollPercentage * this.pathLength) / 100;
      this.isScrolled = scrollTop > 50;
    },
    scrollToTop() {
      window.scrollTo({ top: 0, behavior: "smooth" });
    },
  },
};
</script>
