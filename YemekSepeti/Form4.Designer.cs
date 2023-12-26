namespace YemekSepeti
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button1 = new System.Windows.Forms.Button();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnShop = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(56)))));
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Yemek Kapında";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnLogIn.FlatAppearance.BorderSize = 0;
            this.BtnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogIn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogIn.ImageKey = "profile (1).png";
            this.BtnLogIn.ImageList = this.ımageList1;
            this.BtnLogIn.Location = new System.Drawing.Point(580, 0);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(114, 39);
            this.BtnLogIn.TabIndex = 4;
            this.BtnLogIn.Text = "Giriş Yap";
            this.BtnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogIn.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "profile (1).png");
            this.ımageList1.Images.SetKeyName(1, "order-food.png");
            this.ımageList1.Images.SetKeyName(2, "yemek.jpg");
            this.ımageList1.Images.SetKeyName(3, "like.png");
            // 
            // BtnShop
            // 
            this.BtnShop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnShop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnShop.FlatAppearance.BorderSize = 0;
            this.BtnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShop.ImageKey = "order-food.png";
            this.BtnShop.ImageList = this.ımageList1;
            this.BtnShop.Location = new System.Drawing.Point(740, 2);
            this.BtnShop.Name = "BtnShop";
            this.BtnShop.Size = new System.Drawing.Size(60, 39);
            this.BtnShop.TabIndex = 5;
            this.BtnShop.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageKey = "like.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(686, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 39);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnShop);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button BtnShop;
        private System.Windows.Forms.Button button2;
    }
}