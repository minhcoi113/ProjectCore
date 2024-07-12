import moment from "moment";
const toJson = (item) => {
    return {
        id: item.id,
        name: item.name,
        trangThai: item.trangThai,
        moTaCongViec: item.moTaCongViec,
        thoiGianBatDau: moment(item.thoiGianBatDau).format("yyyy-MM-DD"),
        thoiGianKetThuc: moment(item.thoiGianKetThuc).format("yyyy-MM-DD"),
        nguoiGiao: item.nguoiGiao,
        nguoiThucHien: item.nguoiThucHien,
        parentId: item.parentId,
        files: item.files
    }
}

const fromJson = (item) => {
    return {
        id: item.id,
        name: item.name,
        trangThai : item.trangThai,
        moTaCongViec: item.moTaCongViec,
        thoiGianBatDau: moment(item.thoiGianBatDau).format("yyyy-MM-DD"),
        thoiGianKetThuc: moment(item.thoiGianKetThuc).format("yyyy-MM-DD"),
        nguoiGiao: item.nguoiGiao,
        nguoiThucHien: item.nguoiThucHien,
        parentId: item.parentId,
        files: item.files
    }
}

const baseJson = () => {
    return {
        id: null,
        name: null,
        trangThai : null,
        moTaCongViec: null,
        thoiGianBatDau: null,
        thoiGianKetThuc: null,
        nguoiGiao: null,
        nguoiThucHien: null,
        parentId: null,
        files:[],
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
export const baiThi3Model = {
    toJson, fromJson, baseJson, toListModel
}
