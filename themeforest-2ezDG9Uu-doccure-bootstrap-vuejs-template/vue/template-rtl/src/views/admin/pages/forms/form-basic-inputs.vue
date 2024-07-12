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
          <div class="col-lg-12">
            <div class="card">
              <div class="card-header">
                <h4 class="card-title">Basic Inputs</h4>
              </div>
              <div class="card-body">
                <form action="javascript:;">
                  <div class="form-group row">
                    <label class="col-form-label col-md-2">Text Input</label>
                    <div class="col-md-10">
                      <input type="text" class="form-control" />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-form-label col-md-2">Password</label>
                    <div class="col-md-10">
                      <input type="password" class="form-control" />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-form-label col-md-2">Disabled Input</label>
                    <div class="col-md-10">
                      <input
                        type="text"
                        class="form-control"
                        disabled="disabled"
                      />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-form-label col-md-2">Readonly Input</label>
                    <div class="col-md-10">
                      <input
                        type="text"
                        class="form-control"
                        value="readonly"
                        readonly="readonly"
                      />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-form-label col-md-2">Placeholder</label>
                    <div class="col-md-10">
                      <input
                        type="text"
                        class="form-control"
                        placeholder="Placeholder"
                      />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-form-label col-md-2">File Input</label>
                    <div class="col-md-10">
                      <input class="form-control" type="file" />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-form-label col-md-2">Default Select</label>
                    <div class="col-md-10">
                      <vue-select :options="Option" placeholder="-- Select --" />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-form-label col-md-2">Radio</label>
                    <div class="col-md-10">
                      <div class="radio">
                        <label class="mb-2"> <input type="radio" name="radio" /> Option 1 </label>
                      </div>
                      <div class="radio">
                        <label class="mb-2"> <input type="radio" name="radio" /> Option 2 </label>
                      </div>
                      <div class="radio">
                        <label class="mb-2"> <input type="radio" name="radio" /> Option 3 </label>
                      </div>
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-form-label col-md-2">Checkbox</label>
                    <div class="col-md-10">
                      <div class="checkbox">
                        <label class="mb-2">
                          <input type="checkbox" name="checkbox" /> Option 1
                        </label>
                      </div>
                      <div class="checkbox">
                        <label class="mb-2">
                          <input type="checkbox" name="checkbox" /> Option 2
                        </label>
                      </div>
                      <div class="checkbox">
                        <label class="mb-2">
                          <input type="checkbox" name="checkbox" /> Option 3
                        </label>
                      </div>
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-form-label col-md-2">Textarea</label>
                    <div class="col-md-10">
                      <textarea
                        rows="5"
                        cols="5"
                        class="form-control"
                        placeholder="Enter text here"
                      ></textarea>
                    </div>
                  </div>
                  <div class="form-group mb-0 row">
                    <label class="col-form-label col-md-2">Input Addons</label>
                    <div class="col-md-10">
                      <div class="input-group">
                        <span class="input-group-text">$</span>
                        <input class="form-control" type="text" />
                        <b-button variant="primary" type="button">Button</b-button>
                      </div>
                    </div>
                  </div>
                </form>
              </div>
            </div>
            <div class="card">
              <div class="card-header">
                <h4 class="card-title">Input Sizes</h4>
              </div>
              <div class="card-body">
                <form action="javascript:;">
                  <div class="form-group row">
                    <label class="col-form-label col-md-2">Large Input</label>
                    <div class="col-md-10">
                      <input
                        type="text"
                        class="form-control form-control-lg"
                        placeholder=".form-control-lg"
                      />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-form-label col-md-2">Default Input</label>
                    <div class="col-md-10">
                      <input
                        type="text"
                        class="form-control"
                        placeholder=".form-control"
                      />
                    </div>
                  </div>
                  <div class="form-group mb-0 row">
                    <label class="col-form-label col-md-2">Small Input</label>
                    <div class="col-md-10">
                      <input
                        type="text"
                        class="form-control form-control-sm"
                        placeholder=".form-control-sm"
                      />
                    </div>
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
export default {
  data() {
    return {
      title: "Basic Inputs",
      text: "Dashboard",
      text1: "Basic Inputs",
      Option: [
        "-- Select --",
        "Option 1",
        "Option 2",
        "Option 3",
        "Option 4",
        "Option 5",
      ],
    };
  },
  name: "admin/form-basic-inputs",
};
</script>
