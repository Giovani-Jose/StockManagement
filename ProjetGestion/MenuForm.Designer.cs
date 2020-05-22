namespace ProjetGestion
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.ProductManagementBtn = new System.Windows.Forms.Button();
            this.SellingManagementBtn = new System.Windows.Forms.Button();
            this.ClientManagementbtn = new System.Windows.Forms.Button();
            this.SignOutBtn = new System.Windows.Forms.Button();
            this.UserManagementBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientUserControl1 = new ProjetGestion.ClientUserControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductManagementBtn
            // 
            this.ProductManagementBtn.FlatAppearance.BorderSize = 0;
            this.ProductManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductManagementBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductManagementBtn.Image = ((System.Drawing.Image)(resources.GetObject("ProductManagementBtn.Image")));
            this.ProductManagementBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ProductManagementBtn.Location = new System.Drawing.Point(273, 9);
            this.ProductManagementBtn.Name = "ProductManagementBtn";
            this.ProductManagementBtn.Size = new System.Drawing.Size(168, 37);
            this.ProductManagementBtn.TabIndex = 1;
            this.ProductManagementBtn.Text = "Gestion des produits";
            this.ProductManagementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProductManagementBtn.UseVisualStyleBackColor = true;
            // 
            // SellingManagementBtn
            // 
            this.SellingManagementBtn.FlatAppearance.BorderSize = 0;
            this.SellingManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellingManagementBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingManagementBtn.Image = ((System.Drawing.Image)(resources.GetObject("SellingManagementBtn.Image")));
            this.SellingManagementBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SellingManagementBtn.Location = new System.Drawing.Point(511, 6);
            this.SellingManagementBtn.Name = "SellingManagementBtn";
            this.SellingManagementBtn.Size = new System.Drawing.Size(179, 45);
            this.SellingManagementBtn.TabIndex = 2;
            this.SellingManagementBtn.Text = "Gestion des ventes";
            this.SellingManagementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SellingManagementBtn.UseVisualStyleBackColor = true;
            // 
            // ClientManagementbtn
            // 
            this.ClientManagementbtn.FlatAppearance.BorderSize = 0;
            this.ClientManagementbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientManagementbtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientManagementbtn.Image = ((System.Drawing.Image)(resources.GetObject("ClientManagementbtn.Image")));
            this.ClientManagementbtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ClientManagementbtn.Location = new System.Drawing.Point(16, 5);
            this.ClientManagementbtn.Name = "ClientManagementbtn";
            this.ClientManagementbtn.Size = new System.Drawing.Size(197, 45);
            this.ClientManagementbtn.TabIndex = 3;
            this.ClientManagementbtn.Text = "Gestion des clients";
            this.ClientManagementbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClientManagementbtn.UseVisualStyleBackColor = true;
            // 
            // SignOutBtn
            // 
            this.SignOutBtn.FlatAppearance.BorderSize = 0;
            this.SignOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOutBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutBtn.ForeColor = System.Drawing.Color.Maroon;
            this.SignOutBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SignOutBtn.Location = new System.Drawing.Point(956, 6);
            this.SignOutBtn.Name = "SignOutBtn";
            this.SignOutBtn.Size = new System.Drawing.Size(142, 45);
            this.SignOutBtn.TabIndex = 4;
            this.SignOutBtn.Text = "Deconnexion";
            this.SignOutBtn.UseVisualStyleBackColor = true;
            // 
            // UserManagementBtn
            // 
            this.UserManagementBtn.FlatAppearance.BorderSize = 0;
            this.UserManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserManagementBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserManagementBtn.ForeColor = System.Drawing.Color.Aqua;
            this.UserManagementBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.UserManagementBtn.Location = new System.Drawing.Point(721, 5);
            this.UserManagementBtn.Name = "UserManagementBtn";
            this.UserManagementBtn.Size = new System.Drawing.Size(179, 45);
            this.UserManagementBtn.TabIndex = 5;
            this.UserManagementBtn.Text = "Gestion des utilisateurs";
            this.UserManagementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserManagementBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.UserManagementBtn);
            this.panel1.Controls.Add(this.SignOutBtn);
            this.panel1.Controls.Add(this.ClientManagementbtn);
            this.panel1.Controls.Add(this.SellingManagementBtn);
            this.panel1.Controls.Add(this.ProductManagementBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 541);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 53);
            this.panel1.TabIndex = 0;
            // 
            // clientUserControl1
            // 
            this.clientUserControl1.Location = new System.Drawing.Point(3, 2);
            this.clientUserControl1.Name = "clientUserControl1";
            this.clientUserControl1.Size = new System.Drawing.Size(1138, 538);
            this.clientUserControl1.TabIndex = 1;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 594);
            this.Controls.Add(this.clientUserControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProductManagementBtn;
        private System.Windows.Forms.Button SellingManagementBtn;
        private System.Windows.Forms.Button ClientManagementbtn;
        private System.Windows.Forms.Button SignOutBtn;
        private System.Windows.Forms.Button UserManagementBtn;
        private System.Windows.Forms.Panel panel1;
        private ClientUserControl clientUserControl1;
    }
}