using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public partial class LoginForm : Form
{
    private Panel loginPanel;
    private Label lblLogo;
    private Label lblUsername;
    private TextBox txtUsername;
    private Label lblPassword;
    private TextBox txtPassword;
    private Button btnLogin;
    private Label lblForgotPassword;

    public LoginForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        loginPanel = new Panel();
        lblForgotPassword = new Label();
        btnLogin = new Button();
        txtPassword = new TextBox();
        lblPassword = new Label();
        txtUsername = new TextBox();
        lblUsername = new Label();
        lblLogo = new Label();
        loginPanel.SuspendLayout();
        SuspendLayout();
        // 
        // loginPanel
        // 
        loginPanel.BackColor = Color.White;
        loginPanel.BorderStyle = BorderStyle.FixedSingle;
        loginPanel.Controls.Add(lblForgotPassword);
        loginPanel.Controls.Add(btnLogin);
        loginPanel.Controls.Add(txtPassword);
        loginPanel.Controls.Add(lblPassword);
        loginPanel.Controls.Add(txtUsername);
        loginPanel.Controls.Add(lblUsername);
        loginPanel.Controls.Add(lblLogo);
        loginPanel.Location = new Point(333, 101);
        loginPanel.Name = "loginPanel";
        loginPanel.Size = new Size(385, 451);
        loginPanel.TabIndex = 0;
        // 
        // lblForgotPassword
        // 
        lblForgotPassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblForgotPassword.ForeColor = Color.FromArgb(25, 118, 210);
        lblForgotPassword.Location = new Point(50, 374);
        lblForgotPassword.Name = "lblForgotPassword";
        lblForgotPassword.Size = new Size(263, 50);
        lblForgotPassword.TabIndex = 6;
        lblForgotPassword.Text = "Forgot Password?";
        lblForgotPassword.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = Color.FromArgb(25, 118, 210);
        btnLogin.FlatAppearance.BorderSize = 0;
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnLogin.ForeColor = Color.White;
        btnLogin.Location = new Point(50, 292);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(250, 63);
        btnLogin.TabIndex = 5;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = false;
        // 
        // txtPassword
        // 
        txtPassword.BackColor = Color.White;
        txtPassword.BorderStyle = BorderStyle.FixedSingle;
        txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtPassword.ForeColor = Color.FromArgb(33, 33, 33);
        txtPassword.Location = new Point(50, 221);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(250, 47);
        txtPassword.TabIndex = 4;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // lblPassword
        // 
        lblPassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblPassword.ForeColor = Color.FromArgb(33, 33, 33);
        lblPassword.Location = new Point(50, 175);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(144, 43);
        lblPassword.TabIndex = 3;
        lblPassword.Text = "Password";
        lblPassword.Click += lblPassword_Click;
        // 
        // txtUsername
        // 
        txtUsername.BackColor = Color.White;
        txtUsername.BorderStyle = BorderStyle.FixedSingle;
        txtUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtUsername.ForeColor = Color.FromArgb(33, 33, 33);
        txtUsername.Location = new Point(50, 125);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(250, 47);
        txtUsername.TabIndex = 2;
        // 
        // lblUsername
        // 
        lblUsername.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblUsername.ForeColor = Color.FromArgb(33, 33, 33);
        lblUsername.Location = new Point(50, 82);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(168, 36);
        lblUsername.TabIndex = 1;
        lblUsername.Text = "Username";
        lblUsername.Click += lblUsername_Click;
        // 
        // lblLogo
        // 
        lblLogo.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblLogo.ForeColor = Color.FromArgb(25, 118, 210);
        lblLogo.Location = new Point(63, 30);
        lblLogo.Name = "lblLogo";
        lblLogo.Size = new Size(250, 52);
        lblLogo.TabIndex = 0;
        lblLogo.Text = "Hotel Management";
        lblLogo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(14F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1066, 699);
        Controls.Add(loginPanel);
        Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Hotel Management - Login";
        Load += LoginForm_Load;
        Resize += LoginForm_Resize;
        loginPanel.ResumeLayout(false);
        loginPanel.PerformLayout();
        ResumeLayout(false);
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        // Thêm hiệu ứng và gradient
        this.BackgroundImage = CreateGradientBackground();

        // Tùy chỉnh panel
        loginPanel.Paint += (s, e) =>
        {
            using (var pen = new Pen(ColorTranslator.FromHtml("#B0BEC5"), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, loginPanel.Width - 1, loginPanel.Height - 1);
            }
        };

        // Thêm hiệu ứng hover cho nút Login
        btnLogin.MouseEnter += (s, e) => btnLogin.BackColor = ColorTranslator.FromHtml("#1565C0");
        btnLogin.MouseLeave += (s, e) => btnLogin.BackColor = ColorTranslator.FromHtml("#1976D2");

        // Đặt cursor cho Forgot Password
        lblForgotPassword.Cursor = Cursors.Hand;
    }

    private void LoginForm_Resize(object sender, EventArgs e)
    {
        UpdateGradientBackground();
        loginPanel.Location = new Point((this.ClientSize.Width - loginPanel.Width) / 2, (this.ClientSize.Height - loginPanel.Height) / 2);
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

    private void lblUsername_Click(object sender, EventArgs e)
    {

    }

    private void lblPassword_Click(object sender, EventArgs e)
    {

    }
}