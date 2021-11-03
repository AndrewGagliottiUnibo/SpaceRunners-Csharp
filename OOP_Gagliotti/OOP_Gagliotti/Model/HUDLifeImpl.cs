using System;

namespace OOP_Gagliotti.Model
{
    /// <summary>
    /// HUD lives partial implementation.
    /// </summary>
    public class HUDLifeImpl : IHUDLife
    {
        /// <summary>
        /// Variables.
        /// </summary>
        private readonly int ZERO = 0;
        private readonly int LIFE_UP = 1;
        private readonly int LIFE_DOWN = -1;
        private readonly int INITIAL_LIFE_POINTS = 3;
        private readonly int LESS_LIVES_POSSIBLE = 1;
        private readonly int MAX_LIVE_POSSIBLE = 4;

        private int lifePoints;
        private bool gameStatus;

        /// <summary>
        /// Constructor.
        /// </summary>
        public HUDLifeImpl()
        {
            this.lifePoints = INITIAL_LIFE_POINTS;
            this.gameStatus = true;
            //here missing GUI setup
        }

        public int GetLifePoints()
        {
            return this.lifePoints;
        }

        public void LifeUp()
        {
            if (this.GetLifePoints() < MAX_LIVE_POSSIBLE)
            {
                //here missing GUI update
                this.lifePoints++;
                Console.WriteLine("Life up");
                Console.WriteLine("Actual lives are {0}", this.GetLifePoints());
            }
        }

        public void LifeDown()
        {
            if (this.GetLifePoints() > LESS_LIVES_POSSIBLE)
            {
                this.lifePoints--;
                //here missing GUI update
                Console.WriteLine("Life down");
                Console.WriteLine("Actual lives are {0}", this.GetLifePoints());
            }
            else
            {
                this.lifePoints = ZERO;
                this.gameStatus = false;
            }
        }

        public bool GetStatus()
        {
            Console.WriteLine("Game Status now is {0}", this.gameStatus);
            return this.gameStatus;
        }
    }
}
