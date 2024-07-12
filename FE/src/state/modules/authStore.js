import {apiClient} from "@/state/modules/apiClient";
const controller = "auth";
export const state = {
    currentUser: localStorage.getItem('user-token')
}
export const mutations = {
    SET_CURRENT_USER(state, newValue) {
        state.currentUser = newValue
    }
}
export const getters = {
    // Whether the user is currently logged in.
    loggedIn(state) {
        return !!state.currentUser
    }
}

export const actions = {
    async login({commit}, values) {
        return apiClient.post(controller +"/login", values);
    },
    async loginSso({commit}, values) {
        return apiClient.post(controller +"/login-sso", values);
    }
};
