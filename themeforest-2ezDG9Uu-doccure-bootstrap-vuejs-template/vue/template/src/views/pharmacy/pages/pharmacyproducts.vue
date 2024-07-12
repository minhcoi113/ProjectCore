<template>
  <div class="main-wrapper">
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
                      <template v-if="column.key === 'ProductName'">
                        <div class="table-avatar">
                          <span class="avatar avatar-sm me-2"
                            ><img
                              class="avatar-img"
                              :src="
                                require(`@/assets/pharmacy/img/product/${record.Image}`)
                              "
                              alt="product image"
                          /></span>
                          {{ record.ProductName }}
                        </div>
                      </template>
                      <template v-if="column.key === 'Quantity'">
                        <span :class="record.Class">{{ record.Quantity }}</span>
                      </template>
                      <template v-if="column.key === 'Expire'">
                        <span class="btn btn-sm bg-danger-light">{{
                          record.Expire
                        }}</span>
                      </template>
                      <template v-else-if="column.key === 'action'">
                        <div class="actions">
                          <router-link
                            class="btn btn-sm bg-success-light me-2"
                            to="/pharmacy/edit-product"
                          >
                            <i class="fe fe-pencil"></i> Edits
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
  <!-- /Main Wrapper -->
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
    title: "Product Name",
    dataIndex: "ProductName",
    key: "ProductName",
    sorter: {
      compare: (a, b) => {
        a = a.ProductName.toLowerCase();
        b = b.ProductName.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Category",
    dataIndex: "Category",
    sorter: {
      compare: (a, b) => {
        a = a.Category.toLowerCase();
        b = b.Category.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Price",
    dataIndex: "Price",
    sorter: {
      compare: (a, b) => {
        a = a.Price.toLowerCase();
        b = b.Price.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Quantity",
    dataIndex: "Quantity",
    key: "Quantity",
    sorter: {
      compare: (a, b) => {
        a = a.Quantity.toLowerCase();
        b = b.Quantity.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Discount",
    dataIndex: "Discount",

    sorter: {
      compare: (a, b) => {
        a = a.Discount.toLowerCase();
        b = b.Discount.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },

  {
    title: "Expire",
    dataIndex: "Expire",
    key: "Expire",

    sorter: {
      compare: (a, b) => {
        a = a.Expire.toLowerCase();
        b = b.Expire.toLowerCase();
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
    num: "1",
    ProductName: "Cordacriptine Mardipine",
    Category: "Skin care",
    Price: "$22",
    Quantity: "THERE ONLY 2",
    Discount: "0%",
    Expire: "THE PRODUCT IS EXPIRED",
    Class: "btn btn-sm bg-danger-light",
    Image: "product14.jpg",
  },
  {
    num: "2",
    ProductName: "Abilify",
    Category: "Phytopathology",
    Price: "$22",
    Quantity: "THERE ONLY 2",
    Discount: "0%",
    Expire: "THE PRODUCT IS EXPIRED",
    Class: "btn btn-sm bg-danger-light",
    Image: "product.jpg",
  },
  {
    num: "3",
    ProductName: "Rapalac Neuronium",
    Category: "Skin care",
    Price: "$16",
    Quantity: "213",
    Class: "",
    Discount: "0%",
    Expire: "THE PRODUCT IS EXPIRED",
    Image: "product13.jpg",
  },
  {
    num: "4",
    ProductName: "Actamin",
    Category: "Phytopathology",
    Price: "$22",
    Quantity: "THERE ONLY 5",
    Class: "btn btn-sm bg-danger-light",
    Discount: "0%",
    Expire: "THE PRODUCT IS EXPIRED",
    Image: "product1.jpg",
  },
  {
    num: "5",
    ProductName: "Acetrace Amionel",
    Category: "Body care",
    Price: "$10",
    Quantity: "22",
    Class: "",
    Discount: "0%",
    Expire: "THE PRODUCT IS EXPIRED",
    Image: "product12.jpg",
  },
  {
    num: "6",
    ProductName: "Ergorinex Caffeigestin",
    Category: "Hair care",
    Price: "$15",
    Quantity: "22",
    Class: "",
    Discount: "0%",
    Expire: "THE PRODUCT IS EXPIRED",
    Image: "product11.jpg",
  },
  {
    num: "7",
    ProductName: "Adderall",
    Category: "Phytopathology",
    Price: "$10",
    Quantity: "22",
    Class: "",
    Discount: "0%",
    Expire: "THE PRODUCT IS EXPIRED",
    Image: "product2.jpg",
  },
  {
    num: "8",
    ProductName: "Lysofranil Dorzostin",
    Category: "Hair care",
    Price: "$10",
    Quantity: "22",
    Class: "",
    Discount: "0%",
    Expire: "THE PRODUCT IS EXPIRED",
    Image: "product10.jpg",
  },
];
export default {
  data() {
    return {
      title: "Products",
      text: "Dashboard",
      text1: "Products",
      Add: "Add New",
      columns,
      data,
    };
  },
  name: "pharmacy/products",
};
</script>
