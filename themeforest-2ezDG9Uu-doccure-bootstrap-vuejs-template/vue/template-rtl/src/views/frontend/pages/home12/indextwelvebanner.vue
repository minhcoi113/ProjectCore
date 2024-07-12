<template>
    <!-- Home Banner -->
    <section class="banner-sec-twelve">
        <div class="section-small-imgs">
            <img src="@/assets/img/icons/section-small-icon-01.svg" class="small-icon-one" alt="Img">
            <img src="@/assets/img/icons/section-small-icon-02.svg" class="small-icon-two" alt="Img">
        </div>
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-lg-8">
                    <div class="banner-content-twelve">
                        <div class="banner-title-twelve">
                            <h1>Now Book Lab Tests <br> at Home</h1>
                            <p>Comprehensive Lab Testing for Informed Well-being</p>
                        </div>
                        <form action="search">
                            <div class="input-box-twelve">
                                <div class="input-block">
                                    <vue-select :options="Speciality" id="speciality" placeholder="Select Speciality" />
                                </div>
                                <div class="input-block">
                                    <vue-select :options="UK" id="uk" placeholder="Choose City" />
                                </div>
                                <div class="input-block">
                                    <div class="search-btn-twelve">
                                        <router-link to="search-2">Search Now</router-link>
                                    </div>
                                </div>

                            </div>
                        </form>
                        <div class="banner-counter">
                            <div class="row justify-content-center">
                                <div class="col-md-4 col-sm-6">
                                    <div class="counter-twelve bg-purple-color">
                                        <span class="hexagon"></span>
                                        <h3><span class="counter">985</span>+</h3>
                                        <h5>Collection points</h5>
                                    </div>
                                </div>
                                <div class="col-md-4 col-sm-6">
                                    <div class="counter-twelve bg-violet-color">
                                        <span class="hexagon"></span>
                                        <h3><span class="counter">1</span>M+</h3>
                                        <h5>Reports Delivered</h5>
                                    </div>
                                </div>
                                <div class="col-md-4 col-sm-6">
                                    <div class="counter-twelve bg-blue-color">
                                        <span class="hexagon"></span>
                                        <h3><span class="counter">150</span>+</h3>
                                        <h5>Expert Specialists</h5>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="view-all-lab" data-aos="fade-up">
                            <span><img src="@/assets/img/icons/lab-view-icon.svg" alt="Img"></span>
                            <h5>View all Offers on Lab tests !!!</h5>
                        </div>
                    </div>

                </div>
                <div class="col-lg-4 col-md-6 col-sm-6 col-10">
                    <div class="swiper swiper-slider-banner">
                        <div class="swiper-wrapper">
                            <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
                                <Slide v-for="item in TwelveBanner" :key="item.id">
                                    <!-- Swiper Slide -->
                                    <div class="swiper-slide">
                                        <div class="img-swiper">
                                            <router-link to="consultation"><img
                                                    :src="require(`@/assets/img/slider/${item.Image}`)" class="img-fluid"
                                                    alt="Img"></router-link>
                                        </div>
                                        <div class="swiper-content-card text-end">
                                            <h4><router-link to="consultation">{{ item.Title }}</router-link></h4>
                                            <span class="badge">{{ item.Content }}</span>
                                            <div class="cost-pay">
                                                <h5>{{ item.Disprice }}<span>{{ item.Orgprice }}</span></h5>
                                                <router-link to="booking-2" class="slider-buy-btn">Book Now</router-link>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- /Swiper Slide -->
                                </Slide>
                                <template #addons>
                                    <Navigation />
                                </template>
                            </Carousel>
                        </div>
                        <div class="testimonial-bottom-nav">
                            <div class="slide-next-btn testimonial-next-pre"><i class="fas fa-arrow-left"></i></div>
                            <div class="slide-prev-btn testimonial-next-pre"><i class="fas fa-arrow-right"></i></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- /Home Banner -->

    <!-- Popular Test Section -->
    <section class="popular-test-section">
        <div class="section-small-imgs">
            <img src="@/assets/img/bg/section-bg-01.jpg" class="bg-img-one" alt="Img">
            <img src="@/assets/img/bg/section-bg-02.png" class="bg-img-two" alt="Img">
        </div>
        <div class="container">
            <div class="section-head-twelve">
                <h2>Popular Tests</h2>
                <p>Discover Our Popular Lab Tests, Unlock Key Health Insights with Trusted Diagnostic Services.</p>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <twelve-popular></twelve-popular>
                </div>
            </div>

            <div class="medical-emergency-booking">
                <twelve-chest></twelve-chest>
            </div>
            <div class="medical-descriptions">
                <div class="row">
                    <div class="col-xl-3 col-md-4 col-sm-6">
                        <div class="description-item">
                            <span><img src="@/assets/img/icons/medical-icon-01.svg" alt="Img"></span>
                            <h4><a href="javascript:void(0);">Health Packages</a></h4>
                        </div>
                    </div>
                    <div class="col-xl-3 col-md-4 col-sm-6">
                        <div class="description-item">
                            <span><img src="@/assets/img/icons/medical-icon-02.svg" alt="Img"></span>
                            <h4><a href="javascript:void(0);">All Tests</a></h4>
                        </div>
                    </div>
                    <div class="col-xl-3 col-md-4 col-sm-6">
                        <div class="description-item">
                            <span><img src="@/assets/img/icons/medical-icon-03.svg" alt="Img"></span>
                            <h4><a href="javascript:void(0);">Book a Call</a></h4>
                        </div>
                    </div>
                    <div class="col-xl-3 col-md-4 col-sm-6">
                        <div class="description-item">
                            <span><img src="@/assets/img/icons/medical-icon-04.svg" alt="Img"></span>
                            <h4><a href="javascript:void(0);">Upload Prescription</a></h4>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </section>
    <!-- /Popular Test Section -->
</template>

<script>
import TwelveBanner from '@/assets/json/twelve-banner.json'
import { Carousel, Navigation, Slide } from "vue3-carousel";
import "vue3-carousel/dist/carousel.css";

export default {
    data() {
        return {
            Speciality: ["Select Speciality", "Cardiology", "Neurology", "Urology"],
            UK: ["Choose City", "UK", "USA"],
            TwelveBanner: TwelveBanner,
            settings: {
                itemsToShow: 1,
                snapAlign: "center",
            },
            breakpoints: {
                575: {
                    itemsToShow: 1,
                    snapAlign: "center",
                },
                767: {
                    itemsToShow: 1,
                    snapAlign: "center",
                },
                991: {
                    itemsToShow: 1,
                    snapAlign: "center",
                },
                1024: {
                    itemsToShow: 1,
                    snapAlign: "start",
                },
            },
        }
    },
    components: {
        Carousel,
        Slide,
        Navigation,
    },
}

</script>