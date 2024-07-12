using MongoDB.Bson.Serialization.Attributes;

namespace Project.Net8.Models.PagingParam
{
    public class PagingParam
    {
        public int Start { get; set; } = 1;
        public int Limit { get; set; } = 10;
        

        public string? SortBy { get; set; }
        
        public bool SortDesc { get; set; }
        public string? Content { get; set; }
        public int? Level { get; set; } = null;
        
        
        
        public string? IdDonViCha { get; set; } = null;
        

        public int Skip
        {
            get
            {
                return (Start > 0 ? Start - 1 : 0) * Limit;
            }
        }
    }


    public class PagingParamDefault  : PagingParam
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? MenuId { get; set; } = null;

        public bool Date { get; set; }

        public bool UserTake { get; set; }

        public string? TrangThai { get; set; }
    }

    public class PagingParamFile : PagingParam
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? KhuCumId { get; set; } = null;
        
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? DuAnId { get; set; } = null;
        
        
        
    }

    
    

    public class PagingModel<T>
    {
        public long TotalRows { get; set; }
        
        public IEnumerable<T> Data { get; set; }
    }


    
    
    
}