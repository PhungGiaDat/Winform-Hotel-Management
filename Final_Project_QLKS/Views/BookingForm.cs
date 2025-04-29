using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public partial class BookingForm : Form
{
    private string userRole;
    private Panel navPanel;
    private Label lblTitle;
    private Button btnBackToDashboard;
    private ComboBox cmbBranchFilter;
    private DateTimePicker dtpFilterDate;
    private Button btnFilter;
    private DataGridView dgvBookings;
    private Panel inputPanel;
    private Label lblCustomerName;
    private TextBox txtCustomerName;
    private Label lblCheckIn;
    private DateTimePicker dtpCheckIn;
    private Label lblCheckOut;
    private DateTimePicker dtpCheckOut;
    private Label lblRoomType;
    private ComboBox cmbRoomType;
    private Label lblRoomNumber;
    private ComboBox cmbRoomNumber;
    private Button btnAutoAssignRoom;
    private Button btnAddBooking;
    private Button btnCheckIn;
    private Button btnCheckOut;

    public BookingForm(string role)
    {
        userRole = role;
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        navPanel = new Panel();
        btnBackToDashboard = new Button();
        lblTitle = new Label();
        cmbBranchFilter = new ComboBox();
        dtpFilterDate = new DateTimePicker();
        btnFilter = new Button();
        dgvBookings = new DataGridView();
        inputPanel = new Panel();
        btnCheckOut = new Button();
        btnCheckIn = new Button();
        btnAddBooking = new Button();
        btnAutoAssignRoom = new Button();
        cmbRoomNumber = new ComboBox();
        lblRoomNumber = new Label();
        cmbRoomType = new ComboBox();
        lblRoomType = new Label();
        dtpCheckOut = new DateTimePicker();
        lblCheckOut = new Label();
        dtpCheckIn = new DateTimePicker();
        lblCheckIn = new Label();
        txtCustomerName = new TextBox();
        lblCustomerName = new Label();
        navPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
        inputPanel.SuspendLayout();
        SuspendLayout();
        // 
        // navPanel
        // 
        navPanel.BackColor = Color.FromArgb(25, 118, 210);
        navPanel.Controls.Add(btnBackToDashboard);
        navPanel.Controls.Add(lblTitle);
        navPanel.Location = new Point(0, 0);
        navPanel.Margin = new Padding(5, 6, 5, 6);
        navPanel.Name = "navPanel";
        navPanel.Size = new Size(325, 1401);
        navPanel.TabIndex = 0;
        // 
        // btnBackToDashboard
        // 
        btnBackToDashboard.BackColor = Color.FromArgb(255, 152, 0);
        btnBackToDashboard.FlatAppearance.BorderSize = 0;
        btnBackToDashboard.FlatStyle = FlatStyle.Flat;
        btnBackToDashboard.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBackToDashboard.ForeColor = Color.White;
        btnBackToDashboard.Location = new Point(16, 100);
        btnBackToDashboard.Margin = new Padding(5, 6, 5, 6);
        btnBackToDashboard.Name = "btnBackToDashboard";
        btnBackToDashboard.Size = new Size(292, 80);
        btnBackToDashboard.TabIndex = 1;
        btnBackToDashboard.Text = "Dashboard";
        btnBackToDashboard.UseVisualStyleBackColor = false;
        btnBackToDashboard.Click += btnBackToDashboard_Click;
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
        lblTitle.Text = "Booking";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // cmbBranchFilter
        // 
        cmbBranchFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbBranchFilter.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cmbBranchFilter.Location = new Point(406, 20);
        cmbBranchFilter.Margin = new Padding(5, 6, 5, 6);
        cmbBranchFilter.Name = "cmbBranchFilter";
        cmbBranchFilter.Size = new Size(241, 47);
        cmbBranchFilter.TabIndex = 2;
        // 
        // dtpFilterDate
        // 
        dtpFilterDate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dtpFilterDate.Location = new Point(666, 20);
        dtpFilterDate.Margin = new Padding(5, 6, 5, 6);
        dtpFilterDate.Name = "dtpFilterDate";
        dtpFilterDate.Size = new Size(241, 47);
        dtpFilterDate.TabIndex = 3;
        dtpFilterDate.ValueChanged += dtpFilterDate_ValueChanged;
        // 
        // btnFilter
        // 
        btnFilter.BackColor = Color.FromArgb(25, 118, 210);
        btnFilter.FlatAppearance.BorderSize = 0;
        btnFilter.FlatStyle = FlatStyle.Flat;
        btnFilter.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnFilter.ForeColor = Color.White;
        btnFilter.Location = new Point(926, 20);
        btnFilter.Margin = new Padding(5, 6, 5, 6);
        btnFilter.Name = "btnFilter";
        btnFilter.Size = new Size(130, 60);
        btnFilter.TabIndex = 4;
        btnFilter.Text = "Filter";
        btnFilter.UseVisualStyleBackColor = false;
        // 
        // dgvBookings
        // 
        dgvBookings.AllowUserToAddRows = false;
        dgvBookings.AllowUserToDeleteRows = false;
        dgvBookings.BackgroundColor = Color.White;
        dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvBookings.Location = new Point(406, 100);
        dgvBookings.Margin = new Padding(5, 6, 5, 6);
        dgvBookings.Name = "dgvBookings";
        dgvBookings.ReadOnly = true;
        dgvBookings.RowHeadersWidth = 82;
        dgvBookings.Size = new Size(650, 846);
        dgvBookings.TabIndex = 1;
        // 
        // inputPanel
        // 
        inputPanel.BackColor = Color.White;
        inputPanel.BorderStyle = BorderStyle.FixedSingle;
        inputPanel.Controls.Add(btnCheckOut);
        inputPanel.Controls.Add(btnCheckIn);
        inputPanel.Controls.Add(btnAddBooking);
        inputPanel.Controls.Add(btnAutoAssignRoom);
        inputPanel.Controls.Add(cmbRoomNumber);
        inputPanel.Controls.Add(lblRoomNumber);
        inputPanel.Controls.Add(cmbRoomType);
        inputPanel.Controls.Add(lblRoomType);
        inputPanel.Controls.Add(dtpCheckOut);
        inputPanel.Controls.Add(lblCheckOut);
        inputPanel.Controls.Add(dtpCheckIn);
        inputPanel.Controls.Add(lblCheckIn);
        inputPanel.Controls.Add(txtCustomerName);
        inputPanel.Controls.Add(lblCustomerName);
        inputPanel.Location = new Point(1072, 100);
        inputPanel.Margin = new Padding(5, 6, 5, 6);
        inputPanel.Name = "inputPanel";
        inputPanel.Size = new Size(486, 846);
        inputPanel.TabIndex = 2;
        // 
        // btnCheckOut
        // 
        btnCheckOut.BackColor = Color.FromArgb(239, 83, 80);
        btnCheckOut.FlatAppearance.BorderSize = 0;
        btnCheckOut.FlatStyle = FlatStyle.Flat;
        btnCheckOut.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnCheckOut.ForeColor = Color.White;
        btnCheckOut.Location = new Point(32, 740);
        btnCheckOut.Margin = new Padding(5, 6, 5, 6);
        btnCheckOut.Name = "btnCheckOut";
        btnCheckOut.Size = new Size(195, 80);
        btnCheckOut.TabIndex = 13;
        btnCheckOut.Text = "Check-Out";
        btnCheckOut.UseVisualStyleBackColor = false;
        // 
        // btnCheckIn
        // 
        btnCheckIn.BackColor = Color.FromArgb(25, 118, 210);
        btnCheckIn.FlatAppearance.BorderSize = 0;
        btnCheckIn.FlatStyle = FlatStyle.Flat;
        btnCheckIn.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnCheckIn.ForeColor = Color.White;
        btnCheckIn.Location = new Point(244, 640);
        btnCheckIn.Margin = new Padding(5, 6, 5, 6);
        btnCheckIn.Name = "btnCheckIn";
        btnCheckIn.Size = new Size(195, 80);
        btnCheckIn.TabIndex = 12;
        btnCheckIn.Text = "Check-In";
        btnCheckIn.UseVisualStyleBackColor = false;
        // 
        // btnAddBooking
        // 
        btnAddBooking.BackColor = Color.FromArgb(76, 175, 80);
        btnAddBooking.FlatAppearance.BorderSize = 0;
        btnAddBooking.FlatStyle = FlatStyle.Flat;
        btnAddBooking.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnAddBooking.ForeColor = Color.White;
        btnAddBooking.Location = new Point(32, 640);
        btnAddBooking.Margin = new Padding(5, 6, 5, 6);
        btnAddBooking.Name = "btnAddBooking";
        btnAddBooking.Size = new Size(195, 80);
        btnAddBooking.TabIndex = 11;
        btnAddBooking.Text = "Add Booking";
        btnAddBooking.UseVisualStyleBackColor = false;
        // 
        // btnAutoAssignRoom
        // 
        btnAutoAssignRoom.BackColor = Color.FromArgb(25, 118, 210);
        btnAutoAssignRoom.FlatAppearance.BorderSize = 0;
        btnAutoAssignRoom.FlatStyle = FlatStyle.Flat;
        btnAutoAssignRoom.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnAutoAssignRoom.ForeColor = Color.White;
        btnAutoAssignRoom.Location = new Point(32, 560);
        btnAutoAssignRoom.Margin = new Padding(5, 6, 5, 6);
        btnAutoAssignRoom.Name = "btnAutoAssignRoom";
        btnAutoAssignRoom.Size = new Size(406, 60);
        btnAutoAssignRoom.TabIndex = 10;
        btnAutoAssignRoom.Text = "Auto Assign Room";
        btnAutoAssignRoom.UseVisualStyleBackColor = false;
        // 
        // cmbRoomNumber
        // 
        cmbRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbRoomNumber.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cmbRoomNumber.Location = new Point(244, 480);
        cmbRoomNumber.Margin = new Padding(5, 6, 5, 6);
        cmbRoomNumber.Name = "cmbRoomNumber";
        cmbRoomNumber.Size = new Size(192, 47);
        cmbRoomNumber.TabIndex = 9;
        // 
        // lblRoomNumber
        // 
        lblRoomNumber.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblRoomNumber.ForeColor = Color.FromArgb(33, 33, 33);
        lblRoomNumber.Location = new Point(244, 430);
        lblRoomNumber.Margin = new Padding(5, 0, 5, 0);
        lblRoomNumber.Name = "lblRoomNumber";
        lblRoomNumber.Size = new Size(162, 40);
        lblRoomNumber.TabIndex = 8;
        lblRoomNumber.Text = "Room Number";
        // 
        // cmbRoomType
        // 
        cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbRoomType.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cmbRoomType.Location = new Point(32, 480);
        cmbRoomType.Margin = new Padding(5, 6, 5, 6);
        cmbRoomType.Name = "cmbRoomType";
        cmbRoomType.Size = new Size(192, 47);
        cmbRoomType.TabIndex = 7;
        // 
        // lblRoomType
        // 
        lblRoomType.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblRoomType.ForeColor = Color.FromArgb(33, 33, 33);
        lblRoomType.Location = new Point(32, 430);
        lblRoomType.Margin = new Padding(5, 0, 5, 0);
        lblRoomType.Name = "lblRoomType";
        lblRoomType.Size = new Size(162, 40);
        lblRoomType.TabIndex = 6;
        lblRoomType.Text = "Room Type";
        // 
        // dtpCheckOut
        // 
        dtpCheckOut.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dtpCheckOut.Location = new Point(32, 350);
        dtpCheckOut.Margin = new Padding(5, 6, 5, 6);
        dtpCheckOut.Name = "dtpCheckOut";
        dtpCheckOut.Size = new Size(404, 47);
        dtpCheckOut.TabIndex = 5;
        // 
        // lblCheckOut
        // 
        lblCheckOut.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblCheckOut.ForeColor = Color.FromArgb(33, 33, 33);
        lblCheckOut.Location = new Point(32, 300);
        lblCheckOut.Margin = new Padding(5, 0, 5, 0);
        lblCheckOut.Name = "lblCheckOut";
        lblCheckOut.Size = new Size(162, 40);
        lblCheckOut.TabIndex = 4;
        lblCheckOut.Text = "Check-Out Date";
        // 
        // dtpCheckIn
        // 
        dtpCheckIn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dtpCheckIn.Location = new Point(32, 220);
        dtpCheckIn.Margin = new Padding(5, 6, 5, 6);
        dtpCheckIn.Name = "dtpCheckIn";
        dtpCheckIn.Size = new Size(404, 47);
        dtpCheckIn.TabIndex = 3;
        // 
        // lblCheckIn
        // 
        lblCheckIn.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblCheckIn.ForeColor = Color.FromArgb(33, 33, 33);
        lblCheckIn.Location = new Point(32, 170);
        lblCheckIn.Margin = new Padding(5, 0, 5, 0);
        lblCheckIn.Name = "lblCheckIn";
        lblCheckIn.Size = new Size(162, 40);
        lblCheckIn.TabIndex = 2;
        lblCheckIn.Text = "Check-In Date";
        // 
        // txtCustomerName
        // 
        txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
        txtCustomerName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtCustomerName.Location = new Point(32, 90);
        txtCustomerName.Margin = new Padding(5, 6, 5, 6);
        txtCustomerName.Name = "txtCustomerName";
        txtCustomerName.Size = new Size(405, 47);
        txtCustomerName.TabIndex = 1;
        // 
        // lblCustomerName
        // 
        lblCustomerName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblCustomerName.ForeColor = Color.FromArgb(33, 33, 33);
        lblCustomerName.Location = new Point(32, 40);
        lblCustomerName.Margin = new Padding(5, 0, 5, 0);
        lblCustomerName.Name = "lblCustomerName";
        lblCustomerName.Size = new Size(162, 40);
        lblCustomerName.TabIndex = 0;
        lblCustomerName.Text = "Customer Name";
        // 
        // BookingForm
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1625, 1400);
        Controls.Add(inputPanel);
        Controls.Add(dgvBookings);
        Controls.Add(btnFilter);
        Controls.Add(dtpFilterDate);
        Controls.Add(cmbBranchFilter);
        Controls.Add(navPanel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5, 6, 5, 6);
        MaximizeBox = false;
        Name = "BookingForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Hotel Management - Booking";
        Load += BookingForm_Load;
        Resize += BookingForm_Resize;
        navPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
        inputPanel.ResumeLayout(false);
        inputPanel.PerformLayout();
        ResumeLayout(false);
    }

    private void BookingForm_Load(object sender, EventArgs e)
    {
        // Thêm hiệu ứng và gradient
        this.BackgroundImage = CreateGradientBackground();

        // Thêm hiệu ứng hover cho các nút
        AddHoverEffect(btnBackToDashboard);
        AddHoverEffect(btnFilter);
        AddHoverEffect(btnAutoAssignRoom);
        AddHoverEffect(btnAddBooking, "#4CAF50", "#43A047");
        AddHoverEffect(btnCheckIn);
        AddHoverEffect(btnCheckOut, "#EF5350", "#E53935");

        // Thiết lập ComboBox và DataGridView
        SetupBranchFilterComboBox();
        SetupRoomTypeComboBox();
        SetupDataGridView();

        // Viền mỏng cho inputPanel và dgvBookings
        inputPanel.Paint += (s, e) =>
        {
            using (var pen = new Pen(ColorTranslator.FromHtml("#E0E0E0"), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, inputPanel.Width - 1, inputPanel.Height - 1);
            }
        };
        dgvBookings.CellBorderStyle = DataGridViewCellBorderStyle.None;
        dgvBookings.Paint += (s, e) =>
        {
            using (var pen = new Pen(ColorTranslator.FromHtml("#E0E0E0"), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, dgvBookings.Width - 1, dgvBookings.Height - 1);
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
        btnFilter.Click += (s, e) => LoadBookings();
        btnAutoAssignRoom.Click += BtnAutoAssignRoom_Click;
        btnAddBooking.Click += BtnAddBooking_Click;
        btnCheckIn.Click += BtnCheckIn_Click;
        btnCheckOut.Click += BtnCheckOut_Click;
        dgvBookings.SelectionChanged += DgvBookings_SelectionChanged;
        cmbRoomType.SelectedIndexChanged += (s, e) => UpdateAvailableRooms();

    }

    private void BookingForm_Resize(object sender, EventArgs e)
    {
        UpdateGradientBackground();
        navPanel.Height = this.ClientSize.Height;
        dgvBookings.Location = new Point(250, 50);
        inputPanel.Location = new Point(this.ClientSize.Width - 350, 50);

    }

    private void SetupBranchFilterComboBox()
    {
        cmbBranchFilter.Items.AddRange(new string[] { "All", "Branch 1", "Branch 2", "Branch 3" });
        if (cmbBranchFilter.Items.Count > 0) cmbBranchFilter.SelectedIndex = 0;
    }

    private void SetupRoomTypeComboBox()
    {
        cmbRoomType.Items.AddRange(new string[] { "Single", "Double", "Suite" });
    }

    private void SetupDataGridView()
    {
        dgvBookings.Columns.Add("BookingId", "Booking ID");
        dgvBookings.Columns.Add("CustomerName", "Customer Name");
        dgvBookings.Columns.Add("CheckIn", "Check-In");
        dgvBookings.Columns.Add("CheckOut", "Check-Out");
        dgvBookings.Columns.Add("RoomNumber", "Room Number");
        dgvBookings.Columns.Add("Status", "Status");

        // Tùy chỉnh giao diện DataGridView
        dgvBookings.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1976D2");
        dgvBookings.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgvBookings.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
        dgvBookings.EnableHeadersVisualStyles = false;
        dgvBookings.DefaultCellStyle.Font = new Font("Century Gothic", 10F);
        dgvBookings.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#212121");
        dgvBookings.DefaultCellStyle.BackColor = Color.White;
        dgvBookings.RowHeadersVisible = false;
        dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        LoadBookings();
    }

    private void LoadBookings()
    {
        dgvBookings.Rows.Clear();
        // Dữ liệu giả lập - thay bằng truy vấn database
        string selectedBranch = cmbBranchFilter.SelectedItem?.ToString();
        DateTime filterDate = dtpFilterDate.Value.Date;

        if (selectedBranch == "All" || selectedBranch == "Branch 1")
        {
            dgvBookings.Rows.Add("B001", "John Doe", "2025-04-17", "2025-04-20", "101", "Confirmed");
        }
        if (selectedBranch == "All" || selectedBranch == "Branch 2")
        {
            dgvBookings.Rows.Add("B002", "Jane Smith", "2025-04-18", "2025-04-21", "201", "Checked-In");
        }
    }

    private void UpdateAvailableRooms()
    {
        cmbRoomNumber.Items.Clear();
        // Dữ liệu giả lập - thay bằng truy vấn database
        string selectedRoomType = cmbRoomType.SelectedItem?.ToString();
        DateTime checkIn = dtpCheckIn.Value.Date;
        DateTime checkOut = dtpCheckOut.Value.Date;

        if (selectedRoomType == "Single")
        {
            cmbRoomNumber.Items.Add("101");
            cmbRoomNumber.Items.Add("202");
        }
        else if (selectedRoomType == "Double")
        {
            cmbRoomNumber.Items.Add("102");
            cmbRoomNumber.Items.Add("301");
        }
        else if (selectedRoomType == "Suite")
        {
            cmbRoomNumber.Items.Add("201");
        }
    }

    private void BtnAutoAssignRoom_Click(object sender, EventArgs e)
    {
        if (cmbRoomType.SelectedItem == null || dtpCheckIn.Value >= dtpCheckOut.Value)
        {
            MessageBox.Show("Please select a room type and valid dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Logic gán phòng tự động - giả lập
        UpdateAvailableRooms();
        if (cmbRoomNumber.Items.Count > 0)
        {
            cmbRoomNumber.SelectedIndex = 0; // Gán phòng đầu tiên có sẵn
        }
        else
        {
            MessageBox.Show("No available rooms for the selected type and dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnAddBooking_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtCustomerName.Text) || dtpCheckIn.Value >= dtpCheckOut.Value ||
            cmbRoomType.SelectedItem == null || cmbRoomNumber.SelectedItem == null)
        {
            MessageBox.Show("Please fill in all fields and ensure valid dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Thêm đặt phòng mới
        string bookingId = "B" + (dgvBookings.Rows.Count + 1).ToString("D03");
        dgvBookings.Rows.Add(bookingId, txtCustomerName.Text, dtpCheckIn.Value.ToString("yyyy-MM-dd"),
            dtpCheckOut.Value.ToString("yyyy-MM-dd"), cmbRoomNumber.SelectedItem.ToString(), "Confirmed");
        ClearInputs();
    }

    private void BtnCheckIn_Click(object sender, EventArgs e)
    {
        if (dgvBookings.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a booking to check-in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var selectedRow = dgvBookings.SelectedRows[0];
        selectedRow.Cells["Status"].Value = "Checked-In";
        ClearInputs();
    }

    private void BtnCheckOut_Click(object sender, EventArgs e)
    {
        if (dgvBookings.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a booking to check-out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var selectedRow = dgvBookings.SelectedRows[0];
        selectedRow.Cells["Status"].Value = "Checked-Out";
        ClearInputs();
    }

    private void DgvBookings_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvBookings.SelectedRows.Count > 0)
        {
            var selectedRow = dgvBookings.SelectedRows[0];
            txtCustomerName.Text = selectedRow.Cells["CustomerName"].Value.ToString();
            dtpCheckIn.Value = DateTime.Parse(selectedRow.Cells["CheckIn"].Value.ToString());
            dtpCheckOut.Value = DateTime.Parse(selectedRow.Cells["CheckOut"].Value.ToString());
            cmbRoomNumber.Items.Clear();
            cmbRoomNumber.Items.Add(selectedRow.Cells["RoomNumber"].Value.ToString());
            cmbRoomNumber.SelectedIndex = 0;
        }
    }



    private void ClearInputs()
    {
        txtCustomerName.Clear();
        dtpCheckIn.Value = DateTime.Today;
        dtpCheckOut.Value = DateTime.Today.AddDays(1);
        cmbRoomType.SelectedIndex = -1;
        cmbRoomNumber.Items.Clear();
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

    private void dtpFilterDate_ValueChanged(object sender, EventArgs e)
    {

    }

    private void btnBackToDashboard_Click(object sender, EventArgs e)
    {

    }
}