using System;
using Xunit;
using GameOfLifeLib;
using System.Linq;
using System.Collections.Generic;

namespace GameOfLifeLibTest
{
    public class WorldTest
    {

        public static IEnumerable<object[]> hoge => Enumerable.Range(1, sbyte.MaxValue).Zip(Enumerable.Range(1, sbyte.MaxValue), (x, y) => new object[] { x, y });

        [Theory]
        [MemberData(nameof(hoge))]
        public void ”CˆÓ‚ÌL‚³‚Ì¢ŠE‚ðì‚éŽ–‚ª‚Å‚«‚é(int x,int y)
        {
            var world = new World(x, y);
            Assert.DoesNotContain(world.State, states => states.Any(state => state));
        }
    }
}
