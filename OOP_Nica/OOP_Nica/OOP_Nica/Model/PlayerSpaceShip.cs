namespace OOP_Nica.Model
{
    public class PlayerSpaceShip: SpaceShip {

    /**
     * Constructor.
     * 
     * @param gamefield
     */
    public PlayerSpaceShip() {

       base.setLifePoints(3);
    
    }

    
    public override void  attack() {
        Bullet bullet = new Bullet().bulletDamage(10);
        bullet.SetPosition(2,2);

        bullet.SetSpeed(10);

     
    } 

    

}
}
