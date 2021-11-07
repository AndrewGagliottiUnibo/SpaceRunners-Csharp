public class Bullet: EntityImpl {

    private int damage;

    /**
     * Constructor.
     */
    public Bullet() {
        // set default
        this.setImage(MagicEnumImage.BULLET.getImage());
        this.setDirection(Direction.UP);
        this.getNode().setViewOrder(MagicEnumInt.BULLET_VIEW_ORDER.getValue());

        this.getNode().setScaleX(MagicEnumDouble.BULLET_SCALE.getValue());
        this.getNode().setScaleY(MagicEnumDouble.BULLET_SCALE.getValue());
    }

    /**
     * @param damage
     * @return
     */
    public Bullet bulletDamage(int damage) {
        this.damage = damage;
        return this;
    }

    /**
     * @return bullet damage.
     */
    public int getBulletDamage() {
        return this.damage;
    }

    /**
     * @return bounds of entities.
     */
    public Rectangle getBounds() {
        return new Rectangle();
    }
}