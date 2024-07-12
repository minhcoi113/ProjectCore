<script>
import Layout from "../../layouts/main";
import PageHeader from "@/components/page-header";
import appConfig from "@/app.config";
import {userModel} from "@/models/userModel";
import {notifyModel} from "@/models/notifyModel";
import {required, sameAs,minLength,maxLength} from "vuelidate/lib/validators";
import vue2Dropzone from "vue2-dropzone";
import {mapState} from "vuex";
import Vue from "vue";

// import { revenueChart } from "./data-profile";
// import Stat from "@/components/widgets/stat";

/**
 * Contacts-Profile component
 */
export default {
  page: {
    title: "Thông tin cá nhân",
    meta: [{ name: "description", content: appConfig.description }]
  },
  components: { Layout, PageHeader, vueDropzone: vue2Dropzone},

  data() {
    return {
      url :  process.env.VUE_APP_API_URL + 'files/view/' ,
      title: "Thông tin cá nhân",
      items: [
        {
          text: "Thông tin cá nhân",
          href: "/thong-tin-ca-nhan"
        },
        {
          text: "Thông tin",
          active:true
        },
      ],
      data: [],
      modelpass:{
        password:null,
        newPass:null,
        confirmPass:null,
        userName:null,
        id:null
      },
      model: userModel.baseJson(),
      modelView: userModel.baseJson(),
      submitted: false,
      submittedPass: false,
      showNotifiModal: false,
      dropzoneOptions: {
        url: `${process.env.VUE_APP_API_URL}files/upload`,
        thumbnailWidth: 300,
        maxFilesize: 30,
        maxFiles:1,
        headers: { "My-Awesome-Header": "header value" },
        addRemoveLinks: true,
        acceptedFiles: ".jpeg,.jpg,.png,.gif"
      },
    };
  },
  created() {
    this.fnGetList();
    this.handleProfile();
    this.getInfomation(this.handleProfile().user.id);
    this.getID();
  },
  computed: {
    dataTree() {
      return this.data;
    },
    ...mapState('userStore', ['reloadAuthUser'])
  },
  watch:{
    reloadAuthUser(value) {
      this.loadData();
    },
  },
  validations: {
    model: {
      fullName: {required},
    },
    modelpass: {
      password: { required },
      newPass:{required,
        valid: function(value) {
          const containsUppercase = /[A-Z]/.test(value)
          const containsLowercase = /[a-z]/.test(value)
          const containsNumber = /[0-9]/.test(value)
          const containsSpecial = /[#?!@$%^&*-]/.test(value)
          return containsUppercase && containsLowercase && containsNumber && containsSpecial
        },
        minLength: minLength(8),
        maxLength: maxLength(20),
      },
      confirmPass: { required, sameAsPassword: sameAs('newPass') }
    }
  },
  methods:{
    async getInfomation(id){
      await  this.$store.dispatch("userStore/getById",id).then((res) =>{
        this.modelView = userModel.toJson(res.data);
        this.model = userModel.toJson(res.data)
      })
    },
    async loadData() {
      await this.getInfomation();
      this.$refs.tree.setModel(this.data)
      // this.$store.state.quyTrinhStore.count  = 1;
      // console.log("this.$store.state.count",this.$store.state.quyTrinhStore.count)
    },
    async fnGetList() {
      this.$refs.tblList?.refresh()
    },
    handleProfile() {
      const profile = localStorage.getItem("auth-user");
      return JSON.parse(profile);
    },
    async handleSubmit(e) {
      e.preventDefault();
      this.submitted = true;
      this.$v.$touch();
      if (this.$v.model.$invalid) {
        return;
      } else {
        let loader = this.$loading.show({
          container: this.$refs.formContainer
        });
        if (
            this.model.id != 0 &&
            this.model.id != null &&
            this.model.id
        ) {
          // Update model
          await this.$store.dispatch("userStore/changeProfile", this.model).then((res) => {
            if (res.code === 0) {
              this.$store.commit('userStore/SET_RELOADAUTHUSER', !this.$store.state.userStore.reloadAuthUser)
              this.modelView = userModel.toJson(res.data);
              this.model = userModel.toJson(res.data)
              this.$refs.myVueDropzone.removeAllFiles()
              // localStorage.removeItem('auth-user');
              // localStorage.setItem('auth-user', JSON.stringify(res.data));
            }
            this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res))
          });
        }
        loader.hide();
      }
      this.submitted = false;
    },
    getID(){
      const idstore= localStorage.getItem('auth-user');
      //console.log('StroreID', JSON.parse(idstore)?.user?.id);
      this.modelpass.userName=JSON.parse(idstore)?.user?.userName;
      this.modelpass.id=JSON.parse(idstore)?.user?.id;
      return JSON.parse(idstore);
    },
    async handleDetail(id) {
      await this.$store.dispatch("userStore/getById", id).then((res) => {
        if (res.code === 0) {
          this.model = userModel.fromJson(res.data);
          this.showDetail = true;
        } else {
          this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res));
        }
      });
    },
    async handleSubmitPass(e) {
      e.preventDefault();
      this.submittedPass = true;
      this.$v.$touch()
      if (this.$v.modelpass.$invalid) {
        return;
      } else {
        let loader = this.$loading.show({
          container: this.$refs.formPasswordContainer,
        });
        if (
            this.modelpass.id != 0 &&
            this.modelpass.id != null &&
            this.modelpass.id
        ) {
          await this.$store.dispatch("userStore/changePassword", this.modelpass).then((res) => {
            if (res.success) {
              this.fnGetList();
              this.showModal = false;
            }
            this.modelpass.newPass =null;
            this.modelpass.password=null;
            this.modelpass.confirmPass=null;
            if(res.resultCode=='SUCCESS'){
              this.showNotifiModal=true;
            }
            else{
              this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res))
            }
          });
        }
        loader.hide();
      }
      this.submittedPass = false;
    },
    removeHinhAnh(file, error, xhr){
      let fileHinhAnh = JSON.parse( file.xhr.response);
      if(fileHinhAnh.data && fileHinhAnh.data.id){
        let idFile = fileHinhAnh.data.id;
        let resultData =   this.model.avatar.filter(x => {
          return x.fileId != idFile;
        })
        this.model.avatar= resultData;
      }
    },
    addHinhAnh(file, response){
      if(this.model ){
        if(this.model.avatar == null || this.model.avatar.length <= 0){
          this.model.avatar = [];
        }
        let fileSuccess = response.data;
        this.model.avatar = {fileId: fileSuccess.id,  name: fileSuccess.fileName};
      }
    },
    logoutUser() {
      // eslint-disable-next-line no-unused-vars
      var userLocalStorage = localStorage.getItem("user-token");
      if (userLocalStorage) {
        localStorage.removeItem("user-token");
        localStorage.removeItem("auth-user");
        localStorage.removeItem("TabData");
        window.location.href="/dang-nhap"
        // this.$router.push("/dang-nhap");
        return;
      }
    },
  },

};
</script>

<template>
  <Layout>
    <PageHeader :title="title" :items="items" />
    <div class="row">
      <div class="col-xl-4">
        <div class="card overflow-hidden">
          <div class="bg-soft bg-primary">
            <div class="row">
              <div class="col-7">
                <div class="text-primary p-1">
                  <h5 class="text-primary">Chào mừng bạn đã trở lại</h5>
                </div>
              </div>
              <div class="col-4 align-self-end">
                <img src="@/assets/images/profile-img.png" alt class="img-fluid" />
              </div>
            </div>
          </div>
          <div class="card-body pt-0" style="margin-top: -10px">
            <div class="row">
              <div class="col-sm-12">
                <div class="avatar-md profile-user-wid mb-2">
                  <div v-if="modelView.avatar != null">
                    <b-img
                        :src=" url + `${modelView.avatar.fileId}`"
                        alt
                        class="img-thumbnail rounded-circle"
                        style="height: 72px ; width: 72px"
                    >
                    </b-img>
                  </div>
                  <div v-else>
                    <img
                        class="img-thumbnail rounded-circle"
                        style="height: 72px ; width: 72px"
                        alt
                        src="@/assets/images/avatar-default.png"
                    />
                  </div>

                </div>
                <h5 class="font-size-15 text-truncate">{{modelView.fullName}}</h5>
                <p class="text-muted mb-0 text-truncate">@{{modelView.userName}}</p>
              </div>

<!--              <div class="col-sm-6">-->
<!--                <div class="pt-4">-->
<!--                  <div class="row">-->
<!--                    <div class="col-6">-->
<!--                      <h5 class="font-size-15">125</h5>-->
<!--                      <p class="text-muted mb-0">Projects</p>-->
<!--                    </div>-->
<!--                    <div class="col-6">-->
<!--                      <h5 class="font-size-15">$1245</h5>-->
<!--                      <p class="text-muted mb-0">Revenue</p>-->
<!--                    </div>-->
<!--                  </div>-->
<!--                </div>-->
<!--              </div>-->
            </div>
          </div>
        </div>
        <!-- end card -->
        <div class="card">
          <div class="card-body">
            <h4 class="card-title mb-4">Thông tin cá nhân</h4>
<!--            <p-->
<!--                class="text-muted mb-4"-->
<!--            >Hi I'm Cynthia Price,has been the industry's standard dummy text To an English person, it will seem like simplified English, as a skeptical Cambridge.</p>-->
            <div class="table-responsive ">
              <table class="table table-nowrap mb-0">
                <tbody>
                <tr>
                  <th scope="row" class="fw-normal">Tên tài khoản :</th>
                  <td class="fw-bold">{{modelView.userName}}</td>
                </tr>
                <tr>
                  <th scope="row" class="fw-normal">Họ và tên :</th>
                  <td class="fw-bold">{{modelView.fullName}}</td>
                </tr>
                <tr>
                  <th scope="row" class="fw-normal">E-mail :</th>
                  <td class="fw-bold">{{modelView.email}}</td>
                </tr>
                <tr>
                  <th scope="row" class="fw-normal">Số điện thoại :</th>
                  <td class="fw-bold">{{modelView.phoneNumber}}</td>
                </tr>
<!--                <tr>-->
<!--                  <th scope="row" class="fw-normal">Quyền :</th>-->
<!--                  <td class="fw-bold">-->
<!--                    <div v-for="item in modelView.roles" v-bind:key="item.id">- {{item.ten}}</div></td>-->
<!--                </tr>-->
<!--                <tr>-->
<!--                  <th scope="row" class="fw-normal">Cơ quan</th>-->
<!--                  <td class="fw-bold">{{modelView.donVi.ten}}</td>-->
<!--                </tr>-->
                </tbody>
              </table>
            </div>
          </div>
        </div>
        <!-- end card -->
      </div>

      <div class="col-xl-8">
<!--        <div class="row">-->
<!--          <div v-for="stat of statData" :key="stat.icon" class="col-md-4">-->
<!--            <Stat :icon="stat.icon" :title="stat.title" :value="stat.value" />-->
<!--          </div>-->
<!--        </div>-->
        <div class="col-xl-12">
          <div class="card">
            <div class="card-body">
              <b-tabs justified nav-class="nav-tabs-custom" content-class="p-3 text-muted">
                <b-tab active>
                  <template v-slot:title>
                  <span class="d-inline-block d-sm-none">
                    <i class="far fa-user"></i>
                  </span>
                    <span class="d-none d-sm-inline-block">Thông tin tài khoản</span>
                  </template>
                  <div class="text-end">
                    <b-button type="submit" variant="primary" class=" align-middle me-2" style="width: 80px" size="sm"
                              @click="handleSubmit"
                    >
                      Cập nhật
                    </b-button>
                  </div>
                  <form @submit.prevent="handleSubmit" ref="formContainer">
                    <div class="row">
                      <div class="col-12">
                        <div class="mb-3">
                          <label class="text-left">Họ và tên</label>
                          <span style="color: red">&nbsp;*</span>
                          <input type="hidden" v-model="model.id"/>
                          <input
                              id="lastName"
                              v-model="model.fullName"
                              type="text"
                              class="form-control"
                              placeholder="Nhập họ"
                              :class="{
                                'is-invalid':
                                  submitted && $v.model.fullName.$error,
                              }"
                          />
                          <div
                              v-if="submitted && !$v.model.fullName.required"
                              class="invalid-feedback"
                          >
                            Họ và tên không được trống.
                          </div>
                        </div>
                      </div>
                      <div class="col-12">
                        <div class="mb-3">
                          <label class="text-left">Số điện thoại</label>
                          <input type="hidden" v-model="model.id"/>
                          <input
                              id="phoneNumber"
                              v-model="model.phoneNumber"
                              v-mask="'##########'"
                              type="text"
                              class="form-control"
                              placeholder="Nhập số điện thoại"
                          />
                        </div>
                      </div>
                      <div class="col-12">
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
                        <label class="text-left">Hình ảnh</label>
                        <div class=" profile-user-wid mt-2">
                          <div v-if="model.avatar != null">
                            <b-img
                                style="height: 200px ; width: 300px"
                                :src=" url + `${model.avatar.fileId}`">
                            </b-img>
                          </div>
                          <div v-else>
                            <img
                                style="max-height: 280px ; width: 300px"
                                src="@/assets/images/avatar-default.png"
                            />
                          </div>
                        </div>
                      </div>

                      <div class="col-6" >
                        <label class="text-left">Chọn ảnh </label>
                        <input type="hidden" v-model="model.id"/>
                        <vue-dropzone
                            id="myVueDropzone"
                            ref="myVueDropzone"
                            :use-custom-slot="true"
                            :options="dropzoneOptions"
                            v-on:vdropzone-removed-file="removeHinhAnh"
                            v-on:vdropzone-success="addHinhAnh"
                        >
                          <div class="dropzone-custom-content">
                            <i class="display-1 text-muted bx bxs-cloud-upload " style="font-size: 70px"></i>
                            <h4>Kéo thả hình ảnh hoặc bấm vào để tải hình ảnh</h4>
                          </div>
                        </vue-dropzone>
                      </div>
<!--                      <div class="text-end pt-2 mt-3">-->
<!--                        <b-button  type="submit" variant="success" class="ms-1" size="sm"><i-->
<!--                            class="bx bx-check-double font-size-16 align-middle me-2"-->
<!--                        ></i> Cập nhật-->
<!--                        </b-button>-->
<!--                      </div>-->
                    </div>
                  </form>

                </b-tab>
                <b-tab>
                  <template v-slot:title>
                  <span class="d-inline-block d-sm-none">
                    <i class="fas fa-key"></i>
                  </span>
                    <span class="d-none d-sm-inline-block">Đổi mật khẩu</span>
                  </template>
                  <form @submit.prevent="handleSubmitPass"  ref="formPasswordContainer">
                    <div class="row">
                      <div class="col-6">
                        <div class="mb-3">
                          <label class="text-left">Tên tài khoản</label>
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
                      <div class="col-6">
                        <div class="mb-3">
                          <label class="text-left">Mật khẩu</label>
                          <span style="color: red">&nbsp;*</span>
                          <input type="hidden" v-model="modelpass.id"/>
                          <input
                              v-model="modelpass.password"
                              id="pwd"
                              type="password"
                              name="pwd"
                              class="form-control"
                              placeholder="Nhập mật khẩu"
                              :class="{
                                'is-invalid':
                                  submittedPass && $v.modelpass.password.$error,
                              }"
                          />
                          <div
                              v-if="submittedPass && !$v.modelpass.password.required"
                              class="invalid-feedback"
                          >
                            Mật khẩu không được để trống.
                          </div>
                        </div>
                      </div>
                      <div class="col-6">
                        <div class="mb-3">
                          <label class="text-left">Mật khẩu mới</label>
                          <span style="color: red">&nbsp;*</span>
                          <input type="hidden" v-model="modelpass.id"/>
                          <input
                              v-model="modelpass.newPass"
                              id="pwdnew"
                              type="password"
                              class="form-control"
                              placeholder="Nhập mật khẩu mới"
                              :class="{
                                'is-invalid':
                                  submittedPass && $v.modelpass.newPass.$error,
                              }"
                          />
                          <div
                              v-if="submittedPass && !$v.modelpass.newPass.required"
                              class="invalid-feedback"
                          >
                            Mật khẩu mới không được để trống.
                          </div>
                          <div
                              v-if="submittedPass && !$v.modelpass.newPass.valid"
                              class="invalid-feedback"
                          >
                            Mật khẩu cần có ít nhất một ký tự chữ hoa, một ký tự chữ thường, một số, một ký tự đặc biệt.
                          </div>
                          <div
                              v-if="submittedPass && !$v.modelpass.newPass.minLength"
                              class="invalid-feedback"
                          >
                            Mật khẩu cần có ít nhất 8 ký tự.
                          </div>
                          <div
                              v-if="submittedPass && !$v.modelpass.newPass.maxLength"
                              class="invalid-feedback"
                          >
                            Mật khẩu chỉ được tối đa 20 ký tự.
                          </div>
                        </div>
                      </div>
                      <div class="col-6">
                        <div class="mb-3">
                          <label class="text-left">Nhập lại mật khẩu</label>
                          <span style="color: red">&nbsp;*</span>
                          <input type="hidden" v-model="modelpass.id"/>
                          <input
                              v-model="modelpass.confirmPass"
                              id="confirmpwd"
                              type="password"
                              class="form-control"
                              placeholder="Nhập lại mật khẩu"
                              :class="{
                                'is-invalid':
                                  submittedPass && $v.modelpass.confirmPass.$error,
                              }"
                          />
                          <div
                              v-if="submittedPass && !$v.modelpass.confirmPass.required"
                              class="invalid-feedback"
                          >
                            Vui lòng nhập lại mật khẩu.
                          </div>
                          <div
                              v-if="submittedPass &&modelpass.confirmPass && !$v.modelpass.confirmPass.sameAsPassword"
                              class="invalid-feedback"
                          >
                            Nhập lại mật khẩu và mật khẩu mới không trùng khớp.
                          </div>

                        </div>
                      </div>

                      <div class="text-end pt-2 mt-3">
                        <b-button  type="submit" variant="primary" class="ms-1" size="sm"><i
                            class="bx bx-check-double font-size-16 align-middle me-2"
                        ></i> Lưu
                        </b-button>
                      </div>
                    </div>
                  </form>
                </b-tab>

              </b-tabs>
            </div>
          </div>
        </div>
      </div>

    </div>
    <!-- end row -->
    <b-modal
        v-model="showNotifiModal"
        centered
        title="Thông tin"
        title-class="font-18; card-title"
        no-close-on-backdrop
        hide-header-close
        size="sm"
    >
      <p>
        Cập nhật mật khẩu thành công!
      </p>
      <template #modal-footer>
        <button v-b-modal.modal-close_visit
                class="btn btn-success btn m-1"
                v-on:click="logoutUser">
          OK
        </button>
      </template>
    </b-modal>
  </Layout>
</template>
