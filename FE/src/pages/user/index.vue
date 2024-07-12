<script>
import Layout from "@/layouts/main";
import PageHeader from "@/components/page-header";
import {numeric, required} from "vuelidate/lib/validators";
import appConfig from "@/app.config";
import {pagingModel} from "@/models/pagingModel";
import Multiselect from "vue-multiselect";
import {userModel} from "@/models/userModel";
export default {
  page: {
    title: "Tài khoản",
    meta: [{name: "description", content: appConfig.description}],
  },
  components: {Layout, PageHeader, Multiselect},
  data() {
    return {
      title: "Tài khoản",
      items: [
        {
          text: "Tài khoản",
          href: '/tai-khoan'
        },
        {
          text: "Danh sách",
          active: true,
        }
      ],
      data: [],
      fields: [
        { key: 'STT',
          label: 'STT',
          class: 'td-stt',
          sortable: false,
          thClass: 'hidden-sortable'},
        {
          key: "userName",
          label: "Tài khoản",
          class: 'td-username',
          sortable: true,
          thStyle: "text-align:center",
          thClass: 'hidden-sortable'
        },
        {
          key: "name",
          label: "Họ và tên",
          class: 'td-ten',
          sortable: true,
          thStyle: "text-align:center",
          thClass: 'hidden-sortable'
        },
        {
          key: "unitRole",
          label: "Quyền",
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
      sortDesc: false,
      filterOn: [],
      numberOfElement: 1,
      totalRows: 1,
      model: userModel.baseJson(),
      listCoQuan: [],
      listRole: [],
      listDonVi: [],
      pagination: pagingModel.baseJson()
    };
  },
  computed: {
    //Validations
    rules(){
      return{
        userName: {required},
        name: {required},
        unitRole: {required},
      }
    }
  },
  validations: {
    model: {
      userName: {required},
      name: {required},
      unitRole: {required},
    },
  },
  created() {
  },
  methods: {
    addCoQuanToModel : function (node, instanceId ){
      // console.log(node, instanceId, this.listCoQuan)
      if(node.id){
        this.model.donVi = {id: node.id, name: node.label};
      }else{
        this.model.donVi = null
      }
    },
    normalizer(node){
      if(node.children == null || node.children == 'null'){
        delete node.children;
      }
    },
    async fnGetList() {
      this.$refs.tblList?.refresh()
    },
    async getListRole(){
      await  this.$store.dispatch("roleStore/getAll").then((res) =>{
        this.listRole = res.data || [];
      })
    },
    async getListDonVi(){
      await  this.$store.dispatch("donViStore/getTreeSelected").then((res) =>{
        this.listDonVi = res.data || [];
      })
    },
    async handleDelete() {
      if (this.model.id != 0 && this.model.id != null && this.model.id) {
        await this.$store.dispatch("userStore/delete",{id :  this.model.id}).then((res) => {
          if (res.code===0) {
            this.fnGetList();
            this.showDeleteModal = false;
          }
          var a = {
            message: res.message,
            code: res.code
          };
          //   console.log("LOG A : " ,a)
          this.$store.dispatch("snackBarStore/addNotify", {
            message: res.message,
            code: res.code
          });
        });
      }
    },
    handleShowDeleteModal(id) {
      this.model.id = id;
      this.showDeleteModal = true;
    },
    async handleSubmit(e) {
      e.preventDefault();
      this.submitted = true;
      this.$v.$touch();
      if (this.$v.$invalid) {
        return;
      } else {
        let loader = this.$loading.show({
          container: this.$refs.formContainer,
        });
        if (
            this.model.id != 0 &&
            this.model.id != null &&
            this.model.id
        ) {
          // Update model
          await this.$store.dispatch("userStore/update", this.model).then((res) => {
            if (res.code === 0) {
              this.showModal = false;
              this.$refs.tblList.refresh();
            }
            this.$store.dispatch("snackBarStore/addNotify", {
              message: res.message,
              code: res.code,
            });
          });
        } else {
          // Create model
          await this.$store.dispatch("userStore/create", this.model).then((res) => {
            if (res.code === 0) {
              this.fnGetList();
              this.showModal = false;
              this.model={}
            }
            this.$store.dispatch("snackBarStore/addNotify", {
              message: res.message,
              code: res.code,
            });
          });
        }
        loader.hide();
      }
      this.submitted = false;
    },
    async handleUpdate(id) {
      await this.$store.dispatch("userStore/getById", {id : id}).then((res) => {
        if (res.code===0) {
          this.model = userModel.toJson(res.data);
          this.showModal = true;
        } else {
          this.$store.dispatch("snackBarStore/addNotify", {
            message: res.message,
            code: res.code,
          });
        }
      });
    },
    myProvider (ctx) {
      const params = {
        start: ctx.currentPage,
        limit: ctx.perPage,
        content: this.filter,
        sortDesc: ctx.sortDesc,
      }
      this.loading = true
      try {
        let promise =  this.$store.dispatch("userStore/getPagingParams", params)
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
    this.getListRole();
    this.getListDonVi();
  },
  watch: {
    model: {
      deep: true,
      handler(val) {
        // addCoQuanToModel()
        // this.saveValueToLocalStorage()
      }
    },
    showModal(status) {
      if (status == false) this.model = userModel.baseJson();
    },
    // model() {
    //   return this.model;
    // },
    showDeleteModal(val) {
      if (val == false) {
        this.model.id = null;
      }
    }
  },
};
</script>

<template>
  <Layout>
    <PageHeader :title="title" :items="items"/>
    <div class="row">
      <div class="col-12">
        <div class="card">
          <div class="card-body">
            <div class="row mb-2">
              <div class="col-sm-4">
                <div class="search-box me-2 mb-2 d-inline-block">
                  <div class="position-relative">
                    <input
                        v-model="filter"
                        type="text"
                        class="form-control"
                        placeholder="Tìm kiếm ..."
                    />
                    <i class="bx bx-search-alt search-icon"></i>
                  </div>
                </div>
              </div>
              <div class="col-sm-8">
                <div class="text-sm-end">
                  <b-button
                      type="button"
                      class="btn-label cs-btn-primary mb-2 me-2"
                      @click="showModal = true" size="sm"
                  >
                    <i class="mdi mdi-plus me-1 label-icon"></i> Tạo tài khoản
                  </b-button>
                  <b-modal
                      v-model="showModal"
                      title="Thông tin tài khoản"
                      title-class="text-black font-18"
                      body-class="p-3"
                      hide-footer
                      centered
                      no-close-on-backdrop
                      size="lg"
                  >
                    <form @submit.prevent="handleSubmit"
                          ref="formContainer"
                    >
                      <div class="row">
                        <div class="col-6">
                          <div class="mb-3">
                            <label class="text-left">Tên tài khoản</label>
                            <span style="color: red">&nbsp;*</span>
                            <input type="hidden" v-model="model.id"/>
                            <input
                                id="userName"
                                v-model.trim="model.userName"
                                type="text"
                                class="form-control"
                                placeholder="Nhập tài khoản"
                                :class="{
                                'is-invalid':
                                  submitted && $v.model.userName.$error,
                              }"
                            />
                            <div
                                v-if="submitted && !$v.model.userName.required"
                                class="invalid-feedback"
                            >
                              Tên tài khoản không được trống.
                            </div>
                          </div>
                        </div>
                        <div class="col-6">
                          <div class="mb-3">
                            <label class="text-left">Họ và Tên</label>
                            <span style="color: red">&nbsp;*</span>
                            <input type="hidden" v-model="model.id"/>
                            <input
                                id="lastName"
                                v-model="model.name"
                                type="text"
                                class="form-control"
                                placeholder="Nhập họ và tên"
                                :class="{
                                'is-invalid':
                                  submitted && $v.model.name.$error,
                              }"
                            />
                            <div
                                v-if="submitted && !$v.model.name.required"
                                class="invalid-feedback"
                            >
                              Họ và tên không được trống.
                            </div>
                          </div>
                        </div>
                      
                        <div class="col-6">
                          <div class="mb-3">
                            <label class="text-left">Email</label>
                            <input type="hidden" v-model="model.id"/>
                            <input
                                id="email"
                                v-model="model.email"
                                type="email"
                                pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$"
                                class="form-control"
                                placeholder="Nhập email"
                            />
                          </div>
                        </div>
                        <div class="col-6">
                          <div class="mb-3">
                            <label class="text-left">Vai trò</label>
                            <span style="color: red">&nbsp;*</span>
                            <multiselect v-model="model.unitRole"
                                         :options="listRole"
                                         label="name"
                                         :multiple="false"
                                         selectLabel="Nhấn vào để chọn"
                                         deselectLabel="Nhấn vào để xóa"
                                         :class="{'is-invalid':submitted && $v.model.unitRole.$error,}"
                                         placeholder="Chọn vai trò"
                            >

                            </multiselect>
                            <div
                                v-if="submitted && !$v.model.unitRole.required"
                                class="invalid-feedback"
                            >
                              Vai trò không được trống.
                            </div>
                          </div>
                        </div>
                      </div>
                      <div class="text-end pt-2 mt-3">
                        <b-button variant="light" @click="showModal = false" class="border-0">
                          Đóng
                        </b-button>
                        <b-button  type="submit" variant="success" class="ms-1 cs-btn-primary">Lưu
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
                    <div
                        class="col-sm-12 d-flex justify-content-left align-items-center"
                    >
                      <div
                          id="tickets-table_length"
                          class="dataTables_length m-1"
                          style="
                        display: flex;
                        justify-content: left;
                        align-items: center;
                      "
                      >
                        <div class="me-1" >Hiển thị </div>
                        <b-form-select
                            class="form-select form-select-sm"
                            v-model="perPage"
                            size="sm"
                            :options="pageOptions"
                            style="width: 70px"
                        ></b-form-select
                        >&nbsp;
                        <div style="width: 100px"> dòng </div>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="table-responsive mb-0">
                  <b-table
                      class="datatables table-admin"
                      :items="myProvider"
                      :fields="fields"
                      striped
                      bordered
                      responsive="sm"
                      :per-page="perPage"
                      :current-page="currentPage"
                      :sort-by.sync="sortBy"
                      :sort-desc.sync="sortDesc"
                      :filter="filter"
                      :filter-included-fields="filterOn"
                      ref="tblList"
                      primary-key="id"
                  >
                    <template v-slot:cell(STT)="data">
                      {{ data.index + ((currentPage-1)*perPage) + 1  }}
                    </template>
                    <template v-slot:cell(userName)="data">
                     <span style="margin-left: 5px">
                       {{data.item.userName}}
                     </span>
                    </template>
                    <template v-slot:cell(name)="data">
                     <span style="margin-left: 5px">
                       {{data.item.name}}
                     </span>
                    </template>
                    <template v-slot:cell(unitRole)="data">
                          <span style="margin-left: 5px">
                              {{data.item.unitRole.name}}
                          </span>
                    </template>
                    <template v-slot:cell(process)="data">
                      <button
                          type="button"
                          size="sm"
                          class="btn btn-outline btn-sm"
                          v-on:click="handleUpdate(data.item.id)">
                        <i class="fas fa-pencil-alt text-success me-1"></i>
                      </button>
                      <button
                          type="button"
                          size="sm"
                          class="btn btn-outline btn-sm"
                          v-on:click="handleShowDeleteModal(data.item.id)">
                        <i class="fas fa-trash-alt text-danger me-1"></i>
                      </button>
                    </template>
                  </b-table>
                </div>
                <div class="row">
                  <b-col>
                    <div>Hiển thị {{numberOfElement}} trên tổng số {{totalRows}} dòng</div>
                  </b-col>
                  <div class="col">
                    <div
                        class="dataTables_paginate paging_simple_numbers float-end">
                      <ul class="pagination pagination-rounded mb-0">
                        <!-- pagination -->
                        <b-pagination
                            v-model="currentPage"
                            :total-rows="totalRows"
                            :per-page="perPage"
                        ></b-pagination>
                      </ul>
                    </div>
                  </div>
                </div>

              </div>
            </div>
            <b-modal
                v-model="showDeleteModal"
                centered
                title="Xóa dữ liệu"
                title-class="font-18"
                no-close-on-backdrop
            >
              <p>
                Dữ liệu xóa sẽ không được phục hồi!
              </p>
              <template #modal-footer>
                <button v-b-modal.modal-close_visit
                        class="btn btn-outline-info m-1"
                        v-on:click="showDeleteModal = false">
                  Đóng
                </button>
                <button v-b-modal.modal-close_visit
                        class="btn btn-danger btn m-1"
                        v-on:click="handleDelete">
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
