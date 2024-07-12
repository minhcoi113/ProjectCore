<template>
  <div class="main-wrapper">
    <adminheader></adminheader>
    <adminsidebar></adminsidebar>

    <!-- Page Wrapper -->
    <div class="page-wrapper">
      <div class="content container-fluid">
        <adminbreadcrumb :title="title" :text="text" :text1="text1" />
        <!-- /Page Header -->

        <div class="row">
          <div class="col-sm-12">
            <div class="card">
              <div class="card-header">
                <h5 class="card-title">Form Mask</h5>
                <p class="card-text">
                  Input masks can be used to force the user to enter data conform a
                  specific format. Unlike validation, the user can't enter any other key
                  than the ones specified by the mask.
                </p>
              </div>
              <div class="card-body">
                <form action="javascript:;">
                  <div class="mb-3">
                    <label class="mb-2">Phone</label>
                    <MaskedInput
                      v-model="phone"
                      class="form-control"
                      :mask="'(999) 999-9999'"
                      :value="phone"
                    />
                    <span class="form-text text-muted">(999) 999-9999</span>
                  </div>
                  <div class="mb-3">
                    <label class="mb-2">Date</label>
                    <MaskedInput
                      v-model="date"
                      class="form-control"
                      :mask="'99 / 99 / 9999'"
                      :value="date"
                    />
                    <span class="form-text text-muted">dd/mm/yyyy</span>
                  </div>
                  <div class="mb-3">
                    <label class="mb-2">SSN field 1</label>
                    <MaskedInput
                      v-model="ssn"
                      class="form-control"
                      :mask="'999-99-9999'"
                      :value="ssn"
                    />
                    <span class="form-text text-muted">e.g "999-99-9999"</span>
                  </div>
                  <div class="mb-3">
                    <label class="mb-2">Phone field + ext.</label>
                    <MaskedInput
                      v-model="phoneExt"
                      class="form-control"
                      :mask="'(999) 999-9999? x99999'"
                      :value="phoneExt"
                    />
                    <span class="form-text text-muted">+40 999 999 999</span>
                  </div>
                  <div class="mb-3">
                    <label class="mb-2">Product Key</label>
                    <MaskedInput
                      v-model="product"
                      class="form-control"
                      :mask="'a*-999-a999'"
                      :value="product"
                    />
                    <span class="form-text text-muted">e.g a*-999-a999</span>
                  </div>
                  <div class="form-group mb-3">
                    <label class="mb-2">Currency</label>
                    <MaskedInput
                      v-model="currency"
                      class="form-control"
                      :mask="'999,999,999.99'"
                      :value="currency"
                    />
                    <span class="form-text text-muted">$ 999,999,999.99</span>
                  </div>
                  <div class="mb-3">
                    <label class="mb-2">Eye Script</label>
                    <MaskedInput
                      v-model="eyescript"
                      class="form-control"
                      :mask="'~9.99 ~9.99 999'"
                      :value="eyescript"
                    />
                    <span class="form-text text-muted">~9.99 ~9.99 999</span>
                  </div>
                  <div class="mb-3">
                    <label class="mb-2">Percent</label>
                    <MaskedInput
                      v-model="pct"
                      class="form-control"
                      :mask="'99%'"
                      :value="pct"
                    />
                    <span class="form-text text-muted">e.g "99%"</span>
                  </div>
                  <div class="mb-3">
                    <label class="mb-2">Credit Card Number</label>
                    <MaskedInput
                      v-model="ccn"
                      class="form-control"
                      :mask="'9999 9999 9999 9999'"
                      :value="ccn"
                    />
                    <span class="form-text text-muted">e.g "999.999.999.9999"</span>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import MaskedInput from "./MaskedInput.vue";

export default {
  components: {
    MaskedInput,
  },
  data() {
    return {
      title: "Form Mask",
      text: "Dashboard",
      text1: "Form Mask",
      phone: "",
      date: "",
      ssn: "",
      phoneExt: "",
      product: "",
      currency: "",
      eyescript: "",
      pct: "",
      ccn: "",
    };
  },
  name: "admin/form-mask",
};
</script>
