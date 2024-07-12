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
                  <a-table
                    class="stripped table-hover"
                    :columns="columns"
                    :data-source="data"
                  >
                    <template #bodyCell="{ column, record }">
                      <template v-if="column.key === 'InvoiceNumber'">
                        <div>
                          <router-link to="/admin/invoice">{{
                            record.InvoiceNumber
                          }}</router-link>
                        </div>
                      </template>
                      <template v-else-if="column.key === 'PatientName'">
                        <h2 class="table-avatar">
                          <router-link to="/admin/profile" class="avatar avatar-sm me-2"
                            ><img
                              class="avatar-img rounded-circle"
                              :src="require(`@/assets/img/patients/${record.PatientImg}`)"
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
                      <template v-else-if="column.key === 'action'">
                        <div class="actions">
                          <a
                            class="btn btn-sm bg-danger-light"
                            data-bs-toggle="modal"
                            href="#delete_modal"
                          >
                            <i class="fe fe-trash"></i> Delete
                          </a>
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
    title: "Action",
    key: "action",
    sorter: true,
    class: "text-end",
  },
];

const data = [
  {
    InvoiceNumber: "#IN0001",
    PatientID: "#PT001",
    PatientName: "Charlene Reed",
    PatientImg: "patient1.jpg",
    TotalAmount: "$100.00",
    Status: "Paid",
    Actions: "Delete",
  },
  {
    InvoiceNumber: "#IN0002",
    PatientID: "#PT002",
    PatientName: "Travis Trimble",
    PatientImg: "patient2.jpg",
    TotalAmount: "$200.00",
    Status: "Paid",
    Actions: "Delete",
  },
  {
    InvoiceNumber: "#IN0003",
    PatientID: "#PT003",
    PatientName: "Carl Kelly",
    PatientImg: "patient3.jpg",
    TotalAmount: "$250.00",
    Status: "Paid",
    Actions: "Delete",
  },
  {
    InvoiceNumber: "#IN0004",
    PatientID: "#PT004",
    PatientName: "Michelle Fairfax",
    PatientImg: "patient4.jpg",
    TotalAmount: "$150.00",
    Status: "Paid",
    Actions: "Delete",
  },
  {
    InvoiceNumber: "#IN0005",
    PatientID: "#PT005",
    PatientName: "Gina Moore",
    PatientImg: "patient5.jpg",
    TotalAmount: "$350.00",
    Status: "Paid",
    Actions: "Delete",
  },
  {
    InvoiceNumber: "#IN0006",
    PatientID: "#PT006",
    PatientName: "Elsie Gilley",
    PatientImg: "patient6.jpg",
    TotalAmount: "$300.00",
    Status: "Paid",
    Actions: "Delete",
  },
  {
    InvoiceNumber: "#IN0007",
    PatientID: "#PT007",
    PatientName: "Joan Gardner",
    PatientImg: "patient7.jpg",
    TotalAmount: "$250.00",
    Status: "Paid",
    Actions: "Delete",
  },
  {
    InvoiceNumber: "#IN0008",
    PatientID: "#PT008",
    PatientName: "Daniel Griffing",
    PatientImg: "patient8.jpg",
    TotalAmount: "$150.00",
    Status: "Paid",
    Actions: "Delete",
  },
  {
    InvoiceNumber: "#IN0009",
    PatientID: "#PT009",
    PatientName: "Walter Roberson",
    PatientImg: "patient9.jpg",
    TotalAmount: "$100.00",
    Status: "Paid",
    Actions: "Delete",
  },
  {
    InvoiceNumber: "#IN0010",
    PatientID: "#PT010",
    PatientName: "Robert Rhodes",
    PatientImg: "patient10.jpg",
    TotalAmount: "$120.00",
    Status: "Paid",
    Actions: "Delete",
  },
];

export default {
  data() {
    return {
      title: "Transactions",
      text: "Dashboard",
      text1: "Transactions",
      data,
      columns,
    };
  },
  name: "admin/transactions-list",
};
</script>
