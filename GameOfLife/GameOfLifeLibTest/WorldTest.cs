using System;
using Xunit;
using GameOfLifeLib;

namespace GameOfLifeLibTest
{
    public class WorldTest
    {
        [Fact]
        public void ”CˆÓ‚ÌL‚³‚Ì¢ŠE‚ğì‚é–‚ª‚Å‚«‚é()
        {
            var world = new World(10, 10);
            Assert.Equal(10 * 10, world.State.Count());
        }
    }
}
