<template>
  <div class="main-wrapper">
    <adminheader></adminheader>
    <adminsidebar></adminsidebar>

    <!-- Page Wrapper -->
    <div class="page-wrapper">
      <div class="content container-fluid">
        <adminbreadcrumb3 :title="title" :text="text" :text1="text1" :Add="Add" />
        <!-- /Page Header -->

        <!-- /Page Header -->
        <div class="row">
          <div class="col-sm-12">
            <div class="card">
              <div class="card-body">
                <div class="table-responsive">
                  <div class="showentries mb-3">
                    <label
                      >Show
                      <select>
                        <option value="10">10</option>
                        <option value="25">25</option>
                        <option value="50">50</option>
                        <option value="100">100</option>
                      </select>
                      entries
                    </label>
                  </div>
                  <a-table :columns="columns" :data-source="data">
                    <template #bodyCell="{ column, record }">
                      <template v-if="column.key === 'Title'">
                        <h2 class="table-avatar">
                          <router-link to="/admin/profile" class="avatar avatar-sm me-2">
                            <img
                              class="avatar-img"
                              :src="
                                require(`@/assets/admin/img/specialities/${record.Image}`)
                              "
                              alt="Speciality"
                            />
                          </router-link>
                          <router-link to="/admin/profile">{{
                            record.Specialities
                          }}</router-link>
                        </h2>
                      </template>
                      <template v-else-if="column.key === 'action'">
                        <div>
                          <div class="actions">
                            <a
                              class="btn btn-sm bg-success-light me-2"
                              data-bs-toggle="modal"
                              href="#edit_specialities_details"
                            >
                              <i class="fe fe-pencil"></i> Edit
                            </a>
                            <a
                              data-bs-toggle="modal"
                              href="#delete_modal"
                              class="btn btn-sm bg-danger-light"
                            >
                              <i class="fe fe-trash"></i> Delete
                            </a>
                          </div>
                        </div>
                      </template>
                    </template>
                  </a-table>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- /Page Wrapper -->
  </div>
  <!-- Add Modal -->
  <div class="modal fade" id="Add_Specialities_details" aria-hidden="true" role="dialog">
    <div class="modal-dialog modal-dialog-centered" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Add Specialities</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <form>
            <div class="row form-row">
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Specialities</label>
                  <input type="text" class="form-control" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Image</label>
                  <input type="file" class="form-control" />
                </div>
              </div>
            </div>
            <b-button type="submit" class="btn btn-primary w-100">Save</b-button>
          </form>
        </div>
      </div>
    </div>
  </div>
  <!-- /ADD Modal -->

  <!-- Edit Details Modal -->
  <div class="modal fade" id="edit_specialities_details" aria-hidden="true" role="dialog">
    <div class="modal-dialog modal-dialog-centered" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Edit Specialities</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <form>
            <div class="row form-row">
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Specialities</label>
                  <input type="text" class="form-control" value="Cardiology" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="form-group">
                  <label class="mb-2">Image</label>
                  <input type="file" class="form-control" />
                </div>
              </div>
            </div>
            <b-button type="submit" class="btn btn-primary w-100">Save Changes</b-button>
          </form>
        </div>
      </div>
    </div>
  </div>
  <!-- /Edit Details Modal -->

  <admindelete />
</template>

<script>
const columns = [
  {
    title: "#",
    dataIndex: "ID",
    sorter: {
      compare: (a, b) => {
        a = a.ID.toLowerCase();
        b = b.ID.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Specialities",
    dataIndex: "Specialities",
    key: "Title",
    sorter: {
      compare: (a, b) => {
        a = a.Specialities.toLowerCase();
        b = b.Specialities.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Actions",
    key: "action",
    sorter: true,
  },
];
const data = [
  {
    ID: "#SP001",
    Image: "specialities-01.png",
    Specialities: "Urology",
  },
  {
    ID: "#SP002",
    Image: "specialities-02.png",
    Specialities: "Neurology",
  },
  {
    ID: "#SP003",
    Image: "specialities-03.png",
    Specialities: "Orthopedic",
  },
  {
    ID: "#SP004",
    Image: "specialities-04.png",
    Specialities: "Cardiologist",
  },
  {
    ID: "#SP005",
    Image: "specialities-05.png",
    Specialities: "Dentist",
  },
];
export default {
  data() {
    return {
      title: "Specialities",
      text: "Dashboard",
      text1: "Specialities",
      Add: "Add",
      columns,
      data,
    };
  },
};
</script>
