using System;
using System.Collections.Generic;
using System.Linq;

namespace Conway.Lib {
    public static class Rules {
        public static bool ShouldBeAlive(Coordinates coordinates, Game game) {
            List<Cell> neighbors = game.GetNeighbors(coordinates).ToList();
            if (neighbors.Count() == 3 ||
                (neighbors.Count() == 2 && game.HasLife(coordinates)))
                return true;

            return false;
        }

    }
}