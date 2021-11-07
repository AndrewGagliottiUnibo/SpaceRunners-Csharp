namespace OOP_Nica.Model
{
    /// <summary>
    /// Entity interface.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Set entity position.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void SetPosition(int x, int y);

        /// <summary>
        /// Return position x value
        /// </summary>
        /// <returns> x position </returns>
        int GetXPosition();

        /// <summary>
        /// Return position y value
        /// </summary>
        /// <returns> y position </returns>
        int GetYPosition();

        /// <summary>
        /// Show speed value.
        /// </summary>
        /// <returns> speed value </returns>
        int GetSpeed();

        /// <summary>
        /// Set a speed value.
        /// </summary>
        /// <param name="speed"></param>
        void SetSpeed(int speed);

        /// <summary>
        /// Set a horizontal speed.
        /// </summary>
        /// <param name="speed"></param>
        void SetHorizontalSpeed(int speed);

        /// <summary>
        /// Show a speed value.
        /// </summary>
        /// <returns> Speed value </returns>
        int GetHorrizontalSpeed();
    }
}
