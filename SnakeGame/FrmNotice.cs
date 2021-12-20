using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class FrmNotice : Form
    {
        public FrmNotice(int score)
        {
            InitializeComponent();
            lbScore.Text = score.ToString();
            lbHighScore.Text = DataScore.HighScore.ToString();

            if (Convert.ToInt32(lbHighScore.Text) <= Convert.ToInt32(lbScore.Text))
            {
                DataScore.HighScore = score;
                lbCalculation.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên kìa!");
            }
            else
            {
                DataScore.curName = txtName.Text;
                DataScore.score = Convert.ToInt32(lbScore.Text);
                DataScore.DataSet.Rows.Add(DataScore.curName, DataScore.score);
                this.Close();
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
