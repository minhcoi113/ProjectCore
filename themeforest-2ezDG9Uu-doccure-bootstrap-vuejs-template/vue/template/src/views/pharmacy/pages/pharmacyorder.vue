<template>
  <div class="main-Wrapper">
    <pharmacyheader></pharmacyheader>
    <pharmacysidebar></pharmacysidebar>
    <!-- Page Wrapper -->
    <div class="page-wrapper">
      <div class="content container-fluid">
        <pharmacybreadcrumb1 :title="title" :text="text" :text1="text1" />
        <div class="row">
          <div class="col-md-12"></div>
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
                    <template v-if="column.key === 'Supplier'">
                      <div>
                        {{ record.SupplierID }}
                      </div>
                    </template>
                    <template v-else-if="column.key === 'action'">
                      <div class="actions">
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
    title: "Supplier ID",
    dataIndex: "SupplierID",
    key: "Supplier",

    sorter: {
      compare: (a, b) => {
        a = a.SupplierID.toLowerCase();
        b = b.SupplierID.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Supplier Name",
    dataIndex: "SupplierName",
    sorter: {
      compare: (a, b) => {
        a = a.SupplierName.toLowerCase();
        b = b.SupplierName.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Order by",
    dataIndex: "Orderby",
    sorter: {
      compare: (a, b) => {
        a = a.Orderby.toLowerCase();
        b = b.Orderby.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Add order",
    dataIndex: "Addorder",
    key: "",
    sorter: {
      compare: (a, b) => {
        a = a.Addorder.toLowerCase();
        b = b.Addorder.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Order list",
    dataIndex: "Orderlist",

    sorter: {
      compare: (a, b) => {
        a = a.Orderlist.toLowerCase();
        b = b.Orderlist.toLowerCase();
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
    SupplierID: "256",
    SupplierName: "Douglas Meyer",
    Orderby: "Trinity General Hospital",
    Addorder: "10-5-2023",
    Orderlist: "Dolofin Antigripal(Dolo)  3",
    Action: "Delete",
  },
  {
    num: "2",
    SupplierID: "20",
    SupplierName: "Tyler Robinson",
    Orderby: "Grand Valley Clinic",
    Addorder: "10-5-2023",
    Orderlist: "Dolofin Antigripal(Dolo)  50Dolofin Antigripal(Dolo)  4",
    Action: "Delete",
  },
  {
    num: "3",
    SupplierID: "15",
    SupplierName: "Mary Dixon",
    Orderby: "Grand Plains Clinic",
    Addorder: "10-5-2023",
    Orderlist: "Dolo 650(CIpla)  0",
    Action: "Delete",
  },
  {
    num: "4",
    SupplierID: "156",
    SupplierName: "Kurt Wooten",
    Orderby: "Mercy Vale Clinic",
    Addorder: "10-5-2023",
    Orderlist: "Tektonik(None)  2",
    Action: "Delete",
  },
  {
    num: "5",
    SupplierID: "23",
    SupplierName: "Vickie Pritchett",
    Orderby: "Kindred Soul Clinic",
    Addorder: "10-5-2023",
    Orderlist: "Dolofin Antigripal(Dolo)  4",
    Action: "Delete",
  },
  {
    num: "6",
    SupplierID: "35",
    SupplierName: "Joanne Fry",
    Orderby: "Hope Haven Hospital",
    Addorder: "10-5-2023",
    Orderlist: "Dolo 650(CIpla)  0",
    Action: "Delete",
  },
  {
    num: "7",
    SupplierID: "205",
    SupplierName: "Christopher Johnson",
    Orderby: "Hill Crest Clinic",
    Addorder: "10-5-2023",
    Orderlist: "Dolofin Antigripal(Dolo)  50Dolofin Antigripal(Dolo)  4",
    Action: "Delete",
  },
];

export default {
  data() {
    return {
      title: "Order",
      text: "Dashboard",
      text1: "Order",
      columns,
      data,
    };
  },
  name: "pharmacy/order ",
};
</script>
