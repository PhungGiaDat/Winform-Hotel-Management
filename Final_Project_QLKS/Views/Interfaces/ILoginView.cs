using Final_Project_QLKS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_QLKS.Views.Interfaces
{
    public interface ILoginView : IBaseView
    {
        string Username { get; }
        string Password { get; }
        void NavigateToDashboard(User user);

    }
}
