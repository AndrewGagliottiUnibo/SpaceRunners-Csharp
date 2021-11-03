using System;

namespace OOP_Bennici.bonus
{
    /// <summary>
    /// A Status that boost player's speed of a certain amount.
    /// </summary>
    public class BonusSpeed : Status
    {
        /// <summary>
        /// This Constructor, initializes a Status of BonusSpeed type.
        /// </summary>
        public BonusSpeed() : base()
        {
            this.StatusName = StatusEnum.BonusSpeed;
            this.CoolDown = 7;
            this.BoostFactor = 1.5;
            this.Effect = new Action(() => { this.Player.Speed = this.Player.Speed * this.BoostFactor; });
            this.RemoveEffect = new Action(() => { this.Player.Speed = this.Player.Speed * (1.0/this.BoostFactor); });
        }
    }
}
