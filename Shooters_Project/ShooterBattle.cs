using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooters_Project
{
    public partial class ShooterBattle : Form
    {
        // var declaration here
        ShootLogic shoot = new ShootLogic();
        int chk = 0, chkNo = 0, count = 0, counter = 0,counterchk=0;
        int trigger = 4;
        public ShooterBattle()
        {
            InitializeComponent();
            //clling the method to disble  the button
            shoot.disble(spin_button);
            shoot.disble(fire_button);
            shoot.disble(fire_away_button);
            shoot.disble(restart_button);
            chkNo = shoot.getNo();
            counterchk = shoot.getNewNo();

            textBox_of_chances.Text = "" + trigger;
            textBox_of_chances.Enabled = false;
        }

        // load gun button working 

        private void load_gun_Click(object sender, EventArgs e)
        {
            ImgBox.Image = Shooters_Project.Properties.Resources.load;
            shoot.disble(load_gun);
            shoot.Enble(spin_button);
        }

        // application restarting

        private void restart_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ShooterBattle_Load(object sender, EventArgs e)
        {
            
        }

        // fireaway button working

        private void fire_away_button_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  
            ImgBox.Image = Shooters_Project.Properties.Resources.fire_away;

            // code for sound//
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Shooters_Project.Properties.Resources.sound1);

            Sound_Object.Play();

            counter++;
            if (counter == counterchk)
            {
                MessageBox.Show("Allass You lose the Game");
                shoot.disble(fire_away_button);
                shoot.Enble(restart_button);
            }
            
           else  if (counter==2) {
                shoot.disble(fire_away_button);
                shoot.Enble(restart_button);
            }
            else
            {
                MessageBox.Show("Empty Shoot ");
            }

        }

        private void fire_button_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  
            
            ImgBox.Image = Shooters_Project.Properties.Resources.fire_shoot;
            // code for sound//
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Shooters_Project.Properties.Resources.sound1);

            Sound_Object.Play();

            chk++;

            if (chk == chkNo)
            {
                MessageBox.Show("Allass You lose the Game");
                shoot.disble(fire_button);
                shoot.Enble(restart_button);

                count++;
            }
            else if (chk == 4 && chk == 0) {
                MessageBox.Show("You Won the Game ");
                shoot.disble(fire_button);
                shoot.Enble(restart_button);
            }
            else
            {
                MessageBox.Show("Empty Shoot ");
            }
            trigger--;
            textBox_of_chances.Text = "" + trigger;



        }

        // spin button working 

        private void spin_button_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            ImgBox.Image = Shooters_Project.Properties.Resources.spin_gun; 

            shoot.disble(spin_button);
            shoot.Enble(fire_away_button);
            shoot.Enble(fire_button);
        }
    }
}
