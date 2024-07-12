<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="page-wrapper">
      <!-- Error 404 -->
      <section class="error-section">
        <div class="container">
          <div class="row justify-content-center">
            <div class="col-lg-8 col-md-12 text-center">
              <div class="error-info">
                <div class="error-404-img">
                  <img
                    src="@/assets/img/error-404.png"
                    class="img-fluid"
                    alt="error-404-image"
                  />
                  <div class="error-content error-404-content">
                    <h2>Oops! That Page Can’t Be Found.</h2>
                    <p>The page you are looking for was never existed.</p>
                    <router-link to="/" class="btn btn-primary prime-btn"
                      >Back to Home</router-link
                    >
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
      <!-- /Error 404 -->
    </div>
    <indexfooter></indexfooter>
  </div>
</template>

<script>
export default {
  data() {
    return {
      title: "Error 404",
      text: "Home",
      text1: "Error 404",
    };
  },
};
</script>
