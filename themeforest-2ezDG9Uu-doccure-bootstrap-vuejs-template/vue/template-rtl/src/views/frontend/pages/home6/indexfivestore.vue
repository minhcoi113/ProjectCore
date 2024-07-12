<template>
  <!-- Store Section -->
  <section class="store-section">
    <div class="container">
      <div class="row">
        <div class="col-md-12 aos" data-aos="fade-up">
          <div class="section-heading text-center sec-heading-eye">
            <img src="@/assets/img/icons/eye-icon.svg" alt="eye-icon" class="img-fluid" />
            <h2><span>Our</span> Store</h2>
            <p>Great Reasons For People Choose Doccure Store</p>
          </div>
          <ul class="store-tab nav">
            <li>
              <a
                href="javascript:;"
                :class="{ active: activeTab === 'eyeglass' }"
                @click="activeTab = 'eyeglass'"
                >Eye Glasses</a
              >
            </li>
            <li>
              <a
                href="javascript:;"
                :class="{ active: activeTab === 'computer' }"
                @click="activeTab = 'computer'"
                >Computer Glasses</a
              >
            </li>
            <li>
              <a
                href="javascript:;"
                :class="{ active: activeTab === 'kids' }"
                @click="activeTab = 'kids'"
                >Kids Glasses</a
              >
            </li>
            <li>
              <a
                href="javascript:;"
                :class="{ active: activeTab === 'lense' }"
                @click="activeTab = 'lense'"
                >Contact Lenses</a
              >
            </li>
            <li>
              <a
                href="javascript:;"
                :class="{ active: activeTab === 'sunglass' }"
                @click="activeTab = 'sunglass'"
                >Sunglasses</a
              >
            </li>
            <li>
              <a
                href="javascript:;"
                :class="{ active: activeTab === 'readingglass' }"
                @click="activeTab = 'readingglass'"
                >Reading Glasses</a
              >
            </li>
          </ul>
        </div>
      </div>
      <div class="tab-content">
        <!-- Eye Glass -->
        <div
          class="tab-pane"
          :class="{ active: activeTab === 'eyeglass' }"
          id="eyeglass"
          v-if="activeTab === 'eyeglass'"
        >
          <eyeglass></eyeglass>
        </div>
        <!-- /Eye Glass -->

        <!-- Computer Glass -->
        <div
          class="tab-pane"
          :class="{ active: activeTab === 'computer' }"
          id="computer"
          v-if="activeTab === 'computer'"
        >
          <computerglass></computerglass>
        </div>
        <!-- /Computer Glass -->
        <!-- Kids Glass -->
        <div
          class="tab-pane"
          :class="{ active: activeTab === 'kids' }"
          id="kids"
          v-if="activeTab === 'kids'"
        >
          <kidsglass></kidsglass>
        </div>
        <!-- /Kids Glass -->

        <!-- Lense Glass -->
        <div
          class="tab-pane"
          :class="{ active: activeTab === 'lense' }"
          id="lense"
          v-if="activeTab === 'lense'"
        >
          <lenseglass></lenseglass>
        </div>
        <!-- /Lense Glass -->

        <!-- Sunglass Glass -->
        <div
          class="tab-pane"
          :class="{ active: activeTab === 'sunglass' }"
          id="sunglass"
          v-if="activeTab === 'sunglass'"
        >
          <sunglass></sunglass>
        </div>
        <!-- /Sun Glass -->

        <!-- Reading Glass -->
        <div
          class="tab-pane"
          :class="{ active: activeTab === 'readingglass' }"
          id="readingglass"
          v-if="activeTab === 'readingglass'"
        >
          <readingglass></readingglass>
        </div>
        <!-- /Reading Glass -->
      </div>
    </div>
    <div class="ban-bg">
      <img src="@/assets/img/bg/store-bg-01.png" alt="eye-icon" class="img-fluid bg-10" />
    </div>
  </section>
  <!-- /Store Section -->
</template>
<script>
import AOS from "aos";
import "aos/dist/aos.css";
export default {
  data() {
    return {
      activeTab: "eyeglass",
    };
  },

  watch: {
    activeTab() {
      this.$nextTick(() => {
        const carousel = this.$refs.carousel;
        if (carousel) {
          carousel.restart();
        }
      });
    },
  },
  mounted() {
    this.$nextTick(() => {
      AOS.init();
    });
  },
};
</script>
