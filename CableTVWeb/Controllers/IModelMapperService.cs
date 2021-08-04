namespace CableTVWeb.Controllers
{
    public interface IModelMapperService<TModel, TEntity>
    {
        TEntity ToEntity(TModel model);
        TModel ToModel(TEntity entity);
    }
}
