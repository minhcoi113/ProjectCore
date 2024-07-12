<template>
   <div class="breadcrumb-bar-two">
            <div class="container">
                <div class="row align-items-center inner-banner">
                    <div class="col-md-12 col-12 text-center">
                        <h2 class="breadcrumb-title">{{ title }}</h2>
                        <nav aria-label="breadcrumb" class="page-breadcrumb">
                            <ol class="breadcrumb">
                                <li class="breadcrumb-item"><router-link to="/">{{ text }}</router-link></li>
                                <li class="breadcrumb-item" aria-current="page">{{text1  }}</li>
                            </ol>
                        </nav>
                    </div>
                </div>
            </div>
        </div> 
</template>
<script>
export default {
    props: {
        title: {
            type: String,
            default: "",
        },
        text: {
            type: String,
            default: "",
        },
        text1: {
            type: String,
            default: "",
        },
    
    }  
}
</script>
