<template>
    <div class="main-wrapper">
        <layoutheader></layoutheader>
        <breadcrumb :title="title" :text="text" :text1="text1" />

        <div class="page-wrapper">
            <!-- Pricing -->
            <section class="pricing-section">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12 text-center">
                            <div class="section-inner-header pricing-inner-header">
                                <h2>Our Pricing Plan</h2>
                                <div class="plan-choose-info">
                                    <label class="monthly-plan">Monthly</label>
                                    <div class="status-toggle">
                                        <input type="checkbox" id="status_1" class="check">
                                        <label for="status_1" class="checktoggle">checkbox</label>
                                    </div>
                                    <label class="yearly-plan">Yearly</label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row justify-content-center">
                        <div class="col-lg-4 col-md-6 d-flex">
                            <div class="card pricing-card w-100">
                                <div class="card-body">
                                    <div class="pricing-header">
                                        <div class="pricing-header-info">
                                            <div class="pricing-icon">
                                                <span>
                                                    <img src="@/assets/img/icons/price-icon1.svg" alt="icon">
                                                </span>
                                            </div>
                                            <div class="pricing-title">
                                                <p>For individuals</p>
                                                <h4>Basic</h4>
                                            </div>
                                        </div>
                                        <div class="pricing-header-text">
                                            <p>Lorem ipsum dolor sit amet doloroli sitiol conse ctetur adipiscing elit. </p>
                                        </div>
                                    </div>
                                    <div class="pricing-info">
                                        <div class="pricing-amount">
                                            <h2>$99 <span>/monthly</span></h2>
                                            <h6>What’s included</h6>
                                        </div>
                                        <div class="pricing-list">
                                            <ul>
                                                <li>Lorem ipsum dolor amet, consectetur </li>
                                                <li>Lorem ipsum amet, consectetur </li>
                                                <li>Lorem ipsum dolor amet, consectetur </li>
                                                <li>Lorem ipsum amet, consectetur </li>
                                            </ul>
                                        </div>
                                        <div class="pricing-btn">
                                            <router-link to="/login-email" class="btn btn-primary">Get Started</router-link>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6 d-flex">
                            <div class="card pricing-card w-100">
                                <div class="card-body">
                                    <div class="pricing-header">
                                        <div class="pricing-header-info">
                                            <div class="pricing-icon">
                                                <span>
                                                    <img src="@/assets/img/icons/price-icon2.svg" alt="icon">
                                                </span>
                                            </div>
                                            <div class="pricing-title">
                                                <p>For startups</p>
                                                <h4>Pro</h4>
                                            </div>
                                        </div>
                                        <div class="pricing-header-text">
                                            <p>Lorem ipsum dolor sit amet doloroli sitiol conse ctetur adipiscing elit. </p>
                                        </div>
                                    </div>
                                    <div class="pricing-info">
                                        <div class="pricing-amount">
                                            <h2>$199 <span>/monthly</span></h2>
                                            <h6>What’s included</h6>
                                        </div>
                                        <div class="pricing-list">
                                            <ul>
                                                <li>Lorem ipsum dolor amet, consectetur </li>
                                                <li>Lorem ipsum amet, consectetur </li>
                                                <li>Lorem ipsum dolor amet, consectetur </li>
                                                <li>Lorem ipsum amet, consectetur </li>
                                            </ul>
                                        </div>
                                        <div class="pricing-btn">
                                            <router-link to="/login-email" class="btn btn-primary">Get Started</router-link>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6 d-flex">
                            <div class="card pricing-card w-100">
                                <div class="card-body">
                                    <div class="pricing-header">
                                        <div class="pricing-header-info">
                                            <div class="pricing-icon">
                                                <span>
                                                    <img src="@/assets/img/icons/price-icon3.svg" alt="icon">
                                                </span>
                                            </div>
                                            <div class="pricing-title">
                                                <p>For big companies</p>
                                                <h4>Enterprise</h4>
                                            </div>
                                        </div>
                                        <div class="pricing-header-text">
                                            <p>Lorem ipsum dolor sit amet doloroli sitiol conse ctetur adipiscing elit. </p>
                                        </div>
                                    </div>
                                    <div class="pricing-info">
                                        <div class="pricing-amount">
                                            <h2>$399 <span>/monthly</span></h2>
                                            <h6>What’s included</h6>
                                        </div>
                                        <div class="pricing-list">
                                            <ul>
                                                <li>Lorem ipsum dolor amet, consectetur </li>
                                                <li>Lorem ipsum amet, consectetur </li>
                                                <li>Lorem ipsum dolor amet, consectetur </li>
                                                <li>Lorem ipsum amet, consectetur </li>
                                            </ul>
                                        </div>
                                        <div class="pricing-btn">
                                            <router-link to="/login-email" class="btn btn-primary">Get Started</router-link>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <!-- /Pricing -->
        </div>
    </div>
    <indexfooter></indexfooter>
</template>

<script>
export default {
    data() {
        return {
            title: 'Pricing',
            text: 'Home',
            text1: 'Pricing',
        }
    },
}
</script>