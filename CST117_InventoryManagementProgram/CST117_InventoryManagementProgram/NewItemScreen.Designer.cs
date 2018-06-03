namespace CST117_InventoryManagementProgram
{
    partial class NewItemScreen
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.temporaryLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.companyLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.msrpLabel = new System.Windows.Forms.Label();
            this.msrpUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msrpUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.AutoSize = true;
            this.saveButton.Location = new System.Drawing.Point(286, 560);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 42);
            this.saveButton.TabIndex = 51;
            this.saveButton.Text = "SAVE NEW ITEM";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.AutoSize = true;
            this.cancelButton.Location = new System.Drawing.Point(121, 560);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(78, 42);
            this.cancelButton.TabIndex = 50;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.typeTextBox.Location = new System.Drawing.Point(121, 265);
            this.typeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(268, 32);
            this.typeTextBox.TabIndex = 47;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameTextBox.Location = new System.Drawing.Point(121, 177);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(268, 32);
            this.nameTextBox.TabIndex = 44;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.modelLabel.Location = new System.Drawing.Point(16, 224);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(77, 26);
            this.modelLabel.TabIndex = 43;
            this.modelLabel.Text = "Model:";
            this.modelLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.typeLabel.Location = new System.Drawing.Point(16, 268);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(65, 26);
            this.typeLabel.TabIndex = 42;
            this.typeLabel.Text = "Type:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.quantityLabel.Location = new System.Drawing.Point(16, 312);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(99, 26);
            this.quantityLabel.TabIndex = 41;
            this.quantityLabel.Text = "Quantity:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.priceLabel.Location = new System.Drawing.Point(16, 400);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(68, 26);
            this.priceLabel.TabIndex = 40;
            this.priceLabel.Text = "Price:";
            this.priceLabel.Click += new System.EventHandler(this.priceLabel_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameLabel.Location = new System.Drawing.Point(16, 180);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(77, 26);
            this.nameLabel.TabIndex = 39;
            this.nameLabel.Text = "Name:";
            // 
            // homeButton
            // 
            this.homeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.homeButton.AutoSize = true;
            this.homeButton.Location = new System.Drawing.Point(1179, 25);
            this.homeButton.Margin = new System.Windows.Forms.Padding(2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(78, 42);
            this.homeButton.TabIndex = 35;
            this.homeButton.Text = "HOME";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // temporaryLabel
            // 
            this.temporaryLabel.AutoSize = true;
            this.temporaryLabel.Location = new System.Drawing.Point(7, 28);
            this.temporaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.temporaryLabel.Name = "temporaryLabel";
            this.temporaryLabel.Size = new System.Drawing.Size(77, 13);
            this.temporaryLabel.TabIndex = 34;
            this.temporaryLabel.Text = "logo goes here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 56);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1095, 560);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(78, 42);
            this.logoutButton.TabIndex = 32;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(1177, 560);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(77, 42);
            this.exitButton.TabIndex = 31;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Lucida Handwriting", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.companyLabel.Location = new System.Drawing.Point(223, 8);
            this.companyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(829, 48);
            this.companyLabel.TabIndex = 52;
            this.companyLabel.Text = "WILSON\'S ELECTRONICS ADD NEW ITEM";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.modelTextBox.Location = new System.Drawing.Point(121, 221);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(268, 32);
            this.modelTextBox.TabIndex = 53;
            // 
            // msrpLabel
            // 
            this.msrpLabel.AutoSize = true;
            this.msrpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.msrpLabel.Location = new System.Drawing.Point(16, 356);
            this.msrpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msrpLabel.Name = "msrpLabel";
            this.msrpLabel.Size = new System.Drawing.Size(82, 26);
            this.msrpLabel.TabIndex = 54;
            this.msrpLabel.Text = "MSRP:";
            // 
            // msrpUpDown
            // 
            this.msrpUpDown.DecimalPlaces = 2;
            this.msrpUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.msrpUpDown.Location = new System.Drawing.Point(121, 354);
            this.msrpUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.msrpUpDown.Name = "msrpUpDown";
            this.msrpUpDown.Size = new System.Drawing.Size(268, 32);
            this.msrpUpDown.TabIndex = 56;
            this.msrpUpDown.ThousandsSeparator = true;
            // 
            // priceUpDown
            // 
            this.priceUpDown.DecimalPlaces = 2;
            this.priceUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.priceUpDown.Location = new System.Drawing.Point(121, 398);
            this.priceUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.priceUpDown.Name = "priceUpDown";
            this.priceUpDown.Size = new System.Drawing.Size(268, 32);
            this.priceUpDown.TabIndex = 57;
            this.priceUpDown.ThousandsSeparator = true;
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.quantityUpDown.Location = new System.Drawing.Point(120, 310);
            this.quantityUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(268, 32);
            this.quantityUpDown.TabIndex = 58;
            this.quantityUpDown.ThousandsSeparator = true;
            // 
            // NewItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 666);
            this.Controls.Add(this.quantityUpDown);
            this.Controls.Add(this.priceUpDown);
            this.Controls.Add(this.msrpUpDown);
            this.Controls.Add(this.msrpLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.temporaryLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewItemScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewItemScreen";
            this.Load += new System.EventHandler(this.NewItemScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msrpUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label temporaryLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label msrpLabel;
        private System.Windows.Forms.NumericUpDown msrpUpDown;
        private System.Windows.Forms.NumericUpDown priceUpDown;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
    }
}