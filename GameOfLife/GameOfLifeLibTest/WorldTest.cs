using System;
using Xunit;
using GameOfLifeLib;
using System.Linq;
using System.Collections.Generic;

namespace GameOfLifeLibTest
{
    public class WorldTest
    {

        public static IEnumerable<object[]> ¢ŠE‚ÌL‚³ { get; } = Enumerable.Range(1, sbyte.MaxValue).SelectMany(_ => Enumerable.Range(1, sbyte.MaxValue), (x, y) => new object[] { x, y });
        [Theory]
        [MemberData(nameof(¢ŠE‚ÌL‚³))]
        [InlineData(data: new object[] { 1000, 1000 })]
        public void ”CˆÓ‚ÌL‚³‚Ì¢ŠE‚ğì‚é–‚ª‚Å‚«‚é(int x, int y)
        {
            var world = new World(x, y);
            Assert.DoesNotContain(world.State.AsParallel(), states => states.Any(state => state));
        }

        public static IEnumerable<object[]> ¬—§o—ˆ‚È‚¢¢ŠE‚ÌL‚³ { get; } = Enumerable.Range(-25, 50).SelectMany(x => x >= 0 ? Enumerable.Range(-25, 26) : Enumerable.Range(1, 24), (x, y) => new object[] { x, y });
        [Theory]
        [MemberData(nameof(¬—§o—ˆ‚È‚¢¢ŠE‚ÌL‚³))]
        public void ¢ŠE‚Ìc‚Æ‰¡‚ÍÅ’á1ˆÈã‚ ‚é(int x, int y)
            => Assert.Throws<ArgumentOutOfRangeException>(() => new World(x, y));

        [Fact]
        public void ¢ŠE‚Ì¶¬‚É¶‚«‚Ä‚¢‚éƒZƒ‹‚ğİ’è‚Å‚«‚é()
        {
            /* ‚±‚ñ‚È¢ŠE‚ğì‚è‚½‚¢
             *      
             *  ¡¡¡ 
             *      
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
