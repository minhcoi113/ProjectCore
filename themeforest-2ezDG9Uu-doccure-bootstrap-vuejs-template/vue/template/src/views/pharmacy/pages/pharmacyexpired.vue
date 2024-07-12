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
                        <div class="table-avatar">
                          <span class="avatar avatar-sm me-2"
                            ><img
                              class="avatar-img"
                              :src="
                                require(`@/assets/pharmacy/img/product/${record.Image}`)
                              "
                              alt="product image"
                          /></span>
                          {{ record.BrandName }}
                        </div>
                      </template>
                      <template v-else-if="column.key === 'Quantity'">
                        <span :class="record.Class">{{ record.Quantity }}</span>
                      </template>
                      <template v-else-if="column.key === 'Expire'">
                        <span class="btn btn-sm bg-danger-light">{{
                          record.Expire
                        }}</span>
                      </template>
                      <template v-else-if="column.key === 'action'">
                        <div class="actions">
                          <a
                            class="btn btn-sm bg-success-light me-2"
                            href="javascript:void(0);"
                          >
                            <i class="fe fe-pencil"></i> Edit
                          </a>
                          <a
                            href="javascript:void(0);"
                            class="btn btn-sm bg-danger-light me-2"
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
    title: "Brand Name",
    dataIndex: "BrandName",
    key: "Name",
    sorter: {
      compare: (a, b) => {
        a = a.BrandName.toLowerCase();
        b = b.BrandName.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Genetic Name",
    dataIndex: "GeneticName",
    sorter: {
      compare: (a, b) => {
        a = a.GeneticName.toLowerCase();
        b = b.GeneticName.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Category",
    dataIndex: "Category",
    sorter: {
      compare: (a, b) => {
        a = a.Price.toLowerCase();
        b = b.Price.toLowerCase();
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
    BrandName: "Abilify",
    GeneticName: "Aripiprazole",
    Category: "Phytopathology",
    Price: "$22",
    Quantity: "THERE ONLY 2",
    Discount: "0%",
    Expire: "THE PRODUCT IS EXPIRED",
    Class: "btn btn-sm bg-danger-light",
    Image: "product.jpg",
  },
  {
    num: "2",
    BrandName: "Abilify",
    GeneticName: "Aripiprazole",
    Category: "Phytopathology",
    Price: "$22",
    Quantity: "50",
    class: "",
    Discount: "0%",
    Expire: "THE PRODUCT IS EXPIRED",
    Image: "product.jpg",
  },
  {
    num: "3",
    BrandName: "Abilify",
    GeneticName: "Aripiprazole",
    Category: "Phytopathology",
    Price: "$22",
    Quantity: "120",
    Discount: "0%",
    Expire: "THE PRODUCT IS EXPIRED",
    class: "",
    Image: "product.jpg",
  },
  {
    num: "4",
    BrandName: "Actamin",
    GeneticName: "Amphetamine",
    Category: "Phytopathology",
    Price: "$22",
    Quantity: "THERE ONLY 5",
    Discount: "0%",
    Expire: "THE PRODUCT IS EXPIRED",
    Class: "btn btn-sm bg-danger-light",
    Image: "product1.jpg",
  },
  {
    num: "5",
    BrandName: "Adderall",
    GeneticName: "Amphetamine",
    Category: "Phytopathology",
    Price: "$10",
    Quantity: "22",
    Discount: "0%",
    Expire: "THE PRODUCT IS EXPIRED",
    Class: "",
    Image: "product2.jpg",
  },
  {
    num: "6",
    BrandName: "Abilify",
    GeneticName: "Aripiprazole",
    Category: "Phytopathology",
    Price: "$22",
    Quantity: "213",
    Discount: "0%",
    Expire: "THE PRODUCT IS EXPIRED",
    class: "",
    Image: "product.jpg",
  },
];
export default {
  data() {
    return {
      title: "Expired",
      text: "Medicine",
      text1: "Expired",
      columns,
      data,
    };
  },
  name: "pharmacy/expired",
};
</script>
