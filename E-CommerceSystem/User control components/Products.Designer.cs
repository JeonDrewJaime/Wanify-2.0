namespace E_CommerceSystem
{
    partial class Products
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.product_price = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.Label();
            this.view_prodDetails = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.product_Photo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.edit_product = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.delete_product = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_Photo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // product_price
            // 
            this.product_price.AutoSize = true;
            this.product_price.Cursor = System.Windows.Forms.Cursors.Default;
            this.product_price.Font = new System.Drawing.Font("League Spartan Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(56)))), ((int)(((byte)(142)))));
            this.product_price.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.product_price.Location = new System.Drawing.Point(3, 196);
            this.product_price.Name = "product_price";
            this.product_price.Size = new System.Drawing.Size(58, 23);
            this.product_price.TabIndex = 52;
            this.product_price.Text = "P50.00";
            this.product_price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // product_name
            // 
            this.product_name.AutoSize = true;
            this.product_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.product_name.Font = new System.Drawing.Font("League Spartan Thin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(56)))), ((int)(((byte)(142)))));
            this.product_name.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.product_name.Location = new System.Drawing.Point(3, 0);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(59, 23);
            this.product_name.TabIndex = 51;
            this.product_name.Text = "SHABU";
            this.product_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // view_prodDetails
            // 
            this.view_prodDetails.Animated = true;
            this.view_prodDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_prodDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.view_prodDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.view_prodDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.view_prodDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.view_prodDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.view_prodDetails.Font = new System.Drawing.Font("League Spartan Thin", 12F, System.Drawing.FontStyle.Bold);
            this.view_prodDetails.ForeColor = System.Drawing.Color.White;
            this.view_prodDetails.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(192)))));
            this.view_prodDetails.HoverState.ForeColor = System.Drawing.Color.White;
            this.view_prodDetails.Location = new System.Drawing.Point(0, 222);
            this.view_prodDetails.Name = "view_prodDetails";
            this.view_prodDetails.PressedColor = System.Drawing.Color.Empty;
            this.view_prodDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.view_prodDetails.Size = new System.Drawing.Size(238, 28);
            this.view_prodDetails.TabIndex = 50;
            this.view_prodDetails.Text = "VIEW DETAILS";
            this.view_prodDetails.Tile = true;
            this.view_prodDetails.Click += new System.EventHandler(this.view_prodDetails_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 100;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // product_Photo
            // 
            this.product_Photo.BackColor = System.Drawing.Color.Transparent;
            this.product_Photo.ImageRotate = 0F;
            this.product_Photo.Location = new System.Drawing.Point(9, 11);
            this.product_Photo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.product_Photo.Name = "product_Photo";
            this.product_Photo.Size = new System.Drawing.Size(218, 156);
            this.product_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.product_Photo.TabIndex = 53;
            this.product_Photo.TabStop = false;
            this.product_Photo.UseTransparentBackground = true;
            // 
            // edit_product
            // 
            this.edit_product.Animated = true;
            this.edit_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_product.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.edit_product.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.edit_product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.edit_product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.edit_product.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.edit_product.Font = new System.Drawing.Font("League Spartan Thin", 12F, System.Drawing.FontStyle.Bold);
            this.edit_product.ForeColor = System.Drawing.Color.White;
            this.edit_product.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(192)))));
            this.edit_product.HoverState.ForeColor = System.Drawing.Color.White;
            this.edit_product.Location = new System.Drawing.Point(0, 222);
            this.edit_product.Name = "edit_product";
            this.edit_product.PressedColor = System.Drawing.Color.Empty;
            this.edit_product.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edit_product.Size = new System.Drawing.Size(119, 28);
            this.edit_product.TabIndex = 54;
            this.edit_product.Text = "EDIT PRODUCT";
            this.edit_product.Tile = true;
            this.edit_product.Click += new System.EventHandler(this.edit_product_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.product_name);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 164);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(235, 31);
            this.flowLayoutPanel1.TabIndex = 55;
            // 
            // delete_product
            // 
            this.delete_product.Animated = true;
            this.delete_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_product.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_product.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_product.FillColor = System.Drawing.Color.DarkRed;
            this.delete_product.Font = new System.Drawing.Font("League Spartan Thin", 12F, System.Drawing.FontStyle.Bold);
            this.delete_product.ForeColor = System.Drawing.Color.White;
            this.delete_product.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(95)))), ((int)(((byte)(192)))));
            this.delete_product.HoverState.ForeColor = System.Drawing.Color.White;
            this.delete_product.Location = new System.Drawing.Point(119, 222);
            this.delete_product.Name = "delete_product";
            this.delete_product.PressedColor = System.Drawing.Color.Empty;
            this.delete_product.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.delete_product.Size = new System.Drawing.Size(119, 28);
            this.delete_product.TabIndex = 57;
            this.delete_product.Text = "DELETE";
            this.delete_product.Tile = true;
            this.delete_product.Click += new System.EventHandler(this.delete_product_Click_1);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.delete_product);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.product_price);
            this.Controls.Add(this.edit_product);
            this.Controls.Add(this.product_Photo);
            this.Controls.Add(this.view_prodDetails);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 50, 20);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(238, 250);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_Photo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label product_price;
        private System.Windows.Forms.Label product_name;
        private Guna.UI2.WinForms.Guna2Button view_prodDetails;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox product_Photo;
        private Guna.UI2.WinForms.Guna2Button edit_product;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button delete_product;
    }
}
