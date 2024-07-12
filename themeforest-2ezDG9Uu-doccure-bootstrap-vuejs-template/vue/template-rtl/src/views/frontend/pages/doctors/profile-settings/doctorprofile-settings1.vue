<template>
  <!-- Contact Details -->
  <div class="card">
    <div class="card-body">
      <h4 class="card-title">Contact Details</h4>
      <div class="row">
        <div class="col-md-6">
          <div class="mb-3">
            <label class="mb-2">Address Line 1</label>
            <input type="text" class="form-control" />
          </div>
        </div>
        <div class="col-md-6">
          <div class="mb-3">
            <label class="control-label">Address Line 2</label>
            <input type="text" class="form-control" />
          </div>
        </div>
        <div class="col-md-6">
          <div class="mb-3">
            <label class="control-label">City</label>
            <input type="text" class="form-control" />
          </div>
        </div>

        <div class="col-md-6">
          <div class="mb-3">
            <label class="control-label">State / Province</label>
            <input type="text" class="form-control" />
          </div>
        </div>
        <div class="col-md-6">
          <div class="mb-3">
            <label class="control-label">Country</label>
            <input type="text" class="form-control" />
          </div>
        </div>
        <div class="col-md-6">
          <div class="mb-3">
            <label class="control-label">Postal Code</label>
            <input type="text" class="form-control" />
          </div>
        </div>
      </div>
    </div>
  </div>
  <!-- /Contact Details -->

  <!-- Pricing -->
  <div class="card">
    <div class="card-body">
      <h4 class="card-title">Pricing</h4>
      <div class="mb-0">
        <div id="pricing_select">
          <div class="custom-control form-check custom-control-inline">
            <input
              v-model="selectedOption"
              type="radio"
              id="price_free"
              name="rating_option"
              class="form-check-input"
              value="price_free"
              checked
            />
            <label class="form-check-label" for="price_free">Free</label>
          </div>
          <div class="custom-control form-check custom-control-inline">
            <input
              v-model="selectedOption"
              type="radio"
              id="price_custom"
              name="rating_option"
              value="custom_price"
              class="form-check-input"
            />
            <label class="form-check-label" for="price_custom"
              >Custom Price (per hour)</label
            >
          </div>
        </div>
      </div>
      <div
        class="row custom_price_cont"
        id="custom_price_cont"
        v-show="selectedOption === 'custom_price'"
      >
        <div class="col-md-4">
          <input
            v-model="customPrice"
            type="text"
            class="form-control"
            id="custom_rating_input"
            name="custom_rating_count"
            placeholder="20"
          />
          <small class="form-text text-muted">Custom price you can add</small>
        </div>
      </div>
    </div>
  </div>
  <!-- /Pricing -->

  <!-- Services and Specialization -->
  <div class="card services-card">
    <div class="card-body">
      <h4 class="card-title">Services and Specialization</h4>
      <div class="mb-3">
        <label class="mb-2">Services</label>
        <vue3-tags-input
          type="text"
          data-role="tagsinput"
          id="services"
          class="input-tags form-control"
          name="services"
          :tags="tags"
          placeholder="Enter Services"
        />
        <small class="form-text text-muted"
          >Note : Type & Press enter to add new services</small
        >
      </div>
      <div class="mb-0">
        <label class="mb-2">Specialization </label>

        <vue3-tags-input
          type="text"
          data-role="tagsinput"
          id="specialist"
          class="input-tags form-control"
          name="specialist"
          :tags="tags1"
          placeholder="Enter Specialization"
        />
        <small class="form-text text-muted"
          >Note : Type & Press enter to add new specialization</small
        >
      </div>
    </div>
  </div>
  <!-- /Services and Specialization -->
</template>

<script>
import Vue3TagsInput from "vue3-tags-input";

export default {
  components: {
    Vue3TagsInput,
  },
  data() {
    return {
      tags: ["Tooth Cleaning"],
      tags1: ["Children Care", "Dental Care"],
      myValue: "",
      selectedOption: "price_free",
      customPrice: "",
    };
  },
  watch: {
    selectedOption(newValue) {
      if (newValue === "custom_price") {
        document.getElementById("custom_price_cont").style.display = "block";
      } else {
        document.getElementById("custom_price_cont").style.display = "none";
      }
    },
  },
};
</script>
