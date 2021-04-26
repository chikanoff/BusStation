
namespace BusStation.GUI.GuestWindow
{
    partial class GuestForm
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
            this.ticketDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.startStopComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.endStopComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketDataGridView
            // 
            this.ticketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ticketDataGridView.Name = "ticketDataGridView";
            this.ticketDataGridView.RowTemplate.Height = 25;
            this.ticketDataGridView.Size = new System.Drawing.Size(748, 477);
            this.ticketDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(767, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пункт отправления";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startStopComboBox
            // 
            this.startStopComboBox.FormattingEnabled = true;
            this.startStopComboBox.Location = new System.Drawing.Point(767, 38);
            this.startStopComboBox.Name = "startStopComboBox";
            this.startStopComboBox.Size = new System.Drawing.Size(175, 23);
            this.startStopComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(766, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пункт прибытия";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endStopComboBox
            // 
            this.endStopComboBox.FormattingEnabled = true;
            this.endStopComboBox.Location = new System.Drawing.Point(767, 90);
            this.endStopComboBox.Name = "endStopComboBox";
            this.endStopComboBox.Size = new System.Drawing.Size(175, 23);
            this.endStopComboBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(766, 423);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(176, 30);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(766, 459);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(176, 30);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Сбросить поиск";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 501);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.endStopComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startStopComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно гостя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuestForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ticketDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox startStopComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox endStopComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button resetButton;
    }
}