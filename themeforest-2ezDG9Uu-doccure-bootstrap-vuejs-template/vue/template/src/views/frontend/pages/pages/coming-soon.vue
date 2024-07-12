<template>
    <div class="main-wrapper">
        <layoutheader></layoutheader>
        <breadcrumb :title="title" :text="text" :text1="text1" />

        <div class="page-wrapper">
            <!-- Coming Soon -->
            <section class="error-section">
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-lg-8 col-md-12 text-center">
                            <div class="error-info">
                                <div class="error-img">
                                    <img src="@/assets/img/coming-soon.png" class="img-fluid" alt="coming-soon-image">
                                </div>
                                <div class="error-content">
                                    <h2>We're Launching Soon!</h2>
                                    <p>We're currently working hard on this page.</p>
                                </div>
                                <div class="coming-soon-info">
                                    <div class="coming-soon-count">
                                        <h4 id="day-box">5</h4>
                                        <p>Days</p>
                                    </div>
                                    <div class="coming-soon-count">
                                        <h4 id="hr-box">8</h4>
                                        <p>Hours</p>
                                    </div>
                                    <div class="coming-soon-count">
                                        <h4 id="min-box">48</h4>
                                        <p>Minutes</p>
                                    </div>
                                    <div class="coming-soon-count">
                                        <h4 id="sec-box">20</h4>
                                        <p>Seconds</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <!-- /Coming Soon -->
        </div>
    </div>
    <indexfooter></indexfooter>
</template>

<script>
export default {
    data() {
        return {
            title: 'Coming Soon',
            text: 'Home',
            text1: 'Coming Soon',
        }
    },
}
</script>