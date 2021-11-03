using System;

namespace OOP_Bennici
{
    /// <summary>
    /// An entity that represents player's ship.
    /// </summary>
    public class SpaceShip
    {
        private int lifePoints;
        private Boolean invertedCommand;
        private Boolean canFire;
        private double speed;

        /// <summary>
        /// This Constructor, initializes a SpaceShip entity.
        /// </summary>
        public SpaceShip()
        {
            this.LifePoints = 3;
            this.Speed = 10;
            this.InvertedCommand = false;
            this.CanFire = true;
        }

        /// <value>Property <c>Speed</c> represents the current speed of this SpaceShip.</value>
        public double Speed { get => speed; set => speed = value; }

        /// <value>Property <c>CanFire</c> represents the possibility to fire for this SpaceShip.</value>
        public bool CanFire { get => canFire; set => canFire = value; }

        /// <value>Property <c>InvertedCommand</c> represents the command behaviour of this SpaceShip.</value>
        public Boolean InvertedCommand { get => invertedCommand; set => invertedCommand = value; }

        /// <value>Property <c>LifePoints</c> represents the current number of lifePoints of this SpaceShip.</value>
        public int LifePoints { get => lifePoints; set => lifePoints = value; }
    }
}
