using System.Collections.Generic;
using Patterns.AbstractFactory.Abstraction;
using Patterns.AbstractFactory.Concrete.Houses;
using Patterns.AbstractFactory.Concrete.Roofs;
using Patterns.AbstractFactory.Concrete.Walls;

namespace Patterns.AbstractFactory.Concrete
{
    public class BrickHouseFactory : HouseAbstractFactory
    {
        public override IHouse GetHouse()
        {
            return new BrickHouse();
        }

        public override IHouse GetDefaultHouse()
        {
            var walls = new List<IHouseWall>
            {
                new BrickWall(),
                new BrickWall(),
                new BrickWall(),
                new BrickWall()
            };

            var roofs = new List<IHouseRoof>
            {
                new BrickHouseRoof()
            };

            return new BrickHouse(walls, roofs);
        }

        public override IHouseRoof GetRoof()
        {
            return new BrickHouseRoof();
        }

        public override IHouseWall GetWall()
        {
            return new BrickWall();
        }
    }
}