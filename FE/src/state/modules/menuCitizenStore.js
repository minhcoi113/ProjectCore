import {apiClient} from "@/state/modules/apiClient";
const controller = "MenuCitizen";
export const actions = {
    async getAll({commit}) {
        return apiClient.get(controller +"/get-all");
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
        return await apiClient.post(controller + "/delete" , id);
    },
    async getById({commit}, id) {
        return apiClient.post(controller + "/get-by-id-core" , id);
    },
    async getTree({commit}, id) {
        return apiClient.get(controller + "/getTree");
    },
    async getTreeList({commit}, id) {
        return apiClient.get(controller + "/getTreeList");
    },
    async getTreeListAD({commit}, id) {
        return apiClient.get(controller + "/getTreeList");
    },

    async getTreeListTBV({commit}, id) {
        return apiClient.get(controller + "/getTreeListTBV");
    },
    async getTreeFlatten({commit}) {
        return apiClient.get(controller + "/getTreeFlatten");
    },
    async getCount({commit}) {
        return apiClient.get(controller +"/get-count");
    },
    async getDanhMuc({commit}, id) {
        return apiClient.get(controller + "/getDanhSach");
    },
};
