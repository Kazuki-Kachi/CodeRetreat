using System;
using Xunit;
using GameOfLifeLib;
using System.Linq;
using System.Collections.Generic;

namespace GameOfLifeLibTest
{
    public class WorldTest
    {

        public static IEnumerable<object[]> ���E�̍L�� { get; } = Enumerable.Range(1, sbyte.MaxValue).SelectMany(_ => Enumerable.Range(1, sbyte.MaxValue), (x, y) => new object[] { x, y });
        [Theory]
        [MemberData(nameof(���E�̍L��))]
        [InlineData(data: new object[] { 1000, 1000 })]
        public void �C�ӂ̍L���̐��E����鎖���ł���(int x, int y)
        {
            var world = new World(x, y);
            Assert.DoesNotContain(world.State.AsParallel(), states => states.Any(state => state));
        }

        public static IEnumerable<object[]> �����o���Ȃ����E�̍L�� { get; } = Enumerable.Range(-25, 50).SelectMany(x => x >= 0 ? Enumerable.Range(-25, 26) : Enumerable.Range(1, 24), (x, y) => new object[] { x, y });
        [Theory]
        [MemberData(nameof(�����o���Ȃ����E�̍L��))]
        public void ���E�̏c�Ɖ��͍Œ�1�ȏ゠��(int x, int y)
            => Assert.Throws<ArgumentOutOfRangeException>(() => new World(x, y));
    }
}
