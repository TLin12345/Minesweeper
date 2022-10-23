using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void OK_Click(object sender, EventArgs e)
        {
            if (row.Value * col.Value < 18 || mines.Value > row.Value * col.Value / 2)
                MessageBox.Show("Invalid values...Please try again!");
            else {
                ((MainForm)this.Owner).isCustom = true;
                ((MainForm)this.Owner).row = (int)row.Value;
                ((MainForm)this.Owner).col = (int)col.Value;
                ((MainForm)this.Owner).mines = (int)mines.Value;
                this.Close();
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
