using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_Gagliotti.Model;
using System;

namespace TestProject1
{
    [TestClass]
    public class HUDTest
    {
        /// <summary>
        /// Readonly fields.
        /// </summary>
        private readonly int ZERO = 0;
        private readonly int ONE = 1;
        private readonly int THREE = 3;
        private readonly int FOUR = 4;
        private readonly int FIVE = 5;
        private readonly int TEN = 10;
        private readonly int MAX_POINTS_POSSIBLE = 999;

        /// <summary>
        /// Variables.
        /// </summary>
        private IHUDBonus bonus;
        private IHUDLife life;
        private IHUDPoints points;

        [TestMethod]
        public void TestLifeCounterBehaviour()
        {
            this.life = life = new HUDLifeImpl();
            // Beginning
            Assert.IsTrue(this.life.GetLifePoints() == THREE);
            Assert.IsTrue(this.life.GetStatus());

            // Increment - also border line case: lives can't be more than 4
            this.life.LifeUp();
            Assert.IsTrue(this.life.GetLifePoints() == FOUR);
            Assert.IsTrue(this.life.GetStatus());
            this.life.LifeUp();
            Assert.IsFalse(this.life.GetLifePoints() == FIVE);
            Assert.IsTrue(this.life.GetLifePoints() == FOUR);

            // Decrement
            this.life.LifeDown();
            this.life.LifeDown();
            this.life.LifeDown();
            Assert.IsTrue(this.life.GetLifePoints() == ONE);
            Assert.IsTrue(this.life.GetStatus());

            //Game ends
            this.life.LifeDown();
            Assert.IsTrue(this.life.GetLifePoints() == ZERO);
            Assert.IsFalse(this.life.GetStatus());
        }

        [TestMethod]
        public void TestBonusCounterBehaviour()
        {
            this.bonus = new HUDBonusImpl();

            // All bonuses are off int the beginning
            for (int i = 0; i < FIVE; i++)
            {
                Assert.IsFalse(this.bonus.GetTracker(i));
            }

            // Showing a bonus, one is active, others not
            this.bonus.ShowBonus(ONE);
            Assert.IsTrue(this.bonus.GetTracker(ONE));
            for (int i = 0; i < FIVE; i++)
            {
                if (i != ONE) 
                {
                    Assert.IsFalse(this.bonus.GetTracker(i));
                }
            }

            // Multiple calls don't break the application
            try
            {
                this.bonus.ShowBonus(ONE);
                this.bonus.ShowBonus(ONE);
                this.bonus.ShowBonus(ONE);
                this.bonus.ShowBonus(ONE);
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }

        [TestMethod]
        public void TestPointsCounterBehaviour()
        {
            this.points = new HUDPointsImpl();
            this.life = new HUDLifeImpl();

            // Points at the beginning are 0
            Assert.IsTrue(this.points.GetPoints() == ZERO);

            // Increment
            this.points.PointsUp();
            Assert.IsTrue(this.points.GetPoints() == ONE);
            this.points.PointsSetter(TEN);
            Assert.IsTrue(this.points.GetPoints() == (TEN + ONE));

            // Decrement
            this.points.PointsDown();
            Assert.IsTrue(this.points.GetPoints() == (TEN + ONE - FIVE));
            this.points.PointsDown();
            Assert.IsTrue(this.points.GetPoints() == ONE);

            // Border-line case: can't go below zero
            this.points.PointsDown();
            Assert.IsTrue(this.points.GetPoints() == ZERO);

            // Border-line case: can't go over 999
            this.points.PointsSetter(MAX_POINTS_POSSIBLE);
            Assert.IsTrue(this.points.GetPoints() == MAX_POINTS_POSSIBLE);
            this.points.PointsUp();
            this.points.PointsUp();
            this.points.PointsUp();
            this.points.PointsUp();
            Assert.IsTrue(this.points.GetPoints() == MAX_POINTS_POSSIBLE);
        }
    }
}
