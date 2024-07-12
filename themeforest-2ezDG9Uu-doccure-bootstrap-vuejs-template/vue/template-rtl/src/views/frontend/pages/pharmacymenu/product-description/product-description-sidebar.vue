<template>
  <div class="card search-filter">
    <div class="card-body">
      <div class="clini-infos mt-0">
        <h2>
          $19 <b class="text-lg strike">$45</b>
          <span class="text-lg text-success"><b>10% off</b></span>
        </h2>
      </div>
      <span class="badge badge-primary">In stock</span>
      <div class="custom-increment pt-4">
        <div class="input-group1">
          <span class="input-group-btn float-start">
            <b-button
              type="button"
              class="quantity-left-minus btn btn-danger btn-number"
              @click="decreaseQuantity"
            >
              <span><i class="fas fa-minus"></i></span>
            </b-button>
          </span>
          <input
            type="text"
            id="quantity"
            name="quantity"
            class="input-number"
            v-model.number="quantityValue"
          />
          <span class="input-group-btn float-end">
            <b-button
              type="button"
              class="quantity-right-plus btn btn-success btn-number"
              @click="increaseQuantity"
            >
              <span><i class="fas fa-plus"></i></span>
            </b-button>
          </span>
        </div>
      </div>
      <div class="clinic-details mt-4">
        <div class="clinic-booking">
          <router-link class="apt-btn" to="cart">Add To Cart</router-link>
        </div>
      </div>
      <div class="card flex-fill mt-4 mb-0">
        <ul class="list-group list-group-flush">
          <li class="list-group-item">SKU <span class="float-end">2023-02-0057</span></li>
          <li class="list-group-item">Pack Size <span class="float-end">100g</span></li>
          <li class="list-group-item">Unit Count <span class="float-end">200ml</span></li>
          <li class="list-group-item">Country <span class="float-end">Japan</span></li>
        </ul>
      </div>
    </div>
  </div>
  <div class="card search-filter">
    <div class="card-body">
      <div class="card flex-fill mt-0 mb-0">
        <ul class="list-group list-group-flush benifits-col">
          <li class="list-group-item d-flex align-items-center">
            <div>
              <i class="fas fa-shipping-fast"></i>
            </div>
            <div>Free Shipping<br /><span class="text-sm">For orders from $50</span></div>
          </li>
          <li class="list-group-item d-flex align-items-center">
            <div>
              <i class="far fa-question-circle"></i>
            </div>
            <div>Support 24/7<br /><span class="text-sm">Call us anytime</span></div>
          </li>
          <li class="list-group-item d-flex align-items-center">
            <div>
              <i class="fas fa-hands"></i>
            </div>
            <div>100% Safety<br /><span class="text-sm">Only secure payments</span></div>
          </li>
          <li class="list-group-item d-flex align-items-center">
            <div>
              <i class="fas fa-tag"></i>
            </div>
            <div>Hot Offers<br /><span class="text-sm">Discounts up to 90%</span></div>
          </li>
        </ul>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      quantityValue: 10,
    };
  },
  methods: {
    decreaseQuantity() {
      if (this.quantityValue > 0) {
        this.quantityValue--;
      }
    },
    increaseQuantity() {
      this.quantityValue++;
    },
  },
};
</script>
