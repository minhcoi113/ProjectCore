<script>
import Layout from "../../layouts/main";
import PageHeader from "@/components/page-header";
import appConfig from "@/app.config";
import {notifyModel} from "@/models/notifyModel";
export default {
  page: {
    title: "Thêm quyền vào vai trò",
    meta: [{name: "description", content: appConfig.description}],
  },
  components: {Layout, PageHeader},
  data() {
    return {
      node: [],
      model : null ,
      title: "Thiết lập quyền",
      items: [
        {
          text: "Vai trò",
          active: true,
        },
        {
          text: "Thêm quyền",
          active: true,
        }
      ],
      showModal: false,
      showDeleteModal: false,
      submitted: false,
      treeView: [],
      itemEvents: {
        mouseover: function () {

        },
        contextmenu: function () {
          arguments[2].preventDefault()
        }
      },
      fields: [
        {
          key: 'STT',
          label: 'STT',
          class: 'text-center',
          thStyle: {width: '30px', minWidth: '30px'},
           thClass: 'hidden-sortable'
        },
        {
          key: "name",
          label: "Tên",
          class: "text-center",
          thStyle: {width: '80px', minWidth: '80px'},
          thClass: 'hidden-sortable'
        },
        {
          key: "action",
          label: "Hành động",
          class: "text-center",
          thStyle: {width: '80px', minWidth: '80px'},
          thClass: 'hidden-sortable'
        },
        {
          key: 'process',
          label: 'Xử lý',
          class: 'text-center',
          thStyle: {width: '10px', minWidth: '10px'},
          thClass: 'hidden-sortable'
        }
      ],
    };
  },
  created() {
    this.GetTreeList();
    this.GetPermissionsByRoleId();
  },
  methods: {
    async GetTreeList(){
      await this.$store.dispatch("moduleStore/getAll").then((res) => {
            if (res.code === 0)
            {
              res.data.forEach(elements => this.treeView.push(elements))
              //res.data
            }
      })
    },
    async itemClick (node) {
      this.node = node.model

    },
    async GetPermissionsByRoleId() {
      await this.$store.dispatch("roleStore/getById", this.$route.params.id).then((res) => {
        if (res.code === 0) {
               this.model = res.data;
        } else {
          this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res));
        }
      });
    },
    statusPermission(permission) {
      let check = this.model.permissions.findIndex(x => x.id == permission.id);
      if (check == undefined || check == -1 )
      {
        return  false;
      }
      return true
    },
    onChecked(item) {
      let check = this.model.permissions.findIndex(x => x.id == item.id);
      if (check == undefined || check == -1 )
      {
        this.model.permissions.push({id: item.id, name: item.name, action: item.action})
      }else {
        this.model.permissions = this.model.permissions?.filter(x => {
          if (x.id != item.id)
            return x;
        });
      }
    },
    async handleSubmitRole() {
      await this.$store.dispatch("roleStore/update", this.model).then((res) => {
        if (res.code === 0) {
          this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res));
        }
      })
    }
  },
};
</script>
<template>
  <Layout>
    <PageHeader   :title="title" :items="items"/>
     <div class="row">
       <div class="col-lg-11">
       </div>
       <div class="col-1">
         <b-button
             type="button "
             class="btn-label mb-3 me-2 cs-btn-primary"
             @click="handleSubmitRole" size="xl"
             v-if="$can('save-permission')"
         >
           <i class="mdi mdi-plus me-1 label-icon"></i> Lưu
         </b-button>
       </div>
     </div>
    <div class="row">
      <div class="col-4">
        <div class="card">
          <div class="card-body">
            <div class="font-weight-bold text-danger" style="margin-bottom: 5px" >
              {{this.model.ten}}
            </div>
            <v-jstree  :data = "treeView"  text-field-name = "name" @item-click="itemClick"></v-jstree>
          </div>
        </div>
      </div>
      <div class="col-8">
        <div class="card">
          <div class="card-body">
            <h4 class=" text-danger font-weight-bold font-size-20">{{this.node.name}}</h4>
            <b-table
                class="datatables"
                :items="this.node.permissions"
                :fields="fields"
                striped
                bordered
                responsive="sm">
            <template v-slot:cell(STT)="data">
              {{ data.index + ((currentPage-1)*perPage) + 1  }}
            </template>
              <template v-slot:cell(process)="data">
                <div class="form-check form-check-danger">
                  <input
                      class="form-check-input"
                      type="checkbox"
                      id="formCheckcolor1"
                      :checked="statusPermission(data.item)"
                      @click = "onChecked(data.item)"
                  />
                </div>
              </template>
            </b-table>
          </div>
        </div>
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
