namespace OOP_Gagliotti.Model
{
    /// <summary>
    /// Lives HUD interface.
    /// </summary>
    public interface IHUDLife
    {
        /// <summary>
        /// Checks actual life points.
        /// </summary>
        /// <returns> value of actual life points </returns>
        int GetLifePoints();

        /// <summary>
        /// Life goes up by one.
        /// </summary>
        void LifeUp();

        /// <summary>
        /// Life goes down by one.
        /// </summary>
        void LifeDown();

        /// <summary>
        /// Check if game can still run.
        /// </summary>
        /// <returns> true if game can run </returns>
        bool GetStatus();
    }
}
