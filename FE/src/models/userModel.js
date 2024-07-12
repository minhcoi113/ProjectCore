const toJson = (item) => {
    return {
        id: item.id,
        userName: item.userName,
        name: item.name,
        email: item.email,
        roles: item.roles
    }
}

const fromJson = (item) => {
    return {
        id: item.id,
        userName: item.userName,
        name: item.name,
        email: item.email,
        roles: item.roles
    }
}

const baseJson = () => {
    return {
        id: null,
        userName: null,
        name: null,
        email: null,
        roles: null
    }
}

const toListModel = (items) =>{
    if(items.length > 0){
        let data = [];
        items.map((value, index) =>{
            data.push(fromJson(value));
        })
        return data??[];
    }
    return [];
}
export const userModel = {
    toJson, fromJson, baseJson, toListModel
}
