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
using Microsoft.AspNetCore.Identity;

namespace Final_Project_QLKS.Presenters
{
    public class LoginPresenter : BasePresenter<ILoginView>,ILoginPresenter
    {

        //private readonly ILoginView _view;
        private readonly IUserRepository _userRepo;
        //private readonly IAuthorizationService _authService;

        public LoginPresenter(ILoginView view, IUserRepository userRepository, IAuthorizationService authService)
            : base(view,authService) // gọi view và auth từ base presenter
        {
            _userRepo = userRepository;   
        }

        public void HandleLogin()
        {
            var hashed = new PasswordHasher<string>();

            if (_view == null)
            {
                ShowMessage("View is not initialized.");
                return;
            }

            if (string.IsNullOrEmpty(_view.Username))
            {
                ShowMessage("Tên đăng nhập không được để trống");
                return;
            }

            var user = _userRepo?.GetWithRoleAndPermissions(_view.Username);
            if (user == null)
            {
                ShowMessage("Tên đăng nhập hoặc mật khẩu không đúng");
                return;
            }

            // Print debug info
            Console.WriteLine($"Username: {_view.Username}");
            Console.WriteLine($"Stored PasswordHash: {user.PasswordHash}");
            Console.WriteLine($"Input Password: {_view.Password}");

            // Correct way to verify password using PasswordHasher
            var result = hashed.VerifyHashedPassword(_view.Username, user.PasswordHash, _view.Password);
            Console.WriteLine($"Password verification result: {result}");

            if (result == PasswordVerificationResult.Failed)
            {
                ShowMessage("Tên đăng nhập hoặc mật khẩu không đúng");
                return;
            }

            AppState.CurrentUser = user;
            AppState.Login(user);
            _view.NavigateToDashboard(user);
            ShowMessage("Đăng nhập thành công.");
        }

    }
}
