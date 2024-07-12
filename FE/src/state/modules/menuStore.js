import {apiClient} from "@/state/modules/apiClient";
const controller = "menu";
export const actions = {
    async getAll({commit}) {
        return apiClient.get(controller +"/get-all");
    },
    async getPagingParams({commit}, params) {
        return apiClient.post(controller + "/get-paging-params-core", params);
    },
    async create({commit}, values) {
        return apiClient.post(controller + "/create", values);
    },
    async update({commit, dispatch}, values) {
        return apiClient.put(controller + "/update", values);
    },
    async delete({commit}, id) {
        return await apiClient.post(controller + "/delete/" , id);
    },
    async getById({commit}, id) {
        return apiClient.post(controller + "/get-by-id-core" , id);
    },

    async getListActionById({commit}, id) {
        return apiClient.post(controller + "/get-list-acion" , id);
    },
    async getTree({commit}, id) {
        return apiClient.get(controller + "/getTree");
    },
    async getTreeList({commit}, id) {
        return apiClient.get(controller + "/getTreeList");
    },

    async addAction({commit}, values) {
        return apiClient.post(controller + "/add-action", values);
    },
    async deleteAction({commit}, values) {
        return apiClient.deleteObject(controller + "/delete-action", values);
    },
    async getTreeListAndAction({commit}) {
        return apiClient.get(controller + "/getTreeMenuAndAction");
    },
    async getCount({commit}) {
        return apiClient.get(controller +"/get-count");
    },
    async getTreeListNoiBo({commit}) {
        return apiClient.get(controller + "/getTreeListNoiBo");
    },
    async getTreeFlatten({commit}) {
        return apiClient.get(controller + "/getTreeFlatten");
    },
};
