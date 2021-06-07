using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooters_Project
{
   public class ShootLogic
    {
        Random random = new Random();
        public int getNo() {
            return random.Next(1, 5);
        }

        // random function working

        public int getNewNo()
        {
            return random.Next(1, 3);
        }

        public void disble(Button btn) {
            btn.Enabled = false;
        }
        public void Enble(Button btn)
        {
            btn.Enabled = true;
        }



    }
}
