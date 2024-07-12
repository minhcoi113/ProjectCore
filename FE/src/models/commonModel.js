const toJson = (item) => {
    return {
        id: item.id,
        code: item.code,
        name: item.name,
        collectionName: item.collectionName
    }
}

const fromJson = (item) => {
    return {
        id: item.id,
        code: item.code,
        name: item.name,
        collectionName: item.collectionName
    }
}

const convertJson = (item, collectionName) => {
    return {
        id: item.id,
        code: item.code,
        name: item.name,
        collectionName: collectionName
    }
}

const baseJson = () => {
    return {
        id: null,
        code: null,
        name: null,
        collectionName: null
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
export const commonModel = {
    toJson, fromJson, baseJson, toListModel , convertJson
}
