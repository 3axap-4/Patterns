using System.Collections.Generic;
using Patterns.AbstractFactory.Abstraction;
using Patterns.AbstractFactory.Concrete.Houses;
using Patterns.AbstractFactory.Concrete.Roofs;
using Patterns.AbstractFactory.Concrete.Walls;

namespace Patterns.AbstractFactory.Concrete
{
    public class WoodHouseFactory : HouseAbstractFactory
    {
        public override IHouse GetHouse()
        {
            return new WoodHouse();
        }

        public override IHouse GetDefaultHouse()
        {
            var walls = new List<IHouseWall>
            {
                new WoodWall(),
                new WoodWall(),
                new WoodWall(),
                new WoodWall()
            };

            var roofs = new List<IHouseRoof>
            {
                new WoodHouseRoof()
            };

            return new WoodHouse(walls, roofs);
        }

        public override IHouseRoof GetRoof()
        {
            return new WoodHouseRoof();
        }

        public override IHouseWall GetWall()
        {
            return new WoodWall();
        }
    }
}