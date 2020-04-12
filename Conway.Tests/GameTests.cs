using System;
using Conway.Lib;
using FluentAssertions;
using Xunit;

namespace Conway.Tests {
    public class GameTests {
        [Fact]
        public void SetCell_True_ShouldBeAlive() {
            Game g = new Game(1, 1);
            g.GetStatus()[0, 0].IsAlive.Should().Be(false);
            g.SetCell(0, 0, true);
            g.GetStatus()[0, 0].IsAlive.Should().Be(true);
        }
    }
}