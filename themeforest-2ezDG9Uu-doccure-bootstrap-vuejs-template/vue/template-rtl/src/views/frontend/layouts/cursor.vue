<template>
  <!-- Cursor -->
  <div class="mouse-cursor cursor-outer" ref="cursorOuter"></div>
  <div class="mouse-cursor cursor-inner" ref="cursorInner"></div>
  <!-- /Cursor -->
</template>

<script>
export default {
  mounted() {
    this.$nextTick(() => {
      const cursorInner = this.$refs.cursorInner;
      const cursorOuter = this.$refs.cursorOuter;
      let x = 0;
      let y = 0;

      const onMouseMove = (event) => {
        x = event.clientX;
        y = event.clientY;

        if (!cursorOuter.classList.contains("cursor-hover")) {
          cursorOuter.style.transform = `translate(${x}px, ${y}px)`;
        }
        cursorInner.style.transform = `translate(${x}px, ${y}px)`;
      };

      document.addEventListener("mousemove", onMouseMove);

      this.$el.addEventListener("mouseenter", () => {
        cursorInner.classList.add("cursor-hover");
        cursorOuter.classList.add("cursor-hover");
      });

      this.$el.addEventListener("mouseleave", (event) => {
        if (!event.target.closest("a") || !event.target.closest(".cursor-pointer")) {
          cursorInner.classList.remove("cursor-hover");
          cursorOuter.classList.remove("cursor-hover");
        }
      });

      cursorInner.style.visibility = "visible";
      cursorOuter.style.visibility = "visible";
    });
  },
};
</script>
