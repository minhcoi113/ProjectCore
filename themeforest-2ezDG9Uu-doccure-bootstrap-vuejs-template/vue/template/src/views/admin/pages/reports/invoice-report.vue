<template>
  <div class="main-wrapper">
    <adminheader></adminheader>
    <adminsidebar></adminsidebar>

    <!-- Page Wrapper -->
    <div class="page-wrapper">
      <div class="content container-fluid">
        <adminbreadcrumb :title="title" :text="text" :text1="text1" />

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
                      <template v-if="column.key === 'InvoiceNumber'">
                        <div>
                          <router-link to="/admin/invoice">{{
                            record.InvoiceNumber
                          }}</router-link>
                        </div>
                      </template>
                      <template v-else-if="column.key === 'PatientID'">
                        <div>{{ record.PatientID }}</div>
                      </template>
                      <template v-else-if="column.key === 'PatientName'">
                        <h2 class="table-avatar">
                          <router-link to="/admin/profile" class="avatar avatar-sm me-2"
                            ><img
                              class="avatar-img rounded-circle"
                              :src="
                                require(`@/assets/admin/img/patients/${record.PatientImg}`)
                              "
                              alt="User Image"
                          /></router-link>
                          <router-link to="/admin/profile"
                            >{{ record.PatientName }}
                          </router-link>
                        </h2>
                      </template>
                      <template v-else-if="column.key === 'Status'">
                        <span class="badge rounded-pill bg-success inv-badge">{{
                          record.Status
                        }}</span>
                      </template>
                      <template v-else-if="column.key === 'actions'">
                        <div class="text-end">
                          <div class="actions">
                            <a
                              data-bs-toggle="modal"
                              href="#edit_invoice_report"
                              class="btn btn-sm bg-success-light me-2"
                            >
                              <i class="fe fe-pencil"></i> Edit
                            </a>
                            <a
                              class="btn btn-sm bg-danger-light"
                              data-bs-toggle="modal"
                              href="#delete_modal"
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
  </div>
  <!-- Edit Details Modal -->
  <div class="modal fade" id="edit_invoice_report" aria-hidden="true" role="dialog">
    <div class="modal-dialog modal-dialog-centered" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Edit Invoice Report</h5>
          <b-button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></b-button>
        </div>
        <div class="modal-body">
          <form>
            <div class="row">
              <div class="col-12 col-sm-6">
                <div class="mb-3">
                  <label class="mb-2">Invoice Number</label>
                  <input type="text" class="form-control" value="#INV-0001" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="mb-3">
                  <label class="mb-2">Patient ID</label>
                  <input type="text" class="form-control" value="#PT002" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="mb-3">
                  <label class="mb-2">Patient Name</label>
                  <input type="text" class="form-control" value="R Amer" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="mb-3">
                  <label class="mb-2">Patient Image</label>
                  <input type="file" class="form-control" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="mb-3">
                  <label class="mb-2">Total Amount</label>
                  <input type="text" class="form-control" value="$200.00" />
                </div>
              </div>
              <div class="col-12 col-sm-6">
                <div class="mb-3">
                  <label class="mb-2">Created Date</label>
                  <input type="text" class="form-control" value="29th Jun 2023" />
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
    title: "Invoice Number",
    dataIndex: "InvoiceNumber",
    key: "InvoiceNumber",
    sorter: {
      compare: (a, b) => {
        a = a.InvoiceNumber.toLowerCase();
        b = b.InvoiceNumber.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Patient ID",
    dataIndex: "PatientID",
    key: "PatientID",
    sorter: {
      compare: (a, b) => {
        a = a.PatientID.toLowerCase();
        b = b.PatientID.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Patient Name",
    dataIndex: "PatientName",
    key: "PatientName",
    sorter: {
      compare: (a, b) => {
        a = a.PatientName.toLowerCase();
        b = b.PatientName.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Total Amount",
    dataIndex: "TotalAmount",
    sorter: {
      compare: (a, b) => {
        a = a.TotalAmount.toLowerCase();
        b = b.TotalAmount.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Status",
    dataIndex: "Status",
    key: "Status",
    sorter: {
      compare: (a, b) => {
        a = a.Status.toLowerCase();
        b = b.Status.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },

  {
    title: "Actions",
    key: "actions",
    class: "text-end",
    sorter: true,
  },
];

const data = [
  {
    InvoiceNumber: "#IN0001",
    PatientID: "#PT001",
    PatientName: "Charlene Reed",
    PatientImg: "patient1.jpg",
    TotalAmount: "$100.00",
    CreatedDate: "9 Jul 2023",
    Status: "Paid",
  },
  {
    InvoiceNumber: "#IN0002",
    PatientID: "#PT002",
    PatientName: "Travis Trimble",
    PatientImg: "patient2.jpg",
    TotalAmount: "$200.00",
    CreatedDate: "29 Jun 2023",
    Status: "Paid",
  },
  {
    InvoiceNumber: "#IN0003",
    PatientID: "#PT003",
    PatientName: "Carl Kelly",
    PatientImg: "patient3.jpg",
    TotalAmount: "$250.00",
    CreatedDate: "25 Jul 2023",
    Status: "Paid",
  },
  {
    InvoiceNumber: "#IN0004",
    PatientID: "#PT004",
    PatientName: "Michelle Fairfax",
    PatientImg: "patient4.jpg",
    TotalAmount: "$150.00",
    CreatedDate: "9 Jun 2023",
    Status: "Paid",
  },
  {
    InvoiceNumber: "#IN0005",
    PatientID: "#PT005",
    PatientName: "Gina Moore",
    PatientImg: "patient5.jpg",
    TotalAmount: "$350.00",
    CreatedDate: "19 Jul 2023",
    Status: "Paid",
  },
  {
    InvoiceNumber: "#IN0006",
    PatientID: "#PT006",
    PatientName: "Elsie Gilley",
    PatientImg: "patient6.jpg",
    TotalAmount: "$300.00",
    CreatedDate: "12 Jun 2023",
    Status: "Paid",
  },
  {
    InvoiceNumber: "#IN0007",
    PatientID: "#PT007",
    PatientName: "Joan Gardner",
    PatientImg: "patient7.jpg",
    TotalAmount: "$250.00",
    CreatedDate: "25 Jun 2023",
    Status: "Paid",
  },
  {
    InvoiceNumber: "#IN0008",
    PatientID: "#PT008",
    PatientName: "Daniel Griffing",
    PatientImg: "patient8.jpg",
    TotalAmount: "$150.00",
    CreatedDate: "30 Jun 2023",
    Status: "Paid",
  },
  {
    InvoiceNumber: "#IN0009",
    PatientID: "#PT009",
    PatientName: "Walter Roberson",
    PatientImg: "patient9.jpg",
    TotalAmount: "$100.00",
    CreatedDate: "5 Jul 2023",
    Status: "Paid",
  },
  {
    InvoiceNumber: "#IN0010",
    PatientID: "#PT010",
    PatientName: "Robert Rhodes",
    PatientImg: "patient10.jpg",
    TotalAmount: "$120.00",
    CreatedDate: "7 Jul 2023",
    Status: "Paid",
  },
];

export default {
  data() {
    return {
      title: "Invoice Report",
      text: "Dashboard",
      text1: "Invoice Report",
      data,
      columns,
    };
  },
  name: "admin/invoice-report",
};
</script>
