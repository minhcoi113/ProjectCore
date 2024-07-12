<template>
  <section class="our-blog-fourteen">
    <div class="section-bg">
      <img src="@/assets/img/bg/blog-bg-14.png" alt="Img" />
    </div>
    <div class="container">
      <div class="section-head-fourteen">
        <h2>Our <span> Blog </span></h2>
        <p>Our latest articles</p>
      </div>
      <ul class="nav nav-pills inner-tab" id="pills-tab" role="tablist">
        <li class="nav-item" role="presentation">
          <button :class="{ active: activeTab === 'pills-all' }" @click="activeTab = 'pills-all'"
            class="nav-link " type="button">
            All Blogs
          </button>
        </li>
        <li class="nav-item" role="presentation">
          <button :class="{ active: activeTab === 'pills-family' }" @click="activeTab = 'pills-family'"
          class="nav-link" type="button">
            Health and Safety
          </button>
        </li>

        <li class="nav-item" role="presentation">
          <button :class="{ active: activeTab === 'pills-adult' }" @click="activeTab = 'pills-adult'"
           class="nav-link"  type="button">
            Caregiving
          </button>
        </li>
        <li class="nav-item" role="presentation">
          <button :class="{ active: activeTab === 'pills-accident' }" @click="activeTab = 'pills-accident'"
           class="nav-link" type="button">
            Food
          </button>
        </li>
        <li class="nav-item" role="presentation">
          <button :class="{ active: activeTab === 'pills-fitness' }" @click="activeTab = 'pills-fitness'"
           class="nav-link" type="button">
            Senior Care
          </button>
        </li>
        <li class="nav-item" role="presentation">
          <button :class="{ active: activeTab === 'pills-explore' }" @click="activeTab = 'pills-explore'"
           class="nav-link" type="button">
            Physiotherapy
          </button>
        </li>
      </ul>
      <div class="tab-content pt-0 dashboard-tab">
        <div class="tab-pane" :class="{ active: activeTab === 'pills-all' }"
          v-if="activeTab === 'pills-all'" id="pills-all">
          <blog-carousel></blog-carousel>
        </div>
        <div class="tab-pane" :class="{ active: activeTab === 'pills-family' }"
          v-if="activeTab === 'pills-family'" id="pills-family">
          <blog-carousel></blog-carousel>
        </div>
        <div class="tab-pane" :class="{ active: activeTab === 'pills-adult' }"
          v-if="activeTab === 'pills-adult'" id="pills-adult">
          <blog-carousel></blog-carousel>
        </div>
        <div class="tab-pane" :class="{ active: activeTab === 'pills-accident' }"
          v-if="activeTab === 'pills-accident'" id="pills-accident">
          <blog-carousel></blog-carousel>
        </div>
        <div class="tab-pane" :class="{ active: activeTab === 'pills-fitness' }"
          v-if="activeTab === 'pills-fitness'" id="pills-fitness">
          <blog-carousel></blog-carousel>
        </div>
        <div class="tab-pane" :class="{ active: activeTab === 'pills-explore' }"
          v-if="activeTab === 'pills-explore'" id="pills-explore">
          <blog-carousel></blog-carousel>
        </div>
        <div class="owl-nav-button">
          <router-link to="blog-grid" class="view-all">View All Blogs</router-link>
        </div>
      </div>
    </div>
  </section>
</template>

<script>
export default {
  data() {
    return {
      activeTab: "pills-all",
    }
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
}
</script>