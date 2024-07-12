import moment from 'moment';
const toJson = (item) => {
    return {
        id: item.id,
        code: item.code,
        ten: item.ten,
        thuTu: item.thuTu,
        menus: item.menus,
       createdAt: item.createdAt,
       modifiedAt: item.modifiedAt,
        createdBy: item.createdBy,
        modifiedBy: item.modifiedBy,
    }
}

const fromJson = (item) => {
    return {
        id: item.id,
        code: item.code,
        ten: item.ten,
        thuTu: item.thuTu,
        createdAt: item.createdAt,
        modifiedAt: item.modifiedAt,
        createdBy: item.createdBy,
        modifiedBy: item.modifiedBy,
        isDeleted: item.isDeleted
    }
}

const baseJson = () => {
    return {
        id: null,
        code: null,
        ten: null,
        thuTu: 0,
        menus: null,
        permissions: null,
        createdAt: null,
        modifiedAt: null,
        createdBy: null,
        modifiedBy: null,
        isDeleted: false
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

export const roleModel = {
    toJson, fromJson, baseJson, toListModel
}
