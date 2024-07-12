<template>
    <div class="row">
        <div class="col-md-12">
            <div class="best-package-slider owl-carousel">
                <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
                    <Slide v-for="item in BestCarousel" :key="item.id">
                        <div class="best-package-card">
                            <div class="package-card-top">
                                <div class="card-img-right">
                                    <img :src="require(`@/assets/img/icons/${item.Sticker}`)" :class="item.Class" alt="Img">
                                </div>
                                <div class="package-icon">
                                    <img :src="require(`@/assets/img/icons/${item.Package}`)" alt="Img">
                                </div>
                                <h3><router-link to="consultation">{{ item.title }}</router-link></h3>
                                <p>A diabetic foot exam can help find problems that can lead to serious infection
                                    and ...</p>
                                <ul class="feature-badge">
                                    <li>{{ item.Badgeone }}</li>
                                    <li>{{ item.BadgeTwo }} </li>
                                </ul>
                                <div class="package-footer d-flex justify-content-between align-items-center">
                                    <div class="package-cost">
                                        <h5>$150.25 <span> $199.00</span></h5>
                                    </div>
                                    <div class="package-btn">
                                        <router-link to="booking-2">Book Now</router-link>
                                    </div>
                                </div>
                            </div>
                            <div class="package-card-differ overlay-card" data-aos="fade-up" data-aos-delay="700">
                                <h3><router-link to="consultation">Urine Analysis</router-link></h3>
                                <p>Allergy testing can be useful at different stages of life, like discovering that
                                    a family member...</p>
                                <ul class="features-list">
                                    <li><span><i class="fa-solid fa-check"></i></span>Upload Prescription</li>
                                    <li><span><i class="fa-solid fa-check"></i></span>Complete Blood Count </li>
                                    <li><span><i class="fa-solid fa-check"></i></span>Series Blood Tests </li>
                                    <li><span><i class="fa-solid fa-check"></i></span>Hormone Shots </li>
                                    <li><span><i class="fa-solid fa-check"></i></span>Transactions Lists</li>
                                </ul>
                                <div class="package-footer">
                                    <div class="package-btn">
                                        <router-link to="booking-2">Book Now</router-link>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </Slide>
                    <template #addons>
                        <Pagination />
                    </template>
                </Carousel>
            </div>
        </div>
    </div>
</template>

<script>
import { Carousel, Pagination, Slide } from "vue3-carousel";
import BestCarousel from "@/assets/json/best-carousel.json";
import "vue3-carousel/dist/carousel.css";
export default {
    data() {
        return {
            BestCarousel: BestCarousel,
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
        Pagination,
    },
}
</script>