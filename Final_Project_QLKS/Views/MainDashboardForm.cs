using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public partial class MainDashboardForm : Form
{
    private Panel navPanel;
    private Label lblTitle;
    private Button btnBranchManagement;
    private Button btnRoomManagement;
    private Button btnBooking;
    private Button btnCustomerManagement;
    private Button btnServiceOrder;
    private Button btnReport;
    private Button btnRoleManagement;
    private Button btnLogout;
    private Panel summaryPanel;
    private Label lblAvailableRooms;
    private Label lblBookingsToday;

    // Giả lập vai trò người dùng (Admin, Receptionist, Customer)
    private string userRole = "Admin"; // Thay đổi giá trị này dựa trên đăng nhập thực tế

    public MainDashboardForm(string role)
    {
        userRole = role;
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        navPanel = new Panel();
        btnLogout = new Button();
        btnRoleManagement = new Button();
        btnReport = new Button();
        btnServiceOrder = new Button();
        btnCustomerManagement = new Button();
        btnBooking = new Button();
        btnRoomManagement = new Button();
        btnBranchManagement = new Button();
        lblTitle = new Label();
        summaryPanel = new Panel();
        lblBookingsToday = new Label();
        lblAvailableRooms = new Label();
        navPanel.SuspendLayout();
        summaryPanel.SuspendLayout();
        SuspendLayout();
        // 
        // navPanel
        // 
        navPanel.BackColor = Color.FromArgb(25, 118, 210);
        navPanel.Controls.Add(btnLogout);
        navPanel.Controls.Add(btnRoleManagement);
        navPanel.Controls.Add(btnReport);
        navPanel.Controls.Add(btnServiceOrder);
        navPanel.Controls.Add(btnCustomerManagement);
        navPanel.Controls.Add(btnBooking);
        navPanel.Controls.Add(btnRoomManagement);
        navPanel.Controls.Add(btnBranchManagement);
        navPanel.Controls.Add(lblTitle);
        navPanel.Location = new Point(0, 0);
        navPanel.Margin = new Padding(5, 6, 5, 6);
        navPanel.Name = "navPanel";
        navPanel.Size = new Size(325, 1058);
        navPanel.TabIndex = 0;
        // 
        // btnLogout
        // 
        btnLogout.BackColor = Color.FromArgb(239, 83, 80);
        btnLogout.FlatAppearance.BorderSize = 0;
        btnLogout.FlatStyle = FlatStyle.Flat;
        btnLogout.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnLogout.ForeColor = Color.White;
        btnLogout.Location = new Point(16, 900);
        btnLogout.Margin = new Padding(5, 6, 5, 6);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(292, 80);
        btnLogout.TabIndex = 8;
        btnLogout.Text = "Logout";
        btnLogout.UseVisualStyleBackColor = false;
        // 
        // btnRoleManagement
        // 
        btnRoleManagement.BackColor = Color.FromArgb(255, 152, 0);
        btnRoleManagement.FlatAppearance.BorderSize = 0;
        btnRoleManagement.FlatStyle = FlatStyle.Flat;
        btnRoleManagement.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnRoleManagement.ForeColor = Color.White;
        btnRoleManagement.Location = new Point(16, 700);
        btnRoleManagement.Margin = new Padding(5, 6, 5, 6);
        btnRoleManagement.Name = "btnRoleManagement";
        btnRoleManagement.Size = new Size(292, 80);
        btnRoleManagement.TabIndex = 7;
        btnRoleManagement.Text = "Role Management";
        btnRoleManagement.UseVisualStyleBackColor = false;
        // 
        // btnReport
        // 
        btnReport.BackColor = Color.FromArgb(255, 152, 0);
        btnReport.FlatAppearance.BorderSize = 0;
        btnReport.FlatStyle = FlatStyle.Flat;
        btnReport.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnReport.ForeColor = Color.White;
        btnReport.Location = new Point(16, 600);
        btnReport.Margin = new Padding(5, 6, 5, 6);
        btnReport.Name = "btnReport";
        btnReport.Size = new Size(292, 80);
        btnReport.TabIndex = 6;
        btnReport.Text = "Report";
        btnReport.UseVisualStyleBackColor = false;
        // 
        // btnServiceOrder
        // 
        btnServiceOrder.BackColor = Color.FromArgb(255, 152, 0);
        btnServiceOrder.FlatAppearance.BorderSize = 0;
        btnServiceOrder.FlatStyle = FlatStyle.Flat;
        btnServiceOrder.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnServiceOrder.ForeColor = Color.White;
        btnServiceOrder.Location = new Point(16, 500);
        btnServiceOrder.Margin = new Padding(5, 6, 5, 6);
        btnServiceOrder.Name = "btnServiceOrder";
        btnServiceOrder.Size = new Size(292, 80);
        btnServiceOrder.TabIndex = 5;
        btnServiceOrder.Text = "Service Order";
        btnServiceOrder.UseVisualStyleBackColor = false;
        // 
        // btnCustomerManagement
        // 
        btnCustomerManagement.BackColor = Color.FromArgb(255, 152, 0);
        btnCustomerManagement.FlatAppearance.BorderSize = 0;
        btnCustomerManagement.FlatStyle = FlatStyle.Flat;
        btnCustomerManagement.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnCustomerManagement.ForeColor = Color.White;
        btnCustomerManagement.Location = new Point(16, 400);
        btnCustomerManagement.Margin = new Padding(5, 6, 5, 6);
        btnCustomerManagement.Name = "btnCustomerManagement";
        btnCustomerManagement.Size = new Size(292, 80);
        btnCustomerManagement.TabIndex = 4;
        btnCustomerManagement.Text = "Customer Management";
        btnCustomerManagement.UseVisualStyleBackColor = false;
        // 
        // btnBooking
        // 
        btnBooking.BackColor = Color.FromArgb(255, 152, 0);
        btnBooking.FlatAppearance.BorderSize = 0;
        btnBooking.FlatStyle = FlatStyle.Flat;
        btnBooking.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBooking.ForeColor = Color.White;
        btnBooking.Location = new Point(16, 300);
        btnBooking.Margin = new Padding(5, 6, 5, 6);
        btnBooking.Name = "btnBooking";
        btnBooking.Size = new Size(292, 80);
        btnBooking.TabIndex = 3;
        btnBooking.Text = "Booking";
        btnBooking.UseVisualStyleBackColor = false;
        // 
        // btnRoomManagement
        // 
        btnRoomManagement.BackColor = Color.FromArgb(255, 152, 0);
        btnRoomManagement.FlatAppearance.BorderSize = 0;
        btnRoomManagement.FlatStyle = FlatStyle.Flat;
        btnRoomManagement.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnRoomManagement.ForeColor = Color.White;
        btnRoomManagement.Location = new Point(16, 200);
        btnRoomManagement.Margin = new Padding(5, 6, 5, 6);
        btnRoomManagement.Name = "btnRoomManagement";
        btnRoomManagement.Size = new Size(292, 80);
        btnRoomManagement.TabIndex = 2;
        btnRoomManagement.Text = "Room Management";
        btnRoomManagement.UseVisualStyleBackColor = false;
        // 
        // btnBranchManagement
        // 
        btnBranchManagement.BackColor = Color.FromArgb(255, 152, 0);
        btnBranchManagement.FlatAppearance.BorderSize = 0;
        btnBranchManagement.FlatStyle = FlatStyle.Flat;
        btnBranchManagement.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBranchManagement.ForeColor = Color.White;
        btnBranchManagement.Location = new Point(16, 100);
        btnBranchManagement.Margin = new Padding(5, 6, 5, 6);
        btnBranchManagement.Name = "btnBranchManagement";
        btnBranchManagement.Size = new Size(292, 80);
        btnBranchManagement.TabIndex = 1;
        btnBranchManagement.Text = "Branch Management";
        btnBranchManagement.UseVisualStyleBackColor = false;
        // 
        // lblTitle
        // 
        lblTitle.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(16, 20);
        lblTitle.Margin = new Padding(5, 0, 5, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(292, 60);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Dashboard";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // summaryPanel
        // 
        summaryPanel.BackColor = Color.White;
        summaryPanel.BorderStyle = BorderStyle.FixedSingle;
        summaryPanel.Controls.Add(lblBookingsToday);
        summaryPanel.Controls.Add(lblAvailableRooms);
        summaryPanel.Location = new Point(406, 100);
        summaryPanel.Margin = new Padding(5, 6, 5, 6);
        summaryPanel.Name = "summaryPanel";
        summaryPanel.Size = new Size(974, 298);
        summaryPanel.TabIndex = 1;
        // 
        // lblBookingsToday
        // 
        lblBookingsToday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblBookingsToday.ForeColor = Color.FromArgb(33, 33, 33);
        lblBookingsToday.Location = new Point(32, 160);
        lblBookingsToday.Margin = new Padding(5, 0, 5, 0);
        lblBookingsToday.Name = "lblBookingsToday";
        lblBookingsToday.Size = new Size(910, 60);
        lblBookingsToday.TabIndex = 1;
        lblBookingsToday.Text = "Bookings Today: 5";
        // 
        // lblAvailableRooms
        // 
        lblAvailableRooms.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblAvailableRooms.ForeColor = Color.FromArgb(33, 33, 33);
        lblAvailableRooms.Location = new Point(32, 60);
        lblAvailableRooms.Margin = new Padding(5, 0, 5, 0);
        lblAvailableRooms.Name = "lblAvailableRooms";
        lblAvailableRooms.Size = new Size(910, 60);
        lblAvailableRooms.TabIndex = 0;
        lblAvailableRooms.Text = "Available Rooms: 10";
        // 
        // MainDashboardForm
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(2005, 1046);
        Controls.Add(summaryPanel);
        Controls.Add(navPanel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5, 6, 5, 6);
        MaximizeBox = false;
        Name = "MainDashboardForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Hotel Management - Dashboard";
        Load += MainDashboardForm_Load;
        Resize += MainDashboardForm_Resize;
        navPanel.ResumeLayout(false);
        summaryPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    private void MainDashboardForm_Load(object sender, EventArgs e)
    {
        // Thêm hiệu ứng và gradient
        this.BackgroundImage = CreateGradientBackground();

        // Thêm hiệu ứng hover cho các nút
        AddHoverEffect(btnBranchManagement);
        AddHoverEffect(btnRoomManagement);
        AddHoverEffect(btnBooking);
        AddHoverEffect(btnCustomerManagement);
        AddHoverEffect(btnServiceOrder);
        AddHoverEffect(btnReport);
        AddHoverEffect(btnRoleManagement);
        AddHoverEffect(btnLogout, "#EF5350", "#E53935");

        // Cập nhật tóm tắt (dữ liệu giả lập)
        UpdateSummary();

        // Sự kiện Click cho các nút
        btnRoomManagement.Click += (s, e) =>
        {
            this.Hide();
            RoomManagementForm roomManagement = new RoomManagementForm(userRole);
            roomManagement.ShowDialog();
            this.Close();
        };

        btnBooking.Click += (s, e) =>
        {
            this.Hide();
            BookingForm booking = new BookingForm(userRole);
            booking.ShowDialog();
            this.Close();
        };

        //btnReport.Click += (s, e) =>
        //{
        //    this.Hide();
        //    ReportForm report = new ReportForm(userRole);
        //    report.ShowDialog();
        //    this.Close();
        //};

        btnServiceOrder.Click += (s, e) =>
        {
            this.Hide();
            ServiceOrderForm serviceOrder = new ServiceOrderForm(userRole);
            serviceOrder.ShowDialog();
            this.Close();
        };

        btnLogout.Click += (s, e) =>
        {
            this.Close();
        };
    }

    private void MainDashboardForm_Resize(object sender, EventArgs e)
    {
        UpdateGradientBackground();
        navPanel.Height = this.ClientSize.Height;
        btnLogout.Location = new Point(10, this.ClientSize.Height - 80);
        summaryPanel.Location = new Point(250, 50);
    }

    private void UpdateSummary()
    {
        // Dữ liệu giả lập - thay bằng dữ liệu thực từ database
        lblAvailableRooms.Text = "Available Rooms: 10";
        lblBookingsToday.Text = "Bookings Today: 5";
    }

    private void AddHoverEffect(Button button, string baseColor = "#FF9800", string hoverColor = "#F57C00")
    {
        button.MouseEnter += (s, e) => button.BackColor = ColorTranslator.FromHtml(hoverColor);
        button.MouseLeave += (s, e) => button.BackColor = ColorTranslator.FromHtml(baseColor);
    }

    private Bitmap CreateGradientBackground()
    {
        Bitmap bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
        using (Graphics g = Graphics.FromImage(bitmap))
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(0, this.ClientSize.Height),
                ColorTranslator.FromHtml("#E3F2FD"),
                ColorTranslator.FromHtml("#FFFFFF")))
            {
                g.FillRectangle(brush, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
            }
        }
        return bitmap;
    }

    private void UpdateGradientBackground()
    {
        if (this.BackgroundImage != null)
        {
            this.BackgroundImage.Dispose();
        }
        this.BackgroundImage = CreateGradientBackground();
    }
}