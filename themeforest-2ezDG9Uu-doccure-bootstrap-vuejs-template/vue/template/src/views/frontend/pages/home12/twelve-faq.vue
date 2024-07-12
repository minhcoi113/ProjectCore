<template>
    <!-- Popular Choice -->
    <section class="populr-choice-sec">
        <div class="container">
            <div class="section-head-twelve">
                <h2>Popular Choices</h2>
                <p>Explore Our Top-Tier Packages for Your Personalized Wellness Experience</p>
            </div>
            <div class="choice-slider-main">
                <div class="row">
                    <div class="col-md-12">
                        <div class="popular-choice-slider owl-carousel">
                            <Carousel :wrap-around="true" :settings="settings" :breakpoints="breakpoints">
                                <Slide v-for="item in TwelveChoices" :key="item.id">
                                    <div class="popular-choice-card">
                                        <div class="choice-head text-start">
                                            <h4><a href="javascript:void(0);">{{item.Title}}</a></h4>
                                            <h6><span><img src="@/assets/img/icons/gem.svg" alt="Img"></span>{{item.Text}}</h6>
                                        </div>
                                        <ul class="feature-badge">
                                            <li>{{item.Badge}} </li>
                                        </ul>
                                        <div class="package-footer d-flex justify-content-between align-items-center">
                                            <div class="package-cost">
                                                <h5>{{item.Disprice}} <span>{{item.Orgprice}}</span></h5>
                                            </div>
                                            <div class="offer-price">
                                                <span>{{item.Offer}}</span>
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
                <div class="book-lab-phno">
                    <span>Want to Book a Lab Visit, <a href="#"> Call – +1 234 567 90</a></span>
                </div>
            </div>

        </div>
    </section>
    <!-- /Popular Choice -->

    <!-- Faq Sec -->
    <section class="faq-sec-twelve">
        <div class="section-bg">
            <img src="@/assets/img/icons/faq-sec-bg-icon.svg" class="faq-bg-one" alt="Img">
        </div>
        <div class="container">
            <div class="row">
                <div class="col-lg-6 d-flex">
                    <div class="faq-sec-col w-100">
                        <div class="section-head-twelve">
                            <h2>Frequently Asked Qusetions </h2>
                            <p>Know the Questions from our Customers</p>
                        </div>
                        <div class="faq-main-cards" id="accordionExample">
                            <div class="faq-card">
                                <div class="faq-title">
                                    <a data-bs-toggle="collapse" href="#faqOne" aria-expanded="false">
                                        <span>What is an otolaryngologist?</span>
                                        <div id="faqOne" class="card-collapse collapse show"
                                            data-bs-parent="#accordionExample">
                                            <p>An otolaryngologist is a doctor who specializes in the diagnosis and
                                                treatment of ear, nose and throat diseases as well as related structures of
                                                the head and neck. Otolaryngologists are also referred to as ENT doctors or
                                                physicians. For more information</p>
                                        </div>
                                    </a>
                                </div>
                            </div>
                            <div class="faq-card">
                                <div class="faq-title">
                                    <a class="collapsed" data-bs-toggle="collapse" href="#faqtwo" aria-expanded="false">
                                        <span>What is an otolaryngologist?</span>
                                        <div id="faqtwo" class="card-collapse collapse" data-bs-parent="#accordionExample">
                                            <p>An otolaryngologist is a doctor who specializes in the diagnosis and
                                                treatment of ear, nose and throat diseases as well as related structures of
                                                the head and neck. Otolaryngologists are also referred to as ENT doctors or
                                                physicians. For more information</p>
                                        </div>
                                    </a>
                                </div>
                            </div>
                            <div class="faq-card">
                                <div class="faq-title">
                                    <a class="collapsed" data-bs-toggle="collapse" href="#faqthree" aria-expanded="false">
                                        <span>What is an otolaryngologist?</span>
                                        <div id="faqthree" class="card-collapse collapse"
                                            data-bs-parent="#accordionExample">
                                            <p>An otolaryngologist is a doctor who specializes in the diagnosis and
                                                treatment of ear, nose and throat diseases as well as related structures of
                                                the head and neck. Otolaryngologists are also referred to as ENT doctors or
                                                physicians. For more information</p>
                                        </div>
                                    </a>
                                </div>
                            </div>
                            <div class="faq-card">
                                <div class="faq-title">
                                    <a class="collapsed" data-bs-toggle="collapse" href="#faqfour" aria-expanded="false">
                                        <span>What is an otolaryngologist?</span>
                                        <div id="faqfour" class="card-collapse collapse" data-bs-parent="#accordionExample">
                                            <p>An otolaryngologist is a doctor who specializes in the diagnosis and
                                                treatment of ear, nose and throat diseases as well as related structures of
                                                the head and neck. Otolaryngologists are also referred to as ENT doctors or
                                                physicians. For more information</p>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- /Faq Sec-->
</template>

<script>
import TwelveChoices from '@/assets/json/twelve-choices.json'
import { Carousel, Navigation, Slide } from "vue3-carousel";
import "vue3-carousel/dist/carousel.css";

export default {
    data() {
        return {
            TwelveChoices: TwelveChoices,
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
                    itemsToShow: 2,
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
        Navigation,
    },
}
</script>