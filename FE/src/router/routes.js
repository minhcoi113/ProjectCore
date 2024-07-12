import store from "@/state/store";
export default [
    {
        path: "/dang-nhap",
        name: "login",
        component: () => import("../pages/login/login"),
        meta: {
            beforeResolve(routeTo, routeFrom, next) {
                if (store.getters["authStore/loggedIn"]) {
                    next({name: "default"});
                } else {
                    next();
                }
            }
        },
    },
    {
        path: "/menu",
        name: "Menu",
        meta: {},
        component: () => import("../pages/menu"),
    },
    {
        path: "/danh-muc",
        name: "default",
        meta: {},
        component: () => import("../pages/danhMuc"),
    },
    {
        path: "/tai-khoan",
        name: "Tài khoản",
        component: () => import("../pages/user"),
    },
    {
        path: "/thong-tin-ca-nhan",
        name: "Thông tin cá nhân",
        // meta: {},
        component: () => import("../pages/login/profile"),
    },
    {
        path: "/",
        name: "Danh sách công việc",
        // meta: {},
        component: () => import("../pages/baiThi"),
    },
    
    {
        path: "/cong-viec",
        name: "Danh sách công việc",
        // meta: {},
        component: () => import("../pages/baiThi"),
    },
    {
        path: "/cong-viec-duoc-giao",
        name: "Danh sách công việc được giao",
        // meta: {},
        component: () => import("../pages/baiThi/index_duocgiao"),
    },
    {
        path: "/chi-tiet-cong-viec",
        name: "Chi tiết công việc",
        // meta: {},
        component: () => import("../pages/baiThi/index_chitiet"),
    },
    {
        path: "/404",
        name: "404",
        component: require("../pages/utility/404").default,
    },
    {
        path: "/unauthorized",
        name: "401",
        component: require("../pages/utility/401").default,
    },
    {
        path: "*",
        redirect: "404",
    },

]
