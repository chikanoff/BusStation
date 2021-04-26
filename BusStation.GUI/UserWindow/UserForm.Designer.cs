
namespace BusStation.GUI.UserWindow
{
    partial class UserForm
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
            this.ticketsTabPage = new System.Windows.Forms.TabPage();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.endStopComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startStopComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketDataGridView = new System.Windows.Forms.DataGridView();
            this.userTicketsTabPage = new System.Windows.Forms.TabPage();
            this.userTicketsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.ticketsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).BeginInit();
            this.userTicketsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTicketsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ticketsTabPage);
            this.tabControl.Controls.Add(this.userTicketsTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(930, 477);
            this.tabControl.TabIndex = 0;
            // 
            // ticketsTabPage
            // 
            this.ticketsTabPage.Controls.Add(this.dateTimePicker);
            this.ticketsTabPage.Controls.Add(this.label3);
            this.ticketsTabPage.Controls.Add(this.buyButton);
            this.ticketsTabPage.Controls.Add(this.endStopComboBox);
            this.ticketsTabPage.Controls.Add(this.label2);
            this.ticketsTabPage.Controls.Add(this.startStopComboBox);
            this.ticketsTabPage.Controls.Add(this.label1);
            this.ticketsTabPage.Controls.Add(this.ticketDataGridView);
            this.ticketsTabPage.Location = new System.Drawing.Point(4, 24);
            this.ticketsTabPage.Name = "ticketsTabPage";
            this.ticketsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ticketsTabPage.Size = new System.Drawing.Size(922, 449);
            this.ticketsTabPage.TabIndex = 0;
            this.ticketsTabPage.Text = "Билеты";
            this.ticketsTabPage.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(743, 31);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(175, 23);
            this.dateTimePicker.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(743, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(743, 416);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(176, 30);
            this.buyButton.TabIndex = 12;
            this.buyButton.Text = "Купить";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // endStopComboBox
            // 
            this.endStopComboBox.FormattingEnabled = true;
            this.endStopComboBox.Location = new System.Drawing.Point(743, 135);
            this.endStopComboBox.Name = "endStopComboBox";
            this.endStopComboBox.Size = new System.Drawing.Size(175, 23);
            this.endStopComboBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(743, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пункт прибытия";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startStopComboBox
            // 
            this.startStopComboBox.FormattingEnabled = true;
            this.startStopComboBox.Location = new System.Drawing.Point(743, 83);
            this.startStopComboBox.Name = "startStopComboBox";
            this.startStopComboBox.Size = new System.Drawing.Size(175, 23);
            this.startStopComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(743, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Пункт отправления";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ticketDataGridView
            // 
            this.ticketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ticketDataGridView.Name = "ticketDataGridView";
            this.ticketDataGridView.RowTemplate.Height = 25;
            this.ticketDataGridView.Size = new System.Drawing.Size(734, 443);
            this.ticketDataGridView.TabIndex = 7;
            // 
            // userTicketsTabPage
            // 
            this.userTicketsTabPage.Controls.Add(this.userTicketsDataGridView);
            this.userTicketsTabPage.Location = new System.Drawing.Point(4, 24);
            this.userTicketsTabPage.Name = "userTicketsTabPage";
            this.userTicketsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userTicketsTabPage.Size = new System.Drawing.Size(922, 449);
            this.userTicketsTabPage.TabIndex = 1;
            this.userTicketsTabPage.Text = "Купленные билеты";
            this.userTicketsTabPage.UseVisualStyleBackColor = true;
            // 
            // userTicketsDataGridView
            // 
            this.userTicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTicketsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.userTicketsDataGridView.Name = "userTicketsDataGridView";
            this.userTicketsDataGridView.RowTemplate.Height = 25;
            this.userTicketsDataGridView.Size = new System.Drawing.Size(916, 443);
            this.userTicketsDataGridView.TabIndex = 8;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 501);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно пользователя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.ticketsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).EndInit();
            this.userTicketsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userTicketsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ticketsTabPage;
        private System.Windows.Forms.TabPage userTicketsTabPage;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.ComboBox endStopComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox startStopComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ticketDataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView userTicketsDataGridView;
    }
}