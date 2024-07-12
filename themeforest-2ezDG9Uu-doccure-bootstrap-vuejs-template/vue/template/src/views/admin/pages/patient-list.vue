<template>
  <div class="main-wrapper">
    <adminheader></adminheader>
    <adminsidebar></adminsidebar>

    <!-- Page Wrapper -->
    <div class="page-wrapper">
      <div class="content container-fluid">
        <adminbreadcrumb1 :title="title" :text="text" :text1="text1" :text2="text2" />
        <!-- /Page Header -->

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
                      <template v-if="column.key === 'PatientName'">
                        <h2 class="table-avatar">
                          <router-link to="/admin/profile" class="avatar avatar-sm me-2"
                            ><img
                              class="avatar-img rounded-circle"
                              :src="
                                require(`@/assets/admin/img/patients/${record.PatientImg}`)
                              "
                              alt="User Image"
                          /></router-link>
                          <router-link to="/admin/profile">{{
                            record.PatientName
                          }}</router-link>
                        </h2>
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
</template>

<script>
const columns = [
  {
    title: "Paitent ID",
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
    title: "Age",
    dataIndex: "Age",
    key: "Age",
    sorter: {
      compare: (a, b) => {
        a = a.Age.toLowerCase();
        b = b.Age.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },

  {
    title: "Address",
    dataIndex: "Address",
    key: "Address",
    sorter: {
      compare: (a, b) => {
        a = a.Address.toLowerCase();
        b = b.Address.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },

  {
    title: "Phone",
    dataIndex: "Phone",
    key: "Phone",
    sorter: {
      compare: (a, b) => {
        a = a.Phone.toLowerCase();
        b = b.Phone.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },

  {
    title: "Last Visit",
    dataIndex: "LastVisit",
    key: "LastVisit",
    sorter: {
      compare: (a, b) => {
        a = a.LastVisit.toLowerCase();
        b = b.LastVisit.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },

  {
    title: "Paid",
    dataIndex: "Paid",
    key: "Paid",
    sorter: {
      compare: (a, b) => {
        a = a.Paid.toLowerCase();
        b = b.Paid.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
];

const data = [
  {
    PatientID: "#PT001",
    PatientName: "Charlene Reed",
    PatientImg: "patient1.jpg",
    Age: 29,
    Address: "4417  Goosetown Drive, Taylorsville, North Carolina, 28681",
    Phone: 8286329170,
    LastVisit: "20 Mar 2023",
    Paid: "$100.00",
  },
  {
    PatientID: "#PT002",
    PatientName: "Travis Trimble",
    PatientImg: "patient2.jpg",
    Age: 23,
    Address: "4026  Fantages Way, Brunswick, Maine, 04011",
    Phone: 2077299974,
    LastVisit: "22 Mar 2023",
    Paid: "$200.00",
  },
  {
    PatientID: "#PT003",
    PatientName: "Carl Kelly",
    PatientImg: "patient3.jpg",
    Age: 29,
    Address: "2037 Pearcy Avenue, Decatur, Indiana, 46733",
    Phone: 2607247769,
    LastVisit: "21 Mar 2023",
    Paid: "$250.00",
  },
  {
    PatientID: "#PT004",
    PatientName: "Michelle Fairfax",
    PatientImg: "patient4.jpg",
    Age: 25,
    Address: "2037 Pearcy Avenue, Decatur, Indiana, 46733",
    Phone: 5043686874,
    LastVisit: "21 Apr 2023",
    Paid: "$150.00",
  },
  {
    PatientID: "#PT005",
    PatientName: "Gina Moore",
    PatientImg: "patient5.jpg",
    Age: 23,
    Address: "888  Everette Alley, Hialeah, Florida, 33012",
    Phone: 9548207887,
    LastVisit: "18 Apr 2023",
    Paid: "$350.00",
  },
  {
    PatientID: "#PT006",
    PatientName: "Elsie Gilley",
    PatientImg: "patient6.jpg",
    Age: 16,
    Address: "644  Coffman Alley, Bowling Green, Kentucky, 42101",
    Phone: 3153844562,
    LastVisit: "18 Apr 2023",
    Paid: "$300.00",
  },
  {
    PatientID: "#PT007",
    PatientName: "Joan Gardner",
    PatientImg: "patient7.jpg",
    Age: 25,
    Address: "2399  Hillview Drive, San Francisco, California, 94103",
    Phone: 7072202603,
    LastVisit: "18 Apr 2023",
    Paid: "$250.00",
  },
  {
    PatientID: "#PT008",
    PatientName: "Daniel Griffing",
    PatientImg: "patient8.jpg",
    Age: 21,
    Address: "4914  Hilltop Haven Drive, Passaic, New Jersey, 07055",
    Phone: 9737739497,
    LastVisit: "7 Apr 2023",
    Paid: "$150.00",
  },
  {
    PatientID: "#PT009",
    PatientName: "Walter Roberson",
    PatientImg: "patient9.jpg",
    Age: 18,
    Address: "1299  Star Trek Drive, Panama City, Florida, 32405",
    Phone: 8503584445,
    LastVisit: "11 Apr 2023",
    Paid: "$100.00",
  },
  {
    PatientID: "#PT010",
    PatientName: "Robert Rhodes",
    PatientImg: "patient10.jpg",
    Age: 19,
    Address: "1214  Hamill Avenue, Del Mar, California, 92014",
    Phone: 8582595285,
    LastVisit: "12 Apr 2023",
    Paid: "$120.00",
  },
  {
    PatientID: "#PT011",
    PatientName: "Harry Williams",
    PatientImg: "patient11.jpg",
    Age: 9,
    Address: "4566  Sampson Street, Denver, Colorado, 80202",
    Phone: 3036077075,
    LastVisit: "14 Apr 2023",
    Paid: "$130.00",
  },
  {
    PatientID: "#PT012",
    PatientName: "Robert Johnston",
    PatientImg: "patient12.jpg",
    Age: 29,
    Address: "1996  Crummit Lane, Beatrice, Nebraska, 68310",
    Phone: 4022231492,
    LastVisit: "7 May 2023",
    Paid: "$260.00",
  },
  {
    PatientID: "#PT013",
    PatientName: "Tracy Mason",
    PatientImg: "patient13.jpg",
    Age: 32,
    Address: "4211  Vesta Drive, TOLEDO, Washington, 98591",
    Phone: 7737265795,
    LastVisit: "9 May 2023",
    Paid: "$290.00",
  },
  {
    PatientID: "#PT014",
    PatientName: "Daniel Finch",
    PatientImg: "patient14.jpg",
    Age: 23,
    Address: "186  Bryan Street, Greensboro, North Carolina, 27409",
    Phone: 3362314023,
    LastVisit: "5 May 2023",
    Paid: "$300.00",
  },
  {
    PatientID: "#PT015",
    PatientName: "Jessica Garza",
    PatientImg: "patient15.jpg",
    Age: 10,
    Address: "4672  Rose Street, Schaumburg, Illinois, 60173",
    Phone: 7082788201,
    LastVisit: "6 May 2023",
    Paid: "$310.00",
  },
];

export default {
  data() {
    return {
      title: "List of Patient",
      text: "Dashboard",
      text1: "Users",
      text2: "Patient",
      data,
      columns,
    };
  },
};
</script>
