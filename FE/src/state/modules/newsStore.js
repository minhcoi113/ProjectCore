import {apiClient} from "@/state/modules/apiClient";

const controller = "News";
export const actions = {
    async getAll({commit}) {
        return apiClient.get(controller + "/get-all-core");
    },
    async getTinTrangChu({commit}) {
        return apiClient.get(controller + "/get-tin-trang-chu");
    },
    async getPagingParams({commit}, params) {
        return apiClient.post(controller + "/get-paging-params-core", params);
    },
    async getByMenuId({commit, dispatch}, values) {
        return apiClient.post(controller + "/GetByMenuId", values);
    },
    async create({commit}, values) {
        return apiClient.post(controller + "/create", values);
    },
    async update({commit, dispatch}, values) {
        return apiClient.post(controller + "/update", values);
    },
    async updateAction({commit, dispatch}, values) {
        return apiClient.post(controller + "/update-action", values);
    },
    async delete({commit}, id) {
        return await apiClient.post(controller + "/delete" , id);
    },
    async getById({commit}, id) {
        return apiClient.post(controller + "/get-by-id-core" , id);
    },
    async getTinKhac({commit}, values) {
        return apiClient.post(controller + "/TinKhac" , values);
    },

    async createHoiDap({commit}, values) {
        return apiClient.post(controller + "/create-hoi-dap", values);
    },
    async updateHoiDap({commit}, values) {
        return apiClient.post(controller + "/update-hoi-dap", values);
    },
    async getPagingParamsHoiDap({commit}, values) {
        return apiClient.post(controller + "/get-paging-params-hoi-dap", values);
    },
    async getPagingParamsHoiDapCongDan({commit}, values) {
        return apiClient.post(controller + "/get-paging-params-hoi-dap-cong-dan", values);
    },
};
