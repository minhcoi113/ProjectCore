<template>
    <div class="main-wrapper">
		<layoutheader></layoutheader>
        <breadcrumb :title="title" :text="text" :text1="text1" />
        
            <div class="content success-page-cont">
				<div class="container">
				
					<div class="row justify-content-center">
						<div class="col-lg-6">
						
							<!-- Success Card -->
							<div class="card success-card">
								<div class="card-body">
									<div class="success-cont">
										<i class="fas fa-check"></i>
										<h3>Payment Successfully!</h3>
										<p class="mb-0">Product ID: 245468</p>
									</div>
								</div>
							</div>
							<!-- /Success Card -->	
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
            title: "Payment",
            text: "Home",
            text1: "Payment",
        };
    },
};
</script>