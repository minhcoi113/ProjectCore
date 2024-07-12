using DTC.DefaultRepository.Constants;
using DTC.DefaultRepository.Models.Base;
using DTC.T;
using MongoDB.Bson.Serialization.Attributes;
using Project.Net8.Models.Core;
using System.Runtime.CompilerServices;
using CoreModel = DTC.DefaultRepository.Models.Core.CoreModel;

namespace Project.Net8.Models.Major;

public class BaiThiModel: Audit, TEntity<string>
{
    #region bài 1


    //public int DienTich { get; set; }
    // public int GiaTriNen { get; set; } // có thể sửa lại thành string cho dễ xử lý
    //public CommonModelShort TrangThai { get; set;  }
    //public string DiaChi { get; set; }
    //public string GhiChu { get; set; }

    //public NguoiMuaModelShort NguoiMua { get; set; }

    #endregion

    #region bài 2
    //public string TieuDe { get; set; }
    //public string MoTa { get; set; }
    //public FileShortModel File { get; set; }
    //public DateTime? NgayDang { get; set; }
    #endregion

    #region bài 3
    public string MoTaCongViec { get; set; }

    public DateTime? ThoiGianBatDau { get; set; }

    public DateTime? ThoiGianKetThuc { get; set; }

    public ModelShort NguoiGiao { get; set; }

    public List<ModelShort> NguoiThucHien { get; set; }

    public CommonModelShort TrangThai { get; set; }

    public string ParentId { get; set; }

    public List<FileShortModel> Files { get; set; }
    #endregion

    #region Bài 4
    //public string TieuDeTuyenTryuen { get; set; }// có thể bỏ trường này vì có name trong audit rồi 
    //public string MoTaTuyenTruyen { get; set; }
    //public DateTime? NgayBatDauTT { get; set; }
    //public DateTime? NgayHetHan { get; set; }
    //public string TenDonViSuDung { get; set; }
    //public string LichSu { get; set; }
    #endregion

    #region bai 5
    //public string HoLot { get; set; }
    //public string Ten { get; set; }// có thể bỏ vì có trường name trong audit rồi 
    //public string TaiKhoan { get; set; }
    //public string DiaChiKhachHang { get; set; }
    //public DateTime? NgayThamGia { get; set; }
    //public int DiemSo { get; set; }

    #endregion

    #region model cho TheDiem của bài 5
    //public string TenThe { get; set; }// có thể bỏ này vì trong audit đã có rồi
    //public string LoaiThe { get; set; }
    //public int DiemCanTren { get; set; }
    //public int DiemCanDuoi { get; set; }

    #endregion
    #region  bai6
    //public string TenBen { get; set; }//  Có thể bỏ vì có trường name trong audit 
    //public string Loai { get; set; }
    //public string DiaChiBenBai { get; set; }
    //public int GiaTri { get; set; }// có thể thay bằng string cho dễ xử lý
    //public string LichSuDauGia { get; set; }
    //public string TenDonViChuQuan { get; set; }
    #endregion

    #region model lichsudaugia cua bai 6
    //public DateTime? NgayDauGia { get; set; }
    //public int GiaTriBenBai { get; set; }//  có thể thay bằng string 
    //public DateTime? NgayBatDau { get; set; }
    //public DateTime? NgayKetThuc { get; set; }
    //public string TenDonViSuDung1 { get; set; }// khi nào có dùng thì bỏ số 1 ở sau đi
    #endregion

}

public class ModelShort
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string Id { get; set; }
    public string Name { get; set; }
}

