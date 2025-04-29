using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_QLKS.Presenters.Interfaces
{
    public interface ISessionPresenter
    {
        void ShowLoginForm();
        void ShowMainForm();
        void ShowUserManagementForm();
        void ShowRoomManagementForm();
        void ShowBookingManagementForm();
        void ShowServiceManagementForm();
        void ShowReportForm();
        void ShowCustomerManagementForm();
        void ShowStaffManagementForm();
        void ShowPermissionManagementForm();
        void ShowRoleManagementForm();
        void ShowAuthorizationForm();
        void Logout();
    }
}
