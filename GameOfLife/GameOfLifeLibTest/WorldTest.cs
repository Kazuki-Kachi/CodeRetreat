using System;
using Xunit;
using GameOfLifeLib;

namespace GameOfLifeLibTest
{
    public class WorldTest
    {
        [Fact]
        public void �C�ӂ̍L���̐��E����鎖���ł���()
        {
            var world = new World(10, 10);
            Assert.Equal(10 * 10, world.State.Count());
        }
    }
}
