
namespace SnakeGame
{
    partial class FrmNotice
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbHighScore = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbCalculation = new System.Windows.Forms.Label();
            this.btnPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(12, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(386, 23);
            this.txtName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ghi danh nào:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Điểm bạn đạt được:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kỷ lục:";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(250, 72);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(17, 17);
            this.lbScore.TabIndex = 7;
            this.lbScore.Text = "0";
            // 
            // lbHighScore
            // 
            this.lbHighScore.AutoSize = true;
            this.lbHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lbHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHighScore.Location = new System.Drawing.Point(250, 103);
            this.lbHighScore.Name = "lbHighScore";
            this.lbHighScore.Size = new System.Drawing.Size(17, 17);
            this.lbHighScore.TabIndex = 8;
            this.lbHighScore.Text = "0";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(96, 176);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Ghi danh";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbCalculation
            // 
            this.lbCalculation.AutoSize = true;
            this.lbCalculation.BackColor = System.Drawing.Color.Transparent;
            this.lbCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalculation.ForeColor = System.Drawing.Color.Red;
            this.lbCalculation.Location = new System.Drawing.Point(58, 143);
            this.lbCalculation.Name = "lbCalculation";
            this.lbCalculation.Size = new System.Drawing.Size(327, 17);
            this.lbCalculation.TabIndex = 10;
            this.lbCalculation.Text = "WOW! Bạn đạt được điểm cao nhất luôn kìa.";
            this.lbCalculation.Visible = false;
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(219, 176);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(100, 30);
            this.btnPass.TabIndex = 9;
            this.btnPass.Text = "Bỏ qua";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // FrmNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(410, 218);
            this.Controls.Add(this.lbCalculation);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbHighScore);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNotice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả đạt được";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbHighScore;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbCalculation;
        private System.Windows.Forms.Button btnPass;
    }
}