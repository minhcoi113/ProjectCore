using DTC.DefaultRepository.Models.Base;
using DTC.T;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Project.Net8.Models.Major
{

    // model dùng cho bài 1
    public class NguoiMuaModel :Audit, TEntity<string>
    {
        public string SoCCCD { get; set; }
        public DateTime? NgayKyHopDong { get; set; }
    }
    public class NguoiMuaModelShort
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }
        public string SoCCCD { get; set; }
        public DateTime? NgayKyHopDong { get; set; }
    }
}
