using Conway.Lib;
using FluentAssertions;
using Xunit;

namespace Conway.Tests {
    public class RulesTests {
        [Theory]
        [InlineData(0, 0, false)]
        [InlineData(0, 1, true)]
        [InlineData(0, 2, false)] // x x x
        [InlineData(1, 0, false)] // o o o
        [InlineData(1, 1, true)] // o o o
        [InlineData(1, 2, false)]
        [InlineData(2, 0, false)] // o x o
        [InlineData(2, 1, false)] // o x o
        [InlineData(2, 2, false)] // o o o
        public void ShouldBeAlive_3x3(int row, int column, bool expected) {
            Game game = new Game(3, 3);
            game.SetCell(new Coordinates(0, 0), true);
            game.SetCell(new Coordinates(0, 1), true);
            game.SetCell(new Coordinates(0, 2), true);

            Coordinates coordinates = new Coordinates(row, column);
            Rules.ShouldBeAlive(coordinates, game).Should().Be(expected);
        }
    }
}