const toJson = (item) => {
    return {
        id: item.id,
        name: item.name,
        action: item.action,
        sort: item.sort,
        idModule: item.idModule,
        tenModule: item.tenModule,
        isView: item.isView
    }
}

const fromJson = (item) => {
    return {
        id: item.id,
        name: item.name,
        action: item.action,
        sort: item.sort,
        idModule: item.idModule,
        isView: item.isView
    }
}

const baseJson = () => {
    return {
        id: null,
        name: null,
        sort: 0,
        action: null,
        idModule: null,
        tenModule: null,
        isView: false
    }
}
const convernJson = (item, id) => {
    return {
        id: item.id,
        name: item.name,
        sort: item.sort,
        action: item.action,
        idModule: id,
        tenModule: item.tenModule,
        isView: item.isView,
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

export const quyenModel = {
    toJson, fromJson, baseJson, toListModel , convernJson
}
