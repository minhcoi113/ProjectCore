import {apiClient} from "@/state/modules/apiClient";

const controller = "DanhMuc";
export const actions = {
    async getAll({commit}) {
        return apiClient.get(controller + "/get-all-core");
    },
};
