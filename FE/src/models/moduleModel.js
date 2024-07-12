import moment from 'moment';

const toJson = (item) => {
    return {
        id: item.id,
        name: item.name,
        sort: item.sort,
        permissions: item.permissions,
    }
}

const fromJson = (item) => {
    return {
        id: item.id,
        name: item.name,
        sort: item.sort,
        permissions: item.permissions,
        createdAt:item.createdAt,
        modifiedAt: item.modifiedAt,
        createdBy:item.createdBy,
        modifiedBy: item.modifiedBy,
        isDeleted: item.isDeleted,
    }
}
// const convernJson = (item) => {
//     return {
//         id: item.id,
//         name: item.name,
//         sort: item.sort,
//         permissions: item.permissions,
//         createdAt:item.createdAt,
//         modifiedAt: item.modifiedAt,
//         createdBy:item.createdBy,
//         modifiedBy: item.modifiedBy,
//         isDeleted: item.isDeleted,
//         selected : false
//     }
// }

const baseJson = () => {
    return {
        id: null,
        name: null,
        sort: 0,
        permissions: null,
        isDeleted: false,
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


export const moduleModel = {
    toJson, fromJson, baseJson, toListModel
}
