using System;

namespace OOP_Bennici.malus
{
    /// <summary>
    /// A Status that reverses player's movement commands.
    /// </summary>
    public class MalusCommand : Status
    {
        /// <summary>
        /// This Constructor, initializes a Status of MalusCommand type.
        /// </summary>
        public MalusCommand() : base()
        {
            this.StatusName = StatusEnum.MalusCommand;
            this.CoolDown = 10;
            this.Effect = new Action(() => { this.Player.InvertedCommand = true; });
            this.RemoveEffect = new Action(() => { this.Player.InvertedCommand = false; });
        }
    }
}
