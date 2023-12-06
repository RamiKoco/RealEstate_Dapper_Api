using RealEstate_Dapper_Api.Dtos.ProductDtos;

namespace RealEstate_Dapper_Api.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
        void ProductDealOfTheDayStatusChangeToTrue(int id);
        void ProductDealOfTheDayStatusChangeToFalse(int id);
<<<<<<< HEAD
        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync();
=======
        Task<List<ResultProductDto>> GetLast5ProductAsync();
>>>>>>> e19b9c73fae3a616f8c70e3563c3b8a4bf7ad627
    }
}