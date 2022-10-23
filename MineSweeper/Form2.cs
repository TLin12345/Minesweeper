using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form2 : Form
    {
        bool ended = false;
        int mineCounter = 0;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(String text, int row, int col, int size, int mines, String player) : this(){
            playerName.Text = player;
            this.Text = text;
            field = new Field(row, col, mines);
            this.ClientSize = new Size(row * size, col * size + 60);
            mineCounter = mines;
            mineDisplay.Text = "" + mineCounter;
            buttons = new Button[row][];
            for (int i = 0; i < row; i++)
                buttons[i] = new Button[col];
            ClockDisplay.Location = new Point((int)(row * size * 0.7), 30);
            playerName.Location = new Point((int)(row * size * 0.4), 30);
            mineDisplay.Location = new Point((int)(row * size * 0.1), 30);
            label1.Location = new Point((int)(row * size * 0.1), 10);
            label3.Location = new Point((int)(row * size * 0.4), 10);
            label2.Location = new Point((int)(row * size * 0.7), 10);
            ClockDisplay.Size = new Size((int)(row * size * 0.25), 20);
            playerName.Size = new Size((int)(row * size * 0.25), 20);
            mineDisplay.Size = new Size((int)(row * size * 0.25), 20);
            foreach (int i in Enumerable.Range(0,row))
                foreach (int j in Enumerable.Range(0,col))
                {
                    buttons[i][j] = new Button();
                    buttons[i][j].Text = "";
                    buttons[i][j].BackColor = Color.White;
                    buttons[i][j].Name = i + "," + j;
                    buttons[i][j].Size = new Size(size, size);
                    buttons[i][j].Location = new Point(size * i, size * j + 60);
                    buttons[i][j].UseVisualStyleBackColor = false;
                    buttons[i][j].MouseUp += new MouseEventHandler(Button_Click);
                    this.Controls.Add(buttons[i][j]);
                }
        }
        private void Button_Click(object sender, MouseEventArgs e) {
            Button b = (Button)sender;
            int temp = b.Name.IndexOf(",");
            int click_x = Int16.Parse(b.Name.Substring(0, temp));
            int click_y = Int16.Parse(b.Name.Substring(temp + 1));
            switch (e.Button)
            {
                case MouseButtons.Left:
                    // Left click
                    if (!this.field.Started)
                    {
                        this.field.Initialize(click_x, click_y);
                        timer.Enabled = true;
                    }
                    int n = this.field.CountMines(click_x, click_y);
                    if (this.field.IsMine(click_x, click_y))
                    {
                        b.BackColor = Color.Red;
                        MessageBox.Show("You lost! " + ((MainForm)Owner).nameBox.Text + " you clicked on a mine!\nYou won in: " + ClockDisplay.Text + " seconds");
                        ended = true;
                        this.Close();
                        break;
                    }
                    if (this.field.Discovered.Contains(click_x * buttons[0].Length + click_y))
                        break;
                    foreach (int k in this.field.GetSafeIsland(click_x, click_y))
                    {
                        int i = k / buttons[0].Length;
                        int j = k % buttons[0].Length;
                        buttons[i][j].BackColor = Color.LightGray;
                        int m = this.field.CountMines(i, j);
                        if (m > 0) {
                            buttons[i][j].Text = m + "";
                            buttons[i][j].BackColor = Color.LightBlue;
                        }else
                            buttons[i][j].Enabled = false;
                    }
                    if (field.Win())
                    {
                        MessageBox.Show("Congratulations " + ((MainForm)Owner).nameBox.Text + "! You discovered all safe squares!\nYou won in: " + ClockDisplay.Text + " seconds");
                        ended = true;
                        this.Close();
                    }
                    break;
                case MouseButtons.Right:
                    // Right click
                    if (this.field.Discovered.Contains(click_x * buttons[0].Length + click_y))
                        break;
                    if(field.Flagged.Contains(click_x * buttons[0].Length + click_y))
                    {
                        b.BackColor = Color.White;
                        field.Flagged.Remove(click_x * buttons[0].Length + click_y);
                        mineCounter++;
                        mineDisplay.Text = "" + mineCounter;
                    }
                    else
                    {
                        b.BackColor = Color.Green;
                        field.Flagged.Add(click_x * buttons[0].Length + click_y);
                        mineCounter--;
                        mineDisplay.Text = "" + mineCounter;
                    }  
                    break;
                case MouseButtons.Middle:
                    // Middle Click
                    if (!this.field.Discovered.Contains(click_x * buttons[0].Length + click_y))
                        break;
                    int Flagged_Count = 0;
                    foreach (int k in this.field.GetNeighbors(click_x, click_y))
                        if (field.Flagged.Contains(k))
                            Flagged_Count++;
                    if (this.field.CountMines(click_x, click_y) != Flagged_Count)
                        break;
                    foreach (int k in this.field.GetNeighbors(click_x, click_y))
                    {
                        if (field.Flagged.Contains(k) || field.Discovered.Contains(k))
                            continue;
                        if (this.field.IsMine(k / buttons[0].Length, k % buttons[0].Length))
                        {
                            b.BackColor = Color.Red;
                            MessageBox.Show("You lost! " + ((MainForm)Owner).nameBox.Text + " you clicked on a mine!\nYou won in: " + ClockDisplay.Text + " seconds");
                            ended = true;
                            this.Close();
                            break;
                        }
                        foreach (int l in this.field.GetSafeIsland(k/ buttons[0].Length, k% buttons[0].Length))
                        {
                            int i = l / buttons[0].Length;
                            int j = l % buttons[0].Length;
                            buttons[i][j].BackColor = Color.LightGray;
                            int m = this.field.CountMines(i, j);
                            if (m > 0)
                            {
                                buttons[i][j].Text = m + "";
                                buttons[i][j].BackColor = Color.LightBlue;
                            }
                            else
                                buttons[i][j].Enabled = false;
                        }
                        if (field.Win())
                        {
                            MessageBox.Show("Congratulations " + ((MainForm)Owner).nameBox.Text + "! You discovered all safe squares!\nYou won in: " + ClockDisplay.Text + " seconds");
                            ended = true;
                            this.Close();
                        }
                    }
                    break;
            }
        }
        private Button[][] buttons;
        private Field field;
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.ended && this.field.Started)//Closing a game when it is running
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close the game?", "Game In Progress", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ((MainForm)Owner).count--;//reference to mainform that count - 1 of active game amount
                    ((MainForm)Owner).activeGames.Text = "" + (((MainForm)Owner).count);
                }
                else
                    e.Cancel = result == DialogResult.No;//keep playing games
            }
            else//Game finished
            {
                ((MainForm)Owner).count--;
                ((MainForm)Owner).activeGames.Text = "" + (((MainForm)Owner).count);
            }   
        }
        //Set timer
        private void timer_Tick(object sender, EventArgs e)
        {
            ClockDisplay.Text = "" + (Double.Parse(ClockDisplay.Text) + .1);
        }
        //resume the clock when the form gets re-activated
        private void Form2_Activated(object sender, EventArgs e)
        {
            if (this.field.Started)
                timer.Enabled = true;
        }
        //pause the clock of a game if the form containing the game gets deactivated
        private void Form2_Deactivate(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }
    }
}
