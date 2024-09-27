using Entities.DTOs;
using Entities.Models;
namespace DataAccess.Interfaces;

public interface IDalDtoProductCatName : IEntityRepo<Product>
{
    IQueryable<DtoProductCatName> GetProductsCatName();
    public IQueryable<DtoProductCatName> GetProductsCatName(int id = 0);
    IQueryable<Product> GetProductsByCategory(int catID);

}