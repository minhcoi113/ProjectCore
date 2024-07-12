<script>
import Layout from "../../layouts/main";
import PageHeader from "@/components/page-header";
import {required} from "vuelidate/lib/validators";
import appConfig from "@/app.config";
import {notifyModel} from "@/models/notifyModel";
import {quyenModel} from "@/models/quyenModel";
import {moduleModel} from "@/models/moduleModel";
export default {
  props: ['name'],
  page: {
    title: "Danh sách quyền",
    meta: [{name: "description", content: appConfig.description}],
  },
  components: {Layout, PageHeader},
  data() {
    return {
      title: "Danh sách quyền",
      items: [
        {
          text: "Danh sách quyền",
          active: true,
        },
        {
          text: "Danh sách",
          active: true,
        }
      ],
      data: [],
      idModule : this.$route.params.id,
      isDetail: false,
      showModal: false,
      showDeleteModal: false,
      submitted: false,
      model: quyenModel.baseJson(),
      sortDesc: false,
      currentPage: 1,
      perPage: 5,
      fields: [
        { key: 'STT',
          label: 'STT',
          class : "text-center",
          thStyle: {width: '80px', minWidth: '60px' },
          thClass: 'hidden-sortable' },
        {
          key: "name",
          label: "Tên quyền",
          sortable: true,
          thStyle:"text-align:center",
        },
        {
          key: "action",
          label: "Tên hành động",
          thStyle:"text-align:center",
          sortable: true,
        },
        {
          key: "sort",
          label: "Thứ tự",
          class : "text-center",
          thStyle: {width: '110px', minWidth: '110px'},
          thClass: 'hidden-sortable'
        },
        {
          key: 'process',
          label: 'Xử lý',
          class : "text-center",
          thStyle: {width: '110px', minWidth: '110px'},
          thClass: 'hidden-sortable'
        }
      ],
      tenModule : null,
    };
  },
  validations: {
    model: {
          name: {required},
          action: {required},
          sort: {required}
    },
  },
  created() {
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
      if (status == false)
      {
        this.model = quyenModel.baseJson();
        this.isDetail = false;
      }else {
        this.getModule()
      }
    },
    showDeleteModal(val) {
      if (val == false) {
        this.model.id = null;
      }
    },
  },
  methods: {
    async handleDelete(){
        await this.$store.dispatch("moduleStore/deletePermission", quyenModel.convernJson(this.model, this.$route.params.id)).then((res) => {
          if (res.code === 0) {
            this.model = moduleModel.baseJson();
            this.showDeleteModal= false;
            this.$refs.tblList.refresh();
          }
          this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res))
        });
      },
    async handleDetail(model) {
      this.model = quyenModel.convernJson(model, this.$route.params.id);
      await this.$store.dispatch("moduleStore/getPermissionById", this.model).then((res) => {
        if (res.code === 0) {
          this.model = quyenModel.fromJson(res.data);
          this.showModal = true;
        }else {
          this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res))
        }
      });
    },
    async handleShowDeleteModal(model) {
      this.model =  model;
      this.showDeleteModal = true;
    },
    myProvider (ctx) {
      this.loading = true
      try {
        let promise =  this.$store.dispatch("moduleStore/getById", this.$route.params.id)
        return promise.then(resp => {
          let items = resp.data
          this.loading = false
          return items.permissions || []
        })
      } finally {
        this.loading = false
      }
    },
    async handlePermissionSubmit(e) {
      e.preventDefault();
      this.submitted = true;
      this.$v.$touch();
      if (this.$v.model.$invalid) {
        return;
      } else {
        let loader = this.$loading.show({
          container: this.$refs.formQuyenContainer,
        });
        if (
            this.model.id != 0 &&
            this.model.id != null &&
            this.model.id
        ) {
          // Update model
          await this.$store.dispatch("moduleStore/createPermission", quyenModel.convernJson(this.model,this.idModule)).then((res) => {
            if (res.code === 0) {
              this.model = quyenModel.baseJson();
              this.showModal = false;
              this.$refs.tblList.refresh();
            }
            this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res))
          });
        } else {
          // Create model
          await this.$store.dispatch("moduleStore/createPermission", quyenModel.convernJson(this.model , this.idModule)).then((res) => {
            if (res.code === 0) {
             this.model = quyenModel.baseJson();
             this.showModal = false;
             this.$refs.tblList.refresh();
            }
            this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res))
          });
        }
        loader.hide();
      }
      this.submitted = false;
    },
    async getModule(){
      await  this.$store.dispatch("moduleStore/getById" , this.$route.params.id).then((res) =>{
        this.tenModule = res.data.name
      })
    },
  }
}
</script>
<template>
  <Layout>
    <PageHeader :title="title" :items="items"/>
    <div class="row">
      <div class="col-12">
        <div class="card">
          <div class="card-body">
            <div class="row mb-2">
<!--              <div class="col-sm-4">-->
<!--                <div class="search-box me-2 mb-2 d-inline-block">-->
<!--                  <div class="position-relative">-->
<!--                    <input-->
<!--                        v-model = "filter"-->
<!--                        type="text"-->
<!--                        class="form-control"-->
<!--                        placeholder="Tìm kiếm ..."-->
<!--                    />-->
<!--                    <i class="bx bx-search-alt search-icon"></i>-->
<!--                  </div>-->
<!--                </div>-->
<!--              </div>-->
              <div class="col-sm-12" style="float: right">
                <div class="text-sm-end">
                  <b-button type="button" class="btn-label cs-btn-primary mb-2 me-2" @click="showModal = true" size="sm">
                    <i class="mdi mdi-plus me-1 label-icon"></i> Thêm
                  </b-button>
                  <b-modal
                      v-model="showModal"
                      title="Thông tin Quyền"
                      title-class="text-black font-18"
                      body-class="p-3"
                      hide-footer
                      centered
                      no-close-on-backdrop
                  >
                    <form @submit.prevent="handlePermissionSubmit"
                          ref="formQuyenContainer"
                    >
                      <div class="row">
                        <div class="col-12">
                          <div class="mb-3">
                            <label class="text-left">Tên module</label>
                            <input type="hidden" v-model="model.idModule"/>
                            <input type="hidden" v-model="model.id"/>
                            <input
                                id="idModule"
                                v-model="tenModule"
                                type="text"
                                class="form-control"
                                disabled
                            />
                          </div>
                          <div class="mb-3">
                            <label class="text-left">Tên quyền</label>
                            <input type="hidden" v-model="model.id"/>
                            <input
                                id="quyenName"
                                v-model="model.name"
                                type="text"
                                class="form-control"
                                placeholder="Nhập tên quyền"
                                :class="{
                                  'is-invalid':
                                    submitted && $v.model.name.$error,
                                }"
                            />
                            <div
                                v-if="submitted && !$v.model.name.required"
                                class="invalid-feedback"
                            >
                              Tên quyền không được trống.
                            </div>
                          </div>
                          <div class="mb-3">
                            <label class="text-left">Action</label>
                            <input
                                id="quyenAction"
                                v-model="model.action"
                                type="text"
                                class="form-control"
                                placeholder="Nhập action"
                                :class="{
                                  'is-invalid':
                                    submitted && $v.model.action.$error,
                                }"
                            />
                            <div
                                v-if="submitted && !$v.model.action.required"
                                class="invalid-feedback"
                            >
                              Action không được trống.
                            </div>
                          </div>
                        </div>
                        <div class="col-6">
                          <div class="mb-3">
                            <label class="text-left">Thứ tự</label>
                            <input
                                id="quyenSort"
                                v-model="model.sort"
                                type="number"
                                class="form-control"
                                placeholder="Nhập thứ tự"
                                :class="{
                                  'is-invalid':
                                    submitted && $v.model.sort.$error,
                                }"
                            />
                            <div
                                v-if="submitted &&!$v.model.sort.required"
                                class="invalid-feedback"
                            >
                              Thứ tự không được trống.
                            </div>
                          </div>
                        </div>
                        <div class="col-6" style="margin-top: 35px">
                          <div class="mb-3">
                            <!--                        <label class="text-left">Hiển thị View</label>-->
                            <div class="form-check form-check-primary mb-3">
                              <label class="form-check-label" for="formCheckcolor1">
                                IsView
                              </label>
                              <input
                                  class="form-check-input"
                                  type="checkbox"
                                  id="formCheckcolor1"
                                  v-model="model.isView"
                                  :value="model.isView"
                                  v-on:input="model.isView = !$event.target.value"
                              />
                            </div>
                          </div>
                        </div>
                      </div>
                      <div class="text-end pt-2 mt-3">
                        <b-button variant="light" @click="showModal = false">
                          Đóng
                        </b-button>
                        <b-button
                            v-if="!isDetail"
                            type="submit" variant="success" class="ms-1 btn-red">Lưu
                        </b-button>
                      </div>
                    </form>
                  </b-modal>
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-12">
                    <div class="table-responsive mb-5">
                      <b-table
                          class="datatables"
                          :items="myProvider"
                          :fields="fields"
                          striped
                          bordered
                          responsive="sm"
                          ref="tblList"
                          primary-key="id"
                      >
                        <template v-slot:cell(STT)="data">
                          {{ data.index + ((currentPage-1)*perPage) + 1  }}
                        </template>
                        <template v-slot:cell(coQuan)="data">&nbsp;
                          {{data.item.coQuan.ten}}
                        </template>
                        <template v-slot:cell(process)="data">
                          <button
                              type="button"
                              size="sm"
                              class="btn btn-outline btn-sm"
                              data-toggle="tooltip" data-placement="bottom" title="Chi tiết"
                              v-on:click="handleDetail(data.item) , isDetail = true">
                            <i class="fas fa-eye text-primary me-1"></i>
                          </button>
                          <button
                              type="button"
                              size="sm"
                              class="btn btn-outline btn-sm"
                              data-toggle="tooltip" data-placement="bottom" title="Cập nhật"
                              v-on:click="handleDetail(data.item)">
                            <i class="fas fa-pencil-alt text-success me-1"></i>
                          </button>
                          <button
                              type="button"
                              size="sm"
                              class="btn btn-outline btn-sm"
                              data-toggle="tooltip" data-placement="bottom" title="Xóa"
                              v-on:click="handleShowDeleteModal(data.item)">
                            <i class="fas fa-trash-alt text-danger me-1"></i>
                          </button>
                        </template>
                      </b-table>
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
  </Layout>
</template>
<style>
.hidden-sortable:after, .hidden-sortable:before {
  display: none !important;
}
.table>tbody> tr >td{
  padding: 0px;
  line-height: 30px;
}
</style>
