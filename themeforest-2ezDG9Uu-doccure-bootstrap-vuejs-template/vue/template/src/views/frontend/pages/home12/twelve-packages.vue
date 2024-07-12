<template>
    <!-- Feature Packages Section -->
    <section class="features-section-sixteen">
        <div class="container">
            <div class="section-head-twelve">
                <h2>Featured Packages</h2>
                <p> Explore Our Top-Tier Packages for Your Personalized Wellness Experience</p>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <div class="owl-carousel feature-package-slider">
                        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
                            <Slide v-for="item in TwelvePackages" :key="item.id">
                                <div :class="item.Class">
                                    <div class="feature-package-type text-start">
                                        <h3>{{ item.Title }}</h3>
                                        <div class="package-cost">
                                            <h6>{{ item.text }}</h6>
                                            <h5>{{ item.Disprice }}<span>{{ item.Orgprice }}</span></h5>
                                        </div>
                                        <router-link to="booking-2" class="package-book-btn">Book Now</router-link>
                                    </div>
                                    <div class="package-img">
                                        <img :src="require(`@/assets/img/features/${item.Image}`)" class="package-img-user"
                                            alt="Img">
                                        <img :src="require(`@/assets/img/bg/${item.Background}`)" class="package-img-bg"
                                            alt="Img">
                                    </div>
                                </div>
                            </Slide>
                            <template #addons>
                                <Navigation />
                            </template>
                        </Carousel>
                    </div>
                </div>
            </div>

        </div>
    </section>
    <!-- /Feature Packages Section -->
</template>


<script>
import { Carousel, Navigation, Slide } from "vue3-carousel";
import TwelvePackages from "@/assets/json/twelve-packages.json";
import "vue3-carousel/dist/carousel.css";
export default {
    data() {
        return {
            TwelvePackages: TwelvePackages,
            settings: {
                itemsToShow: 1,
                snapAlign: "center",
            },
            breakpoints: {
                575: {
                    itemsToShow: 2,
                    snapAlign: "center",
                },
                767: {
                    itemsToShow: 1,
                    snapAlign: "center",
                },
                991: {
                    itemsToShow: 3,
                    snapAlign: "center",
                },
                1024: {
                    itemsToShow: 3,
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