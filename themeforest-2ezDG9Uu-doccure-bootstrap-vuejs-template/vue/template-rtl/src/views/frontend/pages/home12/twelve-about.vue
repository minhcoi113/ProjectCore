<template>
    <!-- Patient About us -->
    <section class="about-us-section-fifteen client-review-twelve">
        <div class="container">
            <div class="section-head-twelve">
                <h2>Popular Choices </h2>
                <p> Explore Our Top-Tier Packages for Your Personalized Wellness Experience</p>
            </div>
            <div class="row">
                <div class="col-lg-6">
                    <div class="aboutus-img-main">
                        <img src="@/assets/img/aboutus-fift-1.jpg" alt="image" class="img-fluid">
                    </div>
                </div>
                <div class="col-lg-6 position-relative">
                    <div class="swiper-container vertical-slider">
                        <div class="swiper-wrapper" style="height: 506.8px">
                        <div class="swiper-slide"  v-for="item in TwelveAbout" :key="item.id">
                            <div class="aboutus-fifteen-main">
                                <div class="aboutus-profile-left">
                                    <div class="aboutus-image">
                                        <img :src="require(`@/assets/img/clients/${item.Image}`)" alt="Client"
                                            class="img-fluid">
                                    </div>
                                    <div class="aboutus-contents">
                                        <h6>Madeleine Jennifer</h6>
                                        <span>Chennai, Tamilnadu</span>
                                    </div>
                                </div>
                                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                                    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                                    when an unknown printer took a galley of type and scrambled it to make a type
                                    specimen book.</p>
                            </div>
                        </div>
                        </div>
                        <div class="swiper-button-next"></div>
                        <div class="swiper-button-prev"></div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- /Patient About us -->
</template>

<script>
import TwelveAbout from "@/assets/json/twelve-about.json";
import Swiper from "swiper";
import "swiper/css/swiper.css";
export default {
    data() {
        return {
            TwelveAbout: TwelveAbout,
        };
    },
    mounted() {
        const swiper = new Swiper(".vertical-slider", {
            loop: true,
            direction: "vertical",
            slidesPerView: 3,
            pagination: {
                el: ".swiper-pagination",
                clickable: true,
            },
            navigation: {
                nextEl: ".swiper-button-next",
                prevEl: ".swiper-button-prev",
            },
        });
    },
};
</script>