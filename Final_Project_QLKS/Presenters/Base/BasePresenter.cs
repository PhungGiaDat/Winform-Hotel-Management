using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project_QLKS.Core;
using Final_Project_QLKS.Models;
using Final_Project_QLKS.Services.Interfaces;
using Final_Project_QLKS.Views.Interfaces;

namespace Final_Project_QLKS.Presenters.Base
{
    public abstract class BasePresenter<TView> where TView :IBaseView
    {
        protected readonly TView _view;
        protected readonly IAuthorizationService _authService;

        protected BasePresenter(TView view, IAuthorizationService authService)
        {
            _view = view;
            _authService = authService;
        }

        /// <summary>
        /// User hiện tại trong phiên làm việc
        /// </summary>
        protected User? CurrentUser => AppState.CurrentUser;

        /// <summary>
        /// Kiểm tra đã login chưa
        /// </summary>
        protected bool IsLoggedIn => AppState.IsLoggedIn;

        /// <summary>
        /// Check quyền theo PermissionKey (dùng constants)
        /// </summary>
        protected bool HasPermission(string permissionKey)
        {
            return CurrentUser != null && _authService.HasPermission(CurrentUser, permissionKey);
        }

        /// <summary>
        /// Đăng xuất user
        /// </summary>
        protected void Logout()
        {
            AppState.Logout();
        }

        protected void ShowMessage(string msg)
        {
            _view.ShowMessage(msg);
        }

        /// <summary>
        /// Check vai trò
        /// </summary>
        protected bool IsAdmin => AppState.IsAdmin;
        protected bool IsManager => AppState.IsManager;
        protected bool IsUser => AppState.IsUser;
    }
}

