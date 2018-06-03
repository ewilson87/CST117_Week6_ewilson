namespace CST117_InventoryManagementProgram
{
    partial class HomeScreen
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
            this.exitButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.temporaryLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewInventoryButton = new System.Windows.Forms.Button();
            this.searchInventoryButton = new System.Windows.Forms.Button();
            this.addNewItemButton = new System.Windows.Forms.Button();
            this.reOrderInventoryButton = new System.Windows.Forms.Button();
            this.companyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(1179, 607);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(78, 43);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1097, 607);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(78, 43);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // temporaryLabel
            // 
            this.temporaryLabel.AutoSize = true;
            this.temporaryLabel.Location = new System.Drawing.Point(7, 29);
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
            this.pictureBox1.Size = new System.Drawing.Size(83, 57);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // viewInventoryButton
            // 
            this.viewInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.viewInventoryButton.Location = new System.Drawing.Point(390, 133);
            this.viewInventoryButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewInventoryButton.Name = "viewInventoryButton";
            this.viewInventoryButton.Size = new System.Drawing.Size(209, 177);
            this.viewInventoryButton.TabIndex = 4;
            this.viewInventoryButton.Text = "View Current Inventory";
            this.viewInventoryButton.UseVisualStyleBackColor = true;
            this.viewInventoryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchInventoryButton
            // 
            this.searchInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.searchInventoryButton.Location = new System.Drawing.Point(667, 133);
            this.searchInventoryButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchInventoryButton.Name = "searchInventoryButton";
            this.searchInventoryButton.Size = new System.Drawing.Size(209, 177);
            this.searchInventoryButton.TabIndex = 5;
            this.searchInventoryButton.Text = "Search Current Inventory";
            this.searchInventoryButton.UseVisualStyleBackColor = true;
            this.searchInventoryButton.Click += new System.EventHandler(this.searchInventoryButton_Click);
            // 
            // addNewItemButton
            // 
            this.addNewItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.addNewItemButton.Location = new System.Drawing.Point(390, 372);
            this.addNewItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.addNewItemButton.Name = "addNewItemButton";
            this.addNewItemButton.Size = new System.Drawing.Size(209, 177);
            this.addNewItemButton.TabIndex = 6;
            this.addNewItemButton.Text = "Add New Item";
            this.addNewItemButton.UseVisualStyleBackColor = true;
            this.addNewItemButton.Click += new System.EventHandler(this.addNewItemButton_Click);
            // 
            // reOrderInventoryButton
            // 
            this.reOrderInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.reOrderInventoryButton.Location = new System.Drawing.Point(667, 372);
            this.reOrderInventoryButton.Margin = new System.Windows.Forms.Padding(2);
            this.reOrderInventoryButton.Name = "reOrderInventoryButton";
            this.reOrderInventoryButton.Size = new System.Drawing.Size(209, 177);
            this.reOrderInventoryButton.TabIndex = 7;
            this.reOrderInventoryButton.Text = "Re-Stock Inventory";
            this.reOrderInventoryButton.UseVisualStyleBackColor = true;
            this.reOrderInventoryButton.Click += new System.EventHandler(this.reOrderInventoryButton_Click);
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Lucida Handwriting", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.companyLabel.Location = new System.Drawing.Point(250, 8);
            this.companyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(774, 48);
            this.companyLabel.TabIndex = 8;
            this.companyLabel.Text = "WILSON\'S ELECTRONICS HOME MENU";
            this.companyLabel.Click += new System.EventHandler(this.companyLabel_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1265, 683);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.reOrderInventoryButton);
            this.Controls.Add(this.addNewItemButton);
            this.Controls.Add(this.searchInventoryButton);
            this.Controls.Add(this.viewInventoryButton);
            this.Controls.Add(this.temporaryLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label temporaryLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button viewInventoryButton;
        private System.Windows.Forms.Button searchInventoryButton;
        private System.Windows.Forms.Button addNewItemButton;
        private System.Windows.Forms.Button reOrderInventoryButton;
        private System.Windows.Forms.Label companyLabel;
    }
}