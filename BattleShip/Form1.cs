using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace BattleShip
{
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }
        //private SoundPlayer soundplayer ;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play p = new Play();
            p.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult ok = MessageBox.Show("Are you sure you want to exit ?","Exit", MessageBoxButtons.YesNo);
            if(ok==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //private void button5_MouseHover(object sender, EventArgs e)
        //{
        //}

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.ForeColor = Color.White;
        }

        public void play_sound(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer(@"D:\BattleShip\BattleShipUpdated\BattleShipUpdated\BattleShipUpdated\BattleShip\BattleShip\Resources\game.wav");
            s.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Credits c = new Credits();
            c.Show();
        }

        private void button5_MouseHover(object sender, MouseEventArgs e)
        {
            Button b = (Button) sender;
            b.ForeColor = Color.DarkGreen;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }
    }
}
