using MongoDB.Driver;
using Project.Net8.Models.Core;

namespace Project.Net8.Constants;

public class Projection
{

    public static ProjectionDefinition<CommonModel> Projection_BasicCommon = Builders<CommonModel>.Projection
        .Include(x=>x.Id)
        .Include(x=>x.Code)
        .Include(x =>x.Name);
}