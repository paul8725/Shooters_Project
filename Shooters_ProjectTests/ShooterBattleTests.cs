using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shooters_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooters_Project.Tests
{
    [TestClass()]
    public class ShooterBattleTests
    {
        [TestMethod()]
        public void ShooterBattleTest()
        {

            ShootLogic shoot = new ShootLogic();
            if (shoot.getNo() > 0)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
            
        }
        [TestMethod()]
        public void ShooterBattleTest2()
        {

            ShootLogic shoot = new ShootLogic();
            if (shoot.getNewNo() < 3)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

        }
    }
}