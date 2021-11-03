using System;

namespace OOP_Bennici
{
    /// <summary>
    /// An entity that store an effect (bonus or malus), that can be applied to an entity.
    /// Any type of effect are temporary, each of them have a different cooldown.
    /// </summary>
    public class Status
    {
        private long coolDown;
        private double boostFactor;

        private SpaceShip player;
        private Action effect;
        private Action removeEffect;
        private StatusEnum statusName;

        /// <value>Property <c>CoolDown</c> represents the the maximum cooldown in seconds of this status.</value>
        public long CoolDown { get => coolDown; set => coolDown = value; }

        /// <value>Property <c>BoostFactor</c> represents the value of this boost factor.</value>
        public double BoostFactor { get => boostFactor; set => boostFactor = value; }

        /// <value>Property <c>Player</c> represents the Player's reference.</value>
        public SpaceShip Player { get => player; set => player = value; }

        /// <value>Property <c>Effect</c> represents the action of the effect of this status.</value>
        public Action Effect { get => effect; set => effect = value; }

        /// <value>Property <c>RemoveEffect</c> represents the action to remove the effect of this status.</value>
        public Action RemoveEffect { get => removeEffect; set => removeEffect = value; }

        /// <value>Property <c>StatusName</c> represents the name type of this Status.</value>
        public StatusEnum StatusName { get => statusName; set => statusName = value; }
    }
}
