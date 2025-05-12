using Final_Project_QLKS.Core;
using Final_Project_QLKS.Presenters.Base;
using Final_Project_QLKS.Presenters.Interfaces;
using Final_Project_QLKS.Repositorys.Interfaces;
using Final_Project_QLKS.Services.Interfaces;
using Final_Project_QLKS.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_QLKS.Presenters
{
    public class LoginPresenter : BasePresenter<ILoginView>,ILoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IUserRepository _userRepo;
        private readonly IAuthorizationService _authService;

        public LoginPresenter(ILoginView view, IUserRepository userRepository, IAuthorizationService authService)
            : base(view,authService) // gọi view và auth từ base presenter
        {
            _userRepo = userRepository;   
        }

        public void HandleLogin()
        {
            var user = _userRepo.GetWithRoleAndPermissions(_view.Username);


            if (user != null || user.PasswordHash == _view.Password)
            {
                AppState.CurrentUser = user; // Gán user vào trong AppState
                AppState.Login(user);
                _view.NavigateToDashboard(user);
            }

            else
            {
                ShowMessage("Tên đăng nhập hoặc mật khẩu không đúng");
                return;
            }


            if (!_authService.IsLoggedIn(user))
            {
                ShowMessage("Vui lòng đăng nhập");
            }
            ShowMessage("Đăng nhập thành công.");
        

        }
    }
}
