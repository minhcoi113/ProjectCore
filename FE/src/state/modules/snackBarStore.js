import Vue from "vue";

const options = {
  timeout: 2000,
};

const initialNotify = { message: null, code: null };

export const actions = {
  async addNotify({ commit }, data = initialNotify) {
    if (data.code === 0) {
      Vue.$toast.success(data.message, options);
    } else if (data.code === 23) {
      Vue.$toast.warning(data.message, options);
    } else {
      Vue.$toast.error(data.message, options);
    }
  },
};
