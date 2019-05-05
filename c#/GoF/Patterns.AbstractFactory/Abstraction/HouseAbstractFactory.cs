namespace Patterns.AbstractFactory.Abstraction
{
    public abstract class HouseAbstractFactory
    {
        public abstract IHouse GetHouse();
        public abstract IHouse GetDefaultHouse();
        public abstract IHouseWall GetWall();
        public abstract IHouseRoof GetRoof();
    }
}