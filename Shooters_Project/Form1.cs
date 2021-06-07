using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooters_Project
{
    public partial class Form1 : Form
    {
        int y = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y = y + 10;
            if (y < 100)
            {
                progressBar1.Value = y;
            }
            else {
                timer1.Stop();
                ShooterBattle obj = new ShooterBattle();
                obj.ShowDialog();
            }
        }
    }
}
