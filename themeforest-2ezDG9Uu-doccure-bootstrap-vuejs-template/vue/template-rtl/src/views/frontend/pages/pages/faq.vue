<template>
    <div class="main-wrapper">
        <layoutheader></layoutheader>
        <breadcrumb :title="title" :text="text" :text1="text1" />

        <div class="page-wrapper">
            <!-- FAQ Section -->
            <section class="faq-inner-page">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="section-inner-header text-center">
                                <h2>Frequently Asked Questions</h2>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-6 col-md-6">
                            <div class="faq-info faq-inner-info">
                                <div class="accordion" id="faq-details">

                                    <!-- FAQ Item -->
                                    <div class="accordion-item" v-for="item in FaqOne" :key="item.id">
                                        <h2 class="accordion-header" :id="item.Text">
                                            <a href="javascript:void(0)" class="accordion-button collapsed"
                                                data-bs-toggle="collapse" :data-bs-target="item.Target"
                                                aria-expanded="false" :aria-controls="item.TargetId">
                                                {{ item.Title }}
                                            </a>
                                        </h2>
                                        <div :id="item.TargetId" class="accordion-collapse collapse"
                                            :aria-labelledby="item.Text" data-bs-parent="#faq-details">
                                            <div class="accordion-body">
                                                <div class="accordion-content">
                                                    <p>{{ item.Content }}</p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- /FAQ Item -->

                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6">
                            <div class="faq-info faq-inner-info">
                                <div class="accordion" id="faq-details-info">

                                    <!-- FAQ Item -->
                                    <div class="accordion-item" v-for="item in FaqTwo" :key="item.id">
                                        <h2 class="accordion-header" :id="item.Text">
                                            <a href="javascript:void(0)" class="accordion-button collapsed"
                                                data-bs-toggle="collapse" :data-bs-target="item.Target"
                                                aria-expanded="false" :aria-controls="item.TargetId">
                                                {{item.Title}}
                                            </a>
                                        </h2>
                                        <div :id="item.TargetId" class="accordion-collapse collapse"
                                        :aria-labelledby="item.Text" data-bs-parent="#faq-details-info">
                                            <div class="accordion-body">
                                                <div class="accordion-content">
                                                    <p>{{ item.Content }} </p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- /FAQ Item -->

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <!-- /FAQ Section -->
        </div>
    </div>
    <indexfooter></indexfooter>
</template>

<script>
import FaqOne from '@/assets/json/faqone.json'
import FaqTwo from '@/assets/json/faqtwo.json'
export default {
    data() {
        return {
            title: 'FAQ',
            text: 'Home',
            text1: 'FAQ',
            FaqOne: FaqOne,
            FaqTwo: FaqTwo
        }
    },
}
</script>