<template>
  <div class="main-Wrapper">
    <pharmacyheader></pharmacyheader>
    <pharmacysidebar></pharmacysidebar>
    <!-- Page Wrapper -->
    <div class="page-wrapper">
      <div class="content container-fluid">
        <pharmacybreadcrumb2 :title="title" :text="text" :text1="text1" />
        <div class="row">
          <div class="col-md-12">
            <div class="card">
              <div class="card-body">
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
                <div class="table-responsive">
                  <a-table
                    class="stripped table-hover"
                    :columns="columns"
                    :data-source="data"
                    
                  >
                    <template #bodyCell="{ column, record }">
                      <template v-if="column.key === 'Name'">
                        <div class="table-avatar">
                          {{ record.Name }}
                        </div>
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
            <div
              class="modal fade"
              id="edit_specialities_details"
              aria-hidden="true"
              role="dialog"
            >
              <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                  <div class="modal-header">
                    <h5 class="modal-title">Edit Category</h5>
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
                        <div class="col-12">
                          <div class="form-group">
                            <label class="mb-2">Category</label>
                            <input type="text" class="form-control" value="Cardiology" />
                          </div>
                        </div>
                      </div>
                      <b-button type="submit" class="btn btn-primary w-100">
                        Save Changes
                      </b-button>
                    </form>
                  </div>
                </div>
              </div>
            </div>
            <!-- /Edit Details Modal -->
          </div>

          <!-- /Page Wrapper -->
        </div>
      </div>
    </div>
  </div>
  <pharmacymodel />
  <pharmacydelete />
</template>
<script>
const columns = [
  {
    title: "#",
    dataIndex: "num",
    sorter: {
      compare: (a, b) => {
        a = a.num.toLowerCase();
        b = b.num.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Name",
    dataIndex: "Name",
    key: "Name",

    sorter: {
      compare: (a, b) => {
        a = a.Name.toLowerCase();
        b = b.Name.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Created date",
    dataIndex: "Createddate",
    sorter: {
      compare: (a, b) => {
        a = a.Createddate.toLowerCase();
        b = b.Createddate.toLowerCase();
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
    num: "01",
    Name: "Phytopathology",
    Createddate: "01-May-2023-12:00",
  },
  {
    num: "02",
    Name: "Family care",
    Createddate: "03-May-2023-08:00",
  },
  {
    num: "03",
    Name: "Cancer",
    Createddate: "05-May-2023-06:00",
  },
  {
    num: "04",
    Name: "Hair care",
    Createddate: "06-May-2023-01:00",
  },
  {
    num: "05",
    Name: "Skin care",
    Createddate: "05-May-2023-02:00",
  },
  {
    num: "06",
    Name: "Rare diseases",
    Createddate: "06-May-2023-06:00",
  },
  {
    num: "07",
    Name: "Baby care",
    Createddate: "07-May-2023-12:00",
  },
  {
    num: "08",
    Name: "Inflammations",
    Createddate: "07-May-2023-05:00",
  },
  {
    num: "09",
    Name: "Sleep disorders",
    Createddate: "07-May-2023-08:00",
  },
  {
    num: "10",
    Name: "Infectious diseases",
    Createddate: "08-May-2023-02:00",
  },
];

export default {
  data() {
    return {
      title: "Categories",
      text: "Dashboard",
      text1: "Categories",
      columns,
      data,
    };
  },
  name: "pharmacy/categories",
};
</script>
