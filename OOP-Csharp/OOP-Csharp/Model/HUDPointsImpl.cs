using OOP_Csharp;
using System;

namespace OOP_Csharp.Model
{
    /// <summary>
    /// HUD points partial implementation.
    /// </summary>
    class HUDPointsImpl : IHUDPoints
    {
        /// <summary>
        /// Variables.
        /// </summary>
        private readonly int ZERO = 0;
        private readonly int POINTS_UP = 1;
        private readonly int POINTS_DOWN = 5;
        private readonly int MAX_POINTS_POSSIBLE = 999;

        private int points;

        /// <summary>
        /// Constructor.
        /// </summary>
        public HUDPointsImpl()
        {
            this.points = ZERO;
            //here missing GUI setup
        }
        public int GetPoints()
        {
            return this.points;
        }

        public void PointsUp()
        {
            if (this.GetPoints() < MAX_POINTS_POSSIBLE)
            {
                this.PointsSetter(POINTS_UP);
            }
        }

        public void PointsDown()
        {
            if (this.GetPoints() < POINTS_DOWN)
            {
                this.PointsSetter(-this.GetPoints());
            }
            else
            {
                this.PointsSetter(POINTS_DOWN);
            }
        }

        public void PointsSetter(int value)
        {
            this.points += value;
            //here missing GUI update
            Console.WriteLine("Actual points are {0}", this.GetPoints());
        }
    }
}
