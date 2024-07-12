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
              <div class="card-header">
                <h4 class="card-title">Default Datatable</h4>
                <p class="card-text">
                  This is the most basic example of the datatables with zero
                  configuration. Use the <code>.datatable</code> class to initialize
                  datatables.
                </p>
              </div>
              <div class="card-body">
                <div class="table-responsive">
                  <a-table :columns="columns" :data-source="data">
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
    title: "Name",
    dataIndex: "Name",
    sorter: (a, b) => a.Name.localeCompare(b.Name),
  },
  {
    title: "Position",
    dataIndex: "Position",
    sorter: {
      compare: (a, b) => {
        a = a.Position.toLowerCase();
        b = b.Position.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Office",
    dataIndex: "Office",
    sorter: (a, b) => a.Office.localeCompare(b.Office),
  },
  {
    title: "Age",
    dataIndex: "Age",
    sorter: true,
  },
  {
    title: "Start date",
    dataIndex: "Startdate",
    sorter: {
      compare: (a, b) => {
        a = a.Startdate.toLowerCase();
        b = b.Startdate.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Salary",
    dataIndex: "Salary",
    sorter: {
      compare: (a, b) => {
        a = a.Salary.toLowerCase();
        b = b.Salary.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
];
const data = [
  {
    id: 1,
    Name: "Tiger Nixon",
    Position: "System Architect",
    Office: "Edinburgh",
    Age: 61,
    Startdate: "2023/04/25",
    Salary: "$320,800",
  },
  {
    id: 2,
    Name: "Garrett Winters",
    Position: "Accountant",
    Office: "Tokyo",
    Age: 63,
    Startdate: "2023/06/25",
    Salary: "$170,750",
  },
  {
    id: 3,
    Name: "Ashton Cox",
    Position: "Junior Technical Author",
    Office: "San Francisco",
    Age: 66,
    Startdate: "2023/01/12",
    Salary: "$86,000",
  },
  {
    id: 4,
    Name: "Cedric Kelly",
    Position: "Senior Javascript Developer",
    Office: "Edinburgh",
    Age: 22,
    Startdate: "2023/03/29",
    Salary: "$433,060",
  },
  {
    id: 5,
    Name: "Airi Satou",
    Position: "Accountant",
    Office: "Tokyo",
    Age: 33,
    Startdate: "2023/05/28",
    Salary: "$162,700",
  },
  {
    id: 6,
    Name: "Brielle Williamson",
    Position: "Integration Specialist",
    Office: "New York",
    Age: 61,
    Startdate: "2023/02/02",
    Salary: "$372,000",
  },
  {
    id: 7,
    Name: "Herrod Chandler",
    Position: "Sales Assistant",
    Office: "San Francisco",
    Age: 59,
    Startdate: "2023/06/06",
    Salary: "$137,500",
  },
  {
    id: 8,
    Name: "Rhona Davidson",
    Position: "Integration Specialist",
    Office: "Tokyo",
    Age: 55,
    Startdate: "2023/05/14",
    Salary: "$327,900",
  },
  {
    id: 9,
    Name: "Colleen Hurst",
    Position: "Javascript Developer",
    Office: "San Francisco",
    Age: 39,
    Startdate: "2023/07/15",
    Salary: "$205,500",
  },
  {
    id: 10,
    Name: "Sonya Frost",
    Position: "Software Engineer",
    Office: "Edinburgh",
    Age: 23,
    Startdate: "2023/02/13",
    Salary: "$103,600",
  },
  {
    id: 11,
    Name: "Jena Gaines",
    Position: "Office Manager",
    Office: "London",
    Age: 30,
    Startdate: "2023/02/19",
    Salary: "$90,560",
  },
  {
    id: 12,
    Name: "Quinn Flynn",
    Position: "Support Lead",
    Office: "Edinburgh",
    Age: 22,
    Startdate: "2023/03/03",
    Salary: "$342,000",
  },
  {
    id: 13,
    Name: "Charde Marshall",
    Position: "Regional Director",
    Office: "San Francisco",
    Age: 36,
    Startdate: "2023/07/16",
    Salary: "$470,600",
  },
  {
    id: 14,
    Name: "Haley Kennedy",
    Position: "Senior Marketing Designer",
    Office: "London",
    Age: 43,
    Startdate: "2023/04/18",
    Salary: "$313,500",
  },
  {
    id: 15,
    Name: "Tatyana Fitzpatrick",
    Position: "Regional Director",
    Office: "London",
    Age: 19,
    Startdate: "2023/03/17",
    Salary: "$385,750",
  },
  {
    id: 16,
    Name: "Michael Silva",
    Position: "Marketing Designer",
    Office: "London",
    Age: 66,
    Startdate: "2023/05/27",
    Salary: "$198,500",
  },
  {
    id: 17,
    Name: "Paul Byrd",
    Position: "Chief Financial Officer (CFO)",
    Office: "New York",
    Age: 64,
    Startdate: "2023/06/09",
    Salary: "$725,000",
  },
  {
    id: 18,
    Name: "Gloria Little",
    Position: "Systems Administrator",
    Office: "New York",
    Age: 59,
    Startdate: "2023/04/10",
    Salary: "$237,500",
  },
  {
    id: 19,
    Name: "Bradley Greer",
    Position: "Software Engineer",
    Office: "London",
    Age: 41,
    Startdate: "2023/05/13",
    Salary: "$132,000",
  },
  {
    id: 20,
    Name: "Dai Rios",
    Position: "Personnel Lead",
    Office: "Edinburgh",
    Age: 35,
    Startdate: "2023/05/26",
    Salary: "$217,500",
  },
  {
    id: 21,
    Name: "Jenette Caldwell",
    Position: "Development Lead",
    Office: "New York",
    Age: 30,
    Startdate: "2023/05/03",
    Salary: "$345,000",
  },
  {
    id: 22,
    Name: "Yuri Berry",
    Position: "Chief Marketing Officer (CMO)",
    Office: "New York",
    Age: 40,
    Startdate: "2023/06/25",
    Salary: "$675,000",
  },
  {
    id: 23,
    Name: "Caesar Vance",
    Position: "Pre-Sales Support",
    Office: "New York",
    Age: 21,
    Startdate: "2023/05/12",
    Salary: "$106,450",
  },
  {
    id: 24,
    Name: "Doris Wilder",
    Position: "Sales Assistant",
    Office: "Sidney",
    Age: 23,
    Startdate: "2023/06/20",
    Salary: "$85,600",
  },
  {
    id: 25,
    Name: "Angelica Ramos",
    Position: "Chief Executive Officer (CEO)",
    Office: "London",
    Age: 47,
    Startdate: "2023/06/09",
    Salary: "$1,200,000",
  },
  {
    id: 26,
    Name: "Gavin Joyce",
    Position: "Developer",
    Office: "Edinburgh",
    Age: 42,
    Startdate: "2023/02/22",
    Salary: "$92,575",
  },
  {
    id: 27,
    Name: "Jennifer Chang",
    Position: "Regional Director",
    Office: "Singapore",
    Age: 28,
    Startdate: "2023/01/14",
    Salary: "$357,650",
  },
  {
    id: 28,
    Name: "Brenden Wagner",
    Position: "Software Engineer",
    Office: "San Francisco",
    Age: 28,
    Startdate: "2023/06/07",
    Salary: "$206,850",
  },
  {
    id: 29,
    Name: "Fiona Green",
    Position: "Chief Operating Officer (COO)",
    Office: "San Francisco",
    Age: 48,
    Startdate: "2023/03/11",
    Salary: "$850,000",
  },
  {
    id: 30,
    Name: "Shou Itou",
    Position: "Regional Marketing",
    Office: "Tokyo",
    Age: 20,
    Startdate: "2023/07/14",
    Salary: "$163,000",
  },
];
export default {
  data() {
    return {
      title: "Data Tables",
      text: "Dashboard",
      text1: "Data Tables",
      data,
      columns,
    };
  },
  name: "admin/data-tables",
};
</script>
