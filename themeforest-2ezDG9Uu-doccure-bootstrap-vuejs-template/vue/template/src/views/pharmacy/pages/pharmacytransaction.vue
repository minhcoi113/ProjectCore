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
                          <span class="avatar avatar-sm me-2"
                            ><img
                              class="avatar-img"
                              :src="
                                require(`@/assets/pharmacy/img/product/${record.Image}`)
                              "
                              alt="User Image"
                          /></span>
                          {{ record.ProductName }}
                        </div>
                      </template>
                      <template v-else-if="column.key === 'InvoiceNo'">
                        <router-link to="/pharmacy/invoice">{{
                          record.InvoiceNo
                        }}</router-link>
                      </template>
                      <template v-else-if="column.key === 'status'">
                        <div class="text-center">
                          <span class="badge rounded-pill bg-success inv-badge">{{
                            record.Status
                          }}</span>
                        </div>
                      </template>
                      <template v-else-if="column.key === 'action'">
                        <div>
                          <div class="actions">
                            <router-link
                              class="btn btn-sm bg-danger-light"
                              data-bs-toggle="modal"
                              to="#delete_modal"
                            >
                              <i class="fe fe-trash"></i> Delete
                            </router-link>
                          </div>
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
  <pharmacydelete />
</template>
<script>
const columns = [
  {
    title: "Invoice No",
    dataIndex: "InvoiceNo",
    key: "InvoiceNo",
    sorter: {
      compare: (a, b) => {
        a = a.InvoiceNo.toLowerCase();
        b = b.InvoiceNo.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Product ID",
    dataIndex: "ProductID",
    sorter: {
      compare: (a, b) => {
        a = a.ProductID.toLowerCase();
        b = b.ProductID.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Product Name",
    dataIndex: "ProductName",
    key: "Name",
    sorter: {
      compare: (a, b) => {
        a = a.ProductName.toLowerCase();
        b = b.ProductName.toLowerCase();
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
    InvoiceNo: "#IN0001",
    ProductID: "#01",
    ProductName: "Abilify",
    TotalAmount: "$100.00",
    Status: "Paid",
    Actions: "Delete",
    Image: "product.jpg",
  },
  {
    InvoiceNo: "#IN0002",
    ProductID: "#02",
    ProductName: "ITONE eye drops 10ml",
    TotalAmount: "$200.00",
    Status: "Paid",
    Actions: "Delete",
    Image: "product3.jpg",
  },
  {
    InvoiceNo: "#IN0003",
    ProductID: "#03",
    ProductName: "Safi Natural Blood Purifier",
    TotalAmount: "$250.00",
    Status: "Paid",
    Actions: "Delete",
    Image: "product4.jpg",
  },
  {
    InvoiceNo: "#IN0004",
    ProductID: "#04",
    ProductName: "Moisturization & Nourishment",
    TotalAmount: "$150.00",
    Status: "Paid",
    Actions: "Delete",
    Image: "product5.jpg",
  },
  {
    InvoiceNo: "#IN0005",
    ProductID: "#05",
    ProductName: "Blackhead Removal",
    TotalAmount: "$350.00",
    Status: "Paid",
    Actions: "Delete",
    Image: "product6.jpg",
  },
  {
    InvoiceNo: "#IN0006",
    ProductID: "#06",
    ProductName: "Abilify",
    TotalAmount: "$300.00",
    Status: "Paid",
    Actions: "Delete",
    Image: "product.jpg",
  },
  {
    InvoiceNo: "#IN0007",
    ProductID: "#07",
    ProductName: "Blackhead Removal",
    TotalAmount: "$250.00",
    Status: "Paid",
    Actions: "Delete",
    Image: "product6.jpg",
  },
  {
    InvoiceNo: "#IN0008",
    ProductID: "#08",
    ProductName: "ITONE eye drops 10ml",
    TotalAmount: "$150.00",
    Status: "Paid",
    Actions: "Delete",
    Image: "product3.jpg",
  },
  {
    InvoiceNo: "#IN0009",
    ProductID: "#09",
    ProductName: "Whitening & Fairness",
    TotalAmount: "$100.00",
    Status: "Paid",
    Actions: "Delete",
    Image: "product.jpg",
  },
  {
    InvoiceNo: "#IN0010",
    ProductID: "#10",
    ProductName: "Adderall",
    TotalAmount: "$120.00",
    Status: "Paid",
    Actions: "Delete",
    Image: "product1.jpg",
  },
];

export default {
  data() {
    return {
      title: "Transactions",
      text: "Dashboard",
      text1: "Transactions",
      columns,
      data,
    };
  },
  name: "pharmacy/transactions-list",
};
</script>
