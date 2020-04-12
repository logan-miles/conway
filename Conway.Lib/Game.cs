using System;

namespace Conway.Lib {
    public class Game {
        private Cell[, ] board;

        public Game(int height, int width) {
            board = new Cell[height, width];
        }
    }
}