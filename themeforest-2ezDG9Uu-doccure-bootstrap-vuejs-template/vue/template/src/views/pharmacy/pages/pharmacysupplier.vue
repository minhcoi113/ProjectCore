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
                          {{ record.Product }}
                        </div>
                      </template>

                      <template v-else-if="column.key === 'action'">
                        <div class="actions">
                          <router-link
                            class="btn btn-sm bg-success-light me-2"
                            to="/pharmacy/edit-supplier"
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
    title: "ID",
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
    title: "Product",
    dataIndex: "Product",
    key: "Name",
    sorter: {
      compare: (a, b) => {
        a = a.Product.toLowerCase();
        b = b.Product.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Name",
    dataIndex: "Name",
    sorter: {
      compare: (a, b) => {
        a = a.Name.toLowerCase();
        b = b.Name.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Phone",
    dataIndex: "Phone",
    sorter: {
      compare: (a, b) => {
        a = a.Phone.toLowerCase();
        b = b.Phone.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Email",
    dataIndex: "Email",
    sorter: {
      compare: (a, b) => {
        a = a.Email.toLowerCase();
        b = b.Email.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Address",
    dataIndex: "Address",
    sorter: {
      compare: (a, b) => {
        a = a.Address.toLowerCase();
        b = b.Address.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Company",
    dataIndex: "Company",
    sorter: {
      compare: (a, b) => {
        a = a.Company.toLowerCase();
        b = b.Company.toLowerCase();
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
    ID: "25",
    Product: "Abilify",
    Name: "Discarsa",
    Phone: "+51 1542565",
    Email: "Discarsa@gmail.com",
    Address: "Paseo Los Robles",
    Company: "Discarsa Nicaragua",
    Image: "product.jpg",
  },
  {
    ID: "33",
    Product: "Actamin",
    Name: "Proveedor",
    Phone: "+51 23687541",
    Email: "proveedor@gmail.com",
    Address: "Av circunvalación # 234",
    Company: "mi farmacia",
    Image: "product1.jpg",
  },
  {
    ID: "42",
    Product: "Adderall",
    Name: "Discarsa",
    Phone: "+51 96588552",
    Email: "Discarsa@gmail.com",
    Address: "Paseo Los Robles",
    Company: "Discarsa Nicaragua",
    Image: "product2.jpg",
  },
];
export default {
  data() {
    return {
      title: "Supplier",
      text: "Dashboard",
      text1: "Supplier",
      Add: "Add New",
      columns,
      data,
    };
  },
  name: "pharmacy/supplier",
};
</script>
