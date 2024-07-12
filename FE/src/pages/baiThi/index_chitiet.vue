<script>
import Layout from "@/layouts/main";
import PageHeader from "@/components/page-header";
import appConfig from "@/app.config";
import { pagingModel } from "@/models/pagingModel";
import { baiThi3Model } from "@/models/baiThi3Model";

export default {
    page: {
        title: "Chi tiết công việc",
        meta: [{ name: "description", content: appConfig.description }],
    },
    components: { Layout, PageHeader },
    data() {
        return {
            title: "Chi tiết công việc",
            items: [
                {
                    text: "Chi tiết công việc",
                    href: '/chi-tiet-cong-viec'
                },
                {
                    text: "Chi tiết",
                    active: true,
                }
            ],
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
                    sortable: true,
                    thStyle: "text-align:center",
                    thClass: 'hidden-sortable'
                },
                {
                    key: "trangThai",
                    label: "Trạng Thái",
                    thStyle: "text-align:center",
                    sortable: true,
                    thClass: 'hidden-sortable'
                },
                {
                    key: "moTaCongViec",
                    label: "Mô tả",
                    thStyle: "text-align:left",
                    sortable: true,
                    thClass: 'hidden-sortable'
                }
            ],
            listChildren: [],
            data: [],
            model: baiThi3Model.baseJson(),
            pagination: pagingModel.baseJson()
        };
    },
    created() {
        this.getChildren();
    },
    methods: {
        handleDetailProject(id) {
            console.log("Min: ", id);
            localStorage.setItem("currentProject", id);
            localStorage.setItem("currentProject", id);
            if (this.$route.path === '/chi-tiet-cong-viec') {
                this.$router.replace('/chi-tiet-cong-viec');
            } else {
                this.$router.push('/chi-tiet-cong-viec');
            }
        },
        normalizer(node) {
            if (node.children == null || node.children == 'null') {
                delete node.children;
            }
        },

        async getView() {
            let currentProjectLocal = localStorage.getItem('currentProject');
            let param = {
                id: currentProjectLocal
            }
            await this.$store.dispatch("baiThiStore/getById", param).then((res) => {
                if (res.code === 0) {
                    this.model = baiThi3Model.toJson(res.data);
                } else {
                    this.$store.dispatch("snackBarStore/addNotify", {
                        message: res.message,
                        code: res.code,
                    });
                }
            });
        },

        async getChildren() {
            await this.getView();
            let id = this.model.id;
            this.loading = true;
            try {
                let promise = this.$store.dispatch("baiThiStore/getListById", id)
                return promise.then((res) => {
                    this.listChildren = res.data;
                    return this.listChildren || []
                })
            } finally {
                this.loading = false
            }
        },
    }
};
</script>

<template>
    <Layout>
        <PageHeader :title="title" :items="items" />
        <div class="row">
            <div class="col-12">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col-12">
                                <div class="mb-6">
                                    <label class="text-left" style="font-weight: bold">Tên công việc: </label>
                                    <div id="name" class="form-control-plaintext">
                                        {{ model.name }}
                                    </div>
                                </div>
                            </div>
                            <div class="col-12">
                                <div class="row">
                                    <div class="col-md-6 mb-6">
                                        <label class="text-left" style="font-weight: bold">Ngày bắt đầu: </label>
                                        <div id="thoiGianBatDau" class="form-control-plaintext">
                                            {{ model.thoiGianBatDau }}
                                        </div>
                                    </div>
                                    <div class="col-md-6 mb-6">
                                        <label class="text-left" style="font-weight: bold">Ngày kết thúc: </label>
                                        <div id="thoiGianKetThuc" class="form-control-plaintext">
                                            {{ model.thoiGianKetThuc }}
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-12">
                                <div class="mb-6">
                                    <label class="text-left" style="font-weight: bold">Tình trạng công việc: </label>
                                    <div id="trangThai" class="form-control-plaintext">
                                        {{ model.trangThai.name }}
                                    </div>
                                </div>
                            </div>
                            <div class="col-12">
                                <div class="mb-6">
                                    <label class="text-left" style="font-weight: bold">Mô tả: </label>
                                    <textarea id="moTaCongViec" v-model="model.moTaCongViec" class="form-control"
                                        rows="5" disabled></textarea>
                                </div>
                            </div>
                            <div class="col-12">
                                <div class="mb-6">
                                    <label class="text-left" style="font-weight: bold">Người giải quyết: </label>
                                    <div id="nguoiThucHien" class="form-control-plaintext">
                                        <span v-for="(item, index) in model.nguoiThucHien" :key="index">
                                            {{ item.name }}<span v-if="index < model.nguoiThucHien.length - 1">, </span>
                                        </span>
                                    </div>
                                </div>
                            </div>
                            <div class="col-12">
                                <div class="mb-6">
                                    <label class="text-left" style="font-weight: bold">File đính kèm: </label>
                                    <div v-if="model.files.length > 0">
                                        <div v-for="file in model.files" :key="file.fileId" class="file-item">
                                            <b-link class="ml-25"
                                                :href="`https://localhost:5001/api/v1/files/view/${file.fileId}`"
                                                target="_blank">
                                                {{ file.fileName }}
                                            </b-link>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-12">
                                <div class="mb-6">
                                    <label class="text-left" style="font-weight: bold">Công việc con: </label>
                                    <div class="table-responsive mb-0">
                                        <b-table class="datatables table-admin" :items="listChildren" :fields="fields"
                                            striped bordered responsive="sm" ref="tblList" primary-key="id">
                                            <template v-slot:cell(STT)="data">
                                                {{ data.index + 1 }}
                                            </template>
                                            <template v-slot:cell(name)="data">
                                                <span style="margin-left: 5px">
                                                    <a style="cursor: pointer;"
                                                        v-on:click="handleDetailProject(data.item.id)">
                                                        {{ data.item.name }}
                                                    </a>
                                                </span>
                                            </template>
                                            <template v-slot:cell(trangThai)="data">
                                                <span style="margin-left: 5px">
                                                    {{ data.item.trangThai.name }}
                                                </span>
                                            </template>
                                        </b-table>
                                    </div>
                                </div>
                            </div>
                        </div>
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
