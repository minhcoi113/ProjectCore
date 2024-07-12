<script>
import Layout from "../../layouts/main";
import PageHeader from "@/components/page-header";
import appConfig from "@/app.config";
import {notifyModel} from "@/models/notifyModel";
import {userModel} from "@/models/userModel";
import {required,sameAs} from "vuelidate/lib/validators";

export default {
  page: {
    title: "Đổi mật khẩu",
    meta: [{name: "description", content: appConfig.description}],
  },
  components: {Layout, PageHeader},
  data(){
    return {
      title: "Đổi mật khẩu",
      modelpass:{
        password:null,
        newPass:null,
        confirmPass:null,
        userName:null,
        id:null
      },
      items: [
        {
          text: "Đổi mật khẩu",
          //href: "/nhom-quan-ly-du-an",
           active: true,
        },
        {
          text: "Danh sách",
          active: true,
        }
      ],
      data: [],
      submitted: false,
      //model: userModel.baseJson(),
    }
  },
  validations: {
    modelpass: {
      password: { required },
      newPass:{required},
      confirmPass: { required, sameAsPassword: sameAs('newPass') }
    }
  },
  created() {
    //this.getstore();
    this.getID();
  },
  methods: {
    async handleDetail(id) {
      await this.$store.dispatch("userStore/getById", id).then((res) => {
        if (res.resultCode === 0) {
          this.model = userModel.fromJson(res.data);
          this.showDetail = true;
        } else {
          this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res));
        }
      });
    },
    async handleSubmit(e) {
      e.preventDefault();
      this.submitted = true;
      this.$v.$touch()
      if (this.$v.modelpass.$invalid) {
        return;
      } else {
        let loader = this.$loading.show({
          container: this.$refs.formContainer,
        });
        if (
            this.modelpass.id != 0 &&
            this.modelpass.id != null &&
            this.modelpass.id
        )
        {
          await this.$store.dispatch("userStore/changePassword", this.modelpass).then((res) => {
            if (res.resultCode === 0) {
             this.getID();
              this.showModal = false;
            }
            this.modelpass.newPass =null;
            this.modelpass.password=null;
            this.modelpass.confirmPass=null;
            this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res));
            // this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res))
          });
        }
        loader.hide();
      }
      this.submitted = false;
    },
    // getstore(){
    //   const giatri= localStorage.getItem('auth-user');
    //   console.log('Strore', JSON.parse(giatri)?.user?.userName);
    //   return JSON.parse(giatri)?.user?.userName;
    // },
    async getID(){
      const idstore= localStorage.getItem('auth-user');
      this.modelpass.userName=JSON.parse(idstore)?.user?.userName;
      this.modelpass.id=JSON.parse(idstore)?.user?.id;
      return JSON.parse(idstore);
    }
  }
}
</script>
<template>
  <Layout>
    <PageHeader :title="title" :items="items" />
    <div class="row">
      <div class="col-xl-6">
        <div class="card">
          <div class="card-body">
            <h4 class="card-title">Thông tin tài khoản</h4>
            <form-wizard shape="tab" color="#556ee6">
              <tab-content icon="mdi mdi-account-circle">
                <div class="row">
                  <div class="col-12">
                    <div class="form-group row mb-3">
                      <label class="col-md-3 col-form-label" for="name"
                      >Tên tài khoản</label
                      >
                      <div class="col-md-9">
                        <input type="hidden" v-model="modelpass.id"/>
                        <input
                            id="name"
                            type="text"
                            class="form-control"
                            v-model= "modelpass.userName"
                            disabled
                        />
                      </div>
                    </div>
                    <div class="form-group row mb-3">
                      <label class="col-md-3 col-form-label" for="pwd"
                      >Mật khẩu hiện tại</label
                      >
                      <div class="col-md-9">
                        <input type="hidden" v-model="modelpass.id"/>
                        <input
                            v-model="modelpass.password"
                            id="pwd"
                            type="password"
                            name="pwd"
                            class="form-control"
                            placeholder="Nhập mật khẩu hiện tại"
                            :class="{
                                'is-invalid':
                                  submitted && $v.modelpass.password.$error,
                              }"
                        />
                        <div
                            v-if="submitted && !$v.modelpass.password.required"
                            class="invalid-feedback"
                        >
                          Mật khẩu hiện tại không được để trống.
                        </div>
                      </div>

                    </div>


                    <div class="form-group row mb-3">
                      <label class="col-md-3 col-form-label" for="pwdnew"
                      >Mật khẩu mới</label
                      >
                      <div class="col-md-9">
                        <input type="hidden" v-model="modelpass.id"/>
                        <input
                            v-model="modelpass.newPass"
                            id="pwdnew"
                            type="password"
                            class="form-control"
                            placeholder="Nhập mật khẩu mới"
                            :class="{
                                'is-invalid':
                                  submitted && $v.modelpass.newPass.$error,
                              }"
                        />
                        <div
                            v-if="submitted && !$v.modelpass.newPass.required"
                            class="invalid-feedback"
                        >
                          Mật khẩu mới không được để trống.
                        </div>
                      </div>

                    </div>

                    <div class="form-group row mb-3">
                      <label class="col-md-3 col-form-label" for="confirmpwd"
                      >Nhập lại mật khẩu</label
                      >
                      <div class="col-md-9">
                        <input type="hidden" v-model="modelpass.id"/>
                        <input
                            v-model="modelpass.confirmPass"
                            id="confirmpwd"
                            type="password"
                            class="form-control"
                            placeholder="Nhập lại mật khẩu"
                            :class="{
                                'is-invalid':
                                  submitted && $v.modelpass.confirmPass.$error,
                              }"
                        />
                        <div
                            v-if="submitted && !$v.modelpass.confirmPass.required"
                            class="invalid-feedback"
                        >
                          Vui lòng nhập lại mật khẩu.
                        </div>
                        <div
                            v-if="modelpass.confirmPass && !$v.modelpass.confirmPass.sameAsPassword"
                            class="invalid-feedback"
                        >
                          Nhập lại mật khẩu và mật khẩu mới không trùng khớp.
                        </div>
                      </div>

                    </div>

                  </div>
                  <!-- end col -->
                </div>
                <b-button variant="success" class="text-right pt-1 mt-2" style="float: right" size="sm" type="submit"  @click="handleSubmit">
                  <i
                      class="bx bx-check-double font-size-16 align-middle me-2"
                  ></i>
                  Đổi mật khẩu
                </b-button>
                <!-- end row -->
              </tab-content>

            </form-wizard>
          </div>
          <!-- end card-body -->
        </div>
        <!-- end card -->
      </div>
      <!-- end col -->
    </div>
  </Layout>
</template>
