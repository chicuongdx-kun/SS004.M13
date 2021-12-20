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
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
        }

        private void HighScore_Load(object sender, EventArgs e)
        {
            DataView top = DataScore.DataSet.DefaultView;
            top.Sort = "Score desc";
            DataTable sorted = top.ToTable();

            DataTable res = new DataTable();
            res.Columns.Add("Name", typeof(string));
            res.Columns.Add("Score", typeof(int));

            for (int idx = 0; idx < sorted.Rows.Count; idx++)
            {
                DataRow row = res.NewRow();
                row["Name"] = sorted.Rows[idx]["Name"].ToString();
                row["Score"] = Convert.ToInt32(sorted.Rows[idx]["Score"]);
                res.Rows.Add(row);
            }

            gridHistory.DataSource = res;
        }

        private void pctBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
