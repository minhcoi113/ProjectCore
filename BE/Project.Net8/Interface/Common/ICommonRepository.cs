using Project.Net8.FromBodyModels;
using Project.Net8.Models.PagingParam;

namespace Project.Net8.Interface.Common;

public interface ICommonRepository<TEntity, UEntityId>
{
    Task<long> CountAsync();
    Task<TEntity> GetByIdAsync(IdFromBodyCommonModel model);
    Task<TEntity> CreateAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity model);
    Task DeleteAsync(TEntity model);

    Task<dynamic> GetAsync(string collectionName);
    Task<dynamic> GetPagingAsync(CommonPaging param);
}

