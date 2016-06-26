namespace winSiparisTelefon
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMarkalar = new System.Windows.Forms.ComboBox();
            this.lstModeller = new System.Windows.Forms.ListBox();
            this.btnModelYonet = new System.Windows.Forms.Button();
            this.btnMarkaYonet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Markalar";
            // 
            // cmbMarkalar
            // 
            this.cmbMarkalar.FormattingEnabled = true;
            this.cmbMarkalar.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "LG"});
            this.cmbMarkalar.Location = new System.Drawing.Point(17, 44);
            this.cmbMarkalar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMarkalar.Name = "cmbMarkalar";
            this.cmbMarkalar.Size = new System.Drawing.Size(189, 24);
            this.cmbMarkalar.TabIndex = 1;
            this.cmbMarkalar.SelectedIndexChanged += new System.EventHandler(this.cmbMarkalar_SelectedIndexChanged);
            // 
            // lstModeller
            // 
            this.lstModeller.FormattingEnabled = true;
            this.lstModeller.ItemHeight = 16;
            this.lstModeller.Location = new System.Drawing.Point(17, 75);
            this.lstModeller.Name = "lstModeller";
            this.lstModeller.Size = new System.Drawing.Size(189, 276);
            this.lstModeller.TabIndex = 3;
            // 
            // btnModelYonet
            // 
            this.btnModelYonet.Image = global::winSiparisTelefon.Properties.Resources._1455800936_open_file;
            this.btnModelYonet.Location = new System.Drawing.Point(212, 75);
            this.btnModelYonet.Name = "btnModelYonet";
            this.btnModelYonet.Size = new System.Drawing.Size(32, 23);
            this.btnModelYonet.TabIndex = 4;
            this.btnModelYonet.UseVisualStyleBackColor = true;
            // 
            // btnMarkaYonet
            // 
            this.btnMarkaYonet.Image = global::winSiparisTelefon.Properties.Resources._1455800936_open_file;
            this.btnMarkaYonet.Location = new System.Drawing.Point(212, 44);
            this.btnMarkaYonet.Name = "btnMarkaYonet";
            this.btnMarkaYonet.Size = new System.Drawing.Size(32, 24);
            this.btnMarkaYonet.TabIndex = 2;
            this.btnMarkaYonet.UseVisualStyleBackColor = true;
            this.btnMarkaYonet.Click += new System.EventHandler(this.btnMarkaYonet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 408);
            this.Controls.Add(this.btnModelYonet);
            this.Controls.Add(this.lstModeller);
            this.Controls.Add(this.btnMarkaYonet);
            this.Controls.Add(this.cmbMarkalar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMarkalar;
        private System.Windows.Forms.Button btnMarkaYonet;
        private System.Windows.Forms.ListBox lstModeller;
        private System.Windows.Forms.Button btnModelYonet;
    }
}

