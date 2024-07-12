import {apiClient} from "@/state/modules/apiClient";
const controller = "module";
export const actions = {
    async getTreeModule({commit}) {
        return apiClient.get(controller + "/get-tree-module");
    },
    async getAll({commit}) {
        return apiClient.get(controller + "/get-all");
    },
    async getPagingParams({commit}, params) {
        return apiClient.post(controller + "/get-paging-params", params);
    },
    async create({commit}, values) {
        return apiClient.post(controller + "/create", values);
    },
    async update({commit, dispatch}, values) {
        return apiClient.put(controller + "/update", values);
    },
    async delete({commit}, id) {
        return await apiClient.delete(controller + "/delete/" + id);
    },
    async getById({commit}, id) {
        return apiClient.get(controller + "/get-by-id/" + id);
    },
    async createPermission({commit}, values) {
        return apiClient.post(controller + "/createPermission", values);
    },
    async deletePermission({commit}, values) {
        return apiClient.deleteObject(controller + "/deletePermission", values);
    },
    async getPermissionById({commit}, values) {
        return apiClient.deleteObject(controller + "/GetPermissionById", values);
    }

};
