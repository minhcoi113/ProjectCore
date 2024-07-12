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
                                require(`@/assets/admin/img/patients/${record.PatientImage}`)
                              "
                              alt="User Image"
                          /></router-link>
                          <router-link to="/admin/profile">{{
                            record.PatientName
                          }}</router-link>
                        </h2>
                      </template>
                      <template v-else-if="column.key === 'Ratings'">
                        <div>
                          <i class="fe fe-star text-warning me-1"></i>
                          <i class="fe fe-star text-warning me-1"></i>
                          <i class="fe fe-star text-warning me-1"></i>
                          <i class="fe fe-star text-warning me-1"></i>
                          <i class="fe fe-star-o text-secondary"></i>
                        </div>
                      </template>
                      <template v-else-if="column.key === 'DoctorName'">
                        <h2 class="table-avatar">
                          <router-link to="/admin/profile" class="avatar avatar-sm me-2"
                            ><img
                              class="avatar-img rounded-circle"
                              :src="
                                require(`@/assets/admin/img/doctors/${record.DoctorImage}`)
                              "
                              alt="User Image"
                          /></router-link>
                          <router-link to="/admin/profile">{{
                            record.DoctorName
                          }}</router-link>
                        </h2>
                      </template>
                      <template v-else-if="column.key === 'Data'">
                        <div>
                          {{ record.Date }}<br /><small>{{ record.Time }}</small>
                        </div>
                      </template>
                      <template v-else-if="column.key === 'action'">
                        <div class="actions">
                          <a
                            class="btn btn-sm bg-danger-light"
                            data-bs-toggle="modal"
                            href="#delete_modal"
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
          </div>
        </div>
      </div>
    </div>
  </div>
  <admindelete />
</template>

<script>
const columns = [
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
    title: "Doctor Name",
    dataIndex: "DoctorName",
    key: "DoctorName",
    sorter: {
      compare: (a, b) => {
        a = a.DoctorName.toLowerCase();
        b = b.DoctorName.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Ratings",
    dataIndex: "Ratings",
    key: "Ratings",
    sorter: {
      compare: (a, b) => {
        a = a.Ratings.toLowerCase();
        b = b.Ratings.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },

  {
    title: "Description",
    dataIndex: "Description",
    sorter: {
      compare: (a, b) => {
        a = a.Description.toLowerCase();
        b = b.Description.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },

  {
    title: "Data",
    dataIndex: "Data",
    key: "Data",
    sorter: {
      compare: (a, b) => {
        a = a.Data.toLowerCase();
        b = b.Data.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },

  {
    title: "Action",
    key: "action",
    sorter: true,
    class: "text-end",
  },
];

const data = [
  {
    PatientName: "Charlene Reed",
    DoctorName: "Dr. Ruby Perrin",
    DoctorImage: "doctor-thumb-01.jpg",
    PatientImage: "patient1.jpg",
    Ratings: "",
    Description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
    Date: "3 May 2023",
    Time: "09.59 AM",
    Actions: "Delete",
  },
  {
    PatientName: "Travis Trimble",
    DoctorName: "Dr. Darren Elder",
    DoctorImage: "doctor-thumb-02.jpg",
    PatientImage: "patient2.jpg",
    Ratings: "",
    Description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
    Date: "2 May 2023",
    Time: "08.50 AM",
    Actions: "Delete",
  },
  {
    PatientName: "Carl Kelly",
    DoctorName: "Dr. Deborah Angel",
    DoctorImage: "doctor-thumb-03.jpg",
    PatientImage: "patient3.jpg",
    Ratings: "",
    Description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
    Date: "1 May 2023",
    Time: "02.59 PM",
    Actions: "Delete",
  },
  {
    PatientName: "Michelle Fairfax",
    DoctorName: "Dr. Sofia Brient",
    DoctorImage: "doctor-thumb-04.jpg",
    PatientImage: "patient4.jpg",
    Ratings: "",
    Description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
    Date: "27 Apr 2023",
    Time: "03.40 PM",
    Actions: "Delete",
  },
  {
    PatientName: "Gina Moore",
    DoctorName: "Dr. Marvin Campbell",
    DoctorImage: "doctor-thumb-05.jpg",
    PatientImage: "patient5.jpg",
    Ratings: "",
    Description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
    Date: "24 Apr 2023",
    Time: "04.38 PM",
    Actions: "Delete",
  },
  {
    PatientName: "Elsie Gilley",
    DoctorName: "Dr. Katharine Berthold",
    DoctorImage: "doctor-thumb-06.jpg",
    PatientImage: "patient6.jpg",
    Ratings: "",
    Description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
    Date: "22 Apr 2023",
    Time: "01.50 PM",
    Actions: "Delete",
  },
  {
    PatientName: "Joan Gardner",
    DoctorName: "Dr. Linda Tobin",
    DoctorImage: "doctor-thumb-07.jpg",
    PatientImage: "patient7.jpg",
    Ratings: "",
    Description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
    Date: "21 Jul 2023",
    Time: "05.50 PM",
    Actions: "Delete",
  },
  {
    PatientName: "Daniel Griffing",
    DoctorName: "Dr. Paul Richard",
    DoctorImage: "doctor-thumb-08.jpg",
    PatientImage: "patient8.jpg",
    Ratings: "",
    Description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
    Date: "16 Jun 2023",
    Time: "04.50 PM",
    Actions: "Delete",
  },
  {
    PatientName: "Walter Roberson",
    DoctorName: "Dr. John Gibbs",
    DoctorImage: "doctor-thumb-09.jpg",
    PatientImage: "patient9.jpg",
    Ratings: "",
    Description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
    Date: "11 Mar 2023",
    Time: "05.55 PM",
    Actions: "Delete",
  },
  {
    PatientName: "Harry Williams",
    DoctorName: "Dr. Olga Barlow",
    DoctorImage: "doctor-thumb-10.jpg",
    PatientImage: "patient10.jpg",
    Ratings: "",
    Description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
    Date: "15 Feb 2023",
    Time: "07.30 PM",
    Actions: "Delete",
  },
];

export default {
  data() {
    return {
      title: "Reviews",
      text: "Dashboard",
      text1: "Reviews",
      data,
      columns,
    };
  },
};
</script>
