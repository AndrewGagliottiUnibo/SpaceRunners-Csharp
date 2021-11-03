using OOP_Csharp.Model;
using OOP_Csharp.View;

namespace OOP_Csharp
{
    /// <summary>
    /// View implementations that realize a bridge to the controller.
    /// </summary>
    class HUDImpl : IHUD
    {
        private IHUDPoints pointsHUD;
        private IHUDLife livesHUD;
        private IHUDBonus bonusHUD;

        /// <summary>
        /// Constructor.
        /// </summary>
        public HUDImpl()
        {
            this.CreateHUD();
        }

        /// <summary>
        /// Create all HUD model parts.
        /// </summary>
        private void CreateHUD()
        {
            this.pointsHUD = new HUDPointsImpl();
            this.livesHUD = new HUDLifeImpl();
            this.bonusHUD = new HUDBonusImpl();
        }

        public bool CheckGameStatus()
        {
            return this.livesHUD.GetStatus();
        }
        public int CheckPoints()
        {
            return this.pointsHUD.GetPoints();
        }

        public int CheckLives()
        {
            return this.livesHUD.GetLifePoints();
        }
        public IHUDBonus GetBonus()
        {
            return this.bonusHUD;
        }
    }
}
