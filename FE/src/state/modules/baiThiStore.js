import {apiClient} from "@/state/modules/apiClient";
const controller = "baiThi";

export const state = {
    reloadAuthUser: false,
}

export const mutations = {
    SET_RELOADAUTHUSER(state, newValue) {
        state.reloadAuthUser = newValue
    }
}
export const actions = {

        async getPagingParams({commit}, params) {
            return apiClient.post(controller + "/get-paging-params-core", params);
        },
        async create({commit}, values) {
            return apiClient.post(controller + "/create", values);
        },
        async update({commit, dispatch}, values) {
            return apiClient.post(controller + "/update", values);
        },
        async delete({commit}, id) {
            return await apiClient.post(controller + "/delete", id);
        },
        async getById({commit}, id) {
            return apiClient.post(controller + "/get-by-id-core", id);
        },
        async getTreeAll({commit}) {
            return apiClient.get(controller + "/get-tree-all");
        },
        async getListById({commit}, id) {
            return apiClient.get(controller + "/get-list-cv-by-id/" + id);
        },
    };
