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

export const sectionModel = {
  toJson, fromJson, baseJson, toListModel
}