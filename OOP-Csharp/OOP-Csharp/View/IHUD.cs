using OOP_Csharp.Model;

/// <summary>
/// Hud view interface makes a bridge to the controller.
/// </summary>
namespace OOP_Csharp.View
{
    interface IHUD
    {
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
