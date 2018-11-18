using System;
using Xunit;
using GameOfLifeLib;
using System.Linq;
using System.Collections.Generic;

namespace GameOfLifeLibTest
{
    public class WorldTest
    {

        public static IEnumerable<object[]> 世界の広さ { get; } = Enumerable.Range(1, sbyte.MaxValue).SelectMany(_ => Enumerable.Range(1, sbyte.MaxValue), (x, y) => new object[] { x, y });
        [Theory]
        [MemberData(nameof(世界の広さ))]
        [InlineData(data: new object[] { 1000, 1000 })]
        public void 任意の広さの世界を作る事ができる(int x, int y)
        {
            var world = new World(x, y);
            Assert.DoesNotContain(world.State.AsParallel(), states => states.Any(state => state));
        }

        public static IEnumerable<object[]> 成立出来ない世界の広さ { get; } = Enumerable.Range(-25, 50).SelectMany(x => x >= 0 ? Enumerable.Range(-25, 26) : Enumerable.Range(1, 24), (x, y) => new object[] { x, y });
        [Theory]
        [MemberData(nameof(成立出来ない世界の広さ))]
        public void 世界の縦と横は最低1以上ある(int x, int y)
            => Assert.Throws<ArgumentOutOfRangeException>(() => new World(x, y));

        [Fact]
        public void 世界の生成時に生きているセルを設定できる()
        {
            /* こんな世界を作りたい
             * □□□□□
             * □■■■□
             * □□□□□
             */
            var world = new World(5, 3, (1, 1), (2, 1), (3, 1));
            Assert.True(world.State.SequenceEqual(
                new[] {
                    new[] { false,false,false,false,false },
                    new[] { false,true,true,true,false },
                    new[] { false,false,false,false,false },
            }));
        }

    }
}
