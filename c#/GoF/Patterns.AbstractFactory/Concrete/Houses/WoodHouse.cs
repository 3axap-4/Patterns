using System;
using System.Linq;
using System.Collections.Generic;
using Patterns.AbstractFactory.Abstraction;

namespace Patterns.AbstractFactory.Concrete.Houses
{
    public class WoodHouse : IHouse
    {
        private ICollection<IHouseWall> _walls;
        private ICollection<IHouseRoof> _roofs;

        public WoodHouse()
        {
            _walls = new List<IHouseWall>();
            _roofs = new List<IHouseRoof>();
        }

        public WoodHouse(IEnumerable<IHouseWall> walls,
             IEnumerable<IHouseRoof> roofs)
        {
            _walls = walls.ToList();
            _roofs = roofs.ToList();
        }

        public void AddWall(IHouseWall wall) => _walls.Add(wall);

        public void AddRoof(IHouseRoof roof) => _roofs.Add(roof);

        public override string ToString()
        {
            var s = "";
            foreach (var w in _walls)
                s += $"{w.ToString()}{Environment.NewLine}";

            foreach (var r in _roofs)
                s += $"{r.ToString()}{Environment.NewLine}";

            return $"Wood house with: {Environment.NewLine}{s}";
        }
    }
}
