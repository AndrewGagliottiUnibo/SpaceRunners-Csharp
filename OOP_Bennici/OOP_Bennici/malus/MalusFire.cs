using System;

namespace OOP_Bennici.malus
{
    /// <summary>
    /// A Status that block player's firing.
    /// </summary>
    public class MalusFire : Status
    {
        /// <summary>
        /// This Constructor, initializes a Status of MalusFire type.
        /// </summary>
        public MalusFire() : base()
        {
            this.StatusName = StatusEnum.MalusFire;
            this.CoolDown = 7;
            this.Effect = new Action(() => { this.Player.CanFire = false; });
            this.RemoveEffect = new Action(() => { this.Player.CanFire = true; });
        }
    }
}
