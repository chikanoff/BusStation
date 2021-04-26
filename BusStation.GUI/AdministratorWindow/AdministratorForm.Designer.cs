
namespace BusStation.GUI.AdministratorWindow
{
    partial class AdministratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.usersTabPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.addIsAdminComboBox = new System.Windows.Forms.ComboBox();
            this.addPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addLoginTextBox = new System.Windows.Forms.TextBox();
            this.userAddButton = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.tripTabPage = new System.Windows.Forms.TabPage();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addBusComboBox = new System.Windows.Forms.ComboBox();
            this.addRouteComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addTripButton = new System.Windows.Forms.Button();
            this.tripDataGridView = new System.Windows.Forms.DataGridView();
            this.routesTabPage = new System.Windows.Forms.TabPage();
            this.addRouteTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addRouteButton = new System.Windows.Forms.Button();
            this.routeDataGridView = new System.Windows.Forms.DataGridView();
            this.busesTabPage = new System.Windows.Forms.TabPage();
            this.addCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addCapacityTextBox = new System.Windows.Forms.TextBox();
            this.addBusButton = new System.Windows.Forms.Button();
            this.busDataGridView = new System.Windows.Forms.DataGridView();
            this.stopsTabPage = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.addStopNameTextBox = new System.Windows.Forms.TextBox();
            this.addStopButton = new System.Windows.Forms.Button();
            this.stopDataGridView = new System.Windows.Forms.DataGridView();
            this.routeStopsTabPage = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.addDistanceTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.addRouteForRSComboBox = new System.Windows.Forms.ComboBox();
            this.addStopForRSComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.addStopNumberTextBox = new System.Windows.Forms.TextBox();
            this.addRouteStopButton = new System.Windows.Forms.Button();
            this.routeStopDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.addPriceTextBox = new System.Windows.Forms.TextBox();
            this.addEndPointTComboBox = new System.Windows.Forms.ComboBox();
            this.addStartPointTComboBox = new System.Windows.Forms.ComboBox();
            this.addTripTComboBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.addTicektButton = new System.Windows.Forms.Button();
            this.ticketDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.usersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.tripTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tripDataGridView)).BeginInit();
            this.routesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeDataGridView)).BeginInit();
            this.busesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busDataGridView)).BeginInit();
            this.stopsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopDataGridView)).BeginInit();
            this.routeStopsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeStopDataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.usersTabPage);
            this.tabControl.Controls.Add(this.tripTabPage);
            this.tabControl.Controls.Add(this.routesTabPage);
            this.tabControl.Controls.Add(this.busesTabPage);
            this.tabControl.Controls.Add(this.stopsTabPage);
            this.tabControl.Controls.Add(this.routeStopsTabPage);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(930, 477);
            this.tabControl.TabIndex = 0;
            // 
            // usersTabPage
            // 
            this.usersTabPage.Controls.Add(this.label3);
            this.usersTabPage.Controls.Add(this.addIsAdminComboBox);
            this.usersTabPage.Controls.Add(this.addPasswordTextBox);
            this.usersTabPage.Controls.Add(this.label2);
            this.usersTabPage.Controls.Add(this.label1);
            this.usersTabPage.Controls.Add(this.addLoginTextBox);
            this.usersTabPage.Controls.Add(this.userAddButton);
            this.usersTabPage.Controls.Add(this.userDataGridView);
            this.usersTabPage.Location = new System.Drawing.Point(4, 24);
            this.usersTabPage.Name = "usersTabPage";
            this.usersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.usersTabPage.Size = new System.Drawing.Size(922, 449);
            this.usersTabPage.TabIndex = 0;
            this.usersTabPage.Text = "Пользователи";
            this.usersTabPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(678, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Досутп администратора";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addIsAdminComboBox
            // 
            this.addIsAdminComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addIsAdminComboBox.FormattingEnabled = true;
            this.addIsAdminComboBox.Location = new System.Drawing.Point(678, 127);
            this.addIsAdminComboBox.Name = "addIsAdminComboBox";
            this.addIsAdminComboBox.Size = new System.Drawing.Size(239, 23);
            this.addIsAdminComboBox.TabIndex = 6;
            // 
            // addPasswordTextBox
            // 
            this.addPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPasswordTextBox.Location = new System.Drawing.Point(678, 77);
            this.addPasswordTextBox.Name = "addPasswordTextBox";
            this.addPasswordTextBox.Size = new System.Drawing.Size(239, 23);
            this.addPasswordTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(678, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(678, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addLoginTextBox
            // 
            this.addLoginTextBox.Location = new System.Drawing.Point(678, 27);
            this.addLoginTextBox.Name = "addLoginTextBox";
            this.addLoginTextBox.Size = new System.Drawing.Size(240, 23);
            this.addLoginTextBox.TabIndex = 2;
            // 
            // userAddButton
            // 
            this.userAddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userAddButton.Location = new System.Drawing.Point(680, 395);
            this.userAddButton.Name = "userAddButton";
            this.userAddButton.Size = new System.Drawing.Size(238, 41);
            this.userAddButton.TabIndex = 1;
            this.userAddButton.Text = "Добавить пользователя";
            this.userAddButton.UseVisualStyleBackColor = true;
            this.userAddButton.Click += new System.EventHandler(this.userAddButton_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(3, 3);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowTemplate.Height = 25;
            this.userDataGridView.Size = new System.Drawing.Size(668, 433);
            this.userDataGridView.TabIndex = 0;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDataGridView_CellContentClick);
            // 
            // tripTabPage
            // 
            this.tripTabPage.Controls.Add(this.dateTimePicker);
            this.tripTabPage.Controls.Add(this.addBusComboBox);
            this.tripTabPage.Controls.Add(this.addRouteComboBox);
            this.tripTabPage.Controls.Add(this.label7);
            this.tripTabPage.Controls.Add(this.label8);
            this.tripTabPage.Controls.Add(this.label9);
            this.tripTabPage.Controls.Add(this.addTripButton);
            this.tripTabPage.Controls.Add(this.tripDataGridView);
            this.tripTabPage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tripTabPage.Location = new System.Drawing.Point(4, 24);
            this.tripTabPage.Name = "tripTabPage";
            this.tripTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tripTabPage.Size = new System.Drawing.Size(922, 449);
            this.tripTabPage.TabIndex = 1;
            this.tripTabPage.Text = "Поездки";
            this.tripTabPage.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "\"dd.mm.yyyy\"";
            this.dateTimePicker.Location = new System.Drawing.Point(678, 127);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(240, 23);
            this.dateTimePicker.TabIndex = 18;
            // 
            // addBusComboBox
            // 
            this.addBusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBusComboBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addBusComboBox.FormattingEnabled = true;
            this.addBusComboBox.Location = new System.Drawing.Point(678, 77);
            this.addBusComboBox.Name = "addBusComboBox";
            this.addBusComboBox.Size = new System.Drawing.Size(240, 23);
            this.addBusComboBox.TabIndex = 17;
            // 
            // addRouteComboBox
            // 
            this.addRouteComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addRouteComboBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addRouteComboBox.FormattingEnabled = true;
            this.addRouteComboBox.Location = new System.Drawing.Point(678, 27);
            this.addRouteComboBox.Name = "addRouteComboBox";
            this.addRouteComboBox.Size = new System.Drawing.Size(240, 23);
            this.addRouteComboBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(678, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(678, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Номер автобуса";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(678, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Маршрут";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addTripButton
            // 
            this.addTripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTripButton.Location = new System.Drawing.Point(678, 395);
            this.addTripButton.Name = "addTripButton";
            this.addTripButton.Size = new System.Drawing.Size(238, 41);
            this.addTripButton.TabIndex = 9;
            this.addTripButton.Text = "Добавить поездку";
            this.addTripButton.UseVisualStyleBackColor = true;
            this.addTripButton.Click += new System.EventHandler(this.addTripButton_Click);
            // 
            // tripDataGridView
            // 
            this.tripDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tripDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tripDataGridView.Location = new System.Drawing.Point(3, 3);
            this.tripDataGridView.Name = "tripDataGridView";
            this.tripDataGridView.RowTemplate.Height = 25;
            this.tripDataGridView.Size = new System.Drawing.Size(669, 433);
            this.tripDataGridView.TabIndex = 8;
            this.tripDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tripDataGridView_CellContentClick);
            this.tripDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.tripDataGridView_DataError);
            // 
            // routesTabPage
            // 
            this.routesTabPage.Controls.Add(this.addRouteTextBox);
            this.routesTabPage.Controls.Add(this.label12);
            this.routesTabPage.Controls.Add(this.addRouteButton);
            this.routesTabPage.Controls.Add(this.routeDataGridView);
            this.routesTabPage.Location = new System.Drawing.Point(4, 24);
            this.routesTabPage.Name = "routesTabPage";
            this.routesTabPage.Size = new System.Drawing.Size(922, 449);
            this.routesTabPage.TabIndex = 2;
            this.routesTabPage.Text = "Маршруты";
            this.routesTabPage.UseVisualStyleBackColor = true;
            // 
            // addRouteTextBox
            // 
            this.addRouteTextBox.Location = new System.Drawing.Point(680, 27);
            this.addRouteTextBox.Name = "addRouteTextBox";
            this.addRouteTextBox.Size = new System.Drawing.Size(238, 23);
            this.addRouteTextBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Location = new System.Drawing.Point(680, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(240, 21);
            this.label12.TabIndex = 21;
            this.label12.Text = "Маршрут";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addRouteButton
            // 
            this.addRouteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addRouteButton.Location = new System.Drawing.Point(680, 395);
            this.addRouteButton.Name = "addRouteButton";
            this.addRouteButton.Size = new System.Drawing.Size(238, 41);
            this.addRouteButton.TabIndex = 20;
            this.addRouteButton.Text = "Добавить маршрут";
            this.addRouteButton.UseVisualStyleBackColor = true;
            this.addRouteButton.Click += new System.EventHandler(this.addRouteButton_Click);
            // 
            // routeDataGridView
            // 
            this.routeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.routeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routeDataGridView.Location = new System.Drawing.Point(4, 3);
            this.routeDataGridView.Name = "routeDataGridView";
            this.routeDataGridView.RowTemplate.Height = 25;
            this.routeDataGridView.Size = new System.Drawing.Size(670, 433);
            this.routeDataGridView.TabIndex = 19;
            // 
            // busesTabPage
            // 
            this.busesTabPage.Controls.Add(this.addCategoryComboBox);
            this.busesTabPage.Controls.Add(this.label11);
            this.busesTabPage.Controls.Add(this.label10);
            this.busesTabPage.Controls.Add(this.addCapacityTextBox);
            this.busesTabPage.Controls.Add(this.addBusButton);
            this.busesTabPage.Controls.Add(this.busDataGridView);
            this.busesTabPage.Location = new System.Drawing.Point(4, 24);
            this.busesTabPage.Name = "busesTabPage";
            this.busesTabPage.Size = new System.Drawing.Size(922, 449);
            this.busesTabPage.TabIndex = 3;
            this.busesTabPage.Text = "Автобусы";
            this.busesTabPage.UseVisualStyleBackColor = true;
            // 
            // addCategoryComboBox
            // 
            this.addCategoryComboBox.FormattingEnabled = true;
            this.addCategoryComboBox.Location = new System.Drawing.Point(678, 77);
            this.addCategoryComboBox.Name = "addCategoryComboBox";
            this.addCategoryComboBox.Size = new System.Drawing.Size(240, 23);
            this.addCategoryComboBox.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Location = new System.Drawing.Point(678, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(240, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "Вид трансопрта";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Location = new System.Drawing.Point(680, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 21);
            this.label10.TabIndex = 26;
            this.label10.Text = "Вместимость";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addCapacityTextBox
            // 
            this.addCapacityTextBox.Location = new System.Drawing.Point(680, 27);
            this.addCapacityTextBox.Name = "addCapacityTextBox";
            this.addCapacityTextBox.Size = new System.Drawing.Size(238, 23);
            this.addCapacityTextBox.TabIndex = 25;
            // 
            // addBusButton
            // 
            this.addBusButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBusButton.Location = new System.Drawing.Point(678, 395);
            this.addBusButton.Name = "addBusButton";
            this.addBusButton.Size = new System.Drawing.Size(238, 41);
            this.addBusButton.TabIndex = 24;
            this.addBusButton.Text = "Добавить автобус";
            this.addBusButton.UseVisualStyleBackColor = true;
            this.addBusButton.Click += new System.EventHandler(this.addBusButton_Click);
            // 
            // busDataGridView
            // 
            this.busDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.busDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busDataGridView.Location = new System.Drawing.Point(5, 3);
            this.busDataGridView.Name = "busDataGridView";
            this.busDataGridView.RowTemplate.Height = 25;
            this.busDataGridView.Size = new System.Drawing.Size(667, 433);
            this.busDataGridView.TabIndex = 23;
            this.busDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.busDataGridView_CellContentClick);
            // 
            // stopsTabPage
            // 
            this.stopsTabPage.Controls.Add(this.label14);
            this.stopsTabPage.Controls.Add(this.addStopNameTextBox);
            this.stopsTabPage.Controls.Add(this.addStopButton);
            this.stopsTabPage.Controls.Add(this.stopDataGridView);
            this.stopsTabPage.Location = new System.Drawing.Point(4, 24);
            this.stopsTabPage.Name = "stopsTabPage";
            this.stopsTabPage.Size = new System.Drawing.Size(922, 449);
            this.stopsTabPage.TabIndex = 4;
            this.stopsTabPage.Text = "Остановки";
            this.stopsTabPage.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Location = new System.Drawing.Point(680, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(240, 21);
            this.label14.TabIndex = 32;
            this.label14.Text = "Название";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addStopNameTextBox
            // 
            this.addStopNameTextBox.Location = new System.Drawing.Point(680, 27);
            this.addStopNameTextBox.Name = "addStopNameTextBox";
            this.addStopNameTextBox.Size = new System.Drawing.Size(238, 23);
            this.addStopNameTextBox.TabIndex = 31;
            // 
            // addStopButton
            // 
            this.addStopButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addStopButton.Location = new System.Drawing.Point(680, 395);
            this.addStopButton.Name = "addStopButton";
            this.addStopButton.Size = new System.Drawing.Size(238, 41);
            this.addStopButton.TabIndex = 30;
            this.addStopButton.Text = "Добавить остановку";
            this.addStopButton.UseVisualStyleBackColor = true;
            this.addStopButton.Click += new System.EventHandler(this.addStopButton_Click);
            // 
            // stopDataGridView
            // 
            this.stopDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stopDataGridView.Location = new System.Drawing.Point(4, 3);
            this.stopDataGridView.Name = "stopDataGridView";
            this.stopDataGridView.RowTemplate.Height = 25;
            this.stopDataGridView.Size = new System.Drawing.Size(670, 433);
            this.stopDataGridView.TabIndex = 29;
            this.stopDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StopDataGridView_CellContentClick);
            // 
            // routeStopsTabPage
            // 
            this.routeStopsTabPage.Controls.Add(this.label17);
            this.routeStopsTabPage.Controls.Add(this.addDistanceTextBox);
            this.routeStopsTabPage.Controls.Add(this.label16);
            this.routeStopsTabPage.Controls.Add(this.addRouteForRSComboBox);
            this.routeStopsTabPage.Controls.Add(this.addStopForRSComboBox);
            this.routeStopsTabPage.Controls.Add(this.label13);
            this.routeStopsTabPage.Controls.Add(this.label15);
            this.routeStopsTabPage.Controls.Add(this.addStopNumberTextBox);
            this.routeStopsTabPage.Controls.Add(this.addRouteStopButton);
            this.routeStopsTabPage.Controls.Add(this.routeStopDataGridView);
            this.routeStopsTabPage.Location = new System.Drawing.Point(4, 24);
            this.routeStopsTabPage.Name = "routeStopsTabPage";
            this.routeStopsTabPage.Size = new System.Drawing.Size(922, 449);
            this.routeStopsTabPage.TabIndex = 5;
            this.routeStopsTabPage.Text = "Остановки в маршрутах";
            this.routeStopsTabPage.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Location = new System.Drawing.Point(678, 153);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(240, 21);
            this.label17.TabIndex = 37;
            this.label17.Text = "Раcстояние от начала маршрута";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addDistanceTextBox
            // 
            this.addDistanceTextBox.Location = new System.Drawing.Point(682, 177);
            this.addDistanceTextBox.Name = "addDistanceTextBox";
            this.addDistanceTextBox.Size = new System.Drawing.Size(238, 23);
            this.addDistanceTextBox.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.Location = new System.Drawing.Point(680, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(240, 21);
            this.label16.TabIndex = 34;
            this.label16.Text = "Количество остановок";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addRouteForRSComboBox
            // 
            this.addRouteForRSComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.addRouteForRSComboBox.FormattingEnabled = true;
            this.addRouteForRSComboBox.Location = new System.Drawing.Point(680, 27);
            this.addRouteForRSComboBox.Name = "addRouteForRSComboBox";
            this.addRouteForRSComboBox.Size = new System.Drawing.Size(240, 23);
            this.addRouteForRSComboBox.TabIndex = 35;
            // 
            // addStopForRSComboBox
            // 
            this.addStopForRSComboBox.FormattingEnabled = true;
            this.addStopForRSComboBox.Location = new System.Drawing.Point(680, 77);
            this.addStopForRSComboBox.Name = "addStopForRSComboBox";
            this.addStopForRSComboBox.Size = new System.Drawing.Size(240, 23);
            this.addStopForRSComboBox.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Location = new System.Drawing.Point(680, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(240, 21);
            this.label13.TabIndex = 33;
            this.label13.Text = "Остановка";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.Location = new System.Drawing.Point(680, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(240, 21);
            this.label15.TabIndex = 32;
            this.label15.Text = "Маршрут";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addStopNumberTextBox
            // 
            this.addStopNumberTextBox.Location = new System.Drawing.Point(680, 127);
            this.addStopNumberTextBox.Name = "addStopNumberTextBox";
            this.addStopNumberTextBox.Size = new System.Drawing.Size(238, 23);
            this.addStopNumberTextBox.TabIndex = 31;
            // 
            // addRouteStopButton
            // 
            this.addRouteStopButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addRouteStopButton.Location = new System.Drawing.Point(678, 381);
            this.addRouteStopButton.Name = "addRouteStopButton";
            this.addRouteStopButton.Size = new System.Drawing.Size(238, 55);
            this.addRouteStopButton.TabIndex = 30;
            this.addRouteStopButton.Text = "Добавить остановку в маршруте";
            this.addRouteStopButton.UseVisualStyleBackColor = true;
            this.addRouteStopButton.Click += new System.EventHandler(this.addRouteStopButton_Click);
            // 
            // routeStopDataGridView
            // 
            this.routeStopDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.routeStopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routeStopDataGridView.Location = new System.Drawing.Point(4, 3);
            this.routeStopDataGridView.Name = "routeStopDataGridView";
            this.routeStopDataGridView.RowTemplate.Height = 25;
            this.routeStopDataGridView.Size = new System.Drawing.Size(668, 433);
            this.routeStopDataGridView.TabIndex = 29;
            this.routeStopDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.routeStopDataGridView_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.addPriceTextBox);
            this.tabPage1.Controls.Add(this.addEndPointTComboBox);
            this.tabPage1.Controls.Add(this.addStartPointTComboBox);
            this.tabPage1.Controls.Add(this.addTripTComboBox);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.addTicektButton);
            this.tabPage1.Controls.Add(this.ticketDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(922, 449);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Билеты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.Location = new System.Drawing.Point(677, 158);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(240, 21);
            this.label21.TabIndex = 28;
            this.label21.Text = "Цена";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addPriceTextBox
            // 
            this.addPriceTextBox.Location = new System.Drawing.Point(681, 182);
            this.addPriceTextBox.Name = "addPriceTextBox";
            this.addPriceTextBox.Size = new System.Drawing.Size(238, 23);
            this.addPriceTextBox.TabIndex = 27;
            // 
            // addEndPointTComboBox
            // 
            this.addEndPointTComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addEndPointTComboBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addEndPointTComboBox.FormattingEnabled = true;
            this.addEndPointTComboBox.Location = new System.Drawing.Point(679, 132);
            this.addEndPointTComboBox.Name = "addEndPointTComboBox";
            this.addEndPointTComboBox.Size = new System.Drawing.Size(240, 23);
            this.addEndPointTComboBox.TabIndex = 26;
            // 
            // addStartPointTComboBox
            // 
            this.addStartPointTComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addStartPointTComboBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addStartPointTComboBox.FormattingEnabled = true;
            this.addStartPointTComboBox.Location = new System.Drawing.Point(679, 82);
            this.addStartPointTComboBox.Name = "addStartPointTComboBox";
            this.addStartPointTComboBox.Size = new System.Drawing.Size(240, 23);
            this.addStartPointTComboBox.TabIndex = 25;
            // 
            // addTripTComboBox
            // 
            this.addTripTComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addTripTComboBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addTripTComboBox.FormattingEnabled = true;
            this.addTripTComboBox.Location = new System.Drawing.Point(679, 32);
            this.addTripTComboBox.Name = "addTripTComboBox";
            this.addTripTComboBox.Size = new System.Drawing.Size(240, 23);
            this.addTripTComboBox.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.Location = new System.Drawing.Point(679, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(240, 21);
            this.label18.TabIndex = 23;
            this.label18.Text = "Пункт прибытия";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.Location = new System.Drawing.Point(679, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(240, 21);
            this.label19.TabIndex = 22;
            this.label19.Text = "Пункт отправления";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.Location = new System.Drawing.Point(679, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(240, 21);
            this.label20.TabIndex = 21;
            this.label20.Text = "Поездка";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addTicektButton
            // 
            this.addTicektButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTicektButton.Location = new System.Drawing.Point(679, 400);
            this.addTicektButton.Name = "addTicektButton";
            this.addTicektButton.Size = new System.Drawing.Size(238, 41);
            this.addTicektButton.TabIndex = 20;
            this.addTicektButton.Text = "Добавить билет";
            this.addTicektButton.UseVisualStyleBackColor = true;
            this.addTicektButton.Click += new System.EventHandler(this.addTicektButton_Click);
            // 
            // ticketDataGridView
            // 
            this.ticketDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketDataGridView.Location = new System.Drawing.Point(4, 3);
            this.ticketDataGridView.Name = "ticketDataGridView";
            this.ticketDataGridView.RowTemplate.Height = 25;
            this.ticketDataGridView.Size = new System.Drawing.Size(669, 433);
            this.ticketDataGridView.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(553, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Досутп администратора";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(557, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 23);
            this.comboBox1.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(555, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 23);
            this.textBox1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(557, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Пароль";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(555, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Логин";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(557, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 23);
            this.textBox2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(555, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить пользователя";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // r
            // 
            this.r.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.r.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.r.Location = new System.Drawing.Point(6, 7);
            this.r.Name = "r";
            this.r.RowTemplate.Height = 25;
            this.r.Size = new System.Drawing.Size(545, 425);
            this.r.TabIndex = 8;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 501);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 350);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно администратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.usersTabPage.ResumeLayout(false);
            this.usersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.tripTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tripDataGridView)).EndInit();
            this.routesTabPage.ResumeLayout(false);
            this.routesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeDataGridView)).EndInit();
            this.busesTabPage.ResumeLayout(false);
            this.busesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busDataGridView)).EndInit();
            this.stopsTabPage.ResumeLayout(false);
            this.stopsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopDataGridView)).EndInit();
            this.routeStopsTabPage.ResumeLayout(false);
            this.routeStopsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeStopDataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage usersTabPage;
        private System.Windows.Forms.TabPage tripTabPage;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Button userAddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addLoginTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tataGridView;
        private System.Windows.Forms.DataGridView r;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addTripButton;
        private System.Windows.Forms.DataGridView tripDataGridView;
        private System.Windows.Forms.DataGridView tr;
        private System.Windows.Forms.ComboBox addIsAdminComboBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox addBusComboBox;
        private System.Windows.Forms.ComboBox addRouteComboBox;
        private System.Windows.Forms.TabPage routesTabPage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button addRouteButton;
        private System.Windows.Forms.DataGridView routeDataGridView;
        private System.Windows.Forms.TextBox addRouteTextBox;
        private System.Windows.Forms.TabPage busesTabPage;
        private System.Windows.Forms.ComboBox addCategoryComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox addCapacityTextBox;
        private System.Windows.Forms.Button addBusButton;
        private System.Windows.Forms.DataGridView busDataGridView;
        private System.Windows.Forms.TabPage stopsTabPage;
        private System.Windows.Forms.TabPage routeStopsTabPage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox addStopNameTextBox;
        private System.Windows.Forms.Button addStopButton;
        private System.Windows.Forms.DataGridView stopDataGridView;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox addDistanceTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox addRouteForRSComboBox;
        private System.Windows.Forms.ComboBox addStopForRSComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox addStopNumberTextBox;
        private System.Windows.Forms.Button addRouteStopButton;
        private System.Windows.Forms.DataGridView routeStopDataGridView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox addStartPointTComboBox;
        private System.Windows.Forms.ComboBox addTripTComboBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button addTicektButton;
        private System.Windows.Forms.DataGridView ticketDataGridView;
        private System.Windows.Forms.ComboBox addEndPointTComboBox;
        private System.Windows.Forms.TextBox addPriceTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button d;
    }
}