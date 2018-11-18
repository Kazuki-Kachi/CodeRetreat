using System.Collections.Generic;
using System.Linq;

namespace GameOfLifeLib
{
    public class World
    {
        private int x;
        private int y;

        public World(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public IEnumerable<IEnumerable<bool>> State => Enumerable.Range(0, y).Select(_ => Enumerable.Range(0, x).Select(__ => false));
    }
}