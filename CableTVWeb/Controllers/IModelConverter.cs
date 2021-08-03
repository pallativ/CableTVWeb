namespace CableTVWeb.Controllers
{
    public interface IModelConverter<TModel, TEntity>
    {
        TEntity ToEntity(TModel model);
        TModel ToModel(TEntity entity);
    }
}
