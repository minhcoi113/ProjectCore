<template>
    <!-- Pricing Sec -->
    <section class="pricing-sec-twelve">
        <div class="container">
            <div class="section-head-twelve">
                <div class="title-head-twelve">
                    <h2>Our Pricing </h2>
                    <p> Choose the package that best suit you</p>
                </div>
                <ul class="nav nav-pills inner-tab " id="pills-tab" role="tablist">
                    <li class="nav-item" role="presentation">
                        <button class="nav-link active" id="pills-monthly-tab" data-bs-toggle="pill"
                            data-bs-target="#pills-monthly" type="button" role="tab" aria-controls="pills-monthly"
                            aria-selected="false">Monthly</button>
                    </li>
                    <li class="nav-item" role="presentation">
                        <button class="nav-link" id="pills-yearly-tab" data-bs-toggle="pill" data-bs-target="#pills-yearly"
                            type="button" role="tab" aria-controls="pills-yearly" aria-selected="true">yearly</button>
                    </li>
                </ul>
            </div>
            <div class="tab-content pt-0 dashboard-tab">
                <div class="tab-pane fade show active" id="pills-monthly" role="tabpanel"
                    aria-labelledby="pills-monthly-tab">
                    <div class="row justify-content-center">
                        <div class="col-lg-4 col-md-6">
                            <div class="pricing-card-twelve">
                                <div class="icon-price">
                                    <span><img src="@/assets/img/icons/price-icon-06.svg" alt="Img"></span>
                                    <h5>Free</h5>
                                </div>
                                <div class="cost-price">
                                    <span>$0</span>
                                    <h6>per month</h6>
                                </div>
                                <ul class="price-feature-first">
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>500
                                        Conversations
                                        p/m</li>
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>50 Websites
                                    </li>
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>20 GB Data
                                        Storage</li>
                                </ul>
                                <ul class="price-features-second">
                                    <li><span><i class="feather-plus"></i></span>Everything Off </li>
                                    <li><span><i class="feather-plus"></i></span>Chat Widget</li>
                                    <li><span><i class="feather-plus"></i></span>Real Time Support</li>
                                </ul>
                                <div class="booking-button text-center">
                                    <router-link to="booking" class="btn btn-primary w-100">Book Now</router-link>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6">
                            <div class="pricing-card-twelve active">
                                <div class="icon-price">
                                    <span><img src="@/assets/img/icons/price-icon-05.svg" alt="Img"></span>
                                    <h5>Essential</h5>
                                    <div class="sticker-ribbon"><img src="@/assets/img/icons/price-sticker-ribbon.svg"
                                            alt="">
                                    </div>
                                </div>
                                <div class="cost-price">
                                    <span>$50</span>
                                    <h6>per month</h6>
                                </div>
                                <ul class="price-feature-first">
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>500
                                        Conversations
                                        p/m</li>
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>80 Websites
                                    </li>
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>25 GB Data
                                        Storage</li>
                                </ul>
                                <ul class="price-features-second">
                                    <li><span><i class="feather-plus"></i></span>Everything Off </li>
                                    <li><span><i class="feather-plus"></i></span>Chat Widget</li>
                                    <li><span><i class="feather-plus"></i></span>Real Time Support</li>
                                </ul>
                                <div class="booking-button text-center">
                                    <router-link to="booking" class="btn btn-primary w-100">Book Now</router-link>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6">
                            <div class="pricing-card-twelve">
                                <div class="icon-price">
                                    <span><img src="@/assets/img/icons/price-icon-04.svg" alt="Img"></span>
                                    <h5>Team</h5>
                                </div>
                                <div class="cost-price">
                                    <span>$200</span>
                                    <h6>per month</h6>
                                </div>
                                <ul class="price-feature-first">
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>Unlimited
                                        Conversations p/m</li>
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>100 Websites
                                    </li>
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>30 GB Data
                                        Storage</li>
                                </ul>
                                <ul class="price-features-second">
                                    <li><span><i class="feather-plus"></i></span>Everything Off </li>
                                    <li><span><i class="feather-plus"></i></span>Chat Widget</li>
                                    <li><span><i class="feather-plus"></i></span>Real Time Support</li>
                                </ul>
                                <div class="booking-button text-center">
                                    <router-link to="booking" class="btn btn-primary w-100">Book Now</router-link>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="tab-pane fade" id="pills-yearly" role="tabpanel" aria-labelledby="pills-yearly-tab">
                    <div class="row justify-content-center">
                        <div class="col-lg-4 col-md-6">
                            <div class="pricing-card-twelve">
                                <div class="icon-price">
                                    <span><img src="@/assets/img/icons/price-icon-06.svg" alt="Img"></span>
                                    <h5>Free</h5>
                                </div>
                                <div class="cost-price">
                                    <span>$0</span>
                                    <h6>per month</h6>
                                </div>
                                <ul class="price-feature-first">
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>500
                                        Conversations
                                        p/m</li>
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>50 Websites
                                    </li>
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>20 GB Data
                                        Storage</li>
                                </ul>
                                <ul class="price-features-second">
                                    <li><span><i class="feather-plus"></i></span>Everything Off </li>
                                    <li><span><i class="feather-plus"></i></span>Chat Widget</li>
                                    <li><span><i class="feather-plus"></i></span>Real Time Support</li>
                                </ul>
                                <div class="booking-button text-center">
                                    <router-link to="booking" class="btn btn-primary w-100">Book Now</router-link>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6">
                            <div class="pricing-card-twelve active">
                                <div class="icon-price">
                                    <span><img src="@/assets/img/icons/price-icon-05.svg" alt="Img"></span>
                                    <h5>Essential</h5>
                                    <div class="sticker-ribbon"><img src="@/assets/img/icons/price-sticker-ribbon.svg"
                                            alt="">
                                    </div>
                                </div>
                                <div class="cost-price">
                                    <span>$50</span>
                                    <h6>per month</h6>
                                </div>
                                <ul class="price-feature-first">
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>500
                                        Conversations
                                        p/m</li>
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>80 Websites
                                    </li>
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>25 GB Data
                                        Storage</li>
                                </ul>
                                <ul class="price-features-second">
                                    <li><span><i class="feather-plus"></i></span>Everything Off </li>
                                    <li><span><i class="feather-plus"></i></span>Chat Widget</li>
                                    <li><span><i class="feather-plus"></i></span>Real Time Support</li>
                                </ul>
                                <div class="booking-button text-center">
                                    <router-link to="booking" class="btn btn-primary w-100">Book Now</router-link>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6">
                            <div class="pricing-card-twelve">
                                <div class="icon-price">
                                    <span><img src="@/assets/img/icons/price-icon-04.svg" alt="Img"></span>
                                    <h5>Team</h5>
                                </div>
                                <div class="cost-price">
                                    <span>$200</span>
                                    <h6>per month</h6>
                                </div>
                                <ul class="price-feature-first">
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>Unlimited
                                        Conversations p/m</li>
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>100 Websites
                                    </li>
                                    <li><span><img src="@/assets/img/icons/heart-pulse.svg" alt="Img"></span>30 GB Data
                                        Storage</li>
                                </ul>
                                <ul class="price-features-second">
                                    <li><span><i class="feather-plus"></i></span>Everything Off </li>
                                    <li><span><i class="feather-plus"></i></span>Chat Widget</li>
                                    <li><span><i class="feather-plus"></i></span>Real Time Support</li>
                                </ul>
                                <div class="booking-button text-center">
                                    <router-link to="booking" class="btn btn-primary w-100">Book Now</router-link>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
            <div class="various-logo-sec">
                <div class="row">
                    <div class="col-md-12">
                        <div class="various-logo-slider owl-carousel">
                            <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
                                <Slide v-for="item in TwelvePricing" :key="item.id">
                                    <div class="logo-img-slide">
                                        <img :src="require(`@/assets/img/icons/${item.Image}`)" class="img-fluid" alt="">
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
        </div>
    </section>
    <!-- Pricing Sec -->
</template>

<script>
import TwelvePricing from '@/assets/json/twelve-pricing.json'
import { Carousel, Navigation, Slide } from "vue3-carousel";
import "vue3-carousel/dist/carousel.css";

export default {
    data() {
        return {
            TwelvePricing: TwelvePricing,
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
                    itemsToShow: 3,
                    snapAlign: "center",
                },
                991: {
                    itemsToShow: 4,
                    snapAlign: "start",
                },
                1024: {
                    itemsToShow: 6,
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