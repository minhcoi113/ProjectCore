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
                      <template v-if="column.key === 'DoctorName'">
                        <h2 class="table-avatar">
                          <router-link to="/admin/profile" class="avatar avatar-sm me-2">
                            <img
                              class="avatar-img rounded-circle"
                              :src="require(`@/assets/admin/img/doctors/${record.Image}`)"
                              alt="User Image"
                            />
                          </router-link>
                          <router-link to="/admin/profile">{{
                            record.DoctorName
                          }}</router-link>
                        </h2>
                      </template>
                      <template v-else-if="column.key === 'MemberSince'">
                        <div>
                          {{ record.MemberSince }} <br /><small>{{ record.Time }}</small>
                        </div>
                      </template>
                      <template v-else-if="column.key === 'AccountStatus'">
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
    title: "Member Since",
    dataIndex: "MemberSince",
    key: "MemberSince",
    sorter: {
      compare: (a, b) => {
        a = a.MemberSince.toLowerCase();
        b = b.MemberSince.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Earned",
    dataIndex: "Earned",
    sorter: {
      compare: (a, b) => {
        a = a.Earned.toLowerCase();
        b = b.Earned.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
  {
    title: "Account Status",
    dataIndex: "AccountStatus",
    key: "AccountStatus",
    sorter: {
      compare: (a, b) => {
        a = a.AccountStatus.toLowerCase();
        b = b.AccountStatus.toLowerCase();
        return a > b ? -1 : b > a ? 1 : 0;
      },
    },
  },
];

const data = [
  {
    DoctorName: "Dr. Ruby Perrin",
    Speciality: "Dental",
    Image: "doctor-thumb-01.jpg",
    MemberSince: "14 Jan 2023",
    Time: "02.59 AM",
    Earned: "$3100.00",
    AccountStatus: "checkbox",
    IdName: "status_1",
  },
  {
    DoctorName: "Dr. Darren Elder",
    Speciality: "Dental",
    Image: "doctor-thumb-02.jpg",
    MemberSince: "11 Jun 2023",
    Time: "4.50 AM",
    Earned: "$5000.00",
    AccountStatus: "checkbox",
    IdName: "status_2",
  },
  {
    DoctorName: "Dr. Deborah Angel",
    Speciality: "Cardiology",
    Image: "doctor-thumb-03.jpg",
    MemberSince: "4 Jan 2023",
    Time: "9.40 AM",
    Earned: "$3300.00",
    AccountStatus: "checkbox",
    IdName: "status_3",
  },
  {
    DoctorName: "Dr. Sofia Brient",
    Speciality: "Urology",
    Image: "doctor-thumb-04.jpg",
    MemberSince: "5 Jul 2023",
    Time: "2.59 AM",
    Earned: "$3500.00",
    AccountStatus: "checkbox",
    IdName: "status_4",
  },
  {
    DoctorName: "Dr. Marvin Campbell",
    Speciality: "Orthopaedics",
    Image: "doctor-thumb-05.jpg",
    MemberSince: "24 Jan 2023",
    Time: "02.59 AM",
    Earned: "$3700.00",
    AccountStatus: "checkbox",
    IdName: "status_5",
  },
  {
    DoctorName: "Dr. Katharine Berthold",
    Speciality: "Orthopaedics",
    Image: "doctor-thumb-06.jpg",
    MemberSince: "23 Mar 2023",
    Time: "02.50 PM",
    Earned: "$4000.00",
    AccountStatus: "checkbox",
    IdName: "status_6",
  },
  {
    DoctorName: "Dr. Linda Tobin",
    Speciality: "Neurology",
    Image: "doctor-thumb-07.jpg",
    MemberSince: "14 Jan 2023",
    Time: "01.59 AM",
    Earned: "$2000.00",
    AccountStatus: "checkbox",
    IdName: "status_7",
  },
  {
    DoctorName: "Dr. Paul Richard",
    Speciality: "Dermatology",
    Image: "doctor-thumb-08.jpg",
    MemberSince: "11 Jan 2023",
    Time: "02.59 AM",
    Earned: "$3000.00",
    AccountStatus: "checkbox",
    IdName: "status_8",
  },
  {
    DoctorName: "Dr. John Gibbs",
    Speciality: "Dental",
    Image: "doctor-thumb-09.jpg",
    MemberSince: "21 Apr 2023",
    Time: "02.59 PM",
    Earned: "$4100.00",
    AccountStatus: "checkbox",
    IdName: "status_9",
  },
  {
    DoctorName: "Dr. Olga Barlow",
    Speciality: "Dental",
    Image: "doctor-thumb-10.jpg",
    MemberSince: "15 Feb 2023",
    Time: "03.59 AM",
    Earned: "$3500.00",
    AccountStatus: "checkbox",
    IdName: "status_10",
  },
];

export default {
  data() {
    return {
      title: "List of Doctors",
      text: "Dashboard",
      text1: "Users",
      text2: "Doctor",
      data,
      columns,
    };
  },
};
</script>
