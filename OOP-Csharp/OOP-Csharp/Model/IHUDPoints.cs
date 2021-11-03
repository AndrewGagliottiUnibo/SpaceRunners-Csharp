namespace OOP_Csharp
{
    /// <summary>
    /// Points HUD interface.
    /// </summary>
    interface IHUDPoints
    {
        /// <summary>
        /// Checks actual points.
        /// </summary>
        /// <returns> value of actual points </returns>
        int GetPoints();

        /// <summary>
        /// Points go up by one.
        /// </summary>
        void PointsUp();

        /// <summary>
        /// Points go down by five.
        /// </summary>
        void PointsDown();

        /// <summary>
        /// Set the points counter to the value you want to.
        /// </summary>
        /// <param name="value"></param>
        void PointsSetter(int value);
    }
}
