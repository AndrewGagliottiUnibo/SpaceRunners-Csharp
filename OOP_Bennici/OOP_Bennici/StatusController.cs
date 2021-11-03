using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OOP_Bennici
{
    /// <summary>
    ///  Controller Status class.
    ///  When certain condition are triggered, this class
    ///  applies a StatusEffect of an Status instance to the player.
    /// </summary>
    public class StatusController
    {
        private SpaceShip player;
        private Dictionary<StatusEnum, Task> playerStatus;

        /// <summary>
        /// This Constructor, initializes a StatusController instance.
        /// </summary>
        /// <param name="player"></param>
        public StatusController(SpaceShip player)
        {
            this.player = player;
            this.playerStatus = new Dictionary<StatusEnum, Task>();
            this.initializePlayerStatus();
        }

        /// <summary>
        /// Initialize all the Player's status.
        /// </summary>
        private void initializePlayerStatus()
        {
            foreach (StatusEnum e in Enum.GetValues(typeof(StatusEnum)))
            {
                this.playerStatus.Add(e, new Task(() => { }));
            }
        }

        /// <summary>
        /// Applying StatusEffect to the Player. Every Status has his own expiring time.
        /// </summary>
        /// <param name="status"></param>
        public void applyEffect(Status status)
        {
            status.Player = this.player;
            Task task = this.playerStatus[status.StatusName];
            // Adding effect if never added before or already terminated
            if (task.IsCompleted || !task.IsCanceled)
            {
                Task.Run(status.Effect);
            }
            else
            {
            // Else, refresh task's time
                task.Dispose();
            }
            task = Task.Delay(TimeSpan.FromSeconds(status.CoolDown)).ContinueWith((e) => status.RemoveEffect);
            this.playerStatus[status.StatusName] = task;
        }
    }
}