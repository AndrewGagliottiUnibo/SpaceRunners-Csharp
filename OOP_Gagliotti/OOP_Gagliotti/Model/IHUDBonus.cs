namespace OOP_Gagliotti.Model
{
    /// <summary>
    /// Bonus HUD interface.
    /// </summary>
    public interface IHUDBonus
    {
        /// <summary>
        /// All bonuses.
        /// </summary>
        /// <returns> all bonuses names </returns>
        string[] GetBonus();

        /// <summary>
        /// Displays a bonus.
        /// </summary>
        /// <param name="index"></param>
        void ShowBonus(int index);

        /// <summary>
        /// Hides a bonus.
        /// </summary>
        /// <param name="index"></param>
        void HideBonus(int index);

        /// <summary>
        /// Shows if a particular bonus is active or not.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>true if bonus is active </returns>
        bool GetTracker(int index);
    }
}
