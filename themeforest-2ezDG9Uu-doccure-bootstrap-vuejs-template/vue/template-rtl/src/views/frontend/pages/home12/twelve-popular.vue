<template>
    <div class="popular-test-slider owl-carousel">
        <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
            <Slide v-for="item in TwelvePopular" :key="item.id">
                <div class="test-slider-card">
                    <span :class="item.Class"><img :src="require(`@/assets/img/icons/${item.Image}`)" alt="Img"></span>
                    <h4><router-link to="consultation">{{item.Title}}</router-link></h4>
                    <p>A diabetic foot exam can help find problems that can lead to serious infection and ...</p>
                    <router-link to="consultation" class="read-more-test">Read More</router-link>
                </div>
            </Slide>
            <template #addons>
                <Pagination />
            </template>
        </Carousel>
    </div>
</template>

<script>
import { Carousel, Pagination, Slide } from "vue3-carousel";
import TwelvePopular from "@/assets/json/twelve-popular.json";
import "vue3-carousel/dist/carousel.css";
export default {
    data() {
        return {
            TwelvePopular: TwelvePopular,
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
                    itemsToShow: 3,
                    snapAlign: "center",
                },
                1024: {
                    itemsToShow: 4,
                    snapAlign: "start",
                },
            },
        }
    },
    components: {
        Carousel,
        Slide,
        Pagination,
    },
}
</script>