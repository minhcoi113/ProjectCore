<script>
import Layout from "@/layouts/main";
import PageHeader from "@/components/page-header";
import appConfig from "@/app.config";
import { pagingModel } from "@/models/pagingModel";
import Multiselect from "vue-multiselect";
import { baiThi3Model } from "@/models/baiThi3Model";
import Treeselect from "@riophae/vue-treeselect";
export default {
  page: {
    title: "Danh sách công việc được giao",
    meta: [{ name: "description", content: appConfig.description }],
  },
  components: { Layout, PageHeader, Multiselect, Treeselect },
  data() {
    return {
      title: "Danh sách công việc được giao",
      items: [
        {
          text: "Công việc",
          href: '/cong-viec-duoc-giao'
        },
        {
          text: "Danh sách",
          active: true,
        }
      ],
      data: [],
      fields: [
        {
          key: 'STT',
          label: 'STT',
          class: 'td-stt',
          sortable: false,
          thClass: 'hidden-sortable'
        },
        {
          key: "name",
          label: "Tên công việc",
          class: 'name',
          sortable: true,
          thStyle: "text-align:center",
          thClass: 'hidden-sortable'
        },
        {
          key: "trangThai",
          label: "Trạng Thái",
          class: 'td-email',
          thStyle: "text-align:center",
          sortable: true,
          thClass: 'hidden-sortable'
        },
        {
          key: 'process',
          label: 'Xử lý',
          class: 'td-xuly',
          sortable: false,
          thClass: 'hidden-sortable'
        }
      ],
      currentPage: 1,
      perPage: 10,
      pageOptions: [5, 10, 25, 50, 100],
      showModal: false,
      showDeleteModal: false,
      submitted: false,
      sortBy: "age",
      filter: null,
      filterTrangThai: {
        id: null,
        name: null,
        code: null
      },
      sortDesc: false,
      filterOn: [],
      numberOfElement: 1,
      totalRows: 1,
      model: baiThi3Model.baseJson(),
      listTrangThai: [],
      listUser: [],
      listCV: [],
      pagination: pagingModel.baseJson(),
      date: false
    };
  },
  computed: {
    buttonText() {
      return this.date ? 'Tất cả công việc' : 'Công việc hôm nay';
    }
  },
  created() {
    this.getListTrangThai();
    this.getListUser();
    this.getTreeView();
  },
  methods: {
    async fnGetList() {
      this.$refs.tblList?.refresh()
    },
    async getListTrangThai() {
      await this.$store.dispatch("commonStore/getAll", "DM_TRANGTHAI").then((res) => {
        this.listTrangThai = res.data || [];
      })
    },
    async getListUser() {
      await this.$store.dispatch("userStore/getAllSellect").then((res) => {
        this.listUser = res.data || [];
      })
    },
    async getTreeView() {
      await this.$store.dispatch("baiThiStore/getTreeAll").then((res) => {
        this.listCV = res.data || [];
      })
    },
    async toDate(){
      if(this.date == true){
        this.date = false;
      }else(
        this.date = true
      );      
      this.fnGetList();
    },

    async handleSubmit(e) {
      e.preventDefault();
      this.submitted = true;

      let loader = this.$loading.show({
        container: this.$refs.formContainer,
      });
      if (
        this.model.id != 0 &&
        this.model.id != null &&
        this.model.id
      ) {
        // Update model
        await this.$store.dispatch("baiThiStore/update", this.model).then((res) => {
          if (res.code === 0) {
            this.showModal = false;
            this.getTreeView();
            this.$refs.tblList.refresh();
          }
          this.$store.dispatch("snackBarStore/addNotify", {
            message: res.message,
            code: res.code,
          });
        });
      }
      loader.hide();
      this.submitted = false;
    },
    async handleUpdate(id) {
      await this.$store.dispatch("baiThiStore/getById", { id: id }).then((res) => {
        if (res.code === 0) {
          this.model = baiThi3Model.toJson(res.data);
          this.showModal = true;
        } else {
          this.$store.dispatch("snackBarStore/addNotify", {
            message: res.message,
            code: res.code,
          });
        }
      });
    },
    myProvider(ctx) {
      const params = {
        start: ctx.currentPage,
        limit: ctx.perPage,
        content: this.filter,
        sortDesc: ctx.sortDesc,
        userTake: true,
        trangThai: this.filterTrangThai.code == null ? null : this.filterTrangThai.code,
        date: this.date
      }
      this.loading = true
      try {
        let promise = this.$store.dispatch("baiThiStore/getPagingParams", params)
        return promise.then(resp => {
          let items = resp.data.data
          this.totalRows = resp.data.totalRows
          this.numberOfElement = resp.data.data.length
          this.loading = false
          return items || []
        })
      } finally {
        this.loading = false
      }
    },
  },
  mounted() {
  },
  watch: {
    model: {
      deep: true
    },
    showModal(status) {
      if (status == false) this.model = baiThi3Model.baseJson();
    },
    'filterTrangThai':{
      handler(val){
        this.fnGetList();
      },
      deep: true
    }
  },
};
</script>

<template>
  <Layout>
    <PageHeader :title="title" :items="items" />
    <div class="row">
      <div class="col-12">
        <div class="card">
          <div class="card-body">
            <div class="row mb-2">
              <div class="col-sm-4">
                <div class="search-box me-2 mb-2 d-inline-block">
                  <div class="position-relative">
                    <input v-model="filter" type="text" class="form-control" placeholder="Tìm kiếm ..." />
                    <i class="bx bx-search-alt search-icon"></i>
                  </div>
                </div>
                <div>
                  <a>Trạng thái:</a>
                  <multiselect v-model="filterTrangThai" :options="listTrangThai" :multiple="false" track-by="code"
                    selectLabel="Nhấn vào để chọn" deselectLabel="Nhấn vào để xóa" label="name"
                    placeholder="Tìm kiếm theo trạng thái"></multiselect>
                </div>
                <div>
                  <b-button type="button" class="cs-btn-primary mb-2 me-2" @click="toDate"
                    size="sn">{{ buttonText }}</b-button>
                </div>
              </div>
              <div class="col-sm-8">
                <div class="text-sm-end">
                  <b-button type="button" class="btn-label cs-btn-primary mb-2 me-2" @click="showModal = true"
                    size="sm">
                    <i class="mdi mdi-plus me-1 label-icon"></i> Tạo công việc
                  </b-button>
                  <b-modal v-model="showModal" title="Thông tin công việc" title-class="text-black font-18"
                    body-class="p-3" hide-footer centered no-close-on-backdrop size="lg">
                    <form @submit.prevent="handleSubmit" ref="formContainer">
                      <div class="row">
                        <div class="col-6">
                          <div class="mb-3">
                            <label class="text-left">Tên công việc</label>
                            <span style="color: red">&nbsp;*</span>
                            <input type="hidden" v-model="model.id" />
                            <input id="userName" v-model.trim="model.name" type="text" class="form-control"
                              placeholder="Nhập tên công việc" />
                          </div>
                        </div>
                        <div class="col-6">
                          <div class="mb-3">
                            <label class="text-left">Trạng thái</label>
                            <multiselect v-model="model.trangThai" :options="listTrangThai" label="name"
                              :multiple="false" selectLabel="Nhấn vào để chọn" deselectLabel="Nhấn vào để xóa"
                              placeholder="Chọn trạng thái công việc">
                            </multiselect>
                          </div>
                        </div>
                        <div class="col-6">
                          <div class="mb-3">
                            <label class="text-left">Ngày bắt đầu</label>
                            <span style="color: red">&nbsp;*</span>
                            <input type="hidden" v-model="model.id" />
                            <input id="thoiGianBatDau" v-model="model.thoiGianBatDau" type="date"
                              class="form-control" />
                          </div>
                        </div>
                        <div class="col-6">
                          <div class="mb-3">
                            <label class="text-left">Ngày kết thúc</label>
                            <span style="color: red">&nbsp;*</span>
                            <input type="hidden" v-model="model.id" />
                            <input id="thoiGianKetThuc" v-model="model.thoiGianKetThuc" type="date"
                              class="form-control" />
                          </div>
                        </div>
                        <div class="col-12">
                          <div class="mb-3">
                            <label class="text-left">Mô tả</label>
                            <input type="hidden" v-model="model.id" />
                            <textarea id="moTaCongViec" v-model="model.moTaCongViec" type="text" class="form-control"
                              placeholder="Nhập mô tả công việc" rows="5"></textarea>
                          </div>
                        </div>
                      </div>
                      <div class="col-12">
                        <div class="mb-3">
                          <label class="text-left">Người giải quyết</label>
                          <multiselect v-model="model.nguoiThucHien" :options="listUser" label="name" :multiple="true"
                            selectLabel="Nhấn vào để chọn" deselectLabel="Nhấn vào để xóa"
                            placeholder="Chọn người giải quyết công việc">
                          </multiselect>
                        </div>
                      </div>
                      <div class="mb-3">
                        <label class="text-left">Công việc cha</label>
                        <treeselect :options="listCV" :value="model.parentId" :searchable="true" :show-count="true"
                          :default-expand-level="1">
                          <label slot="option-label"
                            slot-scope="{ node, shouldShowCount, count, labelClassName, countClassName }"
                            :class="labelClassName">
                            {{ node.label }}
                            <span v-if="shouldShowCount" :class="countClassName">({{ count }})</span>
                          </label>
                        </treeselect>
                      </div>
                      <div class="text-end pt-2 mt-3">
                        <b-button variant="light" @click="showModal = false" class="border-0">
                          Đóng
                        </b-button>
                        <b-button type="submit" variant="success" class="ms-1 cs-btn-primary">Lưu
                        </b-button>
                      </div>
                    </form>
                  </b-modal>
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-12">
                <div class="row mt-4">
                  <div class="col-sm-12 col-md-6">
                    <div class="col-sm-12 d-flex justify-content-left align-items-center">
                      <div id="tickets-table_length" class="dataTables_length m-1" style="
                        display: flex;
                        justify-content: left;
                        align-items: center;
                      ">
                        <div class="me-1">Hiển thị </div>
                        <b-form-select class="form-select form-select-sm" v-model="perPage" size="sm"
                          :options="pageOptions" style="width: 70px"></b-form-select>&nbsp;
                        <div style="width: 100px"> dòng </div>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="table-responsive mb-0">
                  <b-table class="datatables table-admin" :items="myProvider" :fields="fields" striped bordered
                    responsive="sm" :per-page="perPage" :current-page="currentPage" :sort-by.sync="sortBy"
                    :sort-desc.sync="sortDesc" :filter="filter" :filter-included-fields="filterOn" ref="tblList"
                    primary-key="id">
                    <template v-slot:cell(STT)="data">
                      {{ data.index + ((currentPage - 1) * perPage) + 1 }}
                    </template>
                    <template v-slot:cell(trangThai)="data">
                      <span style="margin-left: 5px">
                        {{ data.item.trangThai.name }}
                      </span>
                    </template>
                    <template v-slot:cell(process)="data">
                      <button type="button" size="sm" class="btn btn-outline btn-sm"
                        v-on:click="handleUpdate(data.item.id)">
                        <i class="fas fa-pencil-alt text-success me-1"></i>
                      </button>
                      <button type="button" size="sm" class="btn btn-outline btn-sm"
                        v-on:click="handleShowDeleteModal(data.item.id)">
                        <i class="fas fa-trash-alt text-danger me-1"></i>
                      </button>
                    </template>
                  </b-table>
                </div>
                <div class="row">
                  <b-col>
                    <div>Hiển thị {{ numberOfElement }} trên tổng số {{ totalRows }} dòng</div>
                  </b-col>
                  <div class="col">
                    <div class="dataTables_paginate paging_simple_numbers float-end">
                      <ul class="pagination pagination-rounded mb-0">
                        <!-- pagination -->
                        <b-pagination v-model="currentPage" :total-rows="totalRows" :per-page="perPage"></b-pagination>
                      </ul>
                    </div>
                  </div>
                </div>

              </div>
            </div>
            <b-modal v-model="showDeleteModal" centered title="Xóa dữ liệu" title-class="font-18" no-close-on-backdrop>
              <p>
                Dữ liệu xóa sẽ không được phục hồi!
              </p>
              <template #modal-footer>
                <button v-b-modal.modal-close_visit class="btn btn-outline-info m-1"
                  v-on:click="showDeleteModal = false">
                  Đóng
                </button>
                <button v-b-modal.modal-close_visit class="btn btn-danger btn m-1" v-on:click="handleDelete">
                  Xóa
                </button>
              </template>
            </b-modal>
          </div>
        </div>
      </div>
    </div>
  </Layout>
</template>
<style>
.td-xuly {
  text-align: center;
  width: 20%
}
</style>
