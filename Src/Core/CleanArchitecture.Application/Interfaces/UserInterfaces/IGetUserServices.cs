using System.Threading.Tasks;
using CleanArchitecture.Application.DTOs.Account.Requests;
using CleanArchitecture.Application.DTOs.Account.Responses;
using CleanArchitecture.Application.Wrappers;

namespace CleanArchitecture.Application.Interfaces.UserInterfaces
{
    public interface IGetUserServices
    {
        Task<PagedResponse<UserDto>> GetPagedUsers(GetAllUsersRequest model);
    }
}
