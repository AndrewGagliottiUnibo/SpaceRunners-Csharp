using System;

namespace OOP_Bennici.bonus
{
    /// <summary>
    /// A Status that, below a certain maximum, add 1 bonus life to the player.
    /// </summary>
    public class BonusLife : Status
    {
        /// <summary>
        /// This Constructor, initializes a Status of BonusLife type.
        /// </summary>
        public BonusLife() : base()
        {
            this.StatusName = StatusEnum.BonusLife;
            this.CoolDown = 1;
            this.Effect = new Action(() =>
            {
                if (this.Player.LifePoints < 4)
                {
                    this.Player.LifePoints = this.Player.LifePoints + 1;
                }
            });
            this.RemoveEffect = new Action( () => { });
        }
    }
}
