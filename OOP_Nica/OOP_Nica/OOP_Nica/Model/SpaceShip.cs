
namespace OOP_Nica.Model
{

public abstract class SpaceShip : EntityImpl {

    private int lifePoints;
     private bool invertedCommand;
    //private GameField gameField;

    /**
     * Constructor.
     * 
     * @param gamefield
     */
    public SpaceShip() {

    
        base.SetSpeed(10);

        this.setInvertedCommand(false);
        base.SetCanFire(true);

        
    }

    /**
     * Return spaceship lifepoints.
     * 
     * @return
     */
    public int getLifePoints() {
        return this.lifePoints;
    }

    /**
     * Set space ship lifepoints.
     * 
     * @param lifepoint
     */
    public void setLifePoints( int lifepoint) {
        this.lifePoints = lifepoint;
    }

    /**
     * Increase lifepoints.
     * 
     * @param points
     */
    public void increaseLifePoints(int points) {
        this.lifePoints += points;
    }

    /**
     * Decrease lifepoints.
     * 
     * @param points
     */
    public void decreaselifePoints(int points) {
        this.lifePoints -= points;
    }

    /**
     * @return true if commands are inverted
     */
    public bool isInvertedCommand() {
        return this.invertedCommand;
    }

    /**
     * Set if the commands are inverted or not.
     * 
     * @param invertedCommand
     */
    public void setInvertedCommand(bool invertedCommand) {
        this.invertedCommand = invertedCommand;
    }

    /**
     * Cause the boss to move down of some frames.
     */
    public void  drop() {
        this.SetPosition(10,10);
                
    }

    /**
     * @return GameField reference.
     */
    /*public GameField getGameFieldReference() {
        return this.gameField;
    }*/

    /**
     * attack.
     */
    public abstract void attack();
}

}