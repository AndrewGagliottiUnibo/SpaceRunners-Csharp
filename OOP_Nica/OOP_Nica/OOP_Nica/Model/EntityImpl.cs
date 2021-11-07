namespace OOP_Nica.Model
{
    public class EntityImpl : IEntity
    {
        private readonly string name;
        private int speed;
        private int horrizontalSpeed;
        private int positionX;
        private int positionY;
        private bool canFire;
        private string direction;

        public EntityImpl()
        {
         
        }

        public void SetPosition(int x, int y)
        {
            this.positionX = x;
            this.positionY = y;
        }

        public int GetXPosition()
        {
            return this.positionX;
        }

        public int GetYPosition()
        {
            return this.positionY;
        }

        public int GetSpeed()
        {
            return this.speed;
        }

        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }

        public void SetHorizontalSpeed(int speed)
        {
            this.horrizontalSpeed = speed;
        }

        public int GetHorrizontalSpeed()
        {
            return this.horrizontalSpeed;
        }

        public bool GetCanFire()
        {
            return this.canFire;
        }

        public void SetCanFire(bool canFire)
        {
            this.canFire = canFire;
        }

        /// <summary>
        /// Change actual direction.
        /// </summary>
        /// <param name="newDirection"></param>
        public void ChangeDirection(string newDirection)
        {
            this.direction = newDirection;
        }

        /// <summary>
        /// Show actual direction.
        /// </summary>
        /// <returns> direction value </returns>
        public string GetDirection()
        {
            return this.direction;
        }

        /// <summary>
        /// Shows name value.
        /// </summary>
        /// <returns> name value </returns>
        public string GetName()
        {
            return this.name;
        }
    }
}
