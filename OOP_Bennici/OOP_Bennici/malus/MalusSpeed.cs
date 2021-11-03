using System;

namespace OOP_Bennici.malus
{
    /// <summary>
    /// A Status that decrease player's speed of a certain amount.
    /// </summary>
    public class MalusSpeed : Status
    {
        /// <summary>
        /// This Constructor, initializes a Status of MalusSpeed type.
        /// </summary>
        public MalusSpeed() : base()
        {
            this.StatusName = StatusEnum.MalusSpeed;
            this.CoolDown = 7;
            this.BoostFactor = 0.6;
            this.Effect = new Action(() => { this.Player.Speed = this.Player.Speed * this.BoostFactor; });
            this.RemoveEffect = new Action(() => { this.Player.Speed = this.Player.Speed * (1.0 / this.BoostFactor); });
        }
    }
}
