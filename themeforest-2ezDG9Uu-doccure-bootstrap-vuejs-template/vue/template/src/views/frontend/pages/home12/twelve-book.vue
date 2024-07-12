<template>
    <!-- Booking Lab Test -->
    <section class="booking-lab-test-sec">
        <div class="section-bg">
            <img src="@/assets/img/icons/book-lab-bg-01.svg" class="best-pack-bg-one" alt="Img">
            <img src="@/assets/img/icons/book-lab-bg-02.svg" class="best-pack-bg-two" alt="Img">
        </div>
        <div class="container">
            <div class="section-head-twelve">
                <h2>Recent Booked Lab test</h2>
                <p> Uncover the Seamless Process for Easy Navigation and Health Solutions.</p>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <div class="booking-lab-test-slider owl-carousel">
                        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
                            <Slide v-for="item in TwelveBook" :key="item.id">
                                <div class="booking-lab-grid">
                                    <div class="booking-lab-img">
                                        <router-link to="consultation"><img :src="require(`@/assets/img/blog/${item.Image}`)"
                                                class="img-fluid" alt="Img"></router-link>
                                    </div>
                                    <div class="booking-lab-content text-start">
                                        <ul class="feature-badge">
                                            <li>Includes 90 Parameters</li>
                                            <li>Includes 20 tests </li>
                                        </ul>
                                        <h4><router-link to="consultation">{{item.Title}}</router-link></h4>
                                        <p>Confidential Pregnancy Testing, Accurate and Timely Results for Your Peace of
                                            Mind</p>
                                        <div class="package-footer d-flex justify-content-between align-items-center">
                                            <div class="package-cost">
                                                <h5>{{item.Disprice}}<span>{{item.Orgprice}}</span></h5>
                                            </div>
                                            <div class="package-btn">
                                                <router-link to="booking-2">Book Now</router-link>
                                            </div>
                                        </div>
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
    <!-- /Booking Lab Test -->
</template>

<script>
import TwelveBook from '@/assets/json/twelve-book.json'
import { Carousel, Navigation, Slide } from "vue3-carousel";
import "vue3-carousel/dist/carousel.css";

export default {
    data() {
        return {
            TwelveBook: TwelveBook,
            settings: {
                itemsToShow: 1,
                snapAlign: "center",
            },
            breakpoints: {
                575: {
                    itemsToShow: 2,
                    snapAlign: "start",
                },
                767: {
                    itemsToShow: 2,
                    snapAlign: "start",
                },
                991: {
                    itemsToShow: 2,
                    snapAlign: "start",
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