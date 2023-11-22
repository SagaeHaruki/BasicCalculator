namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            this.first_box = new System.Windows.Forms.TextBox();
            this.second_box = new System.Windows.Forms.TextBox();
            this.reslt = new System.Windows.Forms.TextBox();
            this.compute_btn = new System.Windows.Forms.Button();
            this.operatorCMB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // first_box
            // 
            this.first_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_box.Location = new System.Drawing.Point(17, 47);
            this.first_box.Name = "first_box";
            this.first_box.Size = new System.Drawing.Size(267, 30);
            this.first_box.TabIndex = 1;
            this.first_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // second_box
            // 
            this.second_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_box.Location = new System.Drawing.Point(17, 128);
            this.second_box.Name = "second_box";
            this.second_box.Size = new System.Drawing.Size(267, 30);
            this.second_box.TabIndex = 2;
            this.second_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // reslt
            // 
            this.reslt.BackColor = System.Drawing.SystemColors.MenuText;
            this.reslt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reslt.ForeColor = System.Drawing.Color.LimeGreen;
            this.reslt.Location = new System.Drawing.Point(17, 187);
            this.reslt.Multiline = true;
            this.reslt.Name = "reslt";
            this.reslt.Size = new System.Drawing.Size(267, 88);
            this.reslt.TabIndex = 3;
            // 
            // compute_btn
            // 
            this.compute_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compute_btn.Location = new System.Drawing.Point(101, 295);
            this.compute_btn.Name = "compute_btn";
            this.compute_btn.Size = new System.Drawing.Size(89, 32);
            this.compute_btn.TabIndex = 4;
            this.compute_btn.Text = "Compute";
            this.compute_btn.UseVisualStyleBackColor = true;
            this.compute_btn.Click += new System.EventHandler(this.compute_btn_Click);
            // 
            // operatorCMB
            // 
            this.operatorCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operatorCMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorCMB.FormattingEnabled = true;
            this.operatorCMB.Location = new System.Drawing.Point(131, 92);
            this.operatorCMB.Name = "operatorCMB";
            this.operatorCMB.Size = new System.Drawing.Size(46, 24);
            this.operatorCMB.TabIndex = 5;
            this.operatorCMB.SelectedIndexChanged += new System.EventHandler(this.operatorCMB_SelectedIndexChanged);
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 339);
            this.Controls.Add(this.operatorCMB);
            this.Controls.Add(this.compute_btn);
            this.Controls.Add(this.reslt);
            this.Controls.Add(this.second_box);
            this.Controls.Add(this.first_box);
            this.Controls.Add(this.label1);
            this.Name = "FrmBasicCalculator";
            this.Text = "FrmBasicCalculator";
            this.Load += new System.EventHandler(this.FrmBasicCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox first_box;
        private System.Windows.Forms.TextBox second_box;
        private System.Windows.Forms.TextBox reslt;
        private System.Windows.Forms.Button compute_btn;
        private System.Windows.Forms.ComboBox operatorCMB;
    }
}

