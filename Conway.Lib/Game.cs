using System;

namespace Conway.Lib {
    public class Game {
        private Cell[, ] board;

        public Game(int height, int width) {
            board = new Cell[height, width];
            Initialize();
        }

        private void Initialize() {
            for (int i = 0; i < board.GetLength(0); i++) {
                for (int j = 0; j < board.GetLength(1); j++) {
                    board[i, j] = new Cell();
                }
            }
        }

        public void SetCell(int row, int column, bool value) {
            board[row, column].IsAlive = value;
        }

        public Cell[, ] GetStatus() {
            return board;
        }
    }
}