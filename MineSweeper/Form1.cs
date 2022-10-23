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
    public partial class MainForm : Form
    {
        public int row = 0, col = 0, mines = 0;
        public bool isCustom = false;
        public int count = 0;// amounts of activated game
        public String text = "";
        public String name = "";
        Form2 f2 = null;
        public MainForm()
        {
            InitializeComponent();
        }
        // Radio button checked
        private void Play(object sender, EventArgs e)
        {

        }
        // Close all games button
        private void CloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.OwnedForms) // close all opened games
                f.Close();
        }
        // Sub-menu: Easy
        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            row = col = 9;
            mines = 10;
            text = "Easy";
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f2 = new Form2(text, col, row, size, mines, name);
            f2.Owner = this;
            f2.Show();
            count++;
            activeGames.Text = "" + count;
        }
        // Sub-menu: Medium
        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            row = col = 16;
            mines = 40;
            text = "Medium";
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f2 = new Form2(text, col, row, size, mines, name);
            f2.Owner = this;
            f2.Show();
            count++;
            activeGames.Text = "" + count;
        }
        // Sub-menu: Expert
        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            row = 30;
            col = 16;
            mines = 99;
            text = "Expert";
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f2 = new Form2(text, col, row, size, mines, name);
            f2.Owner = this;
            f2.Show();
            count++;
            activeGames.Text = "" + count;
        }
        // MenuStrip item: Close all games
        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.OwnedForms)// close all opened games
                f.Close();
        }
        // MenuStrip item: Exits application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.OwnedForms)// close all opened games
                f.Close();
            Application.Exit();// close the application
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Load!");
            MessageBox.Show((IWin32Window)sender, "Welcome to my Minesweeper!");
        }
    }
}
