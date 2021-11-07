using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_Nica.Model;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private IEntity enemy;
        private IEntity boss;
        private IEntity player;

        [TestMethod]
        public void EntityGeneralBehaviour()
        {
            this.enemy = new EntityImpl("naveNemica", "down");
            this.boss = new EntityImpl("boss", "down");
            this.player = new EntityImpl("player", "none");
        }
    }
}
