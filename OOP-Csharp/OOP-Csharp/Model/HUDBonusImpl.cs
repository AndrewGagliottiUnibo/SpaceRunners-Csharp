namespace OOP_Csharp.Model
{
    /// <summary>
    /// HUD bonuses partial implementation.
    /// </summary>
    class HUDBonusImpl : IHUDBonus
    {
        /// <summary>
        /// Variables.
        /// </summary>
        private readonly int MAX_BONUS_POSSIBLE = 5;
        private bool[] statusTracker;
        private string[] bonus;

        /// <summary>
        /// Constructor.
        /// </summary>
        public HUDBonusImpl()
        {
            this.statusTracker = new bool[MAX_BONUS_POSSIBLE];
            this.bonus = new string[]
            {
                "Life", "SpeedUp", "NoShoot", "InvertCommand", "SpeedDown"
            };
            //here missing GUI setup
        }

        public string[] GetBonus()
        {
            return this.bonus;
        }

        public void ShowBonus(int index)
        {
            this.statusTracker[index] = true;
            //here missing GUI update
        }

        public void HideBonus(int index)
        {
            this.statusTracker[index] = false;
            //here missing GUI update
        }

        public bool GetTracker(int index)
        {
            return this.statusTracker[index];
        }
    }
}
