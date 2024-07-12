<script>
import Layout from "../../layouts/main";
import PageHeader from "@/components/page-header";
import {required} from "vuelidate/lib/validators";
import appConfig from "@/app.config";
import {notifyModel} from "@/models/notifyModel";
import {pagingModel} from "@/models/pagingModel";
import {unitRoleModel} from "@/models/unitRoleModel";

export default {
  page: {
    title: "Quản lý vai trò",
    meta: [{name: "description", content: appConfig.description}],
  },
  components: {Layout, PageHeader},
  data() {
    return {
      title: "Quản lý vai trò",
      items: [
        {
          text: "Vai trò",
          href: "/vai-tro",
          // active: true,
        },
        {
          text: "Danh sách",
          active: true,
        }
      ],
      data: [],
      showModal: false,
      showDetail: false,
      showDeleteModal: false,
      submitted: false,
      model: unitRoleModel.baseJson(),
      listRole: [],
      pagination: pagingModel.baseJson(),
      totalRows: 1,
      todoTotalRows: 1,
      currentPage: 1,
      numberOfElement: 1,
      perPage: 10,
      pageOptions: [5, 10, 25, 50, 100],
      filter: null,
      todoFilter: null,
      filterOn: [],
      todofilterOn: [],
      sortBy: "age",
      sortDesc: false,
      fields: [
        {
          key: 'STT', label: 'STT',
          class: "text-center",
          thStyle: {width: '80px', minWidth: '60px'},
          tdClass: 'align-middle',
          thClass: 'hidden-sortable'
        },
        {
          key: "code",
          label: "Mã quyền",
          class: "text-center",
          thStyle: {width: '150px', minWidth: '150px'},
          thClass: 'hidden-sortable'
        },
        {
          key: "ten",
          label: "Tên quyền",
          sortable: true,
          thStyle: "text-align:center",
          thClass: 'hidden-sortable'
        },
        {
          key: "permissions",
          label: "Số lượng",
          class: "text-center",
          thStyle: {width: '150px', minWidth: '150px'},
          thClass: 'hidden-sortable'
        },
        {
          key: 'process',
          label: 'Xử lý',
          class: "text-center",
          thStyle: {width: '150px', minWidth: '150px'},
          thClass: 'hidden-sortable'
        }
      ],
    };
  },
  validations: {
    model: {
      ten: {required},
      code: {required}
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
      if (status == false) this.model = unitRoleModel.baseJson();
    },
    showDeleteModal(val) {
      if (val == false) {
        this.model.id = null;
      }
    },
  },
  methods: {
    async handleUpdate(id) {
      await this.$store.dispatch("roleStore/getById", id).then((res) => {
        if (res.code === 0) {
          this.model = unitRoleModel.fromJson(res.data);
          this.showModal = true;
        } else {
          this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res));
          this.$refs.tblList.refresh()
        }
      });
    },
    async handleDetail(id) {
      await this.$store.dispatch("roleStore/getById", id).then((res) => {
        if (res.code === 0) {
          this.model = unitRoleModel.fromJson(res.data);
          this.showDetail = true;
        } else {
          this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res));
        }
      });
    },
    async handleDelete() {
      if (this.model.id != 0 && this.model.id != null && this.model.id) {
        await this.$store.dispatch("roleStore/delete", this.model.id).then((res) => {
          if (res.code === 0) {
            this.showDeleteModal = false;
            this.$refs.tblList.refresh()
          }
          this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res));
          // });
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
          await this.$store.dispatch("roleStore/update", this.model).then((res) => {
            if (res.code === 0) {
              this.showModal = false;
              this.$refs.tblList.refresh()
            }
            this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res))
          });
        } else {
          // Create model
          await this.$store.dispatch("roleStore/create", unitRoleModel.toJson(this.model)).then((res) => {
            if (res.code === 0) {
              this.showModal = false;
              this.$refs.tblList.refresh()
              this.model = {};
            }
            this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res))
          });
        }
        loader.hide();
      }
      this.submitted = false;
    },
    myProvider(ctx) {
      const params = {
        start: ctx.currentPage,
        limit: ctx.perPage,
        content: this.filter,
        sortBy: ctx.sortBy,
        sortDesc: ctx.sortDesc,
      }
      this.loading = true
      try {
        let promise = this.$store.dispatch("roleStore/getPagingParams", params)
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
    // todoFiltered(filteredItems) {
    //   // Trigger pagination to update the number of buttons/pages due to filtering
    //   this.todoTotalRows = filteredItems.length;
    //   this.todocurrentPage = 1;
    // }
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
                  <b-button type="button" class="btn-label cs-btn-primary mb-2 me-2" @click="showModal = true" size="sm"
                            v-if="$can('create-roles')"
                  >
                    <i class="mdi mdi-plus me-1 label-icon"></i> Thêm
                  </b-button>
                  <b-modal
                      v-model="showModal"
                      title="Thông tin quyền"
                      title-class="text-black font-18"
                      body-class="p-3"
                      hide-footer
                      centered
                      no-close-on-backdrop
                      size="lg"
                  >
                    <form @submit.prevent="handleSubmit"
                          ref="formContainer">
                      <div class="row">
                        <div class="col-12">
                          <div class="mb-3">
                            <label class="text-left">Mã quyền</label>
                            <span style="color: red">&nbsp;*</span>
                            <input type="hidden" v-model="model.id"/>
                            <input
                                id="ten"
                                v-model.trim="model.code"
                                type="number"
                                class="form-control"
                                placeholder="Nhập mã quyền"
                                :class="{
                                'is-invalid':
                                  submitted && $v.model.code.$error,
                              }"
                            />
                            <div
                                v-if="submitted && !$v.model.code.required"
                                class="invalid-feedback"
                            >
                              Mã quyền không được để trống.
                            </div>
                          </div>
                        </div>
                        <div class="col-12">
                          <div class="mb-3">
                            <label class="text-left">Tên quyền</label>
                            <span style="color: red">&nbsp;*</span>
                            <input type="hidden" v-model="model.id"/>
                            <input
                                v-model="model.ten"
                                type="text"
                                min="0"
                                oninput="validity.valid||(value='');"
                                class="form-control"
                                placeholder="Nhập tên quyền"
                                :class="{
                                'is-invalid':
                                  submitted && $v.model.ten.$error,
                              }"
                            />
                            <div
                                v-if="submitted && !$v.model.ten.required"
                                class="invalid-feedback"
                            >
                              Tên quyền không được để trống.
                            </div>
                          </div>
                        </div>
                        <div class="col-12">
                          <div class="mb-3">
                            <label class="text-left">Thứ tự</label>
                            <input type="hidden" v-model="model.thuTu"/>
                            <input
                                v-model="model.thuTu"
                                type="text"
                                min="0"
                                oninput="validity.valid||(value='');"
                                class="form-control"
                                placeholder="Nhập thứ tự"
                            />
                          </div>
                        </div>
                      </div>
                      <div class="text-end pt-2 mt-3">
                        <b-button variant="light" @click="showModal = false">
                          Đóng
                        </b-button>
                        <b-button type="submit" class="ms-1 cs-btn-primary">
                          Lưu
                        </b-button>
                      </div>
                    </form>
                  </b-modal>
                  <b-modal
                      v-model="showDetail"
                      title="Thông tin chi tiết vai trò"
                      title-class="text-black font-18"
                      body-class="p-3"
                      hide-footer
                      centered
                      no-close-on-backdrop
                      size="lg"
                  >
                    <form @submit.prevent="handleSubmit"
                          ref="formContainer">
                      <div class="row">
                        <div class="col-12">
                          <div class="mb-3">
                            <label class="text-left">Mã quyền : </label>
                            <input
                                v-model="model.code"
                                type="text"
                                class="form-control"
                            />
                          </div>
                        </div>
                        <div class="col-12">
                          <div class="mb-3">
                            <label class="text-left">Tên quyền : </label>
                            <input
                                v-model="model.ten"
                                type="text"
                                class="form-control"
                            />
                          </div>
                        </div>
                        <div class="col-12">
                          <div class="mb-3">
                            <label class="text-left">Thứ tự : </label>
                            <input
                                v-model="model.thuTu"
                                type="text"
                                class="form-control"
                            />
                          </div>
                        </div>
                        <div class="col-12">
                          <div class="mb-3">
                            <label class="text-left">Người tạo : </label>
                            <input
                                v-model="model.createdBy"
                                type="text"
                                class="form-control"
                            />
                          </div>
                        </div>
                        <div class="col-12">
                          <div class="mb-3">
                            <label class="text-left">Ngày tạo: </label>
                            <input
                                v-model="model.createdAt"
                                type="text"
                                class="form-control"
                            />
                          </div>
                        </div>
                        <div class="col-12">
                          <div class="mb-3">
                            <label class="text-left">Người cập nhật : </label>
                            <input
                                v-model="model.modifiedBy"
                                type="text"
                                class="form-control"
                            />
                          </div>
                        </div>
                        <div class="col-12">
                          <div class="mb-3">
                            <label class="text-left">Ngày cập nhật : </label>
                            <input
                                v-model="model.modifiedAt"
                                type="text"
                                class="form-control"
                            />
                          </div>
                        </div>
                      </div>
                      <div class="text-end pt-2 mt-3">
                        <b-button variant="light" @click="showDetail = false">
                          Đóng
                        </b-button>
                      </div>
                    </form>
                  </b-modal>
                </div>
              </div>
            </div>
            <div class="row" style="margin-top: -20px">
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
                        <div style="width: 100px"> dòng</div>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="table-responsive-sm">
                  <b-table
                      class="datatables"
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
                      {{ data.index + ((currentPage - 1) * perPage) + 1 }}
                    </template>
                    <template v-slot:cell(permissions)="data">
                      <router-link :to='`/vai-tro/thiet-lap-quyen/${data.item.id}`'>
                        <b-button
                            v-if="data.item.permissions.length > 0 " :class="countClassName"
                            variant="outline-danger btn-sm"
                            class="cs-btn-primary"
                            size="sm"
                        >{{ data.item.permissions.length }}
                        </b-button>
                        <b-button v-else :class="countClassName" variant="outline-danger btn-sm"
                                  class="cs-btn-primary"
                                  size="sm"
                        >
                          {{ 0 }}
                        </b-button>
                      </router-link>
                    </template>
                    <template v-slot:cell(process)="data">
                      <button
                          type="button"
                          size="sm"
                          class="btn btn-outline btn-sm"
                          data-toggle="tooltip" data-placement="bottom" title="Chi tiết"
                          v-on:click="handleDetail(data.item.id)">
                        <i class="fas fa-eye text-primary me-1"></i>
                      </button>
                      <button
                          v-if="$can('edit-roles')"
                          type="button"
                          size="sm"
                          class="btn btn-outline btn-sm"
                          data-toggle="tooltip" data-placement="bottom" title="Cập nhật"
                          v-on:click="handleUpdate(data.item.id)">
                        <i class="fas fa-pencil-alt text-success me-1"></i>
                      </button>
                      <button
                          v-if="$can('delete-roles')"
                          type="button"
                          size="sm"
                          class="btn btn-outline btn-sm"
                          data-toggle="tooltip" data-placement="bottom" title="Xóa"
                          v-on:click="handleShowDeleteModal(data.item.id)">
                        <i class="fas fa-trash-alt text-danger me-1"></i>
                      </button>
                    </template>
                    <template v-slot:cell(ten)="data">&nbsp;&nbsp;
                      {{ data.item.ten }}
                    </template>
                  </b-table>
                </div>
                <div class="row">
                  <b-col>
                    <div>Hiển thị {{ numberOfElement }} trên tổng số {{ totalRows }} dòng</div>
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
