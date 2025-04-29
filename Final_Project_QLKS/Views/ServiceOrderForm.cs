using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public partial class ServiceOrderForm : Form
{
    private string userRole;
    private Panel navPanel;
    private Label lblTitle;
    private Button btnBackToDashboard;
    private TextBox txtSearch;
    private FlowLayoutPanel serviceGrid;
    private DataGridView dgvOrder;
    private Panel orderPanel;
    private Label lblTotal;
    private Button btnConfirmOrder;
    private Button btnRemoveService;

    // Dữ liệu giả lập cho dịch vụ
    private List<Service> services = new List<Service>
    {
        new Service { Id = 1, Name = "Breakfast", Price = 10, ImagePath = "breakfast.jpg" },
        new Service { Id = 2, Name = "Laundry", Price = 5, ImagePath = "laundry.jpg" },
        new Service { Id = 3, Name = "Spa", Price = 50, ImagePath = "spa.jpg" },
        new Service { Id = 4, Name = "Room Service", Price = 15, ImagePath = "room_service.jpg" }
    };

    private List<OrderItem> orderItems = new List<OrderItem>();

    public ServiceOrderForm(string role)
    {
        userRole = role;
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        navPanel = new Panel();
        btnBackToDashboard = new Button();
        lblTitle = new Label();
        txtSearch = new TextBox();
        serviceGrid = new FlowLayoutPanel();
        orderPanel = new Panel();
        btnRemoveService = new Button();
        btnConfirmOrder = new Button();
        lblTotal = new Label();
        dgvOrder = new DataGridView();
        navPanel.SuspendLayout();
        orderPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
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
        navPanel.Size = new Size(325, 1058);
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
        lblTitle.Text = "Service Order";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtSearch
        // 
        txtSearch.BorderStyle = BorderStyle.FixedSingle;
        txtSearch.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtSearch.Location = new Point(406, 20);
        txtSearch.Margin = new Padding(5, 6, 5, 6);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search services...";
        txtSearch.Size = new Size(486, 47);
        txtSearch.TabIndex = 2;
        // 
        // serviceGrid
        // 
        serviceGrid.AutoScroll = true;
        serviceGrid.BackColor = Color.White;
        serviceGrid.BorderStyle = BorderStyle.FixedSingle;
        serviceGrid.Location = new Point(406, 100);
        serviceGrid.Margin = new Padding(5, 6, 5, 6);
        serviceGrid.Name = "serviceGrid";
        serviceGrid.Size = new Size(649, 798);
        serviceGrid.TabIndex = 3;
        // 
        // orderPanel
        // 
        orderPanel.BackColor = Color.White;
        orderPanel.BorderStyle = BorderStyle.FixedSingle;
        orderPanel.Controls.Add(btnRemoveService);
        orderPanel.Controls.Add(btnConfirmOrder);
        orderPanel.Controls.Add(lblTotal);
        orderPanel.Controls.Add(dgvOrder);
        orderPanel.Location = new Point(1072, 100);
        orderPanel.Margin = new Padding(5, 6, 5, 6);
        orderPanel.Name = "orderPanel";
        orderPanel.Size = new Size(486, 898);
        orderPanel.TabIndex = 4;
        orderPanel.Paint += orderPanel_Paint;
        // 
        // btnRemoveService
        // 
        btnRemoveService.BackColor = Color.FromArgb(239, 83, 80);
        btnRemoveService.FlatAppearance.BorderSize = 0;
        btnRemoveService.FlatStyle = FlatStyle.Flat;
        btnRemoveService.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnRemoveService.ForeColor = Color.White;
        btnRemoveService.Location = new Point(244, 720);
        btnRemoveService.Margin = new Padding(5, 6, 5, 6);
        btnRemoveService.Name = "btnRemoveService";
        btnRemoveService.Size = new Size(211, 60);
        btnRemoveService.TabIndex = 3;
        btnRemoveService.Text = "Remove Service";
        btnRemoveService.UseVisualStyleBackColor = false;
        // 
        // btnConfirmOrder
        // 
        btnConfirmOrder.BackColor = Color.FromArgb(76, 175, 80);
        btnConfirmOrder.FlatAppearance.BorderSize = 0;
        btnConfirmOrder.FlatStyle = FlatStyle.Flat;
        btnConfirmOrder.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnConfirmOrder.ForeColor = Color.White;
        btnConfirmOrder.Location = new Point(16, 720);
        btnConfirmOrder.Margin = new Padding(5, 6, 5, 6);
        btnConfirmOrder.Name = "btnConfirmOrder";
        btnConfirmOrder.Size = new Size(211, 60);
        btnConfirmOrder.TabIndex = 2;
        btnConfirmOrder.Text = "Confirm Order";
        btnConfirmOrder.UseVisualStyleBackColor = false;
        // 
        // lblTotal
        // 
        lblTotal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTotal.ForeColor = Color.FromArgb(33, 33, 33);
        lblTotal.Location = new Point(16, 640);
        lblTotal.Margin = new Padding(5, 0, 5, 0);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(455, 60);
        lblTotal.TabIndex = 1;
        lblTotal.Text = "Total: $0";
        lblTotal.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // dgvOrder
        // 
        dgvOrder.AllowUserToAddRows = false;
        dgvOrder.AllowUserToDeleteRows = false;
        dgvOrder.BackgroundColor = Color.White;
        dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvOrder.Location = new Point(16, 20);
        dgvOrder.Margin = new Padding(5, 6, 5, 6);
        dgvOrder.Name = "dgvOrder";
        dgvOrder.ReadOnly = true;
        dgvOrder.RowHeadersWidth = 82;
        dgvOrder.Size = new Size(455, 600);
        dgvOrder.TabIndex = 0;
        // 
        // ServiceOrderForm
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1625, 1058);
        Controls.Add(orderPanel);
        Controls.Add(serviceGrid);
        Controls.Add(txtSearch);
        Controls.Add(navPanel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5, 6, 5, 6);
        MaximizeBox = false;
        Name = "ServiceOrderForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Hotel Management - Service Order";
        Load += ServiceOrderForm_Load;
        Resize += ServiceOrderForm_Resize;
        navPanel.ResumeLayout(false);
        orderPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private void ServiceOrderForm_Load(object sender, EventArgs e)
    {
        // Thêm hiệu ứng và gradient
        this.BackgroundImage = CreateGradientBackground();

        // Thêm hiệu ứng hover cho các nút
        AddHoverEffect(btnBackToDashboard);
        AddHoverEffect(btnConfirmOrder, "#4CAF50", "#43A047");
        AddHoverEffect(btnRemoveService, "#EF5350", "#E53935");

        // Thiết lập DataGridView và Service Grid
        SetupDataGridView();
        LoadServices();

        // Viền mỏng cho serviceGrid và orderPanel
        serviceGrid.Paint += (s, e) =>
        {
            using (var pen = new Pen(ColorTranslator.FromHtml("#E0E0E0"), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, serviceGrid.Width - 1, serviceGrid.Height - 1);
            }
        };
        orderPanel.Paint += (s, e) =>
        {
            using (var pen = new Pen(ColorTranslator.FromHtml("#E0E0E0"), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, orderPanel.Width - 1, orderPanel.Height - 1);
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
        txtSearch.TextChanged += (s, e) => LoadServices();
        btnConfirmOrder.Click += BtnConfirmOrder_Click;
        btnRemoveService.Click += BtnRemoveService_Click;

        // Debug: Kiểm tra trạng thái nút Confirm Order
        // MessageBox.Show($"Confirm Order Visible: {btnConfirmOrder.Visible}, Role: {userRole}", "Debug");
    }

    private void ServiceOrderForm_Resize(object sender, EventArgs e)
    {
        UpdateGradientBackground();
        navPanel.Height = this.ClientSize.Height;
        serviceGrid.Location = new Point(250, 50);
        orderPanel.Location = new Point(this.ClientSize.Width - 350, 50);
        txtSearch.Location = new Point(250, 10);
    }

    private void SetupDataGridView()
    {
        dgvOrder.Columns.Add("ServiceName", "Service Name");
        dgvOrder.Columns.Add("Quantity", "Quantity");
        dgvOrder.Columns.Add("Price", "Price");
        dgvOrder.Columns.Add("Total", "Total");

        // Tùy chỉnh giao diện DataGridView
        dgvOrder.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1976D2");
        dgvOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgvOrder.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
        dgvOrder.EnableHeadersVisualStyles = false;
        dgvOrder.DefaultCellStyle.Font = new Font("Century Gothic", 10F);
        dgvOrder.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#212121");
        dgvOrder.DefaultCellStyle.BackColor = Color.White;
        dgvOrder.RowHeadersVisible = false;
        dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        // Viền mỏng cho DataGridView
        dgvOrder.CellBorderStyle = DataGridViewCellBorderStyle.None;
        dgvOrder.Paint += (s, e) =>
        {
            using (var pen = new Pen(ColorTranslator.FromHtml("#E0E0E0"), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, dgvOrder.Width - 1, dgvOrder.Height - 1);
            }
        };
    }

    private void LoadServices()
    {
        serviceGrid.Controls.Clear();
        string searchText = txtSearch.Text.ToLower();

        foreach (var service in services)
        {
            if (string.IsNullOrEmpty(searchText) || service.Name.ToLower().Contains(searchText))
            {
                var servicePanel = new Panel
                {
                    Size = new Size(180, 180),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                // Hình ảnh giả lập (thay bằng Image.FromFile(service.ImagePath) nếu có hình ảnh)
                var pictureBox = new PictureBox
                {
                    Size = new Size(160, 100),
                    Location = new Point(10, 10),
                    BackColor = ColorTranslator.FromHtml("#E0E0E0"), // Giả lập hình ảnh
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                // Nếu có hình ảnh, sử dụng: pictureBox.Image = Image.FromFile(service.ImagePath);

                var lblName = new Label
                {
                    Font = new Font("Century Gothic", 10F, FontStyle.Regular),
                    ForeColor = ColorTranslator.FromHtml("#212121"),
                    Location = new Point(10, 120),
                    Size = new Size(160, 20),
                    Text = service.Name,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                var lblPrice = new Label
                {
                    Font = new Font("Century Gothic", 10F, FontStyle.Bold),
                    ForeColor = ColorTranslator.FromHtml("#1976D2"),
                    Location = new Point(10, 140),
                    Size = new Size(160, 20),
                    Text = $"${service.Price}",
                    TextAlign = ContentAlignment.MiddleCenter
                };

                servicePanel.Controls.Add(pictureBox);
                servicePanel.Controls.Add(lblName);
                servicePanel.Controls.Add(lblPrice);

                // Sự kiện click để thêm dịch vụ vào đơn hàng
                servicePanel.Click += (s, e) => AddServiceToOrder(service);
                pictureBox.Click += (s, e) => AddServiceToOrder(service);
                lblName.Click += (s, e) => AddServiceToOrder(service);
                lblPrice.Click += (s, e) => AddServiceToOrder(service);

                serviceGrid.Controls.Add(servicePanel);
            }
        }
    }

    private void AddServiceToOrder(Service service)
    {
        var existingItem = orderItems.Find(item => item.ServiceId == service.Id);
        if (existingItem != null)
        {
            existingItem.Quantity++;
        }
        else
        {
            orderItems.Add(new OrderItem { ServiceId = service.Id, ServiceName = service.Name, Price = service.Price, Quantity = 1 });
        }

        UpdateOrderGrid();
    }

    private void UpdateOrderGrid()
    {
        dgvOrder.Rows.Clear();
        decimal total = 0;

        foreach (var item in orderItems)
        {
            decimal itemTotal = item.Price * item.Quantity;
            dgvOrder.Rows.Add(item.ServiceName, item.Quantity, item.Price, itemTotal);
            total += itemTotal;
        }

        lblTotal.Text = $"Total: ${total}";
    }

    private void BtnConfirmOrder_Click(object sender, EventArgs e)
    {
        if (orderItems.Count == 0)
        {
            MessageBox.Show("Please add at least one service to the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Giả lập xác nhận đơn hàng - thay bằng lưu vào cơ sở dữ liệu
        MessageBox.Show("Order confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        orderItems.Clear();
        UpdateOrderGrid();
    }

    private void BtnRemoveService_Click(object sender, EventArgs e)
    {
        if (dgvOrder.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a service to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var selectedRow = dgvOrder.SelectedRows[0];
        string serviceName = selectedRow.Cells["ServiceName"].Value.ToString();
        var item = orderItems.Find(i => i.ServiceName == serviceName);
        if (item != null)
        {
            orderItems.Remove(item);
        }

        UpdateOrderGrid();
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

    private class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
    }

    private class OrderItem
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    private void orderPanel_Paint(object sender, PaintEventArgs e)
    {

    }
}