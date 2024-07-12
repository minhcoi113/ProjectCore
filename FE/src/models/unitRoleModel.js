import moment from "moment";
const toJson = (item) => {
    return {
        id: item.id,
        ten: item.ten,
        code : item.code,
        thuTu: item.thuTu,
        moTa: item.moTa
    }
}
const fromJson = (item) => {
    return {
        id: item.id,
        ten: item.ten,
        code : item.code,
        thuTu: item.thuTu,
        createdAt: item.createdAt,
        modifiedAt: item.modifiedAt,
        createdBy: item.createdBy,
        modifiedBy: item.modifiedBy,
        moTa: item.moTa
    }
}

const baseJson = () => {
    return {
        id: null,
        ten: null,
        code : null,
        thuTu: null,
        createdAt: null,
        modifiedAt: null,
        createdBy: null,
        modifiedBy: null,
        moTa: null
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

export const  unitRoleModel = {
    toJson, fromJson, baseJson, toListModel
}
