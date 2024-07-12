<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="content">
      <div class="container">
        <div class="row">
          <div class="col-md-12 col-lg-4 col-xl-3 theiaStickySidebar">
            <!-- Search Filter -->
            <div class="stickysidebar">
              <div class="card search-filter">
                <div class="card-header">
                  <h4 class="card-title mb-0">Search Filter</h4>
                </div>
                <div class="card-body">
                  <div class="filter-widget">
                    <div class="cal-icon">
                      <datepicker
                        v-model="startdate"
                        placeholder="Date"
                        class="form-control datetimepicker"
                        :editable="true"
                        :clearable="false"
                      />
                    </div>
                  </div>
                  <div class="filter-widget">
                    <h4>Gender</h4>
                    <div>
                      <label class="custom_check">
                        <input type="checkbox" name="gender_type" checked />
                        <span class="checkmark"></span> Male Doctor
                      </label>
                    </div>
                    <div>
                      <label class="custom_check">
                        <input type="checkbox" name="gender_type" />
                        <span class="checkmark"></span> Female Doctor
                      </label>
                    </div>
                  </div>
                  <div class="filter-widget">
                    <h4>Select Specialist</h4>
                    <div>
                      <label class="custom_check">
                        <input type="checkbox" name="select_specialist" checked />
                        <span class="checkmark"></span> Urology
                      </label>
                    </div>
                    <div>
                      <label class="custom_check">
                        <input type="checkbox" name="select_specialist" checked />
                        <span class="checkmark"></span> Neurology
                      </label>
                    </div>
                    <div>
                      <label class="custom_check">
                        <input type="checkbox" name="select_specialist" />
                        <span class="checkmark"></span> Dentist
                      </label>
                    </div>
                    <div>
                      <label class="custom_check">
                        <input type="checkbox" name="select_specialist" />
                        <span class="checkmark"></span> Orthopedic
                      </label>
                    </div>
                    <div>
                      <label class="custom_check">
                        <input type="checkbox" name="select_specialist" />
                        <span class="checkmark"></span> Cardiologist
                      </label>
                    </div>
                    <div>
                      <label class="custom_check">
                        <input type="checkbox" name="select_specialist" />
                        <span class="checkmark"></span> Cardiologist
                      </label>
                    </div>
                  </div>
                  <div class="btn-search">
                    <b-button type="button" class="btn w-100">Search</b-button>
                  </div>
                </div>
              </div>
            </div>
            <!-- /Search Filter -->
          </div>
          <searchlist></searchlist>
        </div>
      </div>
    </div>
    <indexfooter></indexfooter>
  </div>
</template>
<script>
import { ref } from "vue";
const currentDate = ref(new Date());
export default {
  data() {
    return {
      title: "Search",
      text: "Home",
      text1: "Search",
      startdate: currentDate,
    };
  },
};
</script>
