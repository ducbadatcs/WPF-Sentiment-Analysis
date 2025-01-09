namespace WPF_Sentiment_Analysis
{
    partial class Form1
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
            this.TextBoxNhapCau = new System.Windows.Forms.TextBox();
            this.LabelNhapCau = new System.Windows.Forms.Label();
            this.LabelCamXuc = new System.Windows.Forms.Label();
            this.ButtonNhapCau = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LabelDanhGia = new System.Windows.Forms.Label();
            this.NutThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxNhapCau
            // 
            this.TextBoxNhapCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNhapCau.Location = new System.Drawing.Point(84, 82);
            this.TextBoxNhapCau.Multiline = true;
            this.TextBoxNhapCau.Name = "TextBoxNhapCau";
            this.TextBoxNhapCau.Size = new System.Drawing.Size(514, 130);
            this.TextBoxNhapCau.TabIndex = 0;
            // 
            // LabelNhapCau
            // 
            this.LabelNhapCau.AutoSize = true;
            this.LabelNhapCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNhapCau.Location = new System.Drawing.Point(78, 20);
            this.LabelNhapCau.Name = "LabelNhapCau";
            this.LabelNhapCau.Size = new System.Drawing.Size(157, 36);
            this.LabelNhapCau.TabIndex = 1;
            this.LabelNhapCau.Text = "Nhập Câu";
            // 
            // LabelCamXuc
            // 
            this.LabelCamXuc.AutoSize = true;
            this.LabelCamXuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCamXuc.Location = new System.Drawing.Point(79, 310);
            this.LabelCamXuc.Name = "LabelCamXuc";
            this.LabelCamXuc.Size = new System.Drawing.Size(126, 29);
            this.LabelCamXuc.TabIndex = 2;
            this.LabelCamXuc.Text = "Cảm xúc: ";
            // 
            // ButtonNhapCau
            // 
            this.ButtonNhapCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNhapCau.Location = new System.Drawing.Point(84, 242);
            this.ButtonNhapCau.Name = "ButtonNhapCau";
            this.ButtonNhapCau.Size = new System.Drawing.Size(151, 38);
            this.ButtonNhapCau.TabIndex = 3;
            this.ButtonNhapCau.Text = "Nhập câu";
            this.ButtonNhapCau.UseVisualStyleBackColor = true;
            this.ButtonNhapCau.Click += new System.EventHandler(this.ButtonNhapCau_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LabelDanhGia
            // 
            this.LabelDanhGia.AutoSize = true;
            this.LabelDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDanhGia.Location = new System.Drawing.Point(79, 365);
            this.LabelDanhGia.Name = "LabelDanhGia";
            this.LabelDanhGia.Size = new System.Drawing.Size(123, 29);
            this.LabelDanhGia.TabIndex = 4;
            this.LabelDanhGia.Text = "Đánh giá:";
            // 
            // NutThoat
            // 
            this.NutThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NutThoat.Location = new System.Drawing.Point(511, 242);
            this.NutThoat.Name = "NutThoat";
            this.NutThoat.Size = new System.Drawing.Size(259, 164);
            this.NutThoat.TabIndex = 5;
            this.NutThoat.Text = "Thoát";
            this.NutThoat.UseVisualStyleBackColor = true;
            this.NutThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NutThoat);
            this.Controls.Add(this.LabelDanhGia);
            this.Controls.Add(this.ButtonNhapCau);
            this.Controls.Add(this.LabelCamXuc);
            this.Controls.Add(this.LabelNhapCau);
            this.Controls.Add(this.TextBoxNhapCau);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxNhapCau;
        private System.Windows.Forms.Label LabelNhapCau;
        private System.Windows.Forms.Label LabelCamXuc;
        private System.Windows.Forms.Button ButtonNhapCau;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label LabelDanhGia;
        private System.Windows.Forms.Button NutThoat;
    }
}

