<template>
    <div class="doctor-consulting-slider owl-carousel">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
            <Slide v-for="item in TwelveChest" :key="item.id">
                <div class="medical-emergency-card">
                    <div class="row align-items-center">
                        <div class="col-md-6">
                            <div class="slider-img">
                                <img :src="require(`@/assets/img/bg/${item.Image}`)" class="img-fluid" alt="Img">
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="slider-content text-start">
                                <h3>Chest Pain?</h3>
                                <span>Check if you are risk at a Heart Attack</span>
                                <p>Get a test report in an Hour & care your heart at our
                                    Specialist Advice
                                </p>
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
</template>

<script>
import { Carousel, Navigation, Slide } from "vue3-carousel";
import TwelveChest from "@/assets/json/twelve-chest.json";
import "vue3-carousel/dist/carousel.css";
export default {
    data() {
        return {
            TwelveChest: TwelveChest,
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