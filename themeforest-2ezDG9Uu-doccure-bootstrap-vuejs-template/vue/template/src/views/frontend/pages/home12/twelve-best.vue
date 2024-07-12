<template>
    <!-- Best Packages Section -->
    <section class="best-packages-section">
        <div class="section-bg">
            <img src="@/assets/img/bg/section-bg-03.png" class="best-pack-bg-one" alt="Img">
            <img src="@/assets/img/bg/section-bg-04.png" class="best-pack-bg-two" alt="Img">
        </div>
        <div class="container">
            <div class="section-head-twelve">
                <h2>Best Packages</h2>
                <p> Explore Our Top-Tier Packages for Your Personalized Wellness Experience</p>
            </div>
            <ul class="nav nav-pills inner-tab" id="pills-tab2" role="tablist">
                <li class="nav-item" role="presentation">
                    <button :class="{ active: activeTab === 'pills-all' }" @click="activeTab = 'pills-all'"
                        class="nav-link " type="button">All Packages</button>
                </li>
                <li class="nav-item" role="presentation">
                    <button :class="{ active: activeTab === 'pills-family' }" @click="activeTab = 'pills-family'"
                        class="nav-link" type="button">Family Care</button>
                </li>

                <li class="nav-item" role="presentation">
                    <button :class="{ active: activeTab === 'pills-adult' }" @click="activeTab = 'pills-adult'"
                        class="nav-link" type="button">Adult Care</button>
                </li>
                <li class="nav-item" role="presentation">
                    <button :class="{ active: activeTab === 'pills-accident' }" @click="activeTab = 'pills-accident'"
                        class="nav-link" type="button">Accident Care</button>
                </li>
                <li class="nav-item" role="presentation">
                    <button :class="{ active: activeTab === 'pills-fitness' }" @click="activeTab = 'pills-fitness'"
                        class="nav-link" type="button">Fitness Care</button>
                </li>
                <li class="nav-item" role="presentation">
                    <button :class="{ active: activeTab === 'pills-explore' }" @click="activeTab = 'pills-explore'"
                        class="nav-link" type="button">Explore More</button>
                </li>
            </ul>
            <div class="tab-content pt-0 dashboard-tab">
                <div class="tab-pane" :class="{ active: activeTab === 'pills-all' }" v-if="activeTab === 'pills-all'"
                    id="pills-all">
                    <best-carousel></best-carousel>
                </div>
                <div class="tab-pane" :class="{ active: activeTab === 'pills-family' }" v-if="activeTab === 'pills-family'"
                    id="pills-family">
                    <best-carousel></best-carousel>
                </div>
                <div class="tab-pane" :class="{ active: activeTab === 'pills-adult' }" v-if="activeTab === 'pills-adult'"
                    id="pills-adult">
                    <best-carousel></best-carousel>
                </div>
                <div class="tab-pane" :class="{ active: activeTab === 'pills-accident' }"
                    v-if="activeTab === 'pills-accident'" id="pills-accident">
                    <best-carousel></best-carousel>
                </div>
                <div class="tab-pane" :class="{ active: activeTab === 'pills-fitness' }"
                    v-if="activeTab === 'pills-fitness'" id="pills-fitness">
                    <best-carousel></best-carousel>
                </div>
                <div class="tab-pane" :class="{ active: activeTab === 'pills-explore' }"
                    v-if="activeTab === 'pills-explore'" id="pills-explore">
                    <best-carousel></best-carousel>
                </div>
            </div>
            <div class="how-it-work">
                <div class="section-head-twelve">
                    <h2>How It Works</h2>
                    <p> Uncover the Seamless Process for Easy Navigation and Health Solutions.</p>
                </div>
                <div class="row justify-content-center">
                    <div class="col-lg-4 col-md-6 d-flex">
                        <div class="work-box">
                            <div class="work-icon">
                                <img src="@/assets/img/icons/work-icon-07.svg" alt="Img">
                            </div>
                            <h4>1. Request your test kit</h4>
                            <p>Take the first step to better health – request your test kit. Simple, convenient, and
                                tailored to empower your wellness journey.</p>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6 d-flex">
                        <div class="work-box bg-green">
                            <div class="work-icon">
                                <img src="@/assets/img/icons/work-icon-06.svg" alt="Img">
                            </div>
                            <h4>2. Collect Your Sample</h4>
                            <p> Collect your sample at your convenience with our easy-to-follow instructions. Streamlined
                                and hassle-free, empowering your health from the comfort of home</p>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6 d-flex">
                        <div class="work-box bg-pink">
                            <div class="work-icon">
                                <img src="@/assets/img/icons/work-icon-05.svg" alt="Img">
                            </div>
                            <h4>3. Receive results in days</h4>
                            <p>Expect your test results within days, ensuring a prompt and efficient turnaround. Stay
                                informed and take control of your health journey</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- /Best Packages Section -->
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