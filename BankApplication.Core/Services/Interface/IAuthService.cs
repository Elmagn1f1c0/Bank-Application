using BankApplication.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Core.Services.Interface
{
    public interface IAuthService
    {
        string GenerateTokenString(LoginUser user);
        //Task<bool> RegisterUser(RegisterUser user);
        Task<ResponseDto<bool>> RegisterUser(RegisterUser user);
        //Task<bool> Login(LoginUser user);
        Task<ResponseDto<bool>> Login(LoginUser user);
    }
}
