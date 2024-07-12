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
            <!-- Recent Orders -->
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
                        <div>{{ record.MedicineName }}</div>
                      </template>
                      <template v-else-if="column.key === 'action'">
                        <div class="actions">
                          <a
                            class="btn btn-sm bg-success-light me-2"
                            data-bs-toggle="modal"
                            href="#edit_invoice_report"
                          >
                            <i class="fe fe-pencil"></i> Edit
                          </a>
                          <router-link
                            class="btn btn-sm bg-default-light me-2"
                            to="/pharmacy/invoice"
                          >
                            <i class="fas fa-file-alt"></i> Invoice
                          </router-link>
                          <a
                            href="javascript:void(0);"
                            class="btn btn-sm bg-danger-light"
                            data-bs-toggle="modal"
                            data-bs-target="#deleteConfirmModal"
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
            <!-- /Recent Orders -->
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
    title: "Invoice No",
    dataIndex: "InvoiceNo",
    sorter: {
      compare: (a, b) => {
        a = a.InvoiceNo.toLowerCase();
        b = b.InvoiceNo.toLowerCase();
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
    title: "Total Price",
    dataIndex: "TotalPrice",
    sorter: {
      compare: (a, b) => {
        a = a.TotalPrice.toLowerCase();
        b = b.TotalPrice.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Date",
    dataIndex: "Date",
    sorter: {
      compare: (a, b) => {
        a = a.Date.toLowerCase();
        b = b.Date.toLowerCase();
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
    InvoiceNo: "20170001",
    MedicineName: "Abilify,Actamin,Actamin",
    TotalPrice: "$220",
    Date: "12-5-2023",
  },
  {
    InvoiceNo: "20169999",
    MedicineName: "Abilify,Actamin",
    TotalPrice: "$100",
    Date: "13-5-2023",
  },
  {
    InvoiceNo: "20169998",
    MedicineName: "Abilify",
    TotalPrice: "$150",
    Date: "14-5-2023",
  },
  {
    InvoiceNo: "20170001",
    MedicineName: "Abilify,Actamin,Actamin",
    TotalPrice: "$220",
    Date: "15-5-2023",
  },
];

export default {
  data() {
    return {
      title: "Sales",
      text: "Dashboard",
      text1: "Sales",
      columns,
      data,
    };
  },
  name: "pharmacy/sales",
};
</script>
