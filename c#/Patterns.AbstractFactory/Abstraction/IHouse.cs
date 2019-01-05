namespace Patterns.AbstractFactory.Abstraction
{
    public interface IHouse
    {
        void AddWall(IHouseWall wall);
        void AddRoof(IHouseRoof roof);
    }
}
