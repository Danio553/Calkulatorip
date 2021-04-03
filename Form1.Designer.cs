
namespace Calkulatorip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IPTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaskaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.networkAddressTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BroadcastTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstusefulTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LastusefulTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(195, 35);
            this.IPTextBox.Mask = "###\\.###\\.###\\.###";
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(88, 23);
            this.IPTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "AdresIP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maska:";
            // 
            // MaskaTextBox
            // 
            this.MaskaTextBox.Location = new System.Drawing.Point(195, 67);
            this.MaskaTextBox.Mask = "###\\.###\\.###\\.###";
            this.MaskaTextBox.Name = "MaskaTextBox";
            this.MaskaTextBox.Size = new System.Drawing.Size(88, 23);
            this.MaskaTextBox.TabIndex = 2;
            this.MaskaTextBox.Text = "255255255255";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(285, 34);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(106, 176);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Policz";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateIP);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adres Sieci:";
            // 
            // networkAddressTextBox
            // 
            this.networkAddressTextBox.Location = new System.Drawing.Point(195, 96);
            this.networkAddressTextBox.Mask = "###\\.###\\.###\\.###";
            this.networkAddressTextBox.Name = "networkAddressTextBox";
            this.networkAddressTextBox.ReadOnly = true;
            this.networkAddressTextBox.Size = new System.Drawing.Size(88, 23);
            this.networkAddressTextBox.TabIndex = 5;
            this.networkAddressTextBox.Text = "000000000000";
            // 
            // BroadcastTextBox
            // 
            this.BroadcastTextBox.Location = new System.Drawing.Point(195, 125);
            this.BroadcastTextBox.Mask = "###\\.###\\.###\\.###";
            this.BroadcastTextBox.Name = "BroadcastTextBox";
            this.BroadcastTextBox.ReadOnly = true;
            this.BroadcastTextBox.Size = new System.Drawing.Size(88, 23);
            this.BroadcastTextBox.TabIndex = 7;
            this.BroadcastTextBox.Text = "000000000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adres Rozgłoszeniowy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pierwszy użyteczny adres:";
            // 
            // FirstusefulTextBox
            // 
            this.FirstusefulTextBox.Location = new System.Drawing.Point(195, 156);
            this.FirstusefulTextBox.Mask = "###\\.###\\.###\\.###";
            this.FirstusefulTextBox.Name = "FirstusefulTextBox";
            this.FirstusefulTextBox.ReadOnly = true;
            this.FirstusefulTextBox.Size = new System.Drawing.Size(88, 23);
            this.FirstusefulTextBox.TabIndex = 9;
            this.FirstusefulTextBox.Text = "000000000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ostatni użyteczny adres:";
            // 
            // LastusefulTextBox
            // 
            this.LastusefulTextBox.Location = new System.Drawing.Point(195, 187);
            this.LastusefulTextBox.Mask = "###\\.###\\.###\\.###";
            this.LastusefulTextBox.Name = "LastusefulTextBox";
            this.LastusefulTextBox.ReadOnly = true;
            this.LastusefulTextBox.Size = new System.Drawing.Size(88, 23);
            this.LastusefulTextBox.TabIndex = 11;
            this.LastusefulTextBox.Text = "000000000000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 240);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LastusefulTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FirstusefulTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BroadcastTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.networkAddressTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaskaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox IPTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MaskaTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox networkAddressTextBox;
        private System.Windows.Forms.MaskedTextBox BroadcastTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox FirstusefulTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox LastusefulTextBox;
    }
}

