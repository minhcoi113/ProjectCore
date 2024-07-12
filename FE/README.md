# Project Admin

## Project setup

```
yarn install
```

### Compiles and hot-reloads for development

```
yarn run serve
```

### Compiles and minifies for production

```
yarn run build
```

## Structure project

- [Components](Components): Contains individual project components that can be reused.
- [Models](Models): Define mapping model from api and vice versa.
- [Pages](pages): Contains views of each modules.
- [Router](router): Define routers.
- [State](state):
    - [Modules](modules): Contains store.
    - [Store](store): Store for Vuex.

## Create new Modules or new Pages

1. Create a component in the src/pages/demo.vue with name demo.vue.

```javascript
 <script>
    import Layout from '../../layouts/main'
    import PageHeader from '@/components/page-header'

    export default {
    components: {Layout, PageHeader},
}
</script>

<template>
    <Layout>
        <PageHeader
        :title="title" :items="items" />
        This is New Page
    </Layout>
</template>
```

2. Set the route in /src/router/routes.js

```javascript
export default [
    {
        path: "/",
        name: "default",
        meta: {
            authRequired: false,
        },
        component: () => import("../pages/section"),
    },
    {
        path: "/404",
        name: "404",
        component: require("./views/utility/404").default,
    },
    {
        path: "*",
        redirect: "404",
    },
]
```

3. Show router out menu

```javascript
export const menuItems = [
    {
        id: 1,
        label: "AnhDev99 Management",
        isTitle: true
    },
    {
        id: 2,
        label: "Blogs",
        icon: "bx-home-circle",
        subItems: [
            {
                id: 3,
                label: "Sections",
                link: "/",
                parentId: 2
            },
            {
                id: 4,
                label: "Categories",
                link: "/dashboard/saas",
                parentId: 2
            },
            {
                id: 5,
                label: "Posts",
                link: "/dashboard/crypto",
                parentId: 2
            }
        ]
    }
];
```

4. Using Store with Vuex in state/modules -> new file demoStore.js

```javascript
import {apiClient} from "@/state/modules/apiClient";

export const actions = {
    async getAll({commit}) {
        return apiClient.get("/sections/get-all");
    },
    async create({commit}, values) {
        return apiClient.post("/sections/create", values);
    },
    async update({commit, dispatch}, values) {
        return apiClient.put("/sections/update", values);
    },
    async delete({commit}, id) {
        return await apiClient.delete("/sections/delete/" + id);
    },
    async getById({commit}, id) {
        return apiClient.get("/sections/get-by-id/" + id);
    }
};
```

5. Binding model in Models folder -> new file demoModel.js

```javascript
const toJson = (item) => {
    return {
        id: item.id,
        name: item.name,
        slug: item.slug
    }
}

const fromJson = (item) => {
    return {
        id: item.id,
        name: item.name,
        slug: item.slug
    }
}

const baseJson = () => {
    return {
        id: 0,
        name: null,
        slug: null
    }
}

export const sectionModel = {
    toJson, fromJson, baseJson
}
```

6. Call API with dispatch

```javascript
await this.$store.dispatch("sectionStore/update", this.section).then((res) => {
    // after call api return value you can check value correct and then show message notify.
    this.$store.dispatch("snackBarStore/addNotify", notifyModel.addMessage(res))
});
```