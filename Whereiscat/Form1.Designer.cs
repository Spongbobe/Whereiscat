namespace Whereiscat
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
            this.startBtn = new System.Windows.Forms.Button();
            this.countDownLb = new System.Windows.Forms.Label();
            this.pointlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Friz Quadrata Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(314, 533);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(127, 50);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // countDownLb
            // 
            this.countDownLb.AutoSize = true;
            this.countDownLb.Font = new System.Drawing.Font("Dosis", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDownLb.Location = new System.Drawing.Point(350, -4);
            this.countDownLb.Name = "countDownLb";
            this.countDownLb.Size = new System.Drawing.Size(70, 87);
            this.countDownLb.TabIndex = 1;
            this.countDownLb.Text = "0";
            this.countDownLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countDownLb.Visible = false;
            // 
            // pointlbl
            // 
            this.pointlbl.AutoSize = true;
            this.pointlbl.Font = new System.Drawing.Font("Dosis", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointlbl.ForeColor = System.Drawing.Color.Red;
            this.pointlbl.Location = new System.Drawing.Point(1, -4);
            this.pointlbl.Name = "pointlbl";
            this.pointlbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pointlbl.Size = new System.Drawing.Size(89, 33);
            this.pointlbl.TabIndex = 1;
            this.pointlbl.Text = "Point : 0";
            this.pointlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(749, 635);
            this.Controls.Add(this.pointlbl);
            this.Controls.Add(this.countDownLb);
            this.Controls.Add(this.startBtn);
            this.Font = new System.Drawing.Font("Dosis", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(463, 674);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label countDownLb;
        private System.Windows.Forms.Label pointlbl;
    }
}

