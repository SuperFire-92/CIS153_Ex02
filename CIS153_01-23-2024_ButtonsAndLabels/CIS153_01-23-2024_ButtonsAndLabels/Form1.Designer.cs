namespace CIS153_01_23_2024_ButtonsAndLabels
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_subtract = new System.Windows.Forms.Button();
            this.lbl_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(12, 385);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(686, 191);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_subtract
            // 
            this.btn_subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtract.Location = new System.Drawing.Point(721, 385);
            this.btn_subtract.Name = "btn_subtract";
            this.btn_subtract.Size = new System.Drawing.Size(686, 191);
            this.btn_subtract.TabIndex = 1;
            this.btn_subtract.Text = "SUBTRACT";
            this.btn_subtract.UseVisualStyleBackColor = true;
            this.btn_subtract.Click += new System.EventHandler(this.btn_subtract_Click);
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num.Location = new System.Drawing.Point(673, 21);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(83, 91);
            this.lbl_num.TabIndex = 2;
            this.lbl_num.Text = "0";
            this.lbl_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 588);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.btn_subtract);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_subtract;
        private System.Windows.Forms.Label lbl_num;
    }
}

