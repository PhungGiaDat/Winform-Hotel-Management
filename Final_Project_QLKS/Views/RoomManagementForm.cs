using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public partial class RoomManagementForm : Form
{
    private string userRole;
    private Panel navPanel;
    private Label lblTitle;
    private Button btnBackToDashboard;
    private ComboBox cmbBranch;
    private DataGridView dgvRooms;
    private Panel inputPanel;
    private Label lblRoomNumber;
    private TextBox txtRoomNumber;
    private Label lblRoomType;
    private ComboBox cmbRoomType;
    private Label lblStatus;
    private ComboBox cmbStatus;
    private Label lblPrice;
    private TextBox txtPrice;
    private Button btnAdd;
    private Button btnUpdate;
    private Button btnDelete;

    public RoomManagementForm(string role)
    {
        userRole = role;
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.navPanel = new System.Windows.Forms.Panel();
        this.lblTitle = new System.Windows.Forms.Label();
        this.btnBackToDashboard = new System.Windows.Forms.Button();
        this.cmbBranch = new System.Windows.Forms.ComboBox();
        this.dgvRooms = new System.Windows.Forms.DataGridView();
        this.inputPanel = new System.Windows.Forms.Panel();
        this.lblRoomNumber = new System.Windows.Forms.Label();
        this.txtRoomNumber = new System.Windows.Forms.TextBox();
        this.lblRoomType = new System.Windows.Forms.Label();
        this.cmbRoomType = new System.Windows.Forms.ComboBox();
        this.lblStatus = new System.Windows.Forms.Label();
        this.cmbStatus = new System.Windows.Forms.ComboBox();
        this.lblPrice = new System.Windows.Forms.Label();
        this.txtPrice = new System.Windows.Forms.TextBox();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnUpdate = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.navPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
        this.inputPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // navPanel
        // 
        this.navPanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#1976D2");
        this.navPanel.Controls.Add(this.btnBackToDashboard);
        this.navPanel.Controls.Add(this.lblTitle);
        this.navPanel.Location = new System.Drawing.Point(0, 0);
        this.navPanel.Name = "navPanel";
        this.navPanel.Size = new System.Drawing.Size(200, 529);
        this.navPanel.TabIndex = 0;
        // 
        // lblTitle
        // 
        this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblTitle.ForeColor = System.Drawing.Color.White;
        this.lblTitle.Location = new System.Drawing.Point(10, 10);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(180, 30);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Room Management";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnBackToDashboard
        // 
        this.btnBackToDashboard.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF9800");
        this.btnBackToDashboard.FlatAppearance.BorderSize = 0;
        this.btnBackToDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnBackToDashboard.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnBackToDashboard.ForeColor = System.Drawing.Color.White;
        this.btnBackToDashboard.Location = new System.Drawing.Point(10, 50);
        this.btnBackToDashboard.Name = "btnBackToDashboard";
        this.btnBackToDashboard.Size = new System.Drawing.Size(180, 40);
        this.btnBackToDashboard.TabIndex = 1;
        this.btnBackToDashboard.Text = "Dashboard";
        this.btnBackToDashboard.UseVisualStyleBackColor = false;
        // 
        // cmbBranch
        // 
        this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbBranch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cmbBranch.Location = new System.Drawing.Point(250, 10);
        this.cmbBranch.Name = "cmbBranch";
        this.cmbBranch.Size = new System.Drawing.Size(250, 31);
        this.cmbBranch.TabIndex = 2;
        // 
        // dgvRooms
        // 
        this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
        this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvRooms.Location = new System.Drawing.Point(250, 50);
        this.dgvRooms.Name = "dgvRooms";
        this.dgvRooms.Size = new System.Drawing.Size(400, 400);
        this.dgvRooms.TabIndex = 1;
        this.dgvRooms.AllowUserToAddRows = false;
        this.dgvRooms.AllowUserToDeleteRows = false;
        this.dgvRooms.ReadOnly = true;
        // 
        // inputPanel
        // 
        this.inputPanel.BackColor = System.Drawing.Color.White;
        this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.inputPanel.Controls.Add(this.btnDelete);
        this.inputPanel.Controls.Add(this.btnUpdate);
        this.inputPanel.Controls.Add(this.btnAdd);
        this.inputPanel.Controls.Add(this.txtPrice);
        this.inputPanel.Controls.Add(this.lblPrice);
        this.inputPanel.Controls.Add(this.cmbStatus);
        this.inputPanel.Controls.Add(this.lblStatus);
        this.inputPanel.Controls.Add(this.cmbRoomType);
        this.inputPanel.Controls.Add(this.lblRoomType);
        this.inputPanel.Controls.Add(this.txtRoomNumber);
        this.inputPanel.Controls.Add(this.lblRoomNumber);
        this.inputPanel.Location = new System.Drawing.Point(660, 50);
        this.inputPanel.Name = "inputPanel";
        this.inputPanel.Size = new System.Drawing.Size(300, 400);
        this.inputPanel.TabIndex = 2;
        // 
        // lblRoomNumber
        // 
        this.lblRoomNumber.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblRoomNumber.ForeColor = System.Drawing.ColorTranslator.FromHtml("#212121");
        this.lblRoomNumber.Location = new System.Drawing.Point(20, 20);
        this.lblRoomNumber.Name = "lblRoomNumber";
        this.lblRoomNumber.Size = new System.Drawing.Size(100, 20);
        this.lblRoomNumber.TabIndex = 0;
        this.lblRoomNumber.Text = "Room Number";
        // 
        // txtRoomNumber
        // 
        this.txtRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtRoomNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtRoomNumber.Location = new System.Drawing.Point(20, 45);
        this.txtRoomNumber.Name = "txtRoomNumber";
        this.txtRoomNumber.Size = new System.Drawing.Size(250, 30);
        this.txtRoomNumber.TabIndex = 1;
        // 
        // lblRoomType
        // 
        this.lblRoomType.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblRoomType.ForeColor = System.Drawing.ColorTranslator.FromHtml("#212121");
        this.lblRoomType.Location = new System.Drawing.Point(20, 85);
        this.lblRoomType.Name = "lblRoomType";
        this.lblRoomType.Size = new System.Drawing.Size(100, 20);
        this.lblRoomType.TabIndex = 2;
        this.lblRoomType.Text = "Room Type";
        // 
        // cmbRoomType
        // 
        this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbRoomType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cmbRoomType.Location = new System.Drawing.Point(20, 110);
        this.cmbRoomType.Name = "cmbRoomType";
        this.cmbRoomType.Size = new System.Drawing.Size(250, 31);
        this.cmbRoomType.TabIndex = 3;
        // 
        // lblStatus
        // 
        this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblStatus.ForeColor = System.Drawing.ColorTranslator.FromHtml("#212121");
        this.lblStatus.Location = new System.Drawing.Point(20, 150);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(100, 20);
        this.lblStatus.TabIndex = 4;
        this.lblStatus.Text = "Status";
        // 
        // cmbStatus
        // 
        this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cmbStatus.Location = new System.Drawing.Point(20, 175);
        this.cmbStatus.Name = "cmbStatus";
        this.cmbStatus.Size = new System.Drawing.Size(250, 31);
        this.cmbStatus.TabIndex = 5;
        // 
        // lblPrice
        // 
        this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblPrice.ForeColor = System.Drawing.ColorTranslator.FromHtml("#212121");
        this.lblPrice.Location = new System.Drawing.Point(20, 215);
        this.lblPrice.Name = "lblPrice";
        this.lblPrice.Size = new System.Drawing.Size(100, 20);
        this.lblPrice.TabIndex = 6;
        this.lblPrice.Text = "Price";
        // 
        // txtPrice
        // 
        this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtPrice.Location = new System.Drawing.Point(20, 240);
        this.txtPrice.Name = "txtPrice";
        this.txtPrice.Size = new System.Drawing.Size(250, 30);
        this.txtPrice.TabIndex = 7;
        // 
        // btnAdd
        // 
        this.btnAdd.BackColor = System.Drawing.ColorTranslator.FromHtml("#4CAF50");
        this.btnAdd.FlatAppearance.BorderSize = 0;
        this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnAdd.ForeColor = System.Drawing.Color.White;
        this.btnAdd.Location = new System.Drawing.Point(20, 300);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(120, 40);
        this.btnAdd.TabIndex = 8;
        this.btnAdd.Text = "Add Room";
        this.btnAdd.UseVisualStyleBackColor = false;
        // 
        // btnUpdate
        // 
        this.btnUpdate.BackColor = System.Drawing.ColorTranslator.FromHtml("#1976D2");
        this.btnUpdate.FlatAppearance.BorderSize = 0;
        this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnUpdate.ForeColor = System.Drawing.Color.White;
        this.btnUpdate.Location = new System.Drawing.Point(150, 300);
        this.btnUpdate.Name = "btnUpdate";
        this.btnUpdate.Size = new System.Drawing.Size(120, 40);
        this.btnUpdate.TabIndex = 9;
        this.btnUpdate.Text = "Update";
        this.btnUpdate.UseVisualStyleBackColor = false;
        // 
        // btnDelete
        // 
        this.btnDelete.BackColor = System.Drawing.ColorTranslator.FromHtml("#EF5350");
        this.btnDelete.FlatAppearance.BorderSize = 0;
        this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnDelete.ForeColor = System.Drawing.Color.White;
        this.btnDelete.Location = new System.Drawing.Point(20, 350);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(120, 40);
        this.btnDelete.TabIndex = 10;
        this.btnDelete.Text = "Delete";
        this.btnDelete.UseVisualStyleBackColor = false;
        // 
        // RoomManagementForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(1000, 529);
        this.Controls.Add(this.cmbBranch);
        this.Controls.Add(this.inputPanel);
        this.Controls.Add(this.dgvRooms);
        this.Controls.Add(this.navPanel);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "RoomManagementForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Hotel Management - Room Management";
        this.Load += new System.EventHandler(this.RoomManagementForm_Load);
        this.Resize += new System.EventHandler(this.RoomManagementForm_Resize);
        this.navPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
        this.inputPanel.ResumeLayout(false);
        this.inputPanel.PerformLayout();
        this.ResumeLayout(false);
    }

    private void RoomManagementForm_Load(object sender, EventArgs e)
    {
        // Thêm hiệu ứng và gradient
        this.BackgroundImage = CreateGradientBackground();

        // Thêm hiệu ứng hover cho các nút
        AddHoverEffect(btnBackToDashboard);
        AddHoverEffect(btnAdd, "#4CAF50", "#43A047");
        AddHoverEffect(btnUpdate);
        AddHoverEffect(btnDelete, "#EF5350", "#E53935");

        // Thiết lập ComboBox và DataGridView
        SetupBranchComboBox();
        SetupDataGridView();
        SetupInputControls();

        // Viền mỏng cho inputPanel và dgvRooms
        inputPanel.Paint += (s, e) =>
        {
            using (var pen = new Pen(ColorTranslator.FromHtml("#E0E0E0"), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, inputPanel.Width - 1, inputPanel.Height - 1);
            }
        };
        dgvRooms.CellBorderStyle = DataGridViewCellBorderStyle.None;
        dgvRooms.Paint += (s, e) =>
        {
            using (var pen = new Pen(ColorTranslator.FromHtml("#E0E0E0"), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, dgvRooms.Width - 1, dgvRooms.Height - 1);
            }
        };

        // Sự kiện
        btnBackToDashboard.Click += (s, e) =>
        {
            this.Hide();
            MainDashboardForm dashboard = new MainDashboardForm(userRole);
            dashboard.ShowDialog();
            this.Close();
        };
        btnAdd.Click += BtnAdd_Click;
        btnUpdate.Click += BtnUpdate_Click;
        btnDelete.Click += BtnDelete_Click;
        dgvRooms.SelectionChanged += DgvRooms_SelectionChanged;
        cmbBranch.SelectedIndexChanged += (s, e) => LoadRoomsForBranch();
    }

    private void RoomManagementForm_Resize(object sender, EventArgs e)
    {
        UpdateGradientBackground();
        navPanel.Height = this.ClientSize.Height;
        dgvRooms.Location = new Point(250, 50);
        inputPanel.Location = new Point(this.ClientSize.Width - 350, 50);
        cmbBranch.Location = new Point(250, 10);
    }

    private void SetupBranchComboBox()
    {
        // Dữ liệu giả lập cho chi nhánh
        cmbBranch.Items.AddRange(new string[] { "Branch 1", "Branch 2", "Branch 3" });
        if (cmbBranch.Items.Count > 0) cmbBranch.SelectedIndex = 0;
    }

    private void SetupDataGridView()
    {
        dgvRooms.Columns.Add("RoomNumber", "Room Number");
        dgvRooms.Columns.Add("RoomType", "Room Type");
        dgvRooms.Columns.Add("Status", "Status");
        dgvRooms.Columns.Add("Price", "Price");

        // Tùy chỉnh giao diện DataGridView
        dgvRooms.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1976D2");
        dgvRooms.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgvRooms.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
        dgvRooms.EnableHeadersVisualStyles = false;
        dgvRooms.DefaultCellStyle.Font = new Font("Century Gothic", 10F);
        dgvRooms.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#212121");
        dgvRooms.DefaultCellStyle.BackColor = Color.White;
        dgvRooms.RowHeadersVisible = false;
        dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        LoadRoomsForBranch();
    }

    private void SetupInputControls()
    {
        cmbRoomType.Items.AddRange(new string[] { "Single", "Double", "Suite" });
        cmbStatus.Items.AddRange(new string[] { "Available", "Occupied", "Cleaning" });
    }

    private void LoadRoomsForBranch()
    {
        dgvRooms.Rows.Clear();
        // Dữ liệu giả lập - thay bằng truy vấn database
        if (cmbBranch.SelectedItem?.ToString() == "Branch 1")
        {
            dgvRooms.Rows.Add("101", "Single", "Available", "100");
            dgvRooms.Rows.Add("102", "Double", "Occupied", "150");
        }
        else if (cmbBranch.SelectedItem?.ToString() == "Branch 2")
        {
            dgvRooms.Rows.Add("201", "Suite", "Cleaning", "300");
            dgvRooms.Rows.Add("202", "Single", "Available", "100");
        }
        else if (cmbBranch.SelectedItem?.ToString() == "Branch 3")
        {
            dgvRooms.Rows.Add("301", "Double", "Available", "150");
        }
    }

    private void BtnAdd_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtRoomNumber.Text) || cmbRoomType.SelectedItem == null ||
            cmbStatus.SelectedItem == null || string.IsNullOrEmpty(txtPrice.Text))
        {
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Thêm phòng mới
        dgvRooms.Rows.Add(txtRoomNumber.Text, cmbRoomType.SelectedItem.ToString(),
            cmbStatus.SelectedItem.ToString(), txtPrice.Text);
        ClearInputs();
    }

    private void BtnUpdate_Click(object sender, EventArgs e)
    {
        if (dgvRooms.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a room to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (string.IsNullOrEmpty(txtRoomNumber.Text) || cmbRoomType.SelectedItem == null ||
            cmbStatus.SelectedItem == null || string.IsNullOrEmpty(txtPrice.Text))
        {
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var selectedRow = dgvRooms.SelectedRows[0];
        selectedRow.Cells["RoomNumber"].Value = txtRoomNumber.Text;
        selectedRow.Cells["RoomType"].Value = cmbRoomType.SelectedItem.ToString();
        selectedRow.Cells["Status"].Value = cmbStatus.SelectedItem.ToString();
        selectedRow.Cells["Price"].Value = txtPrice.Text;
        ClearInputs();
    }

    private void BtnDelete_Click(object sender, EventArgs e)
    {
        if (dgvRooms.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a room to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        dgvRooms.Rows.Remove(dgvRooms.SelectedRows[0]);
        ClearInputs();
    }

    private void DgvRooms_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvRooms.SelectedRows.Count > 0)
        {
            var selectedRow = dgvRooms.SelectedRows[0];
            txtRoomNumber.Text = selectedRow.Cells["RoomNumber"].Value.ToString();
            cmbRoomType.SelectedItem = selectedRow.Cells["RoomType"].Value.ToString();
            cmbStatus.SelectedItem = selectedRow.Cells["Status"].Value.ToString();
            txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
        }
    }

    private void ClearInputs()
    {
        txtRoomNumber.Clear();
        cmbRoomType.SelectedIndex = -1;
        cmbStatus.SelectedIndex = -1;
        txtPrice.Clear();
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