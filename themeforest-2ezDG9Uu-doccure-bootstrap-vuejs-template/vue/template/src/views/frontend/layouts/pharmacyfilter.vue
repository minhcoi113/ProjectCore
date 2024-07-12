<template>
  <!-- Search Filter -->
  <div class="card search-filter">
    <div class="card-header">
      <h4 class="card-title mb-0">Search Filter</h4>
    </div>
    <div class="card-body">
      <div class="filter-widget">
        <label class="mb-2">Location</label>
        <input type="text" class="form-control" placeholder="Select Location" />
      </div>
      <div class="filter-widget">
        <h4>Categories</h4>
        <div>
          <label class="custom_check">
            <input type="checkbox" name="gender_type" />
            <span class="checkmark"></span> Popular
          </label>
        </div>
        <div>
          <label class="custom_check">
            <input type="checkbox" name="gender_type" />
            <span class="checkmark"></span> Latest
          </label>
        </div>
        <div>
          <label class="custom_check">
            <input type="checkbox" name="gender_type" />
            <span class="checkmark"></span> Ratings
          </label>
        </div>
        <div>
          <label class="custom_check">
            <input type="checkbox" name="gender_type" />
            <span class="checkmark"></span> Availability
          </label>
        </div>
        <div>
          <label class="custom_check">
            <input type="checkbox" name="gender_type" checked />
            <span class="checkmark"></span> Open 24 Hrs
          </label>
        </div>
        <div>
          <label class="custom_check">
            <input type="checkbox" name="gender_type" />
            <span class="checkmark"></span> Home Delivery
          </label>
        </div>
      </div>

      <div class="btn-search">
        <b-button type="button" class="btn w-100">Search</b-button>
      </div>
    </div>
  </div>
  <!-- /Search Filter -->
</template>
