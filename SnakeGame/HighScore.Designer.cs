
namespace SnakeGame
{
    partial class HighScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScore));
            this.gridHistory = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pctBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // gridHistory
            // 
            this.gridHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHistory.Location = new System.Drawing.Point(9, 42);
            this.gridHistory.Name = "gridHistory";
            this.gridHistory.Size = new System.Drawing.Size(231, 290);
            this.gridHistory.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "History Score";
            // 
            // pctBack
            // 
            this.pctBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.pctBack.BackgroundImage = global::SnakeGame.Properties.Resources.back_button;
            this.pctBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctBack.Location = new System.Drawing.Point(-2, 0);
            this.pctBack.Name = "pctBack";
            this.pctBack.Size = new System.Drawing.Size(42, 36);
            this.pctBack.TabIndex = 4;
            this.pctBack.TabStop = false;
            this.pctBack.Click += new System.EventHandler(this.pctBack_Click);
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(246, 337);
            this.Controls.Add(this.pctBack);
            this.Controls.Add(this.gridHistory);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScore";
            this.Load += new System.EventHandler(this.HighScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridHistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pctBack;
    }
}