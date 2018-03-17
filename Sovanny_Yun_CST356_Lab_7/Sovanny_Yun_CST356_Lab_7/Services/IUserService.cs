using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sovanny_Yun_CST356_Lab7.Models.View;
using Sovanny_Yun_CST356_Lab7.Data.Entities;

namespace Sovanny_Yun_CST356_Lab7.Services
{
    public interface IUserService
    {
        IEnumerable<UserViewModel> GetAllUsers();
        bool Create(UserViewModel userViewModel);
        UserViewModel GetUser(int id);
        bool Edit(UserViewModel userViewModel);
        bool DeleteUser(int id);
    }
}
