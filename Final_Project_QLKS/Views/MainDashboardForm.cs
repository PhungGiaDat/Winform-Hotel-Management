using HotelManagementSystem.Views;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public partial class MainDashboardForm : Form
{
    private Panel navPanel;
    private Label lblTitle;
    private Button btnBranchManagement;
    private Button btnCustomerManagement;
    private Button btnReport;
    private Button btnRoleManagement;
    private Button btnServiceManagement;
    private Button btnLogout;
    private Panel summaryPanel;
    private Label lblAvailableRooms;
    private Label lblBookingsToday;

    // Simulated user role (should be set based on actual login)
    private string userRole = "Admin"; // Change this based on actual login

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
        btnServiceManagement = new Button();
        btnCustomerManagement = new Button();
        btnBranchManagement = new Button();
        lblTitle = new Label();
        summaryPanel = new Panel();
        lblBookingsToday = new Label();
        lblAvailableRooms = new Label();

        navPanel.SuspendLayout();
        summaryPanel.SuspendLayout();
        SuspendLayout();

        // navPanel
        navPanel.BackColor = Color.FromArgb(25, 118, 210);
        navPanel.Controls.Add(btnLogout);
        navPanel.Controls.Add(btnRoleManagement);
        navPanel.Controls.Add(btnReport);
        navPanel.Controls.Add(btnServiceManagement);
        navPanel.Controls.Add(btnCustomerManagement);
        navPanel.Controls.Add(btnBranchManagement);
        navPanel.Controls.Add(lblTitle);
        navPanel.Location = new Point(0, 0);
        navPanel.Margin = new Padding(5, 6, 5, 6);
        navPanel.Name = "navPanel";
        navPanel.Size = new Size(325, 1058);
        navPanel.TabIndex = 0;

        // btnLogout
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

        // btnRoleManagement (Quản lý nhân viên)
        btnRoleManagement.BackColor = Color.FromArgb(255, 152, 0);
        btnRoleManagement.FlatAppearance.BorderSize = 0;
        btnRoleManagement.FlatStyle = FlatStyle.Flat;
        btnRoleManagement.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnRoleManagement.ForeColor = Color.White;
        btnRoleManagement.Location = new Point(16, 500);
        btnRoleManagement.Margin = new Padding(5, 6, 5, 6);
        btnRoleManagement.Name = "btnRoleManagement";
        btnRoleManagement.Size = new Size(292, 80);
        btnRoleManagement.TabIndex = 7;
        btnRoleManagement.Text = "Quản lý nhân viên";
        btnRoleManagement.UseVisualStyleBackColor = false;

        // btnReport
        btnReport.BackColor = Color.FromArgb(255, 152, 0);
        btnReport.FlatAppearance.BorderSize = 0;
        btnReport.FlatStyle = FlatStyle.Flat;
        btnReport.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnReport.ForeColor = Color.White;
        btnReport.Location = new Point(16, 400);
        btnReport.Margin = new Padding(5, 6, 5, 6);
        btnReport.Name = "btnReport";
        btnReport.Size = new Size(292, 80);
        btnReport.TabIndex = 6;
        btnReport.Text = "Báo cáo";
        btnReport.UseVisualStyleBackColor = false;

        // btnServiceManagement (Quản lý dịch vụ)
        btnServiceManagement.BackColor = Color.FromArgb(255, 152, 0);
        btnServiceManagement.FlatAppearance.BorderSize = 0;
        btnServiceManagement.FlatStyle = FlatStyle.Flat;
        btnServiceManagement.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnServiceManagement.ForeColor = Color.White;
        btnServiceManagement.Location = new Point(16, 600);
        btnServiceManagement.Margin = new Padding(5, 6, 5, 6);
        btnServiceManagement.Name = "btnServiceManagement";
        btnServiceManagement.Size = new Size(292, 80);
        btnServiceManagement.TabIndex = 9;
        btnServiceManagement.Text = "Quản lý dịch vụ";
        btnServiceManagement.UseVisualStyleBackColor = false;

        // btnCustomerManagement
        btnCustomerManagement.BackColor = Color.FromArgb(255, 152, 0);
        btnCustomerManagement.FlatAppearance.BorderSize = 0;
        btnCustomerManagement.FlatStyle = FlatStyle.Flat;
        btnCustomerManagement.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnCustomerManagement.ForeColor = Color.White;
        btnCustomerManagement.Location = new Point(16, 300);
        btnCustomerManagement.Margin = new Padding(5, 6, 5, 6);
        btnCustomerManagement.Name = "btnCustomerManagement";
        btnCustomerManagement.Size = new Size(292, 80);
        btnCustomerManagement.TabIndex = 4;
        btnCustomerManagement.Text = "Quản lý khách hàng";
        btnCustomerManagement.UseVisualStyleBackColor = false;

        // btnBranchManagement
        btnBranchManagement.BackColor = Color.FromArgb(255, 152, 0);
        btnBranchManagement.FlatAppearance.BorderSize = 0;
        btnBranchManagement.FlatStyle = FlatStyle.Flat;
        btnBranchManagement.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBranchManagement.ForeColor = Color.White;
        btnBranchManagement.Location = new Point(16, 200);
        btnBranchManagement.Margin = new Padding(5, 6, 5, 6);
        btnBranchManagement.Name = "btnBranchManagement";
        btnBranchManagement.Size = new Size(292, 80);
        btnBranchManagement.TabIndex = 1;
        btnBranchManagement.Text = "Quản lý chi nhánh";
        btnBranchManagement.UseVisualStyleBackColor = false;

        // lblTitle
        lblTitle.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(16, 20);
        lblTitle.Margin = new Padding(5, 0, 5, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(292, 60);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Dashboard";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;

        // summaryPanel
        summaryPanel.BackColor = Color.White;
        summaryPanel.BorderStyle = BorderStyle.FixedSingle;
        summaryPanel.Controls.Add(lblBookingsToday);
        summaryPanel.Controls.Add(lblAvailableRooms);
        summaryPanel.Location = new Point(406, 100);
        summaryPanel.Margin = new Padding(5, 6, 5, 6);
        summaryPanel.Name = "summaryPanel";
        summaryPanel.Size = new Size(974, 298);
        summaryPanel.TabIndex = 1;

        // lblBookingsToday
        lblBookingsToday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblBookingsToday.ForeColor = Color.FromArgb(33, 33, 33);
        lblBookingsToday.Location = new Point(32, 160);
        lblBookingsToday.Margin = new Padding(5, 0, 5, 0);
        lblBookingsToday.Name = "lblBookingsToday";
        lblBookingsToday.Size = new Size(910, 60);
        lblBookingsToday.TabIndex = 1;
        lblBookingsToday.Text = "Bookings Today: 5";

        // lblAvailableRooms
        lblAvailableRooms.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblAvailableRooms.ForeColor = Color.FromArgb(33, 33, 33);
        lblAvailableRooms.Location = new Point(32, 60);
        lblAvailableRooms.Margin = new Padding(5, 0, 5, 0);
        lblAvailableRooms.Name = "lblAvailableRooms";
        lblAvailableRooms.Size = new Size(910, 60);
        lblAvailableRooms.TabIndex = 0;
        lblAvailableRooms.Text = "Available Rooms: 10";

        // MainDashboardForm
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
        // Gradient background
        this.BackgroundImage = CreateGradientBackground();

        // Hover effects
        AddHoverEffect(btnBranchManagement);
        AddHoverEffect(btnCustomerManagement);
        AddHoverEffect(btnReport);
        AddHoverEffect(btnRoleManagement);
        AddHoverEffect(btnServiceManagement);
        AddHoverEffect(btnLogout, "#EF5350", "#E53935");

        // Update summary (mock data)
        UpdateSummary();

        // Button click events (replace with your actual form classes)
        btnBranchManagement.Click += (s, e) =>
        {
            this.Hide();
            using (var form = new BranchManagementForm())
            {
                form.ShowDialog();
            }
            this.Show();
        };
        btnCustomerManagement.Click += (s, e) =>
        {
            this.Hide();
            using (var form = new CustomerForm())
            {
                form.ShowDialog();
            }
            this.Show();
        };
        btnReport.Click += (s, e) =>
        {
            this.Hide();
            using (var form = new ReportForm())
            {
                form.ShowDialog();
            }
            this.Show();
        };
        btnRoleManagement.Click += (s, e) =>
        {
            this.Hide();
            using (var form = new ManagementForm())
            {
                form.ShowDialog();
            }
            this.Show();
        };
        btnServiceManagement.Click += (s, e) =>
        {
            this.Hide();
            using (var form = new ServiceManagementForm(userRole))
            {
                form.ShowDialog();
            }
            this.Show();
        };
        btnLogout.Click += (s, e) => { this.Close(); };

        // Hide all by default, show only for Manager with permission
        ConfigureButtonsByRole();
    }

    private void ConfigureButtonsByRole()
    {
        // Hide all management buttons by default
        btnBranchManagement.Visible = false;
        btnCustomerManagement.Visible = false;
        btnReport.Visible = false;
        btnRoleManagement.Visible = false;
        btnServiceManagement.Visible = false;

        // Example: Only show for Manager role (replace with your permission logic)
        if (userRole == "Manager")
        {
            btnBranchManagement.Visible = true;
            btnCustomerManagement.Visible = true;
            btnReport.Visible = true;
            btnRoleManagement.Visible = true;
            btnServiceManagement.Visible = true;
        }
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
        // Mock data - replace with real data from database
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
        if (this.ClientSize.Width <= 0 || this.ClientSize.Height <= 0)
            return null;
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
