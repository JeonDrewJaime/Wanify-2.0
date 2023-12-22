namespace E_CommerceSystem
{
    partial class ProductOrderCheckOut
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
            this.product_pic = new System.Windows.Forms.PictureBox();
            this.lbl_unit_price = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.unit_price = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.amount = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.item_subtotal = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.product_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.product_pic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // product_pic
            // 
            this.product_pic.Location = new System.Drawing.Point(10, 48);
            this.product_pic.Margin = new System.Windows.Forms.Padding(2);
            this.product_pic.Name = "product_pic";
            this.product_pic.Size = new System.Drawing.Size(105, 96);
            this.product_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.product_pic.TabIndex = 0;
            this.product_pic.TabStop = false;
            // 
            // lbl_unit_price
            // 
            this.lbl_unit_price.Location = new System.Drawing.Point(3, 15);
            this.lbl_unit_price.Name = "lbl_unit_price";
            this.lbl_unit_price.Size = new System.Drawing.Size(154, 31);
            this.lbl_unit_price.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lbl_unit_price.StateCommon.ShortText.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.lbl_unit_price.StateCommon.ShortText.ColorAngle = 1F;
            this.lbl_unit_price.StateCommon.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lbl_unit_price.StateCommon.ShortText.Font = new System.Drawing.Font("League Spartan Thin", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_unit_price.TabIndex = 56;
            this.lbl_unit_price.Values.Text = "UNIT PRICE";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 79);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(130, 31);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("League Spartan Thin", 20.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.TabIndex = 57;
            this.kryptonLabel1.Values.Text = "AMOUNT";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 139);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(209, 31);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("League Spartan Thin", 20.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel2.TabIndex = 58;
            this.kryptonLabel2.Values.Text = "ITEM SUBTOTAL";
            // 
            // unit_price
            // 
            this.unit_price.Location = new System.Drawing.Point(3, 47);
            this.unit_price.Name = "unit_price";
            this.unit_price.Size = new System.Drawing.Size(24, 26);
            this.unit_price.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.unit_price.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(55)))), ((int)(((byte)(176)))));
            this.unit_price.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_price.TabIndex = 59;
            this.unit_price.Values.Text = "0";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(3, 107);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(24, 26);
            this.amount.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.amount.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(55)))), ((int)(((byte)(176)))));
            this.amount.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.TabIndex = 60;
            this.amount.Values.Text = "0";
            // 
            // item_subtotal
            // 
            this.item_subtotal.Location = new System.Drawing.Point(3, 173);
            this.item_subtotal.Name = "item_subtotal";
            this.item_subtotal.Size = new System.Drawing.Size(24, 26);
            this.item_subtotal.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.item_subtotal.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(55)))), ((int)(((byte)(176)))));
            this.item_subtotal.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_subtotal.TabIndex = 61;
            this.item_subtotal.Values.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.lbl_unit_price);
            this.panel1.Controls.Add(this.item_subtotal);
            this.panel1.Controls.Add(this.unit_price);
            this.panel1.Controls.Add(this.kryptonLabel2);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.kryptonLabel1);
            this.panel1.Location = new System.Drawing.Point(358, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 207);
            this.panel1.TabIndex = 62;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // product_name
            // 
            this.product_name.Location = new System.Drawing.Point(3, 16);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(188, 31);
            this.product_name.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(55)))), ((int)(((byte)(176)))));
            this.product_name.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(55)))), ((int)(((byte)(176)))));
            this.product_name.StateCommon.ShortText.Font = new System.Drawing.Font("League Spartan Thin", 20.25F, System.Drawing.FontStyle.Bold);
            this.product_name.TabIndex = 7;
            this.product_name.Values.Text = "Product Name";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.product_name);
            this.panel2.Location = new System.Drawing.Point(122, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 208);
            this.panel2.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.panel3.Controls.Add(this.product_pic);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 208);
            this.panel3.TabIndex = 63;
            // 
            // ProductOrderCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ProductOrderCheckOut";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(953, 207);
            this.Load += new System.EventHandler(this.ProductOrderCheckOut_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.product_pic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox product_pic;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_unit_price;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel unit_price;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel amount;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel item_subtotal;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel product_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}