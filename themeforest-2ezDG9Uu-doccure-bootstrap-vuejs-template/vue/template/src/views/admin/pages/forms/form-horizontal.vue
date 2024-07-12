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
          <div class="col-xl-6 d-flex">
            <div class="card flex-fill">
              <div class="card-header">
                <h4 class="card-title">Basic Form</h4>
              </div>
              <div class="card-body">
                <form action="javascript:;">
                  <div class="form-group row">
                    <label class="col-lg-3 col-form-label">First Name</label>
                    <div class="col-lg-9">
                      <input type="text" class="form-control" />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-lg-3 col-form-label">Last Name</label>
                    <div class="col-lg-9">
                      <input type="text" class="form-control" />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-lg-3 col-form-label">Email Address</label>
                    <div class="col-lg-9">
                      <input type="email" class="form-control" />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-lg-3 col-form-label">Username</label>
                    <div class="col-lg-9">
                      <input type="text" class="form-control" />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-lg-3 col-form-label">Password</label>
                    <div class="col-lg-9">
                      <input type="password" class="form-control" />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-lg-3 col-form-label">Repeat Password</label>
                    <div class="col-lg-9">
                      <input type="password" class="form-control" />
                    </div>
                  </div>
                  <div class="text-end">
                    <b-button type="submit" variant="primary">Submit</b-button>
                  </div>
                </form>
              </div>
            </div>
          </div>
          <div class="col-xl-6 d-flex">
            <div class="card flex-fill">
              <div class="card-header">
                <h4 class="card-title">Address Form</h4>
              </div>
              <div class="card-body">
                <form action="javascript:;">
                  <div class="form-group row">
                    <label class="col-lg-3 col-form-label">Address 1</label>
                    <div class="col-lg-9">
                      <input type="text" class="form-control" />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-lg-3 col-form-label">Address 2</label>
                    <div class="col-lg-9">
                      <input type="text" class="form-control" />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-lg-3 col-form-label">City</label>
                    <div class="col-lg-9">
                      <input type="text" class="form-control" />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-lg-3 col-form-label">State</label>
                    <div class="col-lg-9">
                      <input type="text" class="form-control" />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-lg-3 col-form-label">Country</label>
                    <div class="col-lg-9">
                      <input type="text" class="form-control" />
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-lg-3 col-form-label">Postal Code</label>
                    <div class="col-lg-9">
                      <input type="text" class="form-control" />
                    </div>
                  </div>
                  <div class="text-end">
                    <b-button type="submit" variant="primary">Submit</b-button>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-md-12">
            <div class="card">
              <div class="card-header">
                <h4 class="card-title">Two Column Horizontal Form</h4>
              </div>
              <div class="card-body">
                <h4 class="card-title">Personal Information</h4>
                <form action="javascript:;">
                  <div class="row">
                    <div class="col-xl-6">
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">First Name</label>
                        <div class="col-lg-9">
                          <input type="text" class="form-control" />
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">Last Name</label>
                        <div class="col-lg-9">
                          <input type="text" class="form-control" />
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">Gender</label>
                        <div class="col-lg-9">
                          <div class="form-check form-check-inline">
                            <input
                              class="form-check-input"
                              type="radio"
                              name="gender"
                              id="gender_male"
                              value="option1"
                              checked
                            />
                            <label class="form-check-label" for="gender_male">
                              Male
                            </label>
                          </div>
                          <div class="form-check form-check-inline">
                            <input
                              class="form-check-input"
                              type="radio"
                              name="gender"
                              id="gender_female"
                              value="option2"
                            />
                            <label class="form-check-label" for="gender_female">
                              Female
                            </label>
                          </div>
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">Blood Group</label>
                        <div class="col-lg-9">
                          <vue-select
                            :options="BloodGroup"
                            id="select1"
                            placeholder="Select"
                          />
                        </div>
                      </div>
                    </div>
                    <div class="col-xl-6">
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">Username</label>
                        <div class="col-lg-9">
                          <input type="text" class="form-control" />
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">Email</label>
                        <div class="col-lg-9">
                          <input type="text" class="form-control" />
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">Password</label>
                        <div class="col-lg-9">
                          <input type="password" class="form-control" />
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">Repeat Password</label>
                        <div class="col-lg-9">
                          <input type="password" class="form-control" />
                        </div>
                      </div>
                    </div>
                  </div>
                  <h4 class="card-title">Address</h4>
                  <div class="row">
                    <div class="col-xl-6">
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">Address Line 1</label>
                        <div class="col-lg-9">
                          <input type="text" class="form-control" />
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">Address Line 2</label>
                        <div class="col-lg-9">
                          <input type="text" class="form-control" />
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">State</label>
                        <div class="col-lg-9">
                          <input type="text" class="form-control" />
                        </div>
                      </div>
                    </div>
                    <div class="col-xl-6">
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">City</label>
                        <div class="col-lg-9">
                          <input type="text" class="form-control" />
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">Country</label>
                        <div class="col-lg-9">
                          <input type="text" class="form-control" />
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">Postal Code</label>
                        <div class="col-lg-9">
                          <input type="text" class="form-control" />
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="text-end">
                    <b-button type="submit" variant="primary">Submit</b-button>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-md-12">
            <div class="card">
              <div class="card-header">
                <h4 class="card-title">Two Column Horizontal Form</h4>
              </div>
              <div class="card-body">
                <form action="javascript:;">
                  <div class="row">
                    <div class="col-xl-6">
                      <h4 class="card-title">Personal Details</h4>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">First Name</label>
                        <div class="col-lg-9">
                          <input type="text" class="form-control" />
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">Last Name</label>
                        <div class="col-lg-9">
                          <input type="text" class="form-control" />
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">Password</label>
                        <div class="col-lg-9">
                          <input type="password" class="form-control" />
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">State</label>
                        <div class="col-lg-9">
                          <vue-select
                            :options="State"
                            id="select2"
                            placeholder="Select State"
                          />
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">About</label>
                        <div class="col-lg-9">
                          <textarea
                            rows="4"
                            cols="5"
                            class="form-control"
                            placeholder="Enter message"
                          ></textarea>
                        </div>
                      </div>
                    </div>
                    <div class="col-xl-6">
                      <h4 class="card-title">Personal details</h4>
                      <div class="row">
                        <label class="col-lg-3 col-form-label">Name</label>
                        <div class="col-lg-9">
                          <div class="row">
                            <div class="col-md-6">
                              <div class="form-group">
                                <input
                                  type="text"
                                  placeholder="First Name"
                                  class="form-control"
                                />
                              </div>
                            </div>
                            <div class="col-md-6">
                              <div class="form-group">
                                <input
                                  type="text"
                                  placeholder="Last Name"
                                  class="form-control"
                                />
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">Email</label>
                        <div class="col-lg-9">
                          <input type="text" class="form-control" />
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">Phone</label>
                        <div class="col-lg-9">
                          <input type="text" class="form-control" />
                        </div>
                      </div>
                      <div class="form-group row">
                        <label class="col-lg-3 col-form-label">Address</label>
                        <div class="col-lg-9">
                          <input type="text" class="form-control m-b-20" />
                          <div class="row">
                            <div class="col-md-6">
                              <div class="form-group">
                                <vue-select
                                  :options="Country"
                                  id="select3"
                                  placeholder="Select Country"
                                />
                              </div>
                              <div class="form-group">
                                <input
                                  type="text"
                                  placeholder="ZIP code"
                                  class="form-control"
                                />
                              </div>
                            </div>
                            <div class="col-md-6">
                              <div class="form-group">
                                <input
                                  type="text"
                                  placeholder="State/Province"
                                  class="form-control"
                                />
                              </div>
                              <div class="form-group">
                                <input
                                  type="text"
                                  placeholder="City"
                                  class="form-control"
                                />
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="text-end">
                    <b-button type="submit" variant="primary">Submit</b-button>
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
      title: "Horizontal Form",
      text: "Dashboard",
      text1: "Horizontal Form",
      BloodGroup: ["Select", "A+", "O+", "B+", "AB+"],
      State: ["Select State", "California", "Texas", "Florida"],
      Country: ["Select Country", "USA", "France", "India", "Spain"],
    };
  },
  name: "admin/horizontal",
};
</script>
