using NUnit.Framework;
using OOP_Bennici;

namespace OOP_Bennici_Test
{
    /// <summary>
    /// Class Test to verify the correct Status behavior.
    /// </summary>
    public class StatusControllerTest
    {
        private SpaceShip player;
        private StatusController controller;
        private StatusFactory factory;

        [SetUp]
        public void SetUp()
        {
            this.player = new SpaceShip();
            this.controller = new StatusController(this.player);
            this.factory = new StatusFactoryImpl();
        }

        /// <summary>
        /// Testing if BonusLife is applied.
        /// </summary>
        [Test]
        public void BonusLifeTest()
        {
            int prevValue = 3;
            this.player.LifePoints = prevValue;
            this.controller.applyEffect(factory.createStatus(StatusEnum.BonusLife));
            Assert.AreEqual(prevValue + 1, player.LifePoints);
            this.controller.applyEffect(factory.createStatus(StatusEnum.BonusLife));
            Assert.AreEqual(prevValue + 1, player.LifePoints);
        }

        /// <summary>
        /// Testing if BonusSpeed is applied.
        /// </summary>
        [Test]
        public void BonusSpeedTest()
        {
            Status bonusSpeed = factory.createStatus(StatusEnum.BonusSpeed);
            double expectedSpeed = this.player.Speed * bonusSpeed.BoostFactor;
            this.controller.applyEffect(bonusSpeed);
            System.Threading.Thread.Sleep(500);
            Assert.AreEqual(player.Speed, expectedSpeed);
        }

        /// <summary>
        /// Testing if MalusCommand is applied.
        /// </summary>
        [Test]
        public void MalusCommandTest()
        {
            bool prevValue = this.player.InvertedCommand;
            this.controller.applyEffect(factory.createStatus(StatusEnum.MalusCommand));
            System.Threading.Thread.Sleep(500);
            Assert.IsTrue(this.player.InvertedCommand);
        }

        /// <summary>
        /// Testing if MalusSpeed is applied.
        /// </summary>
        [Test]
        public void MalusSpeedTest()
        {
            Status malusSpeed = factory.createStatus(StatusEnum.MalusSpeed);
            double expectedSpeed = this.player.Speed * malusSpeed.BoostFactor;
            this.controller.applyEffect(malusSpeed);
            System.Threading.Thread.Sleep(500);
            Assert.AreEqual(player.Speed, expectedSpeed);
        }

        /// <summary>
        /// Testing if MalusFire is applied.
        /// </summary>
        [Test]
        public void MalusFireTest()
        {
            bool prevValue = this.player.CanFire;
            this.controller.applyEffect(factory.createStatus(StatusEnum.MalusFire));
            System.Threading.Thread.Sleep(500);
            Assert.IsFalse(this.player.CanFire);
        }

        /// <summary>
        /// Verify that cooldown is refreshed after applying for the second time, before
        /// the first expires, a Status(of the same type).
        /// </summary>
        [Test]
        public void RefreshTimeTest()
        {
            this.SetUp();
            this.MalusFireTest();
            Status malusFire = factory.createStatus(StatusEnum.MalusFire);
            int halfCooldownInMillis = (int)(malusFire.CoolDown * 1000) / 2;
            System.Threading.Thread.Sleep(halfCooldownInMillis);
            this.controller.applyEffect(factory.createStatus(StatusEnum.MalusFire));
            System.Threading.Thread.Sleep(halfCooldownInMillis);
            Assert.IsFalse(player.CanFire);
        }
    }
}