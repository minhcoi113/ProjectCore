<template>
  <div class="main-wrapper">
    <adminheader></adminheader>
    <adminsidebar></adminsidebar>

    <!-- Page Wrapper -->
    <div class="page-wrapper">
      <div class="content container-fluid">
        <adminbreadcrumb :title="title" :text="text" :text1="text1" />

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
                      <template v-if="column.key === 'DoctorName'">
                        <h2 class="table-avatar">
                          <router-link to="/admin/profile" class="avatar avatar-sm me-2"
                            ><img
                              class="avatar-img rounded-circle"
                              :src="
                                require(`@/assets/admin/img/doctors/${record.DoctorImg}`)
                              "
                              alt="User Image"
                          /></router-link>
                          <router-link to="/admin/profile">{{
                            record.DoctorName
                          }}</router-link>
                        </h2>
                      </template>
                      <template v-else-if="column.key === 'PatientName'">
                        <h2 class="table-avatar">
                          <router-link to="/admin/profile" class="avatar avatar-sm me-2">
                            <img
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
                      <template v-else-if="column.key === 'AppointmentTime'">
                        <div>
                          {{ record.AppointmentTime }}
                          <span class="text-primary d-block">{{ record.Time }}</span>
                        </div>
                      </template>
                      <template v-else-if="column.key === 'Status'">
                        <div class="status-toggle">
                          <input
                            type="checkbox"
                            :id="record.IdName"
                            class="check"
                            checked
                          />
                          <label :for="record.IdName" class="checktoggle">checkbox</label>
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
  </div>
</template>

<script>
const columns = [
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
    title: "Speciality",
    dataIndex: "Speciality",
    sorter: {
      compare: (a, b) => {
        a = a.Speciality.toLowerCase();
        b = b.Speciality.toLowerCase();
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
    title: "Appointment Time",
    dataIndex: "AppointmentTime",
    key: "AppointmentTime",
    sorter: {
      compare: (a, b) => {
        a = a.AppointmentTime.toLowerCase();
        b = b.AppointmentTime.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Status",
    dataIndex: "Status",
    key: "Status",
    sorter: {
      compare: (a, b) => {
        a = a.Status.toLowerCase();
        b = b.Status.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Amount",
    dataIndex: "Amount",
    sorter: {
      compare: (a, b) => {
        a = a.Amount.toLowerCase();
        b = b.Amount.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
];

const data = [
  {
    DoctorName: "Dr. Ruby Perrin",
    DoctorImg: "doctor-thumb-01.jpg",
    PatientImg: "patient1.jpg",
    Speciality: "Dental",
    PatientName: "Charlene Reed",
    AppointmentTime: "9 May 2023",
    Time: "11.00 AM - 11.15 AM",
    Status: "checkbox",
    Amount: "$200.00",
    IdName: "status_1",
  },
  {
    DoctorName: "Dr. Darren Elder",
    DoctorImg: "doctor-thumb-02.jpg",
    PatientImg: "patient2.jpg",
    Speciality: "Dental",
    PatientName: "Travis Trimble",
    AppointmentTime: "5 May 2023 ",
    Time: "11.00 AM - 11.35 AM",
    Status: "checkbox",
    Amount: "$300.00",
    IdName: "status_2",
  },
  {
    DoctorName: "Dr. Deborah Angel",
    DoctorImg: "doctor-thumb-03.jpg",
    PatientImg: "patient3.jpg",
    Speciality: "Cardiology",
    PatientName: "Carl Kelly",
    AppointmentTime: "11 May 2023 ",
    Time: "12.00 PM - 12.15 PM",
    Status: "checkbox",
    Amount: "$150.00",
    IdName: "status_3",
  },
  {
    DoctorName: "Dr. Sofia Brient",
    DoctorImg: "doctor-thumb-04.jpg",
    PatientImg: "patient4.jpg",
    Speciality: "Urology",
    PatientName: "Michelle Fairfax",
    AppointmentTime: "7 May 2023 ",
    Time: "1.00 PM - 1.20 PM",
    Status: "checkbox",
    Amount: "$150.00",
    IdName: "status_4",
  },
  {
    DoctorName: "Dr. Marvin Campbell",
    DoctorImg: "doctor-thumb-05.jpg",
    PatientImg: "patient5.jpg",
    Speciality: "Orthopaedics",
    PatientName: "Gina Moore",
    AppointmentTime: "15 May 2023 ",
    Time: "1.00 PM - 1.15 PM",
    Status: "checkbox",
    Amount: "$200.00",
    IdName: "status_5",
  },
  {
    DoctorName: "Dr. Katharine Berthold",
    DoctorImg: "doctor-thumb-06.jpg",
    PatientImg: "patient6.jpg",
    Speciality: "Orthopaedics",
    PatientName: "Elsie Gilley",
    AppointmentTime: "16 May 2023 ",
    Time: "1.00 PM - 1.15 PM",
    Status: "checkbox",
    Amount: "$250.00",
    IdName: "status_6",
  },
  {
    DoctorName: "Dr. Linda Tobin",
    DoctorImg: "doctor-thumb-07.jpg",
    PatientImg: "patient7.jpg",
    Speciality: "Neurology",
    PatientName: "Joan Gardner",
    AppointmentTime: "18 May 2023 ",
    Time: "1.10 PM - 1.25 PM",
    Status: "checkbox",
    Amount: "$260.00",
    IdName: "status_7",
  },
  {
    DoctorName: "Dr. Paul Richard",
    DoctorImg: "doctor-thumb-08.jpg",
    PatientImg: "patient8.jpg",
    Speciality: "Dermatology",
    PatientName: "Daniel Griffing",
    AppointmentTime: "18 May 2023 ",
    Time: "11.10 AM - 11.25 AM",
    Status: "checkbox",
    Amount: "$260.00",
    IdName: "status_8",
  },
  {
    DoctorName: "Dr. John Gibbs",
    DoctorImg: "doctor-thumb-09.jpg",
    PatientImg: "patient9.jpg",
    Speciality: "Dental",
    PatientName: "Walter Roberson",
    AppointmentTime: "21 May 2023 ",
    Time: "12.10 PM - 12.25 PM",
    Status: "checkbox",
    Amount: "$300.00",
    IdName: "status_9",
  },
  {
    DoctorName: "Dr. Olga Barlow",
    DoctorImg: "doctor-thumb-10.jpg",
    PatientImg: "patient10.jpg",
    Speciality: "Dental",
    PatientName: "Robert Rhodes",
    AppointmentTime: "23 May 2023",
    Time: " 12.10 PM - 12.25 PM",
    Status: "checkbox",
    Amount: "$300.00",
    IdName: "status_10",
  },
];
export default {
  data() {
    return {
      title: "Appointments",
      text: "Dashboard",
      text1: "Appointments",
      data,
      columns,
    };
  },
  name: "/admin/appointment-list",
};
</script>
