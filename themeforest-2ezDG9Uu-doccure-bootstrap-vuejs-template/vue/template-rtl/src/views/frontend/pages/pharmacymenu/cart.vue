<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="content">
      <div class="container">
        <div class="card card-table">
          <div class="card-body">
            <div class="table-responsive">
              <table class="table table-hover table-center mb-0">
                <thead>
                  <tr>
                    <th>Product</th>
                    <th>SKU</th>
                    <th>Price</th>
                    <th class="text-center">Quantity</th>
                    <th>Total</th>
                    <th>Action</th>
                  </tr>
                </thead>
                <tbody>
                  <tr v-for="(item, index) in cart" :key="item.id">
                    <td>
                      <h2 class="table-avatar">
                        <router-link
                          to="product-description"
                          class="avatar avatar-sm me-2"
                          ><img
                            class="avatar-img"
                            :src="require(`@/assets/img/products/${item.Image}`)"
                            alt="User Image"
                        /></router-link>
                      </h2>
                      <router-link to="product-description">{{
                        item.Product
                      }}</router-link>
                    </td>
                    <td>{{ item.SKU }}</td>
                    <td>{{ item.Price }}</td>
                    <td class="text-center">
                      <div class="custom-increment cart">
                        <div class="input-group1">
                          <span class="input-group-btn">
                            <b-button
                              type="button"
                              class="quantity-left-minus btn btn-danger btn-number"
                              @click="decreaseQuantity(index)"
                            >
                              <span><i class="fas fa-minus"></i></span>
                            </b-button>
                          </span>
                          <input
                            type="text"
                            :id="'quantity-' + index"
                            class="input-number"
                            :value="quantities[index]"
                          />
                          <span class="input-group-btn">
                            <b-button
                              type="button"
                              class="quantity-right-plus btn btn-success btn-number"
                              @click="increaseQuantity(index)"
                            >
                              <span><i class="fas fa-plus"></i></span>
                            </b-button>
                          </span>
                        </div>
                      </div>
                    </td>
                    <td>{{ item.Total }}</td>
                    <td>
                      <div class="table-action">
                        <a href="javascript:void(0);" class="btn btn-sm bg-danger-light">
                          <i class="fas fa-times"></i>
                        </a>
                      </div>
                    </td>
                  </tr>
                </tbody>
              </table>
            </div>
          </div>
        </div>

        <div class="row">
          <div class="col-md-7 col-lg-8"></div>

          <div class="col-md-5 col-lg-4">
            <!-- Booking Summary -->
            <div class="card booking-card">
              <div class="card-header">
                <h4 class="card-title">Cart Total</h4>
              </div>
              <div class="card-body">
                <div class="booking-summary">
                  <div class="booking-item-wrap">
                    <ul class="booking-date d-block pb-0">
                      <li>Subtotal <span>$5,877.00</span></li>
                      <li>
                        Shipping
                        <span>$25.00<a href="javascript:;">Calculate shipping</a></span>
                      </li>
                    </ul>
                    <ul class="booking-fee pt-4">
                      <li>Tax <span>$0.00</span></li>
                    </ul>
                    <div class="booking-total">
                      <ul class="booking-total-list">
                        <li>
                          <span>Total</span>
                          <span class="total-cost">$160</span>
                        </li>
                        <li>
                          <div class="clinic-booking pt-4">
                            <router-link class="apt-btn" to="product-checkout"
                              >Proceed to checkout</router-link
                            >
                          </div>
                        </li>
                      </ul>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <!-- /Booking Summary -->
          </div>
        </div>
      </div>
    </div>
    <indexfooter></indexfooter>
  </div>
</template>

<script>
import cart from "@/assets/json/pharmacy/cart.json";

export default {
  data() {
    const initialQuantity = 10;
    const quantities = Array(cart.length).fill(initialQuantity);
    return {
      title: "Cart",
      text: "Home",
      text1: "Cart",
      cart: cart,
      quantities: quantities,
    };
  },
  methods: {
    increaseQuantity(index) {
      this.quantities[index] = this.quantities[index] + 1;
    },
    decreaseQuantity(index) {
      if (this.quantities[index] > 0) {
        this.quantities[index] = this.quantities[index] - 1;
      }
    },
  },
};
</script>
