<script>
import Layout from "@/layouts/main";
import PageHeader from "@/components/page-header";
import {numeric, required} from "vuelidate/lib/validators";
import appConfig from "@/app.config";
import {pagingModel} from "@/models/pagingModel";
import Multiselect from "vue-multiselect";
import {commonModel} from "@/models/commonModel";
import Treeselect from "@riophae/vue-treeselect";
export default {
  page: {
    title: "Quản lý danh mục",
    meta: [{name: "description", content: appConfig.description}],
  },
  components: {Layout, PageHeader, Multiselect},
  data() {
    return {
      title: "Quản lý danh mục",
      items: [
        {
          text: "Quản lý danh mục",
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
          key: "name",
          label: "Tên danh mục",
          class: 'td-username',
          sortable: true,
          thStyle: "text-align:center",
          thClass: 'hidden-sortable'
        },
        {
          key: "code",
          label: "Code",
          class: 'td-ten',
          sortable: true,
          thStyle: "text-align:center",
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
      model: commonModel.baseJson(),
      listCoQuan: [],
      listRole: [],
      listDonVi: [],
      pagination: pagingModel.baseJson(),
      listDanhMuc: [],
      collectionSearch: {
          code: null,
          name: null,
      },
    };
  },
  computed: {
    //Validations
    rules(){
      return{
        name: {required},
        code: {required},
      }
    }
  },
  validations: {
    model: {
      name: {required},
      code: {required},
    },
  },
  created() {
  },
  mounted() {
    this.getListDanhMuc();
    this.collectionSearch = this.listDanhMuc[0];
  },
  methods: {
    handleSearch() {
      this.$refs.tblList.refresh();
    },

    addCoQuanToModel : function (node, instanceId ){
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
    async getListDanhMuc(){
      await  this.$store.dispatch("commonStore/getList").then((res) =>{
        this.listDanhMuc = res.data || [];
      })
    },
    async handleDelete() {
      if (this.model.id != 0 && this.model.id != null && this.model.id) {
        await this.$store.dispatch("commonStore/delete",commonModel.convertJson(this.model, this.collectionSearch.code)).then((res) => {
          if (res.code===0) {
            this.fnGetList();
            this.showDeleteModal = false;
          }
          var a = {
            message: res.message,
            code: res.code
          };
          this.$store.dispatch("snackBarStore/addNotify", {
            message: res.message,
            code: res.code
          });
        });
      }
    },
    handleShowDeleteModal(value) {
      this.model = value;
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
          await this.$store.dispatch("commonStore/update", commonModel.convertJson(this.model, this.collectionSearch.code)).then((res) => {
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
          await this.$store.dispatch("commonStore/create", commonModel.convertJson(this.model, this.collectionSearch.code)).then((res) => {
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
      await this.$store.dispatch("commonStore/getById", commonModel.convertJson({id : id}, this.collectionSearch.code)).then((res) => {
        if (res.code===0) {
          this.model = commonModel.toJson(res.data);
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
        collectionName: this.collectionSearch.code == null ? "" : this.collectionSearch.code
      }
      this.loading = true
      try {
        let promise =  this.$store.dispatch("commonStore/getPagingParams", params)
        return promise.then(resp => {
          let items = resp.data.data
          this.totalRows = resp.data.totalRows
          this.numberOfElement = resp.data.length
          this.loading = false
          return items || []
        })
      } finally {
        this.loading = false
      }
    },
  },
  watch: {
    model: {
      deep: true,
      handler(val) {
        // addCoQuanToModel()
        // this.saveValueToLocalStorage()
      }
    },

    /**NHẤP VÀO TÌM KIẾM THÌ HÀM DƯỚI ĐƯỢC XỬ LÝ */
    'collectionSearch': {
      handler(val){
        const params = {
          collectionName: this.collectionSearch.code == null ? "" : this.collectionSearch.code
        }
        this.$store.dispatch("commonStore/getPagingParams" ,params);
        this.$refs.tblList.refresh();
      },
      deep: true
    },

    showModal(status) {
      if (status == false) this.model = commonModel.baseJson();
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
              <div class="col-md-6 col-sm-6">
                <div class="mb-3">
                  <label>Tìm kiếm theo danh mục</label>
                  <multiselect
                      v-model="collectionSearch"
                      :options="listDanhMuc"
                      :multiple="false"
                      track-by="code"
                      class="helo"
                      selectLabel="Nhấn vào để chọn"
                      deselectLabel="Nhấn vào để xóa"
                      label="name"
                      placeholder="Chọn loại danh mục"
                  ></multiselect>
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-12">
                <div class="row">
                  <div class="col-md-12" style="display: flex; justify-content: space-between; align-items: center;">
                    <div
                        class="d-flex justify-content-left align-items-center"
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
                    <b-button
                      type="button"
                      class="btn-label cs-btn-primary"
                      @click="showModal = true" size="sm"
                    >
                      <i class="mdi mdi-plus me-1 label-icon"></i> Thêm
                    </b-button>
                  </div>
                  <div class="col-sm-4 col-md-4" style="display: flex; justify-content: flex-end; align-items: center;">
                    <div class="">
                      <!-- <b-button
                        type="button"
                        class="btn-label cs-btn-primary mb-2 me-2"
                        @click="showModal = true" size="sm"
                      >
                        <i class="mdi mdi-plus me-1 label-icon"></i> Thêm
                      </b-button> -->
                      <b-modal
                          v-model="showModal"
                          title="Thông tin danh mục"
                          title-class="text-black font-18"
                          body-class="p-3"
                          hide-footer
                          centered
                          no-close-on-backdrop
                          size="md"
                      >
                        <form @submit.prevent="handleSubmit"
                              ref="formContainer"
                        >
                          <div class="row">
                            <div class="col-md-12">
                              <div class="mb-3">
                                <label class="text-left">Tên</label>
                                <span style="color: red">&nbsp;*</span>
                                <input type="hidden" v-model="model.id"/>
                                <input
                                    id="userName"
                                    v-model.trim="model.name"
                                    type="text"
                                    class="form-control"
                                    placeholder="Nhập tên"
                                    :class="{
                                    'is-invalid':
                                      submitted && $v.model.name.$error,
                                  }"
                                />
                                <div
                                    v-if="submitted && !$v.model.name.required"
                                    class="invalid-feedback"
                                >
                                  Tên không được trống.
                                </div>
                              </div>
                            </div>
                            <div class="col-md-12">
                              <div class="mb-3">
                                <label class="text-left">Code</label>
                                <span style="color: red">&nbsp;*</span>
                                <input type="hidden" v-model="model.id"/>
                                <input
                                    id="lastName"
                                    v-model="model.code"
                                    type="text"
                                    class="form-control"
                                    placeholder="Nhập code"
                                    :class="{
                                    'is-invalid':
                                      submitted && $v.model.code.$error,
                                  }"
                                />
                                <div
                                    v-if="submitted && !$v.model.code.required"
                                    class="invalid-feedback"
                                >
                                  Code không được trống.
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
                    <template v-slot:cell(donVi)="data">
                     <span style="margin-left: 5px">
                       {{data.item.donVi.name}}
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
                          v-on:click="handleShowDeleteModal(data.item)">
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
