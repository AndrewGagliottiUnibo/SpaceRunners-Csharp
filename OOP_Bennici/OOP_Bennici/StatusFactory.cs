namespace OOP_Bennici
{
    /// <summary>
    /// Factory Interface to create Status Object.
    /// </summary>
    public interface StatusFactory
    {
        /// <summary>
        /// Get a new Status.
        /// </summary>
        /// <param name="type"></param>
        /// <returns>Status</returns>
        Status createStatus(StatusEnum type);
    }
}