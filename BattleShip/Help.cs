using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BattleShip
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void AA10_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.wikihow.com/Play-Battleship");
        }
    }
}
