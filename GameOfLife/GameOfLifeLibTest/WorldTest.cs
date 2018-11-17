using System;
using Xunit;
using GameOfLifeLib;

namespace GameOfLifeLibTest
{
    public class WorldTest
    {
        [Fact]
        public void 任意の広さの世界を作る事ができる()
        {
            var world = new World(10, 10);
            Assert.Equal(10 * 10, world.State.Count());
        }
    }
}
