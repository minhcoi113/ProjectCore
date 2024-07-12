<template>
  <div class="main-Wrapper">
    <pharmacyheader></pharmacyheader>
    <pharmacysidebar></pharmacysidebar>
    <!-- Page Wrapper -->
    <div class="page-wrapper">
      <div class="content container-fluid">
        <pharmacybreadcrumb2 :title="title" :text="text" :text1="text1" :Add="Add" />
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
                        <div class="table-avatar">
                          <span class="avatar avatar-sm me-2"
                            ><img
                              class="avatar-img"
                              :src="
                                require(`@/assets/pharmacy/img/product/${record.Image}`)
                              "
                              alt="product image"
                          /></span>
                          {{ record.MedicineName }}
                        </div>
                      </template>
                      <template v-else-if="column.key === 'action'">
                        <div class="actions">
                          <router-link
                            class="btn btn-sm bg-success-light me-2"
                            to="edit-purchase"
                          >
                            <i class="fe fe-pencil"></i> Edit
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
  <pharmacydelete />
</template>
<script>
const columns = [
  {
    title: "Purchase Date",
    dataIndex: "PurchaseDate",
    sorter: {
      compare: (a, b) => {
        a = a.PurchaseDate.toLowerCase();
        b = b.PurchaseDate.toLowerCase();
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
    title: "Medicine Category",
    dataIndex: "MedicineCategory",
    sorter: {
      compare: (a, b) => {
        a = a.MedicineCategory.toLowerCase();
        b = b.MedicineCategory.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Purchase Price",
    dataIndex: "PurchasePrice",
    sorter: {
      compare: (a, b) => {
        a = a.PurchasePrice.toLowerCase();
        b = b.PurchasePrice.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Quantity",
    dataIndex: "Quantity",
    sorter: {
      compare: (a, b) => {
        a = a.Quantity.toLowerCase();
        b = b.Quantity.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Supplier",
    dataIndex: "Supplier",
    sorter: {
      compare: (a, b) => {
        a = a.Supplier.toLowerCase();
        b = b.Supplier.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Expire Date",
    dataIndex: "ExpireDate",
    sorter: {
      compare: (a, b) => {
        a = a.ExpireDate.toLowerCase();
        b = b.ExpireDate.toLowerCase();
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
    id: "1",
    PurchaseDate: "13-5-2023",
    MedicineName: "Abilify",
    MedicineCategory: "Aripiprazole",
    PurchasePrice: "$220",
    Quantity: "60",
    Supplier: "Bradley",
    ExpireDate: "13-06-23",
    Image: "product.jpg",
  },
  {
    id: "2",
    PurchaseDate: "12-5-2023",
    MedicineName: "Adderall",
    MedicineCategory: "Phytopathology",
    PurchasePrice: "$30",
    Quantity: "20",
    Supplier: "Douglas",
    ExpireDate: "13-06-23",
    Image: "product1.jpg",
  },
  {
    id: "3",
    PurchaseDate: "11-5-2023",
    MedicineName: "Actamin",
    MedicineCategory: "Phytopathology",
    PurchasePrice: "$58",
    Quantity: "33",
    Supplier: "Douglas",
    ExpireDate: "20-06-23",
    Image: "product2.jpg",
  },
  {
    id: "4",
    PurchaseDate: "10-5-2023",
    MedicineName: "Abilify",
    MedicineCategory: "Aripiprazole",
    PurchasePrice: "$336",
    Quantity: "50",
    Supplier: "Bradley",
    ExpireDate: "13-06-23",
    Image: "product.jpg",
  },
  {
    id: "5",
    PurchaseDate: "9-5-2023",
    MedicineName: "Adderall",
    MedicineCategory: "Phytopathology",
    PurchasePrice: "$10",
    Quantity: "605",
    Supplier: "Douglas",
    ExpireDate: "13-06-23",
    Image: "product1.jpg",
  },
  {
    id: "6",
    PurchaseDate: "8-5-2023",
    MedicineName: "Actamin",
    MedicineCategory: "Phytopathology",
    PurchasePrice: "$15",
    Quantity: "160",
    Supplier: "Douglas",
    ExpireDate: "20-06-23",
    Image: "product2.jpg",
  },
];

export default {
  data() {
    return {
      title: "Purchase",
      text: "Dashboard",
      text1: "Purchase",
      Add: "Add New",
      columns,
      data,
    };
  },
  name: "pharmacy/purchase",
};
</script>
