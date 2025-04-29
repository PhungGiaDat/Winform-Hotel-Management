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
    public class LoginPresenter : ILoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IUserRepository _userRepo;
        private readonly IAuthorizationService _authService;

        public LoginPresenter(ILoginView view, IUserRepository userRepository, IAuthorizationService authService)
        {
            _view = view;
            _userRepo = userRepository;
            _authService = authService;
        }

        public void HandleLogin()
        {
            var user = _userRepo.GetWithRoleAndPermissions(_view.Username);


            if (user == null || user.PasswordHash != _view.Password)
            {
                _view.ShowMessage("Sai tên đăng nhập hoặc mật khẩu");
                return;
            }


            if (!_authService.IsAuthorized(user,"LOGIN"))
            {
                _view.ShowMessage("Bạn không có quyền đăng nhập");
            }

            _view.ShowMessage("Đăng nhập thành công.");
            _view.NavigateToDashboard(user);

        }
    }
}
