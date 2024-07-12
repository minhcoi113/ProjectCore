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
          <div class="col-md-6">
            <div class="card">
              <div class="card-header">
                <h4 class="card-title">Basic Form</h4>
              </div>
              <div class="card-body">
                <form action="javascript:;">
                  <div class="form-group">
                    <label class="mb-2">First Name</label>
                    <input type="text" class="form-control" />
                  </div>
                  <div class="form-group">
                    <label class="mb-2">Last Name</label>
                    <input type="text" class="form-control" />
                  </div>
                  <div class="form-group">
                    <label class="mb-2">Email Address</label>
                    <input type="email" class="form-control" />
                  </div>
                  <div class="form-group">
                    <label class="mb-2">Username</label>
                    <input type="text" class="form-control" />
                  </div>
                  <div class="form-group">
                    <label class="mb-2">Password</label>
                    <input type="password" class="form-control" />
                  </div>
                  <div class="form-group">
                    <label class="mb-2">Repeat Password</label>
                    <input type="password" class="form-control" />
                  </div>
                  <div class="text-end">
                    <b-button type="submit" variant="primary">Submit</b-button>
                  </div>
                </form>
              </div>
            </div>
          </div>
          <div class="col-md-6">
            <div class="card">
              <div class="card-header">
                <h4 class="card-title">Address Form</h4>
              </div>
              <div class="card-body">
                <form action="javascript:;">
                  <div class="form-group">
                    <label class="mb-2">Address Line 1</label>
                    <input type="text" class="form-control" />
                  </div>
                  <div class="form-group">
                    <label class="mb-2">Address Line 2</label>
                    <input type="text" class="form-control" />
                  </div>
                  <div class="form-group">
                    <label class="mb-2">City</label>
                    <input type="text" class="form-control" />
                  </div>
                  <div class="form-group">
                    <label class="mb-2">State</label>
                    <input type="text" class="form-control" />
                  </div>
                  <div class="form-group">
                    <label class="mb-2">Country</label>
                    <input type="text" class="form-control" />
                  </div>
                  <div class="form-group">
                    <label class="mb-2">Postal Code</label>
                    <input type="text" class="form-control" />
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
                <h4 class="card-title">Two Column Vertical Form</h4>
              </div>
              <div class="card-body">
                <form action="javascript:;">
                  <h4 class="card-title">Personal Information</h4>
                  <div class="row">
                    <div class="col-md-6">
                      <div class="form-group">
                        <label class="mb-2">First Name</label>
                        <input type="text" class="form-control" />
                      </div>
                      <div class="form-group">
                        <label class="mb-2">Last Name</label>
                        <input type="text" class="form-control" />
                      </div>
                      <div class="form-group">
                        <label class="mb-2">Blood Group</label>
                        <vue-select
                          :options="BloodGroup"
                          id="blood"
                          placeholder="Select"
                        />
                      </div>
                      <div class="form-group">
                        <label class="d-block">Gender:</label>
                        <div class="form-check form-check-inline">
                          <input
                            class="form-check-input"
                            type="radio"
                            name="gender"
                            id="gender_male"
                            value="option1"
                          />
                          <label class="form-check-label" for="gender_male">Male</label>
                        </div>
                        <div class="form-check form-check-inline">
                          <input
                            class="form-check-input"
                            type="radio"
                            name="gender"
                            id="gender_female"
                            value="option2"
                          />
                          <label class="form-check-label" for="gender_female"
                            >Female</label
                          >
                        </div>
                      </div>
                    </div>
                    <div class="col-md-6">
                      <div class="form-group">
                        <label class="mb-2">Username</label>
                        <input type="text" class="form-control" />
                      </div>
                      <div class="form-group">
                        <label class="mb-2">Email</label>
                        <input type="text" class="form-control" />
                      </div>

                      <div class="form-group">
                        <label class="mb-2">Password</label>
                        <input type="text" class="form-control" />
                      </div>
                      <div class="form-group">
                        <label class="mb-2">Repeat Password</label>
                        <input type="text" class="form-control" />
                      </div>
                    </div>
                  </div>
                  <h4 class="card-title">Postal Address</h4>
                  <div class="row">
                    <div class="col-md-6">
                      <div class="form-group">
                        <label class="mb-2">Address Line 1</label>
                        <input type="text" class="form-control" />
                      </div>
                      <div class="form-group">
                        <label class="mb-2">Address Line 2</label>
                        <input type="text" class="form-control" />
                      </div>
                      <div class="form-group">
                        <label class="mb-2">State</label>
                        <input type="text" class="form-control" />
                      </div>
                    </div>
                    <div class="col-md-6">
                      <div class="form-group">
                        <label class="mb-2">City</label>
                        <input type="text" class="form-control" />
                      </div>
                      <div class="form-group">
                        <label class="mb-2">Country</label>
                        <input type="text" class="form-control" />
                      </div>
                      <div class="form-group">
                        <label class="mb-2">Postal Code</label>
                        <input type="text" class="form-control" />
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
                <h4 class="card-title">Two Column Vertical Form</h4>
              </div>
              <div class="card-body">
                <form action="javascript:;">
                  <div class="row">
                    <div class="col-md-6">
                      <h4 class="card-title">Personal details</h4>
                      <div class="form-group">
                        <label class="mb-2">Name:</label>
                        <input type="text" class="form-control" />
                      </div>
                      <div class="form-group">
                        <label class="mb-2">Password:</label>
                        <input type="password" class="form-control" />
                      </div>
                      <div class="form-group">
                        <label class="mb-2">State:</label>
                        <vue-select
                          :options="State"
                          id="state"
                          placeholder="Select State"
                        />
                      </div>
                      <div class="form-group">
                        <label class="mb-2">Your Message:</label>
                        <textarea
                          rows="5"
                          cols="5"
                          class="form-control"
                          placeholder="Enter message"
                        ></textarea>
                      </div>
                    </div>
                    <div class="col-md-6">
                      <h4 class="card-title">Personal details</h4>
                      <div class="row">
                        <div class="col-md-6">
                          <div class="form-group">
                            <label class="mb-2">First Name:</label>
                            <input type="text" class="form-control" />
                          </div>
                        </div>
                        <div class="col-md-6">
                          <div class="form-group">
                            <label class="mb-2">Last Name:</label>
                            <input type="text" class="form-control" />
                          </div>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col-md-6">
                          <div class="form-group">
                            <label class="mb-2">Email:</label>
                            <input type="text" class="form-control" />
                          </div>
                        </div>
                        <div class="col-md-6">
                          <div class="form-group">
                            <label class="mb-2">Phone:</label>
                            <input type="text" class="form-control" />
                          </div>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col-md-12">
                          <div class="form-group">
                            <label class="mb-2">Address line:</label>
                            <input type="text" class="form-control" />
                          </div>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col-md-6">
                          <div class="form-group">
                            <label class="mb-2">Country:</label>
                            <vue-select
                              :options="Country"
                              id="country"
                              placeholder="Select Country"
                            />
                          </div>
                        </div>
                        <div class="col-md-6">
                          <div class="form-group">
                            <label class="mb-2">State/Province:</label>
                            <input type="text" class="form-control" />
                          </div>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col-md-6">
                          <div class="form-group">
                            <label class="mb-2">ZIP code:</label>
                            <input type="text" class="form-control" />
                          </div>
                        </div>
                        <div class="col-md-6">
                          <div class="form-group">
                            <label class="mb-2">City:</label>
                            <input type="text" class="form-control" />
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
      title: "Vertical Form",
      text: "Dashboard",
      text1: "Vertical Form",
      BloodGroup: ["Select", "A+", "O+", "B+", "AB+"],
      State: ["Select State", "California", "Texas", "Florida"],
      Country: ["Select Country", "USA", "France", "India", "Spain"],
    };
  },
  name: "admin/form-vertical",
};
</script>
