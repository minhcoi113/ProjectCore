<template>
  <div id="app">
    <router-view />
  </div>
</template>
<script>
import { loadStyles } from "@/loadStyles";
export default {
  setup() {
    loadStyles();

    // Your other setup logic
    // ...

    return {};
  },
  name: "App",
};
</script>
