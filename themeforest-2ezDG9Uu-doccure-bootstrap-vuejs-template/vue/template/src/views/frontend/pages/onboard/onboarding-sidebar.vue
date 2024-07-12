<template>
    <div class="on-board-wizard">
        <ul>
            <li >
                <router-link to="/onboarding-email">
                    <div class="onboarding-progress" :class="{ active: isActive('/onboarding-email') }">
                        <span>1</span>
                    </div>
                    <div class="onboarding-list">
                        <h6>Registration</h6>
                        <p>Enter Details for Register </p>
                    </div>
                </router-link>
            </li>
            <li >
                <router-link to="/onboarding-identity">
                    <div class="onboarding-progress" :class="{ active: isActive('/onboarding-identity') }">
                        <span>2</span>
                    </div>
                    <div class="onboarding-list">
                        <h6>Upload Identity</h6>
                        <p>Upload your Identity for Verification</p>
                    </div>
                </router-link>
            </li>
            <li >
                <router-link to="/onboarding-personalize">
                    <div class="onboarding-progress" :class="{ active: isActive('/onboarding-personalize') }">
                        <span>3</span>
                    </div>
                    <div class="onboarding-list">
                        <h6>Personal Details</h6>
                        <p>Enter your Personal Details</p>
                    </div>
                </router-link>
            </li>
            <li >
                <router-link to="/onboarding-verification">
                    <div class="onboarding-progress" :class="{ active: isActive('/onboarding-verification') }">
                        <span>4</span>
                    </div>
                    <div class="onboarding-list">
                        <h6>Doctor Verification</h6>
                        <p>Upload Documents for the Verification</p>
                    </div>
                </router-link>
            </li>
            <li >
                <router-link to="/onboarding-payments">
                    <div class="onboarding-progress" :class="{ active: isActive('/onboarding-payments') }">
                        <span>5</span>
                    </div>
                    <div class="onboarding-list">
                        <h6>Payment details</h6>
                        <p>Setup Your Payment Details</p>
                    </div>
                </router-link>
            </li>
            <li >
                <router-link to="/onboarding-preferences">
                    <div class="onboarding-progress" :class="{ active: isActive('/onboarding-preferences') }">
                        <span>6</span>
                    </div>
                    <div class="onboarding-list">
                        <h6>Preferences</h6>
                        <p>Setup Your Preferences for your Account</p>
                    </div>
                </router-link>
            </li>
        </ul>
    </div>
</template>

<script>
export default {
    data() {
        return {
            activeClass: "active",
        }
    },
    methods: {
    isActive(paths) {
      return paths.includes(this.$route.path);
    },
  },
}
</script>