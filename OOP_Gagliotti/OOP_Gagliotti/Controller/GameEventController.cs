using OOP_Gagliotti.Model;
using OOP_Gagliotti.View;
using System;

namespace OOP_Gagliotti.Controller
{
    /// <summary>
    /// I could implements the behaviour of this class partially: this is due to fact to not esagerate 
    /// in recreating all of the behaviour of all classes.
    /// Missing some methods implemented in Java.
    /// 
    /// Here you can monitorate all variables behaviour and in the end, end the game.
    /// </summary>
    public class GameEventController : IGameEventController
    {
        private IHUD hudBuilder;

        /// <summary>
        /// Constructor.
        /// </summary>
        public GameEventController()
        {
            this.hudBuilder = new HUDImpl();
        }

        public void EndGame()
        {
            Console.WriteLine("Game ends...");
        }

        public bool CheckGameStatus()
        {
            return this.hudBuilder.CheckGameStatus();
        }

        public int CheckPoints()
        {
            return this.hudBuilder.CheckPoints();
        }

        public int CheckLives()
        {
            return this.hudBuilder.CheckLives();
        }

        public IHUDBonus GetBonus()
        {
            return this.hudBuilder.GetBonus();
        }
    }
}
