import {apiClient} from "@/state/modules/apiClient";

const controller = "UnitRole";
export const actions = {
    async getAll({commit}) {
        return apiClient.get(controller + "/get-all-core");
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
    async delete({commit}, params) {
        return await apiClient.delete(controller + "/delete", params);
    },
    async getById({commit}, params) {
        return apiClient.get(controller + "/get-by-id-core", params);
    }
};
