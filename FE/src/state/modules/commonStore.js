import {apiClient} from "@/state/modules/apiClient";
const controller = "Common";

export const state = {
    reloadAuthUser: false,
}

export const mutations = {
    SET_RELOADAUTHUSER(state, newValue) {
        state.reloadAuthUser = newValue
    }
}
export const actions = {
    async getAll({commit}, collectionName) {
        return apiClient.get(controller + "/get-all/" + collectionName );
    },
    async getList({commit}) {
        return apiClient.get(controller + "/get-list");
    },
    async getPagingParams({commit}, params) {
        return apiClient.post(controller +"/get-paging-params", params);
    },

    async create({commit}, values) {
        return apiClient.post(controller +"/create", values);
    },
    async update({commit, dispatch}, values) {
        return apiClient.post(controller +"/update", values);
    },
    async delete({commit}, values) {
        return await apiClient.post(controller +"/delete", values);
    },
    async getById({commit}, id) {
        return apiClient.post(controller +"/get-by-id" , id);
    },
};
