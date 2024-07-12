<template>
    <div class="main-wrapper">
        <layoutheader></layoutheader>
        <breadcrumb :title="title" :text="text" :text1="text1" />

        <div class="page-wrapper">
            <!-- Maintenance -->
			<section class="error-section">
				<div class="container">
					<div class="row justify-content-center">
						<div class="col-lg-8 col-md-12 text-center">
							<div class="error-info">
								<div class="error-img">
									<img src="@/assets/img/maintenance.png" class="img-fluid" alt="maintenance-image">
								</div>
								<div class="error-content">
									<h2>We are Under Maintenance.</h2>
									<p>Will be Back Soon!</p>
									<router-link to="/" class="btn btn-primary prime-btn">Back to Home</router-link>
								</div>
							</div>
						</div>
					</div>
				</div>
			</section>
			<!-- /Maintenance -->	
        </div>
    </div>
    <indexfooter></indexfooter>
</template>

<script>
export default {
    data() {
        return {
            title: 'Maintenance',
            text: 'Home',
            text1: 'Maintenance',
        }
    },
}
</script>