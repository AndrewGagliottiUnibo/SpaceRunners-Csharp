using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_Nica.Model;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
    
        private IEntity bullet;
        private IEntity player;

        [TestMethod]
        public void EntityGeneralBehaviour()
        {
            this.player = new PlayerSpaceShip();
            this.bullet = new Bullet();
        }

        [TestMethod]
        public void checkspeed()
        {
            player.SetSpeed(10);
            Assert.IsTrue(player.GetSpeed()==10);
            
        }
        
        [TestMethod]
          public void checksPosition()
        {
            player.SetPosition(10,10);
            Assert.IsTrue(player.GetXPosition()==10);
            Assert.IsTrue(player.GetYPosition()==10);
        }



    }
}
