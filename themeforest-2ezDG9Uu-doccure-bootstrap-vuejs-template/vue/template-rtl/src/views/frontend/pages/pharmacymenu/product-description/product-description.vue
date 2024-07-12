<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="content">
      <div class="container">
        <div class="row">
          <div class="col-md-7 col-lg-9 col-xl-9">
            <!-- Doctor Widget -->
            <div class="card">
              <div class="card-body product-description">
                <div class="doctor-widget">
                  <div class="doc-info-left">
                    <div class="doctor-img1">
                      <img
                        src="@/assets/img/products/product.jpg"
                        class="img-fluid"
                        alt="User Image"
                      />
                    </div>
                    <div class="doc-info-cont">
                      <h4 class="doc-name mb-2">Benzaxapine Croplex</h4>
                      <p>
                        <span class="text-muted">Manufactured By </span> Hamdard (Wakf)
                        Laboratories
                      </p>
                      <p>
                        Lorem Ipsum is simply dummy text of the printing and typesetting
                        industry. Lorem Ipsum has been the industry's standard dummy text
                        ever since the 1500s, when an unknown printer took a galley of
                        type and scrambled
                      </p>
                      <div class="feature-product pt-4">
                        <span>Applied for:</span>
                        <ul>
                          <li>Moisturization & Nourishment</li>
                          <li>Blackhead Removal</li>
                          <li>Anti-acne & Pimples</li>
                          <li>Whitening & Fairness</li>
                        </ul>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <!-- /Doctor Widget -->
            <!-- Doctor Details Tab -->
            <productdetails></productdetails>
            <!-- /Doctor Details Tab -->
          </div>
          <div class="col-md-5 col-lg-3 col-xl-3 theiaStickySidebar">
            <!-- Right Details -->
            <div class="stickysidebar">
              <productdescriptionsidebar></productdescriptionsidebar>
            </div>
            <!-- /Right Details -->
          </div>
        </div>
      </div>
    </div>
    <indexfooter></indexfooter>
  </div>
</template>
<script>
export default {
  data() {
    return {
      title: "Product Description",
      text: "Home",
      text1: "Product Description",
    };
  },
};
</script>
