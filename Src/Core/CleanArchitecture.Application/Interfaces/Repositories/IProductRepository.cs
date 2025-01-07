using System.Threading.Tasks;
using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Domain.Products.DTOs;
using CleanArchitecture.Domain.Products.Entities;

namespace CleanArchitecture.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
