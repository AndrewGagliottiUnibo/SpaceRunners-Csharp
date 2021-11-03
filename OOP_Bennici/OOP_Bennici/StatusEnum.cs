using System;

namespace OOP_Bennici
{
    /// <summary>
    /// Enumeration containing all Status type.
    /// </summary>
    public enum StatusEnum
    {
        BonusLife,
        BonusSpeed,
        MalusCommand,
        MalusSpeed,
        MalusFire
    }

    /// <summary>
    /// Class containing useful method for <c>StatusEnum</c> enum.
    /// </summary>
    public static class StatusEnumMethods
    {
        /// <summary>
        /// Return a random StatusEnum type.
        /// </summary>
        /// <returns>StatusEnum</returns>
        public static StatusEnum getRandom()
        {
            Array values = Enum.GetValues(typeof(StatusEnum));
            Random random = new Random();
            return (StatusEnum)values.GetValue(random.Next(values.Length));
        }
    }
}