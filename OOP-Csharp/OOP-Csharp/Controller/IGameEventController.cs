using OOP_Csharp.Model;

namespace OOP_Csharp
{
    /// <summary>
    /// I could implements the behaviour of this class partially: this is due to fact to not esagerate 
    /// in recreating all of the behaviour of all classes.
    /// Missing some methods implemented in Java.
    /// </summary>
    interface IGameEventController
    {
        /// <summary>
        /// Ends the game.
        /// </summary>
        void EndGame();

        /// <summary>
        /// Checks if game status is true
        /// </summary>
        /// <returns> gameStatus value </returns>
        bool CheckGameStatus();

        /// <summary>
        /// Check the value of the points.
        /// </summary>
        /// <returns> points value </returns>
        int CheckPoints();

        /// <summary>
        /// Check the value of the points
        /// </summary>
        /// <returns> life counter value </returns>
        int CheckLives();

        /// <summary>
        /// Bonus HUD reference
        /// </summary>
        /// <returns> bonus hud reference </returns>
        IHUDBonus GetBonus();
    }
}
