namespace CST117_InventoryManagementProgram
{
    partial class SearchScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.temporaryLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.msrpRadioButton = new System.Windows.Forms.RadioButton();
            this.modelRadioButton = new System.Windows.Forms.RadioButton();
            this.quantityRadioButton = new System.Windows.Forms.RadioButton();
            this.typeRadioButton = new System.Windows.Forms.RadioButton();
            this.priceRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.companyLabel = new System.Windows.Forms.Label();
            this.searchDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msrpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // temporaryLabel
            // 
            this.temporaryLabel.AutoSize = true;
            this.temporaryLabel.Location = new System.Drawing.Point(7, 28);
            this.temporaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.temporaryLabel.Name = "temporaryLabel";
            this.temporaryLabel.Size = new System.Drawing.Size(77, 13);
            this.temporaryLabel.TabIndex = 3;
            this.temporaryLabel.Text = "logo goes here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 56);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(10, 566);
            this.viewButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(78, 42);
            this.viewButton.TabIndex = 8;
            this.viewButton.Text = "VIEW";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Visible = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.homeButton.AutoSize = true;
            this.homeButton.Location = new System.Drawing.Point(1165, 34);
            this.homeButton.Margin = new System.Windows.Forms.Padding(2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(78, 42);
            this.homeButton.TabIndex = 11;
            this.homeButton.Text = "HOME";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1080, 566);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(78, 42);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(1162, 566);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(77, 42);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.msrpRadioButton);
            this.searchGroupBox.Controls.Add(this.modelRadioButton);
            this.searchGroupBox.Controls.Add(this.quantityRadioButton);
            this.searchGroupBox.Controls.Add(this.typeRadioButton);
            this.searchGroupBox.Controls.Add(this.priceRadioButton);
            this.searchGroupBox.Controls.Add(this.nameRadioButton);
            this.searchGroupBox.Location = new System.Drawing.Point(249, 99);
            this.searchGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.searchGroupBox.Size = new System.Drawing.Size(768, 65);
            this.searchGroupBox.TabIndex = 12;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search By";
            this.searchGroupBox.Enter += new System.EventHandler(this.searchGroupBox_Enter);
            // 
            // msrpRadioButton
            // 
            this.msrpRadioButton.AutoSize = true;
            this.msrpRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.msrpRadioButton.Location = new System.Drawing.Point(384, 26);
            this.msrpRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.msrpRadioButton.Name = "msrpRadioButton";
            this.msrpRadioButton.Size = new System.Drawing.Size(94, 30);
            this.msrpRadioButton.TabIndex = 5;
            this.msrpRadioButton.TabStop = true;
            this.msrpRadioButton.Text = "MSRP";
            this.msrpRadioButton.UseVisualStyleBackColor = true;
            // 
            // modelRadioButton
            // 
            this.modelRadioButton.AutoSize = true;
            this.modelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.modelRadioButton.Location = new System.Drawing.Point(142, 26);
            this.modelRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.modelRadioButton.Name = "modelRadioButton";
            this.modelRadioButton.Size = new System.Drawing.Size(108, 30);
            this.modelRadioButton.TabIndex = 4;
            this.modelRadioButton.TabStop = true;
            this.modelRadioButton.Text = "MODEL";
            this.modelRadioButton.UseVisualStyleBackColor = true;
            // 
            // quantityRadioButton
            // 
            this.quantityRadioButton.AutoSize = true;
            this.quantityRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.quantityRadioButton.Location = new System.Drawing.Point(622, 26);
            this.quantityRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.quantityRadioButton.Name = "quantityRadioButton";
            this.quantityRadioButton.Size = new System.Drawing.Size(140, 30);
            this.quantityRadioButton.TabIndex = 3;
            this.quantityRadioButton.TabStop = true;
            this.quantityRadioButton.Text = "QUANTITY";
            this.quantityRadioButton.UseVisualStyleBackColor = true;
            this.quantityRadioButton.CheckedChanged += new System.EventHandler(this.quantityRadioButton_CheckedChanged);
            // 
            // typeRadioButton
            // 
            this.typeRadioButton.AutoSize = true;
            this.typeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.typeRadioButton.Location = new System.Drawing.Point(273, 26);
            this.typeRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.typeRadioButton.Name = "typeRadioButton";
            this.typeRadioButton.Size = new System.Drawing.Size(88, 30);
            this.typeRadioButton.TabIndex = 2;
            this.typeRadioButton.TabStop = true;
            this.typeRadioButton.Text = "TYPE";
            this.typeRadioButton.UseVisualStyleBackColor = true;
            // 
            // priceRadioButton
            // 
            this.priceRadioButton.AutoSize = true;
            this.priceRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.priceRadioButton.Location = new System.Drawing.Point(501, 26);
            this.priceRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.priceRadioButton.Name = "priceRadioButton";
            this.priceRadioButton.Size = new System.Drawing.Size(98, 30);
            this.priceRadioButton.TabIndex = 1;
            this.priceRadioButton.TabStop = true;
            this.priceRadioButton.Text = "PRICE";
            this.priceRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Checked = true;
            this.nameRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameRadioButton.Location = new System.Drawing.Point(25, 26);
            this.nameRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(94, 30);
            this.nameRadioButton.TabIndex = 0;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "NAME";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.searchLabel.Location = new System.Drawing.Point(244, 189);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(103, 26);
            this.searchLabel.TabIndex = 14;
            this.searchLabel.Text = "Keyword:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.searchTextBox.Location = new System.Drawing.Point(347, 187);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(481, 32);
            this.searchTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.searchButton.Location = new System.Drawing.Point(899, 187);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(117, 32);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Lucida Handwriting", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.companyLabel.Location = new System.Drawing.Point(173, 8);
            this.companyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(930, 48);
            this.companyLabel.TabIndex = 53;
            this.companyLabel.Text = "WILSON\'S ELECTRONICS INVENTORY SEARCH";
            // 
            // searchDataGrid
            // 
            this.searchDataGrid.AllowUserToAddRows = false;
            this.searchDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.searchDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.searchDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.searchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.modelColumn,
            this.typeColumn,
            this.quantityColumn,
            this.msrpColumn,
            this.priceColumn,
            this.InventoryItem});
            this.searchDataGrid.DoubleBuffered = true;
            this.searchDataGrid.EnableHeadersVisualStyles = false;
            this.searchDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.searchDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.searchDataGrid.Location = new System.Drawing.Point(249, 238);
            this.searchDataGrid.MultiSelect = false;
            this.searchDataGrid.Name = "searchDataGrid";
            this.searchDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.searchDataGrid.RowHeadersVisible = false;
            this.searchDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchDataGrid.Size = new System.Drawing.Size(767, 359);
            this.searchDataGrid.TabIndex = 57;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            // 
            // modelColumn
            // 
            this.modelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modelColumn.HeaderText = "Model";
            this.modelColumn.Name = "modelColumn";
            // 
            // typeColumn
            // 
            this.typeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Name = "typeColumn";
            // 
            // quantityColumn
            // 
            this.quantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.quantityColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.Name = "quantityColumn";
            // 
            // msrpColumn
            // 
            this.msrpColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.msrpColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.msrpColumn.HeaderText = "MSRP";
            this.msrpColumn.Name = "msrpColumn";
            // 
            // priceColumn
            // 
            this.priceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Format = "C2";
            this.priceColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            // 
            // InventoryItem
            // 
            this.InventoryItem.HeaderText = "InventoryItem";
            this.InventoryItem.Name = "InventoryItem";
            this.InventoryItem.Visible = false;
            // 
            // SearchScreen
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1265, 666);
            this.Controls.Add(this.searchDataGrid);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.temporaryLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SearchScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Screen";
            this.Load += new System.EventHandler(this.SearchScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label temporaryLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.RadioButton quantityRadioButton;
        private System.Windows.Forms.RadioButton typeRadioButton;
        private System.Windows.Forms.RadioButton priceRadioButton;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.RadioButton modelRadioButton;
        private System.Windows.Forms.RadioButton msrpRadioButton;
        private Bunifu.Framework.UI.BunifuCustomDataGrid searchDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msrpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryItem;
    }
}