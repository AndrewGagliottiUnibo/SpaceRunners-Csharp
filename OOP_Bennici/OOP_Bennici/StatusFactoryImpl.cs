using OOP_Bennici.bonus;
using OOP_Bennici.malus;

namespace OOP_Bennici
{
    /// <summary>
    /// Factory Implementation to create Status Object.
    /// </summary>
    public class StatusFactoryImpl : StatusFactory
    {
        /// <inheritdoc />
        public Status createStatus(StatusEnum type)
        {
            return type switch
            {
                StatusEnum.BonusLife => new BonusLife(),
                StatusEnum.BonusSpeed => new BonusSpeed(),
                StatusEnum.MalusCommand => new MalusCommand(),
                StatusEnum.MalusFire => new MalusFire(),
                StatusEnum.MalusSpeed => new MalusSpeed(),
                _ => null,
            };
        }

    }
}