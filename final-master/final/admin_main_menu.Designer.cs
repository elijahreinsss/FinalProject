namespace final
{
    partial class admin_main_menu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.User_Management_BTN = new System.Windows.Forms.Button();
            this.Inventory_BTN = new System.Windows.Forms.Button();
            this.Supplier_Management = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::final.Properties.Resources.Untitled_design__5_;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // User_Management_BTN
            // 
            this.User_Management_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Management_BTN.Location = new System.Drawing.Point(216, 205);
            this.User_Management_BTN.Name = "User_Management_BTN";
            this.User_Management_BTN.Size = new System.Drawing.Size(217, 38);
            this.User_Management_BTN.TabIndex = 3;
            this.User_Management_BTN.Text = "User Management";
            this.User_Management_BTN.UseVisualStyleBackColor = true;
            this.User_Management_BTN.Click += new System.EventHandler(this.User_Management_BTN_Click);
            // 
            // Inventory_BTN
            // 
            this.Inventory_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_BTN.Location = new System.Drawing.Point(230, 249);
            this.Inventory_BTN.Name = "Inventory_BTN";
            this.Inventory_BTN.Size = new System.Drawing.Size(182, 38);
            this.Inventory_BTN.TabIndex = 4;
            this.Inventory_BTN.Text = "Inventory";
            this.Inventory_BTN.UseVisualStyleBackColor = true;
            this.Inventory_BTN.Click += new System.EventHandler(this.Inventory_BTN_Click);
            // 
            // Supplier_Management
            // 
            this.Supplier_Management.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier_Management.Location = new System.Drawing.Point(230, 319);
            this.Supplier_Management.Name = "Supplier_Management";
            this.Supplier_Management.Size = new System.Drawing.Size(182, 38);
            this.Supplier_Management.TabIndex = 5;
            this.Supplier_Management.Text = "Supplier Management";
            this.Supplier_Management.UseVisualStyleBackColor = true;
            this.Supplier_Management.Click += new System.EventHandler(this.Supplier_Management_Click);
            // 
            // admin_main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 387);
            this.Controls.Add(this.Supplier_Management);
            this.Controls.Add(this.Inventory_BTN);
            this.Controls.Add(this.User_Management_BTN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "admin_main_menu";
            this.Text = "UserManagement";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Inventory_BTN;
        private System.Windows.Forms.Button Supplier_Management;
        private System.Windows.Forms.Button User_Management_BTN;
    }
}