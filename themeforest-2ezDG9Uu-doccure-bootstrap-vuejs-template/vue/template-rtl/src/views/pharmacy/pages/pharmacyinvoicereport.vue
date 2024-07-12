<template>
  <div class="main-Wrapper">
    <pharmacyheader></pharmacyheader>
    <pharmacysidebar></pharmacysidebar>
    <!-- Page Wrapper -->
    <div class="page-wrapper">
      <div class="content container-fluid">
        <pharmacybreadcrumb1 :title="title" :text="text" :text1="text1" />
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
                          <span class="avatar avatar-sm me-2">
                            <img
                              class="avatar-img"
                              :src="
                                require(`@/assets/pharmacy/img/product/${record.Image}`)
                              "
                              alt="Product Image"
                          /></span>
                          {{ record.MedicineName }}
                        </div>
                      </template>
                      <template v-else-if="column.key === 'InvoiceNumber'">
                        <div class="sorting_1">
                          <router-link to="/pharmacy/invoice">#IN0001</router-link>
                        </div>
                      </template>
                      <template v-else-if="column.key === 'status'">
                        <span :class="record.Class">{{ record.Status }}</span>
                      </template>
                      <template v-else-if="column.key === 'action'">
                        <div>
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
    <!-- /Page Wrapper -->
  </div>
  <pharmacymodel />
  <pharmacydelete />
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
    title: "Medicine Name",
    dataIndex: "MedicineName",
    key: "Name",
    sorter: {
      compare: (a, b) => {
        a = a.MedicineName.toLowerCase();
        b = b.MedicineName.toLowerCase();
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
    title: "Created Date",
    dataIndex: "CreatedDate",
    sorter: {
      compare: (a, b) => {
        a = a.CreatedDate.toLowerCase();
        b = b.CreatedDate.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Status",
    dataIndex: "Status",
    key: "status",
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
    key: "action",
    sorter: true,
  },
];
const data = [
  {
    InvoiceNumber: "#IN0001",
    MedicineName: "Abilify,Actamin",
    TotalAmount: "$100.00",
    CreatedDate: "9 Apr 2023",
    Class: "badge rounded-pill bg-success inv-badge",
    Status: "Paid",
    Image: "product.jpg",
  },
  {
    InvoiceNumber: "#IN0002",
    MedicineName: "Abilify,Actamin",
    TotalAmount: "$200.00",
    CreatedDate: "29 Mar 2023",
    Class: "badge rounded-pill bg-success inv-badge",
    Status: "Paid",
    Image: "product.jpg",
  },
  {
    InvoiceNumber: "#IN0003",
    MedicineName: "Abilify,Actamin",
    TotalAmount: "$250.00",
    CreatedDate: "25 Apr 2023",
    Class: "badge rounded-pill bg-danger inv-badge",
    Status: "Pending",
    Image: "product.jpg",
  },
  {
    InvoiceNumber: "#IN0004",
    MedicineName: "Abilify,Actamin",
    TotalAmount: "$150.00",
    CreatedDate: "9 Mar 2023",
    Class: "badge rounded-pill bg-warning inv-badge",
    Status: "Unpaid",
    Image: "product.jpg",
  },
  {
    InvoiceNumber: "#IN0005",
    MedicineName: "Abilify,Actamin",
    TotalAmount: "$350.00",
    CreatedDate: "19 May 2023",
    Class: "badge rounded-pill bg-success inv-badge",
    Status: "Paid",
    Image: "product.jpg",
  },
  {
    InvoiceNumber: "#IN0006",
    MedicineName: "Abilify,Actamin",
    TotalAmount: "$300.00",
    CreatedDate: "12 Mar 2023",
    Class: "badge rounded-pill bg-success inv-badge",
    Status: "Paid",
    Image: "product.jpg",
  },
  {
    InvoiceNumber: "#IN0007",
    MedicineName: "Abilify,Actamin",
    TotalAmount: "$250.00",
    CreatedDate: "25 Mar 2023",
    Class: "badge rounded-pill bg-success inv-badge",
    Status: "Paid",
    Image: "product.jpg",
  },
  {
    InvoiceNumber: "#IN0008",
    MedicineName: "Abilify,Actamin,Actamin",
    TotalAmount: "$150.00",
    CreatedDate: "30 Mar 2023",
    Class: "badge rounded-pill bg-success inv-badge",
    Status: "Paid",
    Image: "product.jpg",
  },
  {
    InvoiceNumber: "#IN0009",
    MedicineName: "Abilify",
    TotalAmount: "$100.00",
    CreatedDate: "5 May 2023",
    Class: "badge rounded-pill bg-success inv-badge",
    Status: "Paid",
    Image: "product.jpg",
  },
  {
    InvoiceNumber: "#IN0010",
    MedicineName: "Abilify,Actamin,Actamin",
    TotalAmount: "$120.00",
    CreatedDate: "7 May 2023",
    Class: "badge rounded-pill bg-success inv-badge",
    Status: "Paid",
    Image: "product.jpg",
  },
];

export default {
  data() {
    return {
      title: "Invoice Report",
      text: "Dashboard",
      text1: "Invoice Report",
      columns,
      data,
    };
  },
  name: "pharmacy/invoice-report",
};
</script>
