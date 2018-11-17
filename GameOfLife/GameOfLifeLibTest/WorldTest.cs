using System;
using Xunit;
using GameOfLifeLib;
using System.Linq;
using System.Collections.Generic;

namespace GameOfLifeLibTest
{
    public class WorldTest
    {

        public static IEnumerable<object[]> hoge => Enumerable.Range(1, short.MaxValue).Zip(Enumerable.Range(1, short.MaxValue), (x, y) => new object[] { x, y });

        [Theory]
        [MemberData(nameof(hoge))]
        public void 任意の広さの世界を作る事ができる(int x,int y)
        {
            var world = new World(x, y);
            Assert.Equal(x * y, world.State.Count());
        }
    }
}
